using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	internal class SupportsChildTracksAttribute : Attribute
	{
		// Token: 0x0600030E RID: 782 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x37442C0", Offset = "0x3742EC0", VA = "0x1837442C0")]
		public SupportsChildTracksAttribute([Optional] Type childType, int levels = 2147483647)
		{
		}

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Type childType;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly int levels;
	}
}
