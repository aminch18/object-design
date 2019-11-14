













// <auto-generated />

using System;
using System.Reflection;
using System.Resources;

using System.Threading;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;


namespace ObjectDesign.Properties
{

    /// <summary>
    ///     <para>
    ///		    String resources used in EF exceptions, etc.
    ///     </para>
    ///     <para>
    ///		    These strings are exposed publicly for use by database providers and extensions.
    ///         It is unusual for application code to need these strings.
    ///     </para>
    /// </summary>

    public static class CoreStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("ObjectDesign.Properties.CoreStrings", typeof(CoreStrings).GetTypeInfo().Assembly);


        /// <summary>

        ///     Latitude should be between -90 and 90

        /// </summary>

        public static string InvalidLatitude
            => GetString("InvalidLatitude");


        /// <summary>

        ///     Longitude should be between -180 and 180

        /// </summary>

        public static string InvalidLongitude
            => GetString("InvalidLongitude");


        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}


namespace ObjectDesign.Properties.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class CoreResources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("ObjectDesign.Properties.CoreStrings", typeof(CoreResources).GetTypeInfo().Assembly);

    }
}
