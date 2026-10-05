using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200114D RID: 4429
	[Token(Token = "0x200114D")]
	public class ReturnNewsData
	{
		// Token: 0x06006F28 RID: 28456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F28")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ReturnNewsData()
		{
		}

		// Token: 0x04005EEE RID: 24302
		[Token(Token = "0x4005EEE")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005EEF RID: 24303
		[Token(Token = "0x4005EEF")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005EF0 RID: 24304
		[Token(Token = "0x4005EF0")]
		[FieldOffset(Offset = "0x20")]
		public string tabTitle;

		// Token: 0x04005EF1 RID: 24305
		[Token(Token = "0x4005EF1")]
		[FieldOffset(Offset = "0x28")]
		public string tabIcon;

		// Token: 0x04005EF2 RID: 24306
		[Token(Token = "0x4005EF2")]
		[FieldOffset(Offset = "0x30")]
		public string title;

		// Token: 0x04005EF3 RID: 24307
		[Token(Token = "0x4005EF3")]
		[FieldOffset(Offset = "0x38")]
		public string desc;

		// Token: 0x04005EF4 RID: 24308
		[Token(Token = "0x4005EF4")]
		[FieldOffset(Offset = "0x40")]
		public string imgId;

		// Token: 0x04005EF5 RID: 24309
		[Token(Token = "0x4005EF5")]
		[FieldOffset(Offset = "0x48")]
		public string iconId;

		// Token: 0x04005EF6 RID: 24310
		[Token(Token = "0x4005EF6")]
		[FieldOffset(Offset = "0x50")]
		public ReturnNewsType jumpType;

		// Token: 0x04005EF7 RID: 24311
		[Token(Token = "0x4005EF7")]
		[FieldOffset(Offset = "0x58")]
		public string jumpPlace;
	}
}
