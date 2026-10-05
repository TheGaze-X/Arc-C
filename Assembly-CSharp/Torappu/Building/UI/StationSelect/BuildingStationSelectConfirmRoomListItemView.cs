using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C8F RID: 7311
	[Token(Token = "0x2001C8F")]
	public class BuildingStationSelectConfirmRoomListItemView : DataBinder<ChangedRoomGroupProperty>, IHotfixable
	{
		// Token: 0x0600B586 RID: 46470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B586")]
		[Address(RVA = "0x3310900", Offset = "0x330F500", VA = "0x183310900")]
		private void _InitIfNot(SimpleLayoutContent content)
		{
		}

		// Token: 0x0600B587 RID: 46471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B587")]
		[Address(RVA = "0x3310AB0", Offset = "0x330F6B0", VA = "0x183310AB0")]
		private void _RenderCurrentRoom()
		{
		}

		// Token: 0x0600B588 RID: 46472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B588")]
		[Address(RVA = "0x3310A30", Offset = "0x330F630", VA = "0x183310A30")]
		public void _RenderChangedRooms()
		{
		}

		// Token: 0x0600B589 RID: 46473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B589")]
		[Address(RVA = "0x3310630", Offset = "0x330F230", VA = "0x183310630", Slot = "7")]
		public override void OnValueChanged(ChangedRoomGroupProperty property)
		{
		}

		// Token: 0x0600B58A RID: 46474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B58A")]
		[Address(RVA = "0x3310B30", Offset = "0x330F730", VA = "0x183310B30")]
		public BuildingStationSelectConfirmRoomListItemView()
		{
		}

		// Token: 0x0400B1EC RID: 45548
		[Token(Token = "0x400B1EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _curRoomPanel;

		// Token: 0x0400B1ED RID: 45549
		[Token(Token = "0x400B1ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _curRoomContainer;

		// Token: 0x0400B1EE RID: 45550
		[Token(Token = "0x400B1EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _changedRoomPanel;

		// Token: 0x0400B1EF RID: 45551
		[Token(Token = "0x400B1EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _changedRoomList;

		// Token: 0x0400B1F0 RID: 45552
		[Token(Token = "0x400B1F0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuildingStationSelectConfirmRoomItemView _roomItemPrefab;

		// Token: 0x0400B1F1 RID: 45553
		[Token(Token = "0x400B1F1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textChangedRoomDesc;

		// Token: 0x0400B1F2 RID: 45554
		[Token(Token = "0x400B1F2")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0400B1F3 RID: 45555
		[Token(Token = "0x400B1F3")]
		[FieldOffset(Offset = "0x58")]
		private BuildingStationSelectConfirmRoomListItemView.RoomAdapter m_adapter;

		// Token: 0x0400B1F4 RID: 45556
		[Token(Token = "0x400B1F4")]
		[FieldOffset(Offset = "0x60")]
		private ChangedRoomGroupViewModel m_viewModel;

		// Token: 0x0400B1F5 RID: 45557
		[Token(Token = "0x400B1F5")]
		[FieldOffset(Offset = "0x68")]
		private int m_roomCount;

		// Token: 0x0400B1F6 RID: 45558
		[Token(Token = "0x400B1F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B1F7 RID: 45559
		[Token(Token = "0x400B1F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCurrentRoom;

		// Token: 0x0400B1F8 RID: 45560
		[Token(Token = "0x400B1F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderChangedRooms;

		// Token: 0x0400B1F9 RID: 45561
		[Token(Token = "0x400B1F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B1FA RID: 45562
		[Token(Token = "0x400B1FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C90 RID: 7312
		[Token(Token = "0x2001C90")]
		private class RoomAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B58B RID: 46475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B58B")]
			[Address(RVA = "0x33132C0", Offset = "0x3311EC0", VA = "0x1833132C0")]
			public RoomAdapter(BuildingStationSelectConfirmRoomListItemView closure)
			{
			}

			// Token: 0x170015D6 RID: 5590
			// (get) Token: 0x0600B58C RID: 46476 RVA: 0x00044CB8 File Offset: 0x00042EB8
			[Token(Token = "0x170015D6")]
			public override int count
			{
				[Token(Token = "0x600B58C")]
				[Address(RVA = "0x3313340", Offset = "0x3311F40", VA = "0x183313340", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B58D RID: 46477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B58D")]
			[Address(RVA = "0x3313110", Offset = "0x3311D10", VA = "0x183313110", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400B1FB RID: 45563
			[Token(Token = "0x400B1FB")]
			[FieldOffset(Offset = "0x20")]
			private BuildingStationSelectConfirmRoomListItemView m_closure;

			// Token: 0x0400B1FC RID: 45564
			[Token(Token = "0x400B1FC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B1FD RID: 45565
			[Token(Token = "0x400B1FD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400B1FE RID: 45566
			[Token(Token = "0x400B1FE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
