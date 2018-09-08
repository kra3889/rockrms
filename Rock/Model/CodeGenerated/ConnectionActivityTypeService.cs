//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// ConnectionActivityType Service class
    /// </summary>
    public partial class ConnectionActivityTypeService : Service<ConnectionActivityType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionActivityTypeService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public ConnectionActivityTypeService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( ConnectionActivityType item, out string errorMessage )
        {
            errorMessage = string.Empty;
 
            if ( new Service<ConnectionRequestActivity>( Context ).Queryable().Any( a => a.ConnectionActivityTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", ConnectionActivityType.FriendlyTypeName, ConnectionRequestActivity.FriendlyTypeName );
                return false;
            }  
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class ConnectionActivityTypeExtensionMethods
    {
        /// <summary>
        /// Clones this ConnectionActivityType object to a new ConnectionActivityType object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static ConnectionActivityType Clone( this ConnectionActivityType source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as ConnectionActivityType;
            }
            else
            {
                var target = new ConnectionActivityType();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another ConnectionActivityType object to this ConnectionActivityType object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this ConnectionActivityType target, ConnectionActivityType source )
        {
            target.Id = source.Id;
            target.ConnectionTypeId = source.ConnectionTypeId;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.IsActive = source.IsActive;
            target.Name = source.Name;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}