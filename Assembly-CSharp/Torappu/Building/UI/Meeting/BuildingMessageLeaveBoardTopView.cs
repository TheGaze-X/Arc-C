using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D26 RID: 7462
	[Token(Token = "0x2001D26")]
	public class BuildingMessageLeaveBoardTopView : DataBinder<BuildingMessageLeaveBoardProperty>, IHotfixable
	{
		// Token: 0x0600B834 RID: 47156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B834")]
		[Address(RVA = "0x335E370", Offset = "0x335CF70", VA = "0x18335E370")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B835 RID: 47157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B835")]
		[Address(RVA = "0x335E010", Offset = "0x335CC10", VA = "0x18335E010", Slot = "7")]
		public override void OnValueChanged(BuildingMessageLeaveBoardProperty property)
		{
		}

		// Token: 0x0600B836 RID: 47158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B836")]
		[Address(RVA = "0x335E400", Offset = "0x335D000", VA = "0x18335E400")]
		private void _UpdatePlayerView(RoomSlotModel meetingRoom)
		{
		}

		// Token: 0x0600B837 RID: 47159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B837")]
		[Address(RVA = "0x335E650", Offset = "0x335D250", VA = "0x18335E650")]
		private void _UpdateVisitorView()
		{
		}

		// Token: 0x0600B838 RID: 47160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B838")]
		[Address(RVA = "0x335E570", Offset = "0x335D170", VA = "0x18335E570")]
		private void _UpdateRoomName(string ownerName)
		{
		}

		// Token: 0x0600B839 RID: 47161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B839")]
		[Address(RVA = "0x335E7D0", Offset = "0x335D3D0", VA = "0x18335E7D0")]
		public BuildingMessageLeaveBoardTopView()
		{
		}

		// Token: 0x0400B644 RID: 46660
		[Token(Token = "0x400B644")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingUIRoomTitle _roomTitle;

		// Token: 0x0400B645 RID: 46661
		[Token(Token = "0x400B645")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CommonResourceBarItem _socialPointBar;

		// Token: 0x0400B646 RID: 46662
		[Token(Token = "0x400B646")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRoomName;

		// Token: 0x0400B647 RID: 46663
		[Token(Token = "0x400B647")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _roomNameTwoStateToggle;

		// Token: 0x0400B648 RID: 46664
		[Token(Token = "0x400B648")]
		[FieldOffset(Offset = "0x40")]
		private CommonBasicRoomViewProperty m_basicRoomProperty;

		// Token: 0x0400B649 RID: 46665
		[Token(Token = "0x400B649")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0400B64A RID: 46666
		[Token(Token = "0x400B64A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B64B RID: 46667
		[Token(Token = "0x400B64B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B64C RID: 46668
		[Token(Token = "0x400B64C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdatePlayerView;

		// Token: 0x0400B64D RID: 46669
		[Token(Token = "0x400B64D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateVisitorView;

		// Token: 0x0400B64E RID: 46670
		[Token(Token = "0x400B64E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateRoomName;

		// Token: 0x0400B64F RID: 46671
		[Token(Token = "0x400B64F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
