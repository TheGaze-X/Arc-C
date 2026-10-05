using System;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004BA8 RID: 19368
	[Token(Token = "0x2004BA8")]
	public struct HomeMailIndex
	{
		// Token: 0x0402637E RID: 156542
		[Token(Token = "0x402637E")]
		[FieldOffset(Offset = "0x0")]
		public long index;

		// Token: 0x0402637F RID: 156543
		[Token(Token = "0x402637F")]
		[FieldOffset(Offset = "0x8")]
		public string surveyId;

		// Token: 0x04026380 RID: 156544
		[Token(Token = "0x4026380")]
		[FieldOffset(Offset = "0x10")]
		public MailFromInfo fromType;
	}
}
