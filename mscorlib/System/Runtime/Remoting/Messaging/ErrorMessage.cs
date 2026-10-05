using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003CC RID: 972
	[Token(Token = "0x20003CC")]
	[System.Serializable]
	internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
	{
		// Token: 0x06001EAA RID: 7850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0x4B7D5F0", Offset = "0x4B7C1F0", VA = "0x184B7D5F0")]
		public ErrorMessage()
		{
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x00012F18 File Offset: 0x00011118
		[Token(Token = "0x170003BE")]
		public int ArgCount
		{
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003BF")]
		public object[] Args
		{
			[Token(Token = "0x6001EAC")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003C0")]
		public System.Reflection.MethodBase MethodBase
		{
			[Token(Token = "0x6001EAD")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003C1")]
		public string MethodName
		{
			[Token(Token = "0x6001EAE")]
			[Address(RVA = "0x4B7D640", Offset = "0x4B7C240", VA = "0x184B7D640", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003C2")]
		public object MethodSignature
		{
			[Token(Token = "0x6001EAF")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003C3")]
		public virtual System.Collections.IDictionary Properties
		{
			[Token(Token = "0x6001EB0")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003C4")]
		public string TypeName
		{
			[Token(Token = "0x6001EB1")]
			[Address(RVA = "0x4B7D670", Offset = "0x4B7C270", VA = "0x184B7D670", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003C5")]
		public string Uri
		{
			[Token(Token = "0x6001EB2")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "12")]
		public object GetArg(int arg_num)
		{
			return null;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003C6")]
		public LogicalCallContext LogicalCallContext
		{
			[Token(Token = "0x6001EB4")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x10")]
		private string _uri;
	}
}
