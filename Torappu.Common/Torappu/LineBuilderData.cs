using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	public class LineBuilderData
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x5521390", Offset = "0x551FF90", VA = "0x185521390")]
		public LineBuilderData()
		{
		}

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x10")]
		public List<Vector3> vertices;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x18")]
		public List<float> currentLineLengths;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x20")]
		public List<float> lineSmoothFactor;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector2> extrusionDirection;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x30")]
		public List<Vector2> intersections;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x38")]
		public int numCornerVertices;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x3C")]
		public int numCapVertices;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x40")]
		public LineAlignment alignment;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x44")]
		public bool loop;
	}
}
