using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012AA RID: 4778
	[Token(Token = "0x20012AA")]
	public class SandboxV2GameConst
	{
		// Token: 0x06007226 RID: 29222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007226")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2GameConst()
		{
		}

		// Token: 0x0400693B RID: 26939
		[Token(Token = "0x400693B")]
		[FieldOffset(Offset = "0x10")]
		public string mainMapId;

		// Token: 0x0400693C RID: 26940
		[Token(Token = "0x400693C")]
		[FieldOffset(Offset = "0x18")]
		public string baseTrapId;

		// Token: 0x0400693D RID: 26941
		[Token(Token = "0x400693D")]
		[FieldOffset(Offset = "0x20")]
		public string portableTrapId;

		// Token: 0x0400693E RID: 26942
		[Token(Token = "0x400693E")]
		[FieldOffset(Offset = "0x28")]
		public string doorTrapId;

		// Token: 0x0400693F RID: 26943
		[Token(Token = "0x400693F")]
		[FieldOffset(Offset = "0x30")]
		public string mineTrapId;

		// Token: 0x04006940 RID: 26944
		[Token(Token = "0x4006940")]
		[FieldOffset(Offset = "0x38")]
		public List<string> neutralBossEnemyId;

		// Token: 0x04006941 RID: 26945
		[Token(Token = "0x4006941")]
		[FieldOffset(Offset = "0x40")]
		public string nestTrapId;

		// Token: 0x04006942 RID: 26946
		[Token(Token = "0x4006942")]
		[FieldOffset(Offset = "0x48")]
		public string shopNpcName;

		// Token: 0x04006943 RID: 26947
		[Token(Token = "0x4006943")]
		[FieldOffset(Offset = "0x50")]
		public int daysBetweenAssessment;

		// Token: 0x04006944 RID: 26948
		[Token(Token = "0x4006944")]
		[FieldOffset(Offset = "0x54")]
		public int portableConstructUnlockLevel;

		// Token: 0x04006945 RID: 26949
		[Token(Token = "0x4006945")]
		[FieldOffset(Offset = "0x58")]
		public int outpostConstructUnlockLevel;

		// Token: 0x04006946 RID: 26950
		[Token(Token = "0x4006946")]
		[FieldOffset(Offset = "0x5C")]
		public int maxEnemyCountSameTimeInRush;

		// Token: 0x04006947 RID: 26951
		[Token(Token = "0x4006947")]
		[FieldOffset(Offset = "0x60")]
		public float maxPreDelayTimeInRush;

		// Token: 0x04006948 RID: 26952
		[Token(Token = "0x4006948")]
		[FieldOffset(Offset = "0x64")]
		public int maxSaveCnt;

		// Token: 0x04006949 RID: 26953
		[Token(Token = "0x4006949")]
		[FieldOffset(Offset = "0x68")]
		public int firstSeasonDuration;

		// Token: 0x0400694A RID: 26954
		[Token(Token = "0x400694A")]
		[FieldOffset(Offset = "0x70")]
		public List<SandboxV2SeasonType> seasonTransitionLoop;

		// Token: 0x0400694B RID: 26955
		[Token(Token = "0x400694B")]
		[FieldOffset(Offset = "0x78")]
		public List<int> seasonDurationLoop;

		// Token: 0x0400694C RID: 26956
		[Token(Token = "0x400694C")]
		[FieldOffset(Offset = "0x80")]
		public float firstSeasonStartAngle;

		// Token: 0x0400694D RID: 26957
		[Token(Token = "0x400694D")]
		[FieldOffset(Offset = "0x88")]
		public List<float> seasonTransitionAngleLoop;

		// Token: 0x0400694E RID: 26958
		[Token(Token = "0x400694E")]
		[FieldOffset(Offset = "0x90")]
		public float seasonAngle;

		// Token: 0x0400694F RID: 26959
		[Token(Token = "0x400694F")]
		[FieldOffset(Offset = "0x98")]
		public string battleItemDesc;

		// Token: 0x04006950 RID: 26960
		[Token(Token = "0x4006950")]
		[FieldOffset(Offset = "0xA0")]
		public string foodDesc;

		// Token: 0x04006951 RID: 26961
		[Token(Token = "0x4006951")]
		[FieldOffset(Offset = "0xA8")]
		public string multipleSurvivalDayDesc;

		// Token: 0x04006952 RID: 26962
		[Token(Token = "0x4006952")]
		[FieldOffset(Offset = "0xB0")]
		public string multipleTips;

		// Token: 0x04006953 RID: 26963
		[Token(Token = "0x4006953")]
		[FieldOffset(Offset = "0xB8")]
		public int techProgressScore;

		// Token: 0x04006954 RID: 26964
		[Token(Token = "0x4006954")]
		[FieldOffset(Offset = "0xC0")]
		public string otherEnemyRushName;

		// Token: 0x04006955 RID: 26965
		[Token(Token = "0x4006955")]
		[FieldOffset(Offset = "0xC8")]
		public string surviveDayText;

		// Token: 0x04006956 RID: 26966
		[Token(Token = "0x4006956")]
		[FieldOffset(Offset = "0xD0")]
		public string survivePeriodText;

		// Token: 0x04006957 RID: 26967
		[Token(Token = "0x4006957")]
		[FieldOffset(Offset = "0xD8")]
		public string surviveScoreText;

		// Token: 0x04006958 RID: 26968
		[Token(Token = "0x4006958")]
		[FieldOffset(Offset = "0xE0")]
		public string actionPointScoreText;

		// Token: 0x04006959 RID: 26969
		[Token(Token = "0x4006959")]
		[FieldOffset(Offset = "0xE8")]
		public string nodeExploreDesc;

		// Token: 0x0400695A RID: 26970
		[Token(Token = "0x400695A")]
		[FieldOffset(Offset = "0xF0")]
		public string dungeonExploreDesc;

		// Token: 0x0400695B RID: 26971
		[Token(Token = "0x400695B")]
		[FieldOffset(Offset = "0xF8")]
		public string nodeCompleteDesc;

		// Token: 0x0400695C RID: 26972
		[Token(Token = "0x400695C")]
		[FieldOffset(Offset = "0x100")]
		public string noRiftDungeonDesc;

		// Token: 0x0400695D RID: 26973
		[Token(Token = "0x400695D")]
		[FieldOffset(Offset = "0x108")]
		public string baseRushedDesc;

		// Token: 0x0400695E RID: 26974
		[Token(Token = "0x400695E")]
		[FieldOffset(Offset = "0x110")]
		public string riftBaseDesc;

		// Token: 0x0400695F RID: 26975
		[Token(Token = "0x400695F")]
		[FieldOffset(Offset = "0x118")]
		public string riftBaseRushedDesc;

		// Token: 0x04006960 RID: 26976
		[Token(Token = "0x4006960")]
		[FieldOffset(Offset = "0x120")]
		public List<string> dungeonTriggeredGuideQuestList;

		// Token: 0x04006961 RID: 26977
		[Token(Token = "0x4006961")]
		[FieldOffset(Offset = "0x128")]
		public List<string> noLogInEnemyStatsEnemyId;
	}
}
