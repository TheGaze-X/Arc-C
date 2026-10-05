using System;
using BestHTTP.SignalR.Hubs;
using BestHTTP.SignalR.Messages;
using Il2CppDummyDll;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
internal class TypedDemoHub : Hub
{
	// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x51C5E50", Offset = "0x51C4A50", VA = "0x1851C5E50")]
	public TypedDemoHub()
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x51C5D70", Offset = "0x51C4970", VA = "0x1851C5D70")]
	private void Echo(Hub hub, MethodCallMessage methodCall)
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x51C5C50", Offset = "0x51C4850", VA = "0x1851C5C50")]
	public void Echo(string msg)
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x51C5E00", Offset = "0x51C4A00", VA = "0x1851C5E00")]
	private void OnEcho_Done(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x51C5B50", Offset = "0x51C4750", VA = "0x1851C5B50")]
	public void Draw()
	{
	}

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x48")]
	private string typedEchoResult;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x50")]
	private string typedEchoClientResult;
}
