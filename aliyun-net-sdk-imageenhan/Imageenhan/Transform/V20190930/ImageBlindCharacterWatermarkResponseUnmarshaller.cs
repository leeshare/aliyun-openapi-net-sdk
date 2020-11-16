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
using Aliyun.Acs.imageenhan.Model.V20190930;

namespace Aliyun.Acs.imageenhan.Transform.V20190930
{
    public class ImageBlindCharacterWatermarkResponseUnmarshaller
    {
        public static ImageBlindCharacterWatermarkResponse Unmarshall(UnmarshallerContext context)
        {
			ImageBlindCharacterWatermarkResponse imageBlindCharacterWatermarkResponse = new ImageBlindCharacterWatermarkResponse();

			imageBlindCharacterWatermarkResponse.HttpResponse = context.HttpResponse;
			imageBlindCharacterWatermarkResponse.RequestId = context.StringValue("ImageBlindCharacterWatermark.RequestId");

			ImageBlindCharacterWatermarkResponse.ImageBlindCharacterWatermark_Data data = new ImageBlindCharacterWatermarkResponse.ImageBlindCharacterWatermark_Data();
			data.WatermarkImageURL = context.StringValue("ImageBlindCharacterWatermark.Data.WatermarkImageURL");
			data.TextImageURL = context.StringValue("ImageBlindCharacterWatermark.Data.TextImageURL");
			imageBlindCharacterWatermarkResponse.Data = data;
        
			return imageBlindCharacterWatermarkResponse;
        }
    }
}