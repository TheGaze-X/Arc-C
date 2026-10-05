using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043CF RID: 17359
	[Token(Token = "0x20043CF")]
	public class SandboxV2ShopBuyRequest
	{
		// Token: 0x0601A97A RID: 108922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A97A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ShopBuyRequest()
		{
		}

		// Token: 0x04021E5A RID: 138842
		[Token(Token = "0x4021E5A")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E5B RID: 138843
		[Token(Token = "0x4021E5B")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		// Token: 0x04021E5C RID: 138844
		[Token(Token = "0x4021E5C")]
		[FieldOffset(Offset = "0x1C")]
		public int count;
	}
}
