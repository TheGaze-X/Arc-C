using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200769D RID: 30365
	[Token(Token = "0x200769D")]
	public class Act20sideMilestoneStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602AB38 RID: 174904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB38")]
		[Address(RVA = "0x2677210", Offset = "0x2675E10", VA = "0x182677210")]
		public Act20sideMilestoneStateBean()
		{
		}

		// Token: 0x0403D885 RID: 252037
		[Token(Token = "0x403D885")]
		[FieldOffset(Offset = "0x10")]
		public Act20sideMilestoneViewModel viewModel;

		// Token: 0x0403D886 RID: 252038
		[Token(Token = "0x403D886")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x0403D887 RID: 252039
		[Token(Token = "0x403D887")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
