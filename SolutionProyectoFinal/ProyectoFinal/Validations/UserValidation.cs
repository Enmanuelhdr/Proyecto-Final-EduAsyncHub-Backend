﻿using FluentValidation;
using static ProyectoFinal.DTOs.UsuarioDTO;

namespace ProyectoFinal.Validations
{
    public class RegisterUserValidator : AbstractValidator<RegisterUserRequestDto>
    {
        public RegisterUserValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().Length(1, 100);
            RuleFor(x => x.CorreoElectronico).NotEmpty().EmailAddress();
            RuleFor(x => x.Contraseña).NotEmpty().MinimumLength(8);
            RuleFor(x => x.RolID).InclusiveBetween(1, 3);

        }
    }

    public class LoginUserValidator : AbstractValidator<LoginUserRequestDto>
    {
        public LoginUserValidator()
        {
            RuleFor(x => x.CorreoElectronico).NotEmpty().EmailAddress();
            RuleFor(x => x.Contraseña).NotEmpty().MinimumLength(8);
        }
    }

    public class UpdateUserValidator : AbstractValidator<UpdateUserRequestDto>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.UsuarioID).NotEmpty();
            RuleFor(x => x.Nombre).NotEmpty().Length(1, 100);
            RuleFor(x => x.CorreoElectronico).NotEmpty().EmailAddress();
            RuleFor(x => x.Contraseña).NotEmpty().MinimumLength(8);
            RuleFor(x => x.RolID).InclusiveBetween(1, 3);
        }
    }

    public class DeleteUserValidator : AbstractValidator<DeleteUserRequestDto>
    {
        public DeleteUserValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }

    public class UpdateProfileValidator : AbstractValidator<UpdateProfileRequestDto>
    {
        public UpdateProfileValidator()
        {
            RuleFor(x => x.UsuarioID).NotEmpty();
            RuleFor(x => x.Nombre).NotEmpty().Length(1, 100);
            RuleFor(x => x.CorreoElectronico).NotEmpty().EmailAddress();
            RuleFor(x => x.Contraseña).NotEmpty().MinimumLength(8);
        }
    }
}
