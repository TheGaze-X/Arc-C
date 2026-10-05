using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F50 RID: 3920
	[Token(Token = "0x2000F50")]
	[Serializable]
	public class CGGalleryCGCompositeData
	{
		// Token: 0x06006C5E RID: 27742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C5E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CGGalleryCGCompositeData()
		{
		}

		// Token: 0x0400535A RID: 21338
		[Token(Token = "0x400535A")]
		[FieldOffset(Offset = "0x10")]
		public string cgId;

		// Token: 0x0400535B RID: 21339
		[Token(Token = "0x400535B")]
		[FieldOffset(Offset = "0x18")]
		public int width;

		// Token: 0x0400535C RID: 21340
		[Token(Token = "0x400535C")]
		[FieldOffset(Offset = "0x1C")]
		public int height;
	}
}
