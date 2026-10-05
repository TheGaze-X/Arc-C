using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	public class SpineBone : SpineAttributeBase
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x4E9E6A0", Offset = "0x4E9D2A0", VA = "0x184E9E6A0")]
		public SpineBone(string startsWith = "", string dataField = "", bool includeNone = true, bool fallbackToTextField = false)
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x4E9EB40", Offset = "0x4E9D740", VA = "0x184E9EB40")]
		public static Bone GetBone(string boneName, SkeletonRenderer renderer)
		{
			return null;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x4E9EB00", Offset = "0x4E9D700", VA = "0x184E9EB00")]
		public static BoneData GetBoneData(string boneName, SkeletonDataAsset skeletonDataAsset)
		{
			return null;
		}
	}
}
