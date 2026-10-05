using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200713B RID: 28987
	[Token(Token = "0x200713B")]
	public class ActAutoChessDifficultyRewardModel : IHotfixable, IComparable
	{
		// Token: 0x0602926D RID: 168557 RVA: 0x000D4A00 File Offset: 0x000D2C00
		[Token(Token = "0x602926D")]
		[Address(RVA = "0x247DF80", Offset = "0x247CB80", VA = "0x18247DF80", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0602926E RID: 168558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602926E")]
		[Address(RVA = "0x247E0C0", Offset = "0x247CCC0", VA = "0x18247E0C0")]
		public ActAutoChessDifficultyRewardModel()
		{
		}

		// Token: 0x0403AC65 RID: 240741
		[Token(Token = "0x403AC65")]
		[FieldOffset(Offset = "0x10")]
		public ActAutoChessModeDifficultyType difficulty;

		// Token: 0x0403AC66 RID: 240742
		[Token(Token = "0x403AC66")]
		[FieldOffset(Offset = "0x14")]
		public float factor;

		// Token: 0x0403AC67 RID: 240743
		[Token(Token = "0x403AC67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403AC68 RID: 240744
		[Token(Token = "0x403AC68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
