﻿// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
/* 
 * Authenticator API
 *
 * For bots and other on-premise processes to authenticate. Once authenticated, the bot will be able to use the methods described in serviceAPI.yaml and agentAPI.yaml.  Connections to the servers will be over client authenticated TLS, the servers for this API will perform the authentication by inspecting the certificate presented by the SSLSocketClient.  There will be two implementations of this API, one on your Pod and one on the Key Manager. In order to fully authenticate, an API client will have to call both of these implementations and pass both of the session tokens returned as headers in all subsequent requests to the Symphony API. 
 *
 * OpenAPI spec version: current
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json.Converters;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AuthenticatorApi.Client
{
    /// <summary>
    /// Formatter for 'date' swagger formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types
    /// </summary>
    public class SwaggerDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerDateConverter" /> class.
        /// </summary>
        public SwaggerDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}