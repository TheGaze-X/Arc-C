using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005E4 RID: 1508
	[Token(Token = "0x20005E4")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/ZoneDB")]
	[Serializable]
	public class ZoneDB : ConstTable<ZoneTable, ZoneDB>
	{
		// Token: 0x060061D4 RID: 25044 RVA: 0x0002FE80 File Offset: 0x0002E080
		[Token(Token = "0x60061D4")]
		[Address(RVA = "0x1DFD000", Offset = "0x1DFBC00", VA = "0x181DFD000")]
		public bool TryGetChapterId(string zoneId, out string chapterId)
		{
			return default(bool);
		}

		// Token: 0x060061D5 RID: 25045 RVA: 0x0002FE98 File Offset: 0x0002E098
		[Token(Token = "0x60061D5")]
		[Address(RVA = "0x1DFD130", Offset = "0x1DFBD30", VA = "0x181DFD130")]
		public bool TryGetDiffGroup(string zoneId, out List<StageDiffGroup> diffGroup)
		{
			return default(bool);
		}

		// Token: 0x060061D6 RID: 25046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D6")]
		[Address(RVA = "0x1DFD260", Offset = "0x1DFBE60", VA = "0x181DFD260")]
		public ZoneDB()
		{
		}

		// Token: 0x04002B90 RID: 11152
		[Token(Token = "0x4002B90")]
		public const string MAINLINE_EMPTY_BG = "mainline_empty_bg";

		// Token: 0x04002B91 RID: 11153
		[Token(Token = "0x4002B91")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetChapterId;

		// Token: 0x04002B92 RID: 11154
		[Token(Token = "0x4002B92")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGetDiffGroup;

		// Token: 0x04002B93 RID: 11155
		[Token(Token = "0x4002B93")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
