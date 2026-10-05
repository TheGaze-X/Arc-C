using System;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200665B RID: 26203
	[Token(Token = "0x200665B")]
	[Serializable]
	public class HandbookCardData
	{
		// Token: 0x06025A1C RID: 154140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A1C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandbookCardData()
		{
		}

		// Token: 0x04034DCE RID: 216526
		[Token(Token = "0x4034DCE")]
		[FieldOffset(Offset = "0x10")]
		public string charID;

		// Token: 0x04034DCF RID: 216527
		[Token(Token = "0x4034DCF")]
		[FieldOffset(Offset = "0x18")]
		public float xPos;

		// Token: 0x04034DD0 RID: 216528
		[Token(Token = "0x4034DD0")]
		[FieldOffset(Offset = "0x1C")]
		public float yPos;

		// Token: 0x04034DD1 RID: 216529
		[Token(Token = "0x4034DD1")]
		[FieldOffset(Offset = "0x20")]
		public int sixPosX;

		// Token: 0x04034DD2 RID: 216530
		[Token(Token = "0x4034DD2")]
		[FieldOffset(Offset = "0x24")]
		public int sixPosY;

		// Token: 0x04034DD3 RID: 216531
		[Token(Token = "0x4034DD3")]
		[FieldOffset(Offset = "0x28")]
		public float lvl;

		// Token: 0x04034DD4 RID: 216532
		[Token(Token = "0x4034DD4")]
		[FieldOffset(Offset = "0x30")]
		public string powerId;

		// Token: 0x04034DD5 RID: 216533
		[Token(Token = "0x4034DD5")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x04034DD6 RID: 216534
		[Token(Token = "0x4034DD6")]
		[FieldOffset(Offset = "0x40")]
		public string cardID;
	}
}
