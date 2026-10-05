using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200750E RID: 29966
	[Token(Token = "0x200750E")]
	public class RhineBattlePerformanceStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602A3B3 RID: 172979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3B3")]
		[Address(RVA = "0x25EE980", Offset = "0x25ED580", VA = "0x1825EE980")]
		public void LoadData(bool isRetro, string groupId)
		{
		}

		// Token: 0x0602A3B4 RID: 172980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3B4")]
		[Address(RVA = "0x25EEB90", Offset = "0x25ED790", VA = "0x1825EEB90")]
		public RhineBattlePerformanceStateBean()
		{
		}

		// Token: 0x0403CB02 RID: 248578
		[Token(Token = "0x403CB02")]
		[FieldOffset(Offset = "0x10")]
		public RhineBattlePerformanceProperty property;

		// Token: 0x0403CB03 RID: 248579
		[Token(Token = "0x403CB03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CB04 RID: 248580
		[Token(Token = "0x403CB04")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
