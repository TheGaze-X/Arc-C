using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051B4 RID: 20916
	[Token(Token = "0x20051B4")]
	public class RoguelikeChoiceItemHintModel : RoguelikeChoiceHintModel<RoguelikeItemChoiceModel.Context>
	{
		// Token: 0x0601EE56 RID: 126550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE56")]
		[Address(RVA = "0x18A1B30", Offset = "0x18A0730", VA = "0x1818A1B30", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeItemChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x0601EE57 RID: 126551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE57")]
		[Address(RVA = "0x18A1D40", Offset = "0x18A0940", VA = "0x1818A1D40")]
		public RoguelikeChoiceItemHintModel()
		{
		}

		// Token: 0x04029741 RID: 169793
		[Token(Token = "0x4029741")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x04029742 RID: 169794
		[Token(Token = "0x4029742")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
