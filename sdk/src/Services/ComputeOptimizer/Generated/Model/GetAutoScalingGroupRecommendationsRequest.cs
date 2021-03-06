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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the GetAutoScalingGroupRecommendations operation.
    /// Returns Auto Scaling group recommendations.
    /// 
    ///  
    /// <para>
    /// AWS Compute Optimizer currently generates recommendations for Auto Scaling groups
    /// that are configured to run instances of the M, C, R, T, and X instance families. The
    /// service does not generate recommendations for Auto Scaling groups that have a scaling
    /// policy attached to them, or that do not have the same values for desired, minimum,
    /// and maximum capacity. In order for Compute Optimizer to analyze your Auto Scaling
    /// groups, they must be of a fixed size. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/what-is.html">AWS
    /// Compute Optimizer User Guide</a>.
    /// </para>
    /// </summary>
    public partial class GetAutoScalingGroupRecommendationsRequest : AmazonComputeOptimizerRequest
    {
        private List<string> _accountIds = new List<string>();
        private List<string> _autoScalingGroupArns = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The AWS account IDs for which to return Auto Scaling group recommendations.
        /// </para>
        ///  
        /// <para>
        /// Only one account ID can be specified per request.
        /// </para>
        /// </summary>
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroupArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Auto Scaling groups for which to return recommendations.
        /// </para>
        /// </summary>
        public List<string> AutoScalingGroupArns
        {
            get { return this._autoScalingGroupArns; }
            set { this._autoScalingGroupArns = value; }
        }

        // Check to see if AutoScalingGroupArns property is set
        internal bool IsSetAutoScalingGroupArns()
        {
            return this._autoScalingGroupArns != null && this._autoScalingGroupArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of objects that describe a filter that returns a more specific list of Auto
        /// Scaling group recommendations.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of Auto Scaling group recommendations to return with a single call.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the remaining results, make another call with the returned <code>NextToken</code>
        /// value.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to advance to the next page of Auto Scaling group recommendations.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}