/*
 * Copyright 2014-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 *
 * Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located in the "license" file accompanying this file.
 * See the License for the specific language governing permissions and limitations under the License.
 *
 */
using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
    ///<summary>
    /// SecurityTokenService exception
    /// </summary>
    public class IDPRejectedClaimException : AmazonSecurityTokenServiceException 
    {
        /// <summary>
        /// Constructs a new IDPRejectedClaimException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public IDPRejectedClaimException(string message) 
            : base(message) {}
          
        public IDPRejectedClaimException(string message, Exception innerException) 
            : base(message, innerException) {}
            
        public IDPRejectedClaimException(Exception innerException) 
            : base(innerException) {}
            
        public IDPRejectedClaimException(string message, Exception innerException, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, RequestId, statusCode) {}

        public IDPRejectedClaimException(string message, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, RequestId, statusCode) {}

    }
}