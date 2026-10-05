using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C34 RID: 7220
	[Token(Token = "0x2001C34")]
	public class BuildingTradingGainedOrderView : MonoBehaviour
	{
		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x0600B3B2 RID: 46002 RVA: 0x000443E8 File Offset: 0x000425E8
		[Token(Token = "0x1700158D")]
		[Inspect(Level = 2)]
		public TradingOrderStruct currentOrder
		{
			[Token(Token = "0x600B3B2")]
			[Address(RVA = "0x32D4220", Offset = "0x32D2E20", VA = "0x1832D4220")]
			get
			{
				return default(TradingOrderStruct);
			}
		}

		// Token: 0x0600B3B3 RID: 46003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3B3")]
		[Address(RVA = "0x32D36B0", Offset = "0x32D22B0", VA = "0x1832D36B0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600B3B4 RID: 46004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3B4")]
		[Address(RVA = "0x32D3700", Offset = "0x32D2300", VA = "0x1832D3700")]
		public void Render(TradingOrderStruct orderStruct)
		{
		}

		// Token: 0x0600B3B5 RID: 46005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3B5")]
		[Address(RVA = "0x32D3670", Offset = "0x32D2270", VA = "0x1832D3670")]
		public void EventOnFinishClicked()
		{
		}

		// Token: 0x0600B3B6 RID: 46006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3B6")]
		[Address(RVA = "0x32D3630", Offset = "0x32D2230", VA = "0x1832D3630")]
		public void EventOnDeleteClicked()
		{
		}

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3B7")]
		[Address(RVA = "0x32D3EF0", Offset = "0x32D2AF0", VA = "0x1832D3EF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3B8")]
		[Address(RVA = "0x32D3FF0", Offset = "0x32D2BF0", VA = "0x1832D3FF0")]
		private static void _LoadSprite(BuildingTradingGainedOrderView.RewardIconPair[] hub, Image icon, TradingOrderReward type)
		{
		}

		// Token: 0x0600B3B9 RID: 46009 RVA: 0x00044400 File Offset: 0x00042600
		[Token(Token = "0x600B3B9")]
		[Address(RVA = "0x32D3E90", Offset = "0x32D2A90", VA = "0x1832D3E90")]
		private bool _CheckOrderBuffed(TradingOrderStruct orderStruct)
		{
			return default(bool);
		}

		// Token: 0x0600B3BA RID: 46010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3BA")]
		[Address(RVA = "0x32D4180", Offset = "0x32D2D80", VA = "0x1832D4180")]
		public BuildingTradingGainedOrderView()
		{
		}

		// Token: 0x0400AF21 RID: 44833
		[Token(Token = "0x400AF21")]
		private const string ANIM_COMPLETE_KEY = "IS_COMPLETE";

		// Token: 0x0400AF22 RID: 44834
		[Token(Token = "0x400AF22")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0400AF23 RID: 44835
		[Token(Token = "0x400AF23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNotEnougth;

		// Token: 0x0400AF24 RID: 44836
		[Token(Token = "0x400AF24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text[] _textsTitle;

		// Token: 0x0400AF25 RID: 44837
		[Token(Token = "0x400AF25")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _textsRewardCount;

		// Token: 0x0400AF26 RID: 44838
		[Token(Token = "0x400AF26")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuildingTradingGainedOrderView.RewardIconPair[] _completeIconHub;

		// Token: 0x0400AF27 RID: 44839
		[Token(Token = "0x400AF27")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuildingTradingGainedOrderView.RewardIconPair[] _uncompleteIconHub;

		// Token: 0x0400AF28 RID: 44840
		[Token(Token = "0x400AF28")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _completeIcon;

		// Token: 0x0400AF29 RID: 44841
		[Token(Token = "0x400AF29")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _uncompleteIcon;

		// Token: 0x0400AF2A RID: 44842
		[Token(Token = "0x400AF2A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _itemLayout;

		// Token: 0x0400AF2B RID: 44843
		[Token(Token = "0x400AF2B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400AF2C RID: 44844
		[Token(Token = "0x400AF2C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image[] _orderBuffIcon;

		// Token: 0x0400AF2D RID: 44845
		[Token(Token = "0x400AF2D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject[] _panelIconGroup;

		// Token: 0x0400AF2E RID: 44846
		[Token(Token = "0x400AF2E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] _panelSpecialIcon;

		// Token: 0x0400AF2F RID: 44847
		[Token(Token = "0x400AF2F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _panelExtraIcon;

		// Token: 0x0400AF30 RID: 44848
		[Token(Token = "0x400AF30")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action onFinishClicked;

		// Token: 0x0400AF31 RID: 44849
		[Token(Token = "0x400AF31")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action onDeleteClicked;

		// Token: 0x0400AF32 RID: 44850
		[Token(Token = "0x400AF32")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isTransiting;

		// Token: 0x0400AF33 RID: 44851
		[Token(Token = "0x400AF33")]
		[FieldOffset(Offset = "0xA0")]
		private UIAnimation m_pendingTransition;

		// Token: 0x0400AF34 RID: 44852
		[Token(Token = "0x400AF34")]
		[FieldOffset(Offset = "0xA8")]
		private SimpleLayoutAdapter m_itemAdapter;

		// Token: 0x0400AF35 RID: 44853
		[Token(Token = "0x400AF35")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x0400AF36 RID: 44854
		[Token(Token = "0x400AF36")]
		[FieldOffset(Offset = "0xB8")]
		private TradingOrderStruct m_cachedOrder;

		// Token: 0x02001C35 RID: 7221
		[Token(Token = "0x2001C35")]
		[Serializable]
		private struct RewardIconPair
		{
			// Token: 0x0400AF37 RID: 44855
			[Token(Token = "0x400AF37")]
			[FieldOffset(Offset = "0x0")]
			public TradingOrderReward reward;

			// Token: 0x0400AF38 RID: 44856
			[Token(Token = "0x400AF38")]
			[FieldOffset(Offset = "0x8")]
			public Sprite icon;
		}

		// Token: 0x02001C36 RID: 7222
		[Token(Token = "0x2001C36")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B3BB RID: 46011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3BB")]
			[Address(RVA = "0x32E4370", Offset = "0x32E2F70", VA = "0x1832E4370")]
			public ItemAdapter(BuildingTradingGainedOrderView closure)
			{
			}

			// Token: 0x1700158E RID: 5518
			// (get) Token: 0x0600B3BC RID: 46012 RVA: 0x00044418 File Offset: 0x00042618
			[Token(Token = "0x1700158E")]
			public override int count
			{
				[Token(Token = "0x600B3BC")]
				[Address(RVA = "0x32E43F0", Offset = "0x32E2FF0", VA = "0x1832E43F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B3BD RID: 46013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B3BD")]
			[Address(RVA = "0x32E4180", Offset = "0x32E2D80", VA = "0x1832E4180", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400AF39 RID: 44857
			[Token(Token = "0x400AF39")]
			[FieldOffset(Offset = "0x20")]
			private BuildingTradingGainedOrderView m_closure;

			// Token: 0x0400AF3A RID: 44858
			[Token(Token = "0x400AF3A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400AF3B RID: 44859
			[Token(Token = "0x400AF3B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400AF3C RID: 44860
			[Token(Token = "0x400AF3C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
