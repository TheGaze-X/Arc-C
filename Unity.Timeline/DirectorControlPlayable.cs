using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public class DirectorControlPlayable : PlayableBehaviour
	{
		// Token: 0x060002CB RID: 715 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x58E75D0", Offset = "0x58E61D0", VA = "0x1858E75D0")]
		public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director)
		{
			return default(ScriptPlayable<DirectorControlPlayable>);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x58E7B70", Offset = "0x58E6770", VA = "0x1858E7B70", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x58E7C20", Offset = "0x58E6820", VA = "0x1858E7C20", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x58E7A80", Offset = "0x58E6680", VA = "0x1858E7A80", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x58E7990", Offset = "0x58E6590", VA = "0x1858E7990", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x58E8030", Offset = "0x58E6C30", VA = "0x1858E8030", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x58E83E0", Offset = "0x58E6FE0", VA = "0x1858E83E0")]
		private void SyncSpeed(double speed)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x58E8540", Offset = "0x58E7140", VA = "0x1858E8540")]
		private void SyncStart(PlayableGraph graph, double time)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x58E8600", Offset = "0x58E7200", VA = "0x1858E8600")]
		private void SyncStop(PlayableGraph graph, double time)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000389C File Offset: 0x00001A9C
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x58E7710", Offset = "0x58E6310", VA = "0x1858E7710")]
		private bool DetectDiscontinuity(Playable playable, FrameData info)
		{
			return default(bool);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000038B4 File Offset: 0x00001AB4
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x58E7830", Offset = "0x58E6430", VA = "0x1858E7830")]
		private bool DetectOutOfSync(Playable playable)
		{
			return default(bool);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x58E8690", Offset = "0x58E7290", VA = "0x1858E8690")]
		private void UpdateTime(Playable playable)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x58E8850", Offset = "0x58E7450", VA = "0x1858E8850")]
		public DirectorControlPlayable()
		{
		}

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x10")]
		public PlayableDirector director;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x18")]
		private bool m_SyncTime;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x20")]
		private double m_AssetDuration;
	}
}
