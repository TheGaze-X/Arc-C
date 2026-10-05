using System;
using Il2CppDummyDll;

namespace Torappu.SDK
{
	// Token: 0x020014FE RID: 5374
	[Token(Token = "0x20014FE")]
	[Serializable]
	public class TrackingioOptions
	{
		// Token: 0x06007BA4 RID: 31652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BA4")]
		[Address(RVA = "0x2748640", Offset = "0x2747240", VA = "0x182748640")]
		public string GetAppId()
		{
			return null;
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA5")]
		[Address(RVA = "0x2748680", Offset = "0x2747280", VA = "0x182748680")]
		public TrackingioOptions()
		{
		}

		// Token: 0x04007A12 RID: 31250
		[Token(Token = "0x4007A12")]
		[FieldOffset(Offset = "0x10")]
		public string iosAppId;

		// Token: 0x04007A13 RID: 31251
		[Token(Token = "0x4007A13")]
		[FieldOffset(Offset = "0x18")]
		public string androidAppId;
	}
}
