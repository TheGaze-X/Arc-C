using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200622F RID: 25135
	[Token(Token = "0x200622F")]
	public class AutoChessLocalCache : Singleton<AutoChessLocalCache>
	{
		// Token: 0x06024433 RID: 148531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024433")]
		[Address(RVA = "0x1F06A70", Offset = "0x1F05670", VA = "0x181F06A70")]
		private AutoChessLocalCache()
		{
		}

		// Token: 0x06024434 RID: 148532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024434")]
		[Address(RVA = "0x1F065A0", Offset = "0x1F051A0", VA = "0x181F065A0")]
		private AutoChessLocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06024435 RID: 148533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024435")]
		[Address(RVA = "0x1F061E0", Offset = "0x1F04DE0", VA = "0x181F061E0")]
		private AutoChessLocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x06024436 RID: 148534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024436")]
		[Address(RVA = "0x1F066E0", Offset = "0x1F052E0", VA = "0x181F066E0")]
		private AutoChessLocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x06024437 RID: 148535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024437")]
		[Address(RVA = "0x1F069E0", Offset = "0x1F055E0", VA = "0x181F069E0")]
		private void _SaveData(AutoChessLocalCache.ActData data)
		{
		}

		// Token: 0x06024438 RID: 148536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024438")]
		[Address(RVA = "0x1F05890", Offset = "0x1F04490", VA = "0x181F05890")]
		public string GetLastSelectModeId(string actId, ActAutoChessModeType modeType, ActAutoChessMultiModeSubType multiModeSubType = ActAutoChessMultiModeSubType.NONE)
		{
			return null;
		}

		// Token: 0x06024439 RID: 148537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024439")]
		[Address(RVA = "0x1F05D60", Offset = "0x1F04960", VA = "0x181F05D60")]
		public void SaveLastSelectModeId(string actId, string lastSelectModeId, ActAutoChessModeType modeType, ActAutoChessMultiModeSubType multiModeSubType)
		{
		}

		// Token: 0x0602443A RID: 148538 RVA: 0x000C39F0 File Offset: 0x000C1BF0
		[Token(Token = "0x602443A")]
		[Address(RVA = "0x1F05770", Offset = "0x1F04370", VA = "0x181F05770")]
		public bool GetLastSelectMatchStyle(string actId, ActAutoChessMultiModeSubType multiModeSubType, out bool result)
		{
			return default(bool);
		}

		// Token: 0x0602443B RID: 148539 RVA: 0x000C3A08 File Offset: 0x000C1C08
		[Token(Token = "0x602443B")]
		[Address(RVA = "0x1F05650", Offset = "0x1F04250", VA = "0x181F05650")]
		public bool GetLastSelectMatchFlag(string actId, ActAutoChessMultiModeSubType multiModeSubType, out bool result)
		{
			return default(bool);
		}

		// Token: 0x0602443C RID: 148540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602443C")]
		[Address(RVA = "0x1F05C40", Offset = "0x1F04840", VA = "0x181F05C40")]
		public void SaveLastSelectMatchStyle(string actId, bool isPrecise, ActAutoChessMultiModeSubType multiModeSubType)
		{
		}

		// Token: 0x0602443D RID: 148541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602443D")]
		[Address(RVA = "0x1F05B20", Offset = "0x1F04720", VA = "0x181F05B20")]
		public void SaveLastSelectMatchFlag(string actId, bool matchFlag, ActAutoChessMultiModeSubType multiModeSubType)
		{
		}

		// Token: 0x0602443E RID: 148542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602443E")]
		[Address(RVA = "0x1F055A0", Offset = "0x1F041A0", VA = "0x181F055A0")]
		public string GetLastEmojiThemeId(string actId)
		{
			return null;
		}

		// Token: 0x0602443F RID: 148543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602443F")]
		[Address(RVA = "0x1F05A40", Offset = "0x1F04640", VA = "0x181F05A40")]
		public void SaveLastEmojiThemeId(string actId, string emoticonThemeId)
		{
		}

		// Token: 0x06024440 RID: 148544 RVA: 0x000C3A20 File Offset: 0x000C1C20
		[Token(Token = "0x6024440")]
		[Address(RVA = "0x1F059B0", Offset = "0x1F045B0", VA = "0x181F059B0")]
		public long GetMatchBannedUtilTs(string actId)
		{
			return 0L;
		}

		// Token: 0x06024441 RID: 148545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024441")]
		[Address(RVA = "0x1F05E90", Offset = "0x1F04A90", VA = "0x181F05E90")]
		public void SaveMatchBannedUtilTs(string actId, long matchBannedUtilTs)
		{
		}

		// Token: 0x06024442 RID: 148546 RVA: 0x000C3A38 File Offset: 0x000C1C38
		[Token(Token = "0x6024442")]
		[Address(RVA = "0x1F05510", Offset = "0x1F04110", VA = "0x181F05510")]
		public bool CheckPrevReadyGoldTipDisable(string actId)
		{
			return default(bool);
		}

		// Token: 0x06024443 RID: 148547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024443")]
		[Address(RVA = "0x1F05F50", Offset = "0x1F04B50", VA = "0x181F05F50")]
		public void SavePrevReadyGoldTipDisable()
		{
		}

		// Token: 0x06024444 RID: 148548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024444")]
		[Address(RVA = "0x1F068D0", Offset = "0x1F054D0", VA = "0x181F068D0")]
		private string _GetModeKey(ActAutoChessModeType modeType, ActAutoChessMultiModeSubType multiModeSubType)
		{
			return null;
		}

		// Token: 0x06024445 RID: 148549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024445")]
		[Address(RVA = "0x1F06810", Offset = "0x1F05410", VA = "0x181F06810")]
		private string _GetMatchStyleKey(ActAutoChessMultiModeSubType multiModeSubType)
		{
			return null;
		}

		// Token: 0x06024446 RID: 148550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024446")]
		[Address(RVA = "0x1F06490", Offset = "0x1F05090", VA = "0x181F06490")]
		private AutoChessLocalCache.DataInScene _EnsureDataInScene()
		{
			return null;
		}

		// Token: 0x06024447 RID: 148551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024447")]
		[Address(RVA = "0x1F060D0", Offset = "0x1F04CD0", VA = "0x181F060D0")]
		private void _ConfirmDataInScene(AutoChessLocalCache.DataInScene data, bool triggerSave = true)
		{
		}

		// Token: 0x040326C1 RID: 206529
		[Token(Token = "0x40326C1")]
		private const string MODE_KEY_FORMAT = "mode_type_{0}_{1}";

		// Token: 0x040326C2 RID: 206530
		[Token(Token = "0x40326C2")]
		private const string MULTI_SUB_KEY_FORMAT = "multi_sub_type_{0}";

		// Token: 0x040326C3 RID: 206531
		[Token(Token = "0x40326C3")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<AutoChessLocalCache.ActData> m_memData;

		// Token: 0x040326C4 RID: 206532
		[Token(Token = "0x40326C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040326C5 RID: 206533
		[Token(Token = "0x40326C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x040326C6 RID: 206534
		[Token(Token = "0x40326C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x040326C7 RID: 206535
		[Token(Token = "0x40326C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x040326C8 RID: 206536
		[Token(Token = "0x40326C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x040326C9 RID: 206537
		[Token(Token = "0x40326C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetLastSelectModeId;

		// Token: 0x040326CA RID: 206538
		[Token(Token = "0x40326CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SaveLastSelectModeId;

		// Token: 0x040326CB RID: 206539
		[Token(Token = "0x40326CB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetLastSelectMatchStyle;

		// Token: 0x040326CC RID: 206540
		[Token(Token = "0x40326CC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetLastSelectMatchFlag;

		// Token: 0x040326CD RID: 206541
		[Token(Token = "0x40326CD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SaveLastSelectMatchStyle;

		// Token: 0x040326CE RID: 206542
		[Token(Token = "0x40326CE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SaveLastSelectMatchFlag;

		// Token: 0x040326CF RID: 206543
		[Token(Token = "0x40326CF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetLastEmojiThemeId;

		// Token: 0x040326D0 RID: 206544
		[Token(Token = "0x40326D0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SaveLastEmojiThemeId;

		// Token: 0x040326D1 RID: 206545
		[Token(Token = "0x40326D1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetMatchBannedUtilTs;

		// Token: 0x040326D2 RID: 206546
		[Token(Token = "0x40326D2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SaveMatchBannedUtilTs;

		// Token: 0x040326D3 RID: 206547
		[Token(Token = "0x40326D3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckPrevReadyGoldTipDisable;

		// Token: 0x040326D4 RID: 206548
		[Token(Token = "0x40326D4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SavePrevReadyGoldTipDisable;

		// Token: 0x040326D5 RID: 206549
		[Token(Token = "0x40326D5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetModeKey;

		// Token: 0x040326D6 RID: 206550
		[Token(Token = "0x40326D6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetMatchStyleKey;

		// Token: 0x040326D7 RID: 206551
		[Token(Token = "0x40326D7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EnsureDataInScene;

		// Token: 0x040326D8 RID: 206552
		[Token(Token = "0x40326D8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ConfirmDataInScene;

		// Token: 0x02006230 RID: 25136
		[Token(Token = "0x2006230")]
		private class DataInAct
		{
			// Token: 0x06024448 RID: 148552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024448")]
			[Address(RVA = "0x1F1B9A0", Offset = "0x1F1A5A0", VA = "0x181F1B9A0")]
			public DataInAct()
			{
			}

			// Token: 0x040326D9 RID: 206553
			[Token(Token = "0x40326D9")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, string> modeSelectDataDict;

			// Token: 0x040326DA RID: 206554
			[Token(Token = "0x40326DA")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, bool> modeMatchRangeDataDict;

			// Token: 0x040326DB RID: 206555
			[Token(Token = "0x40326DB")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, bool> modeMatchFlagDataDict;

			// Token: 0x040326DC RID: 206556
			[Token(Token = "0x40326DC")]
			[FieldOffset(Offset = "0x28")]
			public string lastUseEmojiThemeId;

			// Token: 0x040326DD RID: 206557
			[Token(Token = "0x40326DD")]
			[FieldOffset(Offset = "0x30")]
			public long matchBannedUtilTs;

			// Token: 0x040326DE RID: 206558
			[Token(Token = "0x40326DE")]
			[FieldOffset(Offset = "0x38")]
			public AutoChessLocalCache.DataInScene dataInScene;
		}

		// Token: 0x02006231 RID: 25137
		[Token(Token = "0x2006231")]
		private class DataInScene
		{
			// Token: 0x06024449 RID: 148553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024449")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInScene()
			{
			}

			// Token: 0x040326DF RID: 206559
			[Token(Token = "0x40326DF")]
			[FieldOffset(Offset = "0x10")]
			public string sceneId;

			// Token: 0x040326E0 RID: 206560
			[Token(Token = "0x40326E0")]
			[FieldOffset(Offset = "0x18")]
			public bool isPrevReadyGoldTipDisable;
		}

		// Token: 0x02006232 RID: 25138
		[Token(Token = "0x2006232")]
		private class ActData
		{
			// Token: 0x0602444A RID: 148554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602444A")]
			[Address(RVA = "0x1F04830", Offset = "0x1F03430", VA = "0x181F04830")]
			public ActData()
			{
			}

			// Token: 0x040326E1 RID: 206561
			[Token(Token = "0x40326E1")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x040326E2 RID: 206562
			[Token(Token = "0x40326E2")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessLocalCache.DataInAct dataInAct;
		}
	}
}
