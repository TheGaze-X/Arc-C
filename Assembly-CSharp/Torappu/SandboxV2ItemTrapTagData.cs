using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200129A RID: 4762
	[Token(Token = "0x200129A")]
	public class SandboxV2ItemTrapTagData
	{
		// Token: 0x06007213 RID: 29203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007213")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ItemTrapTagData()
		{
		}

		// Token: 0x040068F9 RID: 26873
		[Token(Token = "0x40068F9")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2ItemTrapTag tag;

		// Token: 0x040068FA RID: 26874
		[Token(Token = "0x40068FA")]
		[FieldOffset(Offset = "0x18")]
		public string tagName;

		// Token: 0x040068FB RID: 26875
		[Token(Token = "0x40068FB")]
		[FieldOffset(Offset = "0x20")]
		public string tagPic;

		// Token: 0x040068FC RID: 26876
		[Token(Token = "0x40068FC")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;
	}
}
