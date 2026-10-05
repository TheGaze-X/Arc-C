using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C59 RID: 7257
	[Token(Token = "0x2001C59")]
	public class StationSelectConfirmStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B486 RID: 46214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B486")]
		[Address(RVA = "0x32FC630", Offset = "0x32FB230", VA = "0x1832FC630")]
		public void LoadInput()
		{
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B487")]
		[Address(RVA = "0x32FC8A0", Offset = "0x32FB4A0", VA = "0x1832FC8A0")]
		public StationSelectConfirmStateBean()
		{
		}

		// Token: 0x0400B04E RID: 45134
		[Token(Token = "0x400B04E")]
		[FieldOffset(Offset = "0x10")]
		public StationConfirmModel stateInput;

		// Token: 0x0400B04F RID: 45135
		[Token(Token = "0x400B04F")]
		[FieldOffset(Offset = "0x18")]
		public List<ChangedRoomGroupProperty> changedRoomGroupProperty;

		// Token: 0x0400B050 RID: 45136
		[Token(Token = "0x400B050")]
		[FieldOffset(Offset = "0x20")]
		public bool isConfirm;

		// Token: 0x0400B051 RID: 45137
		[Token(Token = "0x400B051")]
		[FieldOffset(Offset = "0x28")]
		public StationSelectConfirmCharProperty selectConfirmProperty;

		// Token: 0x0400B052 RID: 45138
		[Token(Token = "0x400B052")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadInput;

		// Token: 0x0400B053 RID: 45139
		[Token(Token = "0x400B053")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
