using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A13 RID: 31251
	[Token(Token = "0x2007A13")]
	public class Act13sideDailyMissionViewModel : IHotfixable
	{
		// Token: 0x170066AD RID: 26285
		// (get) Token: 0x0602BCDF RID: 179423 RVA: 0x000DD3E8 File Offset: 0x000DB5E8
		[Token(Token = "0x170066AD")]
		public int agenda
		{
			[Token(Token = "0x602BCDF")]
			[Address(RVA = "0x27B44E0", Offset = "0x27B30E0", VA = "0x1827B44E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602BCE0 RID: 179424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCE0")]
		[Address(RVA = "0x27B41D0", Offset = "0x27B2DD0", VA = "0x1827B41D0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602BCE1 RID: 179425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCE1")]
		[Address(RVA = "0x27B4430", Offset = "0x27B3030", VA = "0x1827B4430")]
		public Act13sideDailyMissionViewModel()
		{
		}

		// Token: 0x0403F613 RID: 259603
		[Token(Token = "0x403F613")]
		[FieldOffset(Offset = "0x10")]
		private PlayerActivity.PlayerAct13sideActivity m_playerData;

		// Token: 0x0403F614 RID: 259604
		[Token(Token = "0x403F614")]
		[FieldOffset(Offset = "0x18")]
		public List<Act13sideDailyMissionItemViewModel> missionItemList;

		// Token: 0x0403F615 RID: 259605
		[Token(Token = "0x403F615")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_agenda;

		// Token: 0x0403F616 RID: 259606
		[Token(Token = "0x403F616")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F617 RID: 259607
		[Token(Token = "0x403F617")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
