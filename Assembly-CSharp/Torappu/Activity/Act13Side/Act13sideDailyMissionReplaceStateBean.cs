using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079EF RID: 31215
	[Token(Token = "0x20079EF")]
	public class Act13sideDailyMissionReplaceStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602BC1E RID: 179230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC1E")]
		[Address(RVA = "0x27B0EB0", Offset = "0x27AFAB0", VA = "0x1827B0EB0")]
		public Act13sideDailyMissionReplaceStateBean()
		{
		}

		// Token: 0x0403F4E8 RID: 259304
		[Token(Token = "0x403F4E8")]
		[FieldOffset(Offset = "0x10")]
		public Act13sideDailyReplaceProperty property;

		// Token: 0x0403F4E9 RID: 259305
		[Token(Token = "0x403F4E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
