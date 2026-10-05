using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.Roguelike.Copper
{
	// Token: 0x0200589E RID: 22686
	[Token(Token = "0x200589E")]
	public abstract class AbstractRoguelikeSwapCopperView : DataBinder<RoguelikeSwapCopperProperty>
	{
		// Token: 0x06021206 RID: 135686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021206")]
		[Address(RVA = "0x1B705E0", Offset = "0x1B6F1E0", VA = "0x181B705E0", Slot = "7")]
		public override void OnValueChanged(RoguelikeSwapCopperProperty property)
		{
		}

		// Token: 0x06021207 RID: 135687
		[Token(Token = "0x6021207")]
		protected abstract void _Render(RoguelikeSwapCopperViewModel model);

		// Token: 0x06021208 RID: 135688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021208")]
		[Address(RVA = "0x1B70690", Offset = "0x1B6F290", VA = "0x181B70690")]
		protected AbstractRoguelikeSwapCopperView()
		{
		}

		// Token: 0x0402D1AD RID: 184749
		[Token(Token = "0x402D1AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402D1AE RID: 184750
		[Token(Token = "0x402D1AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
