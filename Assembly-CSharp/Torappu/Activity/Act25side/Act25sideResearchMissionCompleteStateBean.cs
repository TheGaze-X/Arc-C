using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200750A RID: 29962
	[Token(Token = "0x200750A")]
	public class Act25sideResearchMissionCompleteStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602A3AF RID: 172975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3AF")]
		[Address(RVA = "0x25E3A10", Offset = "0x25E2610", VA = "0x1825E3A10")]
		public Act25sideResearchMissionCompleteStateBean()
		{
		}

		// Token: 0x0403CAF7 RID: 248567
		[Token(Token = "0x403CAF7")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x0403CAF8 RID: 248568
		[Token(Token = "0x403CAF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
