using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonUtility")]
	[ExecuteAlways]
	[RequireComponent(typeof(ISkeletonAnimation))]
	public sealed class SkeletonUtility : MonoBehaviour
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x4E9BA40", Offset = "0x4E9A640", VA = "0x184E9BA40")]
		public static PolygonCollider2D AddBoundingBoxGameObject(Skeleton skeleton, string skinName, string slotName, string attachmentName, Transform parent, bool isTrigger = true)
		{
			return null;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x4E9BDD0", Offset = "0x4E9A9D0", VA = "0x184E9BDD0")]
		public static PolygonCollider2D AddBoundingBoxGameObject(string name, BoundingBoxAttachment box, Slot slot, Transform parent, bool isTrigger = true)
		{
			return null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x4E9B910", Offset = "0x4E9A510", VA = "0x184E9B910")]
		public static PolygonCollider2D AddBoundingBoxAsComponent(BoundingBoxAttachment box, Slot slot, GameObject gameObject, bool isTrigger = true)
		{
			return null;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x4E9D250", Offset = "0x4E9BE50", VA = "0x184E9D250")]
		public static void SetColliderPointsLocal(PolygonCollider2D collider, Slot slot, BoundingBoxAttachment box, float scale = 1f)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x4E9C790", Offset = "0x4E9B390", VA = "0x184E9C790")]
		public static Bounds GetBoundingBoxBounds(BoundingBoxAttachment boundingBox, float depth = 0f)
		{
			return default(Bounds);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x4E9B820", Offset = "0x4E9A420", VA = "0x184E9B820")]
		public static Rigidbody2D AddBoneRigidbody2D(GameObject gameObject, bool isKinematic = true, float gravityScale = 0f)
		{
			return null;
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x0600065A RID: 1626 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600065B RID: 1627 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400002E")]
		public event SkeletonUtility.SkeletonUtilityDelegate OnReset
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x4E9DFE0", Offset = "0x4E9CBE0", VA = "0x184E9DFE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x4E9E370", Offset = "0x4E9CF70", VA = "0x184E9E370")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x4E9DCF0", Offset = "0x4E9C8F0", VA = "0x184E9DCF0")]
		private void Update()
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001B3")]
		public ISkeletonComponent SkeletonComponent
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x4E9E150", Offset = "0x4E9CD50", VA = "0x184E9E150")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001B4")]
		public Skeleton Skeleton
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x4E9E240", Offset = "0x4E9CE40", VA = "0x184E9E240")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x170001B5")]
		public bool IsValid
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x4E9E080", Offset = "0x4E9CC80", VA = "0x184E9E080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000045A4 File Offset: 0x000027A4
		[Token(Token = "0x170001B6")]
		public float PositionScale
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x1692630", Offset = "0x1691230", VA = "0x181692630")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x4E9D230", Offset = "0x4E9BE30", VA = "0x184E9D230")]
		public void ResubscribeEvents()
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x4E9CB90", Offset = "0x4E9B790", VA = "0x184E9CB90")]
		private void OnEnable()
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x4E9D900", Offset = "0x4E9C500", VA = "0x184E9D900")]
		private void Start()
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x4E9C910", Offset = "0x4E9B510", VA = "0x184E9C910")]
		private void OnDisable()
		{
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x4E9C8E0", Offset = "0x4E9B4E0", VA = "0x184E9C8E0")]
		private void HandleRendererReset(SkeletonRenderer r)
		{
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x4E9C8E0", Offset = "0x4E9B4E0", VA = "0x184E9C8E0")]
		private void HandleRendererReset(SkeletonGraphic g)
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x4E9D110", Offset = "0x4E9BD10", VA = "0x184E9D110")]
		public void RegisterBone(SkeletonUtilityBone bone)
		{
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x4E9D910", Offset = "0x4E9C510", VA = "0x184E9D910")]
		public void UnregisterBone(SkeletonUtilityBone bone)
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x4E9D1A0", Offset = "0x4E9BDA0", VA = "0x184E9D1A0")]
		public void RegisterConstraint(SkeletonUtilityConstraint constraint)
		{
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x4E9D970", Offset = "0x4E9C570", VA = "0x184E9D970")]
		public void UnregisterConstraint(SkeletonUtilityConstraint constraint)
		{
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x4E9C070", Offset = "0x4E9AC70", VA = "0x184E9C070")]
		public void CollectBones()
		{
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x4E9DAC0", Offset = "0x4E9C6C0", VA = "0x184E9DAC0")]
		private void UpdateLocal(ISkeletonAnimation anim)
		{
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x4E9DC20", Offset = "0x4E9C820", VA = "0x184E9DC20")]
		private void UpdateWorld(ISkeletonAnimation anim)
		{
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x4E9DAB0", Offset = "0x4E9C6B0", VA = "0x184E9DAB0")]
		private void UpdateComplete(ISkeletonAnimation anim)
		{
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x4E9D9D0", Offset = "0x4E9C5D0", VA = "0x184E9D9D0")]
		private void UpdateAllBones(SkeletonUtilityBone.UpdatePhase phase)
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x4E9C540", Offset = "0x4E9B140", VA = "0x184E9C540")]
		public Transform GetBoneRoot()
		{
			return null;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x4E9D830", Offset = "0x4E9C430", VA = "0x184E9D830")]
		public GameObject SpawnRoot(SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
		{
			return null;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x4E9D760", Offset = "0x4E9C360", VA = "0x184E9D760")]
		public GameObject SpawnHierarchy(SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
		{
			return null;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x4E9D370", Offset = "0x4E9BF70", VA = "0x184E9D370")]
		public GameObject SpawnBoneRecursively(Bone bone, Transform parent, SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
		{
			return null;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x4E9D490", Offset = "0x4E9C090", VA = "0x184E9D490")]
		public GameObject SpawnBone(Bone bone, Transform parent, SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
		{
			return null;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x4E9DF00", Offset = "0x4E9CB00", VA = "0x184E9DF00")]
		public SkeletonUtility()
		{
		}

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x20")]
		public Transform boneRoot;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x28")]
		public bool flipBy180DegreeRotation;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public SkeletonRenderer skeletonRenderer;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public SkeletonGraphic skeletonGraphic;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x40")]
		private Canvas canvas;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public ISkeletonAnimation skeletonAnimation;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x50")]
		private ISkeletonComponent skeletonComponent;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public List<SkeletonUtilityBone> boneComponents;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public List<SkeletonUtilityConstraint> constraintComponents;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x68")]
		private float positionScale;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x6C")]
		private bool hasOverrideBones;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x6D")]
		private bool hasConstraints;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x6E")]
		private bool needToReprocessBones;

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000677 RID: 1655
		[Token(Token = "0x200009D")]
		public delegate void SkeletonUtilityDelegate();
	}
}
