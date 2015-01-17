﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;

namespace Microsoft.WindowsAzure.Commands.StorSimple.Exceptions
{
    [Serializable]
    public class StorSimpleResourceNotFoundException : Exception
    {
        static string genericErrorMessage = "The resourcename provided does not exist under your subscription. To get a list of all available resources use Get-AzureStorSimpleResource";
        /// <summary>
        /// Create a new instance with error message
        /// </summary>
        /// <param name="message">error message</param>
        public StorSimpleResourceNotFoundException(string message)
            : base(message)
        { }

        public StorSimpleResourceNotFoundException()
            : base(genericErrorMessage)
        {

        }
    }
}
