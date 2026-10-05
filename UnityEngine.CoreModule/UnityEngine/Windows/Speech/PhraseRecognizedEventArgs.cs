using System;
using Il2CppDummyDll;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public struct PhraseRecognizedEventArgs
	{
		// Token: 0x06000C3C RID: 3132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x59654F0", Offset = "0x59640F0", VA = "0x1859654F0")]
		internal PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration)
		{
		}

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x0")]
		public readonly ConfidenceLevel confidence;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x8")]
		public readonly SemanticMeaning[] semanticMeanings;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x10")]
		public readonly string text;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x18")]
		public readonly DateTime phraseStartTime;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x20")]
		public readonly TimeSpan phraseDuration;
	}
}
