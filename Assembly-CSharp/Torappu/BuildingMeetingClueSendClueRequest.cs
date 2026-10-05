using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000672 RID: 1650
	[Token(Token = "0x2000672")]
	public class BuildingMeetingClueSendClueRequest : BuildingRequest
	{
		// Token: 0x060062A0 RID: 25248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingMeetingClueSendClueRequest()
		{
		}

		// Token: 0x04002E2D RID: 11821
		[Token(Token = "0x4002E2D")]
		[FieldOffset(Offset = "0x10")]
		public string friendId;

		// Token: 0x04002E2E RID: 11822
		[Token(Token = "0x4002E2E")]
		[FieldOffset(Offset = "0x18")]
		public string clueId;
	}
}
