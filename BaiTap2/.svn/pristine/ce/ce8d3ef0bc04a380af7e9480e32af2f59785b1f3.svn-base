using FluentValidation.Internal;
using FluentValidation.Mvc;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StructureMap
{
    public class RemoteFluentValidationPropertyValidator :
                 FluentValidationPropertyValidator
    {
        private RemoteValidator RemoteValidator
        {
            get { return (RemoteValidator)Validator; }
        }

        public RemoteFluentValidationPropertyValidator(ModelMetadata metadata,
                                                       ControllerContext controllerContext,
                                                       PropertyRule propertyDescription,
                                                       IPropertyValidator validator)
              : base(metadata, controllerContext, propertyDescription, validator)
        {
            ShouldValidate = false;
        }

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
        {
            if (!ShouldGenerateClientSideRules()) yield break;

            var formatter = new MessageFormatter().AppendPropertyName(Rule.PropertyName);
            string message = formatter.BuildMessage(RemoteValidator.Options.ErrorMessageSource.ToString());

            //This is the rule that asp.net mvc 3, uses for Remote attribute. 
            yield return new ModelClientValidationRemoteRule(message, RemoteValidator.Url, RemoteValidator.HttpMethod, RemoteValidator.AdditionalFields);
        }
    }
}