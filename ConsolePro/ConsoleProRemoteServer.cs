using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FlyingWormConsole3
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public class ConsoleProRemoteServer : MonoBehaviour
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x36989F0", Offset = "0x36975F0", VA = "0x1836989F0")]
		public void Awake()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3698A50", Offset = "0x3697650", VA = "0x183698A50")]
		public ConsoleProRemoteServer()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		public bool useNATPunch;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x1C")]
		public int port;
	}
}
