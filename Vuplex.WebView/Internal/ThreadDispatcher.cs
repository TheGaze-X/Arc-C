using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public class ThreadDispatcher : MonoBehaviour
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x17000058")]
		public static bool CurrentlyOnMainThread
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x5BD1E50", Offset = "0x5BD0A50", VA = "0x185BD1E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x5BD15C0", Offset = "0x5BD01C0", VA = "0x185BD15C0")]
		public static void RunOnMainThread(Action action)
		{
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x5BD1CB0", Offset = "0x5BD08B0", VA = "0x185BD1CB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _initialize()
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x5BD17B0", Offset = "0x5BD03B0", VA = "0x185BD17B0")]
		private void Update()
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ThreadDispatcher()
		{
		}

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x0")]
		private static List<Action> _actions;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x8")]
		private static List<Action> _backlog;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x10")]
		private static ThreadDispatcher _instance;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x18")]
		private static int _mainThreadId;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x1C")]
		private static bool _queued;
	}
}
