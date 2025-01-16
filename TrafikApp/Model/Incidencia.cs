using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikApp.Model
{
    internal class Incidencia
    {
        public int id { get; set; }
        public int incidenceId{ get; set; }
        public int sourceId{ get; set; }
        public string incidenceType { get; set; }
        public string autonomousRegion { get; set; }
        public string province { get; set; }
        public string carRegistration { get; set; }
        public string cause { get; set; }
        public string cityTown { get; set; }
        public string startDate { get; set; }
        public string road { get; set; }
        public string pkStart { get; set; }
        public string pkEnd { get; set; }
        public string direction { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public Boolean creada { get; set; }
        public Source source { get; set; }


   

    }
}
