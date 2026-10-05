using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010BB RID: 4283
	[Token(Token = "0x20010BB")]
	[Serializable]
	public class ApSupplyFeature
	{
		// Token: 0x06006E54 RID: 28244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E54")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ApSupplyFeature()
		{
		}

		// Token: 0x04005BAA RID: 23466
		[Token(Token = "0x4005BAA")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005BAB RID: 23467
		[Token(Token = "0x4005BAB")]
		[FieldOffset(Offset = "0x18")]
		public int ap;

		// Token: 0x04005BAC RID: 23468
		[Token(Token = "0x4005BAC")]
		[FieldOffset(Offset = "0x1C")]
		public bool hasTs;
	}
}
