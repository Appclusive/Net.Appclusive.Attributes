/**
 * Copyright 2017 d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.ComponentModel.DataAnnotations;
using Net.Appclusive.Public.Domain.Control;
using Net.Appclusive.Public.Engine;
using PublicConstants = Net.Appclusive.Public.Constants;

namespace Net.Appclusive.Attributes.V001
{
    public class ApprovalF : BaseModel
    {
        [AttributeName(PublicConstants.Approval.ApprovalF.RoleId)]
        [Range(0, long.MaxValue)]
        public virtual long RoleId { get; set; }

        [AttributeName(PublicConstants.Approval.ApprovalF.UserId)]
        [Range(0, long.MaxValue)]
        public virtual long UserId { get; set; }

        [AttributeName(PublicConstants.Approval.ApprovalF.Type)]
        [Range((long) ApprovalType.Default, (long) ApprovalType.AutoDecline)]
        public virtual long Type { get; set; }

        [AttributeName(PublicConstants.Approval.ApprovalF.AbsoluteExpiration)]
        public virtual long AbsoluteExpiration { get; set; }

        [AttributeName(PublicConstants.Approval.ApprovalF.RelativeExpiration)]
        public virtual long RelativeExpiration { get; set; }
    }
}
