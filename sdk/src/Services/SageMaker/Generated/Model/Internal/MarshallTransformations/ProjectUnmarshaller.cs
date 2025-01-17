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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Project Object
    /// </summary>  
    public class ProjectUnmarshaller : IUnmarshaller<Project, XmlUnmarshallerContext>, IUnmarshaller<Project, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Project IUnmarshaller<Project, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Project Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Project unmarshalledObject = new Project();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    unmarshalledObject.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceCatalogProvisionedProductDetails", targetDepth))
                {
                    var unmarshaller = ServiceCatalogProvisionedProductDetailsUnmarshaller.Instance;
                    unmarshalledObject.ServiceCatalogProvisionedProductDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceCatalogProvisioningDetails", targetDepth))
                {
                    var unmarshaller = ServiceCatalogProvisioningDetailsUnmarshaller.Instance;
                    unmarshalledObject.ServiceCatalogProvisioningDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProjectUnmarshaller _instance = new ProjectUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProjectUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}