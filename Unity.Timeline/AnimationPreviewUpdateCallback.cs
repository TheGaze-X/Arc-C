using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	internal class AnimationPreviewUpdateCallback : ITimelineEvaluateCallback
	{
		// Token: 0x06000043 RID: 67 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x58DE580", Offset = "0x58DD180", VA = "0x1858DE580")]
		public AnimationPreviewUpdateCallback(AnimationPlayableOutput output)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x58DE200", Offset = "0x58DCE00", VA = "0x1858DE200", Slot = "4")]
		public void Evaluate()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x58DE460", Offset = "0x58DD060", VA = "0x1858DE460")]
		private void FetchPreviewComponents()
		{
		}

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x10")]
		private AnimationPlayableOutput m_Output;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		private PlayableGraph m_Graph;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x30")]
		private List<IAnimationWindowPreview> m_PreviewComponents;
	}
}
