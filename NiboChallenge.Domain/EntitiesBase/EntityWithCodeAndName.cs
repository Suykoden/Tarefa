﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiboChallenge.Domain.EntitiesBase
{
    public class EntityWithCodeAndName : EntityWithCode
    {
        public string Name { get; set; }
    }
}
