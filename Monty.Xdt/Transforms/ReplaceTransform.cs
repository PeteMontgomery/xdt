﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monty.Xdt.Transforms
{
    public class ReplaceTransform : Transform
    {
        public override void Apply()
        {
            if (this.Arguments.Any())
                throw new InvalidOperationException("Arguments to the Replace transform are not supported.");

            foreach (var e in this.GetTargetElements())
            {
                e.ReplaceWith(this.TransformElement);
            }
        }
    }
}
