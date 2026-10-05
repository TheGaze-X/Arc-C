using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x02000255 RID: 597
	[Token(Token = "0x2000255")]
	public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier>
	{
		// Token: 0x06000D84 RID: 3460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x596A760", Offset = "0x5969360", VA = "0x18596A760")]
		public RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x596A6B0", Offset = "0x59692B0", VA = "0x18596A6B0")]
		public RenderTargetIdentifier(string name)
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x596A640", Offset = "0x5969240", VA = "0x18596A640")]
		public RenderTargetIdentifier(int nameID)
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x596A730", Offset = "0x5969330", VA = "0x18596A730")]
		public RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x596A7D0", Offset = "0x59693D0", VA = "0x18596A7D0")]
		public RenderTargetIdentifier(Texture tex)
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x596A9F0", Offset = "0x59695F0", VA = "0x18596A9F0")]
		public static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			return default(RenderTargetIdentifier);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x596ABB0", Offset = "0x59697B0", VA = "0x18596ABB0")]
		public static implicit operator RenderTargetIdentifier(string name)
		{
			return default(RenderTargetIdentifier);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00006E10 File Offset: 0x00005010
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x596AAA0", Offset = "0x59696A0", VA = "0x18596AAA0")]
		public static implicit operator RenderTargetIdentifier(int nameID)
		{
			return default(RenderTargetIdentifier);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x596AB50", Offset = "0x5969750", VA = "0x18596AB50")]
		public static implicit operator RenderTargetIdentifier(Texture tex)
		{
			return default(RenderTargetIdentifier);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x596A2F0", Offset = "0x5968EF0", VA = "0x18596A2F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00006E40 File Offset: 0x00005040
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x596A2A0", Offset = "0x5968EA0", VA = "0x18596A2A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00006E58 File Offset: 0x00005058
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x596A1D0", Offset = "0x5968DD0", VA = "0x18596A1D0", Slot = "4")]
		public bool Equals(RenderTargetIdentifier rhs)
		{
			return default(bool);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x596A120", Offset = "0x5968D20", VA = "0x18596A120", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x596A9B0", Offset = "0x59695B0", VA = "0x18596A9B0")]
		public static bool operator ==(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			return default(bool);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x596AC70", Offset = "0x5969870", VA = "0x18596AC70")]
		public static bool operator !=(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			return default(bool);
		}

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		public const int AllDepthSlices = -1;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x0")]
		private BuiltinRenderTextureType m_Type;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x4")]
		private int m_NameID;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x8")]
		private int m_InstanceID;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_BufferPointer;

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x18")]
		private int m_MipLevel;

		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x40006E8")]
		[FieldOffset(Offset = "0x1C")]
		private CubemapFace m_CubeFace;

		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		[FieldOffset(Offset = "0x20")]
		private int m_DepthSlice;
	}
}
