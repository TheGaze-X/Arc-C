using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AEE RID: 27374
	[Token(Token = "0x2006AEE")]
	public class AchievementCompInfo : ActArchiveCompInfo
	{
		// Token: 0x06027245 RID: 160325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027245")]
		[Address(RVA = "0x2249F70", Offset = "0x2248B70", VA = "0x182249F70")]
		public AchievementCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027246 RID: 160326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027246")]
		[Address(RVA = "0x2249CB0", Offset = "0x22488B0", VA = "0x182249CB0", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x06027247 RID: 160327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027247")]
		[Address(RVA = "0x2249980", Offset = "0x2248580", VA = "0x182249980", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027248 RID: 160328 RVA: 0x000CD800 File Offset: 0x000CBA00
		[Token(Token = "0x6027248")]
		[Address(RVA = "0x2249C30", Offset = "0x2248830", VA = "0x182249C30", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027249 RID: 160329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027249")]
		[Address(RVA = "0x2249EC0", Offset = "0x2248AC0", VA = "0x182249EC0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x0602724A RID: 160330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602724A")]
		[Address(RVA = "0x22499E0", Offset = "0x22485E0", VA = "0x1822499E0")]
		public Dictionary<int, int> GetRarityCountDict()
		{
			return null;
		}

		// Token: 0x040375F5 RID: 226805
		[Token(Token = "0x40375F5")]
		[FieldOffset(Offset = "0x18")]
		public ArchiveAchievementProperty achievement;

		// Token: 0x040375F6 RID: 226806
		[Token(Token = "0x40375F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040375F7 RID: 226807
		[Token(Token = "0x40375F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040375F8 RID: 226808
		[Token(Token = "0x40375F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x040375F9 RID: 226809
		[Token(Token = "0x40375F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x040375FA RID: 226810
		[Token(Token = "0x40375FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x040375FB RID: 226811
		[Token(Token = "0x40375FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRarityCountDict;
	}
}
