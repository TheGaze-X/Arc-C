using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003875 RID: 14453
	[Token(Token = "0x2003875")]
	[Hotfix(HotfixFlag.Stateless)]
	public class UISyncDataUtil : Singleton<UISyncDataUtil>
	{
		// Token: 0x06016E35 RID: 93749 RVA: 0x00093948 File Offset: 0x00091B48
		[Token(Token = "0x6016E35")]
		[Address(RVA = "0xF66B00", Offset = "0xF65700", VA = "0x180F66B00")]
		private UISyncDataUtil.EventStruct _FindNextSyncEvent()
		{
			return default(UISyncDataUtil.EventStruct);
		}

		// Token: 0x06016E36 RID: 93750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E36")]
		[Address(RVA = "0xF675E0", Offset = "0xF661E0", VA = "0x180F675E0")]
		private UISyncDataUtil()
		{
		}

		// Token: 0x06016E37 RID: 93751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E37")]
		[Address(RVA = "0xF66110", Offset = "0xF64D10", VA = "0x180F66110")]
		public static void NotifyDataSync()
		{
		}

		// Token: 0x06016E38 RID: 93752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E38")]
		[Address(RVA = "0xF66050", Offset = "0xF64C50", VA = "0x180F66050")]
		public static void NotifyAuth()
		{
		}

		// Token: 0x06016E39 RID: 93753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016E39")]
		[Address(RVA = "0xF65FC0", Offset = "0xF64BC0", VA = "0x180F65FC0")]
		public static PlayerSyncStatusViewModel GetSyncStatusModel()
		{
			return null;
		}

		// Token: 0x06016E3A RID: 93754 RVA: 0x00093960 File Offset: 0x00091B60
		[Token(Token = "0x6016E3A")]
		[Address(RVA = "0xF65F40", Offset = "0xF64B40", VA = "0x180F65F40")]
		public static int GetLoginSession()
		{
			return 0;
		}

		// Token: 0x06016E3B RID: 93755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016E3B")]
		[Address(RVA = "0xF65EB0", Offset = "0xF64AB0", VA = "0x180F65EB0")]
		public static List<string> GetForbiddenShopList()
		{
			return null;
		}

		// Token: 0x06016E3C RID: 93756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016E3C")]
		[Address(RVA = "0xF65E20", Offset = "0xF64A20", VA = "0x180F65E20")]
		public static List<string> GetForbiddenGachaList()
		{
			return null;
		}

		// Token: 0x06016E3D RID: 93757 RVA: 0x00093978 File Offset: 0x00091B78
		[Token(Token = "0x6016E3D")]
		[Address(RVA = "0xF65D70", Offset = "0xF64970", VA = "0x180F65D70")]
		public bool CheckIfToReauth()
		{
			return default(bool);
		}

		// Token: 0x06016E3E RID: 93758 RVA: 0x00093990 File Offset: 0x00091B90
		[Token(Token = "0x6016E3E")]
		[Address(RVA = "0xF65C80", Offset = "0xF64880", VA = "0x180F65C80")]
		public bool CheckIfCrossDays()
		{
			return default(bool);
		}

		// Token: 0x06016E3F RID: 93759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E3F")]
		[Address(RVA = "0xF661D0", Offset = "0xF64DD0", VA = "0x180F661D0")]
		public void TrySyncPlayerStatus(Action<PlayerSyncStatusViewModel, bool> callback)
		{
		}

		// Token: 0x06016E40 RID: 93760 RVA: 0x000939A8 File Offset: 0x00091BA8
		[Token(Token = "0x6016E40")]
		[Address(RVA = "0xF65C00", Offset = "0xF64800", VA = "0x180F65C00")]
		public bool CheckCrossDaysAndResync()
		{
			return default(bool);
		}

		// Token: 0x06016E41 RID: 93761 RVA: 0x000939C0 File Offset: 0x00091BC0
		[Token(Token = "0x6016E41")]
		[Address(RVA = "0xF65B80", Offset = "0xF64780", VA = "0x180F65B80")]
		public bool CheckCrossDaysAndResyncIgnoreCheckin()
		{
			return default(bool);
		}

		// Token: 0x06016E42 RID: 93762 RVA: 0x000939D8 File Offset: 0x00091BD8
		[Token(Token = "0x6016E42")]
		[Address(RVA = "0xF66370", Offset = "0xF64F70", VA = "0x180F66370")]
		private bool _CheckCrossDaysAndResync(bool ignoreCheckin)
		{
			return default(bool);
		}

		// Token: 0x06016E43 RID: 93763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E43")]
		[Address(RVA = "0xF671F0", Offset = "0xF65DF0", VA = "0x180F671F0")]
		private void _RouteToHomeToResync()
		{
		}

		// Token: 0x06016E44 RID: 93764 RVA: 0x000939F0 File Offset: 0x00091BF0
		[Token(Token = "0x6016E44")]
		[Address(RVA = "0xF66640", Offset = "0xF65240", VA = "0x180F66640")]
		private static bool _CheckIfCanCheckin()
		{
			return default(bool);
		}

		// Token: 0x06016E45 RID: 93765 RVA: 0x00093A08 File Offset: 0x00091C08
		[Token(Token = "0x6016E45")]
		[Address(RVA = "0xF666F0", Offset = "0xF652F0", VA = "0x180F666F0")]
		private bool _CheckIfSyncStatusDirty()
		{
			return default(bool);
		}

		// Token: 0x06016E46 RID: 93766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E46")]
		[Address(RVA = "0xF67500", Offset = "0xF66100", VA = "0x180F67500")]
		private void _UpdateCacheAfterSyncStatus()
		{
		}

		// Token: 0x06016E47 RID: 93767 RVA: 0x00093A20 File Offset: 0x00091C20
		[Token(Token = "0x6016E47")]
		[Address(RVA = "0xF66950", Offset = "0xF65550", VA = "0x180F66950")]
		private static bool _CheckIfToSyncByTime(DateTime curTime, ref DateTime lastUpdateTime)
		{
			return default(bool);
		}

		// Token: 0x06016E48 RID: 93768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016E48")]
		[Address(RVA = "0xF66DF0", Offset = "0xF659F0", VA = "0x180F66DF0")]
		private static List<UISyncDataUtil.EventStruct> _InitStatusSyncEventList()
		{
			return null;
		}

		// Token: 0x0401B9F1 RID: 113137
		[Token(Token = "0x401B9F1")]
		private const int SYNC_STATUS_INTERVAL_COUNT = 5;

		// Token: 0x0401B9F2 RID: 113138
		[Token(Token = "0x401B9F2")]
		private const int SYNC_STATUS_INTERVAL_SECONDS = 600;

		// Token: 0x0401B9F3 RID: 113139
		[Token(Token = "0x401B9F3")]
		private const int SYNC_STATUS_INTERVAL_FIXED = 300;

		// Token: 0x0401B9F4 RID: 113140
		[Token(Token = "0x401B9F4")]
		[FieldOffset(Offset = "0x0")]
		private static int s_loginSession;

		// Token: 0x0401B9F5 RID: 113141
		[Token(Token = "0x401B9F5")]
		[FieldOffset(Offset = "0x10")]
		private long m_lastSyncDataTs;

		// Token: 0x0401B9F6 RID: 113142
		[Token(Token = "0x401B9F6")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isInitSyncStatus;

		// Token: 0x0401B9F7 RID: 113143
		[Token(Token = "0x401B9F7")]
		[FieldOffset(Offset = "0x1C")]
		private int m_syncStatusTryTriggerCount;

		// Token: 0x0401B9F8 RID: 113144
		[Token(Token = "0x401B9F8")]
		[FieldOffset(Offset = "0x20")]
		private DateTime m_lastAuthTime;

		// Token: 0x0401B9F9 RID: 113145
		[Token(Token = "0x401B9F9")]
		[FieldOffset(Offset = "0x28")]
		private UISyncDataUtil.SyncServiceController m_syncServiceController;

		// Token: 0x0401B9FA RID: 113146
		[Token(Token = "0x401B9FA")]
		[FieldOffset(Offset = "0x30")]
		private PlayerSyncStatusViewModel m_cachedViewModel;

		// Token: 0x0401B9FB RID: 113147
		[Token(Token = "0x401B9FB")]
		[FieldOffset(Offset = "0x38")]
		private List<UISyncDataUtil.EventStruct> m_staticSyncEvents;

		// Token: 0x0401B9FC RID: 113148
		[Token(Token = "0x401B9FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FindNextSyncEvent;

		// Token: 0x0401B9FD RID: 113149
		[Token(Token = "0x401B9FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B9FE RID: 113150
		[Token(Token = "0x401B9FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifyDataSync;

		// Token: 0x0401B9FF RID: 113151
		[Token(Token = "0x401B9FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyAuth;

		// Token: 0x0401BA00 RID: 113152
		[Token(Token = "0x401BA00")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSyncStatusModel;

		// Token: 0x0401BA01 RID: 113153
		[Token(Token = "0x401BA01")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetLoginSession;

		// Token: 0x0401BA02 RID: 113154
		[Token(Token = "0x401BA02")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetForbiddenShopList;

		// Token: 0x0401BA03 RID: 113155
		[Token(Token = "0x401BA03")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetForbiddenGachaList;

		// Token: 0x0401BA04 RID: 113156
		[Token(Token = "0x401BA04")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfToReauth;

		// Token: 0x0401BA05 RID: 113157
		[Token(Token = "0x401BA05")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfCrossDays;

		// Token: 0x0401BA06 RID: 113158
		[Token(Token = "0x401BA06")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TrySyncPlayerStatus;

		// Token: 0x0401BA07 RID: 113159
		[Token(Token = "0x401BA07")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckCrossDaysAndResync;

		// Token: 0x0401BA08 RID: 113160
		[Token(Token = "0x401BA08")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckCrossDaysAndResyncIgnoreCheckin;

		// Token: 0x0401BA09 RID: 113161
		[Token(Token = "0x401BA09")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckCrossDaysAndResync;

		// Token: 0x0401BA0A RID: 113162
		[Token(Token = "0x401BA0A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RouteToHomeToResync;

		// Token: 0x0401BA0B RID: 113163
		[Token(Token = "0x401BA0B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CheckIfCanCheckin;

		// Token: 0x0401BA0C RID: 113164
		[Token(Token = "0x401BA0C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckIfSyncStatusDirty;

		// Token: 0x0401BA0D RID: 113165
		[Token(Token = "0x401BA0D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateCacheAfterSyncStatus;

		// Token: 0x0401BA0E RID: 113166
		[Token(Token = "0x401BA0E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CheckIfToSyncByTime;

		// Token: 0x0401BA0F RID: 113167
		[Token(Token = "0x401BA0F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InitStatusSyncEventList;

		// Token: 0x02003876 RID: 14454
		[Token(Token = "0x2003876")]
		private struct EventStruct
		{
			// Token: 0x06016E4A RID: 93770 RVA: 0x00093A38 File Offset: 0x00091C38
			[Token(Token = "0x6016E4A")]
			[Address(RVA = "0xF58FC0", Offset = "0xF57BC0", VA = "0x180F58FC0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0401BA10 RID: 113168
			[Token(Token = "0x401BA10")]
			[FieldOffset(Offset = "0x0")]
			public long ts;

			// Token: 0x0401BA11 RID: 113169
			[Token(Token = "0x401BA11")]
			[FieldOffset(Offset = "0x8")]
			public PlayerSyncStatusEvent eventType;
		}

		// Token: 0x02003877 RID: 14455
		[Token(Token = "0x2003877")]
		private enum TrySyncFrequency
		{
			// Token: 0x0401BA13 RID: 113171
			[Token(Token = "0x401BA13")]
			CUSTMIZED,
			// Token: 0x0401BA14 RID: 113172
			[Token(Token = "0x401BA14")]
			HIGH,
			// Token: 0x0401BA15 RID: 113173
			[Token(Token = "0x401BA15")]
			MEDIUM,
			// Token: 0x0401BA16 RID: 113174
			[Token(Token = "0x401BA16")]
			LOW
		}

		// Token: 0x02003878 RID: 14456
		[Token(Token = "0x2003878")]
		private struct TrySyncContext : ILuaCallCSharp
		{
			// Token: 0x06016E4B RID: 93771 RVA: 0x00093A50 File Offset: 0x00091C50
			[Token(Token = "0x6016E4B")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0401BA17 RID: 113175
			[Token(Token = "0x401BA17")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UISyncDataUtil.TrySyncContext EMPTY;

			// Token: 0x0401BA18 RID: 113176
			[Token(Token = "0x401BA18")]
			[FieldOffset(Offset = "0x0")]
			private bool m_isEmpty;

			// Token: 0x0401BA19 RID: 113177
			[Token(Token = "0x401BA19")]
			[FieldOffset(Offset = "0x4")]
			public int missedCount;

			// Token: 0x0401BA1A RID: 113178
			[Token(Token = "0x401BA1A")]
			[FieldOffset(Offset = "0x8")]
			public DateTime lastSyncTime;
		}

		// Token: 0x02003879 RID: 14457
		[Token(Token = "0x2003879")]
		private class SyncLifeCycleContext : IHotfixable
		{
			// Token: 0x06016E4D RID: 93773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E4D")]
			[Address(RVA = "0xF5CF40", Offset = "0xF5BB40", VA = "0x180F5CF40")]
			public void Clear()
			{
			}

			// Token: 0x06016E4E RID: 93774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E4E")]
			[Address(RVA = "0xF5D020", Offset = "0xF5BC20", VA = "0x180F5D020")]
			public SyncLifeCycleContext()
			{
			}

			// Token: 0x0401BA1B RID: 113179
			[Token(Token = "0x401BA1B")]
			[FieldOffset(Offset = "0x10")]
			public bool isBusy;

			// Token: 0x0401BA1C RID: 113180
			[Token(Token = "0x401BA1C")]
			[FieldOffset(Offset = "0x18")]
			public List<UISyncDataUtil.AbstractSyncServiceItem> syncingList;

			// Token: 0x0401BA1D RID: 113181
			[Token(Token = "0x401BA1D")]
			[FieldOffset(Offset = "0x20")]
			public List<string> serviceCodeList;

			// Token: 0x0401BA1E RID: 113182
			[Token(Token = "0x401BA1E")]
			[FieldOffset(Offset = "0x28")]
			public PlayerSyncStatusViewModel syncViewModel;

			// Token: 0x0401BA1F RID: 113183
			[Token(Token = "0x401BA1F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Clear;

			// Token: 0x0401BA20 RID: 113184
			[Token(Token = "0x401BA20")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200387A RID: 14458
		[Token(Token = "0x200387A")]
		private abstract class AbstractSyncServiceItem : IHotfixable
		{
			// Token: 0x06016E4F RID: 93775 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E4F")]
			[Address(RVA = "0xF530B0", Offset = "0xF51CB0", VA = "0x180F530B0")]
			public void ResetSyncContext(DateTime syncTime)
			{
			}

			// Token: 0x06016E50 RID: 93776 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E50")]
			[Address(RVA = "0xF53050", Offset = "0xF51C50", VA = "0x180F53050")]
			public void MarkMissed()
			{
			}

			// Token: 0x06016E51 RID: 93777 RVA: 0x00093A68 File Offset: 0x00091C68
			[Token(Token = "0x6016E51")]
			[Address(RVA = "0xF52E10", Offset = "0xF51A10", VA = "0x180F52E10")]
			public bool CheckIfToSync(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x170036A5 RID: 13989
			// (get) Token: 0x06016E52 RID: 93778
			[Token(Token = "0x170036A5")]
			public abstract UISyncDataUtil.TrySyncFrequency frequency { [Token(Token = "0x6016E52")] get; }

			// Token: 0x170036A6 RID: 13990
			// (get) Token: 0x06016E53 RID: 93779
			[Token(Token = "0x170036A6")]
			public abstract PlayerSyncModuleMask moduleMask { [Token(Token = "0x6016E53")] get; }

			// Token: 0x06016E54 RID: 93780 RVA: 0x00093A80 File Offset: 0x00091C80
			[Token(Token = "0x6016E54")]
			[Address(RVA = "0xF52DA0", Offset = "0xF519A0", VA = "0x180F52DA0", Slot = "6")]
			protected virtual bool CheckIfToSyncCustomized(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x06016E55 RID: 93781 RVA: 0x00093A98 File Offset: 0x00091C98
			[Token(Token = "0x6016E55")]
			[Address(RVA = "0xF53130", Offset = "0xF51D30", VA = "0x180F53130")]
			private bool _CheckIfToSyncByContext(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x170036A7 RID: 13991
			// (get) Token: 0x06016E56 RID: 93782
			[Token(Token = "0x170036A7")]
			public abstract bool uniqueServiceFlag { [Token(Token = "0x6016E56")] get; }

			// Token: 0x06016E57 RID: 93783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E57")]
			[Address(RVA = "0xF532C0", Offset = "0xF51EC0", VA = "0x180F532C0")]
			protected AbstractSyncServiceItem()
			{
			}

			// Token: 0x0401BA21 RID: 113185
			[Token(Token = "0x401BA21")]
			[FieldOffset(Offset = "0x10")]
			private UISyncDataUtil.TrySyncContext m_trySyncContext;

			// Token: 0x0401BA22 RID: 113186
			[Token(Token = "0x401BA22")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ResetSyncContext;

			// Token: 0x0401BA23 RID: 113187
			[Token(Token = "0x401BA23")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_MarkMissed;

			// Token: 0x0401BA24 RID: 113188
			[Token(Token = "0x401BA24")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CheckIfToSync;

			// Token: 0x0401BA25 RID: 113189
			[Token(Token = "0x401BA25")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CheckIfToSyncCustomized;

			// Token: 0x0401BA26 RID: 113190
			[Token(Token = "0x401BA26")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__CheckIfToSyncByContext;

			// Token: 0x0401BA27 RID: 113191
			[Token(Token = "0x401BA27")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200387B RID: 14459
		[Token(Token = "0x200387B")]
		private interface ICommonServiceItem
		{
			// Token: 0x06016E58 RID: 93784
			[Token(Token = "0x6016E58")]
			void InterfaceFillResponseResult(PlayerSyncStatusViewModel viewModel, JObject resultObj);

			// Token: 0x06016E59 RID: 93785
			[Token(Token = "0x6016E59")]
			void InterfaceHoldResponseResult(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel);

			// Token: 0x06016E5A RID: 93786
			[Token(Token = "0x6016E5A")]
			void OnSyncStatusFinished(long moduleMask, long curTs);

			// Token: 0x06016E5B RID: 93787
			[Token(Token = "0x6016E5B")]
			PlayerSyncParam InterfaceBuildRequestParam();
		}

		// Token: 0x0200387C RID: 14460
		[Token(Token = "0x200387C")]
		private interface ISingleServiceItem
		{
			// Token: 0x170036A8 RID: 13992
			// (get) Token: 0x06016E5C RID: 93788
			[Token(Token = "0x170036A8")]
			string serviceCode { [Token(Token = "0x6016E5C")] get; }

			// Token: 0x06016E5D RID: 93789
			[Token(Token = "0x6016E5D")]
			void SendService(Action OnFinish);
		}

		// Token: 0x0200387D RID: 14461
		[Token(Token = "0x200387D")]
		private abstract class SingleServiceItem<Request, Response> : UISyncDataUtil.AbstractSyncServiceItem, UISyncDataUtil.ISingleServiceItem, IHotfixable
		{
			// Token: 0x170036A9 RID: 13993
			// (get) Token: 0x06016E5E RID: 93790 RVA: 0x00093AB0 File Offset: 0x00091CB0
			[Token(Token = "0x170036A9")]
			public override bool uniqueServiceFlag
			{
				[Token(Token = "0x6016E5E")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170036AA RID: 13994
			// (get) Token: 0x06016E5F RID: 93791
			[Token(Token = "0x170036AA")]
			public abstract string serviceCode { [Token(Token = "0x6016E5F")] get; }

			// Token: 0x06016E60 RID: 93792
			[Token(Token = "0x6016E60")]
			public abstract void SendService(Action OnFinish);

			// Token: 0x06016E61 RID: 93793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E61")]
			protected SingleServiceItem()
			{
			}

			// Token: 0x0401BA28 RID: 113192
			[Token(Token = "0x401BA28")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_uniqueServiceFlag;

			// Token: 0x0401BA29 RID: 113193
			[Token(Token = "0x401BA29")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200387E RID: 14462
		[Token(Token = "0x200387E")]
		private abstract class CommonSyncServiceItem<Param, Result> : UISyncDataUtil.AbstractSyncServiceItem, UISyncDataUtil.ICommonServiceItem, IHotfixable where Param : PlayerSyncParam where Result : PlayerSyncResult
		{
			// Token: 0x06016E62 RID: 93794 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E62")]
			public void InterfaceFillResponseResult(PlayerSyncStatusViewModel viewModel, JObject resultObj)
			{
			}

			// Token: 0x06016E63 RID: 93795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E63")]
			public void InterfaceHoldResponseResult(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016E64 RID: 93796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016E64")]
			public PlayerSyncParam InterfaceBuildRequestParam()
			{
				return null;
			}

			// Token: 0x170036AB RID: 13995
			// (get) Token: 0x06016E65 RID: 93797 RVA: 0x00093AC8 File Offset: 0x00091CC8
			[Token(Token = "0x170036AB")]
			public override bool uniqueServiceFlag
			{
				[Token(Token = "0x6016E65")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06016E66 RID: 93798
			[Token(Token = "0x6016E66")]
			protected abstract Param BuildRequestParam();

			// Token: 0x06016E67 RID: 93799
			[Token(Token = "0x6016E67")]
			protected abstract void FillResponseModel(PlayerSyncStatusViewModel viewModel, Result result);

			// Token: 0x06016E68 RID: 93800
			[Token(Token = "0x6016E68")]
			protected abstract void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel);

			// Token: 0x06016E69 RID: 93801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E69")]
			public virtual void OnSyncStatusFinished(long moduleMask, long curTs)
			{
			}

			// Token: 0x06016E6A RID: 93802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016E6A")]
			private Result _BuildResponseResult(JObject result)
			{
				return null;
			}

			// Token: 0x06016E6B RID: 93803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E6B")]
			protected CommonSyncServiceItem()
			{
			}

			// Token: 0x0401BA2A RID: 113194
			[Token(Token = "0x401BA2A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InterfaceFillResponseResult;

			// Token: 0x0401BA2B RID: 113195
			[Token(Token = "0x401BA2B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InterfaceHoldResponseResult;

			// Token: 0x0401BA2C RID: 113196
			[Token(Token = "0x401BA2C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InterfaceBuildRequestParam;

			// Token: 0x0401BA2D RID: 113197
			[Token(Token = "0x401BA2D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_uniqueServiceFlag;

			// Token: 0x0401BA2E RID: 113198
			[Token(Token = "0x401BA2E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnSyncStatusFinished;

			// Token: 0x0401BA2F RID: 113199
			[Token(Token = "0x401BA2F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__BuildResponseResult;

			// Token: 0x0401BA30 RID: 113200
			[Token(Token = "0x401BA30")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200387F RID: 14463
		[Token(Token = "0x200387F")]
		private class SyncServiceController
		{
			// Token: 0x06016E6C RID: 93804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E6C")]
			[Address(RVA = "0xF5D120", Offset = "0xF5BD20", VA = "0x180F5D120")]
			public void StartSync(PlayerSyncStatusViewModel cachedModel, Action<PlayerSyncStatusViewModel> callback)
			{
			}

			// Token: 0x06016E6D RID: 93805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E6D")]
			[Address(RVA = "0xF5D8E0", Offset = "0xF5C4E0", VA = "0x180F5D8E0")]
			private void _CheckAllReceive(string serviceCode, Action<PlayerSyncStatusViewModel> callBack)
			{
			}

			// Token: 0x06016E6E RID: 93806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E6E")]
			[Address(RVA = "0xF5DAC0", Offset = "0xF5C6C0", VA = "0x180F5DAC0")]
			public SyncServiceController()
			{
			}

			// Token: 0x0401BA31 RID: 113201
			[Token(Token = "0x401BA31")]
			[FieldOffset(Offset = "0x10")]
			private readonly List<UISyncDataUtil.AbstractSyncServiceItem> SYNC_ITEMS;

			// Token: 0x0401BA32 RID: 113202
			[Token(Token = "0x401BA32")]
			[FieldOffset(Offset = "0x18")]
			private UISyncDataUtil.SyncLifeCycleContext m_lifecycleContext;
		}

		// Token: 0x02003883 RID: 14467
		[Token(Token = "0x2003883")]
		private class UnreadMailSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerSyncResult>
		{
			// Token: 0x170036AC RID: 13996
			// (get) Token: 0x06016E77 RID: 93815 RVA: 0x00093AF8 File Offset: 0x00091CF8
			[Token(Token = "0x170036AC")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016E77")]
				[Address(RVA = "0xF6C130", Offset = "0xF6AD30", VA = "0x180F6C130", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x170036AD RID: 13997
			// (get) Token: 0x06016E78 RID: 93816 RVA: 0x00093B10 File Offset: 0x00091D10
			[Token(Token = "0x170036AD")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016E78")]
				[Address(RVA = "0xF6C1E0", Offset = "0xF6ADE0", VA = "0x180F6C1E0", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016E79 RID: 93817 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016E79")]
			[Address(RVA = "0xF6BF60", Offset = "0xF6AB60", VA = "0x180F6BF60", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016E7A RID: 93818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E7A")]
			[Address(RVA = "0xF6BFC0", Offset = "0xF6ABC0", VA = "0x180F6BFC0", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncResult result)
			{
			}

			// Token: 0x06016E7B RID: 93819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E7B")]
			[Address(RVA = "0xF6C040", Offset = "0xF6AC40", VA = "0x180F6C040", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016E7C RID: 93820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E7C")]
			[Address(RVA = "0xF6C0C0", Offset = "0xF6ACC0", VA = "0x180F6C0C0")]
			public UnreadMailSyncItem()
			{
			}

			// Token: 0x0401BA3B RID: 113211
			[Token(Token = "0x401BA3B")]
			[FieldOffset(Offset = "0x20")]
			private DateTime m_lastSyncDateTime;

			// Token: 0x0401BA3C RID: 113212
			[Token(Token = "0x401BA3C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA3D RID: 113213
			[Token(Token = "0x401BA3D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA3E RID: 113214
			[Token(Token = "0x401BA3E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA3F RID: 113215
			[Token(Token = "0x401BA3F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA40 RID: 113216
			[Token(Token = "0x401BA40")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA41 RID: 113217
			[Token(Token = "0x401BA41")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003884 RID: 14468
		[Token(Token = "0x2003884")]
		private class FriendRequestSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerSyncResult>
		{
			// Token: 0x170036AE RID: 13998
			// (get) Token: 0x06016E7D RID: 93821 RVA: 0x00093B28 File Offset: 0x00091D28
			[Token(Token = "0x170036AE")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016E7D")]
				[Address(RVA = "0xF591A0", Offset = "0xF57DA0", VA = "0x180F591A0", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x170036AF RID: 13999
			// (get) Token: 0x06016E7E RID: 93822 RVA: 0x00093B40 File Offset: 0x00091D40
			[Token(Token = "0x170036AF")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016E7E")]
				[Address(RVA = "0xF59250", Offset = "0xF57E50", VA = "0x180F59250", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016E7F RID: 93823 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016E7F")]
			[Address(RVA = "0xF58FD0", Offset = "0xF57BD0", VA = "0x180F58FD0", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016E80 RID: 93824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E80")]
			[Address(RVA = "0xF59030", Offset = "0xF57C30", VA = "0x180F59030", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncResult result)
			{
			}

			// Token: 0x06016E81 RID: 93825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E81")]
			[Address(RVA = "0xF590B0", Offset = "0xF57CB0", VA = "0x180F590B0", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016E82 RID: 93826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E82")]
			[Address(RVA = "0xF59130", Offset = "0xF57D30", VA = "0x180F59130")]
			public FriendRequestSyncItem()
			{
			}

			// Token: 0x0401BA42 RID: 113218
			[Token(Token = "0x401BA42")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA43 RID: 113219
			[Token(Token = "0x401BA43")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA44 RID: 113220
			[Token(Token = "0x401BA44")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA45 RID: 113221
			[Token(Token = "0x401BA45")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA46 RID: 113222
			[Token(Token = "0x401BA46")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA47 RID: 113223
			[Token(Token = "0x401BA47")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003885 RID: 14469
		[Token(Token = "0x2003885")]
		private class AnnounceVersionSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerSyncAnnounceVersionResult>
		{
			// Token: 0x170036B0 RID: 14000
			// (get) Token: 0x06016E83 RID: 93827 RVA: 0x00093B58 File Offset: 0x00091D58
			[Token(Token = "0x170036B0")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016E83")]
				[Address(RVA = "0xF54CD0", Offset = "0xF538D0", VA = "0x180F54CD0", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x170036B1 RID: 14001
			// (get) Token: 0x06016E84 RID: 93828 RVA: 0x00093B70 File Offset: 0x00091D70
			[Token(Token = "0x170036B1")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016E84")]
				[Address(RVA = "0xF54D80", Offset = "0xF53980", VA = "0x180F54D80", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016E85 RID: 93829 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016E85")]
			[Address(RVA = "0xF54A80", Offset = "0xF53680", VA = "0x180F54A80", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016E86 RID: 93830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E86")]
			[Address(RVA = "0xF54AE0", Offset = "0xF536E0", VA = "0x180F54AE0", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncAnnounceVersionResult result)
			{
			}

			// Token: 0x06016E87 RID: 93831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E87")]
			[Address(RVA = "0xF54BA0", Offset = "0xF537A0", VA = "0x180F54BA0", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016E88 RID: 93832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E88")]
			[Address(RVA = "0xF54C60", Offset = "0xF53860", VA = "0x180F54C60")]
			public AnnounceVersionSyncItem()
			{
			}

			// Token: 0x0401BA48 RID: 113224
			[Token(Token = "0x401BA48")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA49 RID: 113225
			[Token(Token = "0x401BA49")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA4A RID: 113226
			[Token(Token = "0x401BA4A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA4B RID: 113227
			[Token(Token = "0x401BA4B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA4C RID: 113228
			[Token(Token = "0x401BA4C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA4D RID: 113229
			[Token(Token = "0x401BA4D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003886 RID: 14470
		[Token(Token = "0x2003886")]
		private class UserCardSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerSyncResult>
		{
			// Token: 0x170036B2 RID: 14002
			// (get) Token: 0x06016E89 RID: 93833 RVA: 0x00093B88 File Offset: 0x00091D88
			[Token(Token = "0x170036B2")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016E89")]
				[Address(RVA = "0xF6C4F0", Offset = "0xF6B0F0", VA = "0x180F6C4F0", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x06016E8A RID: 93834 RVA: 0x00093BA0 File Offset: 0x00091DA0
			[Token(Token = "0x6016E8A")]
			[Address(RVA = "0xF6C2A0", Offset = "0xF6AEA0", VA = "0x180F6C2A0", Slot = "6")]
			protected override bool CheckIfToSyncCustomized(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x170036B3 RID: 14003
			// (get) Token: 0x06016E8B RID: 93835 RVA: 0x00093BB8 File Offset: 0x00091DB8
			[Token(Token = "0x170036B3")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016E8B")]
				[Address(RVA = "0xF6C5A0", Offset = "0xF6B1A0", VA = "0x180F6C5A0", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016E8C RID: 93836 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016E8C")]
			[Address(RVA = "0xF6C240", Offset = "0xF6AE40", VA = "0x180F6C240", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016E8D RID: 93837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E8D")]
			[Address(RVA = "0xF6C340", Offset = "0xF6AF40", VA = "0x180F6C340", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncResult result)
			{
			}

			// Token: 0x06016E8E RID: 93838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E8E")]
			[Address(RVA = "0xF6C3C0", Offset = "0xF6AFC0", VA = "0x180F6C3C0", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016E8F RID: 93839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E8F")]
			[Address(RVA = "0xF6C440", Offset = "0xF6B040", VA = "0x180F6C440")]
			public UserCardSyncItem()
			{
			}

			// Token: 0x06016E90 RID: 93840 RVA: 0x00093BD0 File Offset: 0x00091DD0
			[Token(Token = "0x6016E90")]
			[Address(RVA = "0xF52DA0", Offset = "0xF519A0", VA = "0x180F52DA0")]
			private bool <>xLuaBaseProxy_CheckIfToSyncCustomized(DateTime P0)
			{
				return default(bool);
			}

			// Token: 0x0401BA4E RID: 113230
			[Token(Token = "0x401BA4E")]
			[FieldOffset(Offset = "0x20")]
			private DateTime m_lastUpdateTime;

			// Token: 0x0401BA4F RID: 113231
			[Token(Token = "0x401BA4F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA50 RID: 113232
			[Token(Token = "0x401BA50")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CheckIfToSyncCustomized;

			// Token: 0x0401BA51 RID: 113233
			[Token(Token = "0x401BA51")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA52 RID: 113234
			[Token(Token = "0x401BA52")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA53 RID: 113235
			[Token(Token = "0x401BA53")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA54 RID: 113236
			[Token(Token = "0x401BA54")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA55 RID: 113237
			[Token(Token = "0x401BA55")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003887 RID: 14471
		[Token(Token = "0x2003887")]
		private class GoodPurchaseSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncGoodPurchaseParam, PlayerSyncGoodPurchaseResult>
		{
			// Token: 0x170036B4 RID: 14004
			// (get) Token: 0x06016E91 RID: 93841 RVA: 0x00093BE8 File Offset: 0x00091DE8
			[Token(Token = "0x170036B4")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016E91")]
				[Address(RVA = "0xF599F0", Offset = "0xF585F0", VA = "0x180F599F0", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x170036B5 RID: 14005
			// (get) Token: 0x06016E92 RID: 93842 RVA: 0x00093C00 File Offset: 0x00091E00
			[Token(Token = "0x170036B5")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016E92")]
				[Address(RVA = "0xF59AA0", Offset = "0xF586A0", VA = "0x180F59AA0", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016E93 RID: 93843 RVA: 0x00093C18 File Offset: 0x00091E18
			[Token(Token = "0x6016E93")]
			[Address(RVA = "0xF59570", Offset = "0xF58170", VA = "0x180F59570", Slot = "6")]
			protected override bool CheckIfToSyncCustomized(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x06016E94 RID: 93844 RVA: 0x00093C30 File Offset: 0x00091E30
			[Token(Token = "0x6016E94")]
			[Address(RVA = "0xF59750", Offset = "0xF58350", VA = "0x180F59750")]
			private static bool _CheckIfToSync(DateTime curTime, DateTime lastTime)
			{
				return default(bool);
			}

			// Token: 0x06016E95 RID: 93845 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016E95")]
			[Address(RVA = "0xF592B0", Offset = "0xF57EB0", VA = "0x180F592B0", Slot = "12")]
			protected override PlayerSyncGoodPurchaseParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016E96 RID: 93846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E96")]
			[Address(RVA = "0xF59600", Offset = "0xF58200", VA = "0x180F59600", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncGoodPurchaseResult result)
			{
			}

			// Token: 0x06016E97 RID: 93847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E97")]
			[Address(RVA = "0xF596A0", Offset = "0xF582A0", VA = "0x180F596A0", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016E98 RID: 93848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E98")]
			[Address(RVA = "0xF59940", Offset = "0xF58540", VA = "0x180F59940")]
			public GoodPurchaseSyncItem()
			{
			}

			// Token: 0x06016E99 RID: 93849 RVA: 0x00093C48 File Offset: 0x00091E48
			[Token(Token = "0x6016E99")]
			[Address(RVA = "0xF52DA0", Offset = "0xF519A0", VA = "0x180F52DA0")]
			private bool <>xLuaBaseProxy_CheckIfToSyncCustomized(DateTime P0)
			{
				return default(bool);
			}

			// Token: 0x0401BA56 RID: 113238
			[Token(Token = "0x401BA56")]
			private const long UPDATE_INTERVAL_SECS = 600L;

			// Token: 0x0401BA57 RID: 113239
			[Token(Token = "0x401BA57")]
			[FieldOffset(Offset = "0x20")]
			private DateTime m_lastUpdatedTime;

			// Token: 0x0401BA58 RID: 113240
			[Token(Token = "0x401BA58")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA59 RID: 113241
			[Token(Token = "0x401BA59")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA5A RID: 113242
			[Token(Token = "0x401BA5A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CheckIfToSyncCustomized;

			// Token: 0x0401BA5B RID: 113243
			[Token(Token = "0x401BA5B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__CheckIfToSync;

			// Token: 0x0401BA5C RID: 113244
			[Token(Token = "0x401BA5C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA5D RID: 113245
			[Token(Token = "0x401BA5D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA5E RID: 113246
			[Token(Token = "0x401BA5E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA5F RID: 113247
			[Token(Token = "0x401BA5F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003888 RID: 14472
		[Token(Token = "0x2003888")]
		private class BuildingClueSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerSyncResult>
		{
			// Token: 0x170036B6 RID: 14006
			// (get) Token: 0x06016E9A RID: 93850 RVA: 0x00093C60 File Offset: 0x00091E60
			[Token(Token = "0x170036B6")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016E9A")]
				[Address(RVA = "0xF55150", Offset = "0xF53D50", VA = "0x180F55150", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x06016E9B RID: 93851 RVA: 0x00093C78 File Offset: 0x00091E78
			[Token(Token = "0x6016E9B")]
			[Address(RVA = "0xF54F00", Offset = "0xF53B00", VA = "0x180F54F00", Slot = "6")]
			protected override bool CheckIfToSyncCustomized(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x170036B7 RID: 14007
			// (get) Token: 0x06016E9C RID: 93852 RVA: 0x00093C90 File Offset: 0x00091E90
			[Token(Token = "0x170036B7")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016E9C")]
				[Address(RVA = "0xF55200", Offset = "0xF53E00", VA = "0x180F55200", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016E9D RID: 93853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016E9D")]
			[Address(RVA = "0xF54EA0", Offset = "0xF53AA0", VA = "0x180F54EA0", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016E9E RID: 93854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E9E")]
			[Address(RVA = "0xF54FA0", Offset = "0xF53BA0", VA = "0x180F54FA0", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncResult result)
			{
			}

			// Token: 0x06016E9F RID: 93855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016E9F")]
			[Address(RVA = "0xF55020", Offset = "0xF53C20", VA = "0x180F55020", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016EA0 RID: 93856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EA0")]
			[Address(RVA = "0xF550A0", Offset = "0xF53CA0", VA = "0x180F550A0")]
			public BuildingClueSyncItem()
			{
			}

			// Token: 0x06016EA1 RID: 93857 RVA: 0x00093CA8 File Offset: 0x00091EA8
			[Token(Token = "0x6016EA1")]
			[Address(RVA = "0xF52DA0", Offset = "0xF519A0", VA = "0x180F52DA0")]
			private bool <>xLuaBaseProxy_CheckIfToSyncCustomized(DateTime P0)
			{
				return default(bool);
			}

			// Token: 0x0401BA60 RID: 113248
			[Token(Token = "0x401BA60")]
			[FieldOffset(Offset = "0x20")]
			private DateTime m_lastUpdateTime;

			// Token: 0x0401BA61 RID: 113249
			[Token(Token = "0x401BA61")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA62 RID: 113250
			[Token(Token = "0x401BA62")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CheckIfToSyncCustomized;

			// Token: 0x0401BA63 RID: 113251
			[Token(Token = "0x401BA63")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA64 RID: 113252
			[Token(Token = "0x401BA64")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA65 RID: 113253
			[Token(Token = "0x401BA65")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA66 RID: 113254
			[Token(Token = "0x401BA66")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA67 RID: 113255
			[Token(Token = "0x401BA67")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003889 RID: 14473
		[Token(Token = "0x2003889")]
		private class BuildingStatusSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerSyncResult>
		{
			// Token: 0x170036B8 RID: 14008
			// (get) Token: 0x06016EA2 RID: 93858 RVA: 0x00093CC0 File Offset: 0x00091EC0
			[Token(Token = "0x170036B8")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016EA2")]
				[Address(RVA = "0xF55510", Offset = "0xF54110", VA = "0x180F55510", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x170036B9 RID: 14009
			// (get) Token: 0x06016EA3 RID: 93859 RVA: 0x00093CD8 File Offset: 0x00091ED8
			[Token(Token = "0x170036B9")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016EA3")]
				[Address(RVA = "0xF555C0", Offset = "0xF541C0", VA = "0x180F555C0", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016EA4 RID: 93860 RVA: 0x00093CF0 File Offset: 0x00091EF0
			[Token(Token = "0x6016EA4")]
			[Address(RVA = "0xF552C0", Offset = "0xF53EC0", VA = "0x180F552C0", Slot = "6")]
			protected override bool CheckIfToSyncCustomized(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x06016EA5 RID: 93861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016EA5")]
			[Address(RVA = "0xF55260", Offset = "0xF53E60", VA = "0x180F55260", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016EA6 RID: 93862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EA6")]
			[Address(RVA = "0xF553A0", Offset = "0xF53FA0", VA = "0x180F553A0", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncResult result)
			{
			}

			// Token: 0x06016EA7 RID: 93863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EA7")]
			[Address(RVA = "0xF55420", Offset = "0xF54020", VA = "0x180F55420", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016EA8 RID: 93864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EA8")]
			[Address(RVA = "0xF554A0", Offset = "0xF540A0", VA = "0x180F554A0")]
			public BuildingStatusSyncItem()
			{
			}

			// Token: 0x06016EA9 RID: 93865 RVA: 0x00093D08 File Offset: 0x00091F08
			[Token(Token = "0x6016EA9")]
			[Address(RVA = "0xF52DA0", Offset = "0xF519A0", VA = "0x180F52DA0")]
			private bool <>xLuaBaseProxy_CheckIfToSyncCustomized(DateTime P0)
			{
				return default(bool);
			}

			// Token: 0x0401BA68 RID: 113256
			[Token(Token = "0x401BA68")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA69 RID: 113257
			[Token(Token = "0x401BA69")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA6A RID: 113258
			[Token(Token = "0x401BA6A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CheckIfToSyncCustomized;

			// Token: 0x0401BA6B RID: 113259
			[Token(Token = "0x401BA6B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA6C RID: 113260
			[Token(Token = "0x401BA6C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA6D RID: 113261
			[Token(Token = "0x401BA6D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA6E RID: 113262
			[Token(Token = "0x401BA6E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200388A RID: 14474
		[Token(Token = "0x200388A")]
		private class CrisisV2StatusSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerSyncResult>
		{
			// Token: 0x170036BA RID: 14010
			// (get) Token: 0x06016EAA RID: 93866 RVA: 0x00093D20 File Offset: 0x00091F20
			[Token(Token = "0x170036BA")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016EAA")]
				[Address(RVA = "0xF58E40", Offset = "0xF57A40", VA = "0x180F58E40", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x170036BB RID: 14011
			// (get) Token: 0x06016EAB RID: 93867 RVA: 0x00093D38 File Offset: 0x00091F38
			[Token(Token = "0x170036BB")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016EAB")]
				[Address(RVA = "0xF58EF0", Offset = "0xF57AF0", VA = "0x180F58EF0", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016EAC RID: 93868 RVA: 0x00093D50 File Offset: 0x00091F50
			[Token(Token = "0x6016EAC")]
			[Address(RVA = "0xF58BE0", Offset = "0xF577E0", VA = "0x180F58BE0", Slot = "6")]
			protected override bool CheckIfToSyncCustomized(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x06016EAD RID: 93869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016EAD")]
			[Address(RVA = "0xF58B80", Offset = "0xF57780", VA = "0x180F58B80", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016EAE RID: 93870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EAE")]
			[Address(RVA = "0xF58CD0", Offset = "0xF578D0", VA = "0x180F58CD0", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncResult result)
			{
			}

			// Token: 0x06016EAF RID: 93871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EAF")]
			[Address(RVA = "0xF58D50", Offset = "0xF57950", VA = "0x180F58D50", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016EB0 RID: 93872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EB0")]
			[Address(RVA = "0xF58DD0", Offset = "0xF579D0", VA = "0x180F58DD0")]
			public CrisisV2StatusSyncItem()
			{
			}

			// Token: 0x06016EB1 RID: 93873 RVA: 0x00093D68 File Offset: 0x00091F68
			[Token(Token = "0x6016EB1")]
			[Address(RVA = "0xF52DA0", Offset = "0xF519A0", VA = "0x180F52DA0")]
			private bool <>xLuaBaseProxy_CheckIfToSyncCustomized(DateTime P0)
			{
				return default(bool);
			}

			// Token: 0x0401BA6F RID: 113263
			[Token(Token = "0x401BA6F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA70 RID: 113264
			[Token(Token = "0x401BA70")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA71 RID: 113265
			[Token(Token = "0x401BA71")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CheckIfToSyncCustomized;

			// Token: 0x0401BA72 RID: 113266
			[Token(Token = "0x401BA72")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA73 RID: 113267
			[Token(Token = "0x401BA73")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA74 RID: 113268
			[Token(Token = "0x401BA74")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA75 RID: 113269
			[Token(Token = "0x401BA75")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200388B RID: 14475
		[Token(Token = "0x200388B")]
		private class ActivityStatusSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerSyncResult>
		{
			// Token: 0x170036BC RID: 14012
			// (get) Token: 0x06016EB2 RID: 93874 RVA: 0x00093D80 File Offset: 0x00091F80
			[Token(Token = "0x170036BC")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016EB2")]
				[Address(RVA = "0xF54770", Offset = "0xF53370", VA = "0x180F54770", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x170036BD RID: 14013
			// (get) Token: 0x06016EB3 RID: 93875 RVA: 0x00093D98 File Offset: 0x00091F98
			[Token(Token = "0x170036BD")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016EB3")]
				[Address(RVA = "0xF54820", Offset = "0xF53420", VA = "0x180F54820", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016EB4 RID: 93876 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016EB4")]
			[Address(RVA = "0xF54400", Offset = "0xF53000", VA = "0x180F54400", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016EB5 RID: 93877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EB5")]
			[Address(RVA = "0xF54530", Offset = "0xF53130", VA = "0x180F54530", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncResult result)
			{
			}

			// Token: 0x06016EB6 RID: 93878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EB6")]
			[Address(RVA = "0xF545B0", Offset = "0xF531B0", VA = "0x180F545B0", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016EB7 RID: 93879 RVA: 0x00093DB0 File Offset: 0x00091FB0
			[Token(Token = "0x6016EB7")]
			[Address(RVA = "0xF54460", Offset = "0xF53060", VA = "0x180F54460", Slot = "6")]
			protected override bool CheckIfToSyncCustomized(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x06016EB8 RID: 93880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EB8")]
			[Address(RVA = "0xF54630", Offset = "0xF53230", VA = "0x180F54630", Slot = "15")]
			public override void OnSyncStatusFinished(long moduleMask, long curTs)
			{
			}

			// Token: 0x06016EB9 RID: 93881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EB9")]
			[Address(RVA = "0xF546F0", Offset = "0xF532F0", VA = "0x180F546F0")]
			public ActivityStatusSyncItem()
			{
			}

			// Token: 0x06016EBA RID: 93882 RVA: 0x00093DC8 File Offset: 0x00091FC8
			[Token(Token = "0x6016EBA")]
			[Address(RVA = "0xF52DA0", Offset = "0xF519A0", VA = "0x180F52DA0")]
			private bool <>xLuaBaseProxy_CheckIfToSyncCustomized(DateTime P0)
			{
				return default(bool);
			}

			// Token: 0x0401BA76 RID: 113270
			[Token(Token = "0x401BA76")]
			[FieldOffset(Offset = "0x20")]
			private long m_lastUpdateTs;

			// Token: 0x0401BA77 RID: 113271
			[Token(Token = "0x401BA77")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA78 RID: 113272
			[Token(Token = "0x401BA78")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA79 RID: 113273
			[Token(Token = "0x401BA79")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA7A RID: 113274
			[Token(Token = "0x401BA7A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA7B RID: 113275
			[Token(Token = "0x401BA7B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA7C RID: 113276
			[Token(Token = "0x401BA7C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_CheckIfToSyncCustomized;

			// Token: 0x0401BA7D RID: 113277
			[Token(Token = "0x401BA7D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnSyncStatusFinished;

			// Token: 0x0401BA7E RID: 113278
			[Token(Token = "0x401BA7E")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200388C RID: 14476
		[Token(Token = "0x200388C")]
		private class ActivityStatusFixedIntervalSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerSyncResult>
		{
			// Token: 0x170036BE RID: 14014
			// (get) Token: 0x06016EBB RID: 93883 RVA: 0x00093DE0 File Offset: 0x00091FE0
			[Token(Token = "0x170036BE")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016EBB")]
				[Address(RVA = "0xF542F0", Offset = "0xF52EF0", VA = "0x180F542F0", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x170036BF RID: 14015
			// (get) Token: 0x06016EBC RID: 93884 RVA: 0x00093DF8 File Offset: 0x00091FF8
			[Token(Token = "0x170036BF")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016EBC")]
				[Address(RVA = "0xF543A0", Offset = "0xF52FA0", VA = "0x180F543A0", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016EBD RID: 93885 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016EBD")]
			[Address(RVA = "0xF53E70", Offset = "0xF52A70", VA = "0x180F53E70", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016EBE RID: 93886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EBE")]
			[Address(RVA = "0xF540B0", Offset = "0xF52CB0", VA = "0x180F540B0", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncResult result)
			{
			}

			// Token: 0x06016EBF RID: 93887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EBF")]
			[Address(RVA = "0xF54130", Offset = "0xF52D30", VA = "0x180F54130", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016EC0 RID: 93888 RVA: 0x00093E10 File Offset: 0x00092010
			[Token(Token = "0x6016EC0")]
			[Address(RVA = "0xF53ED0", Offset = "0xF52AD0", VA = "0x180F53ED0", Slot = "6")]
			protected override bool CheckIfToSyncCustomized(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x06016EC1 RID: 93889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EC1")]
			[Address(RVA = "0xF541B0", Offset = "0xF52DB0", VA = "0x180F541B0", Slot = "15")]
			public override void OnSyncStatusFinished(long moduleMask, long curTs)
			{
			}

			// Token: 0x06016EC2 RID: 93890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EC2")]
			[Address(RVA = "0xF54270", Offset = "0xF52E70", VA = "0x180F54270")]
			public ActivityStatusFixedIntervalSyncItem()
			{
			}

			// Token: 0x06016EC3 RID: 93891 RVA: 0x00093E28 File Offset: 0x00092028
			[Token(Token = "0x6016EC3")]
			[Address(RVA = "0xF52DA0", Offset = "0xF519A0", VA = "0x180F52DA0")]
			private bool <>xLuaBaseProxy_CheckIfToSyncCustomized(DateTime P0)
			{
				return default(bool);
			}

			// Token: 0x0401BA7F RID: 113279
			[Token(Token = "0x401BA7F")]
			[FieldOffset(Offset = "0x20")]
			private long m_lastUpdateTs;

			// Token: 0x0401BA80 RID: 113280
			[Token(Token = "0x401BA80")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA81 RID: 113281
			[Token(Token = "0x401BA81")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA82 RID: 113282
			[Token(Token = "0x401BA82")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA83 RID: 113283
			[Token(Token = "0x401BA83")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA84 RID: 113284
			[Token(Token = "0x401BA84")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA85 RID: 113285
			[Token(Token = "0x401BA85")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_CheckIfToSyncCustomized;

			// Token: 0x0401BA86 RID: 113286
			[Token(Token = "0x401BA86")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnSyncStatusFinished;

			// Token: 0x0401BA87 RID: 113287
			[Token(Token = "0x401BA87")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200388D RID: 14477
		[Token(Token = "0x200388D")]
		private class MedalSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerSyncResult>
		{
			// Token: 0x170036C0 RID: 14016
			// (get) Token: 0x06016EC4 RID: 93892 RVA: 0x00093E40 File Offset: 0x00092040
			[Token(Token = "0x170036C0")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016EC4")]
				[Address(RVA = "0xF5AA70", Offset = "0xF59670", VA = "0x180F5AA70", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x170036C1 RID: 14017
			// (get) Token: 0x06016EC5 RID: 93893 RVA: 0x00093E58 File Offset: 0x00092058
			[Token(Token = "0x170036C1")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016EC5")]
				[Address(RVA = "0xF5AB20", Offset = "0xF59720", VA = "0x180F5AB20", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016EC6 RID: 93894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016EC6")]
			[Address(RVA = "0xF5A740", Offset = "0xF59340", VA = "0x180F5A740", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016EC7 RID: 93895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EC7")]
			[Address(RVA = "0xF5A860", Offset = "0xF59460", VA = "0x180F5A860", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerSyncResult result)
			{
			}

			// Token: 0x06016EC8 RID: 93896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016EC8")]
			[Address(RVA = "0xF5A8E0", Offset = "0xF594E0", VA = "0x180F5A8E0", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016EC9 RID: 93897 RVA: 0x00093E70 File Offset: 0x00092070
			[Token(Token = "0x6016EC9")]
			[Address(RVA = "0xF5A7A0", Offset = "0xF593A0", VA = "0x180F5A7A0", Slot = "6")]
			protected override bool CheckIfToSyncCustomized(DateTime curTime)
			{
				return default(bool);
			}

			// Token: 0x06016ECA RID: 93898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016ECA")]
			[Address(RVA = "0xF5A960", Offset = "0xF59560", VA = "0x180F5A960", Slot = "15")]
			public override void OnSyncStatusFinished(long moduleMask, long curTs)
			{
			}

			// Token: 0x06016ECB RID: 93899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016ECB")]
			[Address(RVA = "0xF5A9F0", Offset = "0xF595F0", VA = "0x180F5A9F0")]
			public MedalSyncItem()
			{
			}

			// Token: 0x06016ECC RID: 93900 RVA: 0x00093E88 File Offset: 0x00092088
			[Token(Token = "0x6016ECC")]
			[Address(RVA = "0xF52DA0", Offset = "0xF519A0", VA = "0x180F52DA0")]
			private bool <>xLuaBaseProxy_CheckIfToSyncCustomized(DateTime P0)
			{
				return default(bool);
			}

			// Token: 0x0401BA88 RID: 113288
			[Token(Token = "0x401BA88")]
			[FieldOffset(Offset = "0x20")]
			private long m_lastSyncTs;

			// Token: 0x0401BA89 RID: 113289
			[Token(Token = "0x401BA89")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA8A RID: 113290
			[Token(Token = "0x401BA8A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA8B RID: 113291
			[Token(Token = "0x401BA8B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA8C RID: 113292
			[Token(Token = "0x401BA8C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA8D RID: 113293
			[Token(Token = "0x401BA8D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA8E RID: 113294
			[Token(Token = "0x401BA8E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_CheckIfToSyncCustomized;

			// Token: 0x0401BA8F RID: 113295
			[Token(Token = "0x401BA8F")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnSyncStatusFinished;

			// Token: 0x0401BA90 RID: 113296
			[Token(Token = "0x401BA90")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200388E RID: 14478
		[Token(Token = "0x200388E")]
		private class CheckForbiddenSyncItem : UISyncDataUtil.CommonSyncServiceItem<PlayerSyncParam, PlayerCheckForbiddenResult>
		{
			// Token: 0x170036C2 RID: 14018
			// (get) Token: 0x06016ECD RID: 93901 RVA: 0x00093EA0 File Offset: 0x000920A0
			[Token(Token = "0x170036C2")]
			public override UISyncDataUtil.TrySyncFrequency frequency
			{
				[Token(Token = "0x6016ECD")]
				[Address(RVA = "0xF55840", Offset = "0xF54440", VA = "0x180F55840", Slot = "4")]
				get
				{
					return UISyncDataUtil.TrySyncFrequency.CUSTMIZED;
				}
			}

			// Token: 0x170036C3 RID: 14019
			// (get) Token: 0x06016ECE RID: 93902 RVA: 0x00093EB8 File Offset: 0x000920B8
			[Token(Token = "0x170036C3")]
			public override PlayerSyncModuleMask moduleMask
			{
				[Token(Token = "0x6016ECE")]
				[Address(RVA = "0xF558F0", Offset = "0xF544F0", VA = "0x180F558F0", Slot = "5")]
				get
				{
					return PlayerSyncModuleMask.NONE;
				}
			}

			// Token: 0x06016ECF RID: 93903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016ECF")]
			[Address(RVA = "0xF55680", Offset = "0xF54280", VA = "0x180F55680", Slot = "13")]
			protected override void FillResponseModel(PlayerSyncStatusViewModel viewModel, PlayerCheckForbiddenResult result)
			{
			}

			// Token: 0x06016ED0 RID: 93904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016ED0")]
			[Address(RVA = "0xF55720", Offset = "0xF54320", VA = "0x180F55720", Slot = "14")]
			protected override void HoldResponseModel(PlayerSyncStatusViewModel curModel, PlayerSyncStatusViewModel prevModel)
			{
			}

			// Token: 0x06016ED1 RID: 93905 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016ED1")]
			[Address(RVA = "0xF55620", Offset = "0xF54220", VA = "0x180F55620", Slot = "12")]
			protected override PlayerSyncParam BuildRequestParam()
			{
				return null;
			}

			// Token: 0x06016ED2 RID: 93906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016ED2")]
			[Address(RVA = "0xF557D0", Offset = "0xF543D0", VA = "0x180F557D0")]
			public CheckForbiddenSyncItem()
			{
			}

			// Token: 0x0401BA91 RID: 113297
			[Token(Token = "0x401BA91")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_frequency;

			// Token: 0x0401BA92 RID: 113298
			[Token(Token = "0x401BA92")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_moduleMask;

			// Token: 0x0401BA93 RID: 113299
			[Token(Token = "0x401BA93")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_FillResponseModel;

			// Token: 0x0401BA94 RID: 113300
			[Token(Token = "0x401BA94")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_HoldResponseModel;

			// Token: 0x0401BA95 RID: 113301
			[Token(Token = "0x401BA95")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BuildRequestParam;

			// Token: 0x0401BA96 RID: 113302
			[Token(Token = "0x401BA96")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
