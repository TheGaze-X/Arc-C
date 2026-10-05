using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D5C RID: 19804
	[Token(Token = "0x2004D5C")]
	public class FriendNameCardMedalStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601DA1B RID: 121371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA1B")]
		[Address(RVA = "0x17292C0", Offset = "0x1727EC0", VA = "0x1817292C0")]
		public void Init()
		{
		}

		// Token: 0x0601DA1C RID: 121372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA1C")]
		[Address(RVA = "0x17297A0", Offset = "0x17283A0", VA = "0x1817297A0")]
		public FriendNameCardMedalStateBean()
		{
		}

		// Token: 0x04027232 RID: 160306
		[Token(Token = "0x4027232")]
		[FieldOffset(Offset = "0x10")]
		public NameCardMedalSelectProperty nameCardSelectProperty;

		// Token: 0x04027233 RID: 160307
		[Token(Token = "0x4027233")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04027234 RID: 160308
		[Token(Token = "0x4027234")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
