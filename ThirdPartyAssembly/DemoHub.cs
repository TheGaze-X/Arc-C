using System;
using BestHTTP.Examples;
using BestHTTP.SignalR.Hubs;
using BestHTTP.SignalR.Messages;
using Il2CppDummyDll;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
internal class DemoHub : Hub
{
	// Token: 0x06000079 RID: 121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x51BDC80", Offset = "0x51BC880", VA = "0x1851BDC80")]
	public DemoHub()
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x51BD1F0", Offset = "0x51BBDF0", VA = "0x1851BD1F0")]
	public void ReportProgress(string arg)
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x51BCB40", Offset = "0x51BB740", VA = "0x1851BCB40")]
	public void OnLongRunningJob_Progress(Hub hub, ClientMessage originialMessage, ProgressMessage progress)
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x51BCA80", Offset = "0x51BB680", VA = "0x1851BCA80")]
	public void OnLongRunningJob_Done(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x51BC8A0", Offset = "0x51BB4A0", VA = "0x1851BC8A0")]
	public void MultipleCalls()
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x51BC350", Offset = "0x51BAF50", VA = "0x1851BC350")]
	public void DynamicTask()
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x51BC970", Offset = "0x51BB570", VA = "0x1851BC970")]
	private void OnDynamicTask_Failed(Hub hub, ClientMessage originalMessage, FailureMessage result)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x51BC900", Offset = "0x51BB500", VA = "0x1851BC900")]
	private void OnDynamicTask_Done(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x51BB740", Offset = "0x51BA340", VA = "0x1851BB740")]
	public void AddToGroups()
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x51BC690", Offset = "0x51BB290", VA = "0x1851BC690")]
	public void GetValue()
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x51BD5D0", Offset = "0x51BC1D0", VA = "0x1851BD5D0")]
	public void TaskWithException()
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x51BC5D0", Offset = "0x51BB1D0", VA = "0x1851BC5D0")]
	public void GenericTaskWithException()
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x51BD510", Offset = "0x51BC110", VA = "0x1851BD510")]
	public void SynchronousException()
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x51BCF50", Offset = "0x51BBB50", VA = "0x1851BCF50")]
	public void PassingDynamicComplex(object person)
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x51BD3F0", Offset = "0x51BBFF0", VA = "0x1851BD3F0")]
	public void SimpleArray(int[] array)
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x51BB8C0", Offset = "0x51BA4C0", VA = "0x1851BB8C0")]
	public void ComplexType(object person)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x51BB7A0", Offset = "0x51BA3A0", VA = "0x1851BB7A0")]
	public void ComplexArray(object[] complexArray)
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x51BCD50", Offset = "0x51BB950", VA = "0x1851BCD50")]
	public void Overload()
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x51BCBD0", Offset = "0x51BB7D0", VA = "0x1851BCBD0")]
	private void OnVoidOverload_Done(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x51BCE10", Offset = "0x51BBA10", VA = "0x1851BCE10")]
	public void Overload(int number)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x51BC9E0", Offset = "0x51BB5E0", VA = "0x1851BC9E0")]
	private void OnIntOverload_Done(Hub hub, ClientMessage originalMessage, ResultMessage result)
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x51BD130", Offset = "0x51BBD30", VA = "0x1851BD130")]
	public void ReadStateValue()
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x51BD070", Offset = "0x51BBC70", VA = "0x1851BD070")]
	public void PlainTask()
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x51BC510", Offset = "0x51BB110", VA = "0x1851BC510")]
	public void GenericTaskWithContinueWith()
	{
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x51BC460", Offset = "0x51BB060", VA = "0x1851BC460")]
	private void FromArbitraryCode(Hub hub, MethodCallMessage methodCall)
	{
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x51BC750", Offset = "0x51BB350", VA = "0x1851BC750")]
	private void GroupAdded(Hub hub, MethodCallMessage methodCall)
	{
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x51BD370", Offset = "0x51BBF70", VA = "0x1851BD370")]
	private void Signal(Hub hub, MethodCallMessage methodCall)
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x51BC7D0", Offset = "0x51BB3D0", VA = "0x1851BC7D0")]
	private void Invoke(Hub hub, MethodCallMessage methodCall)
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x51BB9E0", Offset = "0x51BA5E0", VA = "0x1851BB9E0")]
	public void Draw()
	{
	}

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x48")]
	private float longRunningJobProgress;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x50")]
	private string longRunningJobStatus;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x58")]
	private string fromArbitraryCodeResult;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x60")]
	private string groupAddedResult;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x68")]
	private string dynamicTaskResult;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x70")]
	private string genericTaskResult;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x78")]
	private string taskWithExceptionResult;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x80")]
	private string genericTaskWithExceptionResult;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x88")]
	private string synchronousExceptionResult;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x90")]
	private string invokingHubMethodWithDynamicResult;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x98")]
	private string simpleArrayResult;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0xA0")]
	private string complexTypeResult;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0xA8")]
	private string complexArrayResult;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0xB0")]
	private string voidOverloadResult;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0xB8")]
	private string intOverloadResult;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0xC0")]
	private string readStateResult;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0xC8")]
	private string plainTaskResult;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0xD0")]
	private string genericTaskWithContinueWithResult;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0xD8")]
	private GUIMessageList invokeResults;
}
