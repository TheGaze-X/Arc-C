using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007247 RID: 29255
	[Token(Token = "0x2007247")]
	public class Act5D1RuneUnlockStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602975B RID: 169819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602975B")]
		[Address(RVA = "0x24D0020", Offset = "0x24CEC20", VA = "0x1824D0020")]
		public Act5D1RuneUnlockStateBean()
		{
		}

		// Token: 0x0403B3BE RID: 242622
		[Token(Token = "0x403B3BE")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x0403B3BF RID: 242623
		[Token(Token = "0x403B3BF")]
		[FieldOffset(Offset = "0x18")]
		public string runeId;

		// Token: 0x0403B3C0 RID: 242624
		[Token(Token = "0x403B3C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
