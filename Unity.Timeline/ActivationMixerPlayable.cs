using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	internal class ActivationMixerPlayable : PlayableBehaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x58DC260", Offset = "0x58DAE60", VA = "0x1858DC260")]
		public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount)
		{
			return default(ScriptPlayable<ActivationMixerPlayable>);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000001")]
		public ActivationTrack.PostPlaybackState postPlaybackState
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return ActivationTrack.PostPlaybackState.Active;
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x58DC300", Offset = "0x58DAF00", VA = "0x1858DC300", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x58DC3D0", Offset = "0x58DAFD0", VA = "0x1858DC3D0", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ActivationMixerPlayable()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private ActivationTrack.PostPlaybackState m_PostPlaybackState;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x14")]
		private bool m_BoundGameObjectInitialStateIsActive;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		private GameObject m_BoundGameObject;
	}
}
