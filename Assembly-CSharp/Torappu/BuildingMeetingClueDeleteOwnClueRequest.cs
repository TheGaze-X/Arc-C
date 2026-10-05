using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200066A RID: 1642
	[Token(Token = "0x200066A")]
	public class BuildingMeetingClueDeleteOwnClueRequest : BuildingRequest
	{
		// Token: 0x06006298 RID: 25240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006298")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingMeetingClueDeleteOwnClueRequest()
		{
		}

		// Token: 0x04002E29 RID: 11817
		[Token(Token = "0x4002E29")]
		[FieldOffset(Offset = "0x10")]
		public string clueId;
	}
}
