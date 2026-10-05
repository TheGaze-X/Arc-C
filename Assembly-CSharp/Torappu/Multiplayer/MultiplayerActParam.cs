using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.GameMode;
using Torappu.UI.BattleFinish;

namespace Torappu.Multiplayer
{
	// Token: 0x02001532 RID: 5426
	[Token(Token = "0x2001532")]
	public struct MultiplayerActParam
	{
		// Token: 0x04007C83 RID: 31875
		[Token(Token = "0x4007C83")]
		[FieldOffset(Offset = "0x0")]
		public BattleActivityMeta actMeta;

		// Token: 0x04007C84 RID: 31876
		[Token(Token = "0x4007C84")]
		[FieldOffset(Offset = "0x20")]
		public BattleFinishIndexState.IPlugin battleFinishIndexPlugin;

		// Token: 0x04007C85 RID: 31877
		[Token(Token = "0x4007C85")]
		[FieldOffset(Offset = "0x28")]
		public MultiplayerActParam.MultiplayerSetting setting;

		// Token: 0x04007C86 RID: 31878
		[Token(Token = "0x4007C86")]
		[FieldOffset(Offset = "0x48")]
		public Func<string, StageData> stageDataGetter;

		// Token: 0x04007C87 RID: 31879
		[Token(Token = "0x4007C87")]
		[FieldOffset(Offset = "0x50")]
		public Func<string, string, GameModeFactory.CooperateGameMode.SubGameModeType> gameModeTypeGetter;

		// Token: 0x04007C88 RID: 31880
		[Token(Token = "0x4007C88")]
		[FieldOffset(Offset = "0x58")]
		public Func<string, string, LevelData.Difficulty> stageDifficultyGetter;

		// Token: 0x04007C89 RID: 31881
		[Token(Token = "0x4007C89")]
		[FieldOffset(Offset = "0x60")]
		public bool multiplayerUploadLogClose;

		// Token: 0x04007C8A RID: 31882
		[Token(Token = "0x4007C8A")]
		[FieldOffset(Offset = "0x68")]
		public Action<string> alertFunc;

		// Token: 0x02001533 RID: 5427
		[Token(Token = "0x2001533")]
		public struct MultiplayerSetting
		{
			// Token: 0x06007C95 RID: 31893 RVA: 0x000375D8 File Offset: 0x000357D8
			[Token(Token = "0x6007C95")]
			[Address(RVA = "0x2849FF0", Offset = "0x2848BF0", VA = "0x182849FF0")]
			public static MultiplayerActParam.MultiplayerSetting GeneSettingFromActMultiV3ConstData(ActMultiV3ConstData constData)
			{
				return default(MultiplayerActParam.MultiplayerSetting);
			}

			// Token: 0x04007C8B RID: 31883
			[Token(Token = "0x4007C8B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MultiplayerActParam.MultiplayerSetting Default;

			// Token: 0x04007C8C RID: 31884
			[Token(Token = "0x4007C8C")]
			[FieldOffset(Offset = "0x0")]
			public int maxRetryTimeInMatchRoom;

			// Token: 0x04007C8D RID: 31885
			[Token(Token = "0x4007C8D")]
			[FieldOffset(Offset = "0x4")]
			public int maxRetryTimeInTeamRoom;

			// Token: 0x04007C8E RID: 31886
			[Token(Token = "0x4007C8E")]
			[FieldOffset(Offset = "0x8")]
			public int maxRetryTimeInBattle;

			// Token: 0x04007C8F RID: 31887
			[Token(Token = "0x4007C8F")]
			[FieldOffset(Offset = "0xC")]
			public int settleRetryTime;

			// Token: 0x04007C90 RID: 31888
			[Token(Token = "0x4007C90")]
			[FieldOffset(Offset = "0x10")]
			public float delayTimeNeedTip;

			// Token: 0x04007C91 RID: 31889
			[Token(Token = "0x4007C91")]
			[FieldOffset(Offset = "0x14")]
			public float maxPlaySpeed;

			// Token: 0x04007C92 RID: 31890
			[Token(Token = "0x4007C92")]
			[FieldOffset(Offset = "0x18")]
			public double maxOperatorDelay;
		}
	}
}
