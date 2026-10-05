using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B9C RID: 31644
	[Token(Token = "0x2007B9C")]
	public static class fsVersionManager
	{
		// Token: 0x0602C4CD RID: 181453 RVA: 0x000DF668 File Offset: 0x000DD868
		[Token(Token = "0x602C4CD")]
		[Address(RVA = "0x2876D10", Offset = "0x2875910", VA = "0x182876D10")]
		public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path)
		{
			return default(fsResult);
		}

		// Token: 0x0602C4CE RID: 181454 RVA: 0x000DF680 File Offset: 0x000DD880
		[Token(Token = "0x602C4CE")]
		[Address(RVA = "0x2876BA0", Offset = "0x28757A0", VA = "0x182876BA0")]
		private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current)
		{
			return default(bool);
		}

		// Token: 0x0602C4CF RID: 181455 RVA: 0x000DF698 File Offset: 0x000DD898
		[Token(Token = "0x602C4CF")]
		[Address(RVA = "0x2877110", Offset = "0x2875D10", VA = "0x182877110")]
		public static fsOption<fsVersionedType> GetVersionedType(Type type)
		{
			return default(fsOption<fsVersionedType>);
		}

		// Token: 0x0602C4D0 RID: 181456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C4D0")]
		[Address(RVA = "0x28776D0", Offset = "0x28762D0", VA = "0x1828776D0")]
		private static void VerifyConstructors(fsVersionedType type)
		{
		}

		// Token: 0x0602C4D1 RID: 181457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C4D1")]
		[Address(RVA = "0x28778C0", Offset = "0x28764C0", VA = "0x1828778C0")]
		private static void VerifyUniqueVersionStrings(fsVersionedType type)
		{
		}

		// Token: 0x040401F1 RID: 262641
		[Token(Token = "0x40401F1")]
		[ThreadStatic]
		private static Dictionary<Type, fsOption<fsVersionedType>> _cache;
	}
}
