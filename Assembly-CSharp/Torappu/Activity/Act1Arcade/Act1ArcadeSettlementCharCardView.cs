using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200796F RID: 31087
	[Token(Token = "0x200796F")]
	public class Act1ArcadeSettlementCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B9AE RID: 178606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9AE")]
		[Address(RVA = "0x2780060", Offset = "0x277EC60", VA = "0x182780060")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B9AF RID: 178607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9AF")]
		[Address(RVA = "0x277FD10", Offset = "0x277E910", VA = "0x18277FD10")]
		public void OnRender(Act1ArcadeSettlementModel settlementModel)
		{
		}

		// Token: 0x0602B9B0 RID: 178608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9B0")]
		[Address(RVA = "0x2780210", Offset = "0x277EE10", VA = "0x182780210")]
		public Act1ArcadeSettlementCharCardView()
		{
		}

		// Token: 0x0403F14C RID: 258380
		[Token(Token = "0x403F14C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1ArcadeSettlementCharCardItemView _cardItemPrefab;

		// Token: 0x0403F14D RID: 258381
		[Token(Token = "0x403F14D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform[] _squadCardHolders;

		// Token: 0x0403F14E RID: 258382
		[Token(Token = "0x403F14E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _assistCardHolder;

		// Token: 0x0403F14F RID: 258383
		[Token(Token = "0x403F14F")]
		[FieldOffset(Offset = "0x30")]
		private List<Act1ArcadeSettlementCharCardItemView> m_squadCards;

		// Token: 0x0403F150 RID: 258384
		[Token(Token = "0x403F150")]
		[FieldOffset(Offset = "0x38")]
		private Act1ArcadeSettlementCharCardItemView m_assistCard;

		// Token: 0x0403F151 RID: 258385
		[Token(Token = "0x403F151")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403F152 RID: 258386
		[Token(Token = "0x403F152")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F153 RID: 258387
		[Token(Token = "0x403F153")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F154 RID: 258388
		[Token(Token = "0x403F154")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
