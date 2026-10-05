using System;
using BestHTTP.SignalR;
using BestHTTP.SignalR.Hubs;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
internal class DemoHubSample : MonoBehaviour
{
	// Token: 0x0600006D RID: 109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x51B9FD0", Offset = "0x51B8BD0", VA = "0x1851B9FD0")]
	private void Start()
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x51B6580", Offset = "0x51B5180", VA = "0x1851B6580")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x51B9F20", Offset = "0x51B8B20", VA = "0x1851B9F20")]
	private void OnGUI()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x51BB690", Offset = "0x51BA290", VA = "0x1851BB690")]
	public DemoHubSample()
	{
	}

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x18")]
	private readonly Uri URI;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x20")]
	private Connection signalRConnection;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x28")]
	private DemoHub demoHub;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x30")]
	private TypedDemoHub typedDemoHub;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x38")]
	private Hub vbDemoHub;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x40")]
	private string vbReadStateResult;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 scrollPos;
}
