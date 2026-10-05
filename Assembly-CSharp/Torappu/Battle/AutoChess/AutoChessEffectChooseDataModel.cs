using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200277D RID: 10109
	[Token(Token = "0x200277D")]
	public class AutoChessEffectChooseDataModel : AutoChessDataCenter.AutoChessDataModelBase
	{
		// Token: 0x06010803 RID: 67587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010803")]
		[Address(RVA = "0x84C5D0", Offset = "0x84B1D0", VA = "0x18084C5D0")]
		public void UpdateData(NChooseOneStateData data)
		{
		}

		// Token: 0x06010804 RID: 67588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010804")]
		[Address(RVA = "0x84C450", Offset = "0x84B050", VA = "0x18084C450")]
		public void UpdateData(SelfChooseStateData data)
		{
		}

		// Token: 0x06010805 RID: 67589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010805")]
		[Address(RVA = "0x84C780", Offset = "0x84B380", VA = "0x18084C780")]
		public AutoChessEffectChooseDataModel()
		{
		}

		// Token: 0x040127F9 RID: 75769
		[Token(Token = "0x40127F9")]
		[FieldOffset(Offset = "0x18")]
		public string choiceId;

		// Token: 0x040127FA RID: 75770
		[Token(Token = "0x40127FA")]
		[FieldOffset(Offset = "0x20")]
		public AutoChessEffectChooseDataModel.AutoChessBattleEffectChooseMode choiceMode;

		// Token: 0x040127FB RID: 75771
		[Token(Token = "0x40127FB")]
		[FieldOffset(Offset = "0x28")]
		public List<ChooseStateSlot> options;

		// Token: 0x040127FC RID: 75772
		[Token(Token = "0x40127FC")]
		[FieldOffset(Offset = "0x30")]
		public List<NChooseOneStateData.PlayerChoice> playerQueue;

		// Token: 0x040127FD RID: 75773
		[Token(Token = "0x40127FD")]
		[FieldOffset(Offset = "0x38")]
		public long finTs;

		// Token: 0x040127FE RID: 75774
		[Token(Token = "0x40127FE")]
		[FieldOffset(Offset = "0x40")]
		public int currQueueIndex;

		// Token: 0x040127FF RID: 75775
		[Token(Token = "0x40127FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04012800 RID: 75776
		[Token(Token = "0x4012800")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_UpdateData;

		// Token: 0x04012801 RID: 75777
		[Token(Token = "0x4012801")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200277E RID: 10110
		[Token(Token = "0x200277E")]
		public enum AutoChessBattleEffectChooseMode
		{
			// Token: 0x04012803 RID: 75779
			[Token(Token = "0x4012803")]
			SP_PREPARE,
			// Token: 0x04012804 RID: 75780
			[Token(Token = "0x4012804")]
			MAGIC_SELECT
		}
	}
}
