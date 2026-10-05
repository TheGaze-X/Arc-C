using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CB7 RID: 7351
	[Token(Token = "0x2001CB7")]
	public class BuildingSMRoomGroupListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B63A RID: 46650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B63A")]
		[Address(RVA = "0x33046C0", Offset = "0x33032C0", VA = "0x1833046C0")]
		public void Render(List<StationRoomGroupViewModel> roomGroups)
		{
		}

		// Token: 0x0600B63B RID: 46651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B63B")]
		[Address(RVA = "0x3304880", Offset = "0x3303480", VA = "0x183304880")]
		private void _RebuildVirtualViews(List<StationRoomGroupViewModel> roomGroups)
		{
		}

		// Token: 0x0600B63C RID: 46652 RVA: 0x00044E80 File Offset: 0x00043080
		[Token(Token = "0x600B63C")]
		[Address(RVA = "0x3304E80", Offset = "0x3303A80", VA = "0x183304E80")]
		private bool _RefreshRoomStatus(List<StationRoomGroupViewModel> roomGroups)
		{
			return default(bool);
		}

		// Token: 0x0600B63D RID: 46653 RVA: 0x00044E98 File Offset: 0x00043098
		[Token(Token = "0x600B63D")]
		[Address(RVA = "0x3304770", Offset = "0x3303370", VA = "0x183304770")]
		private Color _GetTitleColor(BuildingData.RoomType roomType)
		{
			return default(Color);
		}

		// Token: 0x0600B63E RID: 46654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B63E")]
		[Address(RVA = "0x33052D0", Offset = "0x3303ED0", VA = "0x1833052D0")]
		public BuildingSMRoomGroupListView()
		{
		}

		// Token: 0x0400B315 RID: 45845
		[Token(Token = "0x400B315")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x0400B316 RID: 45846
		[Token(Token = "0x400B316")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingSMRoomGroupTitleView _titlePrefab;

		// Token: 0x0400B317 RID: 45847
		[Token(Token = "0x400B317")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingSMRoomItemView _roomPrefab;

		// Token: 0x0400B318 RID: 45848
		[Token(Token = "0x400B318")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildingSMRoomGroupListView.RoomColor[] _roomColors;

		// Token: 0x0400B319 RID: 45849
		[Token(Token = "0x400B319")]
		[FieldOffset(Offset = "0x38")]
		private List<UIRecycleLayoutAdapter.IVirtualView> m_viewList;

		// Token: 0x0400B31A RID: 45850
		[Token(Token = "0x400B31A")]
		[FieldOffset(Offset = "0x40")]
		private BuildingSMRoomGroupListView.Adapter m_adapter;

		// Token: 0x0400B31B RID: 45851
		[Token(Token = "0x400B31B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B31C RID: 45852
		[Token(Token = "0x400B31C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RebuildVirtualViews;

		// Token: 0x0400B31D RID: 45853
		[Token(Token = "0x400B31D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshRoomStatus;

		// Token: 0x0400B31E RID: 45854
		[Token(Token = "0x400B31E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetTitleColor;

		// Token: 0x0400B31F RID: 45855
		[Token(Token = "0x400B31F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CB8 RID: 7352
		[Token(Token = "0x2001CB8")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0600B63F RID: 46655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B63F")]
			[Address(RVA = "0x3303A30", Offset = "0x3302630", VA = "0x183303A30")]
			public Adapter(BuildingSMRoomGroupListView closure)
			{
			}

			// Token: 0x0600B640 RID: 46656 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B640")]
			[Address(RVA = "0x33035C0", Offset = "0x33021C0", VA = "0x1833035C0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0600B641 RID: 46657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B641")]
			[Address(RVA = "0x3303630", Offset = "0x3302230", VA = "0x183303630")]
			public void RebuildAll()
			{
			}

			// Token: 0x0400B320 RID: 45856
			[Token(Token = "0x400B320")]
			[FieldOffset(Offset = "0x18")]
			private BuildingSMRoomGroupListView m_closure;

			// Token: 0x0400B321 RID: 45857
			[Token(Token = "0x400B321")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B322 RID: 45858
			[Token(Token = "0x400B322")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0400B323 RID: 45859
			[Token(Token = "0x400B323")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildAll;
		}

		// Token: 0x02001CB9 RID: 7353
		[Token(Token = "0x2001CB9")]
		[Serializable]
		private class RoomColor
		{
			// Token: 0x0600B642 RID: 46658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B642")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoomColor()
			{
			}

			// Token: 0x0400B324 RID: 45860
			[Token(Token = "0x400B324")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomType roomId;

			// Token: 0x0400B325 RID: 45861
			[Token(Token = "0x400B325")]
			[FieldOffset(Offset = "0x14")]
			public Color color;
		}
	}
}
