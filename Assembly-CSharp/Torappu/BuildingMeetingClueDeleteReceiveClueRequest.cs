using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200066C RID: 1644
	[Token(Token = "0x200066C")]
	public class BuildingMeetingClueDeleteReceiveClueRequest : BuildingRequest
	{
		// Token: 0x0600629A RID: 25242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingMeetingClueDeleteReceiveClueRequest()
		{
		}

		// Token: 0x04002E2A RID: 11818
		[Token(Token = "0x4002E2A")]
		[FieldOffset(Offset = "0x10")]
		public string clueId;
	}
}
