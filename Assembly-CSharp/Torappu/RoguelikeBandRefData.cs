using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001228 RID: 4648
	[Token(Token = "0x2001228")]
	public class RoguelikeBandRefData
	{
		// Token: 0x06007028 RID: 28712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007028")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeBandRefData()
		{
		}

		// Token: 0x04006464 RID: 25700
		[Token(Token = "0x4006464")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04006465 RID: 25701
		[Token(Token = "0x4006465")]
		[FieldOffset(Offset = "0x18")]
		public int bandLevel;

		// Token: 0x04006466 RID: 25702
		[Token(Token = "0x4006466")]
		[FieldOffset(Offset = "0x20")]
		public string normalBandId;
	}
}
