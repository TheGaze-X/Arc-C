using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x02001802 RID: 6146
	[Token(Token = "0x2001802")]
	public struct RoomConditionCheckOptions
	{
		// Token: 0x06009B74 RID: 39796 RVA: 0x0003C810 File Offset: 0x0003AA10
		[Token(Token = "0x6009B74")]
		[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x040091FF RID: 37375
		[Token(Token = "0x40091FF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RoomConditionCheckOptions EMPTY;

		// Token: 0x04009200 RID: 37376
		[Token(Token = "0x4009200")]
		[FieldOffset(Offset = "0x0")]
		public string slotId;

		// Token: 0x04009201 RID: 37377
		[Token(Token = "0x4009201")]
		[FieldOffset(Offset = "0x8")]
		public int predictLevel;

		// Token: 0x04009202 RID: 37378
		[Token(Token = "0x4009202")]
		[FieldOffset(Offset = "0xC")]
		public BuildingData.RoomType predictRoomId;
	}
}
