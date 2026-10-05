using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200750D RID: 29965
	[Token(Token = "0x200750D")]
	public class Act25sideResearchUnlockStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602A3B2 RID: 172978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3B2")]
		[Address(RVA = "0x25E9510", Offset = "0x25E8110", VA = "0x1825E9510")]
		public Act25sideResearchUnlockStateBean()
		{
		}

		// Token: 0x0403CB00 RID: 248576
		[Token(Token = "0x403CB00")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x0403CB01 RID: 248577
		[Token(Token = "0x403CB01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
