using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Spine.Unity
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[ExecuteAlways]
	[AddComponentMenu("Spine/BoneFollower")]
	[HelpURL("http://esotericsoftware.com/spine-unity#BoneFollower")]
	public class BoneFollower : MonoBehaviour
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00004094 File Offset: 0x00002294
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000180")]
		public bool EnableManualUpdate
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000181")]
		public SkeletonRenderer SkeletonRenderer
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x4E77510", Offset = "0x4E76110", VA = "0x184E77510")]
			set
			{
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000040AC File Offset: 0x000022AC
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x4E77400", Offset = "0x4E76000", VA = "0x184E77400")]
		public bool SetBone(string name)
		{
			return default(bool);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x4E768D0", Offset = "0x4E754D0", VA = "0x184E768D0")]
		public void Awake()
		{
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x4E77110", Offset = "0x4E75D10", VA = "0x184E77110")]
		public void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer)
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x4E77120", Offset = "0x4E75D20", VA = "0x184E77120")]
		public void Initialize()
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x4E77330", Offset = "0x4E75F30", VA = "0x184E77330")]
		private void OnDestroy()
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x4E77320", Offset = "0x4E75F20", VA = "0x184E77320")]
		public void LateUpdate()
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x4E768E0", Offset = "0x4E754E0", VA = "0x184E768E0")]
		public void DoLateUpdate()
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x4E774F0", Offset = "0x4E760F0", VA = "0x184E774F0")]
		public BoneFollower()
		{
		}

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x20")]
		public SkeletonRenderer skeletonRenderer;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x28")]
		[SpineBone("", "skeletonRenderer", true, false)]
		public string boneName;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x30")]
		public bool followXYPosition;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x31")]
		public bool followZPosition;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x32")]
		public bool followBoneRotation;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x33")]
		[Tooltip("Follows the skeleton's flip state by controlling this Transform's local scale.")]
		public bool followSkeletonFlip;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Follows the target bone's local scale. BoneFollower cannot inherit world/skewed scale because of UnityEngine.Transform property limitations.")]
		public bool followLocalScale;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x35")]
		[Tooltip("Use the applied local scale to replace the local scale.")]
		public bool useAppliedLocalScale;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Applies when 'Follow Skeleton Flip' is disabled but 'Follow Bone Rotation' is enabled. When flipping the skeleton by scaling its Transform, this follower's rotation is adjusted instead of its scale to follow the bone orientation. When one of the axes is flipped,  only one axis can be followed, either the X or the Y axis, which is selected here.")]
		public BoneFollower.AxisOrientation maintainedAxisOrientation;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x3C")]
		[FormerlySerializedAs("resetOnAwake")]
		public bool initializeOnAwake;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x3D")]
		[NonSerialized]
		public bool valid;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Bone bone;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x48")]
		private Transform skeletonTransform;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x50")]
		private bool skeletonTransformIsParent;

		// Token: 0x02000077 RID: 119
		[Token(Token = "0x2000077")]
		public enum AxisOrientation
		{
			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			XAxis = 1,
			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			YAxis
		}
	}
}
