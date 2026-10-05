using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200750B RID: 29963
	[Token(Token = "0x200750B")]
	public class Act25sideResearchRewardStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602A3B0 RID: 172976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3B0")]
		[Address(RVA = "0x25E4CD0", Offset = "0x25E38D0", VA = "0x1825E4CD0")]
		public Act25sideResearchRewardStateBean()
		{
		}

		// Token: 0x0403CAF9 RID: 248569
		[Token(Token = "0x403CAF9")]
		[FieldOffset(Offset = "0x10")]
		public string areaId;

		// Token: 0x0403CAFA RID: 248570
		[Token(Token = "0x403CAFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
