using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	[HelpURL("http://esotericsoftware.com/spine-unity#PointFollower")]
	[ExecuteAlways]
	[AddComponentMenu("Spine/Point Follower")]
	public class PointFollower : MonoBehaviour, IHasSkeletonRenderer, IHasSkeletonComponent
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700018D")]
		public SkeletonRenderer SkeletonRenderer
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700018E")]
		public ISkeletonComponent SkeletonComponent
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0000410C File Offset: 0x0000230C
		[Token(Token = "0x1700018F")]
		public bool IsValid
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x4E7D2D0", Offset = "0x4E7BED0", VA = "0x184E7D2D0")]
		public void Initialize()
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x4E7D2D0", Offset = "0x4E7BED0", VA = "0x184E7D2D0")]
		private void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer)
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x4E7D950", Offset = "0x4E7C550", VA = "0x184E7D950")]
		private void UpdateReferences()
		{
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x4E7D880", Offset = "0x4E7C480", VA = "0x184E7D880")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x4E7D370", Offset = "0x4E7BF70", VA = "0x184E7D370")]
		public void LateUpdate()
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x4E7DC50", Offset = "0x4E7C850", VA = "0x184E7DC50")]
		public PointFollower()
		{
		}

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x18")]
		public SkeletonRenderer skeletonRenderer;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x20")]
		[SpineSlot("", "skeletonRenderer", false, true, false)]
		public string slotName;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x28")]
		[SpineAttachment(true, false, false, "slotName", "skeletonRenderer", "", true, true)]
		public string pointAttachmentName;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x30")]
		public bool followRotation;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x31")]
		public bool followSkeletonFlip;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x32")]
		public bool followSkeletonZPosition;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x38")]
		private Transform skeletonTransform;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x40")]
		private bool skeletonTransformIsParent;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x48")]
		private PointAttachment point;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x50")]
		private Bone bone;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x58")]
		private bool valid;
	}
}
