using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002822 RID: 10274
	[Token(Token = "0x2002822")]
	internal class BattleDialogVariableGetter : Singleton<BattleDialogVariableGetter>, IHotfixable
	{
		// Token: 0x06011194 RID: 70036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011194")]
		[Address(RVA = "0x907600", Offset = "0x906200", VA = "0x180907600")]
		private BattleDialogVariableGetter()
		{
		}

		// Token: 0x06011195 RID: 70037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011195")]
		[Address(RVA = "0x907430", Offset = "0x906030", VA = "0x180907430")]
		public static string GetVariableValue(string varName)
		{
			return null;
		}

		// Token: 0x06011196 RID: 70038 RVA: 0x000694C8 File Offset: 0x000676C8
		[Token(Token = "0x6011196")]
		[Address(RVA = "0x907580", Offset = "0x906180", VA = "0x180907580")]
		private static bool _Equals(string l, string r)
		{
			return default(bool);
		}

		// Token: 0x040132A2 RID: 78498
		[Token(Token = "0x40132A2")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, VariableTranslater.VariableGetterDelegate> m_delegateDic;

		// Token: 0x040132A3 RID: 78499
		[Token(Token = "0x40132A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040132A4 RID: 78500
		[Token(Token = "0x40132A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetVariableValue;

		// Token: 0x040132A5 RID: 78501
		[Token(Token = "0x40132A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Equals;
	}
}
