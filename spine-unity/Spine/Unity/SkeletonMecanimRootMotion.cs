using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonMecanimRootMotion")]
	public class SkeletonMecanimRootMotion : SkeletonRootMotionBase
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000190")]
		public SkeletonMecanim SkeletonMecanim
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x4E84F60", Offset = "0x4E83B60", VA = "0x184E84F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00004124 File Offset: 0x00002324
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x4E849F0", Offset = "0x4E835F0", VA = "0x184E849F0", Slot = "10")]
		public override Vector2 GetRemainingRootMotion(int layerIndex)
		{
			return default(Vector2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000413C File Offset: 0x0000233C
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x4E84AE0", Offset = "0x4E836E0", VA = "0x184E84AE0", Slot = "11")]
		public override SkeletonRootMotionBase.RootMotionInfo GetRootMotionInfo(int layerIndex)
		{
			return default(SkeletonRootMotionBase.RootMotionInfo);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x4E84CC0", Offset = "0x4E838C0", VA = "0x184E84CC0", Slot = "4")]
		protected override void Reset()
		{
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x4E84CE0", Offset = "0x4E838E0", VA = "0x184E84CE0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x4E84BC0", Offset = "0x4E837C0", VA = "0x184E84BC0")]
		private void OnClipApplied(Animation animation, int layerIndex, float weight, float time, float lastTime, bool playsBackward)
		{
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00004154 File Offset: 0x00002354
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x4E84970", Offset = "0x4E83570", VA = "0x184E84970", Slot = "9")]
		protected override Vector2 CalculateAnimationsMovementDelta()
		{
			return default(Vector2);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x4E84F40", Offset = "0x4E83B40", VA = "0x184E84F40")]
		public SkeletonMecanimRootMotion()
		{
		}

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		private const int DefaultMecanimLayerFlags = -1;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x80")]
		public int mecanimLayerFlags;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x84")]
		protected Vector2 movementDelta;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x90")]
		private SkeletonMecanim skeletonMecanim;
	}
}
