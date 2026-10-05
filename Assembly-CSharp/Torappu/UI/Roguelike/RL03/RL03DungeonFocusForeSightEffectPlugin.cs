using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x020057FC RID: 22524
	[Token(Token = "0x20057FC")]
	public class RL03DungeonFocusForeSightEffectPlugin : RoguelikeDungeonEffectPlugin
	{
		// Token: 0x06020ECE RID: 134862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ECE")]
		[Address(RVA = "0x1B30590", Offset = "0x1B2F190", VA = "0x181B30590", Slot = "4")]
		public override void RenderView(RoguelikeFocusViewModel viewModel)
		{
		}

		// Token: 0x06020ECF RID: 134863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ECF")]
		[Address(RVA = "0x1B30680", Offset = "0x1B2F280", VA = "0x181B30680")]
		public RL03DungeonFocusForeSightEffectPlugin()
		{
		}

		// Token: 0x0402CC29 RID: 183337
		[Token(Token = "0x402CC29")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _hidePart;

		// Token: 0x0402CC2A RID: 183338
		[Token(Token = "0x402CC2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _clearPart;

		// Token: 0x0402CC2B RID: 183339
		[Token(Token = "0x402CC2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402CC2C RID: 183340
		[Token(Token = "0x402CC2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
