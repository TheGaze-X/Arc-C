using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D84 RID: 7556
	[Token(Token = "0x2001D84")]
	public class MFormulaSortFilterStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600BA82 RID: 47746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA82")]
		[Address(RVA = "0x33733B0", Offset = "0x3371FB0", VA = "0x1833733B0")]
		public MFormulaSortFilterStateBean()
		{
		}

		// Token: 0x0400B9B0 RID: 47536
		[Token(Token = "0x400B9B0")]
		[FieldOffset(Offset = "0x10")]
		public FormulaOrderStruct orderStruct;

		// Token: 0x0400B9B1 RID: 47537
		[Token(Token = "0x400B9B1")]
		[FieldOffset(Offset = "0x20")]
		public bool isConfirmed;

		// Token: 0x0400B9B2 RID: 47538
		[Token(Token = "0x400B9B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
