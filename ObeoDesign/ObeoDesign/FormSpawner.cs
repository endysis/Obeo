using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObeoDesign
{
    class FormSpawner
    {
        private static Form1 _Home;
        private static Form2 _Route;
        private static Form3 _RouteResults;
        private static Form4 _SavedPage;
        private static String _urlResponse = "N/A";
        private static String _mode = "N/A";

        public static Form1 Home {
            get {
                if (_Home == null) {
                    _Home = new Form1();
                }
                return _Home;
            }
        }

        public static Form2 Route
        {
            get
            {
                if (_Route == null)
                {
                    _Route = new Form2();
                }
                return _Route;
            }
        }
        public static Form3 RouteResults
        {
            get
            {
                if (_RouteResults == null)
                {
                    _RouteResults = new Form3();
                }
                return _RouteResults;
            }
        }
        public static Form4 SavedPage
        {
            get
            {
                if (_SavedPage == null)
                {
                    _SavedPage = new Form4();
                }
                return _SavedPage;
            }
        }

        public static String urlResponse {
            get {
                return _urlResponse;
            }
            set {
                if(_urlResponse == null) {
                    _urlResponse = "";
                }
                _urlResponse = value;
            }
        }

        public static String mode {
            get {
                return _mode;
            }
            set {
                _mode = value;
            }
        }
    }
}
