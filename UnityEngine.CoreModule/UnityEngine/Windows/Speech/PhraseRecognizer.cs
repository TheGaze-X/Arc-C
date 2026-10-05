using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	public abstract class PhraseRecognizer
	{
		// Token: 0x06000C2C RID: 3116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x5965550", Offset = "0x5964150", VA = "0x185965550")]
		[RequiredByNativeCode]
		private void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks)
		{
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x59656A0", Offset = "0x59642A0", VA = "0x1859656A0")]
		[RequiredByNativeCode]
		private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount)
		{
			return null;
		}

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x10")]
		protected IntPtr m_Recognizer;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x18")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized;

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x06000C2F RID: 3119
		[Token(Token = "0x2000161")]
		public delegate void PhraseRecognizedDelegate(PhraseRecognizedEventArgs args);
	}
}
