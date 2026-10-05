using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	public class SkeletonRendererInstruction
	{
		// Token: 0x060006C3 RID: 1731 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x4E99A00", Offset = "0x4E98600", VA = "0x184E99A00")]
		public void Clear()
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x4E99A80", Offset = "0x4E98680", VA = "0x184E99A80")]
		public void Dispose()
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x4E99CF0", Offset = "0x4E988F0", VA = "0x184E99CF0")]
		public void SetWithSubset(ExposedList<SubmeshInstruction> instructions, int startSubmesh, int endSubmesh)
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x4E99FD0", Offset = "0x4E98BD0", VA = "0x184E99FD0")]
		public void Set(SkeletonRendererInstruction other)
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x4E99AD0", Offset = "0x4E986D0", VA = "0x184E99AD0")]
		public static bool GeometryNotEqual(SkeletonRendererInstruction a, SkeletonRendererInstruction b)
		{
			return default(bool);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x4E9A1B0", Offset = "0x4E98DB0", VA = "0x184E9A1B0")]
		public SkeletonRendererInstruction()
		{
		}

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x10")]
		public readonly ExposedList<SubmeshInstruction> submeshInstructions;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x18")]
		public bool immutableTriangles;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x19")]
		public bool hasActiveClipping;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x1C")]
		public int rawVertexCount;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x20")]
		public readonly ExposedList<Attachment> attachments;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x28")]
		public bool reverseMesh;
	}
}
