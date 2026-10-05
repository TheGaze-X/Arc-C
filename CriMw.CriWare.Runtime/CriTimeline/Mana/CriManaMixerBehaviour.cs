using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CriWare.CriMana;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace CriWare.CriTimeline.Mana
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	[Serializable]
	public class CriManaMixerBehaviour : PlayableBehaviour
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000044CC File Offset: 0x000026CC
		[Token(Token = "0x170000AA")]
		private static bool IsEditMode
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x370DE70", Offset = "0x370CA70", VA = "0x18370DE70")]
		private void KeepAudioVolume(bool fadeAudio)
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000044E4 File Offset: 0x000026E4
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x370E660", Offset = "0x370D260", VA = "0x18370E660")]
		private bool PlayMovie(CriManaClipBase clipAsset, int startFrame, double startTime)
		{
			return default(bool);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000044FC File Offset: 0x000026FC
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x370EAC0", Offset = "0x370D6C0", VA = "0x18370EAC0")]
		private bool PrepareMovie(CriManaClipBase clipAsset)
		{
			return default(bool);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00004514 File Offset: 0x00002714
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x370FB40", Offset = "0x370E740", VA = "0x18370FB40")]
		private bool StopMovie(bool keepLastFrame = false)
		{
			return default(bool);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0000452C File Offset: 0x0000272C
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x370FAB0", Offset = "0x370E6B0", VA = "0x18370FAB0")]
		private bool StopForSeekMovie()
		{
			return default(bool);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x370DDC0", Offset = "0x370C9C0", VA = "0x18370DDC0")]
		private static bool IsPlayerStopped(Player player)
		{
			return default(bool);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x370EE00", Offset = "0x370DA00", VA = "0x18370EE00")]
		private void ProcessFrameOnSeeking(TimelineClip activeClip, CriManaClipBase clip, double frameTime)
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x370DC30", Offset = "0x370C830", VA = "0x18370DC30")]
		private void ForceSyncedStop(bool keepLastFrame = false)
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x370EF10", Offset = "0x370DB10", VA = "0x18370EF10", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0000455C File Offset: 0x0000275C
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x370DD60", Offset = "0x370C960", VA = "0x18370DD60")]
		private bool IsIntermediateState()
		{
			return default(bool);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x370DF90", Offset = "0x370CB90", VA = "0x18370DF90", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x370DF30", Offset = "0x370CB30", VA = "0x18370DF30", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x370E570", Offset = "0x370D170", VA = "0x18370E570")]
		private void PausePlayer(bool pause)
		{
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x370DFE0", Offset = "0x370CBE0", VA = "0x18370DFE0", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x370E280", Offset = "0x370CE80", VA = "0x18370E280", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x370E420", Offset = "0x370D020", VA = "0x18370E420", Slot = "15")]
		public override void OnPlayableCreate(Playable playable)
		{
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x370E4F0", Offset = "0x370D0F0", VA = "0x18370E4F0", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x370FCF0", Offset = "0x370E8F0", VA = "0x18370FCF0")]
		public CriManaMixerBehaviour()
		{
		}

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal PlayableDirector m_PlayableDirector;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal TimelineClip[] m_clips;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal CriManaMovieMaterialBase m_boundMovieMaterial;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Dictionary<int, GCHandle> m_gcHandleList;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal bool m_frameSync;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		internal bool m_CheckPosWithinClip;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static double cPreloadTimeSec;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float cFrameSkipTolerance;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Guid? m_lastClipId;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private double lastPlayedTime;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private double m_currentSeekingFrameTime;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_originalAudioVolume;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float m_originalSubAudioVolume;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_originalExtraAudioVolume;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool enableTimelineScrubPlayback;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private double m_lastDirectorTime;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CriManaMixerBehaviour.MovieMixerState m_movieMixerState;

		// Token: 0x0200011F RID: 287
		[Token(Token = "0x200011F")]
		private enum MovieMixerState
		{
			// Token: 0x04000530 RID: 1328
			[Token(Token = "0x4000530")]
			Preloading,
			// Token: 0x04000531 RID: 1329
			[Token(Token = "0x4000531")]
			Ready,
			// Token: 0x04000532 RID: 1330
			[Token(Token = "0x4000532")]
			Playing,
			// Token: 0x04000533 RID: 1331
			[Token(Token = "0x4000533")]
			Stopping,
			// Token: 0x04000534 RID: 1332
			[Token(Token = "0x4000534")]
			Stopped
		}

		// Token: 0x02000120 RID: 288
		[Token(Token = "0x2000120")]
		private enum ClipState
		{
			// Token: 0x04000536 RID: 1334
			[Token(Token = "0x4000536")]
			Idle,
			// Token: 0x04000537 RID: 1335
			[Token(Token = "0x4000537")]
			Prepare,
			// Token: 0x04000538 RID: 1336
			[Token(Token = "0x4000538")]
			Play,
			// Token: 0x04000539 RID: 1337
			[Token(Token = "0x4000539")]
			Seek
		}
	}
}
