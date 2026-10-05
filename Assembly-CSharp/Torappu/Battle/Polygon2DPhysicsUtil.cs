using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x020024D6 RID: 9430
	[Token(Token = "0x20024D6")]
	public static class Polygon2DPhysicsUtil
	{
		// Token: 0x0600F2E8 RID: 62184 RVA: 0x00059790 File Offset: 0x00057990
		[Token(Token = "0x600F2E8")]
		[Address(RVA = "0x6AF7C0", Offset = "0x6AE3C0", VA = "0x1806AF7C0")]
		public static bool PolygonCircle(Polygon2DPhysicsUtil.CircleStruct circle, List<Vector2> points)
		{
			return default(bool);
		}

		// Token: 0x0600F2E9 RID: 62185 RVA: 0x000597A8 File Offset: 0x000579A8
		[Token(Token = "0x600F2E9")]
		[Address(RVA = "0x6AFC80", Offset = "0x6AE880", VA = "0x1806AFC80")]
		public static bool RectangleCircle(Polygon2DPhysicsUtil.CircleStruct circle, Polygon2DPhysicsUtil.RectangleStruct rectangle)
		{
			return default(bool);
		}

		// Token: 0x0600F2EA RID: 62186 RVA: 0x000597C0 File Offset: 0x000579C0
		[Token(Token = "0x600F2EA")]
		[Address(RVA = "0x6AF9F0", Offset = "0x6AE5F0", VA = "0x1806AF9F0")]
		public static bool PolygonRectangle(Polygon2DPhysicsUtil.RectangleStruct rectangle, List<Vector2> points)
		{
			return default(bool);
		}

		// Token: 0x0600F2EB RID: 62187 RVA: 0x000597D8 File Offset: 0x000579D8
		[Token(Token = "0x600F2EB")]
		[Address(RVA = "0x6AFE20", Offset = "0x6AEA20", VA = "0x1806AFE20")]
		public static bool RectangleLine(Vector2 point1, Vector2 point2, Polygon2DPhysicsUtil.RectangleStruct rectangle)
		{
			return default(bool);
		}

		// Token: 0x0600F2EC RID: 62188 RVA: 0x000597F0 File Offset: 0x000579F0
		[Token(Token = "0x600F2EC")]
		[Address(RVA = "0x6AF500", Offset = "0x6AE100", VA = "0x1806AF500")]
		public static bool LineLine(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
		{
			return default(bool);
		}

		// Token: 0x0600F2ED RID: 62189 RVA: 0x00059808 File Offset: 0x00057A08
		[Token(Token = "0x600F2ED")]
		[Address(RVA = "0x6AF8B0", Offset = "0x6AE4B0", VA = "0x1806AF8B0")]
		public static bool PolygonPoint(Vector2 point, List<Vector2> points)
		{
			return default(bool);
		}

		// Token: 0x0600F2EE RID: 62190 RVA: 0x00059820 File Offset: 0x00057A20
		[Token(Token = "0x600F2EE")]
		[Address(RVA = "0x6AF0B0", Offset = "0x6ADCB0", VA = "0x1806AF0B0")]
		public static bool CircleLine(Vector2 point1, Vector2 point2, Polygon2DPhysicsUtil.CircleStruct circle)
		{
			return default(bool);
		}

		// Token: 0x0600F2EF RID: 62191 RVA: 0x00059838 File Offset: 0x00057A38
		[Token(Token = "0x600F2EF")]
		[Address(RVA = "0x6AF410", Offset = "0x6AE010", VA = "0x1806AF410")]
		public static bool CirclePoint(Vector2 point, Polygon2DPhysicsUtil.CircleStruct circle)
		{
			return default(bool);
		}

		// Token: 0x0600F2F0 RID: 62192 RVA: 0x00059850 File Offset: 0x00057A50
		[Token(Token = "0x600F2F0")]
		[Address(RVA = "0x6AFF70", Offset = "0x6AEB70", VA = "0x1806AFF70")]
		public static bool RectanglePoint(Vector2 point, Polygon2DPhysicsUtil.RectangleStruct rectangle)
		{
			return default(bool);
		}

		// Token: 0x0600F2F1 RID: 62193 RVA: 0x00059868 File Offset: 0x00057A68
		[Token(Token = "0x600F2F1")]
		[Address(RVA = "0x6AF600", Offset = "0x6AE200", VA = "0x1806AF600")]
		public static bool LinePoint(Vector2 point, Vector2 linePoint1, Vector2 linePoint2)
		{
			return default(bool);
		}

		// Token: 0x020024D7 RID: 9431
		[Token(Token = "0x20024D7")]
		public struct CircleStruct
		{
			// Token: 0x04010CCC RID: 68812
			[Token(Token = "0x4010CCC")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 center;

			// Token: 0x04010CCD RID: 68813
			[Token(Token = "0x4010CCD")]
			[FieldOffset(Offset = "0x8")]
			public FP radius;
		}

		// Token: 0x020024D8 RID: 9432
		[Token(Token = "0x20024D8")]
		public struct RectangleStruct
		{
			// Token: 0x04010CCE RID: 68814
			[Token(Token = "0x4010CCE")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 plu;

			// Token: 0x04010CCF RID: 68815
			[Token(Token = "0x4010CCF")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 pld;

			// Token: 0x04010CD0 RID: 68816
			[Token(Token = "0x4010CD0")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 pru;

			// Token: 0x04010CD1 RID: 68817
			[Token(Token = "0x4010CD1")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 prd;
		}
	}
}
