using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200605E RID: 24670
	[Token(Token = "0x200605E")]
	public class CarvingMainCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005430 RID: 21552
		// (get) Token: 0x06023AB6 RID: 146102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005430")]
		public UIColorGraphic cardGraphic
		{
			[Token(Token = "0x6023AB6")]
			[Address(RVA = "0x1E4DE10", Offset = "0x1E4CA10", VA = "0x181E4DE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023AB7 RID: 146103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AB7")]
		[Address(RVA = "0x1E4CFB0", Offset = "0x1E4BBB0", VA = "0x181E4CFB0")]
		private void _InitIfNot(CarvingMainCardView.ShowType showType)
		{
		}

		// Token: 0x06023AB8 RID: 146104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AB8")]
		[Address(RVA = "0x1E4CAF0", Offset = "0x1E4B6F0", VA = "0x181E4CAF0")]
		public void Render(CarvingMainCardViewModel model, CarvingMainCardView.RenderParam renderParam)
		{
		}

		// Token: 0x06023AB9 RID: 146105 RVA: 0x000C1830 File Offset: 0x000BFA30
		[Token(Token = "0x6023AB9")]
		[Address(RVA = "0x1E4CA30", Offset = "0x1E4B630", VA = "0x181E4CA30")]
		public float GetScaler()
		{
			return 0f;
		}

		// Token: 0x06023ABA RID: 146106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ABA")]
		[Address(RVA = "0x1E4CEE0", Offset = "0x1E4BAE0", VA = "0x181E4CEE0")]
		public void SetScaler(float scale)
		{
		}

		// Token: 0x06023ABB RID: 146107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ABB")]
		[Address(RVA = "0x1E4DA30", Offset = "0x1E4C630", VA = "0x181E4DA30")]
		private void _RenderSelection(bool isSelect, bool isFastMode)
		{
		}

		// Token: 0x06023ABC RID: 146108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ABC")]
		[Address(RVA = "0x1E4D950", Offset = "0x1E4C550", VA = "0x181E4D950")]
		private void _RenderSelectionInShop(bool isSelectedInShop, bool isFastMode)
		{
		}

		// Token: 0x06023ABD RID: 146109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ABD")]
		[Address(RVA = "0x1E4D220", Offset = "0x1E4BE20", VA = "0x181E4D220")]
		private void _PlayProcessed(bool isProcessed)
		{
		}

		// Token: 0x06023ABE RID: 146110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ABE")]
		[Address(RVA = "0x1E4D360", Offset = "0x1E4BF60", VA = "0x181E4D360")]
		private void _PlaySelectLightTween()
		{
		}

		// Token: 0x06023ABF RID: 146111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ABF")]
		[Address(RVA = "0x1E4D7A0", Offset = "0x1E4C3A0", VA = "0x181E4D7A0")]
		private void _RenderLevelUp(CarvingMainCardViewModel model)
		{
		}

		// Token: 0x06023AC0 RID: 146112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AC0")]
		[Address(RVA = "0x1E4D4B0", Offset = "0x1E4C0B0", VA = "0x181E4D4B0")]
		private void _RenderCardContent(CarvingMainCardViewModel model)
		{
		}

		// Token: 0x06023AC1 RID: 146113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AC1")]
		[Address(RVA = "0x1E4DC60", Offset = "0x1E4C860", VA = "0x181E4DC60")]
		private void _RenderTargetTransfer(List<CarvingMainCardMaterialViewModel> inputMaterials, List<CarvingMainCardMaterialViewModel> outputMaterials)
		{
		}

		// Token: 0x06023AC2 RID: 146114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AC2")]
		[Address(RVA = "0x1E4DDB0", Offset = "0x1E4C9B0", VA = "0x181E4DDB0")]
		public CarvingMainCardView()
		{
		}

		// Token: 0x040316BA RID: 202426
		[Token(Token = "0x40316BA")]
		private const string CARD_LEVEL_IMG = "level_{0}";

		// Token: 0x040316BB RID: 202427
		[Token(Token = "0x40316BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Content")]
		private UIAtlasObject _atlasObject;

		// Token: 0x040316BC RID: 202428
		[Token(Token = "0x40316BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Content")]
		private UIAtlasImage _cardLevel;

		// Token: 0x040316BD RID: 202429
		[Token(Token = "0x40316BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Content")]
		private UIAtlasImage _cardBgType;

		// Token: 0x040316BE RID: 202430
		[Token(Token = "0x40316BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Content")]
		private GameObject _cardUpgradeIcon;

		// Token: 0x040316BF RID: 202431
		[Token(Token = "0x40316BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Content")]
		private List<CarvingMainCardTransferView> _cardTransfers;

		// Token: 0x040316C0 RID: 202432
		[Token(Token = "0x40316C0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _selectHandAnimLocation;

		// Token: 0x040316C1 RID: 202433
		[Token(Token = "0x40316C1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _selectShopAnimLocation;

		// Token: 0x040316C2 RID: 202434
		[Token(Token = "0x40316C2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _selectSlotAnimLocation;

		// Token: 0x040316C3 RID: 202435
		[Token(Token = "0x40316C3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _selectLightAnimLocation;

		// Token: 0x040316C4 RID: 202436
		[Token(Token = "0x40316C4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _selectedInShopAnimLocation;

		// Token: 0x040316C5 RID: 202437
		[Token(Token = "0x40316C5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _selectedAsTokenAnimLocation;

		// Token: 0x040316C6 RID: 202438
		[Token(Token = "0x40316C6")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Animation")]
		private CanvasGroup _selectedInShopAlphaHandler;

		// Token: 0x040316C7 RID: 202439
		[Token(Token = "0x40316C7")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _levelUpAnimLocation;

		// Token: 0x040316C8 RID: 202440
		[Token(Token = "0x40316C8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _processedAnimLocation;

		// Token: 0x040316C9 RID: 202441
		[Token(Token = "0x40316C9")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIColorGraphic _cardGraphic;

		// Token: 0x040316CA RID: 202442
		[Token(Token = "0x40316CA")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIScaler _uiScaler;

		// Token: 0x040316CB RID: 202443
		[Token(Token = "0x40316CB")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_inited;

		// Token: 0x040316CC RID: 202444
		[Token(Token = "0x40316CC")]
		[FieldOffset(Offset = "0xE0")]
		private UISwitchTween m_selectAnimSwitchTween;

		// Token: 0x040316CD RID: 202445
		[Token(Token = "0x40316CD")]
		[FieldOffset(Offset = "0xE8")]
		private UISwitchTween m_selectedInShopSwitchTween;

		// Token: 0x040316CE RID: 202446
		[Token(Token = "0x40316CE")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_selectLightTween;

		// Token: 0x040316CF RID: 202447
		[Token(Token = "0x40316CF")]
		[FieldOffset(Offset = "0xF8")]
		private Tween m_levelUpTween;

		// Token: 0x040316D0 RID: 202448
		[Token(Token = "0x40316D0")]
		[FieldOffset(Offset = "0x100")]
		private Tween m_processedTween;

		// Token: 0x040316D1 RID: 202449
		[Token(Token = "0x40316D1")]
		[FieldOffset(Offset = "0x108")]
		private bool m_cachedSelect;

		// Token: 0x040316D2 RID: 202450
		[Token(Token = "0x40316D2")]
		[FieldOffset(Offset = "0x109")]
		private bool m_cachedSelectedInShop;

		// Token: 0x040316D3 RID: 202451
		[Token(Token = "0x40316D3")]
		[FieldOffset(Offset = "0x10C")]
		private int m_cachedCardLevel;

		// Token: 0x040316D4 RID: 202452
		[Token(Token = "0x40316D4")]
		[FieldOffset(Offset = "0x110")]
		private CarvingMainCardView.ShowType m_cachedShowType;

		// Token: 0x040316D5 RID: 202453
		[Token(Token = "0x40316D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardGraphic;

		// Token: 0x040316D6 RID: 202454
		[Token(Token = "0x40316D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040316D7 RID: 202455
		[Token(Token = "0x40316D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040316D8 RID: 202456
		[Token(Token = "0x40316D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetScaler;

		// Token: 0x040316D9 RID: 202457
		[Token(Token = "0x40316D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetScaler;

		// Token: 0x040316DA RID: 202458
		[Token(Token = "0x40316DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderSelection;

		// Token: 0x040316DB RID: 202459
		[Token(Token = "0x40316DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderSelectionInShop;

		// Token: 0x040316DC RID: 202460
		[Token(Token = "0x40316DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayProcessed;

		// Token: 0x040316DD RID: 202461
		[Token(Token = "0x40316DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlaySelectLightTween;

		// Token: 0x040316DE RID: 202462
		[Token(Token = "0x40316DE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderLevelUp;

		// Token: 0x040316DF RID: 202463
		[Token(Token = "0x40316DF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderCardContent;

		// Token: 0x040316E0 RID: 202464
		[Token(Token = "0x40316E0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderTargetTransfer;

		// Token: 0x040316E1 RID: 202465
		[Token(Token = "0x40316E1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200605F RID: 24671
		[Token(Token = "0x200605F")]
		public enum ShowType
		{
			// Token: 0x040316E3 RID: 202467
			[Token(Token = "0x40316E3")]
			NONE,
			// Token: 0x040316E4 RID: 202468
			[Token(Token = "0x40316E4")]
			SHOP_GOOD,
			// Token: 0x040316E5 RID: 202469
			[Token(Token = "0x40316E5")]
			HAND,
			// Token: 0x040316E6 RID: 202470
			[Token(Token = "0x40316E6")]
			SLOT,
			// Token: 0x040316E7 RID: 202471
			[Token(Token = "0x40316E7")]
			TOKEN
		}

		// Token: 0x02006060 RID: 24672
		[Token(Token = "0x2006060")]
		public struct RenderParam
		{
			// Token: 0x040316E8 RID: 202472
			[Token(Token = "0x40316E8")]
			[FieldOffset(Offset = "0x0")]
			public bool isSelect;

			// Token: 0x040316E9 RID: 202473
			[Token(Token = "0x40316E9")]
			[FieldOffset(Offset = "0x1")]
			public bool isProcessed;

			// Token: 0x040316EA RID: 202474
			[Token(Token = "0x40316EA")]
			[FieldOffset(Offset = "0x2")]
			public bool isFastMode;

			// Token: 0x040316EB RID: 202475
			[Token(Token = "0x40316EB")]
			[FieldOffset(Offset = "0x4")]
			public CarvingMainCardView.ShowType showType;

			// Token: 0x040316EC RID: 202476
			[Token(Token = "0x40316EC")]
			[FieldOffset(Offset = "0x8")]
			public bool isSelectedInShop;
		}

		// Token: 0x02006061 RID: 24673
		[Token(Token = "0x2006061")]
		private class SelectedInShopSwitchTween : UISwitchTween
		{
			// Token: 0x06023AC3 RID: 146115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023AC3")]
			[Address(RVA = "0x1E54310", Offset = "0x1E52F10", VA = "0x181E54310")]
			public SelectedInShopSwitchTween(CarvingMainCardView closure)
			{
			}

			// Token: 0x06023AC4 RID: 146116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023AC4")]
			[Address(RVA = "0x1E53FB0", Offset = "0x1E52BB0", VA = "0x181E53FB0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06023AC5 RID: 146117 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023AC5")]
			[Address(RVA = "0x1E540B0", Offset = "0x1E52CB0", VA = "0x181E540B0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06023AC6 RID: 146118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023AC6")]
			[Address(RVA = "0x1E53E70", Offset = "0x1E52A70", VA = "0x181E53E70", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06023AC7 RID: 146119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023AC7")]
			[Address(RVA = "0x1E53DB0", Offset = "0x1E529B0", VA = "0x181E53DB0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06023AC8 RID: 146120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023AC8")]
			[Address(RVA = "0x1E541C0", Offset = "0x1E52DC0", VA = "0x181E541C0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06023AC9 RID: 146121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023AC9")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06023ACA RID: 146122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023ACA")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x06023ACB RID: 146123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023ACB")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040316ED RID: 202477
			[Token(Token = "0x40316ED")]
			[FieldOffset(Offset = "0x48")]
			private CarvingMainCardView m_closure;

			// Token: 0x040316EE RID: 202478
			[Token(Token = "0x40316EE")]
			[FieldOffset(Offset = "0x50")]
			private Tween m_selectedInShopLightTween;

			// Token: 0x040316EF RID: 202479
			[Token(Token = "0x40316EF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040316F0 RID: 202480
			[Token(Token = "0x40316F0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040316F1 RID: 202481
			[Token(Token = "0x40316F1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040316F2 RID: 202482
			[Token(Token = "0x40316F2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x040316F3 RID: 202483
			[Token(Token = "0x40316F3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x040316F4 RID: 202484
			[Token(Token = "0x40316F4")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
