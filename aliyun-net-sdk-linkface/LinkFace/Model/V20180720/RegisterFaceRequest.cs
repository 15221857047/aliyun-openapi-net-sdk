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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.LinkFace.Transform;
using Aliyun.Acs.LinkFace.Transform.V20180720;
using System.Collections.Generic;

namespace Aliyun.Acs.LinkFace.Model.V20180720
{
    public class RegisterFaceRequest : RpcAcsRequest<RegisterFaceResponse>
    {
        public RegisterFaceRequest()
            : base("LinkFace", "2018-07-20", "RegisterFace")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string image;

		private string groupId;

		private string userId;

		public string Image
		{
			get
			{
				return image;
			}
			set	
			{
				image = value;
				DictionaryUtil.Add(BodyParameters, "Image", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(BodyParameters, "GroupId", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RegisterFaceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return RegisterFaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}