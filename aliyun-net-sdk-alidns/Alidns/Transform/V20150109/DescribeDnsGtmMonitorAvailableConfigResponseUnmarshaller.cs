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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDnsGtmMonitorAvailableConfigResponseUnmarshaller
    {
        public static DescribeDnsGtmMonitorAvailableConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmMonitorAvailableConfigResponse describeDnsGtmMonitorAvailableConfigResponse = new DescribeDnsGtmMonitorAvailableConfigResponse();

			describeDnsGtmMonitorAvailableConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmMonitorAvailableConfigResponse.RequestId = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.RequestId");

			List<DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_Ipv4IspCityNode> describeDnsGtmMonitorAvailableConfigResponse_ipv4IspCityNodes = new List<DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_Ipv4IspCityNode>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmMonitorAvailableConfig.Ipv4IspCityNodes.Length"); i++) {
				DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_Ipv4IspCityNode ipv4IspCityNode = new DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_Ipv4IspCityNode();
				ipv4IspCityNode.IspName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv4IspCityNodes["+ i +"].IspName");
				ipv4IspCityNode.IspCode = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv4IspCityNodes["+ i +"].IspCode");
				ipv4IspCityNode.CityName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv4IspCityNodes["+ i +"].CityName");
				ipv4IspCityNode.CityCode = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv4IspCityNodes["+ i +"].CityCode");
				ipv4IspCityNode.DefaultSelected = _ctx.BooleanValue("DescribeDnsGtmMonitorAvailableConfig.Ipv4IspCityNodes["+ i +"].DefaultSelected");
				ipv4IspCityNode.GroupType = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv4IspCityNodes["+ i +"].GroupType");
				ipv4IspCityNode.GroupName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv4IspCityNodes["+ i +"].GroupName");

				describeDnsGtmMonitorAvailableConfigResponse_ipv4IspCityNodes.Add(ipv4IspCityNode);
			}
			describeDnsGtmMonitorAvailableConfigResponse.Ipv4IspCityNodes = describeDnsGtmMonitorAvailableConfigResponse_ipv4IspCityNodes;

			List<DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_Ipv6IspCityNode> describeDnsGtmMonitorAvailableConfigResponse_ipv6IspCityNodes = new List<DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_Ipv6IspCityNode>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmMonitorAvailableConfig.Ipv6IspCityNodes.Length"); i++) {
				DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_Ipv6IspCityNode ipv6IspCityNode = new DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_Ipv6IspCityNode();
				ipv6IspCityNode.IspName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv6IspCityNodes["+ i +"].IspName");
				ipv6IspCityNode.IspCode = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv6IspCityNodes["+ i +"].IspCode");
				ipv6IspCityNode.CityName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv6IspCityNodes["+ i +"].CityName");
				ipv6IspCityNode.CityCode = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv6IspCityNodes["+ i +"].CityCode");
				ipv6IspCityNode.DefaultSelected = _ctx.BooleanValue("DescribeDnsGtmMonitorAvailableConfig.Ipv6IspCityNodes["+ i +"].DefaultSelected");
				ipv6IspCityNode.GroupType = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv6IspCityNodes["+ i +"].GroupType");
				ipv6IspCityNode.GroupName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.Ipv6IspCityNodes["+ i +"].GroupName");

				describeDnsGtmMonitorAvailableConfigResponse_ipv6IspCityNodes.Add(ipv6IspCityNode);
			}
			describeDnsGtmMonitorAvailableConfigResponse.Ipv6IspCityNodes = describeDnsGtmMonitorAvailableConfigResponse_ipv6IspCityNodes;

			List<DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_DomainIpv4IspCityNode> describeDnsGtmMonitorAvailableConfigResponse_domainIpv4IspCityNodes = new List<DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_DomainIpv4IspCityNode>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmMonitorAvailableConfig.DomainIpv4IspCityNodes.Length"); i++) {
				DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_DomainIpv4IspCityNode domainIpv4IspCityNode = new DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_DomainIpv4IspCityNode();
				domainIpv4IspCityNode.IspName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv4IspCityNodes["+ i +"].IspName");
				domainIpv4IspCityNode.IspCode = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv4IspCityNodes["+ i +"].IspCode");
				domainIpv4IspCityNode.CityName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv4IspCityNodes["+ i +"].CityName");
				domainIpv4IspCityNode.CityCode = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv4IspCityNodes["+ i +"].CityCode");
				domainIpv4IspCityNode.DefaultSelected = _ctx.BooleanValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv4IspCityNodes["+ i +"].DefaultSelected");
				domainIpv4IspCityNode.GroupType = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv4IspCityNodes["+ i +"].GroupType");
				domainIpv4IspCityNode.GroupName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv4IspCityNodes["+ i +"].GroupName");

				describeDnsGtmMonitorAvailableConfigResponse_domainIpv4IspCityNodes.Add(domainIpv4IspCityNode);
			}
			describeDnsGtmMonitorAvailableConfigResponse.DomainIpv4IspCityNodes = describeDnsGtmMonitorAvailableConfigResponse_domainIpv4IspCityNodes;

			List<DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_DomainIpv6IspCityNode> describeDnsGtmMonitorAvailableConfigResponse_domainIpv6IspCityNodes = new List<DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_DomainIpv6IspCityNode>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmMonitorAvailableConfig.DomainIpv6IspCityNodes.Length"); i++) {
				DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_DomainIpv6IspCityNode domainIpv6IspCityNode = new DescribeDnsGtmMonitorAvailableConfigResponse.DescribeDnsGtmMonitorAvailableConfig_DomainIpv6IspCityNode();
				domainIpv6IspCityNode.IspName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv6IspCityNodes["+ i +"].IspName");
				domainIpv6IspCityNode.IspCode = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv6IspCityNodes["+ i +"].IspCode");
				domainIpv6IspCityNode.CityName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv6IspCityNodes["+ i +"].CityName");
				domainIpv6IspCityNode.CityCode = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv6IspCityNodes["+ i +"].CityCode");
				domainIpv6IspCityNode.DefaultSelected = _ctx.BooleanValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv6IspCityNodes["+ i +"].DefaultSelected");
				domainIpv6IspCityNode.GroupType = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv6IspCityNodes["+ i +"].GroupType");
				domainIpv6IspCityNode.GroupName = _ctx.StringValue("DescribeDnsGtmMonitorAvailableConfig.DomainIpv6IspCityNodes["+ i +"].GroupName");

				describeDnsGtmMonitorAvailableConfigResponse_domainIpv6IspCityNodes.Add(domainIpv6IspCityNode);
			}
			describeDnsGtmMonitorAvailableConfigResponse.DomainIpv6IspCityNodes = describeDnsGtmMonitorAvailableConfigResponse_domainIpv6IspCityNodes;
        
			return describeDnsGtmMonitorAvailableConfigResponse;
        }
    }
}
