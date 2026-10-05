using System;
using Il2CppDummyDll;

namespace Torappu.CETest
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public interface ICETestBridge
	{
		// Token: 0x06000028 RID: 40
		[Token(Token = "0x6000028")]
		object LoadData();

		// Token: 0x06000029 RID: 41
		[Token(Token = "0x6000029")]
		void LoadLevel(string levelId, string squadId);

		// Token: 0x0600002A RID: 42
		[Token(Token = "0x600002A")]
		void BackToLogin();
	}
}
