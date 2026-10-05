using System;
using Il2CppDummyDll;

namespace ACE
{
	// Token: 0x0200059B RID: 1435
	[Token(Token = "0x200059B")]
	public interface TssInfoReceiver
	{
		// Token: 0x0600311F RID: 12575
		[Token(Token = "0x600311F")]
		void onReceive(int tssInfoType, string info);
	}
}
