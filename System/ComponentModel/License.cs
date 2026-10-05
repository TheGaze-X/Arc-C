using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	public abstract class License : IDisposable
	{
		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000B3D RID: 2877
		[Token(Token = "0x17000245")]
		public abstract string LicenseKey { [Token(Token = "0x6000B3D")] get; }

		// Token: 0x06000B3E RID: 2878
		[Token(Token = "0x6000B3E")]
		public abstract void Dispose();

		// Token: 0x06000B3F RID: 2879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected License()
		{
		}
	}
}
