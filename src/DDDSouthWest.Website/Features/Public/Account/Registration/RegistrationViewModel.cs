﻿using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace DDDSouthWest.Website.Features.Public.Account.Registration
{
    public class RegistrationViewModel
    {
        public RegistrationViewModel()
        {
            Errors = new List<ValidationFailure>();
        }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public IList<ValidationFailure> Errors { get; set; }

        public bool HasErrors => Errors.Any();
    }
}