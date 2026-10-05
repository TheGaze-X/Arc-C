using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	internal class MeshSubsetCombineUtility
	{
		// Token: 0x02000137 RID: 311
		[Token(Token = "0x2000137")]
		public struct MeshInstance
		{
			// Token: 0x040004E6 RID: 1254
			[Token(Token = "0x40004E6")]
			[FieldOffset(Offset = "0x0")]
			public int meshInstanceID;

			// Token: 0x040004E7 RID: 1255
			[Token(Token = "0x40004E7")]
			[FieldOffset(Offset = "0x4")]
			public int rendererInstanceID;

			// Token: 0x040004E8 RID: 1256
			[Token(Token = "0x40004E8")]
			[FieldOffset(Offset = "0x8")]
			public int additionalVertexStreamsMeshInstanceID;

			// Token: 0x040004E9 RID: 1257
			[Token(Token = "0x40004E9")]
			[FieldOffset(Offset = "0xC")]
			public int enlightenVertexStreamMeshInstanceID;

			// Token: 0x040004EA RID: 1258
			[Token(Token = "0x40004EA")]
			[FieldOffset(Offset = "0x10")]
			public Matrix4x4 transform;

			// Token: 0x040004EB RID: 1259
			[Token(Token = "0x40004EB")]
			[FieldOffset(Offset = "0x50")]
			public Vector4 lightmapScaleOffset;

			// Token: 0x040004EC RID: 1260
			[Token(Token = "0x40004EC")]
			[FieldOffset(Offset = "0x60")]
			public Vector4 realtimeLightmapScaleOffset;
		}

		// Token: 0x02000138 RID: 312
		[Token(Token = "0x2000138")]
		public struct SubMeshInstance
		{
			// Token: 0x040004ED RID: 1261
			[Token(Token = "0x40004ED")]
			[FieldOffset(Offset = "0x0")]
			public int meshInstanceID;

			// Token: 0x040004EE RID: 1262
			[Token(Token = "0x40004EE")]
			[FieldOffset(Offset = "0x4")]
			public int vertexOffset;

			// Token: 0x040004EF RID: 1263
			[Token(Token = "0x40004EF")]
			[FieldOffset(Offset = "0x8")]
			public int gameObjectInstanceID;

			// Token: 0x040004F0 RID: 1264
			[Token(Token = "0x40004F0")]
			[FieldOffset(Offset = "0xC")]
			public int subMeshIndex;

			// Token: 0x040004F1 RID: 1265
			[Token(Token = "0x40004F1")]
			[FieldOffset(Offset = "0x10")]
			public Matrix4x4 transform;
		}

		// Token: 0x02000139 RID: 313
		[Token(Token = "0x2000139")]
		public struct MeshContainer
		{
			// Token: 0x040004F2 RID: 1266
			[Token(Token = "0x40004F2")]
			[FieldOffset(Offset = "0x0")]
			public GameObject gameObject;

			// Token: 0x040004F3 RID: 1267
			[Token(Token = "0x40004F3")]
			[FieldOffset(Offset = "0x8")]
			public MeshSubsetCombineUtility.MeshInstance instance;

			// Token: 0x040004F4 RID: 1268
			[Token(Token = "0x40004F4")]
			[FieldOffset(Offset = "0x78")]
			public List<MeshSubsetCombineUtility.SubMeshInstance> subMeshInstances;
		}
	}
}
