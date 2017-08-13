using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObeoDesign
{
    class Route
    {
       private String _origin;
       private String _destination;
       private String _distance;
       private String _duration;
       private String _mode;

        public String Origin { get { return _origin;} set { _origin = value; } }
        public String Destination { get { return _destination; } set { _destination = value; } }
        public String Distance { get { return _distance; } set { _distance = value; } }
        public String Duration { get { return _duration; } set { _duration = value; } }
        public String Mode { get { return _mode; } set { _mode = value; } }
    }
}
