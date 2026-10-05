using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001424 RID: 5156
	[Token(Token = "0x2001424")]
	public class GetRewardMedalRequest
	{
		// Token: 0x060076E5 RID: 30437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetRewardMedalRequest()
		{
		}

		// Token: 0x04007453 RID: 29779
		[Token(Token = "0x4007453")]
		[FieldOffset(Offset = "0x10")]
		public string medalId;

		// Token: 0x04007454 RID: 29780
		[Token(Token = "0x4007454")]
		[FieldOffset(Offset = "0x18")]
		public string group;
	}
}
