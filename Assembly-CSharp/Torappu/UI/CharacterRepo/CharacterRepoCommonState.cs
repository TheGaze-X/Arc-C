using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E2B RID: 24107
	[Token(Token = "0x2005E2B")]
	public abstract class CharacterRepoCommonState : State
	{
		// Token: 0x06022EE9 RID: 143081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022EE9")]
		[Address(RVA = "0x1D78E50", Offset = "0x1D77A50", VA = "0x181D78E50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022EEA RID: 143082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022EEA")]
		[Address(RVA = "0x1D78EB0", Offset = "0x1D77AB0", VA = "0x181D78EB0")]
		public List<int> LoadCardList()
		{
			return null;
		}

		// Token: 0x06022EEB RID: 143083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EEB")]
		[Address(RVA = "0x1D79070", Offset = "0x1D77C70", VA = "0x181D79070")]
		public void NotifySortTypeChanged(CharacterSortType sortType)
		{
		}

		// Token: 0x06022EEC RID: 143084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EEC")]
		[Address(RVA = "0x1D79210", Offset = "0x1D77E10", VA = "0x181D79210")]
		public void NotifyTrackPointFilterChanged()
		{
		}

		// Token: 0x06022EED RID: 143085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EED")]
		[Address(RVA = "0x1D790F0", Offset = "0x1D77CF0", VA = "0x181D790F0")]
		public void NotifyStarMarkToggleChanged()
		{
		}

		// Token: 0x06022EEE RID: 143086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EEE")]
		[Address(RVA = "0x1D79320", Offset = "0x1D77F20", VA = "0x181D79320")]
		protected CharacterRepoCommonState()
		{
		}

		// Token: 0x040301EB RID: 197099
		[Token(Token = "0x40301EB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected CharacterRepoStateBean _stateBean;

		// Token: 0x040301EC RID: 197100
		[Token(Token = "0x40301EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040301ED RID: 197101
		[Token(Token = "0x40301ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadCardList;

		// Token: 0x040301EE RID: 197102
		[Token(Token = "0x40301EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifySortTypeChanged;

		// Token: 0x040301EF RID: 197103
		[Token(Token = "0x40301EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifyTrackPointFilterChanged;

		// Token: 0x040301F0 RID: 197104
		[Token(Token = "0x40301F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyStarMarkToggleChanged;

		// Token: 0x040301F1 RID: 197105
		[Token(Token = "0x40301F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
