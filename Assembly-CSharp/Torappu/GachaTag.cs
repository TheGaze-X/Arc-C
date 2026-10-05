using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200105B RID: 4187
	[Token(Token = "0x200105B")]
	[Serializable]
	public class GachaTag
	{
		// Token: 0x06006DE2 RID: 28130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GachaTag()
		{
		}

		// Token: 0x04005914 RID: 22804
		[Token(Token = "0x4005914")]
		[FieldOffset(Offset = "0x10")]
		public int tagId;

		// Token: 0x04005915 RID: 22805
		[Token(Token = "0x4005915")]
		[FieldOffset(Offset = "0x18")]
		public string tagName;

		// Token: 0x04005916 RID: 22806
		[Token(Token = "0x4005916")]
		[FieldOffset(Offset = "0x20")]
		public int tagGroup;
	}
}
