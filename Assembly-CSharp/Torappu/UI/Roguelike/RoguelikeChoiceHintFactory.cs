using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051BA RID: 20922
	[Token(Token = "0x20051BA")]
	public class RoguelikeChoiceHintFactory : IHotfixable
	{
		// Token: 0x0601EE67 RID: 126567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE67")]
		[Address(RVA = "0x18A1730", Offset = "0x18A0330", VA = "0x1818A1730", Slot = "4")]
		public virtual IRoguelikeChoiceHintModel Create(RoguelikeChoiceHintType hintType)
		{
			return null;
		}

		// Token: 0x0601EE68 RID: 126568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE68")]
		[Address(RVA = "0x18A1AD0", Offset = "0x18A06D0", VA = "0x1818A1AD0")]
		public RoguelikeChoiceHintFactory()
		{
		}

		// Token: 0x04029751 RID: 169809
		[Token(Token = "0x4029751")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04029752 RID: 169810
		[Token(Token = "0x4029752")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
