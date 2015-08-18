﻿//-----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace System.IdentityModel.Tokens
{
    public class SecurityTokenDescriptor
    {
        public String Audience { get; set; }
        public IEnumerable<Claim> Claims { get; set; }
        public DateTime? Expires { get; set; }
        public DateTime? IssuedAt { get; set; }
        public String Issuer { get; set; }
        public DateTime? NotBefore { get; set; }
        public SigningCredentials SigningCredentials { get; set; }
    }
}