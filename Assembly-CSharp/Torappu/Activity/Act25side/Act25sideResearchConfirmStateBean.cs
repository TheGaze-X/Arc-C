using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007507 RID: 29959
	[Token(Token = "0x2007507")]
	public class Act25sideResearchConfirmStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602A3AD RID: 172973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3AD")]
		[Address(RVA = "0x25E3300", Offset = "0x25E1F00", VA = "0x1825E3300")]
		public Act25sideResearchConfirmStateBean()
		{
		}

		// Token: 0x0403CAEE RID: 248558
		[Token(Token = "0x403CAEE")]
		[FieldOffset(Offset = "0x10")]
		public string areaId;

		// Token: 0x0403CAEF RID: 248559
		[Token(Token = "0x403CAEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
