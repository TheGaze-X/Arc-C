using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace UDatasdk.commons
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public class Loom : MonoBehaviour
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000065")]
		public static Loom Current
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x55C9920", Offset = "0x55C8520", VA = "0x1855C9920")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x55C8850", Offset = "0x55C7450", VA = "0x1855C8850")]
		private void Awake()
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x55C88E0", Offset = "0x55C74E0", VA = "0x1855C88E0")]
		public static void Initialize()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x55C8B20", Offset = "0x55C7720", VA = "0x1855C8B20")]
		public static void QueueOnMainThread(Action<object> taction, object tparam)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x55C8B80", Offset = "0x55C7780", VA = "0x1855C8B80")]
		public static void QueueOnMainThread(Action<object> taction, object tparam, float time)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x55C9130", Offset = "0x55C7D30", VA = "0x1855C9130")]
		public static Thread RunAsync(Action a)
		{
			return null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x55C9000", Offset = "0x55C7C00", VA = "0x1855C9000")]
		private static void RunAction(object action)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x55C8A40", Offset = "0x55C7640", VA = "0x1855C8A40")]
		private void OnDisable()
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Start()
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x55C9240", Offset = "0x55C7E40", VA = "0x1855C9240")]
		private void Update()
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x55C97E0", Offset = "0x55C83E0", VA = "0x1855C97E0")]
		public Loom()
		{
		}

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x0")]
		public static int maxThreads;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x4")]
		private static int numThreads;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x8")]
		private static Loom _current;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x10")]
		private static bool initialized;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x18")]
		private List<Loom.NoDelayedQueueItem> _actions;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x20")]
		private List<Loom.DelayedQueueItem> _delayed;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x28")]
		private List<Loom.DelayedQueueItem> _currentDelayed;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x30")]
		private List<Loom.NoDelayedQueueItem> _currentActions;

		// Token: 0x02000047 RID: 71
		[Token(Token = "0x2000047")]
		public struct NoDelayedQueueItem
		{
			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			[FieldOffset(Offset = "0x0")]
			public Action<object> action;

			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			[FieldOffset(Offset = "0x8")]
			public object param;
		}

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		public struct DelayedQueueItem
		{
			// Token: 0x04000117 RID: 279
			[Token(Token = "0x4000117")]
			[FieldOffset(Offset = "0x0")]
			public float time;

			// Token: 0x04000118 RID: 280
			[Token(Token = "0x4000118")]
			[FieldOffset(Offset = "0x8")]
			public Action<object> action;

			// Token: 0x04000119 RID: 281
			[Token(Token = "0x4000119")]
			[FieldOffset(Offset = "0x10")]
			public object param;
		}
	}
}
