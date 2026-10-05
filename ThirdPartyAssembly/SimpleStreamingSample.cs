using System;
using BestHTTP.Examples;
using BestHTTP.SignalR;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
internal sealed class SimpleStreamingSample : MonoBehaviour
{
	// Token: 0x060000A1 RID: 161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x51C1140", Offset = "0x51BFD40", VA = "0x1851C1140")]
	private void Start()
	{
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x51B6580", Offset = "0x51B5180", VA = "0x1851B6580")]
	private void OnDestroy()
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x51C1090", Offset = "0x51BFC90", VA = "0x1851C1090")]
	private void OnGUI()
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x51C14D0", Offset = "0x51C00D0", VA = "0x1851C14D0")]
	private void signalRConnection_OnNonHubMessage(Connection connection, object data)
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x51C1570", Offset = "0x51C0170", VA = "0x1851C1570")]
	private void signalRConnection_OnStateChanged(Connection connection, ConnectionStates oldState, ConnectionStates newState)
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x51C1460", Offset = "0x51C0060", VA = "0x1851C1460")]
	private void signalRConnection_OnError(Connection connection, string error)
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x51C13A0", Offset = "0x51BFFA0", VA = "0x1851C13A0")]
	public SimpleStreamingSample()
	{
	}

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x18")]
	private readonly Uri URI;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x20")]
	private Connection signalRConnection;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x28")]
	private GUIMessageList messages;
}
