using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A02 RID: 18946
	[Token(Token = "0x2004A02")]
	public class InformantHomeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601C84F RID: 116815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C84F")]
		[Address(RVA = "0x15F7280", Offset = "0x15F5E80", VA = "0x1815F7280")]
		public InformantHomeStateBean()
		{
		}

		// Token: 0x04025614 RID: 153108
		[Token(Token = "0x4025614")]
		[FieldOffset(Offset = "0x10")]
		public InformantHomeProperty property;

		// Token: 0x04025615 RID: 153109
		[Token(Token = "0x4025615")]
		[FieldOffset(Offset = "0x18")]
		public bool isEntry;

		// Token: 0x04025616 RID: 153110
		[Token(Token = "0x4025616")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
