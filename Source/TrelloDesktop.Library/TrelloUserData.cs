using System.Net;
using Newtonsoft.Json;

namespace TrelloDesktop.Library
{
    public class TrelloUserData
    {
        public string Id { get; set; }
        public object AvatarHash { get; set; }
        public string Bio { get; set; }
        public object BioData { get; set; }
        public bool Confirmed { get; set; }
        public string FullName { get; set; }
        public object[] IdEnterprisesDeactivated { get; set; }
        public object[] IdPremOrgsAdmin { get; set; }
        public string Initials { get; set; }
        public string MemberType { get; set; }
        public object[] Products { get; set; }
        public string Status { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
        public string AvatarSource { get; set; }
        public string Email { get; set; }
        public string GravatarHash { get; set; }
        public string[] IdBoards { get; set; }
        public object IdEnterprise { get; set; }
        public object[] IdOrganizations { get; set; }
        public object[] IdEnterprisesAdmin { get; set; }
        public Limits Limits { get; set; }
        public string[] LoginTypes { get; set; }
        public object[] OneTimeMessagesDismissed { get; set; }
        public object[] MessagesDismissed { get; set; }
        public Prefs Prefs { get; set; }
        public object[] Trophies { get; set; }
        public object UploadedAvatarHash { get; set; }
        public object[] PremiumFeatures { get; set; }
        public object IdBoardsPinned { get; set; }
    }
}