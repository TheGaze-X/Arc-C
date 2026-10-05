using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D7C RID: 19836
	[Token(Token = "0x2004D7C")]
	public class NameCardV2StateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601DAFF RID: 121599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAFF")]
		[Address(RVA = "0x174AF40", Offset = "0x1749B40", VA = "0x18174AF40")]
		public NameCardV2StateBean()
		{
		}

		// Token: 0x04027393 RID: 160659
		[Token(Token = "0x4027393")]
		[FieldOffset(Offset = "0x10")]
		public NameCardV2Property property;

		// Token: 0x04027394 RID: 160660
		[Token(Token = "0x4027394")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
