using CloudProvider.Api.ViewModels.IGSViewModels;
using CloudProviderLibrary.CloudServiceProviders.Abstractions;
using CloudProviderLibrary.Enums;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CloudProvider.Api.Controllers
{
    public class IGSProviderController : BaseController
    {
        public IGSProviderController(Func<CloudServiceProvidersEnum, ICloudServiceProvider> serviceResolver) : base(serviceResolver(CloudServiceProvidersEnum.IGS))
        {

        }

        [HttpPost("createIGS")]
        public ActionResult CreateIGS(CreateIGSViewModel model)
        {
            return CreateServiceProvider(model.ToCreateCloudServiceProviderModel());
        }

        [HttpDelete("deleteIGS")]
        public ActionResult DeleteIGS(DeleteIGSViewModel model)
        {
            return DeleteServiceProvider(model.ToDeleteCloudServiceProviderModel());
        }
    }
}
