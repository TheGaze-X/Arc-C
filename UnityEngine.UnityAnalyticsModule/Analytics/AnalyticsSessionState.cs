using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[RequiredByNativeCode]
	public enum AnalyticsSessionState
	{
		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		kSessionStopped,
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		kSessionStarted,
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		kSessionPaused,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		kSessionResumed
	}
}
