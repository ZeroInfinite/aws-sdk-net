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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Metadata for this recommendation set.
    /// </summary>
    public partial class RightsizingRecommendationMetadata
    {
        private string _generationTimestamp;
        private LookbackPeriodInDays _lookbackPeriodInDays;
        private string _recommendationId;

        /// <summary>
        /// Gets and sets the property GenerationTimestamp. 
        /// <para>
        ///  The time stamp for when Amazon Web Services made this recommendation.
        /// </para>
        /// </summary>
        public string GenerationTimestamp
        {
            get { return this._generationTimestamp; }
            set { this._generationTimestamp = value; }
        }

        // Check to see if GenerationTimestamp property is set
        internal bool IsSetGenerationTimestamp()
        {
            return this._generationTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        ///  How many days of previous usage that Amazon Web Services considers when making this
        /// recommendation.
        /// </para>
        /// </summary>
        public LookbackPeriodInDays LookbackPeriodInDays
        {
            get { return this._lookbackPeriodInDays; }
            set { this._lookbackPeriodInDays = value; }
        }

        // Check to see if LookbackPeriodInDays property is set
        internal bool IsSetLookbackPeriodInDays()
        {
            return this._lookbackPeriodInDays != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        ///  The ID for this specific recommendation.
        /// </para>
        /// </summary>
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

    }
}