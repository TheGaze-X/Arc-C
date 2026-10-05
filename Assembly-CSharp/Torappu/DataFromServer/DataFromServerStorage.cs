using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DataFromServer
{
	// Token: 0x020016F7 RID: 5879
	[Token(Token = "0x20016F7")]
	public class DataFromServerStorage : Singleton<DataFromServerStorage>
	{
		// Token: 0x060094CE RID: 38094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094CE")]
		[Address(RVA = "0x31045F0", Offset = "0x31031F0", VA = "0x1831045F0")]
		private DataFromServerStorage()
		{
		}

		// Token: 0x060094CF RID: 38095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094CF")]
		[Address(RVA = "0x3103E50", Offset = "0x3102A50", VA = "0x183103E50")]
		public void UpdateStatusWhenLogin()
		{
		}

		// Token: 0x060094D0 RID: 38096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D0")]
		[Address(RVA = "0x3103FA0", Offset = "0x3102BA0", VA = "0x183103FA0")]
		public void UpdateStatusWhenSyncStatus()
		{
		}

		// Token: 0x060094D1 RID: 38097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D1")]
		[Address(RVA = "0x3103B90", Offset = "0x3102790", VA = "0x183103B90")]
		internal void DataFromServer_SetData(IDataConfig config, object data)
		{
		}

		// Token: 0x060094D2 RID: 38098 RVA: 0x0003A050 File Offset: 0x00038250
		[Token(Token = "0x60094D2")]
		[Address(RVA = "0x31038F0", Offset = "0x31024F0", VA = "0x1831038F0")]
		internal DataFromServerStorage.GetDataResult DataFromServer_GetData(IDataConfig config)
		{
			return default(DataFromServerStorage.GetDataResult);
		}

		// Token: 0x060094D3 RID: 38099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094D3")]
		[Address(RVA = "0x3104370", Offset = "0x3102F70", VA = "0x183104370")]
		private void _UpdateDataOnEvents(Func<KeyValuePair<string, DataFromServerStorage.DataChunk>, bool> remover)
		{
		}

		// Token: 0x060094D4 RID: 38100 RVA: 0x0003A068 File Offset: 0x00038268
		[Token(Token = "0x60094D4")]
		[Address(RVA = "0x31042D0", Offset = "0x3102ED0", VA = "0x1831042D0")]
		private static DataFromServerStorage.DataChunk.Status _GenerateCurrentStatus()
		{
			return default(DataFromServerStorage.DataChunk.Status);
		}

		// Token: 0x060094D5 RID: 38101 RVA: 0x0003A080 File Offset: 0x00038280
		[Token(Token = "0x60094D5")]
		[Address(RVA = "0x31040F0", Offset = "0x3102CF0", VA = "0x1831040F0")]
		private static bool _CheckIfNeedCrossDay(DataFromServerStorage.DataChunk chunk)
		{
			return default(bool);
		}

		// Token: 0x060094D6 RID: 38102 RVA: 0x0003A098 File Offset: 0x00038298
		[Token(Token = "0x60094D6")]
		[Address(RVA = "0x3104220", Offset = "0x3102E20", VA = "0x183104220")]
		private static bool _CheckIfValidForCrossDay(DataFromServerStorage.DataChunk chunk)
		{
			return default(bool);
		}

		// Token: 0x04008ADC RID: 35548
		[Token(Token = "0x4008ADC")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, DataFromServerStorage.DataChunk> m_storage;

		// Token: 0x04008ADD RID: 35549
		[Token(Token = "0x4008ADD")]
		[FieldOffset(Offset = "0x18")]
		private List<string> m_sharedList;

		// Token: 0x04008ADE RID: 35550
		[Token(Token = "0x4008ADE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008ADF RID: 35551
		[Token(Token = "0x4008ADF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateStatusWhenLogin;

		// Token: 0x04008AE0 RID: 35552
		[Token(Token = "0x4008AE0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateStatusWhenSyncStatus;

		// Token: 0x04008AE1 RID: 35553
		[Token(Token = "0x4008AE1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DataFromServer_SetData;

		// Token: 0x04008AE2 RID: 35554
		[Token(Token = "0x4008AE2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DataFromServer_GetData;

		// Token: 0x04008AE3 RID: 35555
		[Token(Token = "0x4008AE3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateDataOnEvents;

		// Token: 0x04008AE4 RID: 35556
		[Token(Token = "0x4008AE4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenerateCurrentStatus;

		// Token: 0x04008AE5 RID: 35557
		[Token(Token = "0x4008AE5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckIfNeedCrossDay;

		// Token: 0x04008AE6 RID: 35558
		[Token(Token = "0x4008AE6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckIfValidForCrossDay;

		// Token: 0x020016F8 RID: 5880
		[Token(Token = "0x20016F8")]
		public class DataChunk
		{
			// Token: 0x060094D7 RID: 38103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60094D7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataChunk()
			{
			}

			// Token: 0x04008AE7 RID: 35559
			[Token(Token = "0x4008AE7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DataFromServerStorage.DataChunk EMPTY;

			// Token: 0x04008AE8 RID: 35560
			[Token(Token = "0x4008AE8")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x04008AE9 RID: 35561
			[Token(Token = "0x4008AE9")]
			[FieldOffset(Offset = "0x18")]
			public DataFromServerStorage.DataChunk.Config config;

			// Token: 0x04008AEA RID: 35562
			[Token(Token = "0x4008AEA")]
			[FieldOffset(Offset = "0x20")]
			public DataFromServerStorage.DataChunk.Status status;

			// Token: 0x04008AEB RID: 35563
			[Token(Token = "0x4008AEB")]
			[FieldOffset(Offset = "0x28")]
			public object data;

			// Token: 0x020016F9 RID: 5881
			[Token(Token = "0x20016F9")]
			public struct Config
			{
				// Token: 0x04008AEC RID: 35564
				[Token(Token = "0x4008AEC")]
				[FieldOffset(Offset = "0x0")]
				public static readonly DataFromServerStorage.DataChunk.Config DEFAULT;

				// Token: 0x04008AED RID: 35565
				[Token(Token = "0x4008AED")]
				[FieldOffset(Offset = "0x0")]
				public bool clearWhenLogin;

				// Token: 0x04008AEE RID: 35566
				[Token(Token = "0x4008AEE")]
				[FieldOffset(Offset = "0x1")]
				public bool clearWhenCrossDay;
			}

			// Token: 0x020016FA RID: 5882
			[Token(Token = "0x20016FA")]
			public struct Status
			{
				// Token: 0x04008AEF RID: 35567
				[Token(Token = "0x4008AEF")]
				[FieldOffset(Offset = "0x0")]
				public DateTime lastRefreshTs;
			}
		}

		// Token: 0x020016FB RID: 5883
		[Token(Token = "0x20016FB")]
		public struct GetDataResult
		{
			// Token: 0x04008AF0 RID: 35568
			[Token(Token = "0x4008AF0")]
			[FieldOffset(Offset = "0x0")]
			public bool needCrossDay;

			// Token: 0x04008AF1 RID: 35569
			[Token(Token = "0x4008AF1")]
			[FieldOffset(Offset = "0x8")]
			public DataFromServerStorage.DataChunk chunk;
		}
	}
}
