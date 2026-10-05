using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005D4 RID: 1492
	[Token(Token = "0x20005D4")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/SandboxPermDB")]
	[Serializable]
	public class SandboxPermDB : ConstTable<SandboxPermTable, SandboxPermDB>
	{
		// Token: 0x06006178 RID: 24952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006178")]
		[Address(RVA = "0x1DF3950", Offset = "0x1DF2550", VA = "0x181DF3950", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006179")]
		[Address(RVA = "0x1DF3810", Offset = "0x1DF2410", VA = "0x181DF3810")]
		public SandboxV2WeatherData GetSandboxV2WeatherDataByTypeAndLevel(string topicId, SandboxV2WeatherType type, int level)
		{
			return null;
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x0002FB98 File Offset: 0x0002DD98
		[Token(Token = "0x600617A")]
		[Address(RVA = "0x1DF32E0", Offset = "0x1DF1EE0", VA = "0x181DF32E0")]
		public int GetSandboxV2NodeUpgradeRarityRequirement(string topicId, SandboxV2ItemTrapTag itemTag)
		{
			return 0;
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x0002FBB0 File Offset: 0x0002DDB0
		[Token(Token = "0x600617B")]
		[Address(RVA = "0x1DF3210", Offset = "0x1DF1E10", VA = "0x181DF3210")]
		public bool GetSandboxPermItemData(string itemId, out SandboxPermItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x0600617C RID: 24956 RVA: 0x0002FBC8 File Offset: 0x0002DDC8
		[Token(Token = "0x600617C")]
		[Address(RVA = "0x1DF3600", Offset = "0x1DF2200", VA = "0x181DF3600")]
		public static long GetSandboxV2PrevNearestShopRefreshTime(string topicId, long timestamp)
		{
			return 0L;
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x0002FBE0 File Offset: 0x0002DDE0
		[Token(Token = "0x600617D")]
		[Address(RVA = "0x1DF33D0", Offset = "0x1DF1FD0", VA = "0x181DF33D0")]
		public static long GetSandboxV2PrevMonthRefreshTime(string topicId, long currTs)
		{
			return 0L;
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617E")]
		[Address(RVA = "0x1DF4010", Offset = "0x1DF2C10", VA = "0x181DF4010")]
		public SandboxPermDB()
		{
		}

		// Token: 0x04002B1C RID: 11036
		[Token(Token = "0x4002B1C")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, Dictionary<KeyValuePair<SandboxV2WeatherType, int>, SandboxV2WeatherData>> m_sandboxV2WeatherDataDict;

		// Token: 0x04002B1D RID: 11037
		[Token(Token = "0x4002B1D")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<string, Dictionary<SandboxV2ItemTrapTag, int>> m_sandboxV2NodeUpgradeRarityRequirementDict;

		// Token: 0x04002B1E RID: 11038
		[Token(Token = "0x4002B1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002B1F RID: 11039
		[Token(Token = "0x4002B1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSandboxV2WeatherDataByTypeAndLevel;

		// Token: 0x04002B20 RID: 11040
		[Token(Token = "0x4002B20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSandboxV2NodeUpgradeRarityRequirement;

		// Token: 0x04002B21 RID: 11041
		[Token(Token = "0x4002B21")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSandboxPermItemData;

		// Token: 0x04002B22 RID: 11042
		[Token(Token = "0x4002B22")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSandboxV2PrevNearestShopRefreshTime;

		// Token: 0x04002B23 RID: 11043
		[Token(Token = "0x4002B23")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSandboxV2PrevMonthRefreshTime;

		// Token: 0x04002B24 RID: 11044
		[Token(Token = "0x4002B24")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
