using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042A9 RID: 17065
	[Token(Token = "0x20042A9")]
	public class SandboxV2DungeonMiscRiftViewModel : IHotfixable
	{
		// Token: 0x0601A45C RID: 107612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A45C")]
		[Address(RVA = "0x1330F70", Offset = "0x132FB70", VA = "0x181330F70")]
		public void LoadData(string topicId, PlayerSandboxV2 playerTopicData, SandboxV2Data topicDetailData, PlayerSandboxV2.Dungeon playerDungeonData)
		{
		}

		// Token: 0x0601A45D RID: 107613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A45D")]
		[Address(RVA = "0x13322C0", Offset = "0x1330EC0", VA = "0x1813322C0")]
		private void _LoadTitlePart(SandboxV2Data topicDetailData, PlayerSandboxV2.RiftInfo.Reservation riftReservation)
		{
		}

		// Token: 0x0601A45E RID: 107614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A45E")]
		[Address(RVA = "0x1331840", Offset = "0x1330440", VA = "0x181331840")]
		private void _LoadDayInfoPart(PlayerSandboxV2.Dungeon playerDungeonData)
		{
		}

		// Token: 0x0601A45F RID: 107615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A45F")]
		[Address(RVA = "0x1331DD0", Offset = "0x13309D0", VA = "0x181331DD0")]
		private void _LoadSeasonInfoPart(SandboxV2Data topicDetailData, PlayerSandboxV2.Dungeon playerDungeonData)
		{
		}

		// Token: 0x0601A460 RID: 107616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A460")]
		[Address(RVA = "0x1331960", Offset = "0x1330560", VA = "0x181331960")]
		private void _LoadFixRiftGlobalEffectPart(SandboxV2Data topicDetailData, PlayerSandboxV2.RiftInfo riftInfo)
		{
		}

		// Token: 0x0601A461 RID: 107617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A461")]
		[Address(RVA = "0x1331AA0", Offset = "0x13306A0", VA = "0x181331AA0")]
		private void _LoadRiftDifficultyPart(SandboxV2Data topicDetailData, PlayerSandboxV2.RiftInfo.Reservation riftReservation)
		{
		}

		// Token: 0x0601A462 RID: 107618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A462")]
		[Address(RVA = "0x1331FA0", Offset = "0x1330BA0", VA = "0x181331FA0")]
		private void _LoadTeamInfoPart(SandboxV2Data topicDetailData, PlayerSandboxV2.RiftInfo riftInfo, PlayerSandboxV2.RiftInfo.Reservation riftReservation)
		{
		}

		// Token: 0x0601A463 RID: 107619 RVA: 0x000A0A88 File Offset: 0x0009EC88
		[Token(Token = "0x601A463")]
		[Address(RVA = "0x1331730", Offset = "0x1330330", VA = "0x181331730")]
		private SandboxV2DungeonMiscRiftMainMissionState _GetMainMissionState(PlayerSandboxV2.RiftInfo.GameInfo playerRiftGameInfo)
		{
			return SandboxV2DungeonMiscRiftMainMissionState.FAIL;
		}

		// Token: 0x0601A464 RID: 107620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A464")]
		[Address(RVA = "0x1332470", Offset = "0x1331070", VA = "0x181332470")]
		public SandboxV2DungeonMiscRiftViewModel()
		{
		}

		// Token: 0x04021474 RID: 136308
		[Token(Token = "0x4021474")]
		[FieldOffset(Offset = "0x10")]
		public bool hasRift;

		// Token: 0x04021475 RID: 136309
		[Token(Token = "0x4021475")]
		[FieldOffset(Offset = "0x18")]
		public string mainTitle;

		// Token: 0x04021476 RID: 136310
		[Token(Token = "0x4021476")]
		[FieldOffset(Offset = "0x20")]
		public string subTitle;

		// Token: 0x04021477 RID: 136311
		[Token(Token = "0x4021477")]
		[FieldOffset(Offset = "0x28")]
		public string riftEndTips;

		// Token: 0x04021478 RID: 136312
		[Token(Token = "0x4021478")]
		[FieldOffset(Offset = "0x30")]
		public SandboxV2DungeonMiscRiftMainMissionState mainMissionState;

		// Token: 0x04021479 RID: 136313
		[Token(Token = "0x4021479")]
		[FieldOffset(Offset = "0x38")]
		public string seasonTitle;

		// Token: 0x0402147A RID: 136314
		[Token(Token = "0x402147A")]
		[FieldOffset(Offset = "0x40")]
		public string seasonDesc;

		// Token: 0x0402147B RID: 136315
		[Token(Token = "0x402147B")]
		[FieldOffset(Offset = "0x48")]
		public Color seasonCol;

		// Token: 0x0402147C RID: 136316
		[Token(Token = "0x402147C")]
		[FieldOffset(Offset = "0x58")]
		public bool isRandomRift;

		// Token: 0x0402147D RID: 136317
		[Token(Token = "0x402147D")]
		[FieldOffset(Offset = "0x59")]
		public bool isPreyRift;

		// Token: 0x0402147E RID: 136318
		[Token(Token = "0x402147E")]
		[FieldOffset(Offset = "0x5A")]
		public bool hasGlobalEffect;

		// Token: 0x0402147F RID: 136319
		[Token(Token = "0x402147F")]
		[FieldOffset(Offset = "0x60")]
		public string globalEffectDesc;

		// Token: 0x04021480 RID: 136320
		[Token(Token = "0x4021480")]
		[FieldOffset(Offset = "0x68")]
		public bool useDifficulty;

		// Token: 0x04021481 RID: 136321
		[Token(Token = "0x4021481")]
		[FieldOffset(Offset = "0x6C")]
		public int curDifficultyLv;

		// Token: 0x04021482 RID: 136322
		[Token(Token = "0x4021482")]
		[FieldOffset(Offset = "0x70")]
		public string difficultyDesc;

		// Token: 0x04021483 RID: 136323
		[Token(Token = "0x4021483")]
		[FieldOffset(Offset = "0x78")]
		public bool hasTeam;

		// Token: 0x04021484 RID: 136324
		[Token(Token = "0x4021484")]
		[FieldOffset(Offset = "0x80")]
		public string teamName;

		// Token: 0x04021485 RID: 136325
		[Token(Token = "0x4021485")]
		[FieldOffset(Offset = "0x88")]
		public int teamLv;

		// Token: 0x04021486 RID: 136326
		[Token(Token = "0x4021486")]
		[FieldOffset(Offset = "0x90")]
		public string teamDesc;

		// Token: 0x04021487 RID: 136327
		[Token(Token = "0x4021487")]
		[FieldOffset(Offset = "0x98")]
		private string m_riftId;

		// Token: 0x04021488 RID: 136328
		[Token(Token = "0x4021488")]
		[FieldOffset(Offset = "0xA0")]
		private StringBuilder m_difficultyDescs;

		// Token: 0x04021489 RID: 136329
		[Token(Token = "0x4021489")]
		[FieldOffset(Offset = "0xA8")]
		private StringBuilder m_teamDescs;

		// Token: 0x0402148A RID: 136330
		[Token(Token = "0x402148A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402148B RID: 136331
		[Token(Token = "0x402148B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadTitlePart;

		// Token: 0x0402148C RID: 136332
		[Token(Token = "0x402148C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadDayInfoPart;

		// Token: 0x0402148D RID: 136333
		[Token(Token = "0x402148D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadSeasonInfoPart;

		// Token: 0x0402148E RID: 136334
		[Token(Token = "0x402148E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadFixRiftGlobalEffectPart;

		// Token: 0x0402148F RID: 136335
		[Token(Token = "0x402148F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadRiftDifficultyPart;

		// Token: 0x04021490 RID: 136336
		[Token(Token = "0x4021490")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadTeamInfoPart;

		// Token: 0x04021491 RID: 136337
		[Token(Token = "0x4021491")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetMainMissionState;

		// Token: 0x04021492 RID: 136338
		[Token(Token = "0x4021492")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
