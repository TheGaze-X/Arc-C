using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	[System.Serializable]
	internal class CallContextRemotingData : System.ICloneable
	{
		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A8")]
		internal string LogicalCallID
		{
			[Token(Token = "0x6001E4E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E4F")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00012E40 File Offset: 0x00011040
		[Token(Token = "0x170003A9")]
		internal bool HasInfo
		{
			[Token(Token = "0x6001E50")]
			[Address(RVA = "0x1028420", Offset = "0x1027020", VA = "0x181028420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x4B72640", Offset = "0x4B71240", VA = "0x184B72640", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CallContextRemotingData()
		{
		}

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x10")]
		private string _logicalCallID;
	}
}
