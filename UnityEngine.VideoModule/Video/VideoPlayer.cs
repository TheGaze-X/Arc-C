using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Video
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
	[RequireComponent(typeof(Transform))]
	[RequiredByNativeCode]
	public sealed class VideoPlayer : Behaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5BA1AA0", Offset = "0x5BA06A0", VA = "0x185BA1AA0")]
		[RequiredByNativeCode]
		private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x5BA1A30", Offset = "0x5BA0630", VA = "0x185BA1A30")]
		[RequiredByNativeCode]
		private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5BA1A70", Offset = "0x5BA0670", VA = "0x185BA1A70")]
		[RequiredByNativeCode]
		private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x5BA1B00", Offset = "0x5BA0700", VA = "0x185BA1B00")]
		[RequiredByNativeCode]
		private static void InvokeStartedCallback_Internal(VideoPlayer source)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5BA1A00", Offset = "0x5BA0600", VA = "0x185BA1A00")]
		[RequiredByNativeCode]
		private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x5BA19C0", Offset = "0x5BA05C0", VA = "0x185BA19C0")]
		[RequiredByNativeCode]
		private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5BA1AD0", Offset = "0x5BA06D0", VA = "0x185BA1AD0")]
		[RequiredByNativeCode]
		private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5BA1980", Offset = "0x5BA0580", VA = "0x185BA1980")]
		[RequiredByNativeCode]
		private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds)
		{
		}

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x18")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VideoPlayer.EventHandler prepareCompleted;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VideoPlayer.EventHandler loopPointReached;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x28")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private VideoPlayer.EventHandler started;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x30")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VideoPlayer.EventHandler frameDropped;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x38")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VideoPlayer.ErrorEventHandler errorReceived;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x40")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VideoPlayer.EventHandler seekCompleted;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x48")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VideoPlayer.TimeEventHandler clockResyncOccurred;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x50")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VideoPlayer.FrameReadyEventHandler frameReady;

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600000C RID: 12
		[Token(Token = "0x200000C")]
		public delegate void EventHandler(VideoPlayer source);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600000E RID: 14
		[Token(Token = "0x200000D")]
		public delegate void ErrorEventHandler(VideoPlayer source, string message);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000010 RID: 16
		[Token(Token = "0x200000E")]
		public delegate void FrameReadyEventHandler(VideoPlayer source, long frameIdx);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000012 RID: 18
		[Token(Token = "0x200000F")]
		public delegate void TimeEventHandler(VideoPlayer source, double seconds);
	}
}
