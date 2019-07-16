using FluentValidation;
using GasStationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationProject.Validations
{
    public class UserLoginValidator: AbstractValidator<UserLoginVM>
    {
        public UserLoginValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(Resources.Resource.E0011);
            RuleFor(x => x.Password).NotEmpty().WithMessage(Resources.Resource.E0012);
        }
    }
}