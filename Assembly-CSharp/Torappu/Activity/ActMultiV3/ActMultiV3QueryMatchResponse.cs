using System;
using Il2CppDummyDll;
using Torappu.Multiplayer;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EE3 RID: 28387
	[Token(Token = "0x2006EE3")]
	public class ActMultiV3QueryMatchResponse : PlayerDeltaResponse
	{
		// Token: 0x0602856A RID: 165226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602856A")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActMultiV3QueryMatchResponse()
		{
		}

		// Token: 0x04039567 RID: 234855
		[Token(Token = "0x4039567")]
		[FieldOffset(Offset = "0x28")]
		public ActMultiV3QueryMatchResponse.QueryMatchResultType result;

		// Token: 0x04039568 RID: 234856
		[Token(Token = "0x4039568")]
		[FieldOffset(Offset = "0x30")]
		public TeamInst team;

		// Token: 0x02006EE4 RID: 28388
		[Token(Token = "0x2006EE4")]
		public enum QueryMatchResultType
		{
			// Token: 0x0403956A RID: 234858
			[Token(Token = "0x403956A")]
			OK,
			// Token: 0x0403956B RID: 234859
			[Token(Token = "0x403956B")]
			CANCEL,
			// Token: 0x0403956C RID: 234860
			[Token(Token = "0x403956C")]
			TIME_OUT
		}
	}
}
