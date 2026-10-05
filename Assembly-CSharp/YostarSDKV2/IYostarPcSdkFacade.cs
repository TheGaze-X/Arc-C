using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YostarSDKV2
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public interface IYostarPcSdkFacade
	{
		// Token: 0x060001FD RID: 509
		[Token(Token = "0x60001FD")]
		void PrepareInitData();

		// Token: 0x060001FE RID: 510
		[Token(Token = "0x60001FE")]
		void Init(YostarPcSdkInitRequest request);

		// Token: 0x060001FF RID: 511
		[Token(Token = "0x60001FF")]
		void Login();

		// Token: 0x06000200 RID: 512
		[Token(Token = "0x6000200")]
		void Pay(YostarPcSdkPayRequest request);

		// Token: 0x06000201 RID: 513
		[Token(Token = "0x6000201")]
		void ShowAgreement();

		// Token: 0x06000202 RID: 514
		[Token(Token = "0x6000202")]
		bool CheckUserCacheExist();

		// Token: 0x06000203 RID: 515
		[Token(Token = "0x6000203")]
		void ShowUserCenter();

		// Token: 0x06000204 RID: 516
		[Token(Token = "0x6000204")]
		void ShowSwitchAccount();

		// Token: 0x06000205 RID: 517
		[Token(Token = "0x6000205")]
		void ShowAihelp();

		// Token: 0x06000206 RID: 518
		[Token(Token = "0x6000206")]
		void OnPause();

		// Token: 0x06000207 RID: 519
		[Token(Token = "0x6000207")]
		void OnResume();

		// Token: 0x06000208 RID: 520
		[Token(Token = "0x6000208")]
		void UserEventUpload(string eventName, Dictionary<string, string> parameters);

		// Token: 0x06000209 RID: 521
		[Token(Token = "0x6000209")]
		void RoleInfoUpload(YostarPcSdkRoleInfoRequest request);

		// Token: 0x0600020A RID: 522
		[Token(Token = "0x600020A")]
		void SetDefaultCursor();

		// Token: 0x0600020B RID: 523
		[Token(Token = "0x600020B")]
		string GetSdkVersion();
	}
}
