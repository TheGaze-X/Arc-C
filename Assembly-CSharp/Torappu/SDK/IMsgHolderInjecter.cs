using System;
using Il2CppDummyDll;

namespace Torappu.SDK
{
	// Token: 0x020014F6 RID: 5366
	[Token(Token = "0x20014F6")]
	public interface IMsgHolderInjecter
	{
		// Token: 0x06007B89 RID: 31625
		[Token(Token = "0x6007B89")]
		bool isPopupAgreement();

		// Token: 0x06007B8A RID: 31626
		[Token(Token = "0x6007B8A")]
		void TryInjectCashShop(InjectShopOptions options);

		// Token: 0x06007B8B RID: 31627
		[Token(Token = "0x6007B8B")]
		void TryInjectSettings(InjectSettingOptions options);

		// Token: 0x06007B8C RID: 31628
		[Token(Token = "0x6007B8C")]
		void TryShowGlobalAgreement(Action onAgree, Action backLogin);
	}
}
