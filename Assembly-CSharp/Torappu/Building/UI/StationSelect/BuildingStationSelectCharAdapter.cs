using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C80 RID: 7296
	[Token(Token = "0x2001C80")]
	public class BuildingStationSelectCharAdapter : LoopScrollAdapter<BuildingStationSelectCharAdapter.ViewHolder, StationCharViewModel>
	{
		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x0600B53E RID: 46398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015CE")]
		public List<int> selectedCharInsts
		{
			[Token(Token = "0x600B53E")]
			[Address(RVA = "0x32EEF90", Offset = "0x32EDB90", VA = "0x1832EEF90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B53F RID: 46399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B53F")]
		[Address(RVA = "0x32EE630", Offset = "0x32ED230", VA = "0x1832EE630", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x0600B540 RID: 46400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B540")]
		[Address(RVA = "0x32EE570", Offset = "0x32ED170", VA = "0x1832EE570", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600B541 RID: 46401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B541")]
		[Address(RVA = "0x32EE760", Offset = "0x32ED360", VA = "0x1832EE760", Slot = "13")]
		public override void UpdateView(int position, GameObject view, BuildingStationSelectCharAdapter.ViewHolder holder, StationCharViewModel data)
		{
		}

		// Token: 0x0600B542 RID: 46402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B542")]
		[Address(RVA = "0x32EE6A0", Offset = "0x32ED2A0", VA = "0x1832EE6A0")]
		public void SetParams(List<int> selectedChrInstIds, CharSortType sortType, StationSelectStateBean.StationSelectStateBeanInputType selectType, [Optional] BuildingStationSelectState.IPlugin plugin)
		{
		}

		// Token: 0x0600B543 RID: 46403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B543")]
		[Address(RVA = "0x32EEDA0", Offset = "0x32ED9A0", VA = "0x1832EEDA0")]
		private void _TryRegisterAVGFirstItem(BuildingStationSelectCharItemView cardView)
		{
		}

		// Token: 0x0600B544 RID: 46404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B544")]
		[Address(RVA = "0x32EEEC0", Offset = "0x32EDAC0", VA = "0x1832EEEC0")]
		public BuildingStationSelectCharAdapter()
		{
		}

		// Token: 0x0400B149 RID: 45385
		[Token(Token = "0x400B149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuildingStationSelectCharItemView _charPrefab;

		// Token: 0x0400B14A RID: 45386
		[Token(Token = "0x400B14A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<int> m_selectedCharInsts;

		// Token: 0x0400B14B RID: 45387
		[Token(Token = "0x400B14B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BuildingStationSelectState.IPlugin m_selectPlugin;

		// Token: 0x0400B14C RID: 45388
		[Token(Token = "0x400B14C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_AVGIsFirstItemRegistered;

		// Token: 0x0400B14D RID: 45389
		[Token(Token = "0x400B14D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private CharSortType m_sortType;

		// Token: 0x0400B14E RID: 45390
		[Token(Token = "0x400B14E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private StationSelectStateBean.StationSelectStateBeanInputType m_selectType;

		// Token: 0x0400B14F RID: 45391
		[Token(Token = "0x400B14F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action<StationCharViewModel> onCharClicked;

		// Token: 0x0400B150 RID: 45392
		[Token(Token = "0x400B150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public int maxSelectCount;

		// Token: 0x0400B151 RID: 45393
		[Token(Token = "0x400B151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedCharInsts;

		// Token: 0x0400B152 RID: 45394
		[Token(Token = "0x400B152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x0400B153 RID: 45395
		[Token(Token = "0x400B153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0400B154 RID: 45396
		[Token(Token = "0x400B154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0400B155 RID: 45397
		[Token(Token = "0x400B155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetParams;

		// Token: 0x0400B156 RID: 45398
		[Token(Token = "0x400B156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryRegisterAVGFirstItem;

		// Token: 0x0400B157 RID: 45399
		[Token(Token = "0x400B157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C81 RID: 7297
		[Token(Token = "0x2001C81")]
		public class ViewHolder
		{
			// Token: 0x0600B545 RID: 46405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B545")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0400B158 RID: 45400
			[Token(Token = "0x400B158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BuildingStationSelectCharItemView view;
		}
	}
}
