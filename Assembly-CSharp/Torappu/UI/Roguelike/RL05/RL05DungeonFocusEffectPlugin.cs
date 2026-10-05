using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055CE RID: 21966
	[Token(Token = "0x20055CE")]
	public class RL05DungeonFocusEffectPlugin : RoguelikeDungeonEffectPlugin
	{
		// Token: 0x060203FC RID: 132092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203FC")]
		[Address(RVA = "0x1A5E190", Offset = "0x1A5CD90", VA = "0x181A5E190", Slot = "4")]
		public override void RenderView(RoguelikeFocusViewModel viewModel)
		{
		}

		// Token: 0x060203FD RID: 132093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203FD")]
		[Address(RVA = "0x1A5E330", Offset = "0x1A5CF30", VA = "0x181A5E330")]
		private void _SetColorWithoutAlpha(Color color)
		{
		}

		// Token: 0x060203FE RID: 132094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203FE")]
		[Address(RVA = "0x1A5E470", Offset = "0x1A5D070", VA = "0x181A5E470")]
		public RL05DungeonFocusEffectPlugin()
		{
		}

		// Token: 0x0402B9DD RID: 178653
		[Token(Token = "0x402B9DD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Graphic[] _colorGraphics;

		// Token: 0x0402B9DE RID: 178654
		[Token(Token = "0x402B9DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalNode;

		// Token: 0x0402B9DF RID: 178655
		[Token(Token = "0x402B9DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _skyZoneNode;

		// Token: 0x0402B9E0 RID: 178656
		[Token(Token = "0x402B9E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeNodeViewData _nodeViewData;

		// Token: 0x0402B9E1 RID: 178657
		[Token(Token = "0x402B9E1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _bossColor;

		// Token: 0x0402B9E2 RID: 178658
		[Token(Token = "0x402B9E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402B9E3 RID: 178659
		[Token(Token = "0x402B9E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetColorWithoutAlpha;

		// Token: 0x0402B9E4 RID: 178660
		[Token(Token = "0x402B9E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055CF RID: 21967
		[Token(Token = "0x20055CF")]
		[Serializable]
		public struct TypeColorGroup
		{
			// Token: 0x0402B9E5 RID: 178661
			[Token(Token = "0x402B9E5")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeEventType nodeType;

			// Token: 0x0402B9E6 RID: 178662
			[Token(Token = "0x402B9E6")]
			[FieldOffset(Offset = "0x4")]
			public Color frontColor;

			// Token: 0x0402B9E7 RID: 178663
			[Token(Token = "0x402B9E7")]
			[FieldOffset(Offset = "0x14")]
			public Color backColor;
		}
	}
}
