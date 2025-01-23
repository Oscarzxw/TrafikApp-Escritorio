using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TrafikApp.Model
{
    internal class Incidencia
    {
        public int id {  get; set; }
        public string incidenceId{ get; set; }
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
         
        public Incidencia() { }
        public Incidencia(string incidenceId, int sourceId, string incidenceType, string autonomousRegion, string province,
                          string carRegistration, string cause, string cityTown, string startDate, string road, string pkStart,
                          string pkEnd, string direction, double latitude, double longitude, Boolean creada, Source source)
        {
            this.incidenceId = incidenceId;
            this.sourceId = sourceId;
            this.incidenceType = incidenceType;
            this.autonomousRegion = autonomousRegion;
            this.province = province;
            this.carRegistration = carRegistration;
            this.cause = cause;
            this.cityTown = cityTown;
            this.startDate = startDate;
            this.road = road;
            this.pkStart = pkStart;
            this.pkEnd = pkEnd;
            this.direction = direction;
            this.latitude = latitude;
            this.longitude = longitude;
            this.creada = creada;
            this.source = source;
        }

        public Incidencia(int sourceId, string incidenceType, string province, string cause, string cityTown, string startDate, string road, double latitude, double longitude, Boolean creada)
        {
            this.sourceId = sourceId;
            this.incidenceType = incidenceType;
            this.autonomousRegion = "Euskadi";
            this.province = province;
            this.carRegistration = "";
            this.cause = cause;
            this.cityTown = cityTown;
            this.startDate = startDate;
            this.road = road;
            this.pkStart = "";
            this.pkEnd = "";
            this.direction = "";
            this.latitude = latitude;
            this.longitude = longitude;
            this.creada = creada;
            this.source = null;
        }

        public Incidencia(string incidenceId)
        {
            this.incidenceId = incidenceId;
            this.sourceId = 0;
            this.incidenceType = "";
            this.autonomousRegion = "";
            this.province = "";
            this.carRegistration = "";
            this.cause = "";
            this.cityTown = "";
            this.startDate = "";
            this.road = "";
            this.pkStart = "";
            this.pkEnd = "";
            this.direction = "";
            this.latitude = 0.1;
            this.longitude = 0.1;
            this.creada = true;
            this.source = null;
        }


    }
}
