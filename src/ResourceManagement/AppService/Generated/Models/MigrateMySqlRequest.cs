// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// MySQL migration request.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MigrateMySqlRequest : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the MigrateMySqlRequest class.
        /// </summary>
        public MigrateMySqlRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrateMySqlRequest class.
        /// </summary>
        /// <param name="connectionString">Connection string to the remote
        /// MySQL database.</param>
        /// <param name="migrationType">The type of migration operation to be
        /// done. Possible values include: 'LocalToRemote',
        /// 'RemoteToLocal'</param>
        /// <param name="kind">Kind of resource.</param>
        public MigrateMySqlRequest(string connectionString, MySqlMigrationType migrationType, string id = default(string), string name = default(string), string type = default(string), string kind = default(string))
            : base(id, name, type, kind)
        {
            ConnectionString = connectionString;
            MigrationType = migrationType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets connection string to the remote MySQL database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the type of migration operation to be done. Possible
        /// values include: 'LocalToRemote', 'RemoteToLocal'
        /// </summary>
        [JsonProperty(PropertyName = "properties.migrationType")]
        public MySqlMigrationType MigrationType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
        }
    }
}