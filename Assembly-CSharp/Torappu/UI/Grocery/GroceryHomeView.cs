using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CB7 RID: 19639
	[Token(Token = "0x2004CB7")]
	public class GroceryHomeView : DataBinder<GroceryHomeProperty>, IHotfixable
	{
		// Token: 0x0601D6E3 RID: 120547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6E3")]
		[Address(RVA = "0x16F9790", Offset = "0x16F8390", VA = "0x1816F9790", Slot = "7")]
		public override void OnValueChanged(GroceryHomeProperty property)
		{
		}

		// Token: 0x0601D6E4 RID: 120548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6E4")]
		[Address(RVA = "0x16F9590", Offset = "0x16F8190", VA = "0x1816F9590")]
		public void OnLaunchBtnClicked()
		{
		}

		// Token: 0x0601D6E5 RID: 120549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6E5")]
		[Address(RVA = "0x16F9670", Offset = "0x16F8270", VA = "0x1816F9670")]
		public void OnMileStoneBtnClicked()
		{
		}

		// Token: 0x0601D6E6 RID: 120550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6E6")]
		[Address(RVA = "0x16F9700", Offset = "0x16F8300", VA = "0x1816F9700")]
		public void OnSaleBtnClicked()
		{
		}

		// Token: 0x0601D6E7 RID: 120551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6E7")]
		[Address(RVA = "0x16F9C60", Offset = "0x16F8860", VA = "0x1816F9C60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D6E8 RID: 120552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6E8")]
		[Address(RVA = "0x16FA000", Offset = "0x16F8C00", VA = "0x1816FA000")]
		private void _OnDailyRewardItemCardClick(int position)
		{
		}

		// Token: 0x0601D6E9 RID: 120553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6E9")]
		[Address(RVA = "0x16FA0C0", Offset = "0x16F8CC0", VA = "0x1816FA0C0")]
		public GroceryHomeView()
		{
		}

		// Token: 0x04026C50 RID: 158800
		[Token(Token = "0x4026C50")]
		private const float ALPHA_DAILY_REWARD_COMPLETE = 0.5f;

		// Token: 0x04026C51 RID: 158801
		[Token(Token = "0x4026C51")]
		private const float ALPHA_DAILY_REWARD_UNCOMPLETE = 1f;

		// Token: 0x04026C52 RID: 158802
		[Token(Token = "0x4026C52")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Title")]
		private Text _textDay;

		// Token: 0x04026C53 RID: 158803
		[Token(Token = "0x4026C53")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Title")]
		private GameObject _panelTitleNormal;

		// Token: 0x04026C54 RID: 158804
		[Token(Token = "0x4026C54")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Title")]
		private GameObject _panelTitleRewardOnly;

		// Token: 0x04026C55 RID: 158805
		[Token(Token = "0x4026C55")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Mile Stone")]
		private GameObject _panelMileStoneSaling;

		// Token: 0x04026C56 RID: 158806
		[Token(Token = "0x4026C56")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Mile Stone")]
		private GameObject _panelMileStoneNextRewardNormal;

		// Token: 0x04026C57 RID: 158807
		[Token(Token = "0x4026C57")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Mile Stone")]
		private Text _textMileStoneNextPt;

		// Token: 0x04026C58 RID: 158808
		[Token(Token = "0x4026C58")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Mile Stone")]
		private GameObject _panelMileStoneNextRewardComplete;

		// Token: 0x04026C59 RID: 158809
		[Token(Token = "0x4026C59")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Mile Stone")]
		private GameObject _panelRewardOnlyMileStone;

		// Token: 0x04026C5A RID: 158810
		[Token(Token = "0x4026C5A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Mile Stone")]
		private UICommonTrackPoint _mileStoneTrackPoint;

		// Token: 0x04026C5B RID: 158811
		[Token(Token = "0x4026C5B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Mile Stone")]
		private Text _textMileStonePoint;

		// Token: 0x04026C5C RID: 158812
		[Token(Token = "0x4026C5C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Mile Stone")]
		private Text _textMileStonePointName;

		// Token: 0x04026C5D RID: 158813
		[Token(Token = "0x4026C5D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Daily Reward")]
		private RectTransform _itemCardContainer;

		// Token: 0x04026C5E RID: 158814
		[Token(Token = "0x4026C5E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Daily Reward")]
		private GameObject _panelDailyReward;

		// Token: 0x04026C5F RID: 158815
		[Token(Token = "0x4026C5F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Daily Reward")]
		private GameObject _panelDailyRewardComplete;

		// Token: 0x04026C60 RID: 158816
		[Token(Token = "0x4026C60")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Daily Reward")]
		private CanvasGroup _canvasGroupDailyReward;

		// Token: 0x04026C61 RID: 158817
		[Token(Token = "0x4026C61")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Daily Reward")]
		private float _itemCardScale;

		// Token: 0x04026C62 RID: 158818
		[Token(Token = "0x4026C62")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Shop Icon")]
		private SimpleLayoutContent _shopIconContent;

		// Token: 0x04026C63 RID: 158819
		[Token(Token = "0x4026C63")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Launch")]
		private SimpleLayoutContent _goodContent;

		// Token: 0x04026C64 RID: 158820
		[Token(Token = "0x4026C64")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Launch")]
		private GameObject _panelCurrentGood;

		// Token: 0x04026C65 RID: 158821
		[Token(Token = "0x4026C65")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Launch")]
		private GameObject _panelRewardOnlyGood;

		// Token: 0x04026C66 RID: 158822
		[Token(Token = "0x4026C66")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Sale")]
		private GameObject _panelSaleBtn;

		// Token: 0x04026C67 RID: 158823
		[Token(Token = "0x4026C67")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Sale")]
		private GameObject _panelSaleBtnStartImg;

		// Token: 0x04026C68 RID: 158824
		[Token(Token = "0x4026C68")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Sale")]
		private GameObject _panelSaleBtnContinueImg;

		// Token: 0x04026C69 RID: 158825
		[Token(Token = "0x4026C69")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Sale")]
		private GameObject _panelAfterSaleBtn;

		// Token: 0x04026C6A RID: 158826
		[Token(Token = "0x4026C6A")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Sale")]
		private GameObject _panelRewardOnlySaleBtn;

		// Token: 0x04026C6B RID: 158827
		[Token(Token = "0x4026C6B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Sale")]
		private Text _textNextSaleRemainTimeDesc;

		// Token: 0x04026C6C RID: 158828
		[Token(Token = "0x4026C6C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Sale")]
		private GameObject _panelNextSaleRemainTimeDesc;

		// Token: 0x04026C6D RID: 158829
		[Token(Token = "0x4026C6D")]
		[FieldOffset(Offset = "0xF8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026C6E RID: 158830
		[Token(Token = "0x4026C6E")]
		[FieldOffset(Offset = "0x108")]
		private TrackPointViewProperty m_mileStoneProperty;

		// Token: 0x04026C6F RID: 158831
		[Token(Token = "0x4026C6F")]
		[FieldOffset(Offset = "0x110")]
		private UIItemCard m_rewardItemCard;

		// Token: 0x04026C70 RID: 158832
		[Token(Token = "0x4026C70")]
		[FieldOffset(Offset = "0x118")]
		private List<GroceryHomeShopModel> m_cacheShopModel;

		// Token: 0x04026C71 RID: 158833
		[Token(Token = "0x4026C71")]
		[FieldOffset(Offset = "0x120")]
		private List<GroceryHomeGoodItemModel> m_cacheGoodModel;

		// Token: 0x04026C72 RID: 158834
		[Token(Token = "0x4026C72")]
		[FieldOffset(Offset = "0x128")]
		private GroceryHomeView.ShopIconAdapter m_shopIconAdapter;

		// Token: 0x04026C73 RID: 158835
		[Token(Token = "0x4026C73")]
		[FieldOffset(Offset = "0x130")]
		private GroceryHomeView.GoodAdapter m_goodAdapter;

		// Token: 0x04026C74 RID: 158836
		[Token(Token = "0x4026C74")]
		[FieldOffset(Offset = "0x138")]
		private bool m_hasInited;

		// Token: 0x04026C75 RID: 158837
		[Token(Token = "0x4026C75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026C76 RID: 158838
		[Token(Token = "0x4026C76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLaunchBtnClicked;

		// Token: 0x04026C77 RID: 158839
		[Token(Token = "0x4026C77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMileStoneBtnClicked;

		// Token: 0x04026C78 RID: 158840
		[Token(Token = "0x4026C78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSaleBtnClicked;

		// Token: 0x04026C79 RID: 158841
		[Token(Token = "0x4026C79")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026C7A RID: 158842
		[Token(Token = "0x4026C7A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnDailyRewardItemCardClick;

		// Token: 0x04026C7B RID: 158843
		[Token(Token = "0x4026C7B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CB8 RID: 19640
		[Token(Token = "0x2004CB8")]
		public class MileStoneTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x17004503 RID: 17667
			// (get) Token: 0x0601D6EA RID: 120554 RVA: 0x000AB690 File Offset: 0x000A9890
			// (set) Token: 0x0601D6EB RID: 120555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004503")]
			public bool isShow
			{
				[Token(Token = "0x601D6EA")]
				[Address(RVA = "0x170C4C0", Offset = "0x170B0C0", VA = "0x18170C4C0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x601D6EB")]
				[Address(RVA = "0x170C520", Offset = "0x170B120", VA = "0x18170C520")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			// Token: 0x0601D6EC RID: 120556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D6EC")]
			[Address(RVA = "0x170C1A0", Offset = "0x170ADA0", VA = "0x18170C1A0", Slot = "6")]
			public virtual void UpdateState(object paramObj)
			{
			}

			// Token: 0x0601D6ED RID: 120557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D6ED")]
			[Address(RVA = "0x170C460", Offset = "0x170B060", VA = "0x18170C460")]
			public MileStoneTrackPointModel()
			{
			}

			// Token: 0x04026C7D RID: 158845
			[Token(Token = "0x4026C7D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04026C7E RID: 158846
			[Token(Token = "0x4026C7E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x04026C7F RID: 158847
			[Token(Token = "0x4026C7F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04026C80 RID: 158848
			[Token(Token = "0x4026C80")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02004CB9 RID: 19641
			[Token(Token = "0x2004CB9")]
			public class Param
			{
				// Token: 0x0601D6EE RID: 120558 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601D6EE")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x04026C81 RID: 158849
				[Token(Token = "0x4026C81")]
				[FieldOffset(Offset = "0x10")]
				public string actId;
			}
		}

		// Token: 0x02004CBA RID: 19642
		[Token(Token = "0x2004CBA")]
		private class ShopIconAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601D6EF RID: 120559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D6EF")]
			[Address(RVA = "0x170CB10", Offset = "0x170B710", VA = "0x18170CB10")]
			public ShopIconAdapter(GroceryHomeView closure)
			{
			}

			// Token: 0x17004504 RID: 17668
			// (get) Token: 0x0601D6F0 RID: 120560 RVA: 0x000AB6A8 File Offset: 0x000A98A8
			[Token(Token = "0x17004504")]
			public override int count
			{
				[Token(Token = "0x601D6F0")]
				[Address(RVA = "0x170CB90", Offset = "0x170B790", VA = "0x18170CB90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D6F1 RID: 120561 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D6F1")]
			[Address(RVA = "0x170C880", Offset = "0x170B480", VA = "0x18170C880", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026C82 RID: 158850
			[Token(Token = "0x4026C82")]
			[FieldOffset(Offset = "0x20")]
			private GroceryHomeView m_clousre;

			// Token: 0x04026C83 RID: 158851
			[Token(Token = "0x4026C83")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026C84 RID: 158852
			[Token(Token = "0x4026C84")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026C85 RID: 158853
			[Token(Token = "0x4026C85")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004CBB RID: 19643
		[Token(Token = "0x2004CBB")]
		private class GoodAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601D6F2 RID: 120562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D6F2")]
			[Address(RVA = "0x16F4940", Offset = "0x16F3540", VA = "0x1816F4940")]
			public GoodAdapter(GroceryHomeView closure)
			{
			}

			// Token: 0x17004505 RID: 17669
			// (get) Token: 0x0601D6F3 RID: 120563 RVA: 0x000AB6C0 File Offset: 0x000A98C0
			[Token(Token = "0x17004505")]
			public override int count
			{
				[Token(Token = "0x601D6F3")]
				[Address(RVA = "0x16F49C0", Offset = "0x16F35C0", VA = "0x1816F49C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D6F4 RID: 120564 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D6F4")]
			[Address(RVA = "0x16F4660", Offset = "0x16F3260", VA = "0x1816F4660", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026C86 RID: 158854
			[Token(Token = "0x4026C86")]
			[FieldOffset(Offset = "0x20")]
			private GroceryHomeView m_closure;

			// Token: 0x04026C87 RID: 158855
			[Token(Token = "0x4026C87")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026C88 RID: 158856
			[Token(Token = "0x4026C88")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026C89 RID: 158857
			[Token(Token = "0x4026C89")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
