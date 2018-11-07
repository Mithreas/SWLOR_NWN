﻿using FluentValidation;
using SWLOR.Game.Server.Data.Contracts;
using SWLOR.Game.Server.Data.Entity;
using SWLOR.Game.Server.Data.Validator;
using SWLOR.Game.Server.Service.Contracts;
using SWLOR.Game.Server.ValueObject;

namespace SWLOR.Game.Server.Data.Processor
{
    public class BaseStructureProcessor : IDataProcessor<BaseStructure>
    {
        public IValidator Validator => new BaseStructureValidator();

        public DatabaseAction Process(IDataService data, BaseStructure dataObject)
        {
            return null;
        }
    }
}