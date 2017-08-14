# Obeo Project

This repository consists of a C#.Net Windows Forms Application, which is a basic concept for a group travel app. The idea behind Obeo is to bind all holiday information in one place, which makes for easy reference when wanting to find important details about your trip.
Obeo utilises the Google Distance API to retrieve data based on origin and end point destinations.
The application also sends the data through a REST API via POST request and outputs the content to a HTML page. A GET request can have various parameters and is available for output in JSON or HTML. Database management is facilitated using MySQL. This functionality will eventually be enhanced, so each user can have thier own Obeo profile, with their saved holiday destinations.
Please bear in this only a rough concept and further development will be amended to enable a fluid and efficient experience.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine.

### Prerequisites

What things you need to run the software

```
Visual Studio // (I use Eclipse)
XAMPP (If you want to run Web server and MySQL DB locally)
Metro Framework // (UI Design Library)

```

### Running The application

The .cs files can be located with the following path

```
\ObeoDesign\ObeoDesign
```

On running the project a menu is presented with the following options.

```
[1] Plan your Route
[2] Plan your Accomodation
[3] View Holiday Members
[4] Saved Routes
```

Please not the only fucntional tiles are ...

```
[1] Plan your Route
[4] Saved Routes

```

On Clicking...

```
[1] Plan your Route

```

... one is presented with multiple options to tailor the journey route.

By clicking...
```
[1] Plan your Route / Query Route 

```
... the inputed data will be be used to send a GET request to the Google Distance API.

By clicking ...
```
[4] Saved Routes

```
The application sends a GET request to my custom "journeys" API.

The php page is located at the following address.

```
http://www.endy.co.uk/journeys.php
```

## API Parameters

Journey data sent from the application are stored a MySQL database.

For online GET requests use the following address

```
http://www.endy.co.uk/journeys.php
```

Below shows the consequence of each parameter

|Parameter|Possible Values|Description| 
|--|--|--| 
|dataname|origin, destination, distance, duration, mode|Select the datatype/types to output. For multiple datatypes, separate each word with a "-"| 
|orderby|origin, destination, distance, duration, mode|Order by a certain type| 
|order|asc,dec|Present the information in ascending or descending order| 
|num|0 - inf|Specify the number of records to output| 
|format|json,html|Specify the output format| 

For example the following GET request...

```
http://www.endy.co.uk/journeys.php?dataname=origin-duration&orderby=origin&order=dec
```

...would output all corresponding 'Origin' and 'Duration' data in decending order.

## Demonstration

The video below displays the functionality of this project.

[![Video Demonstration](https://media.licdn.com/mpr/mpr/shrink_200_200/AAEAAQAAAAAAAAX9AAAAJDhkZTcwNDAxLTEzY2MtNDlhYi1iODY0LTdkMDgyZDU2MTczMg.png)](https://www.youtube.com/watch?v=f-3nleMkGuo "Video Demonstration")

## Built With

* [Microsoft Visual Studio](https://www.visualstudio.com/) - IDE used
* [Xammp](https://www.apachefriends.org/index.html) - Web testing
* [Paw](https://paw.cloud/) - API testing
* [Json.NET](http://www.newtonsoft.com/json) - JSON Decoding

## Authors

* **O'Shea Douglas** - *Initial work* - [ÉNDY](https://github.com/endysis)

