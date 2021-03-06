﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiboChallenge.Domain.EntitiesBase;

namespace NiboChallenge.Domain.Entities
{
    public class Tournament : EntityWithName
    {
        public DateTime RegisterDateTime { get; set; }
        public bool Active { get; set; }
        public string Status { get; set; }
    }
}
