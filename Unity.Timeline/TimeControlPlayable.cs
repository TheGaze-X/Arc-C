using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	public class TimeControlPlayable : PlayableBehaviour
	{
		// Token: 0x060002ED RID: 749 RVA: 0x000038FC File Offset: 0x00001AFC
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x58FD820", Offset = "0x58FC420", VA = "0x1858FD820")]
		public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl)
		{
			return default(ScriptPlayable<TimeControlPlayable>);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
		public void Initialize(ITimeControl timeControl)
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x58FD9D0", Offset = "0x58FC5D0", VA = "0x1858FD9D0", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x58FD980", Offset = "0x58FC580", VA = "0x1858FD980", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x58FD930", Offset = "0x58FC530", VA = "0x1858FD930", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public TimeControlPlayable()
		{
		}

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x10")]
		private ITimeControl m_timeControl;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x18")]
		private bool m_started;
	}
}
