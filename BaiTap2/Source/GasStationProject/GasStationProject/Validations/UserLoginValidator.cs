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
            RuleFor(x => x.Email).NotEmpty().WithMessage("Địa chỉ Email không được trống.").MaximumLength(100).WithMessage("Tên đăng nhập không được quá 100 kí tự.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Mật khẩu không được để trống.");
        }
    }
}