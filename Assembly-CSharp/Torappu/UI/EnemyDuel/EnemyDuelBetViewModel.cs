using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FD9 RID: 20441
	[Token(Token = "0x2004FD9")]
	public class EnemyDuelBetViewModel : IHotfixable
	{
		// Token: 0x0601E598 RID: 124312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E598")]
		[Address(RVA = "0x1814CB0", Offset = "0x18138B0", VA = "0x181814CB0")]
		public void LoadData()
		{
		}

		// Token: 0x0601E599 RID: 124313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E599")]
		[Address(RVA = "0x1815810", Offset = "0x1814410", VA = "0x181815810")]
		public void UpdateData()
		{
		}

		// Token: 0x0601E59A RID: 124314 RVA: 0x000AE3A8 File Offset: 0x000AC5A8
		[Token(Token = "0x601E59A")]
		[Address(RVA = "0x1815E10", Offset = "0x1814A10", VA = "0x181815E10")]
		private EnemyDuelBetSelectStatus _GetSelectStatus(EnemyDuelChoiceSide choiceSide, EnemyDuelChoiceType choiceType)
		{
			return EnemyDuelBetSelectStatus.NONE;
		}

		// Token: 0x0601E59B RID: 124315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E59B")]
		[Address(RVA = "0x1814B80", Offset = "0x1813780", VA = "0x181814B80")]
		public EnemyDuelBetParams GenerateBetParams(EnemyDuelBetSelectStatus status)
		{
			return null;
		}

		// Token: 0x0601E59C RID: 124316 RVA: 0x000AE3C0 File Offset: 0x000AC5C0
		[Token(Token = "0x601E59C")]
		[Address(RVA = "0x1814910", Offset = "0x1813510", VA = "0x181814910")]
		public bool CanSelect(EnemyDuelBetSelectStatus status)
		{
			return default(bool);
		}

		// Token: 0x0601E59D RID: 124317 RVA: 0x000AE3D8 File Offset: 0x000AC5D8
		[Token(Token = "0x601E59D")]
		[Address(RVA = "0x1815710", Offset = "0x1814310", VA = "0x181815710")]
		public bool SetEnemyDetailPanelShowStatus(bool isShow)
		{
			return default(bool);
		}

		// Token: 0x0601E59E RID: 124318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E59E")]
		[Address(RVA = "0x18157A0", Offset = "0x18143A0", VA = "0x1818157A0")]
		public void ToggleEnemyDetailPanelShowStatus()
		{
		}

		// Token: 0x0601E59F RID: 124319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E59F")]
		[Address(RVA = "0x1815690", Offset = "0x1814290", VA = "0x181815690")]
		public void SetEmoticonDisabledStatus(bool isEmoticonDisabled)
		{
		}

		// Token: 0x0601E5A0 RID: 124320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5A0")]
		[Address(RVA = "0x1815260", Offset = "0x1813E60", VA = "0x181815260")]
		public void RefreshPlayerList()
		{
		}

		// Token: 0x0601E5A1 RID: 124321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5A1")]
		[Address(RVA = "0x1814AC0", Offset = "0x18136C0", VA = "0x181814AC0")]
		public void ClearPlayerList()
		{
		}

		// Token: 0x0601E5A2 RID: 124322 RVA: 0x000AE3F0 File Offset: 0x000AC5F0
		[Token(Token = "0x601E5A2")]
		[Address(RVA = "0x1815F10", Offset = "0x1814B10", VA = "0x181815F10")]
		private int _SortPlayerListByBetTs(EnemyDuelBetPlayerViewModel lhs, EnemyDuelBetPlayerViewModel rhs)
		{
			return 0;
		}

		// Token: 0x0601E5A3 RID: 124323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5A3")]
		[Address(RVA = "0x1815C40", Offset = "0x1814840", VA = "0x181815C40")]
		private void _CalculatePlayerRank()
		{
		}

		// Token: 0x0601E5A4 RID: 124324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E5A4")]
		[Address(RVA = "0x1816030", Offset = "0x1814C30", VA = "0x181816030")]
		public EnemyDuelBetViewModel()
		{
		}

		// Token: 0x04028932 RID: 166194
		[Token(Token = "0x4028932")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04028933 RID: 166195
		[Token(Token = "0x4028933")]
		[FieldOffset(Offset = "0x18")]
		public EnemyDuelModeType modeType;

		// Token: 0x04028934 RID: 166196
		[Token(Token = "0x4028934")]
		[FieldOffset(Offset = "0x1C")]
		public int currRoundNum;

		// Token: 0x04028935 RID: 166197
		[Token(Token = "0x4028935")]
		[FieldOffset(Offset = "0x20")]
		public int boomFxRoundNum;

		// Token: 0x04028936 RID: 166198
		[Token(Token = "0x4028936")]
		[FieldOffset(Offset = "0x24")]
		public bool canSkip;

		// Token: 0x04028937 RID: 166199
		[Token(Token = "0x4028937")]
		[FieldOffset(Offset = "0x28")]
		public int totalBetTime;

		// Token: 0x04028938 RID: 166200
		[Token(Token = "0x4028938")]
		[FieldOffset(Offset = "0x2C")]
		public int privateBetTime;

		// Token: 0x04028939 RID: 166201
		[Token(Token = "0x4028939")]
		[FieldOffset(Offset = "0x30")]
		public int minWinStreakCount;

		// Token: 0x0402893A RID: 166202
		[Token(Token = "0x402893A")]
		[FieldOffset(Offset = "0x38")]
		public EnemyDuelTopBarViewModel topBarViewModel;

		// Token: 0x0402893B RID: 166203
		[Token(Token = "0x402893B")]
		[FieldOffset(Offset = "0x40")]
		public string selfPlayerId;

		// Token: 0x0402893C RID: 166204
		[Token(Token = "0x402893C")]
		[FieldOffset(Offset = "0x48")]
		public EnemyDuelOperationModeViewModel operationModeViewModel;

		// Token: 0x0402893D RID: 166205
		[Token(Token = "0x402893D")]
		[FieldOffset(Offset = "0x50")]
		public EnemyDuelStandModeViewModel standModeViewModel;

		// Token: 0x0402893E RID: 166206
		[Token(Token = "0x402893E")]
		[FieldOffset(Offset = "0x58")]
		public List<EnemyDuelBetPlayerViewModel> playerList;

		// Token: 0x0402893F RID: 166207
		[Token(Token = "0x402893F")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, EnemyDuelBetPlayerViewModel> playerDict;

		// Token: 0x04028940 RID: 166208
		[Token(Token = "0x4028940")]
		[FieldOffset(Offset = "0x68")]
		public List<EnemyDuelBetPlayerViewModel> playerListLeft;

		// Token: 0x04028941 RID: 166209
		[Token(Token = "0x4028941")]
		[FieldOffset(Offset = "0x70")]
		public List<EnemyDuelBetPlayerViewModel> playerListRight;

		// Token: 0x04028942 RID: 166210
		[Token(Token = "0x4028942")]
		[FieldOffset(Offset = "0x78")]
		public List<EnemyDuelBetEnemyViewModel> enemyListLeft;

		// Token: 0x04028943 RID: 166211
		[Token(Token = "0x4028943")]
		[FieldOffset(Offset = "0x80")]
		public List<EnemyDuelBetEnemyViewModel> enemyListRight;

		// Token: 0x04028944 RID: 166212
		[Token(Token = "0x4028944")]
		[FieldOffset(Offset = "0x88")]
		public long betEndTs;

		// Token: 0x04028945 RID: 166213
		[Token(Token = "0x4028945")]
		[FieldOffset(Offset = "0x90")]
		public bool isSurvive;

		// Token: 0x04028946 RID: 166214
		[Token(Token = "0x4028946")]
		[FieldOffset(Offset = "0x94")]
		public EnemyDuelBetSelectStatus selectStatus;

		// Token: 0x04028947 RID: 166215
		[Token(Token = "0x4028947")]
		[FieldOffset(Offset = "0x98")]
		public bool showEnemyDetailPanel;

		// Token: 0x04028948 RID: 166216
		[Token(Token = "0x4028948")]
		[FieldOffset(Offset = "0x9C")]
		public int totalPlayerCount;

		// Token: 0x04028949 RID: 166217
		[Token(Token = "0x4028949")]
		[FieldOffset(Offset = "0xA0")]
		public int survivePlayerCount;

		// Token: 0x0402894A RID: 166218
		[Token(Token = "0x402894A")]
		[FieldOffset(Offset = "0xA8")]
		public string defaultEnemyTag;

		// Token: 0x0402894B RID: 166219
		[Token(Token = "0x402894B")]
		[FieldOffset(Offset = "0xB0")]
		public int loadSeqNum;

		// Token: 0x0402894C RID: 166220
		[Token(Token = "0x402894C")]
		[FieldOffset(Offset = "0xB4")]
		public int refreshPlayerListSeqNum;

		// Token: 0x0402894D RID: 166221
		[Token(Token = "0x402894D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402894E RID: 166222
		[Token(Token = "0x402894E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0402894F RID: 166223
		[Token(Token = "0x402894F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetSelectStatus;

		// Token: 0x04028950 RID: 166224
		[Token(Token = "0x4028950")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenerateBetParams;

		// Token: 0x04028951 RID: 166225
		[Token(Token = "0x4028951")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CanSelect;

		// Token: 0x04028952 RID: 166226
		[Token(Token = "0x4028952")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetEnemyDetailPanelShowStatus;

		// Token: 0x04028953 RID: 166227
		[Token(Token = "0x4028953")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ToggleEnemyDetailPanelShowStatus;

		// Token: 0x04028954 RID: 166228
		[Token(Token = "0x4028954")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetEmoticonDisabledStatus;

		// Token: 0x04028955 RID: 166229
		[Token(Token = "0x4028955")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshPlayerList;

		// Token: 0x04028956 RID: 166230
		[Token(Token = "0x4028956")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ClearPlayerList;

		// Token: 0x04028957 RID: 166231
		[Token(Token = "0x4028957")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SortPlayerListByBetTs;

		// Token: 0x04028958 RID: 166232
		[Token(Token = "0x4028958")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CalculatePlayerRank;

		// Token: 0x04028959 RID: 166233
		[Token(Token = "0x4028959")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
