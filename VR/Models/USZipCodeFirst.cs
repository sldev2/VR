using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class USZipCodeFirst
    {
        public string ZipCode { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public System.Data.Entity.Spatial.DbGeography GeoPoint { get; set; }
    }
}
