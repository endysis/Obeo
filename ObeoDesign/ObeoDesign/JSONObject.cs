using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObeoDesign
{
    public class Distance
    {
        public string text { get; set; }
        public int value { get; set; }
    }

    public class Duration
    {
        public string text { get; set; } 
        public int value { get; set; }
    }

    public class Element
    {
        public Distance distance { get; set; }
        public Duration duration { get; set; }
        public string status { get; set; }
    }

    public class Row
    {
        public List<Element> elements { get; set; }
    }

    public class JSONObject
    {
        public List<string> destination_addresses { get; set; }
        public List<string> origin_addresses { get; set; }
        public List<Row> rows { get; set; }
        public string status { get; set; }
    }

    public class Journey
    {
        public string JOURNEY_ID { get; set; }
        public string ORIGIN { get; set; }
        public string DESTINATION { get; set; }
        public string DISTANCE { get; set; }
        public string DURATION { get; set; }
        public string MODE { get; set; }
    }

    public class RootObjectJourney
    {
        public List<Journey> Journeys { get; set; }
    }
}