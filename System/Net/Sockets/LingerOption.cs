using System;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003B6 RID: 950
	[Token(Token = "0x20003B6")]
	public class LingerOption
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DE")]
		[Address(RVA = "0x50BCB80", Offset = "0x50BB780", VA = "0x1850BCB80")]
		public LingerOption(bool enable, int seconds)
		{
		}

		// Token: 0x170005A2 RID: 1442
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A2")]
		public bool Enabled
		{
			[Token(Token = "0x60019DF")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A3")]
		public int LingerTime
		{
			[Token(Token = "0x60019E0")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			set
			{
			}
		}

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x10")]
		private bool enabled;

		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x14")]
		private int lingerTime;
	}
}
