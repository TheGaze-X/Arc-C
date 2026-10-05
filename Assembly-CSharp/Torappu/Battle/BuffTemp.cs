using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200266F RID: 9839
	[Token(Token = "0x200266F")]
	[CreateAssetMenu(menuName = "Torappu/DB/Temp/BuffTemp")]
	public class BuffTemp : ScriptableObject
	{
		// Token: 0x06010172 RID: 65906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010172")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public BuffTemp()
		{
		}

		// Token: 0x04011E5D RID: 73309
		[Token(Token = "0x4011E5D")]
		[FieldOffset(Offset = "0x18")]
		public BuffTemplate template;
	}
}
