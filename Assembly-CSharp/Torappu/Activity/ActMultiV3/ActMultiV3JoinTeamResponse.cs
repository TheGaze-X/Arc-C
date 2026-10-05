using System;
using Il2CppDummyDll;
using Torappu.Multiplayer;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EC3 RID: 28355
	[Token(Token = "0x2006EC3")]
	public class ActMultiV3JoinTeamResponse : PlayerDeltaResponse
	{
		// Token: 0x0602853B RID: 165179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602853B")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActMultiV3JoinTeamResponse()
		{
		}

		// Token: 0x0403950D RID: 234765
		[Token(Token = "0x403950D")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x0403950E RID: 234766
		[Token(Token = "0x403950E")]
		[FieldOffset(Offset = "0x30")]
		public TeamInst team;

		// Token: 0x02006EC4 RID: 28356
		[Token(Token = "0x2006EC4")]
		public enum JoinResultType
		{
			// Token: 0x04039510 RID: 234768
			[Token(Token = "0x4039510")]
			OK,
			// Token: 0x04039511 RID: 234769
			[Token(Token = "0x4039511")]
			TOO_FAST,
			// Token: 0x04039512 RID: 234770
			[Token(Token = "0x4039512")]
			BAN,
			// Token: 0x04039513 RID: 234771
			[Token(Token = "0x4039513")]
			ROOM_NOT_EXIST,
			// Token: 0x04039514 RID: 234772
			[Token(Token = "0x4039514")]
			ROOM_IS_FULL
		}
	}
}
