using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051B8 RID: 20920
	[Token(Token = "0x20051B8")]
	public class RoguelikeChoiceHPHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x0601EE61 RID: 126561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE61")]
		[Address(RVA = "0x18A13A0", Offset = "0x189FFA0", VA = "0x1818A13A0", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x0601EE62 RID: 126562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE62")]
		[Address(RVA = "0x18A1560", Offset = "0x18A0160", VA = "0x1818A1560")]
		private string _GenHintForHp()
		{
			return null;
		}

		// Token: 0x0601EE63 RID: 126563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE63")]
		[Address(RVA = "0x18A16C0", Offset = "0x18A02C0", VA = "0x1818A16C0")]
		public RoguelikeChoiceHPHintModel()
		{
		}

		// Token: 0x0402974B RID: 169803
		[Token(Token = "0x402974B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402974C RID: 169804
		[Token(Token = "0x402974C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForHp;

		// Token: 0x0402974D RID: 169805
		[Token(Token = "0x402974D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
