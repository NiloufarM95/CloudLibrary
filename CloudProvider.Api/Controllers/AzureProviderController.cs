using CloudProvider.Api.ViewModels.AzureViewModels;
using CloudProviderLibrary.CloudServiceProviders.Abstractions;
using CloudProviderLibrary.Enums;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CloudProvider.Api.Controllers
{
    public class AzureProviderController : BaseController
    {
        public AzureProviderController(Func<CloudServiceProvidersEnum, ICloudServiceProvider> serviceResolver) : base(serviceResolver(CloudServiceProvidersEnum.Azure))
        {

        }

        [HttpPost("createAzure")]
        public ActionResult CreateAzure(CreateAzureViewModel model)
        {
            return CreateServiceProvider(model.ToCreateCloudServiceProviderModel());
        }

        [HttpDelete("deleteAzure")]
        public ActionResult DeleteAzure(DeleteAzureViewModel model)
        {
            return DeleteServiceProvider(model.ToDeleteCloudServiceProviderModel());
        }
    }
}
