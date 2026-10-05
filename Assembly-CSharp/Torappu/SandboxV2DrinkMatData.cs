using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012A2 RID: 4770
	[Token(Token = "0x20012A2")]
	public class SandboxV2DrinkMatData
	{
		// Token: 0x0600721A RID: 29210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600721A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2DrinkMatData()
		{
		}

		// Token: 0x0400691C RID: 26908
		[Token(Token = "0x400691C")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400691D RID: 26909
		[Token(Token = "0x400691D")]
		[FieldOffset(Offset = "0x18")]
		public SandboxPermItemType type;

		// Token: 0x0400691E RID: 26910
		[Token(Token = "0x400691E")]
		[FieldOffset(Offset = "0x1C")]
		public int count;
	}
}
