using System;
using Il2CppDummyDll;
using Torappu.Multiplayer;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EC0 RID: 28352
	[Token(Token = "0x2006EC0")]
	public class ActMultiV3CreateTeamResponse : PlayerDeltaResponse
	{
		// Token: 0x06028539 RID: 165177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028539")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActMultiV3CreateTeamResponse()
		{
		}

		// Token: 0x04039504 RID: 234756
		[Token(Token = "0x4039504")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x04039505 RID: 234757
		[Token(Token = "0x4039505")]
		[FieldOffset(Offset = "0x30")]
		public TeamInst team;

		// Token: 0x02006EC1 RID: 28353
		[Token(Token = "0x2006EC1")]
		public enum CreateResultType
		{
			// Token: 0x04039507 RID: 234759
			[Token(Token = "0x4039507")]
			OK,
			// Token: 0x04039508 RID: 234760
			[Token(Token = "0x4039508")]
			TOO_FAST,
			// Token: 0x04039509 RID: 234761
			[Token(Token = "0x4039509")]
			BAN,
			// Token: 0x0403950A RID: 234762
			[Token(Token = "0x403950A")]
			SERVER_OVERLOAD
		}
	}
}
