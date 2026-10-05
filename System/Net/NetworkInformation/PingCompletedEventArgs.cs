using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200037F RID: 895
	[Token(Token = "0x200037F")]
	public class PingCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001884 RID: 6276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001884")]
		[Address(RVA = "0x50A1D90", Offset = "0x50A0990", VA = "0x1850A1D90")]
		internal PingCompletedEventArgs(Exception ex, bool cancelled, object userState, PingReply reply)
		{
		}

		// Token: 0x04000EC2 RID: 3778
		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x28")]
		private PingReply reply;
	}
}
