using System;
using BestHTTP.Examples;
using BestHTTP.SignalR.Hubs;
using BestHTTP.SignalR.Messages;
using Il2CppDummyDll;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
internal class BaseHub : Hub
{
	// Token: 0x0600004C RID: 76 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x51B7CE0", Offset = "0x51B68E0", VA = "0x1851B7CE0")]
	public BaseHub(string name, string title)
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x51B7760", Offset = "0x51B6360", VA = "0x1851B7760")]
	private void Joined(Hub hub, MethodCallMessage methodCall)
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x51B7C50", Offset = "0x51B6850", VA = "0x1851B7C50")]
	private void Rejoined(Hub hub, MethodCallMessage methodCall)
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x51B7AB0", Offset = "0x51B66B0", VA = "0x1851B7AB0")]
	private void Left(Hub hub, MethodCallMessage methodCall)
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x51B76D0", Offset = "0x51B62D0", VA = "0x1851B76D0")]
	private void Invoked(Hub hub, MethodCallMessage methodCall)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x51B75C0", Offset = "0x51B61C0", VA = "0x1851B75C0")]
	public void InvokedFromClient()
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x51B7BD0", Offset = "0x51B67D0", VA = "0x1851B7BD0")]
	private void OnInvoked(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x51B7B40", Offset = "0x51B6740", VA = "0x1851B7B40")]
	private void OnInvokeFailed(Hub hub, ClientMessage originalMessage, FailureMessage result)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x51B7510", Offset = "0x51B6110", VA = "0x1851B7510")]
	public void Draw()
	{
	}

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x48")]
	private string Title;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x50")]
	private GUIMessageList messages;
}
