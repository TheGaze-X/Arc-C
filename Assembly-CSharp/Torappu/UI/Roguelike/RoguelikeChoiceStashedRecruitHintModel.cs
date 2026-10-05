using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051B9 RID: 20921
	[Token(Token = "0x20051B9")]
	public class RoguelikeChoiceStashedRecruitHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x0601EE64 RID: 126564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE64")]
		[Address(RVA = "0x18A4760", Offset = "0x18A3360", VA = "0x1818A4760", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x0601EE65 RID: 126565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE65")]
		[Address(RVA = "0x18A4930", Offset = "0x18A3530", VA = "0x1818A4930")]
		private string _GenHintForStashedRecruit()
		{
			return null;
		}

		// Token: 0x0601EE66 RID: 126566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE66")]
		[Address(RVA = "0x18A4AA0", Offset = "0x18A36A0", VA = "0x1818A4AA0")]
		public RoguelikeChoiceStashedRecruitHintModel()
		{
		}

		// Token: 0x0402974E RID: 169806
		[Token(Token = "0x402974E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402974F RID: 169807
		[Token(Token = "0x402974F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForStashedRecruit;

		// Token: 0x04029750 RID: 169808
		[Token(Token = "0x4029750")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
