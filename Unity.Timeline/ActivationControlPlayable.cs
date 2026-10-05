using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public class ActivationControlPlayable : PlayableBehaviour
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x0000383C File Offset: 0x00001A3C
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x58DBE00", Offset = "0x58DAA00", VA = "0x1858DBE00")]
		public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, ActivationControlPlayable.PostPlaybackState postPlaybackState)
		{
			return default(ScriptPlayable<ActivationControlPlayable>);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x58DBFF0", Offset = "0x58DABF0", VA = "0x1858DBFF0", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x58DBF50", Offset = "0x58DAB50", VA = "0x1858DBF50", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x58DC1D0", Offset = "0x58DADD0", VA = "0x1858DC1D0", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object userData)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x58DC070", Offset = "0x58DAC70", VA = "0x1858DC070", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x58DC100", Offset = "0x58DAD00", VA = "0x1858DC100", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x58DC250", Offset = "0x58DAE50", VA = "0x1858DC250")]
		public ActivationControlPlayable()
		{
		}

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x18")]
		public ActivationControlPlayable.PostPlaybackState postPlayback;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x1C")]
		private ActivationControlPlayable.InitialState m_InitialState;

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		public enum PostPlaybackState
		{
			// Token: 0x04000132 RID: 306
			[Token(Token = "0x4000132")]
			Active,
			// Token: 0x04000133 RID: 307
			[Token(Token = "0x4000133")]
			Inactive,
			// Token: 0x04000134 RID: 308
			[Token(Token = "0x4000134")]
			Revert
		}

		// Token: 0x0200004F RID: 79
		[Token(Token = "0x200004F")]
		private enum InitialState
		{
			// Token: 0x04000136 RID: 310
			[Token(Token = "0x4000136")]
			Unset,
			// Token: 0x04000137 RID: 311
			[Token(Token = "0x4000137")]
			Active,
			// Token: 0x04000138 RID: 312
			[Token(Token = "0x4000138")]
			Inactive
		}
	}
}
