using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051DA RID: 20954
	[Token(Token = "0x20051DA")]
	public abstract class AbstractRoguelikeDrawCopperView : DataBinder<RoguelikeDrawCopperProperty>
	{
		// Token: 0x17004844 RID: 18500
		// (get) Token: 0x0601EF2B RID: 126763
		// (set) Token: 0x0601EF2C RID: 126764
		[Token(Token = "0x17004844")]
		public abstract Action onConfirmDrawPending { [Token(Token = "0x601EF2B")] get; [Token(Token = "0x601EF2C")] set; }

		// Token: 0x0601EF2D RID: 126765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF2D")]
		[Address(RVA = "0x18AD470", Offset = "0x18AC070", VA = "0x1818AD470", Slot = "7")]
		public override void OnValueChanged(RoguelikeDrawCopperProperty property)
		{
		}

		// Token: 0x0601EF2E RID: 126766
		[Token(Token = "0x601EF2E")]
		protected abstract void _Render(RoguelikeDrawCopperViewModel model);

		// Token: 0x0601EF2F RID: 126767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF2F")]
		[Address(RVA = "0x18AD520", Offset = "0x18AC120", VA = "0x1818AD520")]
		protected AbstractRoguelikeDrawCopperView()
		{
		}

		// Token: 0x0402988A RID: 170122
		[Token(Token = "0x402988A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402988B RID: 170123
		[Token(Token = "0x402988B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
