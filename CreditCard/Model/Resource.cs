﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CreditCard.Model
{
    public class Resource
    {
        [JsonProperty(Order = 2)]
        public string Href { get; set; }
                     
    }
}