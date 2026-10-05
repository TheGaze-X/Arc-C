using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback
	{
		// Token: 0x06000012 RID: 18 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x58DCF40", Offset = "0x58DBB40", VA = "0x1858DCF40")]
		public AnimationOutputWeightProcessor(AnimationPlayableOutput output)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x58DCB00", Offset = "0x58DB700", VA = "0x1858DCB00")]
		private void FindMixers()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x58DCC10", Offset = "0x58DB810", VA = "0x1858DCC10")]
		private void FindMixers(Playable parent, int port, Playable node)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x58DC9B0", Offset = "0x58DB5B0", VA = "0x1858DC9B0", Slot = "4")]
		public void Evaluate()
		{
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		private AnimationPlayableOutput m_Output;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		private AnimationMotionXToDeltaPlayable m_MotionXPlayable;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<AnimationOutputWeightProcessor.WeightInfo> m_Mixers;

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		private struct WeightInfo
		{
			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x0")]
			public Playable mixer;

			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x10")]
			public Playable parentMixer;

			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x20")]
			public int port;
		}
	}
}
