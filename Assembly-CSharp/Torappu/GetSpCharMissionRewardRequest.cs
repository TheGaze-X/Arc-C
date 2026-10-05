using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006C3 RID: 1731
	[Token(Token = "0x20006C3")]
	public class GetSpCharMissionRewardRequest
	{
		// Token: 0x0600630C RID: 25356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetSpCharMissionRewardRequest()
		{
		}

		// Token: 0x04002EB3 RID: 11955
		[Token(Token = "0x4002EB3")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04002EB4 RID: 11956
		[Token(Token = "0x4002EB4")]
		[FieldOffset(Offset = "0x18")]
		public string missionId;
	}
}
