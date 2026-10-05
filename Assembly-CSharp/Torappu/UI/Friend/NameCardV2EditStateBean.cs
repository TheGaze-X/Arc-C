using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D7D RID: 19837
	[Token(Token = "0x2004D7D")]
	public class NameCardV2EditStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601DB00 RID: 121600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB00")]
		[Address(RVA = "0x17474A0", Offset = "0x17460A0", VA = "0x1817474A0")]
		public NameCardV2EditStateBean()
		{
		}

		// Token: 0x04027395 RID: 160661
		[Token(Token = "0x4027395")]
		[FieldOffset(Offset = "0x10")]
		public NameCardV2Property property;

		// Token: 0x04027396 RID: 160662
		[Token(Token = "0x4027396")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
