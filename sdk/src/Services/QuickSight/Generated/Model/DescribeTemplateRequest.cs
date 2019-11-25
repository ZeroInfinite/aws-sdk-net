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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTemplate operation.
    /// Describes a template's metadata.
    /// 
    ///  
    /// <para>
    /// CLI syntax:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight describe-template --aws-account-id 111122223333 --template-id
    /// reports_test_template </code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight describe-template --aws-account-id 111122223333 --template-id
    /// reports_test_template --version-number-2</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight describe-template --aws-account-id 111122223333 --template-id
    /// reports_test_template --alias-name '\$LATEST' </code> 
    /// </para>
    ///  
    /// <para>
    /// Users can explicitly describe the latest version of the dashboard by passing <code>$LATEST</code>
    /// to the <code>alias-name</code> parameter. <code>$LATEST</code> is an internally supported
    /// alias, which points to the latest version of the dashboard. 
    /// </para>
    /// </summary>
    public partial class DescribeTemplateRequest : AmazonQuickSightRequest
    {
        private string _aliasName;
        private string _awsAccountId;
        private string _templateId;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// This is an optional field, when an alias name is provided, the version referenced
        /// by the alias is described. Refer to <code>CreateTemplateAlias</code> to create a template
        /// alias. <code>$PUBLISHED</code> is not supported for template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// AWS account ID that contains the template you are describing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// An ID for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// This is an optional field, when a version number is provided the corresponding version
        /// is describe, if it's not provided the latest version of the template is described.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}