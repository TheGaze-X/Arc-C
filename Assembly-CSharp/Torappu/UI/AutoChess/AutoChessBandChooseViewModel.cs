using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.AutoChess.Server;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200629D RID: 25245
	[Token(Token = "0x200629D")]
	public class AutoChessBandChooseViewModel : IHotfixable
	{
		// Token: 0x06024658 RID: 149080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024658")]
		[Address(RVA = "0x1F27970", Offset = "0x1F26570", VA = "0x181F27970")]
		public void LoadData(AutoChessPrepareModel prepareModel)
		{
		}

		// Token: 0x06024659 RID: 149081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024659")]
		[Address(RVA = "0x1F27B90", Offset = "0x1F26790", VA = "0x181F27B90")]
		public void RefreshPlayerData(AutoChessPrepareModel prepareModel)
		{
		}

		// Token: 0x0602465A RID: 149082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602465A")]
		[Address(RVA = "0x1F28400", Offset = "0x1F27000", VA = "0x181F28400")]
		private void _LoadDataFromBandIdRange(AutoChessPrepareModel prepareModel, IEnumerable<string> bandIdRange)
		{
		}

		// Token: 0x0602465B RID: 149083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602465B")]
		[Address(RVA = "0x1F28340", Offset = "0x1F26F40", VA = "0x181F28340")]
		private IEnumerable<string> _GetTrainingBandIdRange(ActAutoChessData actData)
		{
			return null;
		}

		// Token: 0x0602465C RID: 149084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602465C")]
		[Address(RVA = "0x1F281C0", Offset = "0x1F26DC0", VA = "0x181F281C0")]
		private AutoChessBandChooseBandItemModel _GetSelectedBand(MsgStrategyChoice playerChoice, AutoChessBandChooseBandItemModel currSelectedBand, Dictionary<string, AutoChessData.AutoChessBandData> bandDict, ListDict<string, ActAutoChessData.ActAutoChessBandData> actBandDict)
		{
			return null;
		}

		// Token: 0x0602465D RID: 149085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602465D")]
		[Address(RVA = "0x1F28F50", Offset = "0x1F27B50", VA = "0x181F28F50")]
		public AutoChessBandChooseViewModel()
		{
		}

		// Token: 0x04032A45 RID: 207429
		[Token(Token = "0x4032A45")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04032A46 RID: 207430
		[Token(Token = "0x4032A46")]
		[FieldOffset(Offset = "0x18")]
		public bool isSingleMode;

		// Token: 0x04032A47 RID: 207431
		[Token(Token = "0x4032A47")]
		[FieldOffset(Offset = "0x20")]
		public string modeId;

		// Token: 0x04032A48 RID: 207432
		[Token(Token = "0x4032A48")]
		[FieldOffset(Offset = "0x28")]
		public string modeName;

		// Token: 0x04032A49 RID: 207433
		[Token(Token = "0x4032A49")]
		[FieldOffset(Offset = "0x30")]
		public Color modeColor;

		// Token: 0x04032A4A RID: 207434
		[Token(Token = "0x4032A4A")]
		[FieldOffset(Offset = "0x40")]
		public ActAutoChessModeType mode;

		// Token: 0x04032A4B RID: 207435
		[Token(Token = "0x4032A4B")]
		[FieldOffset(Offset = "0x44")]
		public ActAutoChessModeDifficultyType difficulty;

		// Token: 0x04032A4C RID: 207436
		[Token(Token = "0x4032A4C")]
		[FieldOffset(Offset = "0x48")]
		public AutoChessBandChoosePlayerStatus currStatus;

		// Token: 0x04032A4D RID: 207437
		[Token(Token = "0x4032A4D")]
		[FieldOffset(Offset = "0x4C")]
		public bool isSkipDisabled;

		// Token: 0x04032A4E RID: 207438
		[Token(Token = "0x4032A4E")]
		[FieldOffset(Offset = "0x50")]
		public string selectedBand;

		// Token: 0x04032A4F RID: 207439
		[Token(Token = "0x4032A4F")]
		[FieldOffset(Offset = "0x58")]
		public List<AutoChessBandChooseBandItemModel> bandModelList;

		// Token: 0x04032A50 RID: 207440
		[Token(Token = "0x4032A50")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, AutoChessBandChooseBandItemModel> bandModelDict;

		// Token: 0x04032A51 RID: 207441
		[Token(Token = "0x4032A51")]
		[FieldOffset(Offset = "0x68")]
		public ListDict<string, AutoChessBandChoosePlayerModel> playerModelList;

		// Token: 0x04032A52 RID: 207442
		[Token(Token = "0x4032A52")]
		[FieldOffset(Offset = "0x70")]
		public bool isPlayersAllChosen;

		// Token: 0x04032A53 RID: 207443
		[Token(Token = "0x4032A53")]
		[FieldOffset(Offset = "0x78")]
		private string m_selfUid;

		// Token: 0x04032A54 RID: 207444
		[Token(Token = "0x4032A54")]
		[FieldOffset(Offset = "0x80")]
		private List<AutoChessMedalInfoModel> m_medalModelList;

		// Token: 0x04032A55 RID: 207445
		[Token(Token = "0x4032A55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032A56 RID: 207446
		[Token(Token = "0x4032A56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04032A57 RID: 207447
		[Token(Token = "0x4032A57")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadDataFromBandIdRange;

		// Token: 0x04032A58 RID: 207448
		[Token(Token = "0x4032A58")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetTrainingBandIdRange;

		// Token: 0x04032A59 RID: 207449
		[Token(Token = "0x4032A59")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetSelectedBand;

		// Token: 0x04032A5A RID: 207450
		[Token(Token = "0x4032A5A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
