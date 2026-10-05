using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010AE RID: 4270
	[Token(Token = "0x20010AE")]
	[Serializable]
	public class FullPotentialCharacterInfo
	{
		// Token: 0x06006E38 RID: 28216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E38")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FullPotentialCharacterInfo()
		{
		}

		// Token: 0x04005B7A RID: 23418
		[Token(Token = "0x4005B7A")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04005B7B RID: 23419
		[Token(Token = "0x4005B7B")]
		[FieldOffset(Offset = "0x18")]
		public long ts;
	}
}
