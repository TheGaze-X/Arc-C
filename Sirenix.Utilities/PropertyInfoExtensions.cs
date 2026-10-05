using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public static class PropertyInfoExtensions
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x4E28F10", Offset = "0x4E27B10", VA = "0x184E28F10")]
		public static bool IsAutoProperty(this PropertyInfo propInfo, bool allowVirtual = false)
		{
			return default(bool);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x4E28EC0", Offset = "0x4E27AC0", VA = "0x184E28EC0")]
		public static bool IsAliasProperty(this PropertyInfo propertyInfo)
		{
			return default(bool);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x4E28D90", Offset = "0x4E27990", VA = "0x184E28D90")]
		public static PropertyInfo DeAliasProperty(this PropertyInfo propertyInfo, bool throwOnNotAliased = false)
		{
			return null;
		}
	}
}
