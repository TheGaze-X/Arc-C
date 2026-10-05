using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
	{
		// Token: 0x06001F44 RID: 8004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F44")]
		[Address(RVA = "0x4BA9300", Offset = "0x4BA7F00", VA = "0x184BA9300")]
		public ReturnMessage(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm)
		{
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F45")]
		[Address(RVA = "0x4BA91A0", Offset = "0x4BA7DA0", VA = "0x184BA91A0")]
		public ReturnMessage(System.Exception e, IMethodCallMessage mcm)
		{
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x00013098 File Offset: 0x00011298
		[Token(Token = "0x1700040D")]
		public int ArgCount
		{
			[Token(Token = "0x6001F46")]
			[Address(RVA = "0x4BA9410", Offset = "0x4BA8010", VA = "0x184BA9410", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700040E")]
		public object[] Args
		{
			[Token(Token = "0x6001F47")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700040F")]
		public LogicalCallContext LogicalCallContext
		{
			[Token(Token = "0x6001F48")]
			[Address(RVA = "0x4BA9430", Offset = "0x4BA8030", VA = "0x184BA9430", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000410")]
		public System.Reflection.MethodBase MethodBase
		{
			[Token(Token = "0x6001F49")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000411")]
		public string MethodName
		{
			[Token(Token = "0x6001F4A")]
			[Address(RVA = "0x4BA94B0", Offset = "0x4BA80B0", VA = "0x184BA94B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000412")]
		public object MethodSignature
		{
			[Token(Token = "0x6001F4B")]
			[Address(RVA = "0x4BA9540", Offset = "0x4BA8140", VA = "0x184BA9540", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000413")]
		public virtual System.Collections.IDictionary Properties
		{
			[Token(Token = "0x6001F4C")]
			[Address(RVA = "0x4BA97C0", Offset = "0x4BA83C0", VA = "0x184BA97C0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000414")]
		public string TypeName
		{
			[Token(Token = "0x6001F4D")]
			[Address(RVA = "0x4BA9850", Offset = "0x4BA8450", VA = "0x184BA9850", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000415")]
		public string Uri
		{
			[Token(Token = "0x6001F4E")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F4F")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001F51 RID: 8017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000416")]
		private string Uri
		{
			[Token(Token = "0x6001F50")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F51")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F52")]
		[Address(RVA = "0x4BA9170", Offset = "0x4BA7D70", VA = "0x184BA9170", Slot = "15")]
		public object GetArg(int argNum)
		{
			return null;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000417")]
		public System.Exception Exception
		{
			[Token(Token = "0x6001F53")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000418")]
		public object[] OutArgs
		{
			[Token(Token = "0x6001F54")]
			[Address(RVA = "0x4BA96F0", Offset = "0x4BA82F0", VA = "0x184BA96F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000419")]
		public virtual object ReturnValue
		{
			[Token(Token = "0x6001F55")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001F57 RID: 8023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041A")]
		private Identity TargetIdentity
		{
			[Token(Token = "0x6001F56")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F57")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object[] _outArgs;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object[] _args;

		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LogicalCallContext _callCtx;

		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object _returnValue;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _uri;

		// Token: 0x0400108B RID: 4235
		[Token(Token = "0x400108B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private System.Exception _exception;

		// Token: 0x0400108C RID: 4236
		[Token(Token = "0x400108C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private System.Reflection.MethodBase _methodBase;

		// Token: 0x0400108D RID: 4237
		[Token(Token = "0x400108D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _methodName;

		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private System.Type[] _methodSignature;

		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string _typeName;

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MethodReturnDictionary _properties;

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Identity _targetIdentity;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ArgInfo _inArgInfo;
	}
}
