using System;
using System.Collections.Generic;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public static class StencilMaterial
	{
		// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Material.Add instead.", true)]
		public static Material Add(Material baseMat, int stencilID)
		{
			return null;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x5B7BF40", Offset = "0x5B7AB40", VA = "0x185B7BF40")]
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask)
		{
			return null;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x5B7CC10", Offset = "0x5B7B810", VA = "0x185B7CC10")]
		private static void LogWarningWhenNotInBatchmode(string warning, Object context)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x5B7BFE0", Offset = "0x5B7ABE0", VA = "0x185B7BFE0")]
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask)
		{
			return null;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x5B7CC80", Offset = "0x5B7B880", VA = "0x185B7CC80")]
		public static void Remove(Material customMat)
		{
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x5B7CA10", Offset = "0x5B7B610", VA = "0x185B7CA10")]
		public static void ClearAll()
		{
		}

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x0")]
		private static List<StencilMaterial.MatEntry> m_List;

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x2000071")]
		private class MatEntry
		{
			// Token: 0x060004D7 RID: 1239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x5B6B790", Offset = "0x5B6A390", VA = "0x185B6B790")]
			public MatEntry()
			{
			}

			// Token: 0x04000252 RID: 594
			[Token(Token = "0x4000252")]
			[FieldOffset(Offset = "0x10")]
			public Material baseMat;

			// Token: 0x04000253 RID: 595
			[Token(Token = "0x4000253")]
			[FieldOffset(Offset = "0x18")]
			public Material customMat;

			// Token: 0x04000254 RID: 596
			[Token(Token = "0x4000254")]
			[FieldOffset(Offset = "0x20")]
			public int count;

			// Token: 0x04000255 RID: 597
			[Token(Token = "0x4000255")]
			[FieldOffset(Offset = "0x24")]
			public int stencilId;

			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			[FieldOffset(Offset = "0x28")]
			public StencilOp operation;

			// Token: 0x04000257 RID: 599
			[Token(Token = "0x4000257")]
			[FieldOffset(Offset = "0x2C")]
			public CompareFunction compareFunction;

			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			[FieldOffset(Offset = "0x30")]
			public int readMask;

			// Token: 0x04000259 RID: 601
			[Token(Token = "0x4000259")]
			[FieldOffset(Offset = "0x34")]
			public int writeMask;

			// Token: 0x0400025A RID: 602
			[Token(Token = "0x400025A")]
			[FieldOffset(Offset = "0x38")]
			public bool useAlphaClip;

			// Token: 0x0400025B RID: 603
			[Token(Token = "0x400025B")]
			[FieldOffset(Offset = "0x3C")]
			public ColorWriteMask colorMask;
		}
	}
}
