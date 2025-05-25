using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class SiteSetting : CoreEntity
    {
        public string? SiteTitle { get; set; } = string.Empty;
        public string? SiteLogoUrl { get; set; } = string.Empty;
        public string? SiteFavionUrl { get; set; } = string.Empty;
        public string? Adress { get; set; } = string.Empty;
        public string? MapUrl { get; set; } = string.Empty;
        public string? ContactMail { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        public string? InstagramUrl { get; set; } = string.Empty;
        public string? LinkedinUrl { get; set; } = string.Empty;
        public string? FacebookUrl { get; set; } = string.Empty;
        public string? YoutubeUrl { get; set; } = string.Empty;
        public string? XUrl { get; set; } = string.Empty;
        public string? GithubUrl { get; set; } = string.Empty;
        public string? SiteBg { get; set; } = string.Empty;
        public string? FooterCopy { get; set; } = string.Empty;
        public string? CvUrl { get; set; } = string.Empty;
        public int MaintenanceMode { get; set; }
    }
}
