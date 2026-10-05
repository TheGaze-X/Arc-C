using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000366 RID: 870
	[Token(Token = "0x2000366")]
	public enum IPStatus
	{
		// Token: 0x04000E4D RID: 3661
		[Token(Token = "0x4000E4D")]
		Success,
		// Token: 0x04000E4E RID: 3662
		[Token(Token = "0x4000E4E")]
		DestinationNetworkUnreachable = 11002,
		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		DestinationHostUnreachable,
		// Token: 0x04000E50 RID: 3664
		[Token(Token = "0x4000E50")]
		DestinationProtocolUnreachable,
		// Token: 0x04000E51 RID: 3665
		[Token(Token = "0x4000E51")]
		DestinationPortUnreachable,
		// Token: 0x04000E52 RID: 3666
		[Token(Token = "0x4000E52")]
		DestinationProhibited = 11004,
		// Token: 0x04000E53 RID: 3667
		[Token(Token = "0x4000E53")]
		NoResources = 11006,
		// Token: 0x04000E54 RID: 3668
		[Token(Token = "0x4000E54")]
		BadOption,
		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000E55")]
		HardwareError,
		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000E56")]
		PacketTooBig,
		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		TimedOut,
		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		BadRoute = 11012,
		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		TtlExpired,
		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000E5A")]
		TtlReassemblyTimeExceeded,
		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000E5B")]
		ParameterProblem,
		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		SourceQuench,
		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000E5D")]
		BadDestination = 11018,
		// Token: 0x04000E5E RID: 3678
		[Token(Token = "0x4000E5E")]
		DestinationUnreachable = 11040,
		// Token: 0x04000E5F RID: 3679
		[Token(Token = "0x4000E5F")]
		TimeExceeded,
		// Token: 0x04000E60 RID: 3680
		[Token(Token = "0x4000E60")]
		BadHeader,
		// Token: 0x04000E61 RID: 3681
		[Token(Token = "0x4000E61")]
		UnrecognizedNextHeader,
		// Token: 0x04000E62 RID: 3682
		[Token(Token = "0x4000E62")]
		IcmpError,
		// Token: 0x04000E63 RID: 3683
		[Token(Token = "0x4000E63")]
		DestinationScopeMismatch,
		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		Unknown = -1
	}
}
