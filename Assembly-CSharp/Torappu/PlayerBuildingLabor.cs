using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A35 RID: 2613
	[Token(Token = "0x2000A35")]
	public class PlayerBuildingLabor
	{
		// Token: 0x060066F3 RID: 26355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingLabor()
		{
		}

		// Token: 0x040037FC RID: 14332
		[Token(Token = "0x40037FC")]
		[FieldOffset(Offset = "0x10")]
		public float buffSpeed;

		// Token: 0x040037FD RID: 14333
		[Token(Token = "0x40037FD")]
		[FieldOffset(Offset = "0x14")]
		public int value;

		// Token: 0x040037FE RID: 14334
		[Token(Token = "0x40037FE")]
		[FieldOffset(Offset = "0x18")]
		public int maxValue;

		// Token: 0x040037FF RID: 14335
		[Token(Token = "0x40037FF")]
		[FieldOffset(Offset = "0x20")]
		public DateTime lastUpdateTime;

		// Token: 0x04003800 RID: 14336
		[Token(Token = "0x4003800")]
		[FieldOffset(Offset = "0x28")]
		public double processPoint;
	}
}
