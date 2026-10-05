using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006711 RID: 26385
	[Token(Token = "0x2006711")]
	public class HandBookV2MissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170059A9 RID: 22953
		// (set) Token: 0x06025DD0 RID: 155088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059A9")]
		public UIStringEvent onBtnGetClick
		{
			[Token(Token = "0x6025DD0")]
			[Address(RVA = "0x20E59F0", Offset = "0x20E45F0", VA = "0x1820E59F0")]
			set
			{
			}
		}

		// Token: 0x06025DD1 RID: 155089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DD1")]
		[Address(RVA = "0x20E4F40", Offset = "0x20E3B40", VA = "0x1820E4F40")]
		public void OnBtnGetClick()
		{
		}

		// Token: 0x06025DD2 RID: 155090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DD2")]
		[Address(RVA = "0x20E4FD0", Offset = "0x20E3BD0", VA = "0x1820E4FD0")]
		public void Render(HandBookV2MissionListItemModel missionItemModel)
		{
		}

		// Token: 0x06025DD3 RID: 155091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DD3")]
		[Address(RVA = "0x20E58D0", Offset = "0x20E44D0", VA = "0x1820E58D0")]
		private void _OnClickItemButton(int index)
		{
		}

		// Token: 0x06025DD4 RID: 155092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DD4")]
		[Address(RVA = "0x20E57B0", Offset = "0x20E43B0", VA = "0x1820E57B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025DD5 RID: 155093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DD5")]
		[Address(RVA = "0x20E5980", Offset = "0x20E4580", VA = "0x1820E5980")]
		public HandBookV2MissionItemView()
		{
		}

		// Token: 0x040353FD RID: 218109
		[Token(Token = "0x40353FD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgForceIcon;

		// Token: 0x040353FE RID: 218110
		[Token(Token = "0x40353FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textForceName;

		// Token: 0x040353FF RID: 218111
		[Token(Token = "0x40353FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotalFavorPoint;

		// Token: 0x04035400 RID: 218112
		[Token(Token = "0x4035400")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textAvgFavorPoint;

		// Token: 0x04035401 RID: 218113
		[Token(Token = "0x4035401")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _charListContent;

		// Token: 0x04035402 RID: 218114
		[Token(Token = "0x4035402")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _normalBgGo;

		// Token: 0x04035403 RID: 218115
		[Token(Token = "0x4035403")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _availBgGo;

		// Token: 0x04035404 RID: 218116
		[Token(Token = "0x4035404")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _alreadyGetGo;

		// Token: 0x04035405 RID: 218117
		[Token(Token = "0x4035405")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04035406 RID: 218118
		[Token(Token = "0x4035406")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04035407 RID: 218119
		[Token(Token = "0x4035407")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04035408 RID: 218120
		[Token(Token = "0x4035408")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_hasInited;

		// Token: 0x04035409 RID: 218121
		[Token(Token = "0x4035409")]
		[FieldOffset(Offset = "0x70")]
		private HandBookV2MissionListItemModel m_missionItemModel;

		// Token: 0x0403540A RID: 218122
		[Token(Token = "0x403540A")]
		[FieldOffset(Offset = "0x78")]
		private UIItemCard m_itemCard;

		// Token: 0x0403540B RID: 218123
		[Token(Token = "0x403540B")]
		[FieldOffset(Offset = "0x80")]
		private UIItemViewModel m_itemModel;

		// Token: 0x0403540C RID: 218124
		[Token(Token = "0x403540C")]
		[FieldOffset(Offset = "0x88")]
		private HandBookV2MissionItemView.Adapter m_adapter;

		// Token: 0x0403540D RID: 218125
		[Token(Token = "0x403540D")]
		[FieldOffset(Offset = "0x90")]
		private UIStringEvent m_onBtnGetClick;

		// Token: 0x0403540E RID: 218126
		[Token(Token = "0x403540E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onBtnGetClick;

		// Token: 0x0403540F RID: 218127
		[Token(Token = "0x403540F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBtnGetClick;

		// Token: 0x04035410 RID: 218128
		[Token(Token = "0x4035410")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035411 RID: 218129
		[Token(Token = "0x4035411")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnClickItemButton;

		// Token: 0x04035412 RID: 218130
		[Token(Token = "0x4035412")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035413 RID: 218131
		[Token(Token = "0x4035413")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006712 RID: 26386
		[Token(Token = "0x2006712")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170059AA RID: 22954
			// (set) Token: 0x06025DD6 RID: 155094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170059AA")]
			public HandBookV2MissionListItemModel dataSource
			{
				[Token(Token = "0x6025DD6")]
				[Address(RVA = "0x20CDD10", Offset = "0x20CC910", VA = "0x1820CDD10")]
				set
				{
				}
			}

			// Token: 0x170059AB RID: 22955
			// (get) Token: 0x06025DD7 RID: 155095 RVA: 0x000C93D8 File Offset: 0x000C75D8
			[Token(Token = "0x170059AB")]
			public override int count
			{
				[Token(Token = "0x6025DD7")]
				[Address(RVA = "0x20CDC90", Offset = "0x20CC890", VA = "0x1820CDC90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06025DD8 RID: 155096 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025DD8")]
			[Address(RVA = "0x20CDA90", Offset = "0x20CC690", VA = "0x1820CDA90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06025DD9 RID: 155097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025DD9")]
			[Address(RVA = "0x20CDC30", Offset = "0x20CC830", VA = "0x1820CDC30")]
			public Adapter()
			{
			}

			// Token: 0x04035414 RID: 218132
			[Token(Token = "0x4035414")]
			[FieldOffset(Offset = "0x20")]
			private HandBookV2MissionListItemModel m_missionListModel;

			// Token: 0x04035415 RID: 218133
			[Token(Token = "0x4035415")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_dataSource;

			// Token: 0x04035416 RID: 218134
			[Token(Token = "0x4035416")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04035417 RID: 218135
			[Token(Token = "0x4035417")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04035418 RID: 218136
			[Token(Token = "0x4035418")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
