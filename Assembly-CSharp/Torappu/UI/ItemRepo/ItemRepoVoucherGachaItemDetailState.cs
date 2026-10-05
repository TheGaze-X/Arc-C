using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E66 RID: 24166
	[Token(Token = "0x2005E66")]
	public class ItemRepoVoucherGachaItemDetailState : PopupFloatState
	{
		// Token: 0x06023043 RID: 143427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023043")]
		[Address(RVA = "0x1D88760", Offset = "0x1D87360", VA = "0x181D88760", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023044 RID: 143428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023044")]
		[Address(RVA = "0x1D88C40", Offset = "0x1D87840", VA = "0x181D88C40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023045 RID: 143429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023045")]
		[Address(RVA = "0x1D88880", Offset = "0x1D87480", VA = "0x181D88880", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023046 RID: 143430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023046")]
		[Address(RVA = "0x1D887C0", Offset = "0x1D873C0", VA = "0x181D887C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06023047 RID: 143431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023047")]
		[Address(RVA = "0x1D88E00", Offset = "0x1D87A00", VA = "0x181D88E00")]
		public ItemRepoVoucherGachaItemDetailState()
		{
		}

		// Token: 0x06023049 RID: 143433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023049")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040303AC RID: 197548
		[Token(Token = "0x40303AC")]
		[FieldOffset(Offset = "0x70")]
		private ItemRepoVoucherGachaItemDetailStateBean m_stateBean;

		// Token: 0x040303AD RID: 197549
		[Token(Token = "0x40303AD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040303AE RID: 197550
		[Token(Token = "0x40303AE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x040303AF RID: 197551
		[Token(Token = "0x40303AF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CancelDragIfFits _cancelDragIfFits;

		// Token: 0x040303B0 RID: 197552
		[Token(Token = "0x40303B0")]
		[FieldOffset(Offset = "0x90")]
		private ItemRepoItemListAdapter m_adapter;

		// Token: 0x040303B1 RID: 197553
		[Token(Token = "0x40303B1")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x040303B2 RID: 197554
		[Token(Token = "0x40303B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040303B3 RID: 197555
		[Token(Token = "0x40303B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040303B4 RID: 197556
		[Token(Token = "0x40303B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040303B5 RID: 197557
		[Token(Token = "0x40303B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x040303B6 RID: 197558
		[Token(Token = "0x40303B6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
