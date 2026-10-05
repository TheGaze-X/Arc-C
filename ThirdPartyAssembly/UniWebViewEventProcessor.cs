using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
public class UniWebViewEventProcessor : MonoBehaviour
{
	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000027")]
	public static UniWebViewEventProcessor instance
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x51C7020", Offset = "0x51C5C20", VA = "0x1851C7020")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x51C6DA0", Offset = "0x51C59A0", VA = "0x1851C6DA0")]
	public void QueueEvent(Action action)
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x51C6E70", Offset = "0x51C5A70", VA = "0x1851C6E70")]
	private void Update()
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x51C6C60", Offset = "0x51C5860", VA = "0x1851C6C60")]
	private void MoveQueuedEventsToExecuting()
	{
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x51C6F30", Offset = "0x51C5B30", VA = "0x1851C6F30")]
	public UniWebViewEventProcessor()
	{
	}

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x18")]
	private object _queueLock;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x20")]
	private List<Action> _queuedEvents;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x28")]
	private List<Action> _executingEvents;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x0")]
	private static UniWebViewEventProcessor _instance;
}
