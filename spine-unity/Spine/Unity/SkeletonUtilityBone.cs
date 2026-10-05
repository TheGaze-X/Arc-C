using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	[ExecuteAlways]
	[AddComponentMenu("Spine/SkeletonUtilityBone")]
	[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonUtilityBone")]
	public class SkeletonUtilityBone : MonoBehaviour
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x170001B7")]
		public bool IncompatibleTransformMode
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x4E9B470", Offset = "0x4E9A070", VA = "0x184E9B470")]
		public void Reset()
		{
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x4E9B2D0", Offset = "0x4E99ED0", VA = "0x184E9B2D0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x4E9B1B0", Offset = "0x4E99DB0", VA = "0x184E9B1B0")]
		private void HandleOnReset()
		{
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x4E9B1C0", Offset = "0x4E99DC0", VA = "0x184E9B1C0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x4E9A410", Offset = "0x4E99010", VA = "0x184E9A410")]
		public void DoUpdate(SkeletonUtilityBone.UpdatePhase phase)
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x4E9A3E0", Offset = "0x4E98FE0", VA = "0x184E9A3E0")]
		public static bool BoneTransformModeIncompatible(Bone bone)
		{
			return default(bool);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x4E9A290", Offset = "0x4E98E90", VA = "0x184E9A290")]
		public void AddBoundingBox(string skinName, string slotName, string attachmentName)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x4E9B6A0", Offset = "0x4E9A2A0", VA = "0x184E9B6A0")]
		public SkeletonUtilityBone()
		{
		}

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x18")]
		public string boneName;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x20")]
		public Transform parentReference;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x28")]
		public SkeletonUtilityBone.Mode mode;

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x2C")]
		public bool position;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x2D")]
		public bool rotation;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x2E")]
		public bool scale;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x2F")]
		public bool zPosition;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float overrideAlpha;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x38")]
		public SkeletonUtility hierarchy;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Bone bone;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public bool transformLerpComplete;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x49")]
		[NonSerialized]
		public bool valid;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x50")]
		private Transform cachedTransform;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x58")]
		private Transform skeletonTransform;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x60")]
		private bool incompatibleTransformMode;

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x200009F")]
		public enum Mode
		{
			// Token: 0x04000404 RID: 1028
			[Token(Token = "0x4000404")]
			Follow,
			// Token: 0x04000405 RID: 1029
			[Token(Token = "0x4000405")]
			Override
		}

		// Token: 0x020000A0 RID: 160
		[Token(Token = "0x20000A0")]
		public enum UpdatePhase
		{
			// Token: 0x04000407 RID: 1031
			[Token(Token = "0x4000407")]
			Local,
			// Token: 0x04000408 RID: 1032
			[Token(Token = "0x4000408")]
			World,
			// Token: 0x04000409 RID: 1033
			[Token(Token = "0x4000409")]
			Complete
		}
	}
}
