using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace U8.SDK
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	public class U8SDKTickEvent : MonoBehaviour
	{
		// Token: 0x06000281 RID: 641 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x4A29EC0", Offset = "0x4A28AC0", VA = "0x184A29EC0")]
		private void Update()
		{
		}

		// Token: 0x06000282 RID: 642
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x4A29EC0", Offset = "0x4A28AC0", VA = "0x184A29EC0")]
		[PreserveSig]
		public static extern void HGU8SDKTickEvent();

		// Token: 0x06000283 RID: 643 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public U8SDKTickEvent()
		{
		}
	}
}
