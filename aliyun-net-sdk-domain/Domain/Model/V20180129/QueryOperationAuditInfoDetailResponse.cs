/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryOperationAuditInfoDetailResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private long? createTime;

		private long? updateTime;

		private string businessName;

		private string domainName;

		private int? auditType;

		private int? auditStatus;

		private string auditInfo;

		private string remark;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
			}
		}

		public long? CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public long? UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public string BusinessName
		{
			get
			{
				return businessName;
			}
			set	
			{
				businessName = value;
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		public int? AuditType
		{
			get
			{
				return auditType;
			}
			set	
			{
				auditType = value;
			}
		}

		public int? AuditStatus
		{
			get
			{
				return auditStatus;
			}
			set	
			{
				auditStatus = value;
			}
		}

		public string AuditInfo
		{
			get
			{
				return auditInfo;
			}
			set	
			{
				auditInfo = value;
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
			}
		}
	}
}