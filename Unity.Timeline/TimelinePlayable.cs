using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public class TimelinePlayable : PlayableBehaviour
	{
		// Token: 0x06000318 RID: 792 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x5903130", Offset = "0x5901D30", VA = "0x185903130")]
		public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
		{
			return default(ScriptPlayable<TimelinePlayable>);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x5902380", Offset = "0x5900F80", VA = "0x185902380")]
		public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x59020F0", Offset = "0x5900CF0", VA = "0x1859020F0")]
		private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x5902680", Offset = "0x5901280", VA = "0x185902680")]
		private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x5903460", Offset = "0x5902060", VA = "0x185903460")]
		private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x59033C0", Offset = "0x5901FC0", VA = "0x1859033C0")]
		private void EvaluateAnimationPreviewUpdateCallback(TrackAsset track, AnimationPlayableOutput animOutput)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000039D4 File Offset: 0x00001BD4
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x5902C70", Offset = "0x5901870", VA = "0x185902C70")]
		private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs)
		{
			return default(Playable);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x5903B70", Offset = "0x5902770", VA = "0x185903B70", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x5903500", Offset = "0x5902100", VA = "0x185903500")]
		private void Evaluate(Playable playable, FrameData frameData)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x5902080", Offset = "0x5900C80", VA = "0x185902080")]
		private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x5903B10", Offset = "0x5902710", VA = "0x185903B10")]
		private static void ForAOTCompilationOnly()
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x5903C00", Offset = "0x5902800", VA = "0x185903C00")]
		public TimelinePlayable()
		{
		}

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x10")]
		private IntervalTree<RuntimeElement> m_IntervalTree;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x18")]
		private List<RuntimeElement> m_ActiveClips;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x20")]
		private List<RuntimeElement> m_CurrentListOfActiveClips;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x28")]
		private int m_ActiveBit;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x30")]
		private List<ITimelineEvaluateCallback> m_EvaluateCallbacks;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<TrackAsset, Playable> m_PlayableCache;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x0")]
		internal static bool muteAudioScrubbing;
	}
}
