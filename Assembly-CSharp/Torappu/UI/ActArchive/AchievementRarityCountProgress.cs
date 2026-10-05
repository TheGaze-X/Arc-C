using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AEB RID: 27371
	[Token(Token = "0x2006AEB")]
	public class AchievementRarityCountProgress : IHotfixable
	{
		// Token: 0x0602723E RID: 160318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602723E")]
		[Address(RVA = "0x224AC80", Offset = "0x2249880", VA = "0x18224AC80")]
		public AchievementRarityCountProgress()
		{
		}

		// Token: 0x040375E7 RID: 226791
		[Token(Token = "0x40375E7")]
		[FieldOffset(Offset = "0x10")]
		public int raritySortId;

		// Token: 0x040375E8 RID: 226792
		[Token(Token = "0x40375E8")]
		[FieldOffset(Offset = "0x14")]
		public int value;

		// Token: 0x040375E9 RID: 226793
		[Token(Token = "0x40375E9")]
		[FieldOffset(Offset = "0x18")]
		public int total;

		// Token: 0x040375EA RID: 226794
		[Token(Token = "0x40375EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
