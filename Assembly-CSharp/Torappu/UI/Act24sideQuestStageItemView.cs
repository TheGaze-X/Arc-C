using System;
using Il2CppDummyDll;
using Torappu.Activity.Act24side;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003441 RID: 13377
	[Token(Token = "0x2003441")]
	public class Act24sideQuestStageItemView : MonoBehaviour, IHotfixable, IAct24sideQuestStageItemView
	{
		// Token: 0x06015658 RID: 87640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015658")]
		[Address(RVA = "0xDDC370", Offset = "0xDDAF70", VA = "0x180DDC370", Slot = "4")]
		public void Render(Act24sideQuestStageItemModel questItemModel, bool isSelect)
		{
		}

		// Token: 0x06015659 RID: 87641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015659")]
		[Address(RVA = "0xDDC970", Offset = "0xDDB570", VA = "0x180DDC970")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601565A RID: 87642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601565A")]
		[Address(RVA = "0xDDC890", Offset = "0xDDB490", VA = "0x180DDC890")]
		private string _GetSpriteName(bool isHard, bool isSelect, bool isDragon)
		{
			return null;
		}

		// Token: 0x0601565B RID: 87643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601565B")]
		[Address(RVA = "0xDDC210", Offset = "0xDDAE10", VA = "0x180DDC210")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x0601565C RID: 87644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601565C")]
		[Address(RVA = "0xDDCAB0", Offset = "0xDDB6B0", VA = "0x180DDCAB0")]
		public Act24sideQuestStageItemView()
		{
		}

		// Token: 0x040199A8 RID: 104872
		[Token(Token = "0x40199A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _bgNormalGo;

		// Token: 0x040199A9 RID: 104873
		[Token(Token = "0x40199A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bgNormalSelectGo;

		// Token: 0x040199AA RID: 104874
		[Token(Token = "0x40199AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _bgDragonGo;

		// Token: 0x040199AB RID: 104875
		[Token(Token = "0x40199AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bgDragonSelectGo;

		// Token: 0x040199AC RID: 104876
		[Token(Token = "0x40199AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rtInfo;

		// Token: 0x040199AD RID: 104877
		[Token(Token = "0x40199AD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _unselectOffset;

		// Token: 0x040199AE RID: 104878
		[Token(Token = "0x40199AE")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _selectOffset;

		// Token: 0x040199AF RID: 104879
		[Token(Token = "0x40199AF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x040199B0 RID: 104880
		[Token(Token = "0x40199B0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorStageNameNormal;

		// Token: 0x040199B1 RID: 104881
		[Token(Token = "0x40199B1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorStageNameHighlight;

		// Token: 0x040199B2 RID: 104882
		[Token(Token = "0x40199B2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _imgQuestIcon;

		// Token: 0x040199B3 RID: 104883
		[Token(Token = "0x40199B3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasObject _atlasQuest;

		// Token: 0x040199B4 RID: 104884
		[Token(Token = "0x40199B4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _iconNormalName;

		// Token: 0x040199B5 RID: 104885
		[Token(Token = "0x40199B5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _iconNormalSelectName;

		// Token: 0x040199B6 RID: 104886
		[Token(Token = "0x40199B6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _iconHardName;

		// Token: 0x040199B7 RID: 104887
		[Token(Token = "0x40199B7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _iconHardSelectName;

		// Token: 0x040199B8 RID: 104888
		[Token(Token = "0x40199B8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SimpleLayoutContent _rankList;

		// Token: 0x040199B9 RID: 104889
		[Token(Token = "0x40199B9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _newFlagGo;

		// Token: 0x040199BA RID: 104890
		[Token(Token = "0x40199BA")]
		[FieldOffset(Offset = "0xB0")]
		private Act24sideQuestStageItemModel m_questItemModel;

		// Token: 0x040199BB RID: 104891
		[Token(Token = "0x40199BB")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isSelect;

		// Token: 0x040199BC RID: 104892
		[Token(Token = "0x40199BC")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040199BD RID: 104893
		[Token(Token = "0x40199BD")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_hasInited;

		// Token: 0x040199BE RID: 104894
		[Token(Token = "0x40199BE")]
		[FieldOffset(Offset = "0xD8")]
		private Act24sideQuestStageItemView.RankListAdapter m_rankListAdapter;

		// Token: 0x040199BF RID: 104895
		[Token(Token = "0x40199BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040199C0 RID: 104896
		[Token(Token = "0x40199C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040199C1 RID: 104897
		[Token(Token = "0x40199C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetSpriteName;

		// Token: 0x040199C2 RID: 104898
		[Token(Token = "0x40199C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x040199C3 RID: 104899
		[Token(Token = "0x40199C3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003442 RID: 13378
		[Token(Token = "0x2003442")]
		private class RankListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601565D RID: 87645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601565D")]
			[Address(RVA = "0xDEB910", Offset = "0xDEA510", VA = "0x180DEB910")]
			public RankListAdapter(Act24sideQuestStageItemView closure)
			{
			}

			// Token: 0x17003298 RID: 12952
			// (get) Token: 0x0601565E RID: 87646 RVA: 0x0008BB18 File Offset: 0x00089D18
			[Token(Token = "0x17003298")]
			public override int count
			{
				[Token(Token = "0x601565E")]
				[Address(RVA = "0xDEB990", Offset = "0xDEA590", VA = "0x180DEB990", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601565F RID: 87647 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601565F")]
			[Address(RVA = "0xDEB730", Offset = "0xDEA330", VA = "0x180DEB730", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040199C4 RID: 104900
			[Token(Token = "0x40199C4")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideQuestStageItemView m_closure;

			// Token: 0x040199C5 RID: 104901
			[Token(Token = "0x40199C5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040199C6 RID: 104902
			[Token(Token = "0x40199C6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040199C7 RID: 104903
			[Token(Token = "0x40199C7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
