using System;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003B3 RID: 947
	[Token(Token = "0x20003B3")]
	public enum IOControlCode : long
	{
		// Token: 0x04000FE6 RID: 4070
		[Token(Token = "0x4000FE6")]
		AsyncIO = 2147772029L,
		// Token: 0x04000FE7 RID: 4071
		[Token(Token = "0x4000FE7")]
		NonBlockingIO,
		// Token: 0x04000FE8 RID: 4072
		[Token(Token = "0x4000FE8")]
		DataToRead = 1074030207L,
		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4000FE9")]
		OobDataRead = 1074033415L,
		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		AssociateHandle = 2281701377L,
		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		EnableCircularQueuing = 671088642L,
		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		Flush = 671088644L,
		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		GetBroadcastAddress = 1207959557L,
		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		GetExtensionFunctionPointer = 3355443206L,
		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		GetQos,
		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		GetGroupQos,
		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		MultipointLoopback = 2281701385L,
		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		MulticastScope,
		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		SetQos,
		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		SetGroupQos,
		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		TranslateHandle = 3355443213L,
		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		RoutingInterfaceQuery = 3355443220L,
		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		RoutingInterfaceChange = 2281701397L,
		// Token: 0x04000FF8 RID: 4088
		[Token(Token = "0x4000FF8")]
		AddressListQuery = 1207959574L,
		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		AddressListChange = 671088663L,
		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		QueryTargetPnpHandle = 1207959576L,
		// Token: 0x04000FFB RID: 4091
		[Token(Token = "0x4000FFB")]
		NamespaceChange = 2281701401L,
		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		AddressListSort = 3355443225L,
		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		ReceiveAll = 2550136833L,
		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		ReceiveAllMulticast,
		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		ReceiveAllIgmpMulticast,
		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		KeepAliveValues,
		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		AbsorbRouterAlert,
		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		UnicastInterface,
		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		LimitBroadcasts,
		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		BindToInterface,
		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		MulticastInterface,
		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		AddMulticastGroupOnInterface,
		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		DeleteMulticastGroupFromInterface
	}
}
