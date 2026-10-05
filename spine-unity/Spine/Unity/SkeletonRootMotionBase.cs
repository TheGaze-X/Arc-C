using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public abstract class SkeletonRootMotionBase : MonoBehaviour
	{
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x000041CC File Offset: 0x000023CC
		[Token(Token = "0x17000192")]
		public bool UsesRigidbody
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x4E89C50", Offset = "0x4E88850", VA = "0x184E89C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x4E88660", Offset = "0x4E87260", VA = "0x184E88660", Slot = "4")]
		protected virtual void Reset()
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x4E898E0", Offset = "0x4E884E0", VA = "0x184E898E0", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x4E88800", Offset = "0x4E87400", VA = "0x184E88800", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x4E89450", Offset = "0x4E88050", VA = "0x184E89450", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x4E88660", Offset = "0x4E87260", VA = "0x184E88660")]
		protected void FindRigidbodyComponent()
		{
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x000041E4 File Offset: 0x000023E4
		[Token(Token = "0x17000193")]
		protected virtual float AdditionalScale
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x738E30", Offset = "0x737A30", VA = "0x180738E30", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600052D RID: 1325
		[Token(Token = "0x600052D")]
		protected abstract Vector2 CalculateAnimationsMovementDelta();

		// Token: 0x0600052E RID: 1326
		[Token(Token = "0x600052E")]
		public abstract Vector2 GetRemainingRootMotion(int trackIndex = 0);

		// Token: 0x0600052F RID: 1327
		[Token(Token = "0x600052F")]
		public abstract SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int trackIndex = 0);

		// Token: 0x06000530 RID: 1328 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x4E897A0", Offset = "0x4E883A0", VA = "0x184E897A0")]
		public void SetRootMotionBone(string name)
		{
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x4E88150", Offset = "0x4E86D50", VA = "0x184E88150")]
		public void AdjustRootMotionToDistance(Vector2 distanceToTarget, int trackIndex = 0, bool adjustX = true, bool adjustY = true, float minX = 0f, float maxX = 3.4028235E+38f, float minY = 0f, float maxY = 3.4028235E+38f, bool allowXTranslation = false, bool allowYTranslation = false)
		{
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000041FC File Offset: 0x000023FC
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x4E88D90", Offset = "0x4E87990", VA = "0x184E88D90")]
		public Vector2 GetAnimationRootMotion(Animation animation)
		{
			return default(Vector2);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00004214 File Offset: 0x00002414
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x4E88DC0", Offset = "0x4E879C0", VA = "0x184E88DC0")]
		public Vector2 GetAnimationRootMotion(float startTime, float endTime, Animation animation)
		{
			return default(Vector2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000422C File Offset: 0x0000242C
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x4E88C40", Offset = "0x4E87840", VA = "0x184E88C40")]
		public SkeletonRootMotionBase.RootMotionInfo GetAnimationRootMotionInfo(Animation animation, float currentTime)
		{
			return default(SkeletonRootMotionBase.RootMotionInfo);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00004244 File Offset: 0x00002444
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x4E891E0", Offset = "0x4E87DE0", VA = "0x184E891E0")]
		private Vector2 GetTimelineMovementDelta(float startTime, float endTime, TranslateTimeline timeline, Animation animation)
		{
			return default(Vector2);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x4E88AA0", Offset = "0x4E876A0", VA = "0x184E88AA0")]
		private void GatherTopLevelBones()
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x4E89370", Offset = "0x4E87F70", VA = "0x184E89370")]
		private void HandleUpdateLocal(ISkeletonAnimation animatedSkeletonComponent)
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x4E883E0", Offset = "0x4E86FE0", VA = "0x184E883E0")]
		private void ApplyRootMotion(Vector2 skeletonDelta, Vector2 parentBoneScale)
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000425C File Offset: 0x0000245C
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x4E88FA0", Offset = "0x4E87BA0", VA = "0x184E88FA0")]
		private Vector2 GetScaleAffectingRootMotion()
		{
			return default(Vector2);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00004274 File Offset: 0x00002474
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x4E88FC0", Offset = "0x4E87BC0", VA = "0x184E88FC0")]
		private Vector2 GetScaleAffectingRootMotion(out Vector2 parentBoneScale)
		{
			return default(Vector2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000428C File Offset: 0x0000248C
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x4E89160", Offset = "0x4E87D60", VA = "0x184E89160")]
		private Vector2 GetSkeletonSpaceMovementDelta(Vector2 boneLocalDelta, out Vector2 parentBoneScale)
		{
			return default(Vector2);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x4E894E0", Offset = "0x4E880E0", VA = "0x184E894E0")]
		private void SetEffectiveBoneOffsetsTo(Vector2 displacementSkeletonSpace, Vector2 parentBoneScale)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x4E885F0", Offset = "0x4E871F0", VA = "0x184E885F0")]
		private void ClearEffectiveBoneOffsets(Vector2 parentBoneScale)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x4E89B50", Offset = "0x4E88750", VA = "0x184E89B50")]
		protected SkeletonRootMotionBase()
		{
		}

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x18")]
		[SpineBone("", "", true, false)]
		[SerializeField]
		protected string rootMotionBoneName;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x20")]
		public bool transformPositionX;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x21")]
		public bool transformPositionY;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x24")]
		public float rootMotionScaleX;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x28")]
		public float rootMotionScaleY;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x2C")]
		public float rootMotionTranslateXPerY;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x30")]
		public float rootMotionTranslateYPerX;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x38")]
		[Header("Optional")]
		public Rigidbody2D rigidBody2D;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x40")]
		public Rigidbody rigidBody;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x48")]
		protected ISkeletonComponent skeletonComponent;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x50")]
		protected Bone rootMotionBone;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x58")]
		protected int rootMotionBoneIndex;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x60")]
		protected List<Bone> topLevelBones;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x68")]
		protected Vector2 initialOffset;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x70")]
		protected Vector2 tempSkeletonDisplacement;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x78")]
		protected Vector2 rigidbodyDisplacement;

		// Token: 0x0200007F RID: 127
		[Token(Token = "0x200007F")]
		public struct RootMotionInfo
		{
			// Token: 0x0400032E RID: 814
			[Token(Token = "0x400032E")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 start;

			// Token: 0x0400032F RID: 815
			[Token(Token = "0x400032F")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 current;

			// Token: 0x04000330 RID: 816
			[Token(Token = "0x4000330")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 mid;

			// Token: 0x04000331 RID: 817
			[Token(Token = "0x4000331")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 end;

			// Token: 0x04000332 RID: 818
			[Token(Token = "0x4000332")]
			[FieldOffset(Offset = "0x20")]
			public bool timeIsPastMid;
		}
	}
}
