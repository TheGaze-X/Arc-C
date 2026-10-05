using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRootMotion")]
	public class SkeletonRootMotion : SkeletonRootMotionBase
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x0000416C File Offset: 0x0000236C
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x4E8A0F0", Offset = "0x4E88CF0", VA = "0x184E8A0F0", Slot = "10")]
		public override Vector2 GetRemainingRootMotion(int trackIndex)
		{
			return default(Vector2);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00004184 File Offset: 0x00002384
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x4E8A1A0", Offset = "0x4E88DA0", VA = "0x184E8A1A0", Slot = "11")]
		public override SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int trackIndex)
		{
			return default(SkeletonRootMotionBase.RootMotionInfo);
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000419C File Offset: 0x0000239C
		[Token(Token = "0x17000191")]
		protected override float AdditionalScale
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x4E8A3D0", Offset = "0x4E88FD0", VA = "0x184E8A3D0", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x4E84CC0", Offset = "0x4E838C0", VA = "0x184E84CC0", Slot = "4")]
		protected override void Reset()
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x4E8A240", Offset = "0x4E88E40", VA = "0x184E8A240", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000041B4 File Offset: 0x000023B4
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x4E89DD0", Offset = "0x4E889D0", VA = "0x184E89DD0", Slot = "9")]
		protected override Vector2 CalculateAnimationsMovementDelta()
		{
			return default(Vector2);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x4E89CE0", Offset = "0x4E888E0", VA = "0x184E89CE0")]
		private void ApplyMixAlphaToDelta(ref Vector2 currentDelta, TrackEntry next, TrackEntry track)
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x4E84F40", Offset = "0x4E83B40", VA = "0x184E84F40")]
		public SkeletonRootMotion()
		{
		}

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		private const int DefaultAnimationTrackFlags = -1;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x80")]
		public int animationTrackFlags;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x88")]
		private AnimationState animationState;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x90")]
		private Canvas canvas;
	}
}
