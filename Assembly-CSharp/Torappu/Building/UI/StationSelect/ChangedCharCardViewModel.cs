using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C63 RID: 7267
	[Token(Token = "0x2001C63")]
	public class ChangedCharCardViewModel
	{
		// Token: 0x0600B496 RID: 46230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B496")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangedCharCardViewModel()
		{
		}

		// Token: 0x0400B079 RID: 45177
		[Token(Token = "0x400B079")]
		[FieldOffset(Offset = "0x10")]
		public StationCharViewModel stationCharModel;

		// Token: 0x0400B07A RID: 45178
		[Token(Token = "0x400B07A")]
		[FieldOffset(Offset = "0x18")]
		public ChangedRoomViewModel.StationedCharChangeStatus status;

		// Token: 0x0400B07B RID: 45179
		[Token(Token = "0x400B07B")]
		[FieldOffset(Offset = "0x1C")]
		public bool isAssist;

		// Token: 0x0400B07C RID: 45180
		[Token(Token = "0x400B07C")]
		[FieldOffset(Offset = "0x1D")]
		public bool isEmpty;

		// Token: 0x0400B07D RID: 45181
		[Token(Token = "0x400B07D")]
		[FieldOffset(Offset = "0x20")]
		public int assistIdx;
	}
}
