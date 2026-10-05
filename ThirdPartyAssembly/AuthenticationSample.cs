using System;
using BestHTTP.SignalR;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
internal class AuthenticationSample : MonoBehaviour
{
	// Token: 0x06000045 RID: 69 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x51B6720", Offset = "0x51B5320", VA = "0x1851B6720")]
	private void Start()
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x51B6580", Offset = "0x51B5180", VA = "0x1851B6580")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x51B65A0", Offset = "0x51B51A0", VA = "0x1851B65A0")]
	private void OnGUI()
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x51B72C0", Offset = "0x51B5EC0", VA = "0x1851B72C0")]
	private void signalRConnection_OnConnected(Connection manager)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x51B6650", Offset = "0x51B5250", VA = "0x1851B6650")]
	private void Restart()
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x51B71F0", Offset = "0x51B5DF0", VA = "0x1851B71F0")]
	public AuthenticationSample()
	{
	}

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x18")]
	private readonly Uri URI;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	private Connection signalRConnection;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x28")]
	private string userName;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x30")]
	private string role;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 scrollPos;
}
