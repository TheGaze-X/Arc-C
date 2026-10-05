using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A40 RID: 2624
	[Token(Token = "0x2000A40")]
	public class PlayerSkins
	{
		// Token: 0x060066FF RID: 26367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FF")]
		[Address(RVA = "0x1EFE940", Offset = "0x1EFD540", VA = "0x181EFE940")]
		public PlayerSkins()
		{
		}

		// Token: 0x0400381D RID: 14365
		[Token(Token = "0x400381D")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, int> characterSkins;

		// Token: 0x0400381E RID: 14366
		[Token(Token = "0x400381E")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, long> skinTs;

		// Token: 0x0400381F RID: 14367
		[Token(Token = "0x400381F")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, bool> skinSp;
	}
}
