using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public class ParticleControlPlayable : PlayableBehaviour
	{
		// Token: 0x060002DB RID: 731 RVA: 0x000038CC File Offset: 0x00001ACC
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x58FC6D0", Offset = "0x58FB2D0", VA = "0x1858FC6D0")]
		public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed)
		{
			return default(ScriptPlayable<ParticleControlPlayable>);
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000C9")]
		public ParticleSystem particleSystem
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x58FC890", Offset = "0x58FB490", VA = "0x1858FC890")]
		public void Initialize(ParticleSystem ps, uint randomSeed)
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x58FCB80", Offset = "0x58FB780", VA = "0x1858FCB80")]
		private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed)
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x58FC930", Offset = "0x58FB530", VA = "0x1858FC930", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData data)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x58FC920", Offset = "0x58FB520", VA = "0x1858FC920", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x58FC920", Offset = "0x58FB520", VA = "0x1858FC920", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x58FCCA0", Offset = "0x58FB8A0", VA = "0x1858FCCA0")]
		private void Simulate(float time, bool restart)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x58FCD80", Offset = "0x58FB980", VA = "0x1858FCD80")]
		public ParticleControlPlayable()
		{
		}

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		private const float kUnsetTime = 3.4028235E+38f;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x10")]
		private float m_LastPlayableTime;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x14")]
		private float m_LastParticleTime;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x18")]
		private uint m_RandomSeed;
	}
}
