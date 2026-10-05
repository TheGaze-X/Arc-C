using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	public sealed class DictationRecognizer
	{
		// Token: 0x06000C30 RID: 3120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x3104BA0", Offset = "0x31037A0", VA = "0x183104BA0")]
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword)
		{
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x926B20", Offset = "0x925720", VA = "0x180926B20")]
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence)
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x5137A0", Offset = "0x5123A0", VA = "0x1805137A0")]
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause)
		{
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x595A250", Offset = "0x5958E50", VA = "0x18595A250")]
		[RequiredByNativeCode]
		private void DictationRecognizer_InvokeErrorEvent(string error, int hresult)
		{
		}

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Recognizer;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x18")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DictationRecognizer.DictationHypothesisDelegate DictationHypothesis;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DictationRecognizer.DictationResultDelegate DictationResult;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x28")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DictationRecognizer.DictationCompletedDelegate DictationComplete;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x30")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DictationRecognizer.DictationErrorHandler DictationError;

		// Token: 0x02000163 RID: 355
		// (Invoke) Token: 0x06000C35 RID: 3125
		[Token(Token = "0x2000163")]
		public delegate void DictationHypothesisDelegate(string text);

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x06000C37 RID: 3127
		[Token(Token = "0x2000164")]
		public delegate void DictationResultDelegate(string text, ConfidenceLevel confidence);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x06000C39 RID: 3129
		[Token(Token = "0x2000165")]
		public delegate void DictationCompletedDelegate(DictationCompletionCause cause);

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x06000C3B RID: 3131
		[Token(Token = "0x2000166")]
		public delegate void DictationErrorHandler(string error, int hresult);
	}
}
