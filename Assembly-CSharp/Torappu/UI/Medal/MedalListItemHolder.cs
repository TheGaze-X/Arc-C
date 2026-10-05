using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004980 RID: 18816
	[Token(Token = "0x2004980")]
	public class MedalListItemHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004324 RID: 17188
		// (get) Token: 0x0601C5B2 RID: 116146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004324")]
		public string originMedalId
		{
			[Token(Token = "0x601C5B2")]
			[Address(RVA = "0x15D1E20", Offset = "0x15D0A20", VA = "0x1815D1E20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C5B3 RID: 116147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5B3")]
		[Address(RVA = "0x15D0CD0", Offset = "0x15CF8D0", VA = "0x1815D0CD0")]
		public void RenderTitle(MedalGroupViewModel groupViewModel)
		{
		}

		// Token: 0x0601C5B4 RID: 116148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5B4")]
		[Address(RVA = "0x15D0D60", Offset = "0x15CF960", VA = "0x1815D0D60")]
		public void RenderView(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5B5 RID: 116149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5B5")]
		[Address(RVA = "0x15D08A0", Offset = "0x15CF4A0", VA = "0x1815D08A0")]
		public void OnOpenDetail()
		{
		}

		// Token: 0x0601C5B6 RID: 116150 RVA: 0x000A7FA0 File Offset: 0x000A61A0
		[Token(Token = "0x601C5B6")]
		[Address(RVA = "0x15D0EC0", Offset = "0x15CFAC0", VA = "0x1815D0EC0")]
		private static MedalListItemHolder.ViewStatus _ConvertToViewStatus(MedalCommonViewModel viewModel)
		{
			return MedalListItemHolder.ViewStatus.NONE;
		}

		// Token: 0x0601C5B7 RID: 116151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5B7")]
		[Address(RVA = "0x15D0FC0", Offset = "0x15CFBC0", VA = "0x1815D0FC0")]
		private void _RenderListItems(MedalListItemHolder.ViewStatus status, MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5B8 RID: 116152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5B8")]
		private void _RenderItemView<T>(MedalListItemHolder.RenderViewOptions<T> options, ref T viewInst) where T : MonoBehaviour, MedalListItemHolder.IMedalListItem
		{
		}

		// Token: 0x0601C5B9 RID: 116153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5B9")]
		[Address(RVA = "0x15D18B0", Offset = "0x15D04B0", VA = "0x1815D18B0")]
		private void _UpdateAbleItemView(MedalListItemHolder.ViewStatus status, MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5BA RID: 116154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5BA")]
		[Address(RVA = "0x15D1A60", Offset = "0x15D0660", VA = "0x1815D1A60")]
		private void _UpdateAlreadyGetView(MedalListItemHolder.ViewStatus status, MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5BB RID: 116155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5BB")]
		[Address(RVA = "0x15D1C10", Offset = "0x15D0810", VA = "0x1815D1C10")]
		private void _UpdateNotGetView(MedalListItemHolder.ViewStatus status, MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C5BC RID: 116156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5BC")]
		[Address(RVA = "0x15D1510", Offset = "0x15D0110", VA = "0x1815D1510")]
		private void _RenderTitleView(MedalListItemHolder.ViewStatus status, MedalGroupViewModel groupViewModel)
		{
		}

		// Token: 0x0601C5BD RID: 116157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5BD")]
		[Address(RVA = "0x15D1DC0", Offset = "0x15D09C0", VA = "0x1815D1DC0")]
		public MedalListItemHolder()
		{
		}

		// Token: 0x040251E6 RID: 152038
		[Token(Token = "0x40251E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MedalListAbleToGetItemView _ableItemView;

		// Token: 0x040251E7 RID: 152039
		[Token(Token = "0x40251E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MedalListAlreadyGetItemView _getItemView;

		// Token: 0x040251E8 RID: 152040
		[Token(Token = "0x40251E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MedalListNotGetItemView _notGetItemView;

		// Token: 0x040251E9 RID: 152041
		[Token(Token = "0x40251E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MedalListTitleView _titleView;

		// Token: 0x040251EA RID: 152042
		[Token(Token = "0x40251EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040251EB RID: 152043
		[Token(Token = "0x40251EB")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public UIMedalEvent clickMedalEvent;

		// Token: 0x040251EC RID: 152044
		[Token(Token = "0x40251EC")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public UIStringEvent clickToGroupEvent;

		// Token: 0x040251ED RID: 152045
		[Token(Token = "0x40251ED")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public UIStringEvent clickToMedalEvent;

		// Token: 0x040251EE RID: 152046
		[Token(Token = "0x40251EE")]
		[FieldOffset(Offset = "0x58")]
		private MedalCommonViewModel m_cacheviewModel;

		// Token: 0x040251EF RID: 152047
		[Token(Token = "0x40251EF")]
		[FieldOffset(Offset = "0x60")]
		private MedalListAbleToGetItemView m_ableItemView;

		// Token: 0x040251F0 RID: 152048
		[Token(Token = "0x40251F0")]
		[FieldOffset(Offset = "0x68")]
		private MedalListAlreadyGetItemView m_getItemView;

		// Token: 0x040251F1 RID: 152049
		[Token(Token = "0x40251F1")]
		[FieldOffset(Offset = "0x70")]
		private MedalListNotGetItemView m_notGetItemView;

		// Token: 0x040251F2 RID: 152050
		[Token(Token = "0x40251F2")]
		[FieldOffset(Offset = "0x78")]
		private MedalListTitleView m_titleView;

		// Token: 0x040251F3 RID: 152051
		[Token(Token = "0x40251F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_originMedalId;

		// Token: 0x040251F4 RID: 152052
		[Token(Token = "0x40251F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderTitle;

		// Token: 0x040251F5 RID: 152053
		[Token(Token = "0x40251F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040251F6 RID: 152054
		[Token(Token = "0x40251F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnOpenDetail;

		// Token: 0x040251F7 RID: 152055
		[Token(Token = "0x40251F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ConvertToViewStatus;

		// Token: 0x040251F8 RID: 152056
		[Token(Token = "0x40251F8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderListItems;

		// Token: 0x040251F9 RID: 152057
		[Token(Token = "0x40251F9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderItemView;

		// Token: 0x040251FA RID: 152058
		[Token(Token = "0x40251FA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateAbleItemView;

		// Token: 0x040251FB RID: 152059
		[Token(Token = "0x40251FB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateAlreadyGetView;

		// Token: 0x040251FC RID: 152060
		[Token(Token = "0x40251FC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateNotGetView;

		// Token: 0x040251FD RID: 152061
		[Token(Token = "0x40251FD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderTitleView;

		// Token: 0x040251FE RID: 152062
		[Token(Token = "0x40251FE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004981 RID: 18817
		[Token(Token = "0x2004981")]
		public interface IMedalListItem
		{
			// Token: 0x0601C5BE RID: 116158
			[Token(Token = "0x601C5BE")]
			void RenderView(MedalCommonViewModel viewModel);
		}

		// Token: 0x02004982 RID: 18818
		[Token(Token = "0x2004982")]
		private enum ViewStatus
		{
			// Token: 0x04025200 RID: 152064
			[Token(Token = "0x4025200")]
			NONE,
			// Token: 0x04025201 RID: 152065
			[Token(Token = "0x4025201")]
			TITLE,
			// Token: 0x04025202 RID: 152066
			[Token(Token = "0x4025202")]
			ABLETOGET,
			// Token: 0x04025203 RID: 152067
			[Token(Token = "0x4025203")]
			ALREADYGET,
			// Token: 0x04025204 RID: 152068
			[Token(Token = "0x4025204")]
			NOTGET
		}

		// Token: 0x02004983 RID: 18819
		[Token(Token = "0x2004983")]
		private struct RenderViewOptions<T> where T : MonoBehaviour, MedalListItemHolder.IMedalListItem
		{
			// Token: 0x04025205 RID: 152069
			[Token(Token = "0x4025205")]
			[FieldOffset(Offset = "0x0")]
			public T prefab;

			// Token: 0x04025206 RID: 152070
			[Token(Token = "0x4025206")]
			[FieldOffset(Offset = "0x0")]
			public MedalListItemHolder.ViewStatus targetStatus;

			// Token: 0x04025207 RID: 152071
			[Token(Token = "0x4025207")]
			[FieldOffset(Offset = "0x0")]
			public MedalListItemHolder.ViewStatus curStatus;

			// Token: 0x04025208 RID: 152072
			[Token(Token = "0x4025208")]
			[FieldOffset(Offset = "0x0")]
			public MedalCommonViewModel viewModel;
		}
	}
}
