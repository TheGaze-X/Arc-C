using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public static class SkeletonDataCompatibility
	{
		// Token: 0x0200006E RID: 110
		[Token(Token = "0x200006E")]
		public enum SourceType
		{
			// Token: 0x040002C0 RID: 704
			[Token(Token = "0x40002C0")]
			Json,
			// Token: 0x040002C1 RID: 705
			[Token(Token = "0x40002C1")]
			Binary
		}

		// Token: 0x0200006F RID: 111
		[Token(Token = "0x200006F")]
		[Serializable]
		public class VersionInfo
		{
			// Token: 0x060004B6 RID: 1206 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VersionInfo()
			{
			}

			// Token: 0x040002C2 RID: 706
			[Token(Token = "0x40002C2")]
			[FieldOffset(Offset = "0x10")]
			public string rawVersion;

			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			[FieldOffset(Offset = "0x18")]
			public int[] version;

			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			[FieldOffset(Offset = "0x20")]
			public SkeletonDataCompatibility.SourceType sourceType;
		}

		// Token: 0x02000070 RID: 112
		[Token(Token = "0x2000070")]
		[Serializable]
		public class CompatibilityProblemInfo
		{
			// Token: 0x060004B7 RID: 1207 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x4E79E80", Offset = "0x4E78A80", VA = "0x184E79E80")]
			public string DescriptionString()
			{
				return null;
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CompatibilityProblemInfo()
			{
			}

			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0x10")]
			public SkeletonDataCompatibility.VersionInfo actualVersion;

			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x40002C6")]
			[FieldOffset(Offset = "0x18")]
			public int[][] compatibleVersions;

			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			[FieldOffset(Offset = "0x20")]
			public string explicitProblemDescription;
		}
	}
}
