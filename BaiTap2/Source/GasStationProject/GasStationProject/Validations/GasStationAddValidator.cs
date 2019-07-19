using FluentValidation;
using GasStationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace GasStationProject.Validations
{
    public class GasStationAddValidator : AbstractValidator<GasStationAddVM>
    {
        public GasStationAddValidator()
        {
            RuleFor(x => x.GasStationName).NotEmpty().WithMessage(Resources.Resource.E0001).MaximumLength(100).WithMessage(Resources.Resource.E0004);
            RuleFor(x => x.Longitude).NotEmpty().WithMessage(Resources.Resource.E0001);
            RuleFor(x => x.Latitude).NotEmpty().WithMessage(Resources.Resource.E0001);
            RuleFor(x => x.Gatype).NotEmpty().WithMessage(Resources.Resource.E0001);
            RuleFor(x=>x.Rating).NotEmpty().WithMessage(Resources.Resource.E0001);
            RuleFor(x=>x.Address).NotEmpty().WithMessage(Resources.Resource.E0001).MaximumLength(250).WithMessage(Resources.Resource.E0004);
            RuleFor(x => x.OpeningTime).MaximumLength(50).WithMessage(Resources.Resource.E0004);
            RuleFor(x=>x.District).NotEmpty().WithMessage(Resources.Resource.E0001);

        }


    }
}