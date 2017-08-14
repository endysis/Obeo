 <?php

// Databast connection information
$host = "localhost";
$user = "root";
$pwd  = "ripley";
$db   = "Obeo";

//Connect to the database
try {
    $conn = new PDO("mysql:host=$host;dbname=$db", $user, $pwd);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
}
catch (Exception $e) {
    die(var_dump($e));
}

if ($_SERVER['REQUEST_METHOD'] == "GET") {
    // Queries
    $format    = isset($_GET['format']) && strtolower($_GET['format']) == 'html' ? "html" : "json";
    $data_name = isset($_GET['dataname']);
    if ($data_name) {
        $data_name = str_replace("-", ",", strtoupper($_GET['dataname']));
    } else {
        $data_name = "*";
    }
    $number_of_journeys = isset($_GET['num']) ? intval($_GET['num']) : 1000;
    $order              = isset($_GET['order']) && strtolower($_GET['order']) == 'dec' ? 'DESC' : 'ASC';
    $order_by           = isset($_GET['orderby']) ? strtoupper($_GET['orderby']) : 'ORIGIN';
    
    
    $counter    = 1;
    $sql_select = "SELECT $data_name FROM `Journeys` ORDER BY $order_by $order LIMIT $number_of_journeys";
    $stmt       = $conn->query($sql_select);
    $journeys   = $stmt->fetchAll();
    
    
    if ($format == 'json') {
        $stmt->execute();
        $array = $stmt->fetchAll(PDO::FETCH_ASSOC);
        header('Content-type: application/json');
        echo json_encode(array('Journeys' => $array));
    }
    
    else {
        $allColumns = "ORIGIN,DESTINATION,DISTANCE,DURATION,MODE";
        if ($data_name == "*") {
            $data_name = $allColumns;
        }
        // Extract data requests from 'data_name' query string and place in an array
        $tableHeaders = array();
        $data_name    = $data_name . ",";
        $stringLength = strlen($data_name);
        for ($x = 0; $x < $stringLength; $x++) {
            if ($data_name[$x] == ",") {
                array_push($tableHeaders, substr($data_name, 0, $x));
                $data_name    = substr($data_name, ($x + 1), $stringLength);
                $stringLength = strlen($data_name);
                $x            = 0;
            }
            if ($stringLength == 0) {
                break;
            }
        }
        
        if (count($journeys) > 0) {
?>
<html>
 <head>
 </head>
 <body>
   <div class="tbl-header">
    <table cellpadding="0" cellspacing="0" border="0">
      <thead>
      <tr>
        <?php
            for ($i = 0; $i < count($tableHeaders); $i++) {
?><th><?php
                echo $tableHeaders[$i];
?></th><?php
            }
?>
  </tr>
      </thead>
    </table>
  </div>

  <div class="tbl-content">
    <table cellpadding="0" cellspacing="0" border="0">
      <tbody class = "tbl-body">
        <?php
            foreach ($journeys as $journey) {
?>
          <tr> 
          <?php
                for ($i = 0; $i < count($tableHeaders); $i++) {
?><td><?php
                    echo $journey[$tableHeaders[$i]];
?></td>
          <?php
                }
?>
          </tr>
            <?php
            }
?>
      </tr>
      </tbody>
    </table>
  </div>    
   </body>
 </html>      
    <?php
            $counter++;
        } else {
            echo "<h3>No car is currently registered.</h3>";
        }
    }
} else if ($_SERVER['REQUEST_METHOD'] == "POST" && !empty($_POST)) {
    try {
        $journey_origin = $_POST['journey_origin'];
        $journey_destination = $_POST['journey_destination'];
        $journey_distance = $_POST['journey_distance'];
        $journey_duration = $_POST['journey_duration'];
        $journey_mode = $_POST['journey_mode'];

        
        $sql_insert = "INSERT INTO `Journeys` (`ORIGIN`, `DESTINATION`,`DISTANCE`,`DURATION`,`MODE`)
                         VALUES (?,?,?,?,?)";
        
        $stmt = $conn->prepare($sql_insert);
        $stmt->bindValue(1, $journey_origin);
        $stmt->bindValue(2, $journey_destination);
        $stmt->bindValue(3, $journey_distance);
        $stmt->bindValue(4, $journey_duration);
        $stmt->bindValue(5, $journey_mode);
        $stmt->execute();
        
    }
    catch (Exception $e) {
        die(var_dump($e));
    }
    echo "<h3> Data Sent </h3>";
    
} else {
    http_response_code(405);
}
?> 