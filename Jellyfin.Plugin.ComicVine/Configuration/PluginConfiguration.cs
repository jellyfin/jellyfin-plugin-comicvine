using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.ComicVine.Configuration
{
    /// <summary>
    /// Instance of the empty plugin configuration.
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {
        /// <summary>
        /// Gets or sets the Comic Vine API key.
        /// </summary>
        /// <remarks>The rate limit is 200 requests per resource, per hour.</remarks>
        public string ComicVineApiKey { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the format for an issue's name.
        /// </summary>
        /// <remarks>
        /// This has the following available placeholders: {Name}, {Volume.Name}, {Id}, {IssueNumber}, {IssueNumberFormatted}.
        /// If a value is missing or empty (no name or volume), its value will be replaced with the empty string.
        /// </remarks>
        public string IssueNameFormatOverride { get; set; } = string.Empty;
    }
}
