using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[AttributeUsage(AttributeTargets.Class)]
	internal class MenuCategoryAttribute : Attribute
	{
		// Token: 0x06000315 RID: 789 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x58FBEF0", Offset = "0x58FAAF0", VA = "0x1858FBEF0")]
		public MenuCategoryAttribute(string category)
		{
		}

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x10")]
		public readonly string category;
	}
}
