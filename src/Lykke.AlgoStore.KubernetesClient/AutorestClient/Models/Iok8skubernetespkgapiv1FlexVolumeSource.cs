// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.AlgoStore.KubernetesClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// FlexVolume represents a generic volume resource that is
    /// provisioned/attached using an exec based plugin. This is an alpha
    /// feature and may change in future.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1FlexVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1FlexVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1FlexVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1FlexVolumeSource class.
        /// </summary>
        /// <param name="driver">Driver is the name of the driver to use for
        /// this volume.</param>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem
        /// type supported by the host operating system. Ex. "ext4", "xfs",
        /// "ntfs". The default filesystem depends on FlexVolume
        /// script.</param>
        /// <param name="options">Optional: Extra command options if
        /// any.</param>
        /// <param name="readOnlyProperty">Optional: Defaults to false
        /// (read/write). ReadOnly here will force the ReadOnly setting in
        /// VolumeMounts.</param>
        /// <param name="secretRef">Optional: SecretRef is reference to the
        /// secret object containing sensitive information to pass to the
        /// plugin scripts. This may be empty if no secret object is specified.
        /// If the secret object contains more than one secret, all secrets are
        /// passed to the plugin scripts.</param>
        public Iok8skubernetespkgapiv1FlexVolumeSource(string driver, string fsType = default(string), IDictionary<string, string> options = default(IDictionary<string, string>), bool? readOnlyProperty = default(bool?), Iok8skubernetespkgapiv1LocalObjectReference secretRef = default(Iok8skubernetespkgapiv1LocalObjectReference))
        {
            Driver = driver;
            FsType = fsType;
            Options = options;
            ReadOnlyProperty = readOnlyProperty;
            SecretRef = secretRef;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets driver is the name of the driver to use for this
        /// volume.
        /// </summary>
        [JsonProperty(PropertyName = "driver")]
        public string Driver { get; set; }

        /// <summary>
        /// Gets or sets filesystem type to mount. Must be a filesystem type
        /// supported by the host operating system. Ex. "ext4", "xfs", "ntfs".
        /// The default filesystem depends on FlexVolume script.
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or sets optional: Extra command options if any.
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public IDictionary<string, string> Options { get; set; }

        /// <summary>
        /// Gets or sets optional: Defaults to false (read/write). ReadOnly
        /// here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets optional: SecretRef is reference to the secret object
        /// containing sensitive information to pass to the plugin scripts.
        /// This may be empty if no secret object is specified. If the secret
        /// object contains more than one secret, all secrets are passed to the
        /// plugin scripts.
        /// </summary>
        [JsonProperty(PropertyName = "secretRef")]
        public Iok8skubernetespkgapiv1LocalObjectReference SecretRef { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Driver == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Driver");
            }
        }
    }
}
