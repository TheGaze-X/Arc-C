using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007188 RID: 29064
	[Token(Token = "0x2007188")]
	public class Act9D0SubMissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602940F RID: 168975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602940F")]
		[Address(RVA = "0x24A57F0", Offset = "0x24A43F0", VA = "0x1824A57F0")]
		public Act9D0SubMissionStateBean()
		{
		}

		// Token: 0x0403AEB8 RID: 241336
		[Token(Token = "0x403AEB8")]
		[FieldOffset(Offset = "0x10")]
		public SubMissionViewModel subMissionViewModel;

		// Token: 0x0403AEB9 RID: 241337
		[Token(Token = "0x403AEB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
