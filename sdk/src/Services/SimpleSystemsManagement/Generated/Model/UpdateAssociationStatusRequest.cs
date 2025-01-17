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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAssociationStatus operation.
    /// Updates the status of the Amazon Web Services Systems Manager document (SSM document)
    /// associated with the specified instance.
    /// 
    ///  
    /// <para>
    ///  <code>UpdateAssociationStatus</code> is primarily used by the Amazon Web Services
    /// Systems Manager Agent (SSM Agent) to report status updates about your associations
    /// and is only used for associations created with the <code>InstanceId</code> legacy
    /// parameter.
    /// </para>
    /// </summary>
    public partial class UpdateAssociationStatusRequest : AmazonSimpleSystemsManagementRequest
    {
        private AssociationStatus _associationStatus;
        private string _instanceId;
        private string _name;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateAssociationStatusRequest() { }

        /// <summary>
        /// Instantiates UpdateAssociationStatusRequest with the parameterized properties
        /// </summary>
        /// <param name="associationStatus">The association status.</param>
        /// <param name="instanceId">The instance ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        public UpdateAssociationStatusRequest(AssociationStatus associationStatus, string instanceId, string name)
        {
            _associationStatus = associationStatus;
            _instanceId = instanceId;
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// The association status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssociationStatus AssociationStatus
        {
            get { return this._associationStatus; }
            set { this._associationStatus = value; }
        }

        // Check to see if AssociationStatus property is set
        internal bool IsSetAssociationStatus()
        {
            return this._associationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSM document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}