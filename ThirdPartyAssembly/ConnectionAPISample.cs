using System;
using BestHTTP.Examples;
using BestHTTP.SignalR;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public sealed class ConnectionAPISample : MonoBehaviour
{
	// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x51B8540", Offset = "0x51B7140", VA = "0x1851B8540")]
	private void Start()
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x51B8270", Offset = "0x51B6E70", VA = "0x1851B8270")]
	private void OnGUI()
	{
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x51B6580", Offset = "0x51B5180", VA = "0x1851B6580")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x51B9380", Offset = "0x51B7F80", VA = "0x1851B9380")]
	private void signalRConnection_OnGeneralMessage(Connection manager, object data)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x51B93F0", Offset = "0x51B7FF0", VA = "0x1851B93F0")]
	private void signalRConnection_OnStateChanged(Connection manager, ConnectionStates oldState, ConnectionStates newState)
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x51B7FF0", Offset = "0x51B6BF0", VA = "0x1851B7FF0")]
	private void Broadcast(string text)
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x51B7F50", Offset = "0x51B6B50", VA = "0x1851B7F50")]
	private void BroadcastExceptMe(string text)
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x51B8090", Offset = "0x51B6C90", VA = "0x1851B8090")]
	private void EnterName(string name)
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x51B8130", Offset = "0x51B6D30", VA = "0x1851B8130")]
	private void JoinGroup(string groupName)
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x51B81D0", Offset = "0x51B6DD0", VA = "0x1851B81D0")]
	private void LeaveGroup(string groupName)
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x51B83E0", Offset = "0x51B6FE0", VA = "0x1851B83E0")]
	private void SendToMe(string text)
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x51B8480", Offset = "0x51B7080", VA = "0x1851B8480")]
	private void SendToUser(string userOrGroupName, string text)
	{
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x51B8320", Offset = "0x51B6F20", VA = "0x1851B8320")]
	private void SendToGroup(string userOrGroupName, string text)
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x51B9230", Offset = "0x51B7E30", VA = "0x1851B9230")]
	public ConnectionAPISample()
	{
	}

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x18")]
	private readonly Uri URI;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x20")]
	private Connection signalRConnection;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x28")]
	private string ToEveryBodyText;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x30")]
	private string ToMeText;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x38")]
	private string PrivateMessageText;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x40")]
	private string PrivateMessageUserOrGroupName;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x48")]
	private GUIMessageList messages;

	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	private enum MessageTypes
	{
		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		Send,
		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		Broadcast,
		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		Join,
		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		PrivateMessage,
		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		AddToGroup,
		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		RemoveFromGroup,
		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		SendToGroup,
		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		BroadcastExceptMe
	}
}
