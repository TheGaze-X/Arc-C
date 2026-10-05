using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	public struct CombineInstance
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014E")]
		public Mesh mesh
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x5924100", Offset = "0x5922D00", VA = "0x185924100")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x5924140", Offset = "0x5922D40", VA = "0x185924140")]
			set
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014F")]
		public Matrix4x4 transform
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x59241D0", Offset = "0x5922DD0", VA = "0x1859241D0")]
			set
			{
			}
		}

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x0")]
		private int m_MeshInstanceID;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x4")]
		private int m_SubMeshIndex;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x8")]
		private Matrix4x4 m_Transform;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x48")]
		private Vector4 m_LightmapScaleOffset;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x58")]
		private Vector4 m_RealtimeLightmapScaleOffset;
	}
}
