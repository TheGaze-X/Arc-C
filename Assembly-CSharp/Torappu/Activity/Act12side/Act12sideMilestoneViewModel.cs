using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act12side
{
	// Token: 0x02007A62 RID: 31330
	[Token(Token = "0x2007A62")]
	public class Act12sideMilestoneViewModel : IHotfixable
	{
		// Token: 0x170066DA RID: 26330
		// (get) Token: 0x0602BE1A RID: 179738 RVA: 0x000DD868 File Offset: 0x000DBA68
		[Token(Token = "0x170066DA")]
		public bool hasMilestoneReward
		{
			[Token(Token = "0x602BE1A")]
			[Address(RVA = "0x27C23D0", Offset = "0x27C0FD0", VA = "0x1827C23D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BE1B RID: 179739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE1B")]
		[Address(RVA = "0x27C2320", Offset = "0x27C0F20", VA = "0x1827C2320")]
		public Act12sideMilestoneViewModel()
		{
		}

		// Token: 0x0403F8D6 RID: 260310
		[Token(Token = "0x403F8D6")]
		[FieldOffset(Offset = "0x10")]
		public int milestonePoint;

		// Token: 0x0403F8D7 RID: 260311
		[Token(Token = "0x403F8D7")]
		[FieldOffset(Offset = "0x18")]
		public List<Act12sideMilestoneItemModel> milestoneItemList;

		// Token: 0x0403F8D8 RID: 260312
		[Token(Token = "0x403F8D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasMilestoneReward;

		// Token: 0x0403F8D9 RID: 260313
		[Token(Token = "0x403F8D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
