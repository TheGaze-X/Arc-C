using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public class SkeletonClipping
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700011E")]
		public ExposedList<float> ClippedVertices
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700011F")]
		public ExposedList<int> ClippedTriangles
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000120")]
		public ExposedList<float> ClippedUVs
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x000039EC File Offset: 0x00001BEC
		[Token(Token = "0x17000121")]
		public bool IsClipping
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x1FF9060", Offset = "0x1FF7C60", VA = "0x181FF9060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00003A04 File Offset: 0x00001C04
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x4E60780", Offset = "0x4E5F380", VA = "0x184E60780")]
		public int ClipStart(Slot slot, ClippingAttachment clip)
		{
			return 0;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x4E606A0", Offset = "0x4E5F2A0", VA = "0x184E606A0")]
		public void ClipEnd(Slot slot)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x4E605E0", Offset = "0x4E5F1E0", VA = "0x184E605E0")]
		public void ClipEnd()
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x4E60A20", Offset = "0x4E5F620", VA = "0x184E60A20")]
		public void ClipTriangles(float[] vertices, int verticesLength, int[] triangles, int trianglesLength, float[] uvs)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x4E612C0", Offset = "0x4E5FEC0", VA = "0x184E612C0")]
		internal bool Clip(float x1, float y1, float x2, float y2, float x3, float y3, ExposedList<float> clippingArea, ExposedList<float> output)
		{
			return default(bool);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x4E61A00", Offset = "0x4E60600", VA = "0x184E61A00")]
		public static void MakeClockwise(ExposedList<float> polygon)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x4E61B90", Offset = "0x4E60790", VA = "0x184E61B90")]
		public SkeletonClipping()
		{
		}

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x10")]
		internal readonly Triangulator triangulator;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x18")]
		internal readonly ExposedList<float> clippingPolygon;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x20")]
		internal readonly ExposedList<float> clipOutput;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x28")]
		internal readonly ExposedList<float> clippedVertices;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x30")]
		internal readonly ExposedList<int> clippedTriangles;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x38")]
		internal readonly ExposedList<float> clippedUVs;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x40")]
		internal readonly ExposedList<float> scratch;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x48")]
		internal ClippingAttachment clipAttachment;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x50")]
		internal ExposedList<ExposedList<float>> clippingPolygons;
	}
}
