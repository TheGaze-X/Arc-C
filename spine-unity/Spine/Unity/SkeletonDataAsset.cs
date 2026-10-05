using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[CreateAssetMenu(fileName = "New SkeletonDataAsset", menuName = "Spine/SkeletonData Asset")]
	public class SkeletonDataAsset : ScriptableObject
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0000401C File Offset: 0x0000221C
		[Token(Token = "0x17000177")]
		public bool IsLoaded
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x2215970", Offset = "0x2214570", VA = "0x182215970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x4E7EE90", Offset = "0x4E7DA90", VA = "0x184E7EE90")]
		private void Reset()
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x4E7EFB0", Offset = "0x4E7DBB0", VA = "0x184E7EFB0")]
		public static SkeletonDataAsset CreateRuntimeInstance(TextAsset skeletonDataFile, AtlasAssetBase atlasAsset, bool initialize, float scale = 0.01f)
		{
			return null;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x4E7EED0", Offset = "0x4E7DAD0", VA = "0x184E7EED0")]
		public static SkeletonDataAsset CreateRuntimeInstance(TextAsset skeletonDataFile, AtlasAssetBase[] atlasAssets, bool initialize, float scale = 0.01f)
		{
			return null;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x4E7EE90", Offset = "0x4E7DA90", VA = "0x184E7EE90")]
		public void Clear()
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x4E7F200", Offset = "0x4E7DE00", VA = "0x184E7F200")]
		public AnimationStateData GetAnimationStateData()
		{
			return null;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x4E7F3A0", Offset = "0x4E7DFA0", VA = "0x184E7F3A0")]
		public SkeletonData GetSkeletonData(bool quiet)
		{
			return null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x4E7FD40", Offset = "0x4E7E940", VA = "0x184E7FD40")]
		internal void InitializeWithData(SkeletonData sd)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x4E7F110", Offset = "0x4E7DD10", VA = "0x184E7F110")]
		public void FillStateData()
		{
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x4E7F230", Offset = "0x4E7DE30", VA = "0x184E7F230")]
		internal Atlas[] GetAtlasArray()
		{
			return null;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x4E7FF60", Offset = "0x4E7EB60", VA = "0x184E7FF60")]
		internal static SkeletonData ReadSkeletonData(byte[] bytes, AttachmentLoader attachmentLoader, float scale)
		{
			return null;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x4E7FEA0", Offset = "0x4E7EAA0", VA = "0x184E7FEA0")]
		internal static SkeletonData ReadSkeletonData(string text, AttachmentLoader attachmentLoader, float scale)
		{
			return null;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x4E800B0", Offset = "0x4E7ECB0", VA = "0x184E800B0")]
		public SkeletonDataAsset()
		{
		}

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x18")]
		public AtlasAssetBase[] atlasAssets;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x20")]
		public float scale;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x28")]
		public TextAsset skeletonJSON;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x30")]
		public bool isUpgradingBlendModeMaterials;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x38")]
		public BlendModeMaterials blendModeMaterials;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Use SkeletonDataModifierAssets to apply changes to the SkeletonData after being loaded, such as apply blend mode Materials to Attachments under slots with special blend modes.")]
		public List<SkeletonDataModifierAsset> skeletonDataModifiers;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x48")]
		[SpineAnimation("", "", false, false)]
		public string[] fromAnimation;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x50")]
		[SpineAnimation("", "", false, false)]
		public string[] toAnimation;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x58")]
		public float[] duration;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x60")]
		public float defaultMix;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x68")]
		public RuntimeAnimatorController controller;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x70")]
		private SkeletonData skeletonData;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x78")]
		private AnimationStateData stateData;
	}
}
