using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061FD RID: 25085
	[Token(Token = "0x20061FD")]
	public class HandBookDropInfoViewModel : IHotfixable
	{
		// Token: 0x0602432B RID: 148267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602432B")]
		[Address(RVA = "0x1EE47F0", Offset = "0x1EE33F0", VA = "0x181EE47F0")]
		public void LoadData(CommonFinishBattleResponse response)
		{
		}

		// Token: 0x0602432C RID: 148268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602432C")]
		[Address(RVA = "0x1EE4BE0", Offset = "0x1EE37E0", VA = "0x181EE4BE0")]
		public HandBookDropInfoViewModel()
		{
		}

		// Token: 0x0403251D RID: 206109
		[Token(Token = "0x403251D")]
		[FieldOffset(Offset = "0x10")]
		public List<DropInfoViewModel> dropItems;

		// Token: 0x0403251E RID: 206110
		[Token(Token = "0x403251E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403251F RID: 206111
		[Token(Token = "0x403251F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
