using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public enum EVoiceResult
	{
		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		k_EVoiceResultOK,
		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		k_EVoiceResultNotInitialized,
		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		k_EVoiceResultNotRecording,
		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		k_EVoiceResultNoData,
		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		k_EVoiceResultBufferTooSmall,
		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		k_EVoiceResultDataCorrupted,
		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		k_EVoiceResultRestricted,
		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		k_EVoiceResultUnsupportedCodec,
		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		k_EVoiceResultReceiverOutOfDate,
		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		k_EVoiceResultReceiverDidNotAnswer
	}
}
