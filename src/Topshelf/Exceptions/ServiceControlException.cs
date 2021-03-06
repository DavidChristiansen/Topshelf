﻿// Copyright 2007-2011 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Topshelf.Exceptions
{
	using System;
	using System.Runtime.Serialization;
	using Magnum.Extensions;


	[Serializable]
	public class ServiceControlException :
		TopshelfException
	{
		public ServiceControlException(string name, Type serviceType, string message, Exception innerException)
			: this("{0}: {1} ({2})".FormatWith(message, name, serviceType.ToShortTypeName()), innerException)
		{
		}

		public ServiceControlException()
		{
		}

		public ServiceControlException(string message)
			: base(message)
		{
		}

		public ServiceControlException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected ServiceControlException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}