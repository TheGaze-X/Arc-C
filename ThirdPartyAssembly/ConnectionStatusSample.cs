using System;
using BestHTTP.Examples;
using BestHTTP.SignalR;
using BestHTTP.SignalR.Hubs;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
internal sealed class ConnectionStatusSample : MonoBehaviour
{
	// Token: 0x06000064 RID: 100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x51B9570", Offset = "0x51B8170", VA = "0x1851B9570")]
	private void Start()
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x51B6580", Offset = "0x51B5180", VA = "0x1851B6580")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x51B94C0", Offset = "0x51B80C0", VA = "0x1851B94C0")]
	private void OnGUI()
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x51B9B90", Offset = "0x51B8790", VA = "0x1851B9B90")]
	private void signalRConnection_OnNonHubMessage(Connection manager, object data)
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x51B9C30", Offset = "0x51B8830", VA = "0x1851B9C30")]
	private void signalRConnection_OnStateChanged(Connection manager, ConnectionStates oldState, ConnectionStates newState)
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x51B9B20", Offset = "0x51B8720", VA = "0x1851B9B20")]
	private void signalRConnection_OnError(Connection manager, string error)
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x51B9CE0", Offset = "0x51B88E0", VA = "0x1851B9CE0")]
	private void statusHub_OnMethodCall(Hub hub, string method, params object[] args)
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x51B9A60", Offset = "0x51B8660", VA = "0x1851B9A60")]
	public ConnectionStatusSample()
	{
	}

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x18")]
	private readonly Uri URI;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x20")]
	private Connection signalRConnection;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x28")]
	private GUIMessageList messages;
}
