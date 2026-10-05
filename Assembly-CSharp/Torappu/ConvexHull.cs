using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	public class ConvexHull : IHotfixable
	{
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x0002D498 File Offset: 0x0002B698
		// (set) Token: 0x06004CEF RID: 19695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001F7")]
		public Vector2 center
		{
			[Token(Token = "0x6004CEE")]
			[Address(RVA = "0x1792B80", Offset = "0x1791780", VA = "0x181792B80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004CEF")]
			[Address(RVA = "0x1792BF0", Offset = "0x17917F0", VA = "0x181792BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF0")]
		[Address(RVA = "0x1792A40", Offset = "0x1791640", VA = "0x181792A40")]
		public ConvexHull(Vector2 resizeRatio, List<Vector2> corners)
		{
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF1")]
		[Address(RVA = "0x1791E60", Offset = "0x1790A60", VA = "0x181791E60")]
		private void _Reset()
		{
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0x1790C00", Offset = "0x178F800", VA = "0x181790C00")]
		public void UpdateVerts(Vector2 resizeRatio, List<Vector2> corners)
		{
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
		[Token(Token = "0x6004CF3")]
		[Address(RVA = "0x1790450", Offset = "0x178F050", VA = "0x181790450")]
		public bool TryGetMovementInHull(Vector2 origin, Vector2 offset, out Vector2 destination)
		{
			return default(bool);
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0x1790290", Offset = "0x178EE90", VA = "0x181790290")]
		public bool InHullRange(Vector2 destination)
		{
			return default(bool);
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x0002D4E0 File Offset: 0x0002B6E0
		[Token(Token = "0x6004CF5")]
		[Address(RVA = "0x17910F0", Offset = "0x178FCF0", VA = "0x1817910F0")]
		private float _Cross(Vector2 a, Vector2 b, Vector2 c)
		{
			return 0f;
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x17911E0", Offset = "0x178FDE0", VA = "0x1817911E0")]
		private void _DoCalculateHull(List<Vector2> input, Vector2 resizeRatio, ref List<Vector2> result, out Vector2 resizeScale)
		{
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF7")]
		[Address(RVA = "0x1791FB0", Offset = "0x1790BB0", VA = "0x181791FB0")]
		private void _ResizeByCenter(Vector2 resizeScale)
		{
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
		[Token(Token = "0x6004CF8")]
		[Address(RVA = "0x1791AC0", Offset = "0x17906C0", VA = "0x181791AC0")]
		private float _GetTriangleArea(Vector2 p0, Vector2 p1, Vector2 p2)
		{
			return 0f;
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF9")]
		[Address(RVA = "0x1790E50", Offset = "0x178FA50", VA = "0x181790E50")]
		private void _ConstructBorderLines()
		{
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x0002D510 File Offset: 0x0002B710
		[Token(Token = "0x6004CFA")]
		[Address(RVA = "0x1791D50", Offset = "0x1790950", VA = "0x181791D50")]
		private static bool _IsOnSegment(Vector2 intersect, Vector2 lineStart, Vector2 lineEnd)
		{
			return default(bool);
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x0002D528 File Offset: 0x0002B728
		[Token(Token = "0x6004CFB")]
		[Address(RVA = "0x1791950", Offset = "0x1790550", VA = "0x181791950")]
		private Vector2 _GetProjection(Vector2 vector, Vector2 direction)
		{
			return default(Vector2);
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x0002D540 File Offset: 0x0002B740
		[Token(Token = "0x6004CFC")]
		[Address(RVA = "0x1792800", Offset = "0x1791400", VA = "0x181792800")]
		private bool _TryGetIntersect(Vector2 p1_1, Vector2 p1_2, Vector2 p2_1, Vector2 p2_2, out Vector2 result)
		{
			return default(bool);
		}

		// Token: 0x04001100 RID: 4352
		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x10")]
		private List<Vector2> m_verts;

		// Token: 0x04001101 RID: 4353
		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x18")]
		private List<ConvexHull.BorderLine> m_borderLines;

		// Token: 0x04001103 RID: 4355
		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_center;

		// Token: 0x04001104 RID: 4356
		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_center;

		// Token: 0x04001105 RID: 4357
		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04001106 RID: 4358
		[Token(Token = "0x4001106")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x04001107 RID: 4359
		[Token(Token = "0x4001107")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateVerts;

		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x4001108")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetMovementInHull;

		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InHullRange;

		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Cross;

		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoCalculateHull;

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResizeByCenter;

		// Token: 0x0400110D RID: 4365
		[Token(Token = "0x400110D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetTriangleArea;

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ConstructBorderLines;

		// Token: 0x0400110F RID: 4367
		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__IsOnSegment;

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetProjection;

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryGetIntersect;

		// Token: 0x020004A9 RID: 1193
		[Token(Token = "0x20004A9")]
		private struct BorderLine
		{
			// Token: 0x170001F8 RID: 504
			// (get) Token: 0x06004CFD RID: 19709 RVA: 0x0002D558 File Offset: 0x0002B758
			[Token(Token = "0x170001F8")]
			public Vector2 direction
			{
				[Token(Token = "0x6004CFD")]
				[Address(RVA = "0x1787740", Offset = "0x1786340", VA = "0x181787740")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x06004CFE RID: 19710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CFE")]
			[Address(RVA = "0x1787730", Offset = "0x1786330", VA = "0x181787730")]
			public BorderLine(Vector2 start, Vector2 end)
			{
			}

			// Token: 0x06004CFF RID: 19711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CFF")]
			[Address(RVA = "0x1787440", Offset = "0x1786040", VA = "0x181787440", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04001112 RID: 4370
			[Token(Token = "0x4001112")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 startPoint;

			// Token: 0x04001113 RID: 4371
			[Token(Token = "0x4001113")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 endPoint;
		}
	}
}
