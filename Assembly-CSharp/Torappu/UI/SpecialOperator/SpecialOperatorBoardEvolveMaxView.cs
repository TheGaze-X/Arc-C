using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E8A RID: 16010
	[Token(Token = "0x2003E8A")]
	public class SpecialOperatorBoardEvolveMaxView : SpecialOperatorBoardEvolveItemView
	{
		// Token: 0x06018DED RID: 101869 RVA: 0x0009C3F0 File Offset: 0x0009A5F0
		[Token(Token = "0x6018DED")]
		[Address(RVA = "0x11865B0", Offset = "0x11851B0", VA = "0x1811865B0", Slot = "4")]
		public override SpecialOperatorBoardEvolveItemType GetItemType()
		{
			return SpecialOperatorBoardEvolveItemType.LINE;
		}

		// Token: 0x06018DEE RID: 101870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DEE")]
		[Address(RVA = "0x1186610", Offset = "0x1185210", VA = "0x181186610", Slot = "5")]
		public override void Render(ISpecialOperatorBoardEvolveItemViewModel viewModel, SpecialOperatorBoardEvolveItemView.Param param)
		{
		}

		// Token: 0x06018DEF RID: 101871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DEF")]
		[Address(RVA = "0x1186690", Offset = "0x1185290", VA = "0x181186690")]
		public SpecialOperatorBoardEvolveMaxView()
		{
		}

		// Token: 0x0401EA17 RID: 125463
		[Token(Token = "0x401EA17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetItemType;

		// Token: 0x0401EA18 RID: 125464
		[Token(Token = "0x401EA18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EA19 RID: 125465
		[Token(Token = "0x401EA19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
