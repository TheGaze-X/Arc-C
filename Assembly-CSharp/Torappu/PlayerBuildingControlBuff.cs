using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A55 RID: 2645
	[Token(Token = "0x2000A55")]
	public class PlayerBuildingControlBuff
	{
		// Token: 0x06006714 RID: 26388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006714")]
		[Address(RVA = "0x1EF1600", Offset = "0x1EF0200", VA = "0x181EF1600")]
		public PlayerBuildingControlBuff()
		{
		}

		// Token: 0x0400385A RID: 14426
		[Token(Token = "0x400385A")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingControlBuff.Global global;

		// Token: 0x02000A56 RID: 2646
		[Token(Token = "0x2000A56")]
		public class Global
		{
			// Token: 0x06006715 RID: 26389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006715")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Global()
			{
			}

			// Token: 0x0400385B RID: 14427
			[Token(Token = "0x400385B")]
			[FieldOffset(Offset = "0x10")]
			public int apCost;
		}
	}
}
