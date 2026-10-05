using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public class AnimationStateData
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000058")]
		public SkeletonData SkeletonData
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00002744 File Offset: 0x00000944
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000059")]
		public float DefaultMix
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x73B900", Offset = "0x73A500", VA = "0x18073B900")]
			set
			{
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4E3AFE0", Offset = "0x4E39BE0", VA = "0x184E3AFE0")]
		public AnimationStateData(SkeletonData skeletonData)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4E3AC00", Offset = "0x4E39800", VA = "0x184E3AC00")]
		public void SetMix(string fromName, string toName, float duration)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4E3AE20", Offset = "0x4E39A20", VA = "0x184E3AE20")]
		public void SetMix(Animation from, Animation to, float duration)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x4E3AA50", Offset = "0x4E39650", VA = "0x184E3AA50")]
		public float GetMix(Animation from, Animation to)
		{
			return 0f;
		}

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x10")]
		internal SkeletonData skeletonData;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<AnimationStateData.AnimationPair, float> animationToMixTime;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x20")]
		internal float defaultMix;

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		public struct AnimationPair
		{
			// Token: 0x06000145 RID: 325 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
			public AnimationPair(Animation a1, Animation a2)
			{
			}

			// Token: 0x06000146 RID: 326 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x4E3A9F0", Offset = "0x4E395F0", VA = "0x184E3A9F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			[FieldOffset(Offset = "0x0")]
			public readonly Animation a1;

			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0x8")]
			public readonly Animation a2;
		}

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		public class AnimationPairComparer : IEqualityComparer<AnimationStateData.AnimationPair>
		{
			// Token: 0x06000147 RID: 327 RVA: 0x00002774 File Offset: 0x00000974
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x4E3A8C0", Offset = "0x4E394C0", VA = "0x184E3A8C0", Slot = "4")]
			private bool Equals(AnimationStateData.AnimationPair x, AnimationStateData.AnimationPair y)
			{
				return default(bool);
			}

			// Token: 0x06000148 RID: 328 RVA: 0x0000278C File Offset: 0x0000098C
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x4E3A8E0", Offset = "0x4E394E0", VA = "0x184E3A8E0", Slot = "5")]
			private int GetHashCode(AnimationStateData.AnimationPair obj)
			{
				return 0;
			}

			// Token: 0x06000149 RID: 329 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AnimationPairComparer()
			{
			}

			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AnimationStateData.AnimationPairComparer Instance;
		}
	}
}
