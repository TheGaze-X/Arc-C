using System;
using BestHTTP.WebSocket;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000019 RID: 25
[Token(Token = "0x2000019")]
public class WebSocketSample : MonoBehaviour
{
	// Token: 0x060000E0 RID: 224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x51C87B0", Offset = "0x51C73B0", VA = "0x1851C87B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x51C8960", Offset = "0x51C7560", VA = "0x1851C8960")]
	private void OnGUI()
	{
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x51C8A90", Offset = "0x51C7690", VA = "0x1851C8A90")]
	private void OnOpen(WebSocket ws)
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x51C8A10", Offset = "0x51C7610", VA = "0x1851C8A10")]
	private void OnMessageReceived(WebSocket ws, string message)
	{
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x51C86F0", Offset = "0x51C72F0", VA = "0x1851C86F0")]
	private void OnClosed(WebSocket ws, ushort code, string message)
	{
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x51C87D0", Offset = "0x51C73D0", VA = "0x1851C87D0")]
	private void OnError(WebSocket ws, Exception ex)
	{
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x51C9340", Offset = "0x51C7F40", VA = "0x1851C9340")]
	public WebSocketSample()
	{
	}

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x18")]
	private string address;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x20")]
	private string msgToSend;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x28")]
	private string Text;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x30")]
	private WebSocket webSocket;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 scrollPos;
}
