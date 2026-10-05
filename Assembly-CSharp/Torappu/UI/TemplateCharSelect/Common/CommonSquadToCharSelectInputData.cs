using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C02 RID: 23554
	[Token(Token = "0x2005C02")]
	public class CommonSquadToCharSelectInputData : TemplateCharSelectCharInputData
	{
		// Token: 0x06022245 RID: 139845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022245")]
		[Address(RVA = "0x1C964D0", Offset = "0x1C950D0", VA = "0x181C964D0")]
		public CommonSquadToCharSelectInputData()
		{
		}

		// Token: 0x0402ECF7 RID: 191735
		[Token(Token = "0x402ECF7")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		// Token: 0x0402ECF8 RID: 191736
		[Token(Token = "0x402ECF8")]
		[FieldOffset(Offset = "0x20")]
		public string skillId;

		// Token: 0x0402ECF9 RID: 191737
		[Token(Token = "0x402ECF9")]
		[FieldOffset(Offset = "0x28")]
		public string equipId;

		// Token: 0x0402ECFA RID: 191738
		[Token(Token = "0x402ECFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
