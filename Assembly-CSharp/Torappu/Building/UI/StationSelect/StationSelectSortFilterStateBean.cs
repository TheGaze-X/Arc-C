using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C6B RID: 7275
	[Token(Token = "0x2001C6B")]
	public class StationSelectSortFilterStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B4B7 RID: 46263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4B7")]
		[Address(RVA = "0x32FF280", Offset = "0x32FDE80", VA = "0x1832FF280")]
		public StationSelectSortFilterStateBean()
		{
		}

		// Token: 0x0400B09D RID: 45213
		[Token(Token = "0x400B09D")]
		[FieldOffset(Offset = "0x10")]
		public StationOrderStruct orderStruct;

		// Token: 0x0400B09E RID: 45214
		[Token(Token = "0x400B09E")]
		[FieldOffset(Offset = "0x1C")]
		public bool isConfirmed;

		// Token: 0x0400B09F RID: 45215
		[Token(Token = "0x400B09F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
