using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003DA RID: 986
	[Token(Token = "0x20003DA")]
	[System.CLSCompliant(false)]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, System.Runtime.Serialization.ISerializable, IInternalMessage
	{
		// Token: 0x06001F07 RID: 7943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x4B9F800", Offset = "0x4B9E400", VA = "0x184B9F800")]
		internal MethodResponse(System.Exception e, IMethodCallMessage msg)
		{
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F08")]
		[Address(RVA = "0x4B9F8F0", Offset = "0x4B9E4F0", VA = "0x184B9F8F0")]
		internal MethodResponse(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg)
		{
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F09")]
		[Address(RVA = "0x4B9F9C0", Offset = "0x4B9E5C0", VA = "0x184B9F9C0")]
		internal MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg)
		{
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0x4B9FBC0", Offset = "0x4B9E7C0", VA = "0x184B9FBC0")]
		internal MethodResponse(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0x4B9F190", Offset = "0x4B9DD90", VA = "0x184B9F190")]
		internal void InitMethodProperty(string key, object value)
		{
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00013020 File Offset: 0x00011220
		[Token(Token = "0x170003EF")]
		public int ArgCount
		{
			[Token(Token = "0x6001F0C")]
			[Address(RVA = "0x4B9FD90", Offset = "0x4B9E990", VA = "0x184B9FD90", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003F0")]
		public object[] Args
		{
			[Token(Token = "0x6001F0D")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003F1")]
		public System.Exception Exception
		{
			[Token(Token = "0x6001F0E")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003F2")]
		public LogicalCallContext LogicalCallContext
		{
			[Token(Token = "0x6001F0F")]
			[Address(RVA = "0x4B9FDA0", Offset = "0x4B9E9A0", VA = "0x184B9FDA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003F3")]
		public System.Reflection.MethodBase MethodBase
		{
			[Token(Token = "0x6001F10")]
			[Address(RVA = "0x4B9FE20", Offset = "0x4B9EA20", VA = "0x184B9FE20", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003F4")]
		public string MethodName
		{
			[Token(Token = "0x6001F11")]
			[Address(RVA = "0x4B9FFA0", Offset = "0x4B9EBA0", VA = "0x184B9FFA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003F5")]
		public object MethodSignature
		{
			[Token(Token = "0x6001F12")]
			[Address(RVA = "0x4BA0010", Offset = "0x4B9EC10", VA = "0x184BA0010", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003F6")]
		public object[] OutArgs
		{
			[Token(Token = "0x6001F13")]
			[Address(RVA = "0x4BA00E0", Offset = "0x4B9ECE0", VA = "0x184BA00E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003F7")]
		public virtual System.Collections.IDictionary Properties
		{
			[Token(Token = "0x6001F14")]
			[Address(RVA = "0x4BA0300", Offset = "0x4B9EF00", VA = "0x184BA0300", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003F8")]
		public object ReturnValue
		{
			[Token(Token = "0x6001F15")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003F9")]
		public string TypeName
		{
			[Token(Token = "0x6001F16")]
			[Address(RVA = "0x4BA03A0", Offset = "0x4B9EFA0", VA = "0x184BA03A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FA")]
		public string Uri
		{
			[Token(Token = "0x6001F17")]
			[Address(RVA = "0x4B9F790", Offset = "0x4B9E390", VA = "0x184B9F790", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F18")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FB")]
		private string Uri
		{
			[Token(Token = "0x6001F19")]
			[Address(RVA = "0x4B9F790", Offset = "0x4B9E390", VA = "0x184B9F790", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F1A")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0x4B9DE10", Offset = "0x4B9CA10", VA = "0x184B9DE10", Slot = "15")]
		public object GetArg(int argNum)
		{
			return null;
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x4B9DE40", Offset = "0x4B9CA40", VA = "0x184B9DE40", Slot = "23")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FC")]
		private Identity TargetIdentity
		{
			[Token(Token = "0x6001F1D")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70", Slot = "18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F1E")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x0400105F RID: 4191
		[Token(Token = "0x400105F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _methodName;

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _uri;

		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _typeName;

		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Reflection.MethodBase _methodBase;

		// Token: 0x04001063 RID: 4195
		[Token(Token = "0x4001063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object _returnValue;

		// Token: 0x04001064 RID: 4196
		[Token(Token = "0x4001064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private System.Exception _exception;

		// Token: 0x04001065 RID: 4197
		[Token(Token = "0x4001065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private System.Type[] _methodSignature;

		// Token: 0x04001066 RID: 4198
		[Token(Token = "0x4001066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ArgInfo _inArgInfo;

		// Token: 0x04001067 RID: 4199
		[Token(Token = "0x4001067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private object[] _args;

		// Token: 0x04001068 RID: 4200
		[Token(Token = "0x4001068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private object[] _outArgs;

		// Token: 0x04001069 RID: 4201
		[Token(Token = "0x4001069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IMethodCallMessage _callMsg;

		// Token: 0x0400106A RID: 4202
		[Token(Token = "0x400106A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private LogicalCallContext _callContext;

		// Token: 0x0400106B RID: 4203
		[Token(Token = "0x400106B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Identity _targetIdentity;

		// Token: 0x0400106C RID: 4204
		[Token(Token = "0x400106C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected System.Collections.IDictionary ExternalProperties;

		// Token: 0x0400106D RID: 4205
		[Token(Token = "0x400106D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected System.Collections.IDictionary InternalProperties;
	}
}
