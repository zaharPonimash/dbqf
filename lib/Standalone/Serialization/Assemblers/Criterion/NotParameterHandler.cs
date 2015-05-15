﻿using dbqf.Criterion;
using Standalone.Serialization.DTO.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standalone.Serialization.Assemblers.Criterion
{
    public class NotParameterHandler : TransformHandler
    {
        // need a reference to the chain of responsibility that this TransformHandler is part of to restore the contained parameter
        public TransformHandler Chain { get; set; }
        public NotParameterHandler(TransformHandler successor)
            : base(successor)
        {
        }

        public override dbqf.Criterion.IParameter Restore(DTO.Criterion.ParameterDTO dto)
        {
            var np = dto as NotParameterDTO;
            if (np == null)
                return base.Restore(dto);

            return new NotParameter(Chain.Restore(np.Parameter));
        }

        public override DTO.Criterion.ParameterDTO Create(dbqf.Criterion.IParameter p)
        {
            var np = p as NotParameter;
            if (np == null)
                return base.Create(p);

            return new NotParameterDTO() { Parameter = Chain.Create(np.Parameter) };
        }
    }
}
