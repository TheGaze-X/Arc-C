using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C2A RID: 3114
	[Token(Token = "0x2000C2A")]
	public class ActArchiveChatItemData : IComparable
	{
		// Token: 0x06006909 RID: 26889 RVA: 0x00030BB8 File Offset: 0x0002EDB8
		[Token(Token = "0x6006909")]
		[Address(RVA = "0x1FF8670", Offset = "0x1FF7270", VA = "0x181FF8670", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveChatItemData()
		{
		}

		// Token: 0x04003FB4 RID: 16308
		[Token(Token = "0x4003FB4")]
		[FieldOffset(Offset = "0x10")]
		public int floor;

		// Token: 0x04003FB5 RID: 16309
		[Token(Token = "0x4003FB5")]
		[FieldOffset(Offset = "0x18")]
		public string chatZoneId;

		// Token: 0x04003FB6 RID: 16310
		[Token(Token = "0x4003FB6")]
		[FieldOffset(Offset = "0x20")]
		public string chatDesc;

		// Token: 0x04003FB7 RID: 16311
		[Token(Token = "0x4003FB7")]
		[FieldOffset(Offset = "0x28")]
		public string chatStoryId;
	}
}
