using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace CriWare.CriTimeline.Atom
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	[Serializable]
	public class CriAtomMixerBehaviour : PlayableBehaviour
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00004634 File Offset: 0x00002834
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B6")]
		public Guid m_Guid
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x2569140", Offset = "0x2567D40", VA = "0x182569140")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x370A9A0", Offset = "0x37095A0", VA = "0x18370A9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x370A140", Offset = "0x3708D40", VA = "0x18370A140", Slot = "15")]
		public override void OnPlayableCreate(Playable playable)
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x370A180", Offset = "0x3708D80", VA = "0x18370A180", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x370A0A0", Offset = "0x3708CA0", VA = "0x18370A0A0", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x370A1B0", Offset = "0x3708DB0", VA = "0x18370A1B0", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x170000B7")]
		private static bool IsEditor
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public CriAtomMixerBehaviour()
		{
		}

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x10")]
		internal PlayableDirector m_Director;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x18")]
		internal TimelineClip[] m_Clips;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x20")]
		internal CriAtomSourceBase m_Bind;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x28")]
		internal string m_AisacControls;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x30")]
		internal bool m_StopOnWrapping;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x31")]
		internal bool m_StopAtGraphEnd;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x32")]
		internal bool m_ApplyPlayableSpeed;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x33")]
		internal bool m_CheckPosWithinClip;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		private const int cScratchTimeIntervalMs = 200;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		private const double cFrameSkipTolerance = 5E-324;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x48")]
		private DateTime m_lastScrubTime;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x50")]
		private double m_lastDirectorTime;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x58")]
		private CriAtomListener previewSelectedListenerObj;
	}
}
