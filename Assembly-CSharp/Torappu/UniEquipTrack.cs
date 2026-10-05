using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013B4 RID: 5044
	[Token(Token = "0x20013B4")]
	public class UniEquipTrack
	{
		// Token: 0x0600739F RID: 29599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UniEquipTrack()
		{
		}

		// Token: 0x04007010 RID: 28688
		[Token(Token = "0x4007010")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04007011 RID: 28689
		[Token(Token = "0x4007011")]
		[FieldOffset(Offset = "0x18")]
		public string equipId;

		// Token: 0x04007012 RID: 28690
		[Token(Token = "0x4007012")]
		[FieldOffset(Offset = "0x20")]
		public UniEquipType type;

		// Token: 0x04007013 RID: 28691
		[Token(Token = "0x4007013")]
		[FieldOffset(Offset = "0x28")]
		public long archiveShowTimeEnd;
	}
}
