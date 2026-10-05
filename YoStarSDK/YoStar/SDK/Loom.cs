using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public class Loom : MonoBehaviour
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public static Loom Current
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x5BE1920", Offset = "0x5BE0520", VA = "0x185BE1920")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x5BE07E0", Offset = "0x5BDF3E0", VA = "0x185BE07E0")]
		private void Awake()
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x5BE0870", Offset = "0x5BDF470", VA = "0x185BE0870")]
		public static void Initialize()
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x5BE0FB0", Offset = "0x5BDFBB0", VA = "0x185BE0FB0")]
		public static void QueueOnMainThread(Action<object> taction, object tparam)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x5BE0AB0", Offset = "0x5BDF6B0", VA = "0x185BE0AB0")]
		public static void QueueOnMainThread(Action<object> taction, object tparam, float time)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x5BE1140", Offset = "0x5BDFD40", VA = "0x185BE1140")]
		public static Thread RunAsync(Action a)
		{
			return null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x5BE1010", Offset = "0x5BDFC10", VA = "0x185BE1010")]
		private static void RunAction(object action)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x5BE09D0", Offset = "0x5BDF5D0", VA = "0x185BE09D0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Start()
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x5BE1250", Offset = "0x5BDFE50", VA = "0x185BE1250")]
		private void Update()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x5BE17E0", Offset = "0x5BE03E0", VA = "0x185BE17E0")]
		public Loom()
		{
		}

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x0")]
		public static int maxThreads;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x4")]
		private static int numThreads;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x8")]
		private static Loom _current;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x10")]
		private static bool initialized;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x18")]
		private List<Loom.NoDelayedQueueItem> _actions;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x20")]
		private List<Loom.DelayedQueueItem> _delayed;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x28")]
		private List<Loom.DelayedQueueItem> _currentDelayed;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x30")]
		private List<Loom.NoDelayedQueueItem> _currentActions;

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		public struct NoDelayedQueueItem
		{
			// Token: 0x040000A1 RID: 161
			[Token(Token = "0x40000A1")]
			[FieldOffset(Offset = "0x0")]
			public Action<object> action;

			// Token: 0x040000A2 RID: 162
			[Token(Token = "0x40000A2")]
			[FieldOffset(Offset = "0x8")]
			public object param;
		}

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		public struct DelayedQueueItem
		{
			// Token: 0x040000A3 RID: 163
			[Token(Token = "0x40000A3")]
			[FieldOffset(Offset = "0x0")]
			public float time;

			// Token: 0x040000A4 RID: 164
			[Token(Token = "0x40000A4")]
			[FieldOffset(Offset = "0x8")]
			public Action<object> action;

			// Token: 0x040000A5 RID: 165
			[Token(Token = "0x40000A5")]
			[FieldOffset(Offset = "0x10")]
			public object param;
		}
	}
}
