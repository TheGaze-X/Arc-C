using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018C9 RID: 6345
	[Token(Token = "0x20018C9")]
	public class GridMachine3D
	{
		// Token: 0x0600A01C RID: 40988 RVA: 0x0003E760 File Offset: 0x0003C960
		[Token(Token = "0x600A01C")]
		[Address(RVA = "0x31B64F0", Offset = "0x31B50F0", VA = "0x1831B64F0")]
		private static bool _HitTest(GridMachine3D.IGridCube rect0, GridMachine3D.IGridCube rect1)
		{
			return default(bool);
		}

		// Token: 0x0600A01D RID: 40989 RVA: 0x0003E778 File Offset: 0x0003C978
		[Token(Token = "0x600A01D")]
		[Address(RVA = "0x31B5C00", Offset = "0x31B4800", VA = "0x1831B5C00")]
		public bool AddGridCube(GridMachine3D.IGridCube cube, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600A01E RID: 40990 RVA: 0x0003E790 File Offset: 0x0003C990
		[Token(Token = "0x600A01E")]
		[Address(RVA = "0x31B6460", Offset = "0x31B5060", VA = "0x1831B6460")]
		public bool RemoveGridCube(GridMachine3D.IGridCube cube)
		{
			return default(bool);
		}

		// Token: 0x0600A01F RID: 40991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A01F")]
		[Address(RVA = "0x31B6360", Offset = "0x31B4F60", VA = "0x1831B6360")]
		public void ClearGridRect()
		{
		}

		// Token: 0x0600A020 RID: 40992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A020")]
		[Address(RVA = "0x31B63C0", Offset = "0x31B4FC0", VA = "0x1831B63C0")]
		public void ForEachGridCube(Action<GridMachine3D.IGridCube> action)
		{
		}

		// Token: 0x0600A021 RID: 40993 RVA: 0x0003E7A8 File Offset: 0x0003C9A8
		[Token(Token = "0x600A021")]
		[Address(RVA = "0x31B5EA0", Offset = "0x31B4AA0", VA = "0x1831B5EA0")]
		public bool CheckIntersection(GridMachine3D.IGridCube rect, [Optional] Action<GridMachine3D.IGridCube> action)
		{
			return default(bool);
		}

		// Token: 0x0600A022 RID: 40994 RVA: 0x0003E7C0 File Offset: 0x0003C9C0
		[Token(Token = "0x600A022")]
		[Address(RVA = "0x31B5D40", Offset = "0x31B4940", VA = "0x1831B5D40")]
		public bool CheckIntersectionPairs([Optional] Action<GridMachine3D.IGridCube, GridMachine3D.IGridCube> action)
		{
			return default(bool);
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x0003E7D8 File Offset: 0x0003C9D8
		[Token(Token = "0x600A023")]
		[Address(RVA = "0x31B5F90", Offset = "0x31B4B90", VA = "0x1831B5F90")]
		public bool CheckOutofRange(int x, int y, int z, int w, int h, int d, [Optional] Action<GridMachine3D.IGridCube> action)
		{
			return default(bool);
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A024")]
		[Address(RVA = "0x31B6790", Offset = "0x31B5390", VA = "0x1831B6790")]
		public GridMachine3D()
		{
		}

		// Token: 0x0400966F RID: 38511
		[Token(Token = "0x400966F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<GridMachine3D.IGridCube> m_cubeList;

		// Token: 0x020018CA RID: 6346
		[Token(Token = "0x20018CA")]
		public interface IGridCube
		{
			// Token: 0x17001235 RID: 4661
			// (get) Token: 0x0600A025 RID: 40997
			[Token(Token = "0x17001235")]
			int x { [Token(Token = "0x600A025")] get; }

			// Token: 0x17001236 RID: 4662
			// (get) Token: 0x0600A026 RID: 40998
			[Token(Token = "0x17001236")]
			int y { [Token(Token = "0x600A026")] get; }

			// Token: 0x17001237 RID: 4663
			// (get) Token: 0x0600A027 RID: 40999
			[Token(Token = "0x17001237")]
			int z { [Token(Token = "0x600A027")] get; }

			// Token: 0x17001238 RID: 4664
			// (get) Token: 0x0600A028 RID: 41000
			[Token(Token = "0x17001238")]
			int w { [Token(Token = "0x600A028")] get; }

			// Token: 0x17001239 RID: 4665
			// (get) Token: 0x0600A029 RID: 41001
			[Token(Token = "0x17001239")]
			int h { [Token(Token = "0x600A029")] get; }

			// Token: 0x1700123A RID: 4666
			// (get) Token: 0x0600A02A RID: 41002
			[Token(Token = "0x1700123A")]
			int d { [Token(Token = "0x600A02A")] get; }
		}
	}
}
