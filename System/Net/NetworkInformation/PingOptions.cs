using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200036C RID: 876
	[Token(Token = "0x200036C")]
	public class PingOptions
	{
		// Token: 0x0600184E RID: 6222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184E")]
		[Address(RVA = "0x50A1DC0", Offset = "0x50A09C0", VA = "0x1850A1DC0")]
		public PingOptions()
		{
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x17000559")]
		public int Ttl
		{
			[Token(Token = "0x600184F")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x0000AF80 File Offset: 0x00009180
		[Token(Token = "0x1700055A")]
		public bool DontFragment
		{
			[Token(Token = "0x6001850")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000E74 RID: 3700
		[Token(Token = "0x4000E74")]
		[FieldOffset(Offset = "0x10")]
		private int ttl;

		// Token: 0x04000E75 RID: 3701
		[Token(Token = "0x4000E75")]
		[FieldOffset(Offset = "0x14")]
		private bool dontFragment;
	}
}
