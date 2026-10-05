using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UDatasdk
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public interface IUDataSDK
	{
		// Token: 0x06000001 RID: 1
		[Token(Token = "0x6000001")]
		void InitUData(string channel, string pid, string evn, bool logEnable, [Optional] Action<InitRet> callBack);

		// Token: 0x06000002 RID: 2
		[Token(Token = "0x6000002")]
		void TrackEvent(string eventType, string eventProperty);

		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		void DeleteAllCache();

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		void OnResume();

		// Token: 0x06000005 RID: 5
		[Token(Token = "0x6000005")]
		void OnPause();

		// Token: 0x06000006 RID: 6
		[Token(Token = "0x6000006")]
		void OnApplicationQuit();
	}
}
