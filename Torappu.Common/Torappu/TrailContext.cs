using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	public class TrailContext
	{
		// Token: 0x060006D8 RID: 1752 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x552A2E0", Offset = "0x5528EE0", VA = "0x18552A2E0")]
		private void _ResizeTrails(int targetCount)
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x552A110", Offset = "0x5528D10", VA = "0x18552A110")]
		private TrailContext.Trail _AllocTrail()
		{
			return null;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x552A080", Offset = "0x5528C80", VA = "0x18552A080")]
		private TrailContext.Point _AllocPoint()
		{
			return null;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x552A270", Offset = "0x5528E70", VA = "0x18552A270")]
		private void _DellocTrail(TrailContext.Trail trail)
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x552A210", Offset = "0x5528E10", VA = "0x18552A210")]
		private void _DellocPoint(TrailContext.Point point)
		{
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x552A530", Offset = "0x5529130", VA = "0x18552A530")]
		public TrailContext()
		{
		}

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x10")]
		public List<TrailContext.Trail> trails;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x18")]
		private Queue<TrailContext.Point> m_pointPool;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x20")]
		private Queue<TrailContext.Trail> m_trailPool;

		// Token: 0x02000117 RID: 279
		[Token(Token = "0x2000117")]
		public interface IHost
		{
			// Token: 0x060006DE RID: 1758
			[Token(Token = "0x60006DE")]
			int GetTrailCount();

			// Token: 0x060006DF RID: 1759
			[Token(Token = "0x60006DF")]
			float CalcTrailLifetime(int index);

			// Token: 0x060006E0 RID: 1760
			[Token(Token = "0x60006E0")]
			float MinPointDistance();

			// Token: 0x060006E1 RID: 1761
			[Token(Token = "0x60006E1")]
			bool CheckTrailExpired(int index);

			// Token: 0x060006E2 RID: 1762
			[Token(Token = "0x60006E2")]
			bool GetCurrentPosition(int index, out Vector3 position);
		}

		// Token: 0x02000118 RID: 280
		[Token(Token = "0x2000118")]
		public class Trail
		{
			// Token: 0x060006E3 RID: 1763 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x552A760", Offset = "0x5529360", VA = "0x18552A760")]
			public void Reset(TrailContext context)
			{
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x552A650", Offset = "0x5529250", VA = "0x18552A650")]
			public void AddPosition(TrailContext context, Vector3 position)
			{
			}

			// Token: 0x060006E5 RID: 1765 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x552A920", Offset = "0x5529520", VA = "0x18552A920")]
			public Trail()
			{
			}

			// Token: 0x040005E2 RID: 1506
			[Token(Token = "0x40005E2")]
			[FieldOffset(Offset = "0x10")]
			public float timer;

			// Token: 0x040005E3 RID: 1507
			[Token(Token = "0x40005E3")]
			[FieldOffset(Offset = "0x18")]
			public Queue<TrailContext.Point> buffer;

			// Token: 0x040005E4 RID: 1508
			[Token(Token = "0x40005E4")]
			[FieldOffset(Offset = "0x20")]
			public TrailContext.Point tail;
		}

		// Token: 0x02000119 RID: 281
		[Token(Token = "0x2000119")]
		public class Point
		{
			// Token: 0x060006E6 RID: 1766 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Point()
			{
			}

			// Token: 0x040005E5 RID: 1509
			[Token(Token = "0x40005E5")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 pos;

			// Token: 0x040005E6 RID: 1510
			[Token(Token = "0x40005E6")]
			[FieldOffset(Offset = "0x1C")]
			public float timestamp;
		}

		// Token: 0x0200011A RID: 282
		[Token(Token = "0x200011A")]
		public static class Utils
		{
			// Token: 0x060006E7 RID: 1767 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x552BB70", Offset = "0x552A770", VA = "0x18552BB70")]
			public static void Update(TrailContext.IHost host, TrailContext context, float deltaTime)
			{
			}
		}
	}
}
