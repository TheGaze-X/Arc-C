using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	internal static class VisualElementListPool
	{
		// Token: 0x06000565 RID: 1381 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x5AA0F10", Offset = "0x5A9FB10", VA = "0x185AA0F10")]
		public static List<VisualElement> Copy(List<VisualElement> elements)
		{
			return null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x5AA0FC0", Offset = "0x5A9FBC0", VA = "0x185AA0FC0")]
		public static List<VisualElement> Get(int initialCapacity = 0)
		{
			return null;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x5AA1090", Offset = "0x5A9FC90", VA = "0x185AA1090")]
		public static void Release(List<VisualElement> elements)
		{
		}

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<List<VisualElement>> pool;
	}
}
