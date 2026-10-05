using System;
using System.Collections.Generic;
using BestHTTP.SocketIO;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public sealed class SocketIOChatSample : MonoBehaviour
{
	// Token: 0x060000A9 RID: 169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x51C2920", Offset = "0x51C1520", VA = "0x1851C2920")]
	private void Start()
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x51C18E0", Offset = "0x51C04E0", VA = "0x1851C18E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x51C38F0", Offset = "0x51C24F0", VA = "0x1851C38F0")]
	private void Update()
	{
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x51C1900", Offset = "0x51C0500", VA = "0x1851C1900")]
	private void OnGUI()
	{
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x51C1830", Offset = "0x51C0430", VA = "0x1851C1830")]
	private void DrawLoginScreen()
	{
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x51C1780", Offset = "0x51C0380", VA = "0x1851C1780")]
	private void DrawChatScreen()
	{
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x51C2820", Offset = "0x51C1420", VA = "0x1851C2820")]
	private void SetUserName()
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x51C2690", Offset = "0x51C1290", VA = "0x1851C2690")]
	private void SendMessage()
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x51C3830", Offset = "0x51C2430", VA = "0x1851C3830")]
	private void UpdateTyping()
	{
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x51C3CC0", Offset = "0x51C28C0", VA = "0x1851C3CC0")]
	private void addParticipantsMessage(Dictionary<string, object> data)
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x51C3BA0", Offset = "0x51C27A0", VA = "0x1851C3BA0")]
	private void addChatMessage(Dictionary<string, object> data)
	{
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x51C1680", Offset = "0x51C0280", VA = "0x1851C1680")]
	private void AddChatTyping(Dictionary<string, object> data)
	{
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x51C2510", Offset = "0x51C1110", VA = "0x1851C2510")]
	private void RemoveChatTyping(Dictionary<string, object> data)
	{
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x51C1A30", Offset = "0x51C0630", VA = "0x1851C1A30")]
	private void OnLogin(Socket socket, Packet packet, params object[] args)
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x51C1B10", Offset = "0x51C0710", VA = "0x1851C1B10")]
	private void OnNewMessage(Socket socket, Packet packet, params object[] args)
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x51C2090", Offset = "0x51C0C90", VA = "0x1851C2090")]
	private void OnUserJoined(Socket socket, Packet packet, params object[] args)
	{
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x51C22D0", Offset = "0x51C0ED0", VA = "0x1851C22D0")]
	private void OnUserLeft(Socket socket, Packet packet, params object[] args)
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x51C1EE0", Offset = "0x51C0AE0", VA = "0x1851C1EE0")]
	private void OnTyping(Socket socket, Packet packet, params object[] args)
	{
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x51C1CD0", Offset = "0x51C08D0", VA = "0x1851C1CD0")]
	private void OnStopTyping(Socket socket, Packet packet, params object[] args)
	{
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x51C3A40", Offset = "0x51C2640", VA = "0x1851C3A40")]
	public SocketIOChatSample()
	{
	}

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x18")]
	private readonly TimeSpan TYPING_TIMER_LENGTH;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x20")]
	private SocketManager Manager;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x28")]
	private SocketIOChatSample.ChatStates State;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x30")]
	private string userName;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x38")]
	private string message;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x40")]
	private string chatLog;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 scrollPos;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x50")]
	private bool typing;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x58")]
	private DateTime lastTypingTime;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x60")]
	private List<string> typingUsers;

	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	private enum ChatStates
	{
		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		Login,
		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		Chat
	}
}
