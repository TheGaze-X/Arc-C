using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062FE RID: 25342
	[Token(Token = "0x20062FE")]
	public class AutoChessSettleGamePersonalEquipItemViewModel : IComparable<AutoChessSettleGamePersonalEquipItemViewModel>, IHotfixable
	{
		// Token: 0x06024870 RID: 149616 RVA: 0x000C47A0 File Offset: 0x000C29A0
		[Token(Token = "0x6024870")]
		[Address(RVA = "0x1F56080", Offset = "0x1F54C80", VA = "0x181F56080", Slot = "4")]
		public int CompareTo(AutoChessSettleGamePersonalEquipItemViewModel other)
		{
			return 0;
		}

		// Token: 0x06024871 RID: 149617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024871")]
		[Address(RVA = "0x1F56170", Offset = "0x1F54D70", VA = "0x181F56170")]
		public AutoChessSettleGamePersonalEquipItemViewModel()
		{
		}

		// Token: 0x04032F09 RID: 208649
		[Token(Token = "0x4032F09")]
		[FieldOffset(Offset = "0x10")]
		public string equipIconId;

		// Token: 0x04032F0A RID: 208650
		[Token(Token = "0x4032F0A")]
		[FieldOffset(Offset = "0x18")]
		public bool isGolden;

		// Token: 0x04032F0B RID: 208651
		[Token(Token = "0x4032F0B")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x04032F0C RID: 208652
		[Token(Token = "0x4032F0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04032F0D RID: 208653
		[Token(Token = "0x4032F0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
