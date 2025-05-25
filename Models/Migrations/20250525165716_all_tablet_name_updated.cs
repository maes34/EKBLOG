using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class all_tablet_name_updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "adress",
                table: "SiteSettings",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "youtube_url",
                table: "SiteSettings",
                newName: "YoutubeUrl");

            migrationBuilder.RenameColumn(
                name: "x_url",
                table: "SiteSettings",
                newName: "XUrl");

            migrationBuilder.RenameColumn(
                name: "site_title",
                table: "SiteSettings",
                newName: "SiteTitle");

            migrationBuilder.RenameColumn(
                name: "site_logo_url",
                table: "SiteSettings",
                newName: "SiteLogoUrl");

            migrationBuilder.RenameColumn(
                name: "site_favicon_url",
                table: "SiteSettings",
                newName: "SiteFavionUrl");

            migrationBuilder.RenameColumn(
                name: "site_bg",
                table: "SiteSettings",
                newName: "SiteBg");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "SiteSettings",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "maintenance_mode",
                table: "SiteSettings",
                newName: "MaintenanceMode");

            migrationBuilder.RenameColumn(
                name: "linkedin_url",
                table: "SiteSettings",
                newName: "MapUrl");

            migrationBuilder.RenameColumn(
                name: "instagram_url",
                table: "SiteSettings",
                newName: "LinkedinUrl");

            migrationBuilder.RenameColumn(
                name: "github_url",
                table: "SiteSettings",
                newName: "InstagramUrl");

            migrationBuilder.RenameColumn(
                name: "footer_copy",
                table: "SiteSettings",
                newName: "GithubUrl");

            migrationBuilder.RenameColumn(
                name: "facebook_url",
                table: "SiteSettings",
                newName: "FooterCopy");

            migrationBuilder.RenameColumn(
                name: "cv_url",
                table: "SiteSettings",
                newName: "FacebookUrl");

            migrationBuilder.RenameColumn(
                name: "contact_email",
                table: "SiteSettings",
                newName: "CvUrl");

            migrationBuilder.RenameColumn(
                name: "surname",
                table: "Contacts",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "Contacts",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "read",
                table: "Contacts",
                newName: "Read");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Contacts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "messages",
                table: "Contacts",
                newName: "Messages");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Contacts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Blogs",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "image_url",
                table: "Blogs",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Abouts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "photo_url",
                table: "Abouts",
                newName: "PhotoUrl");

            migrationBuilder.AddColumn<string>(
                name: "ContactMail",
                table: "SiteSettings",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactMail",
                table: "SiteSettings");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "SiteSettings",
                newName: "adress");

            migrationBuilder.RenameColumn(
                name: "YoutubeUrl",
                table: "SiteSettings",
                newName: "youtube_url");

            migrationBuilder.RenameColumn(
                name: "XUrl",
                table: "SiteSettings",
                newName: "x_url");

            migrationBuilder.RenameColumn(
                name: "SiteTitle",
                table: "SiteSettings",
                newName: "site_title");

            migrationBuilder.RenameColumn(
                name: "SiteLogoUrl",
                table: "SiteSettings",
                newName: "site_logo_url");

            migrationBuilder.RenameColumn(
                name: "SiteFavionUrl",
                table: "SiteSettings",
                newName: "site_favicon_url");

            migrationBuilder.RenameColumn(
                name: "SiteBg",
                table: "SiteSettings",
                newName: "site_bg");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "SiteSettings",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "MapUrl",
                table: "SiteSettings",
                newName: "linkedin_url");

            migrationBuilder.RenameColumn(
                name: "MaintenanceMode",
                table: "SiteSettings",
                newName: "maintenance_mode");

            migrationBuilder.RenameColumn(
                name: "LinkedinUrl",
                table: "SiteSettings",
                newName: "instagram_url");

            migrationBuilder.RenameColumn(
                name: "InstagramUrl",
                table: "SiteSettings",
                newName: "github_url");

            migrationBuilder.RenameColumn(
                name: "GithubUrl",
                table: "SiteSettings",
                newName: "footer_copy");

            migrationBuilder.RenameColumn(
                name: "FooterCopy",
                table: "SiteSettings",
                newName: "facebook_url");

            migrationBuilder.RenameColumn(
                name: "FacebookUrl",
                table: "SiteSettings",
                newName: "cv_url");

            migrationBuilder.RenameColumn(
                name: "CvUrl",
                table: "SiteSettings",
                newName: "contact_email");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Contacts",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Contacts",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "Read",
                table: "Contacts",
                newName: "read");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Messages",
                table: "Contacts",
                newName: "messages");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contacts",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Blogs",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Blogs",
                newName: "image_url");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Abouts",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "PhotoUrl",
                table: "Abouts",
                newName: "photo_url");
        }
    }
}
