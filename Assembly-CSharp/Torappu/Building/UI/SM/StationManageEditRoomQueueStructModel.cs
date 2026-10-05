using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001C9E RID: 7326
	[Token(Token = "0x2001C9E")]
	public struct StationManageEditRoomQueueStructModel
	{
		// Token: 0x0400B24B RID: 45643
		[Token(Token = "0x400B24B")]
		[FieldOffset(Offset = "0x0")]
		public string slotId;

		// Token: 0x0400B24C RID: 45644
		[Token(Token = "0x400B24C")]
		[FieldOffset(Offset = "0x8")]
		public StationCharStructModel[] buildingCharModels;

		// Token: 0x0400B24D RID: 45645
		[Token(Token = "0x400B24D")]
		[FieldOffset(Offset = "0x10")]
		public bool isQueueAvailable;

		// Token: 0x0400B24E RID: 45646
		[Token(Token = "0x400B24E")]
		[FieldOffset(Offset = "0x11")]
		public bool isUpdateByMsg;

		// Token: 0x0400B24F RID: 45647
		[Token(Token = "0x400B24F")]
		[FieldOffset(Offset = "0x18")]
		public Sprite bkg;
	}
}
