using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.Utilities
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public static class UnityVersion
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void EnsureLoaded()
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000039D4 File Offset: 0x00001BD4
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x4E39740", Offset = "0x4E38340", VA = "0x184E39740")]
		public static bool IsVersionOrGreater(int major, int minor)
		{
			return default(bool);
		}

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Major;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int Minor;
	}
}
