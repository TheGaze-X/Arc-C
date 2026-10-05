using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F58 RID: 20312
	[Token(Token = "0x2004F58")]
	public class EnemyDuelBattleFinishViewModel : IHotfixable
	{
		// Token: 0x170046E2 RID: 18146
		// (get) Token: 0x0601E3DA RID: 123866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046E2")]
		public List<SettlementRankItemModel> rankList
		{
			[Token(Token = "0x601E3DA")]
			[Address(RVA = "0x17E3C30", Offset = "0x17E2830", VA = "0x1817E3C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E3DB RID: 123867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3DB")]
		[Address(RVA = "0x17E24B0", Offset = "0x17E10B0", VA = "0x1817E24B0")]
		public void LoadData()
		{
		}

		// Token: 0x0601E3DC RID: 123868 RVA: 0x000ADFA0 File Offset: 0x000AC1A0
		[Token(Token = "0x601E3DC")]
		[Address(RVA = "0x17E22A0", Offset = "0x17E0EA0", VA = "0x1817E22A0")]
		public MileStoneInfo GetMileStoneInfoByPoint(int point)
		{
			return default(MileStoneInfo);
		}

		// Token: 0x0601E3DD RID: 123869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3DD")]
		[Address(RVA = "0x17E2CE0", Offset = "0x17E18E0", VA = "0x1817E2CE0")]
		private void _LoadBattleInOut()
		{
		}

		// Token: 0x0601E3DE RID: 123870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3DE")]
		[Address(RVA = "0x17E3990", Offset = "0x17E2590", VA = "0x1817E3990")]
		private void _LoadSingleModeData(ActivityEnemyDuelData actData)
		{
		}

		// Token: 0x0601E3DF RID: 123871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3DF")]
		[Address(RVA = "0x17E3250", Offset = "0x17E1E50", VA = "0x1817E3250")]
		private void _LoadMultiModeData(ActivityEnemyDuelData actData)
		{
		}

		// Token: 0x0601E3E0 RID: 123872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3E0")]
		[Address(RVA = "0x17E2F30", Offset = "0x17E1B30", VA = "0x1817E2F30")]
		private void _LoadDailyMissionAndBp(ActivityEnemyDuelData actData)
		{
		}

		// Token: 0x0601E3E1 RID: 123873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3E1")]
		[Address(RVA = "0x17E3430", Offset = "0x17E2030", VA = "0x1817E3430")]
		private void _LoadRankList(ActivityEnemyDuelData actData, List<RankInfo> playerList)
		{
		}

		// Token: 0x0601E3E2 RID: 123874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E3E2")]
		[Address(RVA = "0x17E2E50", Offset = "0x17E1A50", VA = "0x1817E2E50")]
		private string _LoadCommentText(ListDict<string, ActivityEnemyDuelSingleCommentData> commentDict)
		{
			return null;
		}

		// Token: 0x0601E3E3 RID: 123875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3E3")]
		[Address(RVA = "0x17E3B70", Offset = "0x17E2770", VA = "0x1817E3B70")]
		public EnemyDuelBattleFinishViewModel()
		{
		}

		// Token: 0x0402854E RID: 165198
		[Token(Token = "0x402854E")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0402854F RID: 165199
		[Token(Token = "0x402854F")]
		[FieldOffset(Offset = "0x18")]
		public int settlePicNum;

		// Token: 0x04028550 RID: 165200
		[Token(Token = "0x4028550")]
		[FieldOffset(Offset = "0x20")]
		public string modeId;

		// Token: 0x04028551 RID: 165201
		[Token(Token = "0x4028551")]
		[FieldOffset(Offset = "0x28")]
		public string sceneId;

		// Token: 0x04028552 RID: 165202
		[Token(Token = "0x4028552")]
		[FieldOffset(Offset = "0x30")]
		public string modeTitle;

		// Token: 0x04028553 RID: 165203
		[Token(Token = "0x4028553")]
		[FieldOffset(Offset = "0x38")]
		public EnemyDuelModeType duelMode;

		// Token: 0x04028554 RID: 165204
		[Token(Token = "0x4028554")]
		[FieldOffset(Offset = "0x3C")]
		public bool isQuit;

		// Token: 0x04028555 RID: 165205
		[Token(Token = "0x4028555")]
		[FieldOffset(Offset = "0x3D")]
		public bool isSolo;

		// Token: 0x04028556 RID: 165206
		[Token(Token = "0x4028556")]
		[FieldOffset(Offset = "0x3E")]
		public bool isRoom;

		// Token: 0x04028557 RID: 165207
		[Token(Token = "0x4028557")]
		[FieldOffset(Offset = "0x3F")]
		public bool isRoomOwner;

		// Token: 0x04028558 RID: 165208
		[Token(Token = "0x4028558")]
		[FieldOffset(Offset = "0x40")]
		public int playerScore;

		// Token: 0x04028559 RID: 165209
		[Token(Token = "0x4028559")]
		[FieldOffset(Offset = "0x48")]
		public ChoiceCntInfo operationInfo;

		// Token: 0x0402855A RID: 165210
		[Token(Token = "0x402855A")]
		[FieldOffset(Offset = "0x50")]
		public float countDownSeconds;

		// Token: 0x0402855B RID: 165211
		[Token(Token = "0x402855B")]
		[FieldOffset(Offset = "0x58")]
		public string nickName;

		// Token: 0x0402855C RID: 165212
		[Token(Token = "0x402855C")]
		[FieldOffset(Offset = "0x60")]
		public string nickNumber;

		// Token: 0x0402855D RID: 165213
		[Token(Token = "0x402855D")]
		[FieldOffset(Offset = "0x68")]
		public string commentText;

		// Token: 0x0402855E RID: 165214
		[Token(Token = "0x402855E")]
		[FieldOffset(Offset = "0x70")]
		public bool isBest;

		// Token: 0x0402855F RID: 165215
		[Token(Token = "0x402855F")]
		[FieldOffset(Offset = "0x74")]
		public int rank;

		// Token: 0x04028560 RID: 165216
		[Token(Token = "0x4028560")]
		[FieldOffset(Offset = "0x78")]
		public int selfIndex;

		// Token: 0x04028561 RID: 165217
		[Token(Token = "0x4028561")]
		[FieldOffset(Offset = "0x7C")]
		public bool isTopRank;

		// Token: 0x04028562 RID: 165218
		[Token(Token = "0x4028562")]
		[FieldOffset(Offset = "0x80")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04028563 RID: 165219
		[Token(Token = "0x4028563")]
		[FieldOffset(Offset = "0x98")]
		public int rewardDailyMission;

		// Token: 0x04028564 RID: 165220
		[Token(Token = "0x4028564")]
		[FieldOffset(Offset = "0x9C")]
		public int currDailyMission;

		// Token: 0x04028565 RID: 165221
		[Token(Token = "0x4028565")]
		[FieldOffset(Offset = "0xA0")]
		public int fullDailyMission;

		// Token: 0x04028566 RID: 165222
		[Token(Token = "0x4028566")]
		[FieldOffset(Offset = "0xA4")]
		public int rewardBpDailyComplete;

		// Token: 0x04028567 RID: 165223
		[Token(Token = "0x4028567")]
		[FieldOffset(Offset = "0xA8")]
		public int rewardBp;

		// Token: 0x04028568 RID: 165224
		[Token(Token = "0x4028568")]
		[FieldOffset(Offset = "0xAC")]
		public MileStoneInfo prevMileStone;

		// Token: 0x04028569 RID: 165225
		[Token(Token = "0x4028569")]
		[FieldOffset(Offset = "0xC8")]
		public MileStoneInfo currMileStone;

		// Token: 0x0402856A RID: 165226
		[Token(Token = "0x402856A")]
		[FieldOffset(Offset = "0xE8")]
		private List<ActivityEnemyDuelMilestoneItemData> m_mileStoneList;

		// Token: 0x0402856B RID: 165227
		[Token(Token = "0x402856B")]
		[FieldOffset(Offset = "0xF0")]
		private string m_commentId;

		// Token: 0x0402856C RID: 165228
		[Token(Token = "0x402856C")]
		[FieldOffset(Offset = "0xF8")]
		private string m_uid;

		// Token: 0x0402856D RID: 165229
		[Token(Token = "0x402856D")]
		[FieldOffset(Offset = "0x100")]
		public List<SettlementRankItemModel> m_rankList;

		// Token: 0x0402856E RID: 165230
		[Token(Token = "0x402856E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rankList;

		// Token: 0x0402856F RID: 165231
		[Token(Token = "0x402856F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028570 RID: 165232
		[Token(Token = "0x4028570")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMileStoneInfoByPoint;

		// Token: 0x04028571 RID: 165233
		[Token(Token = "0x4028571")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadBattleInOut;

		// Token: 0x04028572 RID: 165234
		[Token(Token = "0x4028572")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadSingleModeData;

		// Token: 0x04028573 RID: 165235
		[Token(Token = "0x4028573")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadMultiModeData;

		// Token: 0x04028574 RID: 165236
		[Token(Token = "0x4028574")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadDailyMissionAndBp;

		// Token: 0x04028575 RID: 165237
		[Token(Token = "0x4028575")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadRankList;

		// Token: 0x04028576 RID: 165238
		[Token(Token = "0x4028576")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadCommentText;

		// Token: 0x04028577 RID: 165239
		[Token(Token = "0x4028577")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
