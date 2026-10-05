using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067D9 RID: 26585
	[Token(Token = "0x20067D9")]
	public class ZoneHomeRecentViewModel : IHotfixable
	{
		// Token: 0x060261DB RID: 156123 RVA: 0x000CA1D0 File Offset: 0x000C83D0
		[Token(Token = "0x60261DB")]
		[Address(RVA = "0x2144B60", Offset = "0x2143760", VA = "0x182144B60")]
		public bool IsStageEmpty()
		{
			return default(bool);
		}

		// Token: 0x060261DC RID: 156124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261DC")]
		[Address(RVA = "0x2144BC0", Offset = "0x21437C0", VA = "0x182144BC0")]
		public void LoadData()
		{
		}

		// Token: 0x060261DD RID: 156125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261DD")]
		[Address(RVA = "0x2145410", Offset = "0x2144010", VA = "0x182145410")]
		private void _LoadLastRecentBattleStage(out string stageId, out StageType type)
		{
		}

		// Token: 0x060261DE RID: 156126 RVA: 0x000CA1E8 File Offset: 0x000C83E8
		[Token(Token = "0x60261DE")]
		[Address(RVA = "0x21450F0", Offset = "0x2143CF0", VA = "0x1821450F0")]
		private LocalBattleCache.RecentBattleRecord _FindLastRecentBattleRecord()
		{
			return default(LocalBattleCache.RecentBattleRecord);
		}

		// Token: 0x060261DF RID: 156127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261DF")]
		[Address(RVA = "0x2145520", Offset = "0x2144120", VA = "0x182145520")]
		private void _LoadStageInfo()
		{
		}

		// Token: 0x060261E0 RID: 156128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60261E0")]
		[Address(RVA = "0x2145320", Offset = "0x2143F20", VA = "0x182145320")]
		private static string _GetTypeDesc(HomeRecentStageType type)
		{
			return null;
		}

		// Token: 0x060261E1 RID: 156129 RVA: 0x000CA200 File Offset: 0x000C8400
		[Token(Token = "0x60261E1")]
		[Address(RVA = "0x2145070", Offset = "0x2143C70", VA = "0x182145070")]
		private static HomeRecentStageType _ConvertStageType(StageType stageType)
		{
			return HomeRecentStageType.NONE;
		}

		// Token: 0x060261E2 RID: 156130 RVA: 0x000CA218 File Offset: 0x000C8418
		[Token(Token = "0x60261E2")]
		[Address(RVA = "0x2144FA0", Offset = "0x2143BA0", VA = "0x182144FA0")]
		private static bool _CheckIfRecordAvailable(LocalBattleCache.RecentBattleRecord record)
		{
			return default(bool);
		}

		// Token: 0x060261E3 RID: 156131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261E3")]
		[Address(RVA = "0x2145660", Offset = "0x2144260", VA = "0x182145660")]
		public ZoneHomeRecentViewModel()
		{
		}

		// Token: 0x04035AB1 RID: 219825
		[Token(Token = "0x4035AB1")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04035AB2 RID: 219826
		[Token(Token = "0x4035AB2")]
		[FieldOffset(Offset = "0x18")]
		public string code;

		// Token: 0x04035AB3 RID: 219827
		[Token(Token = "0x4035AB3")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04035AB4 RID: 219828
		[Token(Token = "0x4035AB4")]
		[FieldOffset(Offset = "0x28")]
		public HomeRecentStageType type;

		// Token: 0x04035AB5 RID: 219829
		[Token(Token = "0x4035AB5")]
		[FieldOffset(Offset = "0x30")]
		public string typeDesc;

		// Token: 0x04035AB6 RID: 219830
		[Token(Token = "0x4035AB6")]
		[FieldOffset(Offset = "0x38")]
		public string zoneId;

		// Token: 0x04035AB7 RID: 219831
		[Token(Token = "0x4035AB7")]
		[FieldOffset(Offset = "0x40")]
		public bool isRetro;

		// Token: 0x04035AB8 RID: 219832
		[Token(Token = "0x4035AB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsStageEmpty;

		// Token: 0x04035AB9 RID: 219833
		[Token(Token = "0x4035AB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035ABA RID: 219834
		[Token(Token = "0x4035ABA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadLastRecentBattleStage;

		// Token: 0x04035ABB RID: 219835
		[Token(Token = "0x4035ABB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FindLastRecentBattleRecord;

		// Token: 0x04035ABC RID: 219836
		[Token(Token = "0x4035ABC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadStageInfo;

		// Token: 0x04035ABD RID: 219837
		[Token(Token = "0x4035ABD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTypeDesc;

		// Token: 0x04035ABE RID: 219838
		[Token(Token = "0x4035ABE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConvertStageType;

		// Token: 0x04035ABF RID: 219839
		[Token(Token = "0x4035ABF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckIfRecordAvailable;

		// Token: 0x04035AC0 RID: 219840
		[Token(Token = "0x4035AC0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
