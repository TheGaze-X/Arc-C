using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public abstract class SkeletonDataModifierAsset : ScriptableObject
	{
		// Token: 0x060004B9 RID: 1209
		[Token(Token = "0x60004B9")]
		public abstract void Apply(SkeletonData skeletonData);

		// Token: 0x060004BA RID: 1210 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		protected SkeletonDataModifierAsset()
		{
		}
	}
}
