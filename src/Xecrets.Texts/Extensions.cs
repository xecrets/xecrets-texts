#region Copyright and License

/*
 * Xecrets Texts - Copyright © 2022-2026, Svante Seleborg, All Rights Reserved.
 *
 * This code file is part of Xecrets Texts
 *
 * Xecrets Texts is free software: you can redistribute it and/or modify it under the terms of the GNU General
 * Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any
 * later version.
 *
 * Xecrets Texts is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the
 * implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more
 * details.
 *
 * You should have received a copy of the GNU General Public License along with Xecrets Texts.  If not, see
 * <https://www.gnu.org/licenses/>.
 *
 * The source repository can be found at https://github.com/xecrets/xecrets-texts please go there for more
 * information, suggestions and contributions. You may also visit https://www.axantum.com for more information about the
 * author, or submit support requests at https://www.axantum.com/support .
*/

#endregion Copyright and License

using System.Globalization;

using Microsoft.Extensions.Localization;

namespace Xecrets.Texts;

/// <summary>
/// Extensions and helpers for URL rewriting and string formatting used across Xecrets assemblies.
/// </summary>
public static partial class Extensions
{
    extension(LocalizedString format)
    {
        /// <summary>
        /// Formats a <see cref="LocalizedString"/> using <see cref="CultureInfo.CurrentCulture"/>.
        /// </summary>
        /// <param name="args">Format arguments passed to <see cref="string.Format(IFormatProvider, string, object[])"/>.</param>
        /// <returns>The formatted string.</returns>
        public string FormatUi(params object[] args) => string.Format(CultureInfo.CurrentCulture, format.Value, args);

        /// <summary>
        /// Formats a pipe-delimited plural <see cref="LocalizedString"/> by selecting the segment matching <paramref name="n">,
        /// typically 0, 1 or 2. If n > number of segments, the last one is chosen.</paramref>/>.
        /// </summary>
        /// <param name="n">The count that selects the plural form. Negative values return an empty string.</param>
        /// <param name="args">Additional format arguments.</param>
        /// <returns>The formatted plural string, or <see cref="string.Empty"/> when <paramref name="n"/> is negative.</returns>
        public string PluralFormatUi(int n, params object[] args)
        {
            if (n < 0)
            {
                return string.Empty;
            }

            string[] formats = format.Value.Split('|');
            return string.Format(CultureInfo.CurrentCulture, formats[n < formats.Length ? n : formats.Length - 1], n, args);
        }
    }

    /// <summary>
    /// Strips accelerator underscores and trailing ellipsis from a localized menu label.
    /// </summary>
    /// <param name="menuText">The raw localized menu string.</param>
    /// <returns>The cleaned label text.</returns>
    public static string MenuToLabelText(this LocalizedString menuText) => menuText.Value.Replace("_", string.Empty).Replace("...", string.Empty);

    /// <summary>
    /// Rewrites a production URL to point to a local dev server or test server when running in debug mode.
    /// In release builds the URL is returned unchanged.
    /// </summary>
    /// <param name="url">The URL, must be rooted at <c>https://www.axantum.com</c>.</param>
    /// <returns>The original URL in release builds, or a rewritten URL in debug builds.</returns>
    internal static string ToSite(this string url)
    {
        if (Is.Debug)
        {
            string testServer = (Platform.IsWindows || Platform.IsLinux || Platform.IsMacOS) && DebugDevServer.IsDevServerRunning
                ? "http://localhost:3000"
                : "https://test.axantum.com";
            return url.Replace("https://www.axantum.com", testServer);
        }

        return url;
    }

    /// <summary>
    /// Rewrites a production URL (see <see cref="ToSite(string)"/>) and appends a URL fragment.
    /// </summary>
    /// <param name="url">The URL to rewrite.</param>
    /// <param name="fragment">The fragment to append, e.g. <c>"#section"</c>.</param>
    /// <returns>The rewritten URL with the fragment appended.</returns>
    internal static string ToSite(this string url, string fragment) => url.ToSite() + fragment;
}
