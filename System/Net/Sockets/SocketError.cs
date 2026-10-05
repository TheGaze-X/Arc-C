using System;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003BD RID: 957
	[Token(Token = "0x20003BD")]
	public enum SocketError
	{
		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		Success,
		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		SocketError = -1,
		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		Interrupted = 10004,
		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		AccessDenied = 10013,
		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		Fault,
		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		InvalidArgument = 10022,
		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		TooManyOpenSockets = 10024,
		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		WouldBlock = 10035,
		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		InProgress,
		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		AlreadyInProgress,
		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		NotSocket,
		// Token: 0x0400104B RID: 4171
		[Token(Token = "0x400104B")]
		DestinationAddressRequired,
		// Token: 0x0400104C RID: 4172
		[Token(Token = "0x400104C")]
		MessageSize,
		// Token: 0x0400104D RID: 4173
		[Token(Token = "0x400104D")]
		ProtocolType,
		// Token: 0x0400104E RID: 4174
		[Token(Token = "0x400104E")]
		ProtocolOption,
		// Token: 0x0400104F RID: 4175
		[Token(Token = "0x400104F")]
		ProtocolNotSupported,
		// Token: 0x04001050 RID: 4176
		[Token(Token = "0x4001050")]
		SocketNotSupported,
		// Token: 0x04001051 RID: 4177
		[Token(Token = "0x4001051")]
		OperationNotSupported,
		// Token: 0x04001052 RID: 4178
		[Token(Token = "0x4001052")]
		ProtocolFamilyNotSupported,
		// Token: 0x04001053 RID: 4179
		[Token(Token = "0x4001053")]
		AddressFamilyNotSupported,
		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		AddressAlreadyInUse,
		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		AddressNotAvailable,
		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		NetworkDown,
		// Token: 0x04001057 RID: 4183
		[Token(Token = "0x4001057")]
		NetworkUnreachable,
		// Token: 0x04001058 RID: 4184
		[Token(Token = "0x4001058")]
		NetworkReset,
		// Token: 0x04001059 RID: 4185
		[Token(Token = "0x4001059")]
		ConnectionAborted,
		// Token: 0x0400105A RID: 4186
		[Token(Token = "0x400105A")]
		ConnectionReset,
		// Token: 0x0400105B RID: 4187
		[Token(Token = "0x400105B")]
		NoBufferSpaceAvailable,
		// Token: 0x0400105C RID: 4188
		[Token(Token = "0x400105C")]
		IsConnected,
		// Token: 0x0400105D RID: 4189
		[Token(Token = "0x400105D")]
		NotConnected,
		// Token: 0x0400105E RID: 4190
		[Token(Token = "0x400105E")]
		Shutdown,
		// Token: 0x0400105F RID: 4191
		[Token(Token = "0x400105F")]
		TimedOut = 10060,
		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		ConnectionRefused,
		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		HostDown = 10064,
		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		HostUnreachable,
		// Token: 0x04001063 RID: 4195
		[Token(Token = "0x4001063")]
		ProcessLimit = 10067,
		// Token: 0x04001064 RID: 4196
		[Token(Token = "0x4001064")]
		SystemNotReady = 10091,
		// Token: 0x04001065 RID: 4197
		[Token(Token = "0x4001065")]
		VersionNotSupported,
		// Token: 0x04001066 RID: 4198
		[Token(Token = "0x4001066")]
		NotInitialized,
		// Token: 0x04001067 RID: 4199
		[Token(Token = "0x4001067")]
		Disconnecting = 10101,
		// Token: 0x04001068 RID: 4200
		[Token(Token = "0x4001068")]
		TypeNotFound = 10109,
		// Token: 0x04001069 RID: 4201
		[Token(Token = "0x4001069")]
		HostNotFound = 11001,
		// Token: 0x0400106A RID: 4202
		[Token(Token = "0x400106A")]
		TryAgain,
		// Token: 0x0400106B RID: 4203
		[Token(Token = "0x400106B")]
		NoRecovery,
		// Token: 0x0400106C RID: 4204
		[Token(Token = "0x400106C")]
		NoData,
		// Token: 0x0400106D RID: 4205
		[Token(Token = "0x400106D")]
		IOPending = 997,
		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		OperationAborted = 995
	}
}
