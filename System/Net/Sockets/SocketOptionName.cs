using System;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003C0 RID: 960
	[Token(Token = "0x20003C0")]
	public enum SocketOptionName
	{
		// Token: 0x04001081 RID: 4225
		[Token(Token = "0x4001081")]
		Debug = 1,
		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4001082")]
		AcceptConnection,
		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4001083")]
		ReuseAddress = 4,
		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4001084")]
		KeepAlive = 8,
		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4001085")]
		DontRoute = 16,
		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		Broadcast = 32,
		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		UseLoopback = 64,
		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		Linger = 128,
		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		OutOfBandInline = 256,
		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		DontLinger = -129,
		// Token: 0x0400108B RID: 4235
		[Token(Token = "0x400108B")]
		ExclusiveAddressUse = -5,
		// Token: 0x0400108C RID: 4236
		[Token(Token = "0x400108C")]
		SendBuffer = 4097,
		// Token: 0x0400108D RID: 4237
		[Token(Token = "0x400108D")]
		ReceiveBuffer,
		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		SendLowWater,
		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		ReceiveLowWater,
		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		SendTimeout,
		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		ReceiveTimeout,
		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		Error,
		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		Type,
		// Token: 0x04001094 RID: 4244
		[Token(Token = "0x4001094")]
		ReuseUnicastPort = 12295,
		// Token: 0x04001095 RID: 4245
		[Token(Token = "0x4001095")]
		MaxConnections = 2147483647,
		// Token: 0x04001096 RID: 4246
		[Token(Token = "0x4001096")]
		IPOptions = 1,
		// Token: 0x04001097 RID: 4247
		[Token(Token = "0x4001097")]
		HeaderIncluded,
		// Token: 0x04001098 RID: 4248
		[Token(Token = "0x4001098")]
		TypeOfService,
		// Token: 0x04001099 RID: 4249
		[Token(Token = "0x4001099")]
		IpTimeToLive,
		// Token: 0x0400109A RID: 4250
		[Token(Token = "0x400109A")]
		MulticastInterface = 9,
		// Token: 0x0400109B RID: 4251
		[Token(Token = "0x400109B")]
		MulticastTimeToLive,
		// Token: 0x0400109C RID: 4252
		[Token(Token = "0x400109C")]
		MulticastLoopback,
		// Token: 0x0400109D RID: 4253
		[Token(Token = "0x400109D")]
		AddMembership,
		// Token: 0x0400109E RID: 4254
		[Token(Token = "0x400109E")]
		DropMembership,
		// Token: 0x0400109F RID: 4255
		[Token(Token = "0x400109F")]
		DontFragment,
		// Token: 0x040010A0 RID: 4256
		[Token(Token = "0x40010A0")]
		AddSourceMembership,
		// Token: 0x040010A1 RID: 4257
		[Token(Token = "0x40010A1")]
		DropSourceMembership,
		// Token: 0x040010A2 RID: 4258
		[Token(Token = "0x40010A2")]
		BlockSource,
		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		UnblockSource,
		// Token: 0x040010A4 RID: 4260
		[Token(Token = "0x40010A4")]
		PacketInformation,
		// Token: 0x040010A5 RID: 4261
		[Token(Token = "0x40010A5")]
		HopLimit = 21,
		// Token: 0x040010A6 RID: 4262
		[Token(Token = "0x40010A6")]
		IPProtectionLevel = 23,
		// Token: 0x040010A7 RID: 4263
		[Token(Token = "0x40010A7")]
		IPv6Only = 27,
		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		NoDelay = 1,
		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		BsdUrgent,
		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		Expedited = 2,
		// Token: 0x040010AB RID: 4267
		[Token(Token = "0x40010AB")]
		NoChecksum = 1,
		// Token: 0x040010AC RID: 4268
		[Token(Token = "0x40010AC")]
		ChecksumCoverage = 20,
		// Token: 0x040010AD RID: 4269
		[Token(Token = "0x40010AD")]
		UpdateAcceptContext = 28683,
		// Token: 0x040010AE RID: 4270
		[Token(Token = "0x40010AE")]
		UpdateConnectContext = 28688
	}
}
