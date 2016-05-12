using System;
using System.Collections.Generic;

namespace VR.Models
{
    public partial class freeZipcodeDb
    {
        public Nullable<double> Zipcode { get; set; }
        public string ZipCodeType { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string LocationType { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Long { get; set; }
        public string Location { get; set; }
        public bool Decommisioned { get; set; }
        public string TaxReturnsFiled { get; set; }
        public string EstimatedPopulation { get; set; }
        public string TotalWages { get; set; }
    }
}
