using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020009F1 RID: 2545
	[Token(Token = "0x20009F1")]
	public class PlayerTemplateTrap
	{
		// Token: 0x060066B7 RID: 26295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066B7")]
		[Address(RVA = "0x1EFF820", Offset = "0x1EFE420", VA = "0x181EFF820")]
		public PlayerTemplateTrap()
		{
		}

		// Token: 0x0400372B RID: 14123
		[Token(Token = "0x400372B")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerTemplateTrap.Domin> domains;

		// Token: 0x020009F2 RID: 2546
		[Token(Token = "0x20009F2")]
		public class Trap
		{
			// Token: 0x060066B8 RID: 26296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066B8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Trap()
			{
			}

			// Token: 0x0400372C RID: 14124
			[Token(Token = "0x400372C")]
			[FieldOffset(Offset = "0x10")]
			public int count;
		}

		// Token: 0x020009F3 RID: 2547
		[Token(Token = "0x20009F3")]
		public class Domin
		{
			// Token: 0x060066B9 RID: 26297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066B9")]
			[Address(RVA = "0x1EE9B40", Offset = "0x1EE8740", VA = "0x181EE9B40")]
			public Domin()
			{
			}

			// Token: 0x0400372D RID: 14125
			[Token(Token = "0x400372D")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, PlayerTemplateTrap.Trap> traps;

			// Token: 0x0400372E RID: 14126
			[Token(Token = "0x400372E")]
			[FieldOffset(Offset = "0x18")]
			public List<string> squad;
		}
	}
}
