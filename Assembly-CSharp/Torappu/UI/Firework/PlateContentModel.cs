using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E33 RID: 20019
	[Token(Token = "0x2004E33")]
	public class PlateContentModel
	{
		// Token: 0x0601DE7C RID: 122492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE7C")]
		[Address(RVA = "0x177D2E0", Offset = "0x177BEE0", VA = "0x18177D2E0")]
		public void Clear()
		{
		}

		// Token: 0x0601DE7D RID: 122493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE7D")]
		[Address(RVA = "0x177D130", Offset = "0x177BD30", VA = "0x18177D130")]
		public void Add(FireworkData.PlateContent content)
		{
		}

		// Token: 0x0601DE7E RID: 122494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE7E")]
		[Address(RVA = "0x177D290", Offset = "0x177BE90", VA = "0x18177D290")]
		public void Add(GridPosition pos)
		{
		}

		// Token: 0x0601DE7F RID: 122495 RVA: 0x000ACCC8 File Offset: 0x000AAEC8
		[Token(Token = "0x601DE7F")]
		[Address(RVA = "0x177D330", Offset = "0x177BF30", VA = "0x18177D330")]
		public bool Contains(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0601DE80 RID: 122496 RVA: 0x000ACCE0 File Offset: 0x000AAEE0
		[Token(Token = "0x601DE80")]
		[Address(RVA = "0x177D3C0", Offset = "0x177BFC0", VA = "0x18177D3C0")]
		public HashSet<GridPosition>.Enumerator GetEnumerator()
		{
			return default(HashSet<GridPosition>.Enumerator);
		}

		// Token: 0x0601DE81 RID: 122497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE81")]
		[Address(RVA = "0x177D480", Offset = "0x177C080", VA = "0x18177D480")]
		public PlateContentModel()
		{
		}

		// Token: 0x04027AE2 RID: 162530
		[Token(Token = "0x4027AE2")]
		[FieldOffset(Offset = "0x10")]
		public HashSet<GridPosition> plateContent;
	}
}
