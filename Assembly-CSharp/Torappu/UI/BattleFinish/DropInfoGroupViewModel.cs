using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061FC RID: 25084
	[Token(Token = "0x20061FC")]
	public class DropInfoGroupViewModel
	{
		// Token: 0x06024327 RID: 148263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024327")]
		[Address(RVA = "0x1EE4030", Offset = "0x1EE2C30", VA = "0x181EE4030")]
		public void LoadData(CommonFinishBattleResponse response)
		{
		}

		// Token: 0x06024328 RID: 148264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024328")]
		[Address(RVA = "0x1EE3E90", Offset = "0x1EE2A90", VA = "0x181EE3E90")]
		public void LoadData(PryResult dropResult)
		{
		}

		// Token: 0x06024329 RID: 148265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024329")]
		[Address(RVA = "0x1EE43F0", Offset = "0x1EE2FF0", VA = "0x181EE43F0")]
		private void _BatchServiceItems(List<CommonFinishBattleResponse.RewardModel> serviceItems, List<DropInfoViewModel> resultList, StageDropType dropTypeInput)
		{
		}

		// Token: 0x0602432A RID: 148266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602432A")]
		[Address(RVA = "0x1EE4760", Offset = "0x1EE3360", VA = "0x181EE4760")]
		public DropInfoGroupViewModel()
		{
		}

		// Token: 0x04032517 RID: 206103
		[Token(Token = "0x4032517")]
		[FieldOffset(Offset = "0x10")]
		public StageDiffGroup difficulty;

		// Token: 0x04032518 RID: 206104
		[Token(Token = "0x4032518")]
		[FieldOffset(Offset = "0x18")]
		public List<DropInfoViewModel> dropItems;

		// Token: 0x04032519 RID: 206105
		[Token(Token = "0x4032519")]
		[FieldOffset(Offset = "0x20")]
		public PlayerBattleRank rank;

		// Token: 0x0403251A RID: 206106
		[Token(Token = "0x403251A")]
		[FieldOffset(Offset = "0x24")]
		public float goldRate;

		// Token: 0x0403251B RID: 206107
		[Token(Token = "0x403251B")]
		[FieldOffset(Offset = "0x28")]
		public float expRate;

		// Token: 0x0403251C RID: 206108
		[Token(Token = "0x403251C")]
		[FieldOffset(Offset = "0x2C")]
		public bool isMultipleBattle;
	}
}
