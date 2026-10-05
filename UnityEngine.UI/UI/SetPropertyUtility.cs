using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	internal static class SetPropertyUtility
	{
		// Token: 0x0600048D RID: 1165 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x58C1610", Offset = "0x58C0210", VA = "0x1858C1610")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x600048E")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x600048F")]
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return default(bool);
		}
	}
}
