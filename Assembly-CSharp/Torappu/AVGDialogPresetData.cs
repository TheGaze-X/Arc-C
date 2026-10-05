using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FE7 RID: 4071
	[Token(Token = "0x2000FE7")]
	public class AVGDialogPresetData
	{
		// Token: 0x06006D3E RID: 27966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AVGDialogPresetData()
		{
		}

		// Token: 0x0400564C RID: 22092
		[Token(Token = "0x400564C")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x0400564D RID: 22093
		[Token(Token = "0x400564D")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400564E RID: 22094
		[Token(Token = "0x400564E")]
		[FieldOffset(Offset = "0x20")]
		public int nameFontSize;

		// Token: 0x0400564F RID: 22095
		[Token(Token = "0x400564F")]
		[FieldOffset(Offset = "0x24")]
		public int messageFontSize;

		// Token: 0x04005650 RID: 22096
		[Token(Token = "0x4005650")]
		[FieldOffset(Offset = "0x28")]
		public float messageMinHeight;
	}
}
