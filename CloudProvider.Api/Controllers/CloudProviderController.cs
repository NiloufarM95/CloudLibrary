using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudProvider.Api.ViewModels.AWSViewModels;
using CloudProvider.Api.ViewModels.AzureViewModels;
using CloudProvider.Api.ViewModels.GoogleViewModels;
using CloudProvider.Api.ViewModels.IGSViewModels;
using CloudProviderLibrary.CloudServiceProviders.Abstractions;
using CloudProviderLibrary.Enums;

namespace CloudProvider.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CloudProviderController : ControllerBase
    {
        private readonly ICloudServiceProvider _igsServiceProvider;
        private readonly ICloudServiceProvider _awsServiceProvider;
        private readonly ICloudServiceProvider _googleServiceProvider;
        private readonly ICloudServiceProvider _azureServiceProvider;

        public CloudProviderController(Func<CloudServiceProvidersEnum, ICloudServiceProvider> serviceResolver)
        {
            _igsServiceProvider = serviceResolver(CloudServiceProvidersEnum.IGS);
            _awsServiceProvider = serviceResolver(CloudServiceProvidersEnum.AWS);
            _googleServiceProvider = serviceResolver(CloudServiceProvidersEnum.Google);
            _azureServiceProvider = serviceResolver(CloudServiceProvidersEnum.Azure);
        }

        #region IGS

        [HttpPost("createIGS")]
        public ActionResult CreateIGS(CreateIGSViewModel model)
        {
            try
            {
                _igsServiceProvider.CreateCloudInfrastructure(new CreateIGSViewModel().ToModel(model));

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deleteIGS")]
        public ActionResult DeleteIGS(DeleteIGSViewModel model)
        {
            try
            {
                _igsServiceProvider.DeleteCloudInfrastructure(new DeleteIGSViewModel().ToModel(model));

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

        #region AWS

        [HttpPost("createAWS")]
        public ActionResult CreateAWS(CreateAWSViewModel model)
        {
            try
            {
                _awsServiceProvider.CreateCloudInfrastructure(new CreateAWSViewModel().ToModel(model));

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deleteAWS")]
        public ActionResult DeleteAWS(DeleteAWSViewModel model)
        {
            try
            {
                _awsServiceProvider.DeleteCloudInfrastructure(new DeleteAWSViewModel().ToModel(model));

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

        #region Azure

        [HttpPost("createAzure")]
        public ActionResult CreateAzure(CreateAzureViewModel model)
        {
            try
            {
                _azureServiceProvider.CreateCloudInfrastructure(new CreateAzureViewModel().ToModel(model));

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deleteAzure")]
        public ActionResult DeleteAzure(DeleteAzureViewModel model)
        {
            try
            {
                _azureServiceProvider.DeleteCloudInfrastructure(new DeleteAzureViewModel().ToModel(model));

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

        #region Google

        [HttpPost("createGoogle")]
        public ActionResult CreateGoogle(CreateGoogleViewModel model)
        {
            try
            {
                _googleServiceProvider.CreateCloudInfrastructure(new CreateGoogleViewModel().ToModel(model));

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deleteGoogle")]
        public ActionResult DeleteGoogle(DeleteGoogleViewModel model)
        {
            try
            {
                _googleServiceProvider.DeleteCloudInfrastructure(new DeleteGoogleViewModel().ToModel(model));

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
