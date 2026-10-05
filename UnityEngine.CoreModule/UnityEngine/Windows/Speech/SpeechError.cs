using System;
using Il2CppDummyDll;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	public enum SpeechError
	{
		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		NoError,
		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		TopicLanguageNotSupported,
		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		GrammarLanguageMismatch,
		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		GrammarCompilationFailure,
		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		AudioQualityFailure,
		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		PauseLimitExceeded,
		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		TimeoutExceeded,
		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		NetworkFailure,
		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		MicrophoneUnavailable,
		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		UnknownError
	}
}
