using CloudProvider.Api.ViewModels.GoogleViewModels;
using CloudProviderLibrary.CloudServiceProviders.Abstractions;
using CloudProviderLibrary.Enums;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CloudProvider.Api.Controllers
{
    public class GoogleProviderController : BaseController
    {
        public GoogleProviderController(Func<CloudServiceProvidersEnum, ICloudServiceProvider> serviceResolver) : base(serviceResolver(CloudServiceProvidersEnum.Google))
        {

        }

        [HttpPost("createGoogle")]
        public ActionResult CreateGoogle(CreateGoogleViewModel model)
        {
            return CreateServiceProvider(model.ToCreateCloudServiceProviderModel());
        }

        [HttpDelete("deleteGoogle")]
        public ActionResult DeleteGoogle(DeleteGoogleViewModel model)
        {
            return DeleteServiceProvider(model.ToDeleteCloudServiceProviderModel());
        }
    }
}
