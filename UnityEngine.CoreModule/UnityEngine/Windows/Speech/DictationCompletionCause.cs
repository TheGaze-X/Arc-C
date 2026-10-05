using System;
using Il2CppDummyDll;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	public enum DictationCompletionCause
	{
		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		Complete,
		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		AudioQualityFailure,
		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		Canceled,
		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		TimeoutExceeded,
		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		PauseLimitExceeded,
		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		NetworkFailure,
		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		MicrophoneUnavailable,
		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		UnknownError
	}
}
