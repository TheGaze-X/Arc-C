using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200193E RID: 6462
	[Token(Token = "0x200193E")]
	public class DIYShopBuyItemLine : MonoBehaviour
	{
		// Token: 0x14000046 RID: 70
		// (add) Token: 0x0600A288 RID: 41608 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A289 RID: 41609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000046")]
		public event Action<int> countChanged
		{
			[Token(Token = "0x600A288")]
			[Address(RVA = "0x31BFDD0", Offset = "0x31BE9D0", VA = "0x1831BFDD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A289")]
			[Address(RVA = "0x31BFE90", Offset = "0x31BEA90", VA = "0x1831BFE90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x0600A28A RID: 41610 RVA: 0x0003F468 File Offset: 0x0003D668
		// (set) Token: 0x0600A28B RID: 41611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012DB")]
		public int buyCount
		{
			[Token(Token = "0x600A28A")]
			[Address(RVA = "0x31BFE80", Offset = "0x31BEA80", VA = "0x1831BFE80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600A28B")]
			[Address(RVA = "0x31BFF40", Offset = "0x31BEB40", VA = "0x1831BFF40")]
			set
			{
			}
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A28C")]
		[Address(RVA = "0x31BFC30", Offset = "0x31BE830", VA = "0x1831BFC30")]
		private void _UpdateView()
		{
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A28D")]
		[Address(RVA = "0x31BFBC0", Offset = "0x31BE7C0", VA = "0x1831BFBC0")]
		public void Setup(DIYShopBuyItemLine.Argument arg)
		{
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A28E")]
		[Address(RVA = "0x31BFA40", Offset = "0x31BE640", VA = "0x1831BFA40")]
		public void OnAddButtonPressed()
		{
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A28F")]
		[Address(RVA = "0x31BFB60", Offset = "0x31BE760", VA = "0x1831BFB60")]
		public void OnMinusButtonPressed()
		{
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A290")]
		[Address(RVA = "0x31BFB00", Offset = "0x31BE700", VA = "0x1831BFB00")]
		public void OnMinButtonPressed()
		{
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A291")]
		[Address(RVA = "0x31BFAA0", Offset = "0x31BE6A0", VA = "0x1831BFAA0")]
		public void OnMaxButtonPressed()
		{
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A292")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DIYShopBuyItemLine()
		{
		}

		// Token: 0x040098D6 RID: 39126
		[Token(Token = "0x40098D6")]
		private const string BUY_COUNT_FORMAT = "{0}/{1}";

		// Token: 0x040098D7 RID: 39127
		[Token(Token = "0x40098D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _countLabel;

		// Token: 0x040098D8 RID: 39128
		[Token(Token = "0x40098D8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _totalCostLabel;

		// Token: 0x040098D9 RID: 39129
		[Token(Token = "0x40098D9")]
		[FieldOffset(Offset = "0x28")]
		private DIYShopBuyItemLine.Argument m_currentArgument;

		// Token: 0x040098DB RID: 39131
		[Token(Token = "0x40098DB")]
		[FieldOffset(Offset = "0x38")]
		public int m_buyCount;

		// Token: 0x0200193F RID: 6463
		[Token(Token = "0x200193F")]
		public class Argument
		{
			// Token: 0x0600A293 RID: 41619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A293")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Argument()
			{
			}

			// Token: 0x040098DC RID: 39132
			[Token(Token = "0x40098DC")]
			[FieldOffset(Offset = "0x10")]
			public int maxCount;

			// Token: 0x040098DD RID: 39133
			[Token(Token = "0x40098DD")]
			[FieldOffset(Offset = "0x14")]
			public int price;

			// Token: 0x040098DE RID: 39134
			[Token(Token = "0x40098DE")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
