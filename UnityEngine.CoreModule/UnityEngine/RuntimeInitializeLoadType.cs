using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	public enum RuntimeInitializeLoadType
	{
		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		AfterSceneLoad,
		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		BeforeSceneLoad,
		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		AfterAssembliesLoaded,
		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		BeforeSplashScreen,
		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		SubsystemRegistration
	}
}
