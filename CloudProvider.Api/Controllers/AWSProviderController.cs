using CloudProvider.Api.ViewModels.AWSViewModels;
using CloudProviderLibrary.CloudServiceProviders.Abstractions;
using CloudProviderLibrary.Enums;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CloudProvider.Api.Controllers
{
    public class AWSProviderController : BaseController
    {
        public AWSProviderController(Func<CloudServiceProvidersEnum, ICloudServiceProvider> serviceResolver) : base(serviceResolver(CloudServiceProvidersEnum.AWS))
        {

        }

        [HttpPost("createAWS")]
        public ActionResult CreateAWS(CreateAWSViewModel model)
        {
            return CreateServiceProvider(model.ToCreateCloudServiceProviderModel());

        }

        [HttpDelete("deleteAWS")]
        public ActionResult DeleteAWS(DeleteAWSViewModel model)
        {
            return DeleteServiceProvider(model.ToDeleteCloudServiceProviderModel());
        }

    }
}
