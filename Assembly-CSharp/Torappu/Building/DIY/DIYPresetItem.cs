using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x0200184E RID: 6222
	[Token(Token = "0x200184E")]
	public struct DIYPresetItem
	{
		// Token: 0x06009D59 RID: 40281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D59")]
		[Address(RVA = "0x317D1A0", Offset = "0x317BDA0", VA = "0x18317D1A0")]
		public DIYPresetItem(string id, int pos0, int pos1, int dir)
		{
		}

		// Token: 0x04009410 RID: 37904
		[Token(Token = "0x4009410")]
		[FieldOffset(Offset = "0x0")]
		public string id;

		// Token: 0x04009411 RID: 37905
		[Token(Token = "0x4009411")]
		[FieldOffset(Offset = "0x8")]
		public int pos0;

		// Token: 0x04009412 RID: 37906
		[Token(Token = "0x4009412")]
		[FieldOffset(Offset = "0xC")]
		public int pos1;

		// Token: 0x04009413 RID: 37907
		[Token(Token = "0x4009413")]
		[FieldOffset(Offset = "0x10")]
		public int dir;
	}
}
