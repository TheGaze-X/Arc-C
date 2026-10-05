using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity.AnimationTools
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public static class TimelineExtensions
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x4EA95A0", Offset = "0x4EA81A0", VA = "0x184EA95A0")]
		public static Vector2 Evaluate(this TranslateTimeline timeline, float time, [Optional] SkeletonData skeletonData)
		{
			return default(Vector2);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x4EA97F0", Offset = "0x4EA83F0", VA = "0x184EA97F0")]
		public static TranslateTimeline FindTranslateTimelineForBone(this Animation a, int boneIndex)
		{
			return null;
		}
	}
}
