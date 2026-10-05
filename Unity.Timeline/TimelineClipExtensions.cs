using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public static class TimelineClipExtensions
	{
		// Token: 0x06000342 RID: 834 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x5901060", Offset = "0x58FFC60", VA = "0x185901060")]
		public static void MoveToTrack(this TimelineClip clip, TrackAsset destinationTrack)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00003ADC File Offset: 0x00001CDC
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x59014D0", Offset = "0x59000D0", VA = "0x1859014D0")]
		public static bool TryMoveToTrack(this TimelineClip clip, TrackAsset destinationTrack)
		{
			return default(bool);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x5900EE0", Offset = "0x58FFAE0", VA = "0x185900EE0")]
		private static void MoveToTrack_Impl(TimelineClip clip, TrackAsset destinationTrack, Object asset, TrackAsset parentTrack)
		{
		}

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string k_UndoSetParentTrackText;
	}
}
