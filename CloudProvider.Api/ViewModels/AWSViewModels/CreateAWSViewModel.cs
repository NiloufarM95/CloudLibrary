using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;

namespace CloudProvider.Api.ViewModels.AWSViewModels
{
    public class CreateAWSViewModel : CreateViewModel
    {
        public override CreateCloudServiceProviderModel ToCreateCloudServiceProviderModel()
        {
            return new CreateCloudServiceProviderModel(CloudServiceProvidersEnum.AWS, InfrastructureName, ResourceType, ResourceContent);
        }
    }
}
