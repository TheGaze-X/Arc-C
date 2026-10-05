using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C8E RID: 7310
	[Token(Token = "0x2001C8E")]
	public class BuildingStationSelectConfirmRoomItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x0600B581 RID: 46465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D5")]
		public BuildingCharSelectRoomConfig roomConfig
		{
			[Token(Token = "0x600B581")]
			[Address(RVA = "0x33105A0", Offset = "0x330F1A0", VA = "0x1833105A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B582 RID: 46466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B582")]
		[Address(RVA = "0x330F2C0", Offset = "0x330DEC0", VA = "0x18330F2C0")]
		public void Render(ChangedRoomViewModel changedModel, bool isCur = false)
		{
		}

		// Token: 0x0600B583 RID: 46467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B583")]
		[Address(RVA = "0x330FEC0", Offset = "0x330EAC0", VA = "0x18330FEC0")]
		private void _ProcessStationChangedChars(List<ChangedRoomViewModel.StationedCharChangedModel> changedChars)
		{
		}

		// Token: 0x0600B584 RID: 46468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B584")]
		[Address(RVA = "0x330F930", Offset = "0x330E530", VA = "0x18330F930")]
		private void _ProcessAssistChangedChars(List<ChangedRoomViewModel.StationedCharChangedModel> changedChars)
		{
		}

		// Token: 0x0600B585 RID: 46469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B585")]
		[Address(RVA = "0x3310540", Offset = "0x330F140", VA = "0x183310540")]
		public BuildingStationSelectConfirmRoomItemView()
		{
		}

		// Token: 0x0400B1D9 RID: 45529
		[Token(Token = "0x400B1D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textRoomCode;

		// Token: 0x0400B1DA RID: 45530
		[Token(Token = "0x400B1DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textRoomIndex;

		// Token: 0x0400B1DB RID: 45531
		[Token(Token = "0x400B1DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageRoomBkg;

		// Token: 0x0400B1DC RID: 45532
		[Token(Token = "0x400B1DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageRoomDeco;

		// Token: 0x0400B1DD RID: 45533
		[Token(Token = "0x400B1DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageRoomIcon;

		// Token: 0x0400B1DE RID: 45534
		[Token(Token = "0x400B1DE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _roomTargetHolder;

		// Token: 0x0400B1DF RID: 45535
		[Token(Token = "0x400B1DF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textRoomTarget;

		// Token: 0x0400B1E0 RID: 45536
		[Token(Token = "0x400B1E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _iconRoomStop;

		// Token: 0x0400B1E1 RID: 45537
		[Token(Token = "0x400B1E1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objCur;

		// Token: 0x0400B1E2 RID: 45538
		[Token(Token = "0x400B1E2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BuildingStationSelectConfirmRoomCharCardAdapter _charAdapter;

		// Token: 0x0400B1E3 RID: 45539
		[Token(Token = "0x400B1E3")]
		[FieldOffset(Offset = "0x68")]
		private List<ChangedCharCardViewModel> m_charViewModels;

		// Token: 0x0400B1E4 RID: 45540
		[Token(Token = "0x400B1E4")]
		[FieldOffset(Offset = "0x70")]
		private RoomSlotModel m_currentRoomSlot;

		// Token: 0x0400B1E5 RID: 45541
		[Token(Token = "0x400B1E5")]
		[FieldOffset(Offset = "0x78")]
		private ChangedRoomViewModel m_cachedRoomModel;

		// Token: 0x0400B1E6 RID: 45542
		[Token(Token = "0x400B1E6")]
		[FieldOffset(Offset = "0x80")]
		private SpriteHub m_profHub;

		// Token: 0x0400B1E7 RID: 45543
		[Token(Token = "0x400B1E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roomConfig;

		// Token: 0x0400B1E8 RID: 45544
		[Token(Token = "0x400B1E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B1E9 RID: 45545
		[Token(Token = "0x400B1E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ProcessStationChangedChars;

		// Token: 0x0400B1EA RID: 45546
		[Token(Token = "0x400B1EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ProcessAssistChangedChars;

		// Token: 0x0400B1EB RID: 45547
		[Token(Token = "0x400B1EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
