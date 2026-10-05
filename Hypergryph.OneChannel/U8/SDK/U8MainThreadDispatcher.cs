using System;
using System.Collections.Concurrent;
using Il2CppDummyDll;
using UnityEngine;

namespace U8.SDK
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public class U8MainThreadDispatcher : MonoBehaviour
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x4A2D9F0", Offset = "0x4A2C5F0", VA = "0x184A2D9F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Initialize()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x4A2DB40", Offset = "0x4A2C740", VA = "0x184A2DB40")]
		public static void RunOnMainThread(Action action)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x4A2DBD0", Offset = "0x4A2C7D0", VA = "0x184A2DBD0")]
		private void Update()
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public U8MainThreadDispatcher()
		{
		}

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ConcurrentQueue<Action> _queue;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x8")]
		private static U8MainThreadDispatcher _instance;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x10")]
		private static int _initialized;
	}
}
