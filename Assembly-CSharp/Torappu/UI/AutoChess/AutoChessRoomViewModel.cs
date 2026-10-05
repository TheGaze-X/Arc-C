using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.AutoChess.Server;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062DF RID: 25311
	[Token(Token = "0x20062DF")]
	public class AutoChessRoomViewModel : IHotfixable
	{
		// Token: 0x060247CD RID: 149453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247CD")]
		[Address(RVA = "0x1F52E80", Offset = "0x1F51A80", VA = "0x181F52E80")]
		public void LoadData(AutoChessPrepareModel prepareModel)
		{
		}

		// Token: 0x060247CE RID: 149454 RVA: 0x000C45F0 File Offset: 0x000C27F0
		[Token(Token = "0x60247CE")]
		[Address(RVA = "0x1F53490", Offset = "0x1F52090", VA = "0x181F53490")]
		public AutoChessRoomViewModel.RefreshDataResult RefreshData(AutoChessPrepareModel prepareModel, List<KeyValuePair<string, string>> leavePlayerNamesBuffer)
		{
			return default(AutoChessRoomViewModel.RefreshDataResult);
		}

		// Token: 0x060247CF RID: 149455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247CF")]
		[Address(RVA = "0x1F53990", Offset = "0x1F52590", VA = "0x181F53990")]
		public void SetCardShowFoldMenu(string uid, bool value)
		{
		}

		// Token: 0x060247D0 RID: 149456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247D0")]
		[Address(RVA = "0x1F52C50", Offset = "0x1F51850", VA = "0x181F52C50")]
		public void ClearCardShowFoldMenu()
		{
		}

		// Token: 0x060247D1 RID: 149457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60247D1")]
		[Address(RVA = "0x1F52DD0", Offset = "0x1F519D0", VA = "0x181F52DD0")]
		public AutoChessRoomPlayerCardViewModel GetPlayerCardViewModelByUID(string uid)
		{
			return null;
		}

		// Token: 0x060247D2 RID: 149458 RVA: 0x000C4608 File Offset: 0x000C2808
		[Token(Token = "0x60247D2")]
		[Address(RVA = "0x1F54040", Offset = "0x1F52C40", VA = "0x181F54040")]
		private AutoChessRoomViewModel.RefreshPlayerModelsResult _RefreshPlayerCardModels(AutoChessPrepareModel prepareModel, AutoChessTeamStatus teamStatus, List<KeyValuePair<string, string>> leavePlayerNamesBuffer)
		{
			return default(AutoChessRoomViewModel.RefreshPlayerModelsResult);
		}

		// Token: 0x060247D3 RID: 149459 RVA: 0x000C4620 File Offset: 0x000C2820
		[Token(Token = "0x60247D3")]
		[Address(RVA = "0x1F52D20", Offset = "0x1F51920", VA = "0x181F52D20")]
		private static int ComparePlayerInfo(MsgAutoChessPlayerStatus l, MsgAutoChessPlayerStatus r)
		{
			return 0;
		}

		// Token: 0x060247D4 RID: 149460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247D4")]
		[Address(RVA = "0x1F53F60", Offset = "0x1F52B60", VA = "0x181F53F60")]
		private void _PreparePositionBuffer(int modelCnt)
		{
		}

		// Token: 0x060247D5 RID: 149461 RVA: 0x000C4638 File Offset: 0x000C2838
		[Token(Token = "0x60247D5")]
		[Address(RVA = "0x1F53E90", Offset = "0x1F52A90", VA = "0x181F53E90")]
		private int _FindAvailPosition(int from)
		{
			return 0;
		}

		// Token: 0x060247D6 RID: 149462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60247D6")]
		[Address(RVA = "0x1F53AA0", Offset = "0x1F526A0", VA = "0x181F53AA0")]
		private string _BuildInvitationFormatText(string actId, AutoChessServiceTeamInfo teamInfo)
		{
			return null;
		}

		// Token: 0x060247D7 RID: 149463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60247D7")]
		[Address(RVA = "0x1F53DA0", Offset = "0x1F529A0", VA = "0x181F53DA0")]
		private string _BuildMatchPlayerCntTip(bool isPrecise, int playerCount, int maxPlayerCnt)
		{
			return null;
		}

		// Token: 0x060247D8 RID: 149464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247D8")]
		[Address(RVA = "0x1F55000", Offset = "0x1F53C00", VA = "0x181F55000")]
		public AutoChessRoomViewModel()
		{
		}

		// Token: 0x04032D3B RID: 208187
		[Token(Token = "0x4032D3B")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04032D3C RID: 208188
		[Token(Token = "0x4032D3C")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessRoomPlayerCardViewModel> playerCardModels;

		// Token: 0x04032D3D RID: 208189
		[Token(Token = "0x4032D3D")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, int> uidToCardModelCacheMap;

		// Token: 0x04032D3E RID: 208190
		[Token(Token = "0x4032D3E")]
		[FieldOffset(Offset = "0x28")]
		public List<ActAutoChessData.ActAutoChessModeData> modeDatas;

		// Token: 0x04032D3F RID: 208191
		[Token(Token = "0x4032D3F")]
		[FieldOffset(Offset = "0x30")]
		public int playerCount;

		// Token: 0x04032D40 RID: 208192
		[Token(Token = "0x4032D40")]
		[FieldOffset(Offset = "0x34")]
		public int maxPlayerCnt;

		// Token: 0x04032D41 RID: 208193
		[Token(Token = "0x4032D41")]
		[FieldOffset(Offset = "0x38")]
		public string matchPlayerCntTip;

		// Token: 0x04032D42 RID: 208194
		[Token(Token = "0x4032D42")]
		[FieldOffset(Offset = "0x40")]
		public string invitationFormatText;

		// Token: 0x04032D43 RID: 208195
		[Token(Token = "0x4032D43")]
		[FieldOffset(Offset = "0x48")]
		public string roomId;

		// Token: 0x04032D44 RID: 208196
		[Token(Token = "0x4032D44")]
		[FieldOffset(Offset = "0x50")]
		public string modeId;

		// Token: 0x04032D45 RID: 208197
		[Token(Token = "0x4032D45")]
		[FieldOffset(Offset = "0x58")]
		public bool showFullRoomTip;

		// Token: 0x04032D46 RID: 208198
		[Token(Token = "0x4032D46")]
		[FieldOffset(Offset = "0x59")]
		public bool showModeSwitchBtn;

		// Token: 0x04032D47 RID: 208199
		[Token(Token = "0x4032D47")]
		[FieldOffset(Offset = "0x5A")]
		public bool showRoomId;

		// Token: 0x04032D48 RID: 208200
		[Token(Token = "0x4032D48")]
		[FieldOffset(Offset = "0x5B")]
		public bool isPrecise;

		// Token: 0x04032D49 RID: 208201
		[Token(Token = "0x4032D49")]
		[FieldOffset(Offset = "0x5C")]
		public bool matchFlag;

		// Token: 0x04032D4A RID: 208202
		[Token(Token = "0x4032D4A")]
		[FieldOffset(Offset = "0x5D")]
		public bool isSelfReady;

		// Token: 0x04032D4B RID: 208203
		[Token(Token = "0x4032D4B")]
		[FieldOffset(Offset = "0x5E")]
		public bool isSelfHost;

		// Token: 0x04032D4C RID: 208204
		[Token(Token = "0x4032D4C")]
		[FieldOffset(Offset = "0x5F")]
		public bool isRangeAvailable;

		// Token: 0x04032D4D RID: 208205
		[Token(Token = "0x4032D4D")]
		[FieldOffset(Offset = "0x60")]
		public AutoChessRoomViewModel.ReadyButtonState readyButtonState;

		// Token: 0x04032D4E RID: 208206
		[Token(Token = "0x4032D4E")]
		[FieldOffset(Offset = "0x68")]
		public string selfUID;

		// Token: 0x04032D4F RID: 208207
		[Token(Token = "0x4032D4F")]
		[FieldOffset(Offset = "0x70")]
		public AutoChessModeChoiceViewModel modeChoiceViewModel;

		// Token: 0x04032D50 RID: 208208
		[Token(Token = "0x4032D50")]
		[FieldOffset(Offset = "0x78")]
		public ActAutoChessModeDifficultyType difficultyType;

		// Token: 0x04032D51 RID: 208209
		[Token(Token = "0x4032D51")]
		[FieldOffset(Offset = "0x80")]
		private bool[] m_unavailPositionBuffer;

		// Token: 0x04032D52 RID: 208210
		[Token(Token = "0x4032D52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032D53 RID: 208211
		[Token(Token = "0x4032D53")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04032D54 RID: 208212
		[Token(Token = "0x4032D54")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCardShowFoldMenu;

		// Token: 0x04032D55 RID: 208213
		[Token(Token = "0x4032D55")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ClearCardShowFoldMenu;

		// Token: 0x04032D56 RID: 208214
		[Token(Token = "0x4032D56")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPlayerCardViewModelByUID;

		// Token: 0x04032D57 RID: 208215
		[Token(Token = "0x4032D57")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshPlayerCardModels;

		// Token: 0x04032D58 RID: 208216
		[Token(Token = "0x4032D58")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ComparePlayerInfo;

		// Token: 0x04032D59 RID: 208217
		[Token(Token = "0x4032D59")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PreparePositionBuffer;

		// Token: 0x04032D5A RID: 208218
		[Token(Token = "0x4032D5A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FindAvailPosition;

		// Token: 0x04032D5B RID: 208219
		[Token(Token = "0x4032D5B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__BuildInvitationFormatText;

		// Token: 0x04032D5C RID: 208220
		[Token(Token = "0x4032D5C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__BuildMatchPlayerCntTip;

		// Token: 0x04032D5D RID: 208221
		[Token(Token = "0x4032D5D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062E0 RID: 25312
		[Token(Token = "0x20062E0")]
		public enum ReadyButtonState
		{
			// Token: 0x04032D5F RID: 208223
			[Token(Token = "0x4032D5F")]
			READY,
			// Token: 0x04032D60 RID: 208224
			[Token(Token = "0x4032D60")]
			CANCEL_READY,
			// Token: 0x04032D61 RID: 208225
			[Token(Token = "0x4032D61")]
			UNAVAIL_START_MATCH,
			// Token: 0x04032D62 RID: 208226
			[Token(Token = "0x4032D62")]
			START_MATCH,
			// Token: 0x04032D63 RID: 208227
			[Token(Token = "0x4032D63")]
			UNAVAIL_START_GAME,
			// Token: 0x04032D64 RID: 208228
			[Token(Token = "0x4032D64")]
			START_GAME
		}

		// Token: 0x020062E1 RID: 25313
		[Token(Token = "0x20062E1")]
		public struct RefreshDataResult
		{
			// Token: 0x04032D65 RID: 208229
			[Token(Token = "0x4032D65")]
			[FieldOffset(Offset = "0x0")]
			public int newPlayerCnt;

			// Token: 0x04032D66 RID: 208230
			[Token(Token = "0x4032D66")]
			[FieldOffset(Offset = "0x4")]
			public bool needNotifyModeChanged;
		}

		// Token: 0x020062E2 RID: 25314
		[Token(Token = "0x20062E2")]
		private struct RefreshPlayerModelsResult
		{
			// Token: 0x04032D67 RID: 208231
			[Token(Token = "0x4032D67")]
			[FieldOffset(Offset = "0x0")]
			public int playerCount;

			// Token: 0x04032D68 RID: 208232
			[Token(Token = "0x4032D68")]
			[FieldOffset(Offset = "0x8")]
			public MsgAutoChessPlayerStatus selfStatus;

			// Token: 0x04032D69 RID: 208233
			[Token(Token = "0x4032D69")]
			[FieldOffset(Offset = "0x10")]
			public bool isSelfReady;

			// Token: 0x04032D6A RID: 208234
			[Token(Token = "0x4032D6A")]
			[FieldOffset(Offset = "0x11")]
			public bool isAllPlayerReady;

			// Token: 0x04032D6B RID: 208235
			[Token(Token = "0x4032D6B")]
			[FieldOffset(Offset = "0x14")]
			public int newPlayerCnt;
		}
	}
}
