﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPruebaBanderas.Models
{
    public class Country
    {
        [Key]
        public string name { get; set; }
        public List<string> topLevelDomain { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Error", MinimumLength = 2)]
        public string alpha2Code { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Error", MinimumLength = 3)]
        public string alpha3Code { get; set; }
        public List<string> callingCodes { get; set; }
        [Required]
        public string capital { get; set; }
        public List<string> altSpellings { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        [Required]
        public int population { get; set; }
        [Required]
        public List<double> latlng { get; set; }
        public string demonym { get; set; }
        [Required]
        public double area { get; set; }
        public double gini { get; set; }
        public List<string> timezones { get; set; }
        public List<string> borders { get; set; }
        public string nativeName { get; set; }
        public string numericCode { get; set; }
        public List<Currency> currencies { get; set; }
        public List<Language> languages { get; set; }
        public Translations translations { get; set; }
        public string flag { get; set; }
        public List<RegionalBloc> regionalBlocs { get; set; }
        public string cioc { get; set; }
    }
}