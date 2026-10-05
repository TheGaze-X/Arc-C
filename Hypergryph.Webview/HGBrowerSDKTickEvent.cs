using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Hypergryph.SDK
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class HGBrowerSDKTickEvent : MonoBehaviour
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x4A2E060", Offset = "0x4A2CC60", VA = "0x184A2E060")]
		private void Update()
		{
		}

		// Token: 0x0600006C RID: 108
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x4A2E060", Offset = "0x4A2CC60", VA = "0x184A2E060")]
		[PreserveSig]
		private static extern void WebViewSDKTickEvent();

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HGBrowerSDKTickEvent()
		{
		}
	}
}
