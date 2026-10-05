using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E97 RID: 16023
	[Token(Token = "0x2003E97")]
	public class SpecialOperatorBoardEvolveMaxViewModel : ISpecialOperatorBoardEvolveItemViewModel, IHotfixable
	{
		// Token: 0x06018E12 RID: 101906 RVA: 0x0009C4C8 File Offset: 0x0009A6C8
		[Token(Token = "0x6018E12")]
		[Address(RVA = "0x1186490", Offset = "0x1185090", VA = "0x181186490", Slot = "4")]
		public SpecialOperatorBoardEvolveItemType GetItemType()
		{
			return SpecialOperatorBoardEvolveItemType.LINE;
		}

		// Token: 0x06018E13 RID: 101907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E13")]
		[Address(RVA = "0x11864F0", Offset = "0x11850F0", VA = "0x1811864F0", Slot = "5")]
		public void RefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06018E14 RID: 101908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E14")]
		[Address(RVA = "0x1186550", Offset = "0x1185150", VA = "0x181186550")]
		public SpecialOperatorBoardEvolveMaxViewModel()
		{
		}

		// Token: 0x0401EA87 RID: 125575
		[Token(Token = "0x401EA87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetItemType;

		// Token: 0x0401EA88 RID: 125576
		[Token(Token = "0x401EA88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401EA89 RID: 125577
		[Token(Token = "0x401EA89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
