using System;
using Il2CppDummyDll;
using Torappu.UI.BattleFinish;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200756A RID: 30058
	[Token(Token = "0x200756A")]
	public class Act24sideBattleInfoViewModel : BattleInfoViewModel, IHotfixable
	{
		// Token: 0x0602A525 RID: 173349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A525")]
		[Address(RVA = "0x25F5FC0", Offset = "0x25F4BC0", VA = "0x1825F5FC0")]
		public Act24sideBattleInfoViewModel()
		{
		}

		// Token: 0x0403CDB8 RID: 249272
		[Token(Token = "0x403CDB8")]
		[FieldOffset(Offset = "0x40")]
		public string stageId;

		// Token: 0x0403CDB9 RID: 249273
		[Token(Token = "0x403CDB9")]
		[FieldOffset(Offset = "0x48")]
		public bool isQuestStage;

		// Token: 0x0403CDBA RID: 249274
		[Token(Token = "0x403CDBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
