using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000756 RID: 1878
	[Token(Token = "0x2000756")]
	public class AdvancedGachaRequest
	{
		// Token: 0x060063C0 RID: 25536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AdvancedGachaRequest()
		{
		}

		// Token: 0x04002FCD RID: 12237
		[Token(Token = "0x4002FCD")]
		[FieldOffset(Offset = "0x10")]
		public string poolId;

		// Token: 0x04002FCE RID: 12238
		[Token(Token = "0x4002FCE")]
		[FieldOffset(Offset = "0x18")]
		public GachaType useTkt;

		// Token: 0x04002FCF RID: 12239
		[Token(Token = "0x4002FCF")]
		[FieldOffset(Offset = "0x20")]
		public string itemId;
	}
}
