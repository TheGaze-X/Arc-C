using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075F9 RID: 30201
	[Token(Token = "0x20075F9")]
	public class Act24sideMissionRewardViewModel : IHotfixable
	{
		// Token: 0x0602A855 RID: 174165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A855")]
		[Address(RVA = "0x262A340", Offset = "0x2628F40", VA = "0x18262A340")]
		public void LoadData(string actId, List<UIItemViewModel> rewardList)
		{
		}

		// Token: 0x0602A856 RID: 174166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A856")]
		[Address(RVA = "0x262A5E0", Offset = "0x26291E0", VA = "0x18262A5E0")]
		public Act24sideMissionRewardViewModel()
		{
		}

		// Token: 0x0403D353 RID: 250707
		[Token(Token = "0x403D353")]
		[FieldOffset(Offset = "0x10")]
		public List<UIItemViewModel> normalItemList;

		// Token: 0x0403D354 RID: 250708
		[Token(Token = "0x403D354")]
		[FieldOffset(Offset = "0x18")]
		public List<Act24sideMeldingItemViewModel> actItemList;

		// Token: 0x0403D355 RID: 250709
		[Token(Token = "0x403D355")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D356 RID: 250710
		[Token(Token = "0x403D356")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
