using System;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	public static class SirenixAssetPaths
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x4E38B40", Offset = "0x4E37740", VA = "0x184E38B40")]
		private static string ToPathSafeString(string name, char replace = '_')
		{
			return null;
		}

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		public const string DefaultSirenixPluginPath = "Assets/Plugins/Sirenix/";

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		public const string SirenixAssetPathsSOGuid = "08379ccefc05200459f90a1c0711a340";

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		public const string LookupAssetName = "OdinPathLookup.asset";

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string OdinPath;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string SirenixAssetsPath;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string SirenixPluginPath;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string SirenixAssembliesPath;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string OdinResourcesPath;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string OdinEditorConfigsPath;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string OdinResourcesConfigsPath;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string OdinTempPath;
	}
}
