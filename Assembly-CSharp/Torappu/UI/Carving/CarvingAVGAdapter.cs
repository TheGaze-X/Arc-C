using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006030 RID: 24624
	[Token(Token = "0x2006030")]
	public class CarvingAVGAdapter : ExecutorComponent, IHotfixable
	{
		// Token: 0x060239BE RID: 145854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60239BE")]
		[Address(RVA = "0x1E3F230", Offset = "0x1E3DE30", VA = "0x181E3F230", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x060239BF RID: 145855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239BF")]
		[Address(RVA = "0x1E3F1D0", Offset = "0x1E3DDD0", VA = "0x181E3F1D0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x060239C0 RID: 145856 RVA: 0x000C1560 File Offset: 0x000BF760
		[Token(Token = "0x60239C0")]
		[Address(RVA = "0x1E3F480", Offset = "0x1E3E080", VA = "0x181E3F480")]
		private bool _OnFocusBuyCard(Command command)
		{
			return default(bool);
		}

		// Token: 0x060239C1 RID: 145857 RVA: 0x000C1578 File Offset: 0x000BF778
		[Token(Token = "0x60239C1")]
		[Address(RVA = "0x1E3F660", Offset = "0x1E3E260", VA = "0x181E3F660")]
		private bool _OnSelectHandCard(Command command)
		{
			return default(bool);
		}

		// Token: 0x060239C2 RID: 145858 RVA: 0x000C1590 File Offset: 0x000BF790
		[Token(Token = "0x60239C2")]
		[Address(RVA = "0x1E3F5C0", Offset = "0x1E3E1C0", VA = "0x181E3F5C0")]
		private bool _OnSelectCardSlot(Command command)
		{
			return default(bool);
		}

		// Token: 0x060239C3 RID: 145859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239C3")]
		[Address(RVA = "0x1E3F7A0", Offset = "0x1E3E3A0", VA = "0x181E3F7A0")]
		public CarvingAVGAdapter()
		{
		}

		// Token: 0x040314CD RID: 201933
		[Token(Token = "0x40314CD")]
		private const string PARAM_FOCUS_BUY_CARD_POSITION = "position";

		// Token: 0x040314CE RID: 201934
		[Token(Token = "0x40314CE")]
		private const string PARAM_SELECT_HAND_CARD_ID = "cardId";

		// Token: 0x040314CF RID: 201935
		[Token(Token = "0x40314CF")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040314D0 RID: 201936
		[Token(Token = "0x40314D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x040314D1 RID: 201937
		[Token(Token = "0x40314D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x040314D2 RID: 201938
		[Token(Token = "0x40314D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnFocusBuyCard;

		// Token: 0x040314D3 RID: 201939
		[Token(Token = "0x40314D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSelectHandCard;

		// Token: 0x040314D4 RID: 201940
		[Token(Token = "0x40314D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSelectCardSlot;

		// Token: 0x040314D5 RID: 201941
		[Token(Token = "0x40314D5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
