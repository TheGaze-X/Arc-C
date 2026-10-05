using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	public enum ESteamNetworkingConfigValue
	{
		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		k_ESteamNetworkingConfig_Invalid,
		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		k_ESteamNetworkingConfig_TimeoutInitial = 24,
		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		k_ESteamNetworkingConfig_TimeoutConnected,
		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		k_ESteamNetworkingConfig_SendBufferSize = 9,
		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x400097E")]
		k_ESteamNetworkingConfig_RecvBufferSize = 47,
		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		k_ESteamNetworkingConfig_RecvBufferMessages,
		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		k_ESteamNetworkingConfig_RecvMaxMessageSize,
		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		k_ESteamNetworkingConfig_RecvMaxSegmentsPerPacket,
		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		k_ESteamNetworkingConfig_ConnectionUserData = 40,
		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		k_ESteamNetworkingConfig_SendRateMin = 10,
		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		k_ESteamNetworkingConfig_SendRateMax,
		// Token: 0x04000985 RID: 2437
		[Token(Token = "0x4000985")]
		k_ESteamNetworkingConfig_NagleTime,
		// Token: 0x04000986 RID: 2438
		[Token(Token = "0x4000986")]
		k_ESteamNetworkingConfig_IP_AllowWithoutAuth = 23,
		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x4000987")]
		k_ESteamNetworkingConfig_IPLocalHost_AllowWithoutAuth = 52,
		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		k_ESteamNetworkingConfig_MTU_PacketSize = 32,
		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		k_ESteamNetworkingConfig_MTU_DataSize,
		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		k_ESteamNetworkingConfig_Unencrypted,
		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		k_ESteamNetworkingConfig_SymmetricConnect = 37,
		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		k_ESteamNetworkingConfig_LocalVirtualPort,
		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		k_ESteamNetworkingConfig_DualWifi_Enable,
		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		k_ESteamNetworkingConfig_EnableDiagnosticsUI = 46,
		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		k_ESteamNetworkingConfig_FakePacketLoss_Send = 2,
		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		k_ESteamNetworkingConfig_FakePacketLoss_Recv,
		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		k_ESteamNetworkingConfig_FakePacketLag_Send,
		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		k_ESteamNetworkingConfig_FakePacketLag_Recv,
		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		k_ESteamNetworkingConfig_FakePacketReorder_Send,
		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		k_ESteamNetworkingConfig_FakePacketReorder_Recv,
		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		k_ESteamNetworkingConfig_FakePacketReorder_Time,
		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		k_ESteamNetworkingConfig_FakePacketDup_Send = 26,
		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		k_ESteamNetworkingConfig_FakePacketDup_Recv,
		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		k_ESteamNetworkingConfig_FakePacketDup_TimeMax,
		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		k_ESteamNetworkingConfig_PacketTraceMaxBytes = 41,
		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		k_ESteamNetworkingConfig_FakeRateLimit_Send_Rate,
		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		k_ESteamNetworkingConfig_FakeRateLimit_Send_Burst,
		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		k_ESteamNetworkingConfig_FakeRateLimit_Recv_Rate,
		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		k_ESteamNetworkingConfig_FakeRateLimit_Recv_Burst,
		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		k_ESteamNetworkingConfig_OutOfOrderCorrectionWindowMicroseconds = 51,
		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		k_ESteamNetworkingConfig_Callback_ConnectionStatusChanged = 201,
		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		k_ESteamNetworkingConfig_Callback_AuthStatusChanged,
		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		k_ESteamNetworkingConfig_Callback_RelayNetworkStatusChanged,
		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		k_ESteamNetworkingConfig_Callback_MessagesSessionRequest,
		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		k_ESteamNetworkingConfig_Callback_MessagesSessionFailed,
		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		k_ESteamNetworkingConfig_Callback_CreateConnectionSignaling,
		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		k_ESteamNetworkingConfig_Callback_FakeIPResult,
		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		k_ESteamNetworkingConfig_P2P_STUN_ServerList = 103,
		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Enable,
		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x40009A8")]
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Penalty,
		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		k_ESteamNetworkingConfig_P2P_Transport_SDR_Penalty,
		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		k_ESteamNetworkingConfig_P2P_TURN_ServerList,
		// Token: 0x040009AB RID: 2475
		[Token(Token = "0x40009AB")]
		k_ESteamNetworkingConfig_P2P_TURN_UserList,
		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x40009AC")]
		k_ESteamNetworkingConfig_P2P_TURN_PassList,
		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Implementation,
		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial = 19,
		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail,
		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		k_ESteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate,
		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x40009B1")]
		k_ESteamNetworkingConfig_SDRClient_SingleSocket,
		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		k_ESteamNetworkingConfig_SDRClient_ForceRelayCluster = 29,
		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		k_ESteamNetworkingConfig_SDRClient_DevTicket,
		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		k_ESteamNetworkingConfig_SDRClient_ForceProxyAddr,
		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		k_ESteamNetworkingConfig_SDRClient_FakeClusterPing = 36,
		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		k_ESteamNetworkingConfig_SDRClient_LimitPingProbesToNearestN = 60,
		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		k_ESteamNetworkingConfig_LogLevel_AckRTT = 13,
		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		k_ESteamNetworkingConfig_LogLevel_PacketDecode,
		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		k_ESteamNetworkingConfig_LogLevel_Message,
		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		k_ESteamNetworkingConfig_LogLevel_PacketGaps,
		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		k_ESteamNetworkingConfig_LogLevel_P2PRendezvous,
		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		k_ESteamNetworkingConfig_LogLevel_SDRRelayPings,
		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x40009BD")]
		k_ESteamNetworkingConfig_ECN = 999,
		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x40009BE")]
		k_ESteamNetworkingConfig_DELETED_EnumerateDevVars = 35,
		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x40009BF")]
		k_ESteamNetworkingConfigValue__Force32Bit = 2147483647
	}
}
