using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200769C RID: 30364
	[Token(Token = "0x200769C")]
	public class Act20sideEntertainCompViewModel : IHotfixable
	{
		// Token: 0x0602AB33 RID: 174899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB33")]
		[Address(RVA = "0x26743D0", Offset = "0x2672FD0", VA = "0x1826743D0")]
		public void LoadData(string activityId, bool isRetro)
		{
		}

		// Token: 0x0602AB34 RID: 174900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AB34")]
		[Address(RVA = "0x2674370", Offset = "0x2672F70", VA = "0x182674370")]
		public List<RuneTable.PackedRuneData> GetRuneList()
		{
			return null;
		}

		// Token: 0x0602AB35 RID: 174901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB35")]
		[Address(RVA = "0x2674BE0", Offset = "0x26737E0", VA = "0x182674BE0")]
		private void _LoadPlayerActivityData(string actId, bool isRetro)
		{
		}

		// Token: 0x0602AB36 RID: 174902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AB36")]
		[Address(RVA = "0x2674770", Offset = "0x2673370", VA = "0x182674770")]
		private string _GetUnlockConditionStr(string zoneId, long timeStampNow, string conditionStr)
		{
			return null;
		}

		// Token: 0x0602AB37 RID: 174903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB37")]
		[Address(RVA = "0x2674DB0", Offset = "0x26739B0", VA = "0x182674DB0")]
		public Act20sideEntertainCompViewModel()
		{
		}

		// Token: 0x0403D86F RID: 252015
		[Token(Token = "0x403D86F")]
		private const int SPECIAL_STAGE_COUNT = 2;

		// Token: 0x0403D870 RID: 252016
		[Token(Token = "0x403D870")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D871 RID: 252017
		[Token(Token = "0x403D871")]
		[FieldOffset(Offset = "0x18")]
		public string stage1Id;

		// Token: 0x0403D872 RID: 252018
		[Token(Token = "0x403D872")]
		[FieldOffset(Offset = "0x20")]
		public string stage1Desc;

		// Token: 0x0403D873 RID: 252019
		[Token(Token = "0x403D873")]
		[FieldOffset(Offset = "0x28")]
		public CartCompetitionRank stage1Rank;

		// Token: 0x0403D874 RID: 252020
		[Token(Token = "0x403D874")]
		[FieldOffset(Offset = "0x2C")]
		public bool hasRecordStage1;

		// Token: 0x0403D875 RID: 252021
		[Token(Token = "0x403D875")]
		[FieldOffset(Offset = "0x2D")]
		public bool isStage1Locked;

		// Token: 0x0403D876 RID: 252022
		[Token(Token = "0x403D876")]
		[FieldOffset(Offset = "0x30")]
		public string stage1UnlockStr;

		// Token: 0x0403D877 RID: 252023
		[Token(Token = "0x403D877")]
		[FieldOffset(Offset = "0x38")]
		public string stage2Id;

		// Token: 0x0403D878 RID: 252024
		[Token(Token = "0x403D878")]
		[FieldOffset(Offset = "0x40")]
		public string stage2Desc;

		// Token: 0x0403D879 RID: 252025
		[Token(Token = "0x403D879")]
		[FieldOffset(Offset = "0x48")]
		public CartCompetitionRank stage2Rank;

		// Token: 0x0403D87A RID: 252026
		[Token(Token = "0x403D87A")]
		[FieldOffset(Offset = "0x4C")]
		public bool hasRecordStage2;

		// Token: 0x0403D87B RID: 252027
		[Token(Token = "0x403D87B")]
		[FieldOffset(Offset = "0x4D")]
		public bool isStage2Locked;

		// Token: 0x0403D87C RID: 252028
		[Token(Token = "0x403D87C")]
		[FieldOffset(Offset = "0x50")]
		public string stage2UnlockStr;

		// Token: 0x0403D87D RID: 252029
		[Token(Token = "0x403D87D")]
		[FieldOffset(Offset = "0x58")]
		public PlayerCartInfo.Cart battleCar;

		// Token: 0x0403D87E RID: 252030
		[Token(Token = "0x403D87E")]
		[FieldOffset(Offset = "0x60")]
		public int stage1RankIndex;

		// Token: 0x0403D87F RID: 252031
		[Token(Token = "0x403D87F")]
		[FieldOffset(Offset = "0x64")]
		public int stage2RankIndex;

		// Token: 0x0403D880 RID: 252032
		[Token(Token = "0x403D880")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D881 RID: 252033
		[Token(Token = "0x403D881")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRuneList;

		// Token: 0x0403D882 RID: 252034
		[Token(Token = "0x403D882")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadPlayerActivityData;

		// Token: 0x0403D883 RID: 252035
		[Token(Token = "0x403D883")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetUnlockConditionStr;

		// Token: 0x0403D884 RID: 252036
		[Token(Token = "0x403D884")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
