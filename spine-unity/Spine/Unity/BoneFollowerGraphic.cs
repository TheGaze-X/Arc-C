using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	[RequireComponent(typeof(RectTransform))]
	[HelpURL("http://esotericsoftware.com/spine-unity#BoneFollowerGraphic")]
	[AddComponentMenu("Spine/UI/BoneFollowerGraphic")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class BoneFollowerGraphic : MonoBehaviour
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000182")]
		public SkeletonGraphic SkeletonGraphic
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x4E768A0", Offset = "0x4E754A0", VA = "0x184E768A0")]
			set
			{
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000040C4 File Offset: 0x000022C4
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x4E76780", Offset = "0x4E75380", VA = "0x184E76780")]
		public bool SetBone(string name)
		{
			return default(bool);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x4E75D80", Offset = "0x4E74980", VA = "0x184E75D80")]
		public void Awake()
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x4E75D90", Offset = "0x4E74990", VA = "0x184E75D90")]
		public void Initialize()
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x4E75EE0", Offset = "0x4E74AE0", VA = "0x184E75EE0")]
		public void LateUpdate()
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x4E76880", Offset = "0x4E75480", VA = "0x184E76880")]
		public BoneFollowerGraphic()
		{
		}

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x18")]
		public SkeletonGraphic skeletonGraphic;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x20")]
		public bool initializeOnAwake;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x28")]
		[SpineBone("", "skeletonGraphic", true, false)]
		public string boneName;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x30")]
		public bool followBoneRotation;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x31")]
		[Tooltip("Follows the skeleton's flip state by controlling this Transform's local scale.")]
		public bool followSkeletonFlip;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x32")]
		[Tooltip("Follows the target bone's local scale. BoneFollower cannot inherit world/skewed scale because of UnityEngine.Transform property limitations.")]
		public bool followLocalScale;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x33")]
		public bool followXYPosition;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x34")]
		public bool followZPosition;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Applies when 'Follow Skeleton Flip' is disabled but 'Follow Bone Rotation' is enabled. When flipping the skeleton by scaling its Transform, this follower's rotation is adjusted instead of its scale to follow the bone orientation. When one of the axes is flipped,  only one axis can be followed, either the X or the Y axis, which is selected here.")]
		public BoneFollower.AxisOrientation maintainedAxisOrientation;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Bone bone;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x48")]
		private Transform skeletonTransform;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x50")]
		private bool skeletonTransformIsParent;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x51")]
		[NonSerialized]
		public bool valid;
	}
}
