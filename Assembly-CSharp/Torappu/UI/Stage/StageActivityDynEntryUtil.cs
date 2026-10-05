using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068E1 RID: 26849
	[Token(Token = "0x20068E1")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class StageActivityDynEntryUtil
	{
		// Token: 0x0602676E RID: 157550 RVA: 0x000CB3A0 File Offset: 0x000C95A0
		[Token(Token = "0x602676E")]
		[Address(RVA = "0x217F930", Offset = "0x217E530", VA = "0x18217F930")]
		private static bool _CheckDynEntryValid(string actId, DynEntrySwitchInfo dynEntryInfo)
		{
			return default(bool);
		}

		// Token: 0x0602676F RID: 157551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602676F")]
		[Address(RVA = "0x21802A0", Offset = "0x217EEA0", VA = "0x1821802A0")]
		private static string _GetLocalDynEntrySetting(string actId)
		{
			return null;
		}

		// Token: 0x06026770 RID: 157552 RVA: 0x000CB3B8 File Offset: 0x000C95B8
		[Token(Token = "0x6026770")]
		[Address(RVA = "0x217F460", Offset = "0x217E060", VA = "0x18217F460")]
		public static bool SetActivityDynEntry(string actId, string dynEntryId)
		{
			return default(bool);
		}

		// Token: 0x06026771 RID: 157553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026771")]
		[Address(RVA = "0x217F340", Offset = "0x217DF40", VA = "0x18217F340")]
		public static string GetActivityDynEntry(string actId, string currEntryId)
		{
			return null;
		}

		// Token: 0x06026772 RID: 157554 RVA: 0x000CB3D0 File Offset: 0x000C95D0
		[Token(Token = "0x6026772")]
		[Address(RVA = "0x217F6A0", Offset = "0x217E2A0", VA = "0x18217F6A0")]
		public static bool TryGetActDynEntryBgmSignal(string actId, string entryId, out string signal)
		{
			return default(bool);
		}

		// Token: 0x06026773 RID: 157555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026773")]
		[Address(RVA = "0x2180970", Offset = "0x217F570", VA = "0x182180970")]
		private static string _GetTypeAct27sideDynEntry(string actId)
		{
			return null;
		}

		// Token: 0x06026774 RID: 157556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026774")]
		[Address(RVA = "0x217F9E0", Offset = "0x217E5E0", VA = "0x18217F9E0")]
		private static string _GetCommonActDynEntry(string actId, string currEntryId)
		{
			return null;
		}

		// Token: 0x06026775 RID: 157557 RVA: 0x000CB3E8 File Offset: 0x000C95E8
		[Token(Token = "0x6026775")]
		[Address(RVA = "0x217FF40", Offset = "0x217EB40", VA = "0x18217FF40")]
		private static bool _GetCommonDynEntryId(string actId, ActivityDynEntrySwitchData dynEntrySwitchData, out string entryId)
		{
			return default(bool);
		}

		// Token: 0x06026776 RID: 157558 RVA: 0x000CB400 File Offset: 0x000C9600
		[Token(Token = "0x6026776")]
		[Address(RVA = "0x2180340", Offset = "0x217EF40", VA = "0x182180340")]
		private static bool _GetRandomDynEntryId(string actId, string currEntryId, ActivityDynEntrySwitchData dynEntrySwitchData, out string entryId)
		{
			return default(bool);
		}

		// Token: 0x06026777 RID: 157559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026777")]
		[Address(RVA = "0x21800E0", Offset = "0x217ECE0", VA = "0x1821800E0")]
		private static string _GetDynEntryStageTrack(string actId, ListDict<string, DynEntrySwitchInfo> validDynEntries)
		{
			return null;
		}

		// Token: 0x06026778 RID: 157560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026778")]
		[Address(RVA = "0x21806A0", Offset = "0x217F2A0", VA = "0x1821806A0")]
		private static ListDict<string, DynEntrySwitchInfo> _GetStageValidDynEntry(string actId, ListDict<string, DynEntrySwitchInfo> dynEntries)
		{
			return null;
		}

		// Token: 0x04036313 RID: 221971
		[Token(Token = "0x4036313")]
		private const string ACT_LOCAL_CACHE_DYN_ENTRY_SETTING = "{0}_dyn_entry_setting";

		// Token: 0x04036314 RID: 221972
		[Token(Token = "0x4036314")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckDynEntryValid;

		// Token: 0x04036315 RID: 221973
		[Token(Token = "0x4036315")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetLocalDynEntrySetting;

		// Token: 0x04036316 RID: 221974
		[Token(Token = "0x4036316")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetActivityDynEntry;

		// Token: 0x04036317 RID: 221975
		[Token(Token = "0x4036317")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetActivityDynEntry;

		// Token: 0x04036318 RID: 221976
		[Token(Token = "0x4036318")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetActDynEntryBgmSignal;

		// Token: 0x04036319 RID: 221977
		[Token(Token = "0x4036319")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTypeAct27sideDynEntry;

		// Token: 0x0403631A RID: 221978
		[Token(Token = "0x403631A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetCommonActDynEntry;

		// Token: 0x0403631B RID: 221979
		[Token(Token = "0x403631B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetCommonDynEntryId;

		// Token: 0x0403631C RID: 221980
		[Token(Token = "0x403631C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetRandomDynEntryId;

		// Token: 0x0403631D RID: 221981
		[Token(Token = "0x403631D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetDynEntryStageTrack;

		// Token: 0x0403631E RID: 221982
		[Token(Token = "0x403631E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetStageValidDynEntry;
	}
}
