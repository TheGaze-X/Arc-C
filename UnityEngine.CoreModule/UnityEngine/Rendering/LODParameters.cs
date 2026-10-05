using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x02000273 RID: 627
	[Token(Token = "0x2000273")]
	public struct LODParameters : IEquatable<LODParameters>
	{
		// Token: 0x06000E05 RID: 3589 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x597F620", Offset = "0x597E220", VA = "0x18597F620", Slot = "4")]
		public bool Equals(LODParameters other)
		{
			return default(bool);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x597F6C0", Offset = "0x597E2C0", VA = "0x18597F6C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00006F60 File Offset: 0x00005160
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x597F7E0", Offset = "0x597E3E0", VA = "0x18597F7E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0x0")]
		private int m_IsOrthographic;

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x4")]
		private Vector3 m_CameraPosition;

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x10")]
		private float m_FieldOfView;

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0x14")]
		private float m_OrthoSize;

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x18")]
		private int m_CameraPixelHeight;
	}
}
