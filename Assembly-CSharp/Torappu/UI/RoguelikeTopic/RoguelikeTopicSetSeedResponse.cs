using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004558 RID: 17752
	[Token(Token = "0x2004558")]
	public class RoguelikeTopicSetSeedResponse : PlayerDeltaResponse
	{
		// Token: 0x0601B0B0 RID: 110768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0B0")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RoguelikeTopicSetSeedResponse()
		{
		}

		// Token: 0x04022BFD RID: 142333
		[Token(Token = "0x4022BFD")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeTopicSetSeedResponse.ResultCode result;

		// Token: 0x02004559 RID: 17753
		[Token(Token = "0x2004559")]
		public enum ResultCode
		{
			// Token: 0x04022BFF RID: 142335
			[Token(Token = "0x4022BFF")]
			SUCCESS,
			// Token: 0x04022C00 RID: 142336
			[Token(Token = "0x4022C00")]
			INVALID_LENGTH,
			// Token: 0x04022C01 RID: 142337
			[Token(Token = "0x4022C01")]
			INVALID_CHARSET,
			// Token: 0x04022C02 RID: 142338
			[Token(Token = "0x4022C02")]
			SENSITIVE_WORD,
			// Token: 0x04022C03 RID: 142339
			[Token(Token = "0x4022C03")]
			FUNCTION_CLOSE,
			// Token: 0x04022C04 RID: 142340
			[Token(Token = "0x4022C04")]
			USER_BANNED,
			// Token: 0x04022C05 RID: 142341
			[Token(Token = "0x4022C05")]
			FAIL
		}
	}
}
