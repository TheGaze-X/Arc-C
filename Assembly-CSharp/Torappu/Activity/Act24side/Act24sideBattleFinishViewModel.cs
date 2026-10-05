using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.BattleFinish;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007569 RID: 30057
	[Token(Token = "0x2007569")]
	public class Act24sideBattleFinishViewModel : IHotfixable
	{
		// Token: 0x0602A523 RID: 173347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A523")]
		[Address(RVA = "0x25F48D0", Offset = "0x25F34D0", VA = "0x1825F48D0")]
		public void LoadData(string actId, Act24sideBattleFinishResponse response)
		{
		}

		// Token: 0x0602A524 RID: 173348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A524")]
		[Address(RVA = "0x25F54B0", Offset = "0x25F40B0", VA = "0x1825F54B0")]
		public Act24sideBattleFinishViewModel()
		{
		}

		// Token: 0x0403CDB2 RID: 249266
		[Token(Token = "0x403CDB2")]
		[FieldOffset(Offset = "0x10")]
		public Act24sideBattleInfoViewModel battleInfoModel;

		// Token: 0x0403CDB3 RID: 249267
		[Token(Token = "0x403CDB3")]
		[FieldOffset(Offset = "0x18")]
		public DropInfoGroupViewModel dropInfoModel;

		// Token: 0x0403CDB4 RID: 249268
		[Token(Token = "0x403CDB4")]
		[FieldOffset(Offset = "0x20")]
		public Act24sideBattleFinishMeldingDropViewModel meldingDropInfoModel;

		// Token: 0x0403CDB5 RID: 249269
		[Token(Token = "0x403CDB5")]
		[FieldOffset(Offset = "0x28")]
		public UIExpBarController.ControlModel expBarControlModel;

		// Token: 0x0403CDB6 RID: 249270
		[Token(Token = "0x403CDB6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CDB7 RID: 249271
		[Token(Token = "0x403CDB7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
