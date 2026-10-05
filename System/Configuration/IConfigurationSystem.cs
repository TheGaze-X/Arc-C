using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000426 RID: 1062
	[Token(Token = "0x2000426")]
	[ComVisible(false)]
	public interface IConfigurationSystem
	{
		// Token: 0x06001C5D RID: 7261
		[Token(Token = "0x6001C5D")]
		object GetConfig(string configKey);

		// Token: 0x06001C5E RID: 7262
		[Token(Token = "0x6001C5E")]
		void Init();
	}
}
