using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C61 RID: 7265
	[Token(Token = "0x2001C61")]
	public class ChangedRoomGroupViewModel
	{
		// Token: 0x0600B495 RID: 46229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B495")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangedRoomGroupViewModel()
		{
		}

		// Token: 0x0400B072 RID: 45170
		[Token(Token = "0x400B072")]
		[FieldOffset(Offset = "0x10")]
		public ChangedRoomGroupViewModel.ChangedRoomGroupType changeType;

		// Token: 0x0400B073 RID: 45171
		[Token(Token = "0x400B073")]
		[FieldOffset(Offset = "0x18")]
		public List<ChangedRoomViewModel> assistants;

		// Token: 0x0400B074 RID: 45172
		[Token(Token = "0x400B074")]
		[FieldOffset(Offset = "0x20")]
		public List<ChangedRoomViewModel> stations;

		// Token: 0x0400B075 RID: 45173
		[Token(Token = "0x400B075")]
		[FieldOffset(Offset = "0x28")]
		public List<ChangedRoomViewModel> allRooms;

		// Token: 0x02001C62 RID: 7266
		[Token(Token = "0x2001C62")]
		public enum ChangedRoomGroupType
		{
			// Token: 0x0400B077 RID: 45175
			[Token(Token = "0x400B077")]
			Current,
			// Token: 0x0400B078 RID: 45176
			[Token(Token = "0x400B078")]
			Passive
		}
	}
}
