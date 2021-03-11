using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CloudProviderLibrary.CloudServiceProviders.Abstractions;
using CloudProviderLibrary.Enums;
using CloudProviderLibrary.Models;
using Newtonsoft.Json;

namespace CloudProviderLibrary.CloudServiceProviders.Concretes
{
    /// <summary>
    /// General cloud service provider implementation methods
    /// </summary>
    public class CloudServiceProviderUtils 
    {
        public static void CreateCloudInfrastructure(CreateCloudServiceProviderModel model)
        {
            string dir = GetResourceFilePath(model.CloudProvider, model.InfrastructureName, model.ResourceType);

            var content = JsonConvert.SerializeObject(model.ResourceContent);

            try
            {
                File.WriteAllText(CreateContentFile(model.InfrastructureName, dir), content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static string CreateContentFile(string infrastructureName, string dir)
        {
            return Path.Combine(dir, infrastructureName + "_SERVER" + ".json");
        }

        private static string GetResourceFilePath(CloudServiceProvidersEnum cloudServiceProvider, string infrastrustureName, ResourceTypesEnum resourceType)
        {
            var dir = Path.Combine(GetInfrastructurePath(cloudServiceProvider, infrastrustureName),
                resourceType.ToString());

            CreateDirectory(dir);

            return dir;
        }

        private static void CreateDirectory(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private static string GetInfrastructurePath(CloudServiceProvidersEnum cloudServiceProvider, string infrastrustureName)
        {
            return Path.Combine(GetCurrentDirectory(), cloudServiceProvider.ToString(), infrastrustureName);
        }

        private static string GetCurrentDirectory()
        {
            return Path.GetDirectoryName(Environment.CurrentDirectory);
        }

        public static void DeleteCloudInfrastructure(DeleteCloudServiceProviderModel model)
        {
            string infrastructureDir = GetInfrastructurePath(model.CloudProvider,model.InfrastructureName);
            foreach (var subDir in new DirectoryInfo(infrastructureDir).GetDirectories())
            {
                subDir.Delete(true);
            }
        }
    }
}
