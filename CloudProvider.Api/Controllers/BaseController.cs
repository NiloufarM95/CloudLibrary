using CloudProviderLibrary.CloudServiceProviders.Abstractions;
using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CloudProvider.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected readonly ICloudServiceProvider _serviceProvider;

        protected BaseController(ICloudServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected ActionResult CreateServiceProvider<T>(T createViewModel) where T : CreateCloudServiceProviderModel
        {
            try
            {
                _serviceProvider.CreateCloudInfrastructure(createViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        protected ActionResult DeleteServiceProvider<T>(T deleteViewModel) where T : DeleteCloudServiceProviderModel
        {
            try
            {
                _serviceProvider.DeleteCloudInfrastructure(deleteViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
