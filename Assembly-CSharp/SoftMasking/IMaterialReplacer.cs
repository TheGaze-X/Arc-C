using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SoftMasking
{
	// Token: 0x02000435 RID: 1077
	[Token(Token = "0x2000435")]
	public interface IMaterialReplacer
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06004969 RID: 18793
		[Token(Token = "0x17000163")]
		int order { [Token(Token = "0x6004969")] get; }

		// Token: 0x0600496A RID: 18794
		[Token(Token = "0x600496A")]
		Material Replace(Material material);
	}
}
