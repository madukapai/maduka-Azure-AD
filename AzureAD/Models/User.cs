using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureAD.Models
{
    public class User
    {
        public class Value
        {
            public string odatatype { get; set; }
            public string objectType { get; set; }
            public string objectId { get; set; }
            public object deletionTimestamp { get; set; }
            public bool accountEnabled { get; set; }
            public object[] signInNames { get; set; }
            public Assignedlicens[] assignedLicenses { get; set; }
            public Assignedplan[] assignedPlans { get; set; }
            public object city { get; set; }
            public string companyName { get; set; }
            public string country { get; set; }
            public object creationType { get; set; }
            public string department { get; set; }
            public bool? dirSyncEnabled { get; set; }
            public string displayName { get; set; }
            public object facsimileTelephoneNumber { get; set; }
            public string givenName { get; set; }
            public string immutableId { get; set; }
            public object isCompromised { get; set; }
            public string jobTitle { get; set; }
            public DateTime? lastDirSyncTime { get; set; }
            public string mail { get; set; }
            public string mailNickname { get; set; }
            public string mobile { get; set; }
            public string onPremisesSecurityIdentifier { get; set; }
            public string[] otherMails { get; set; }
            public string passwordPolicies { get; set; }
            public Passwordprofile passwordProfile { get; set; }
            public object physicalDeliveryOfficeName { get; set; }
            public object postalCode { get; set; }
            public string preferredLanguage { get; set; }
            public object[] provisionedPlans { get; set; }
            public object[] provisioningErrors { get; set; }
            public string[] proxyAddresses { get; set; }
            public DateTime refreshTokensValidFromDateTime { get; set; }
            public string sipProxyAddress { get; set; }
            public object state { get; set; }
            public object streetAddress { get; set; }
            public string surname { get; set; }
            public object telephoneNumber { get; set; }
            public string thumbnailPhotoodatamediaContentType { get; set; }
            public string usageLocation { get; set; }
            public string userPrincipalName { get; set; }
            public string userType { get; set; }
            public string ManagerUri { get; set; }
            public string ManagerObjectId { get; set; }
            public string Manager { get; set; }
        }

        public class Passwordprofile
        {
            public object password { get; set; }
            public bool forceChangePasswordNextLogin { get; set; }
            public bool enforceChangePasswordPolicy { get; set; }
        }

        public class Assignedlicens
        {
            public object[] disabledPlans { get; set; }
            public string skuId { get; set; }
        }

        public class Assignedplan
        {
            public DateTime assignedTimestamp { get; set; }
            public string capabilityStatus { get; set; }
            public string service { get; set; }
            public string servicePlanId { get; set; }
        }

        public class Result
        {
            public string odatametadata { get; set; }
            public Value[] value { get; set; }
        }

        public class Manager
        {
            public string odatametadata { get; set; }
            public string url { get; set; }
        }
    }
}