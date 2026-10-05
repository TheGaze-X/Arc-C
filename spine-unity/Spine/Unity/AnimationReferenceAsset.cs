using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[CreateAssetMenu(menuName = "Spine/Animation Reference Asset", order = 100)]
	public class AnimationReferenceAsset : ScriptableObject, IHasSkeletonDataAsset
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700016E")]
		public SkeletonDataAsset SkeletonDataAsset
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700016F")]
		public Animation Animation
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x4E755C0", Offset = "0x4E741C0", VA = "0x184E755C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x4E753F0", Offset = "0x4E73FF0", VA = "0x184E753F0")]
		public void Initialize()
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x4E755F0", Offset = "0x4E741F0", VA = "0x184E755F0")]
		public static implicit operator Animation(AnimationReferenceAsset asset)
		{
			return null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public AnimationReferenceAsset()
		{
		}

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		private const bool QuietSkeletonData = true;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected SkeletonDataAsset skeletonDataAsset;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x20")]
		[SpineAnimation("", "", true, false)]
		[SerializeField]
		protected string animationName;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x28")]
		private Animation animation;
	}
}
