using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054F3 RID: 21747
	[Token(Token = "0x20054F3")]
	public class RoguelikeGoodsObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004AFD RID: 19197
		// (get) Token: 0x0601FFC6 RID: 131014 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FFC7 RID: 131015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004AFD")]
		public Action<RoguelikeGoodsViewModel> onGoodsClicked
		{
			[Token(Token = "0x601FFC6")]
			[Address(RVA = "0x1A1E100", Offset = "0x1A1CD00", VA = "0x181A1E100")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601FFC7")]
			[Address(RVA = "0x1A1E360", Offset = "0x1A1CF60", VA = "0x181A1E360")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004AFE RID: 19198
		// (get) Token: 0x0601FFC8 RID: 131016 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FFC9 RID: 131017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004AFE")]
		public Action<RoguelikeGoodsViewModel> onLockSlotClick
		{
			[Token(Token = "0x601FFC8")]
			[Address(RVA = "0x1A1E160", Offset = "0x1A1CD60", VA = "0x181A1E160")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601FFC9")]
			[Address(RVA = "0x1A1E3E0", Offset = "0x1A1CFE0", VA = "0x181A1E3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004AFF RID: 19199
		// (get) Token: 0x0601FFCA RID: 131018 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FFCB RID: 131019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004AFF")]
		public Action onBankClicked
		{
			[Token(Token = "0x601FFCA")]
			[Address(RVA = "0x1A1E0A0", Offset = "0x1A1CCA0", VA = "0x181A1E0A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601FFCB")]
			[Address(RVA = "0x1A1E2E0", Offset = "0x1A1CEE0", VA = "0x181A1E2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004B00 RID: 19200
		// (get) Token: 0x0601FFCC RID: 131020 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FFCD RID: 131021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B00")]
		public RoguelikeShopGoodsLoopAdapter.SwitchPlayHandler switchPlayHandler
		{
			[Token(Token = "0x601FFCC")]
			[Address(RVA = "0x1A1E1C0", Offset = "0x1A1CDC0", VA = "0x181A1E1C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601FFCD")]
			[Address(RVA = "0x1A1E460", Offset = "0x1A1D060", VA = "0x181A1E460")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004B01 RID: 19201
		// (get) Token: 0x0601FFCE RID: 131022 RVA: 0x000B41E0 File Offset: 0x000B23E0
		[Token(Token = "0x17004B01")]
		public float tweenDuration
		{
			[Token(Token = "0x601FFCE")]
			[Address(RVA = "0x1A1E220", Offset = "0x1A1CE20", VA = "0x181A1E220")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004B02 RID: 19202
		// (get) Token: 0x0601FFCF RID: 131023 RVA: 0x000B41F8 File Offset: 0x000B23F8
		[Token(Token = "0x17004B02")]
		public float tweenInterval
		{
			[Token(Token = "0x601FFCF")]
			[Address(RVA = "0x1A1E280", Offset = "0x1A1CE80", VA = "0x181A1E280")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0601FFD0 RID: 131024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFD0")]
		[Address(RVA = "0x1A1BF20", Offset = "0x1A1AB20", VA = "0x181A1BF20")]
		public void EventOnGoodsClicked()
		{
		}

		// Token: 0x0601FFD1 RID: 131025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFD1")]
		[Address(RVA = "0x1A1BE10", Offset = "0x1A1AA10", VA = "0x181A1BE10")]
		public void EventOnBankClicked()
		{
		}

		// Token: 0x0601FFD2 RID: 131026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFD2")]
		[Address(RVA = "0x1A1C030", Offset = "0x1A1AC30", VA = "0x181A1C030")]
		public void EventOnLockSlotClick()
		{
		}

		// Token: 0x0601FFD3 RID: 131027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFD3")]
		[Address(RVA = "0x1A1C150", Offset = "0x1A1AD50", VA = "0x181A1C150")]
		public void InjectPlugins(List<RoguelikeGoodsObjPlugin> plugins)
		{
		}

		// Token: 0x0601FFD4 RID: 131028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFD4")]
		[Address(RVA = "0x1A1C1D0", Offset = "0x1A1ADD0", VA = "0x181A1C1D0")]
		public void Render(int index, RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FFD5 RID: 131029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFD5")]
		[Address(RVA = "0x1A1CDC0", Offset = "0x1A1B9C0", VA = "0x181A1CDC0")]
		private void _RenderLockSlotView(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FFD6 RID: 131030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFD6")]
		[Address(RVA = "0x1A1C5A0", Offset = "0x1A1B1A0", VA = "0x181A1C5A0")]
		private void _RenderBankEntryView(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FFD7 RID: 131031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFD7")]
		[Address(RVA = "0x1A1C7E0", Offset = "0x1A1B3E0", VA = "0x181A1C7E0")]
		private void _RenderGoodsItemView(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FFD8 RID: 131032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFD8")]
		[Address(RVA = "0x1A1D5E0", Offset = "0x1A1C1E0", VA = "0x181A1D5E0")]
		private void _SetupTween()
		{
		}

		// Token: 0x0601FFD9 RID: 131033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFD9")]
		[Address(RVA = "0x1A1D340", Offset = "0x1A1BF40", VA = "0x181A1D340")]
		private void _SetupPluginsIfNeeded()
		{
		}

		// Token: 0x0601FFDA RID: 131034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFDA")]
		[Address(RVA = "0x1A1D0E0", Offset = "0x1A1BCE0", VA = "0x181A1D0E0")]
		private void _SetupDiscountPluginIfNeed()
		{
		}

		// Token: 0x0601FFDB RID: 131035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFDB")]
		[Address(RVA = "0x1A1D210", Offset = "0x1A1BE10", VA = "0x181A1D210")]
		private void _SetupIconPluginIfNeed()
		{
		}

		// Token: 0x0601FFDC RID: 131036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FFDC")]
		[Address(RVA = "0x1A1C420", Offset = "0x1A1B020", VA = "0x181A1C420")]
		private RoguelikeGoodsObjPlugin TryGetPluginByType(RoguelikeShopGoodPluginType type)
		{
			return null;
		}

		// Token: 0x0601FFDD RID: 131037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFDD")]
		[Address(RVA = "0x1A1CE20", Offset = "0x1A1BA20", VA = "0x181A1CE20")]
		private void _RenderPlugins(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FFDE RID: 131038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFDE")]
		[Address(RVA = "0x1A1C6A0", Offset = "0x1A1B2A0", VA = "0x181A1C6A0")]
		private void _RenderDiscountPlugin(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FFDF RID: 131039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFDF")]
		[Address(RVA = "0x1A1CC70", Offset = "0x1A1B870", VA = "0x181A1CC70")]
		private void _RenderIconPlugin(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FFE0 RID: 131040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFE0")]
		[Address(RVA = "0x1A1D7A0", Offset = "0x1A1C3A0", VA = "0x181A1D7A0")]
		private void _UpdateSwitchTween()
		{
		}

		// Token: 0x0601FFE1 RID: 131041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFE1")]
		[Address(RVA = "0x1A1E040", Offset = "0x1A1CC40", VA = "0x181A1E040")]
		public RoguelikeGoodsObjView()
		{
		}

		// Token: 0x0402B286 RID: 176774
		[Token(Token = "0x402B286")]
		private const int GOODS_COLUMN_CNT = 4;

		// Token: 0x0402B287 RID: 176775
		[Token(Token = "0x402B287")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Settings")]
		private Color _normalTextColor;

		// Token: 0x0402B288 RID: 176776
		[Token(Token = "0x402B288")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Settings")]
		private Color _nonAffordableTextColor;

		// Token: 0x0402B289 RID: 176777
		[Token(Token = "0x402B289")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Settings")]
		private float _soldoutAlpha;

		// Token: 0x0402B28A RID: 176778
		[Token(Token = "0x402B28A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelGoods;

		// Token: 0x0402B28B RID: 176779
		[Token(Token = "0x402B28B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelGoodSoldOut;

		// Token: 0x0402B28C RID: 176780
		[Token(Token = "0x402B28C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelBank;

		// Token: 0x0402B28D RID: 176781
		[Token(Token = "0x402B28D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelLockSlot;

		// Token: 0x0402B28E RID: 176782
		[Token(Token = "0x402B28E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402B28F RID: 176783
		[Token(Token = "0x402B28F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402B290 RID: 176784
		[Token(Token = "0x402B290")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _priceIconImage;

		// Token: 0x0402B291 RID: 176785
		[Token(Token = "0x402B291")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textPrice;

		// Token: 0x0402B292 RID: 176786
		[Token(Token = "0x402B292")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textPriceCaption;

		// Token: 0x0402B293 RID: 176787
		[Token(Token = "0x402B293")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x0402B294 RID: 176788
		[Token(Token = "0x402B294")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _lackPanel;

		// Token: 0x0402B295 RID: 176789
		[Token(Token = "0x402B295")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<GameObject> _recyclePanels;

		// Token: 0x0402B296 RID: 176790
		[Token(Token = "0x402B296")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402B297 RID: 176791
		[Token(Token = "0x402B297")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0402B298 RID: 176792
		[Token(Token = "0x402B298")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform _panelWidgets;

		// Token: 0x0402B299 RID: 176793
		[Token(Token = "0x402B299")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup _canvasGroupWidgets;

		// Token: 0x0402B29A RID: 176794
		[Token(Token = "0x402B29A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x0402B29B RID: 176795
		[Token(Token = "0x402B29B")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float _tweenInternvalX;

		// Token: 0x0402B29C RID: 176796
		[Token(Token = "0x402B29C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _tweenInterval;

		// Token: 0x0402B29D RID: 176797
		[Token(Token = "0x402B29D")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private Ease _tweenShowEase;

		// Token: 0x0402B29E RID: 176798
		[Token(Token = "0x402B29E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Ease _tweenHideEase;

		// Token: 0x0402B29F RID: 176799
		[Token(Token = "0x402B29F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _textBankCurrent;

		// Token: 0x0402B2A0 RID: 176800
		[Token(Token = "0x402B2A0")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _faultyIconGo;

		// Token: 0x0402B2A1 RID: 176801
		[Token(Token = "0x402B2A1")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _normalPricePanel;

		// Token: 0x0402B2A2 RID: 176802
		[Token(Token = "0x402B2A2")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Plugin")]
		private RectTransform _iconPluginContainer;

		// Token: 0x0402B2A3 RID: 176803
		[Token(Token = "0x402B2A3")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Plugin")]
		private RectTransform _discountPluginContainer;

		// Token: 0x0402B2A4 RID: 176804
		[Token(Token = "0x402B2A4")]
		[FieldOffset(Offset = "0x100")]
		private int m_cachedIndex;

		// Token: 0x0402B2A5 RID: 176805
		[Token(Token = "0x402B2A5")]
		[FieldOffset(Offset = "0x108")]
		private RoguelikeGoodsViewModel m_cacheModel;

		// Token: 0x0402B2A6 RID: 176806
		[Token(Token = "0x402B2A6")]
		[FieldOffset(Offset = "0x110")]
		private RoguelikeGameShopSwitchTween m_switchTween;

		// Token: 0x0402B2A7 RID: 176807
		[Token(Token = "0x402B2A7")]
		[FieldOffset(Offset = "0x118")]
		private float m_tweenHideX;

		// Token: 0x0402B2A8 RID: 176808
		[Token(Token = "0x402B2A8")]
		[FieldOffset(Offset = "0x120")]
		private List<RoguelikeGoodsObjPlugin> m_pluginPrefabList;

		// Token: 0x0402B2A9 RID: 176809
		[Token(Token = "0x402B2A9")]
		[FieldOffset(Offset = "0x128")]
		private RoguelikeGoodsObjPlugin m_pluginDiscount;

		// Token: 0x0402B2AA RID: 176810
		[Token(Token = "0x402B2AA")]
		[FieldOffset(Offset = "0x130")]
		private RoguelikeGoodsObjPlugin m_pluginIcon;

		// Token: 0x0402B2AB RID: 176811
		[Token(Token = "0x402B2AB")]
		[FieldOffset(Offset = "0x138")]
		private UIStateFinder m_finder;

		// Token: 0x0402B2AC RID: 176812
		[Token(Token = "0x402B2AC")]
		[FieldOffset(Offset = "0x148")]
		private string m_cachedPriceId;

		// Token: 0x0402B2B1 RID: 176817
		[Token(Token = "0x402B2B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onGoodsClicked;

		// Token: 0x0402B2B2 RID: 176818
		[Token(Token = "0x402B2B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onGoodsClicked;

		// Token: 0x0402B2B3 RID: 176819
		[Token(Token = "0x402B2B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onLockSlotClick;

		// Token: 0x0402B2B4 RID: 176820
		[Token(Token = "0x402B2B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onLockSlotClick;

		// Token: 0x0402B2B5 RID: 176821
		[Token(Token = "0x402B2B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onBankClicked;

		// Token: 0x0402B2B6 RID: 176822
		[Token(Token = "0x402B2B6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onBankClicked;

		// Token: 0x0402B2B7 RID: 176823
		[Token(Token = "0x402B2B7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_switchPlayHandler;

		// Token: 0x0402B2B8 RID: 176824
		[Token(Token = "0x402B2B8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_switchPlayHandler;

		// Token: 0x0402B2B9 RID: 176825
		[Token(Token = "0x402B2B9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_tweenDuration;

		// Token: 0x0402B2BA RID: 176826
		[Token(Token = "0x402B2BA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_tweenInterval;

		// Token: 0x0402B2BB RID: 176827
		[Token(Token = "0x402B2BB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnGoodsClicked;

		// Token: 0x0402B2BC RID: 176828
		[Token(Token = "0x402B2BC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnBankClicked;

		// Token: 0x0402B2BD RID: 176829
		[Token(Token = "0x402B2BD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnLockSlotClick;

		// Token: 0x0402B2BE RID: 176830
		[Token(Token = "0x402B2BE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_InjectPlugins;

		// Token: 0x0402B2BF RID: 176831
		[Token(Token = "0x402B2BF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B2C0 RID: 176832
		[Token(Token = "0x402B2C0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RenderLockSlotView;

		// Token: 0x0402B2C1 RID: 176833
		[Token(Token = "0x402B2C1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderBankEntryView;

		// Token: 0x0402B2C2 RID: 176834
		[Token(Token = "0x402B2C2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RenderGoodsItemView;

		// Token: 0x0402B2C3 RID: 176835
		[Token(Token = "0x402B2C3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SetupTween;

		// Token: 0x0402B2C4 RID: 176836
		[Token(Token = "0x402B2C4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SetupPluginsIfNeeded;

		// Token: 0x0402B2C5 RID: 176837
		[Token(Token = "0x402B2C5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SetupDiscountPluginIfNeed;

		// Token: 0x0402B2C6 RID: 176838
		[Token(Token = "0x402B2C6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SetupIconPluginIfNeed;

		// Token: 0x0402B2C7 RID: 176839
		[Token(Token = "0x402B2C7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_TryGetPluginByType;

		// Token: 0x0402B2C8 RID: 176840
		[Token(Token = "0x402B2C8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RenderPlugins;

		// Token: 0x0402B2C9 RID: 176841
		[Token(Token = "0x402B2C9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RenderDiscountPlugin;

		// Token: 0x0402B2CA RID: 176842
		[Token(Token = "0x402B2CA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RenderIconPlugin;

		// Token: 0x0402B2CB RID: 176843
		[Token(Token = "0x402B2CB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateSwitchTween;

		// Token: 0x0402B2CC RID: 176844
		[Token(Token = "0x402B2CC")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
