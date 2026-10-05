using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public static class FieldInfoExtensions
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4E22430", Offset = "0x4E21030", VA = "0x184E22430")]
		public static bool IsAliasField(this FieldInfo fieldInfo)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4E22300", Offset = "0x4E20F00", VA = "0x184E22300")]
		public static FieldInfo DeAliasField(this FieldInfo fieldInfo, bool throwOnNotAliased = false)
		{
			return null;
		}
	}
}
