using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x02001747 RID: 5959
	[Token(Token = "0x2001747")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class PersistentResInfoEntry
	{
		// Token: 0x0600963B RID: 38459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600963B")]
		[Address(RVA = "0x3111FE0", Offset = "0x3110BE0", VA = "0x183111FE0")]
		public static PersistentResInfo LoadLocalPersistentResInfo()
		{
			return null;
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600963C")]
		[Address(RVA = "0x3112230", Offset = "0x3110E30", VA = "0x183112230")]
		public static void WritePersistentResInfoToCacheFoler(PersistentResInfo info)
		{
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600963D")]
		[Address(RVA = "0x31122E0", Offset = "0x3110EE0", VA = "0x1831122E0")]
		public static void WritePersistentResInfoToPersistentFile(PersistentResInfo info)
		{
		}

		// Token: 0x0600963E RID: 38462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600963E")]
		[Address(RVA = "0x3112180", Offset = "0x3110D80", VA = "0x183112180")]
		public static void OverwriteLocalPersistentResInfoWithCache()
		{
		}

		// Token: 0x0600963F RID: 38463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600963F")]
		[Address(RVA = "0x31120F0", Offset = "0x3110CF0", VA = "0x1831120F0")]
		public static void MarkPersistResInfoInvalidAndDelete()
		{
		}

		// Token: 0x06009640 RID: 38464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009640")]
		[Address(RVA = "0x31127D0", Offset = "0x31113D0", VA = "0x1831127D0")]
		private static void _WritePersistentResInfoToFile(PersistentResInfo info, string path)
		{
		}

		// Token: 0x06009641 RID: 38465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009641")]
		[Address(RVA = "0x3112750", Offset = "0x3111350", VA = "0x183112750")]
		private static PersistentResInfo _TryLoadLocalPersistentResInfo()
		{
			return null;
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009642")]
		[Address(RVA = "0x31123F0", Offset = "0x3110FF0", VA = "0x1831123F0")]
		private static PersistentResInfo _LoadPersistentResInfoFromFile(string path)
		{
			return null;
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009643")]
		[Address(RVA = "0x3111EE0", Offset = "0x3110AE0", VA = "0x183111EE0")]
		public static void ClearCache()
		{
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009644")]
		[Address(RVA = "0x31126C0", Offset = "0x31112C0", VA = "0x1831126C0")]
		private static void _RequireReload()
		{
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009645")]
		[Address(RVA = "0x3111F40", Offset = "0x3110B40", VA = "0x183111F40")]
		public static string GeneratePersistentResInfoPath()
		{
			return null;
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009646")]
		[Address(RVA = "0x3112350", Offset = "0x3110F50", VA = "0x183112350")]
		private static string _GenPersistentResInfoCachedPath()
		{
			return null;
		}

		// Token: 0x04008C7F RID: 35967
		[Token(Token = "0x4008C7F")]
		[FieldOffset(Offset = "0x0")]
		private static PersistentResInfo s_info;

		// Token: 0x04008C80 RID: 35968
		[Token(Token = "0x4008C80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadLocalPersistentResInfo;

		// Token: 0x04008C81 RID: 35969
		[Token(Token = "0x4008C81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_WritePersistentResInfoToCacheFoler;

		// Token: 0x04008C82 RID: 35970
		[Token(Token = "0x4008C82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_WritePersistentResInfoToPersistentFile;

		// Token: 0x04008C83 RID: 35971
		[Token(Token = "0x4008C83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OverwriteLocalPersistentResInfoWithCache;

		// Token: 0x04008C84 RID: 35972
		[Token(Token = "0x4008C84")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_MarkPersistResInfoInvalidAndDelete;

		// Token: 0x04008C85 RID: 35973
		[Token(Token = "0x4008C85")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__WritePersistentResInfoToFile;

		// Token: 0x04008C86 RID: 35974
		[Token(Token = "0x4008C86")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryLoadLocalPersistentResInfo;

		// Token: 0x04008C87 RID: 35975
		[Token(Token = "0x4008C87")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadPersistentResInfoFromFile;

		// Token: 0x04008C88 RID: 35976
		[Token(Token = "0x4008C88")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ClearCache;

		// Token: 0x04008C89 RID: 35977
		[Token(Token = "0x4008C89")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RequireReload;

		// Token: 0x04008C8A RID: 35978
		[Token(Token = "0x4008C8A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GeneratePersistentResInfoPath;

		// Token: 0x04008C8B RID: 35979
		[Token(Token = "0x4008C8B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenPersistentResInfoCachedPath;
	}
}
