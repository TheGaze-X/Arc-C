using System;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace Hypergryph.SDK
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public class HGGameUpdateCallback : MonoBehaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x4A07260", Offset = "0x4A05E60", VA = "0x184A07260")]
		public HGGameUpdateCallback()
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x4A07070", Offset = "0x4A05C70", VA = "0x184A07070")]
		public static void Init(IHGGameUpdateSDKCallback callback)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4A072D0", Offset = "0x4A05ED0", VA = "0x184A072D0")]
		public void onLatestGame(string data)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4A07490", Offset = "0x4A06090", VA = "0x184A07490")]
		private void runInMainTread(Action action)
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static IHGGameUpdateSDKCallback m_callback;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		private const string gameObjectName = "(hggameupdate_callback)";

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x8")]
		private static SynchronizationContext mainThreadContext;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x10")]
		public static HGGameUpdateCallback s_instance;
	}
}
