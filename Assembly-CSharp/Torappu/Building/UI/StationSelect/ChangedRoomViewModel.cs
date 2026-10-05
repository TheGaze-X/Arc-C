using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C5E RID: 7262
	[Token(Token = "0x2001C5E")]
	public class ChangedRoomViewModel
	{
		// Token: 0x0600B493 RID: 46227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B493")]
		[Address(RVA = "0x5A4AB0", Offset = "0x5A36B0", VA = "0x1805A4AB0")]
		public ChangedRoomViewModel()
		{
		}

		// Token: 0x0400B068 RID: 45160
		[Token(Token = "0x400B068")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x0400B069 RID: 45161
		[Token(Token = "0x400B069")]
		[FieldOffset(Offset = "0x18")]
		public int assistType;

		// Token: 0x0400B06A RID: 45162
		[Token(Token = "0x400B06A")]
		[FieldOffset(Offset = "0x1C")]
		public bool asssitRoom;

		// Token: 0x0400B06B RID: 45163
		[Token(Token = "0x400B06B")]
		[FieldOffset(Offset = "0x20")]
		public List<ChangedRoomViewModel.StationedCharChangedModel> charChanges;

		// Token: 0x02001C5F RID: 7263
		[Token(Token = "0x2001C5F")]
		public struct StationedCharChangedModel
		{
			// Token: 0x170015B1 RID: 5553
			// (get) Token: 0x0600B494 RID: 46228 RVA: 0x00044730 File Offset: 0x00042930
			[Token(Token = "0x170015B1")]
			public bool isEmpty
			{
				[Token(Token = "0x600B494")]
				[Address(RVA = "0x33013E0", Offset = "0x32FFFE0", VA = "0x1833013E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0400B06C RID: 45164
			[Token(Token = "0x400B06C")]
			[FieldOffset(Offset = "0x0")]
			public int instId;

			// Token: 0x0400B06D RID: 45165
			[Token(Token = "0x400B06D")]
			[FieldOffset(Offset = "0x4")]
			public ChangedRoomViewModel.StationedCharChangeStatus changeStatus;
		}

		// Token: 0x02001C60 RID: 7264
		[Token(Token = "0x2001C60")]
		public enum StationedCharChangeStatus
		{
			// Token: 0x0400B06F RID: 45167
			[Token(Token = "0x400B06F")]
			None,
			// Token: 0x0400B070 RID: 45168
			[Token(Token = "0x400B070")]
			OnWork,
			// Token: 0x0400B071 RID: 45169
			[Token(Token = "0x400B071")]
			OffWork
		}
	}
}
