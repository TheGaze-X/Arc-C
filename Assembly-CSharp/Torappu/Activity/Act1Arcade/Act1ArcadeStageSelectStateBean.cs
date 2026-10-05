using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007987 RID: 31111
	[Token(Token = "0x2007987")]
	public class Act1ArcadeStageSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602BA64 RID: 178788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA64")]
		[Address(RVA = "0x278CE20", Offset = "0x278BA20", VA = "0x18278CE20")]
		public void LoadData(DataBundle saveInst, bool isFromBattle)
		{
		}

		// Token: 0x0602BA65 RID: 178789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA65")]
		[Address(RVA = "0x278D130", Offset = "0x278BD30", VA = "0x18278D130")]
		public void UpdateData()
		{
		}

		// Token: 0x0602BA66 RID: 178790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA66")]
		[Address(RVA = "0x278D1C0", Offset = "0x278BDC0", VA = "0x18278D1C0")]
		public Act1ArcadeStageSelectStateBean()
		{
		}

		// Token: 0x0403F248 RID: 258632
		[Token(Token = "0x403F248")]
		[FieldOffset(Offset = "0x10")]
		public readonly Act1ArcadeStageSelectProperty property;

		// Token: 0x0403F249 RID: 258633
		[Token(Token = "0x403F249")]
		[FieldOffset(Offset = "0x18")]
		public string selectedZoneIdByEntry;

		// Token: 0x0403F24A RID: 258634
		[Token(Token = "0x403F24A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F24B RID: 258635
		[Token(Token = "0x403F24B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403F24C RID: 258636
		[Token(Token = "0x403F24C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
