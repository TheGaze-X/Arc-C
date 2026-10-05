using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003DC RID: 988
	[Token(Token = "0x20003DC")]
	[System.Serializable]
	[StructLayout(0)]
	internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage
	{
		// Token: 0x06001F21 RID: 7969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x4BA0A30", Offset = "0x4B9F630", VA = "0x184BA0A30")]
		internal void InitMessage(RuntimeMethodInfo method, object[] out_args)
		{
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x4BA1180", Offset = "0x4B9FD80", VA = "0x184BA1180")]
		public MonoMethodMessage(System.Reflection.MethodBase method, object[] out_args)
		{
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x4BA1010", Offset = "0x4B9FC10", VA = "0x184BA1010")]
		internal MonoMethodMessage(System.Reflection.MethodInfo minfo, object[] in_args, object[] out_args)
		{
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x4BA0960", Offset = "0x4B9F560", VA = "0x184BA0960")]
		private static System.Reflection.MethodInfo GetMethodInfo(System.Type type, string methodName)
		{
			return null;
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x4BA0E00", Offset = "0x4B9FA00", VA = "0x184BA0E00")]
		public MonoMethodMessage(System.Type type, string methodName, object[] in_args)
		{
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003FD")]
		public System.Collections.IDictionary Properties
		{
			[Token(Token = "0x6001F26")]
			[Address(RVA = "0x4BA1790", Offset = "0x4BA0390", VA = "0x184BA1790", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x00013038 File Offset: 0x00011238
		[Token(Token = "0x170003FE")]
		public int ArgCount
		{
			[Token(Token = "0x6001F27")]
			[Address(RVA = "0x4BA1280", Offset = "0x4B9FE80", VA = "0x184BA1280", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003FF")]
		public object[] Args
		{
			[Token(Token = "0x6001F28")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000400")]
		public LogicalCallContext LogicalCallContext
		{
			[Token(Token = "0x6001F29")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F2A")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000401")]
		public System.Reflection.MethodBase MethodBase
		{
			[Token(Token = "0x6001F2B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000402")]
		public string MethodName
		{
			[Token(Token = "0x6001F2C")]
			[Address(RVA = "0x4BA1380", Offset = "0x4B9FF80", VA = "0x184BA1380", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000403")]
		public object MethodSignature
		{
			[Token(Token = "0x6001F2D")]
			[Address(RVA = "0x4BA1410", Offset = "0x4BA0010", VA = "0x184BA1410", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000404")]
		public string TypeName
		{
			[Token(Token = "0x6001F2E")]
			[Address(RVA = "0x4BA1820", Offset = "0x4BA0420", VA = "0x184BA1820", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000405")]
		public string Uri
		{
			[Token(Token = "0x6001F2F")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F30")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x4BA0930", Offset = "0x4B9F530", VA = "0x184BA0930", Slot = "12")]
		public object GetArg(int arg_num)
		{
			return null;
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000406")]
		public System.Exception Exception
		{
			[Token(Token = "0x6001F32")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x00013050 File Offset: 0x00011250
		[Token(Token = "0x17000407")]
		public int OutArgCount
		{
			[Token(Token = "0x6001F33")]
			[Address(RVA = "0x4BA1590", Offset = "0x4BA0190", VA = "0x184BA1590", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000408")]
		public object[] OutArgs
		{
			[Token(Token = "0x6001F34")]
			[Address(RVA = "0x4BA15F0", Offset = "0x4BA01F0", VA = "0x184BA15F0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000409")]
		public object ReturnValue
		{
			[Token(Token = "0x6001F35")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001F37 RID: 7991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040A")]
		private Identity TargetIdentity
		{
			[Token(Token = "0x6001F36")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F37")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700040B")]
		public AsyncResult AsyncResult
		{
			[Token(Token = "0x6001F38")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x00013068 File Offset: 0x00011268
		[Token(Token = "0x1700040C")]
		internal CallType CallType
		{
			[Token(Token = "0x6001F39")]
			[Address(RVA = "0x4BA1310", Offset = "0x4B9FF10", VA = "0x184BA1310")]
			get
			{
				return CallType.Sync;
			}
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00013080 File Offset: 0x00011280
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0x4BA0D80", Offset = "0x4B9F980", VA = "0x184BA0D80")]
		public bool NeedsOutProcessing(out int outCount)
		{
			return default(bool);
		}

		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RuntimeMethodInfo method;

		// Token: 0x04001071 RID: 4209
		[Token(Token = "0x4001071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object[] args;

		// Token: 0x04001072 RID: 4210
		[Token(Token = "0x4001072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string[] names;

		// Token: 0x04001073 RID: 4211
		[Token(Token = "0x4001073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] arg_types;

		// Token: 0x04001074 RID: 4212
		[Token(Token = "0x4001074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LogicalCallContext ctx;

		// Token: 0x04001075 RID: 4213
		[Token(Token = "0x4001075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object rval;

		// Token: 0x04001076 RID: 4214
		[Token(Token = "0x4001076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public System.Exception exc;

		// Token: 0x04001077 RID: 4215
		[Token(Token = "0x4001077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AsyncResult asyncResult;

		// Token: 0x04001078 RID: 4216
		[Token(Token = "0x4001078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CallType call_type;

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string uri;

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x400107A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MCMDictionary properties;

		// Token: 0x0400107B RID: 4219
		[Token(Token = "0x400107B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Identity identity;

		// Token: 0x0400107C RID: 4220
		[Token(Token = "0x400107C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private System.Type[] methodSignature;
	}
}
