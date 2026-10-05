using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public static class PhraseRecognitionSystem
	{
		// Token: 0x06000C26 RID: 3110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x5965430", Offset = "0x5964030", VA = "0x185965430")]
		[RequiredByNativeCode]
		private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode)
		{
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x5965490", Offset = "0x5964090", VA = "0x185965490")]
		[RequiredByNativeCode]
		private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status)
		{
		}

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static PhraseRecognitionSystem.ErrorDelegate OnError;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x8")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static PhraseRecognitionSystem.StatusDelegate OnStatusChanged;

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x06000C29 RID: 3113
		[Token(Token = "0x200015E")]
		public delegate void ErrorDelegate(SpeechError errorCode);

		// Token: 0x0200015F RID: 351
		// (Invoke) Token: 0x06000C2B RID: 3115
		[Token(Token = "0x200015F")]
		public delegate void StatusDelegate(SpeechSystemStatus status);
	}
}
