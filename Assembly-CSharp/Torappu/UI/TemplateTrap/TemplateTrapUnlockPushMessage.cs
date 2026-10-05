using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D2B RID: 15659
	[Token(Token = "0x2003D2B")]
	public struct TemplateTrapUnlockPushMessage
	{
		// Token: 0x0401DDB9 RID: 122297
		[Token(Token = "0x401DDB9")]
		[FieldOffset(Offset = "0x0")]
		public string domainId;

		// Token: 0x0401DDBA RID: 122298
		[Token(Token = "0x401DDBA")]
		[FieldOffset(Offset = "0x8")]
		public string trapId;

		// Token: 0x0401DDBB RID: 122299
		[Token(Token = "0x401DDBB")]
		[FieldOffset(Offset = "0x10")]
		public bool isFirst;
	}
}
