using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007113 RID: 28947
	[Token(Token = "0x2007113")]
	public class ActAutoChessHandbookBondDetailListAdapter : LoopScrollAdapter<ActAutoChessHandbookBondDetailListAdapter.ViewHolder, ActAutoChessHandbookChessViewModel>, IHotfixable
	{
		// Token: 0x06029208 RID: 168456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029208")]
		[Address(RVA = "0x2482C80", Offset = "0x2481880", VA = "0x182482C80", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06029209 RID: 168457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029209")]
		[Address(RVA = "0x2482D30", Offset = "0x2481930", VA = "0x182482D30", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ActAutoChessHandbookBondDetailListAdapter.ViewHolder holder, ActAutoChessHandbookChessViewModel data)
		{
		}

		// Token: 0x0602920A RID: 168458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602920A")]
		[Address(RVA = "0x2482F60", Offset = "0x2481B60", VA = "0x182482F60")]
		public ActAutoChessHandbookBondDetailListAdapter()
		{
		}

		// Token: 0x0403ABA0 RID: 240544
		[Token(Token = "0x403ABA0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x0403ABA1 RID: 240545
		[Token(Token = "0x403ABA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0403ABA2 RID: 240546
		[Token(Token = "0x403ABA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403ABA3 RID: 240547
		[Token(Token = "0x403ABA3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007114 RID: 28948
		[Token(Token = "0x2007114")]
		public class ViewHolder
		{
			// Token: 0x0602920B RID: 168459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602920B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403ABA4 RID: 240548
			[Token(Token = "0x403ABA4")]
			[FieldOffset(Offset = "0x10")]
			public ActAutoChessHandbookBondDetailItemView itemView;
		}
	}
}
