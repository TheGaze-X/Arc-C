using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052FC RID: 21244
	[Token(Token = "0x20052FC")]
	public class RoguelikeMenuInitSquadWithDifficultyObject : RoguelikeMenuObject<RoguelikeMenuRelicViewModel>
	{
		// Token: 0x17004985 RID: 18821
		// (get) Token: 0x0601F565 RID: 128357 RVA: 0x000B1918 File Offset: 0x000AFB18
		[Token(Token = "0x17004985")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F565")]
			[Address(RVA = "0x19125F0", Offset = "0x19111F0", VA = "0x1819125F0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F566 RID: 128358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F566")]
		[Address(RVA = "0x1911E20", Offset = "0x1910A20", VA = "0x181911E20", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x0601F567 RID: 128359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F567")]
		[Address(RVA = "0x1911FC0", Offset = "0x1910BC0", VA = "0x181911FC0", Slot = "16")]
		public override void Render(RoguelikeMenuRelicViewModel viewModel)
		{
		}

		// Token: 0x0601F568 RID: 128360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F568")]
		[Address(RVA = "0x19120E0", Offset = "0x1910CE0", VA = "0x1819120E0")]
		private void _RenderInitSquadWithDifficulty(RoguelikeMenuRelicViewModel viewModel)
		{
		}

		// Token: 0x0601F569 RID: 128361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F569")]
		[Address(RVA = "0x1912560", Offset = "0x1911160", VA = "0x181912560")]
		public RoguelikeMenuInitSquadWithDifficultyObject()
		{
		}

		// Token: 0x0601F56B RID: 128363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F56B")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0402A1AB RID: 172459
		[Token(Token = "0x402A1AB")]
		private const string BAND_RANK_FORMAT = "band_rank_{0}";

		// Token: 0x0402A1AC RID: 172460
		[Token(Token = "0x402A1AC")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 HIDE_POS;

		// Token: 0x0402A1AD RID: 172461
		[Token(Token = "0x402A1AD")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 SHOW_POS;

		// Token: 0x0402A1AE RID: 172462
		[Token(Token = "0x402A1AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402A1AF RID: 172463
		[Token(Token = "0x402A1AF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402A1B0 RID: 172464
		[Token(Token = "0x402A1B0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelDifficulty;

		// Token: 0x0402A1B1 RID: 172465
		[Token(Token = "0x402A1B1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgDifficulty;

		// Token: 0x0402A1B2 RID: 172466
		[Token(Token = "0x402A1B2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasObject _difficultyAtlasObject;

		// Token: 0x0402A1B3 RID: 172467
		[Token(Token = "0x402A1B3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtDifficulty;

		// Token: 0x0402A1B4 RID: 172468
		[Token(Token = "0x402A1B4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelBandRank;

		// Token: 0x0402A1B5 RID: 172469
		[Token(Token = "0x402A1B5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _imgBandRank;

		// Token: 0x0402A1B6 RID: 172470
		[Token(Token = "0x402A1B6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasObject _bandRankAtlasObject;

		// Token: 0x0402A1B7 RID: 172471
		[Token(Token = "0x402A1B7")]
		[FieldOffset(Offset = "0x70")]
		private FadeTranslationSwitchTween m_showSwitchTween;

		// Token: 0x0402A1B8 RID: 172472
		[Token(Token = "0x402A1B8")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedInitItemId;

		// Token: 0x0402A1B9 RID: 172473
		[Token(Token = "0x402A1B9")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedDifficultyLevel;

		// Token: 0x0402A1BA RID: 172474
		[Token(Token = "0x402A1BA")]
		[FieldOffset(Offset = "0x84")]
		private int m_cachedBandRank;

		// Token: 0x0402A1BB RID: 172475
		[Token(Token = "0x402A1BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A1BC RID: 172476
		[Token(Token = "0x402A1BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A1BD RID: 172477
		[Token(Token = "0x402A1BD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A1BE RID: 172478
		[Token(Token = "0x402A1BE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderInitSquadWithDifficulty;

		// Token: 0x0402A1BF RID: 172479
		[Token(Token = "0x402A1BF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
