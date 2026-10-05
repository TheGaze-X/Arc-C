using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A02 RID: 10754
	[Token(Token = "0x2002A02")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class LegionBattleUtil
	{
		// Token: 0x06011D70 RID: 73072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011D70")]
		[Address(RVA = "0x9AD200", Offset = "0x9ABE00", VA = "0x1809AD200")]
		public static GameObject LoadUIPlugin()
		{
			return null;
		}

		// Token: 0x06011D71 RID: 73073 RVA: 0x0006D350 File Offset: 0x0006B550
		[Token(Token = "0x6011D71")]
		[Address(RVA = "0x9AD180", Offset = "0x9ABD80", VA = "0x1809AD180")]
		public static bool IsProfessionReplaceable(ProfessionCategory profession)
		{
			return default(bool);
		}

		// Token: 0x06011D72 RID: 73074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011D72")]
		[Address(RVA = "0x9AD100", Offset = "0x9ABD00", VA = "0x1809AD100")]
		public static string GetLegionReplaceableTileColor()
		{
			return null;
		}

		// Token: 0x06011D73 RID: 73075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011D73")]
		[Address(RVA = "0x9ACFE0", Offset = "0x9ABBE0", VA = "0x1809ACFE0")]
		public static string GetLegionProfessionUIColor(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x040140B1 RID: 82097
		[Token(Token = "0x40140B1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<ProfessionCategory> PROFESSION_ORDER_LIST;

		// Token: 0x040140B2 RID: 82098
		[Token(Token = "0x40140B2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Dictionary<ProfessionCategory, string> ProfessionEnLogNameDic;

		// Token: 0x040140B3 RID: 82099
		[Token(Token = "0x40140B3")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Dictionary<ProfessionCategory, string> ProfessionNameKeyDic;

		// Token: 0x040140B4 RID: 82100
		[Token(Token = "0x40140B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadUIPlugin;

		// Token: 0x040140B5 RID: 82101
		[Token(Token = "0x40140B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsProfessionReplaceable;

		// Token: 0x040140B6 RID: 82102
		[Token(Token = "0x40140B6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetLegionReplaceableTileColor;

		// Token: 0x040140B7 RID: 82103
		[Token(Token = "0x40140B7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetLegionProfessionUIColor;
	}
}
