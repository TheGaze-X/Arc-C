using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079F6 RID: 31222
	[Token(Token = "0x20079F6")]
	public class Act13sideMissionListStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602BC48 RID: 179272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC48")]
		[Address(RVA = "0x27B7580", Offset = "0x27B6180", VA = "0x1827B7580")]
		public Act13sideMissionListStateBean()
		{
		}

		// Token: 0x0403F522 RID: 259362
		[Token(Token = "0x403F522")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0403F523 RID: 259363
		[Token(Token = "0x403F523")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
