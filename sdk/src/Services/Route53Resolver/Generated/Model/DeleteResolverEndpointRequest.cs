/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResolverEndpoint operation.
    /// Deletes a resolver endpoint. The effect of deleting a resolver endpoint depends on
    /// whether it's an inbound or an outbound resolver endpoint:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>Inbound</b>: DNS queries from your network or another VPC are no longer routed
    /// to the DNS service for the specified VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Outbound</b>: DNS queries from a VPC are no longer routed to your network or to
    /// another VPC.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteResolverEndpointRequest : AmazonRoute53ResolverRequest
    {
        private string _resolverEndpointId;

        /// <summary>
        /// Gets and sets the property ResolverEndpointId. 
        /// <para>
        /// The ID of the resolver endpoint that you want to delete.
        /// </para>
        /// </summary>
        public string ResolverEndpointId
        {
            get { return this._resolverEndpointId; }
            set { this._resolverEndpointId = value; }
        }

        // Check to see if ResolverEndpointId property is set
        internal bool IsSetResolverEndpointId()
        {
            return this._resolverEndpointId != null;
        }

    }
}