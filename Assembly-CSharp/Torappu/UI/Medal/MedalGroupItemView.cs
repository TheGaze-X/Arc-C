using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200496A RID: 18794
	[Token(Token = "0x200496A")]
	public class MedalGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C53C RID: 116028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C53C")]
		[Address(RVA = "0x15CC130", Offset = "0x15CAD30", VA = "0x1815CC130")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C53D RID: 116029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C53D")]
		[Address(RVA = "0x15CB970", Offset = "0x15CA570", VA = "0x1815CB970")]
		protected void RenderData(MedalGroupItemView.Param param)
		{
		}

		// Token: 0x0601C53E RID: 116030 RVA: 0x000A7DF0 File Offset: 0x000A5FF0
		[Token(Token = "0x601C53E")]
		[Address(RVA = "0x15CC0A0", Offset = "0x15CACA0", VA = "0x1815CC0A0")]
		private static bool _CheckIfShowTypeSplit(MedalGroupListItemModel prevModel, bool isStyledGroup)
		{
			return default(bool);
		}

		// Token: 0x0601C53F RID: 116031 RVA: 0x000A7E08 File Offset: 0x000A6008
		[Token(Token = "0x601C53F")]
		[Address(RVA = "0x15CBD40", Offset = "0x15CA940", VA = "0x1815CBD40")]
		private static float _CalcSelfHeightLogicly(MedalGroupItemView prefab, MedalGroupListItemModel curModel, MedalGroupListItemModel prevModel)
		{
			return 0f;
		}

		// Token: 0x0601C540 RID: 116032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C540")]
		[Address(RVA = "0x15CC280", Offset = "0x15CAE80", VA = "0x1815CC280")]
		private void _UpdateMedalItems(int groupIndex, IList<MedalCommonViewModel> viewModelList, AsyncGameObjectLoader asyncLoader)
		{
		}

		// Token: 0x0601C541 RID: 116033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C541")]
		[Address(RVA = "0x15CB8D0", Offset = "0x15CA4D0", VA = "0x1815CB8D0")]
		public void OnClick()
		{
		}

		// Token: 0x0601C542 RID: 116034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C542")]
		[Address(RVA = "0x15CC5B0", Offset = "0x15CB1B0", VA = "0x1815CC5B0")]
		public MedalGroupItemView()
		{
		}

		// Token: 0x040250E4 RID: 151780
		[Token(Token = "0x40250E4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _groupImage;

		// Token: 0x040250E5 RID: 151781
		[Token(Token = "0x40250E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _groupBackImage;

		// Token: 0x040250E6 RID: 151782
		[Token(Token = "0x40250E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelStyledTitle;

		// Token: 0x040250E7 RID: 151783
		[Token(Token = "0x40250E7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040250E8 RID: 151784
		[Token(Token = "0x40250E8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _jumpBtn;

		// Token: 0x040250E9 RID: 151785
		[Token(Token = "0x40250E9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _typeSplit;

		// Token: 0x040250EA RID: 151786
		[Token(Token = "0x40250EA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("LayoutHeight")]
		private VerticalLayoutGroup _selfLayout;

		// Token: 0x040250EB RID: 151787
		[Token(Token = "0x40250EB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("LayoutHeight")]
		private GridLayoutGroup _childLayout;

		// Token: 0x040250EC RID: 151788
		[Token(Token = "0x40250EC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("LayoutHeight")]
		private LayoutElement _layoutTypeSplit;

		// Token: 0x040250ED RID: 151789
		[Token(Token = "0x40250ED")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("LayoutHeight")]
		private LayoutElement _layoutStyleTitle;

		// Token: 0x040250EE RID: 151790
		[Token(Token = "0x40250EE")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public UIMedalEvent clickEvent;

		// Token: 0x040250EF RID: 151791
		[Token(Token = "0x40250EF")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public UIStringEvent clickToGroupEvent;

		// Token: 0x040250F0 RID: 151792
		[Token(Token = "0x40250F0")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public bool ableToGetFlag;

		// Token: 0x040250F1 RID: 151793
		[Token(Token = "0x40250F1")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public string pageName;

		// Token: 0x040250F2 RID: 151794
		[Token(Token = "0x40250F2")]
		[FieldOffset(Offset = "0x88")]
		private MedalGroupItemView.ItemAdapter m_itemAdapter;

		// Token: 0x040250F3 RID: 151795
		[Token(Token = "0x40250F3")]
		[FieldOffset(Offset = "0x90")]
		private List<MedalCommonItemView.AsyncParam> m_paramList;

		// Token: 0x040250F4 RID: 151796
		[Token(Token = "0x40250F4")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x040250F5 RID: 151797
		[Token(Token = "0x40250F5")]
		[FieldOffset(Offset = "0xA0")]
		private MedalGroupViewModel m_cachedGroupModel;

		// Token: 0x040250F6 RID: 151798
		[Token(Token = "0x40250F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040250F7 RID: 151799
		[Token(Token = "0x40250F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderData;

		// Token: 0x040250F8 RID: 151800
		[Token(Token = "0x40250F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIfShowTypeSplit;

		// Token: 0x040250F9 RID: 151801
		[Token(Token = "0x40250F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalcSelfHeightLogicly;

		// Token: 0x040250FA RID: 151802
		[Token(Token = "0x40250FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateMedalItems;

		// Token: 0x040250FB RID: 151803
		[Token(Token = "0x40250FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040250FC RID: 151804
		[Token(Token = "0x40250FC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200496B RID: 18795
		[Token(Token = "0x200496B")]
		public struct Param
		{
			// Token: 0x040250FD RID: 151805
			[Token(Token = "0x40250FD")]
			[FieldOffset(Offset = "0x0")]
			public MedalGroupListItemModel viewModel;

			// Token: 0x040250FE RID: 151806
			[Token(Token = "0x40250FE")]
			[FieldOffset(Offset = "0x8")]
			public MedalGroupListItemModel prevModel;

			// Token: 0x040250FF RID: 151807
			[Token(Token = "0x40250FF")]
			[FieldOffset(Offset = "0x10")]
			public AsyncGameObjectLoader loader;

			// Token: 0x04025100 RID: 151808
			[Token(Token = "0x4025100")]
			[FieldOffset(Offset = "0x18")]
			public int groupIndex;

			// Token: 0x04025101 RID: 151809
			[Token(Token = "0x4025101")]
			[FieldOffset(Offset = "0x20")]
			public MedalGroupItemView prefab;
		}

		// Token: 0x0200496C RID: 18796
		[Token(Token = "0x200496C")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<MedalGroupItemView>
		{
			// Token: 0x0601C543 RID: 116035 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C543")]
			[Address(RVA = "0x15DC1F0", Offset = "0x15DADF0", VA = "0x1815DC1F0")]
			public string GetMedalGroupTypeID()
			{
				return null;
			}

			// Token: 0x0601C544 RID: 116036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C544")]
			[Address(RVA = "0x15DC610", Offset = "0x15DB210", VA = "0x1815DC610")]
			public VirtualView(MedalGroupItemView.Param param)
			{
			}

			// Token: 0x0601C545 RID: 116037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C545")]
			[Address(RVA = "0x15DC510", Offset = "0x15DB110", VA = "0x1815DC510")]
			public void RefreshView()
			{
			}

			// Token: 0x0601C546 RID: 116038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C546")]
			[Address(RVA = "0x15DC280", Offset = "0x15DAE80", VA = "0x1815DC280", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601C547 RID: 116039 RVA: 0x000A7E20 File Offset: 0x000A6020
			[Token(Token = "0x601C547")]
			[Address(RVA = "0x15DC2F0", Offset = "0x15DAEF0", VA = "0x1815DC2F0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601C548 RID: 116040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C548")]
			[Address(RVA = "0x15DC370", Offset = "0x15DAF70", VA = "0x1815DC370", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601C549 RID: 116041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C549")]
			[Address(RVA = "0x15DC4B0", Offset = "0x15DB0B0", VA = "0x1815DC4B0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x04025102 RID: 151810
			[Token(Token = "0x4025102")]
			[FieldOffset(Offset = "0x20")]
			private MedalGroupItemView.Param m_param;

			// Token: 0x04025103 RID: 151811
			[Token(Token = "0x4025103")]
			[FieldOffset(Offset = "0x48")]
			private float m_cachedHeight;

			// Token: 0x04025104 RID: 151812
			[Token(Token = "0x4025104")]
			[FieldOffset(Offset = "0x50")]
			public UIMedalEvent clickEvent;

			// Token: 0x04025105 RID: 151813
			[Token(Token = "0x4025105")]
			[FieldOffset(Offset = "0x58")]
			public UIStringEvent clickToGroupEvent;

			// Token: 0x04025106 RID: 151814
			[Token(Token = "0x4025106")]
			[FieldOffset(Offset = "0x60")]
			public bool ableToGetFlag;

			// Token: 0x04025107 RID: 151815
			[Token(Token = "0x4025107")]
			[FieldOffset(Offset = "0x68")]
			public string pageName;

			// Token: 0x04025108 RID: 151816
			[Token(Token = "0x4025108")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetMedalGroupTypeID;

			// Token: 0x04025109 RID: 151817
			[Token(Token = "0x4025109")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402510A RID: 151818
			[Token(Token = "0x402510A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RefreshView;

			// Token: 0x0402510B RID: 151819
			[Token(Token = "0x402510B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402510C RID: 151820
			[Token(Token = "0x402510C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402510D RID: 151821
			[Token(Token = "0x402510D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402510E RID: 151822
			[Token(Token = "0x402510E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnViewDetached;
		}

		// Token: 0x0200496D RID: 18797
		[Token(Token = "0x200496D")]
		private class ItemAdapter : AsyncDataViewListAdapter<MedalCommonItemView, MedalCommonItemView.AsyncParam>
		{
			// Token: 0x0601C54A RID: 116042 RVA: 0x000A7E38 File Offset: 0x000A6038
			[Token(Token = "0x601C54A")]
			[Address(RVA = "0x15C53E0", Offset = "0x15C3FE0", VA = "0x1815C53E0", Slot = "8")]
			protected override uint CostPerItem()
			{
				return 0U;
			}

			// Token: 0x0601C54B RID: 116043 RVA: 0x000A7E50 File Offset: 0x000A6050
			[Token(Token = "0x601C54B")]
			[Address(RVA = "0x15C5440", Offset = "0x15C4040", VA = "0x1815C5440", Slot = "4")]
			protected override int GetCount()
			{
				return 0;
			}

			// Token: 0x0601C54C RID: 116044 RVA: 0x000A7E68 File Offset: 0x000A6068
			[Token(Token = "0x601C54C")]
			[Address(RVA = "0x15C54B0", Offset = "0x15C40B0", VA = "0x1815C54B0", Slot = "5")]
			protected override MedalCommonItemView.AsyncParam GetData(int index)
			{
				return default(MedalCommonItemView.AsyncParam);
			}

			// Token: 0x0601C54D RID: 116045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C54D")]
			[Address(RVA = "0x15C5570", Offset = "0x15C4170", VA = "0x1815C5570", Slot = "7")]
			protected override Transform GetListContainer()
			{
				return null;
			}

			// Token: 0x0601C54E RID: 116046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C54E")]
			[Address(RVA = "0x15C5640", Offset = "0x15C4240", VA = "0x1815C5640", Slot = "6")]
			protected override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601C54F RID: 116047 RVA: 0x000A7E80 File Offset: 0x000A6080
			[Token(Token = "0x601C54F")]
			[Address(RVA = "0x15C55E0", Offset = "0x15C41E0", VA = "0x1815C55E0", Slot = "9")]
			protected override int GetListGroup()
			{
				return 0;
			}

			// Token: 0x0601C550 RID: 116048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C550")]
			[Address(RVA = "0x15C56B0", Offset = "0x15C42B0", VA = "0x1815C56B0")]
			public ItemAdapter()
			{
			}

			// Token: 0x0402510F RID: 151823
			[Token(Token = "0x402510F")]
			[FieldOffset(Offset = "0x18")]
			public List<MedalCommonItemView.AsyncParam> paramList;

			// Token: 0x04025110 RID: 151824
			[Token(Token = "0x4025110")]
			[FieldOffset(Offset = "0x20")]
			public SimpleLayoutContent content;

			// Token: 0x04025111 RID: 151825
			[Token(Token = "0x4025111")]
			[FieldOffset(Offset = "0x28")]
			public int groupIndex;

			// Token: 0x04025112 RID: 151826
			[Token(Token = "0x4025112")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CostPerItem;

			// Token: 0x04025113 RID: 151827
			[Token(Token = "0x4025113")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetCount;

			// Token: 0x04025114 RID: 151828
			[Token(Token = "0x4025114")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x04025115 RID: 151829
			[Token(Token = "0x4025115")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetListContainer;

			// Token: 0x04025116 RID: 151830
			[Token(Token = "0x4025116")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04025117 RID: 151831
			[Token(Token = "0x4025117")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetListGroup;

			// Token: 0x04025118 RID: 151832
			[Token(Token = "0x4025118")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200496E RID: 18798
		[Token(Token = "0x200496E")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700431D RID: 17181
			// (get) Token: 0x0601C551 RID: 116049 RVA: 0x000A7E98 File Offset: 0x000A6098
			[Token(Token = "0x1700431D")]
			public override int count
			{
				[Token(Token = "0x601C551")]
				[Address(RVA = "0x15C49A0", Offset = "0x15C35A0", VA = "0x1815C49A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C552 RID: 116050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C552")]
			[Address(RVA = "0x15C42A0", Offset = "0x15C2EA0", VA = "0x1815C42A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601C553 RID: 116051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C553")]
			[Address(RVA = "0x15C4940", Offset = "0x15C3540", VA = "0x1815C4940")]
			public Adapter()
			{
			}

			// Token: 0x04025119 RID: 151833
			[Token(Token = "0x4025119")]
			[FieldOffset(Offset = "0x20")]
			public List<MedalCommonViewModel> viewModelList;

			// Token: 0x0402511A RID: 151834
			[Token(Token = "0x402511A")]
			[FieldOffset(Offset = "0x28")]
			public UIMedalEvent clickEvent;

			// Token: 0x0402511B RID: 151835
			[Token(Token = "0x402511B")]
			[FieldOffset(Offset = "0x30")]
			public bool ableToGetFlag;

			// Token: 0x0402511C RID: 151836
			[Token(Token = "0x402511C")]
			[FieldOffset(Offset = "0x38")]
			public string pageName;

			// Token: 0x0402511D RID: 151837
			[Token(Token = "0x402511D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402511E RID: 151838
			[Token(Token = "0x402511E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402511F RID: 151839
			[Token(Token = "0x402511F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
