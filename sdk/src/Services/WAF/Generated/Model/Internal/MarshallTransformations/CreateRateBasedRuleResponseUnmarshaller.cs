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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAF.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAF.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateRateBasedRule operation
    /// </summary>  
    public class CreateRateBasedRuleResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateRateBasedRuleResponse response = new CreateRateBasedRuleResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ChangeToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ChangeToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Rule", targetDepth))
                {
                    var unmarshaller = RateBasedRuleUnmarshaller.Instance;
                    response.Rule = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("WAFBadRequestException"))
            {
                return new WAFBadRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("WAFDisallowedNameException"))
            {
                return new WAFDisallowedNameException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("WAFInternalErrorException"))
            {
                return new WAFInternalErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("WAFInvalidParameterException"))
            {
                return new WAFInvalidParameterException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("WAFLimitsExceededException"))
            {
                return new WAFLimitsExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("WAFStaleDataException"))
            {
                return new WAFStaleDataException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("WAFTagOperationException"))
            {
                return new WAFTagOperationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("WAFTagOperationInternalErrorException"))
            {
                return new WAFTagOperationInternalErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonWAFException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreateRateBasedRuleResponseUnmarshaller _instance = new CreateRateBasedRuleResponseUnmarshaller();        

        internal static CreateRateBasedRuleResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRateBasedRuleResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}