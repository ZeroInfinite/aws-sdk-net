/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Container for the parameters to the ListSpeakerEnrollmentJobs operation.
    /// Lists all the speaker enrollment jobs in the domain with the specified <code>JobStatus</code>.
    /// If <code>JobStatus</code> is not provided, this lists all jobs with all possible speaker
    /// enrollment job statuses.
    /// </summary>
    public partial class ListSpeakerEnrollmentJobsRequest : AmazonVoiceIDRequest
    {
        private string _domainId;
        private SpeakerEnrollmentJobStatus _jobStatus;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain containing the speaker enrollment jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Provides the status of your speaker enrollment Job.
        /// </para>
        /// </summary>
        public SpeakerEnrollmentJobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that are returned per call. You can use <code>NextToken</code>
        /// to obtain further pages of results. The default is 100; the maximum allowed page size
        /// is also 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// If <code>NextToken</code> is returned, there are more results available. The value
        /// of <code>NextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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