using System;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	public enum ProtocolType
	{
		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		IP,
		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		IPv6HopByHopOptions = 0,
		// Token: 0x04001014 RID: 4116
		[Token(Token = "0x4001014")]
		Icmp,
		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		Igmp,
		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		Ggp,
		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		IPv4,
		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		Tcp = 6,
		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		Pup = 12,
		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		Udp = 17,
		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		Idp = 22,
		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		IPv6 = 41,
		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		IPv6RoutingHeader = 43,
		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		IPv6FragmentHeader,
		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		IPSecEncapsulatingSecurityPayload = 50,
		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		IPSecAuthenticationHeader,
		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		IcmpV6 = 58,
		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		IPv6NoNextHeader,
		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		IPv6DestinationOptions,
		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		ND = 77,
		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		Raw = 255,
		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		Unspecified = 0,
		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		Ipx = 1000,
		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		Spx = 1256,
		// Token: 0x04001029 RID: 4137
		[Token(Token = "0x4001029")]
		SpxII,
		// Token: 0x0400102A RID: 4138
		[Token(Token = "0x400102A")]
		Unknown = -1
	}
}
