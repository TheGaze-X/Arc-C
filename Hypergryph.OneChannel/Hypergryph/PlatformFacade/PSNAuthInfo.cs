using System;
using Il2CppDummyDll;

namespace Hypergryph.PlatformFacade
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	public struct PSNAuthInfo
	{
		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x0")]
		public PSNAuthResultStatus status;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x8")]
		public string psnAuthCode;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x10")]
		public string psnEnv;
	}
}
