using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056B1 RID: 22193
	[Token(Token = "0x20056B1")]
	public class RL04DungeonFocusEffectPlugin : RoguelikeDungeonEffectPlugin
	{
		// Token: 0x060208E4 RID: 133348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208E4")]
		[Address(RVA = "0x1AA7CE0", Offset = "0x1AA68E0", VA = "0x181AA7CE0", Slot = "4")]
		public override void RenderView(RoguelikeFocusViewModel viewModel)
		{
		}

		// Token: 0x060208E5 RID: 133349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208E5")]
		[Address(RVA = "0x1AA7E80", Offset = "0x1AA6A80", VA = "0x181AA7E80")]
		public RL04DungeonFocusEffectPlugin()
		{
		}

		// Token: 0x0402C1A9 RID: 180649
		[Token(Token = "0x402C1A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RL04DungeonFocusEffectPlugin.TypeColorGroup> _colorConfigs;

		// Token: 0x0402C1AA RID: 180650
		[Token(Token = "0x402C1AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _frontColor;

		// Token: 0x0402C1AB RID: 180651
		[Token(Token = "0x402C1AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _backColor;

		// Token: 0x0402C1AC RID: 180652
		[Token(Token = "0x402C1AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _bossFrontColor;

		// Token: 0x0402C1AD RID: 180653
		[Token(Token = "0x402C1AD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _bossBackColor;

		// Token: 0x0402C1AE RID: 180654
		[Token(Token = "0x402C1AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402C1AF RID: 180655
		[Token(Token = "0x402C1AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056B2 RID: 22194
		[Token(Token = "0x20056B2")]
		[Serializable]
		public struct TypeColorGroup
		{
			// Token: 0x0402C1B0 RID: 180656
			[Token(Token = "0x402C1B0")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeEventType nodeType;

			// Token: 0x0402C1B1 RID: 180657
			[Token(Token = "0x402C1B1")]
			[FieldOffset(Offset = "0x4")]
			public Color frontColor;

			// Token: 0x0402C1B2 RID: 180658
			[Token(Token = "0x402C1B2")]
			[FieldOffset(Offset = "0x14")]
			public Color backColor;
		}
	}
}
