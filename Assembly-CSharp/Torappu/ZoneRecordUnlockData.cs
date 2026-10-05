using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013CC RID: 5068
	[Token(Token = "0x20013CC")]
	[Serializable]
	public class ZoneRecordUnlockData
	{
		// Token: 0x060073BC RID: 29628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZoneRecordUnlockData()
		{
		}

		// Token: 0x040070B5 RID: 28853
		[Token(Token = "0x40070B5")]
		[FieldOffset(Offset = "0x10")]
		public string noteId;

		// Token: 0x040070B6 RID: 28854
		[Token(Token = "0x40070B6")]
		[FieldOffset(Offset = "0x18")]
		public string zoneId;

		// Token: 0x040070B7 RID: 28855
		[Token(Token = "0x40070B7")]
		[FieldOffset(Offset = "0x20")]
		public string initialName;

		// Token: 0x040070B8 RID: 28856
		[Token(Token = "0x40070B8")]
		[FieldOffset(Offset = "0x28")]
		public string finalName;

		// Token: 0x040070B9 RID: 28857
		[Token(Token = "0x40070B9")]
		[FieldOffset(Offset = "0x30")]
		public string accordingExposeId;

		// Token: 0x040070BA RID: 28858
		[Token(Token = "0x40070BA")]
		[FieldOffset(Offset = "0x38")]
		public string initialDes;

		// Token: 0x040070BB RID: 28859
		[Token(Token = "0x40070BB")]
		[FieldOffset(Offset = "0x40")]
		public string finalDes;

		// Token: 0x040070BC RID: 28860
		[Token(Token = "0x40070BC")]
		[FieldOffset(Offset = "0x48")]
		public string remindDes;
	}
}
