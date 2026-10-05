using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	public struct MeshGeneratorBuffers
	{
		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x0")]
		public int vertexCount;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x8")]
		public Vector3[] vertexBuffer;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x10")]
		public Vector2[] uvBuffer;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x18")]
		public Color32[] colorBuffer;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x20")]
		public MeshGenerator meshGenerator;
	}
}
