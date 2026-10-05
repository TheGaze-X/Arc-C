using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052FB RID: 21243
	[Token(Token = "0x20052FB")]
	public class RoguelikeMenuInitSquadObject : RoguelikeMenuObject<RoguelikeMenuRelicViewModel>
	{
		// Token: 0x0601F55F RID: 128351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F55F")]
		[Address(RVA = "0x1911220", Offset = "0x190FE20", VA = "0x181911220", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x17004984 RID: 18820
		// (get) Token: 0x0601F560 RID: 128352 RVA: 0x000B1900 File Offset: 0x000AFB00
		[Token(Token = "0x17004984")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F560")]
			[Address(RVA = "0x1911910", Offset = "0x1910510", VA = "0x181911910", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F561 RID: 128353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F561")]
		[Address(RVA = "0x19113C0", Offset = "0x190FFC0", VA = "0x1819113C0", Slot = "16")]
		public override void Render(RoguelikeMenuRelicViewModel viewModel)
		{
		}

		// Token: 0x0601F562 RID: 128354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F562")]
		[Address(RVA = "0x1911880", Offset = "0x1910480", VA = "0x181911880")]
		public RoguelikeMenuInitSquadObject()
		{
		}

		// Token: 0x0601F564 RID: 128356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F564")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0402A19B RID: 172443
		[Token(Token = "0x402A19B")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 HIDE_POS;

		// Token: 0x0402A19C RID: 172444
		[Token(Token = "0x402A19C")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 SHOW_POS;

		// Token: 0x0402A19D RID: 172445
		[Token(Token = "0x402A19D")]
		[FieldOffset(Offset = "0x10")]
		private static Color NORMAL_SQUAD_ICON_COLOR;

		// Token: 0x0402A19E RID: 172446
		[Token(Token = "0x402A19E")]
		[FieldOffset(Offset = "0x20")]
		private static Color UPGRADABLE_SQUAD_ICON_COLOR;

		// Token: 0x0402A19F RID: 172447
		[Token(Token = "0x402A19F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402A1A0 RID: 172448
		[Token(Token = "0x402A1A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402A1A1 RID: 172449
		[Token(Token = "0x402A1A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imageUpgradeRank;

		// Token: 0x0402A1A2 RID: 172450
		[Token(Token = "0x402A1A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _squadUpgradeRankAtlas;

		// Token: 0x0402A1A3 RID: 172451
		[Token(Token = "0x402A1A3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string[] _squadUpgradeRankImageName;

		// Token: 0x0402A1A4 RID: 172452
		[Token(Token = "0x402A1A4")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeRelicViewModel m_cachedModel;

		// Token: 0x0402A1A5 RID: 172453
		[Token(Token = "0x402A1A5")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedItemId;

		// Token: 0x0402A1A6 RID: 172454
		[Token(Token = "0x402A1A6")]
		[FieldOffset(Offset = "0x60")]
		private FadeTranslationSwitchTween m_showSwitchTween;

		// Token: 0x0402A1A7 RID: 172455
		[Token(Token = "0x402A1A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A1A8 RID: 172456
		[Token(Token = "0x402A1A8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A1A9 RID: 172457
		[Token(Token = "0x402A1A9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A1AA RID: 172458
		[Token(Token = "0x402A1AA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
