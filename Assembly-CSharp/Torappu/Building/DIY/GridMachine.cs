using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018C7 RID: 6343
	[Token(Token = "0x20018C7")]
	public class GridMachine
	{
		// Token: 0x0600A00E RID: 40974 RVA: 0x0003E6D0 File Offset: 0x0003C8D0
		[Token(Token = "0x600A00E")]
		[Address(RVA = "0x31B72D0", Offset = "0x31B5ED0", VA = "0x1831B72D0")]
		private static bool _HitTest(GridMachine.IGridRect rect0, GridMachine.IGridRect rect1)
		{
			return default(bool);
		}

		// Token: 0x0600A00F RID: 40975 RVA: 0x0003E6E8 File Offset: 0x0003C8E8
		[Token(Token = "0x600A00F")]
		[Address(RVA = "0x31B6820", Offset = "0x31B5420", VA = "0x1831B6820")]
		public bool AddGridRect(GridMachine.IGridRect rect, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x0003E700 File Offset: 0x0003C900
		[Token(Token = "0x600A010")]
		[Address(RVA = "0x31B7240", Offset = "0x31B5E40", VA = "0x1831B7240")]
		public bool RemoveGridRect(GridMachine.IGridRect rect)
		{
			return default(bool);
		}

		// Token: 0x0600A011 RID: 40977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A011")]
		[Address(RVA = "0x31B6EB0", Offset = "0x31B5AB0", VA = "0x1831B6EB0")]
		public void ClearGridRect()
		{
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A012")]
		[Address(RVA = "0x31B6F10", Offset = "0x31B5B10", VA = "0x1831B6F10")]
		public void ForEachGridRect(Action<GridMachine.IGridRect> action)
		{
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x0003E718 File Offset: 0x0003C918
		[Token(Token = "0x600A013")]
		[Address(RVA = "0x31B6AC0", Offset = "0x31B56C0", VA = "0x1831B6AC0")]
		public bool CheckIntersection(GridMachine.IGridRect rect, [Optional] Action<GridMachine.IGridRect> action)
		{
			return default(bool);
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x0003E730 File Offset: 0x0003C930
		[Token(Token = "0x600A014")]
		[Address(RVA = "0x31B6960", Offset = "0x31B5560", VA = "0x1831B6960")]
		public bool CheckIntersectionPairs([Optional] Action<GridMachine.IGridRect, GridMachine.IGridRect> action)
		{
			return default(bool);
		}

		// Token: 0x0600A015 RID: 40981 RVA: 0x0003E748 File Offset: 0x0003C948
		[Token(Token = "0x600A015")]
		[Address(RVA = "0x31B6BB0", Offset = "0x31B57B0", VA = "0x1831B6BB0")]
		public bool CheckOutofRange(int x, int y, int w, int h, [Optional] Action<GridMachine.IGridRect> action)
		{
			return default(bool);
		}

		// Token: 0x0600A016 RID: 40982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A016")]
		[Address(RVA = "0x31B6FB0", Offset = "0x31B5BB0", VA = "0x1831B6FB0")]
		public int[,] GetOccupationMatrix(int x, int y, int w, int h)
		{
			return null;
		}

		// Token: 0x0600A017 RID: 40983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A017")]
		[Address(RVA = "0x31B74A0", Offset = "0x31B60A0", VA = "0x1831B74A0")]
		public GridMachine()
		{
		}

		// Token: 0x0400966E RID: 38510
		[Token(Token = "0x400966E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<GridMachine.IGridRect> m_rectList;

		// Token: 0x020018C8 RID: 6344
		[Token(Token = "0x20018C8")]
		public interface IGridRect
		{
			// Token: 0x17001231 RID: 4657
			// (get) Token: 0x0600A018 RID: 40984
			[Token(Token = "0x17001231")]
			int x { [Token(Token = "0x600A018")] get; }

			// Token: 0x17001232 RID: 4658
			// (get) Token: 0x0600A019 RID: 40985
			[Token(Token = "0x17001232")]
			int y { [Token(Token = "0x600A019")] get; }

			// Token: 0x17001233 RID: 4659
			// (get) Token: 0x0600A01A RID: 40986
			[Token(Token = "0x17001233")]
			int w { [Token(Token = "0x600A01A")] get; }

			// Token: 0x17001234 RID: 4660
			// (get) Token: 0x0600A01B RID: 40987
			[Token(Token = "0x17001234")]
			int h { [Token(Token = "0x600A01B")] get; }
		}
	}
}
