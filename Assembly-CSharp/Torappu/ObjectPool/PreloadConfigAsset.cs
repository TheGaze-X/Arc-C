using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.ObjectPool
{
	// Token: 0x02001481 RID: 5249
	[Token(Token = "0x2001481")]
	[CreateAssetMenu(menuName = "Torappu/ObjectPool/PreloadConfig")]
	public class PreloadConfigAsset : ScriptableObject
	{
		// Token: 0x06007985 RID: 31109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007985")]
		[Address(RVA = "0x26444C0", Offset = "0x26430C0", VA = "0x1826444C0")]
		public PreloadConfigAsset()
		{
		}

		// Token: 0x040077B5 RID: 30645
		[Token(Token = "0x40077B5")]
		[FieldOffset(Offset = "0x18")]
		public PoolManager.ObjectConfig[] configs;
	}
}
