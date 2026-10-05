using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006AB RID: 1707
	[Token(Token = "0x20006AB")]
	public class BuildingChangeBGMRequest : BuildingRequest
	{
		// Token: 0x060062E7 RID: 25319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingChangeBGMRequest()
		{
		}

		// Token: 0x04002E93 RID: 11923
		[Token(Token = "0x4002E93")]
		[FieldOffset(Offset = "0x10")]
		public string musicId;
	}
}
