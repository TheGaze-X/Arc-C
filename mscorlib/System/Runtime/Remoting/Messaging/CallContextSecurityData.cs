using System;
using System.Security.Principal;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003BB RID: 955
	[Token(Token = "0x20003BB")]
	[System.Serializable]
	internal class CallContextSecurityData : System.ICloneable
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00012E28 File Offset: 0x00011028
		[Token(Token = "0x170003A7")]
		internal bool HasInfo
		{
			[Token(Token = "0x6001E4B")]
			[Address(RVA = "0x1028420", Offset = "0x1027020", VA = "0x181028420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x4B726B0", Offset = "0x4B712B0", VA = "0x184B726B0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CallContextSecurityData()
		{
		}

		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x10")]
		private System.Security.Principal.IPrincipal _principal;
	}
}
