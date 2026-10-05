using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	public struct X509ChainStatus
	{
		// Token: 0x06000847 RID: 2119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x5134640", Offset = "0x5133240", VA = "0x185134640")]
		internal X509ChainStatus(X509ChainStatusFlags flag)
		{
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00005238 File Offset: 0x00003438
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019F")]
		public X509ChainStatusFlags Status
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return X509ChainStatusFlags.NoError;
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			set
			{
			}
		}

		// Token: 0x170001A0 RID: 416
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A0")]
		public string StatusInformation
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
			set
			{
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x51344C0", Offset = "0x51330C0", VA = "0x1851344C0")]
		internal static string GetInformation(X509ChainStatusFlags flags)
		{
			return null;
		}

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x0")]
		private X509ChainStatusFlags status;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x8")]
		private string info;
	}
}
