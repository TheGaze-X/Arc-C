using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x0200173C RID: 5948
	[Token(Token = "0x200173C")]
	public class HotUpdateMgr : Singleton<HotUpdateMgr>
	{
		// Token: 0x06009605 RID: 38405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009605")]
		[Address(RVA = "0x31084A0", Offset = "0x31070A0", VA = "0x1831084A0")]
		public static void Init(bool force = false)
		{
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x0003A770 File Offset: 0x00038970
		[Token(Token = "0x6009606")]
		[Address(RVA = "0x3108410", Offset = "0x3107010", VA = "0x183108410")]
		public static bool CheckUpdate(string resType)
		{
			return default(bool);
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x0003A788 File Offset: 0x00038988
		[Token(Token = "0x6009607")]
		[Address(RVA = "0x3108360", Offset = "0x3106F60", VA = "0x183108360")]
		public static bool CheckUpdateByABName(string abname)
		{
			return default(bool);
		}

		// Token: 0x06009608 RID: 38408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009608")]
		[Address(RVA = "0x31085D0", Offset = "0x31071D0", VA = "0x1831085D0")]
		public static void SetUpdate(string resType, bool update)
		{
		}

		// Token: 0x06009609 RID: 38409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009609")]
		[Address(RVA = "0x3108530", Offset = "0x3107130", VA = "0x183108530")]
		public static void SetUpdateList(IList<string> resTypeList, bool update)
		{
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600960A")]
		[Address(RVA = "0x31082D0", Offset = "0x3106ED0", VA = "0x1831082D0")]
		public static string CheckType(string abname)
		{
			return null;
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600960B")]
		[Address(RVA = "0x31090A0", Offset = "0x3107CA0", VA = "0x1831090A0")]
		private HotUpdateMgr()
		{
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600960C")]
		[Address(RVA = "0x3108970", Offset = "0x3107570", VA = "0x183108970")]
		private void _Init(bool force)
		{
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x0003A7A0 File Offset: 0x000389A0
		[Token(Token = "0x600960D")]
		[Address(RVA = "0x3108830", Offset = "0x3107430", VA = "0x183108830")]
		private bool _CheckUpdate(string type)
		{
			return default(bool);
		}

		// Token: 0x0600960E RID: 38414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600960E")]
		[Address(RVA = "0x3108F70", Offset = "0x3107B70", VA = "0x183108F70")]
		private void _SetUpdate(string type, bool update)
		{
		}

		// Token: 0x0600960F RID: 38415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600960F")]
		[Address(RVA = "0x3108CD0", Offset = "0x31078D0", VA = "0x183108CD0")]
		private void _SetUpdateList(IList<string> typeList, bool update)
		{
		}

		// Token: 0x06009610 RID: 38416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009610")]
		[Address(RVA = "0x3108770", Offset = "0x3107370", VA = "0x183108770")]
		private string _CheckType(string abname)
		{
			return null;
		}

		// Token: 0x04008C3C RID: 35900
		[Token(Token = "0x4008C3C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, string> m_typeInfos;

		// Token: 0x04008C3D RID: 35901
		[Token(Token = "0x4008C3D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, bool> m_status;

		// Token: 0x04008C3E RID: 35902
		[Token(Token = "0x4008C3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04008C3F RID: 35903
		[Token(Token = "0x4008C3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckUpdate;

		// Token: 0x04008C40 RID: 35904
		[Token(Token = "0x4008C40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckUpdateByABName;

		// Token: 0x04008C41 RID: 35905
		[Token(Token = "0x4008C41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetUpdate;

		// Token: 0x04008C42 RID: 35906
		[Token(Token = "0x4008C42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetUpdateList;

		// Token: 0x04008C43 RID: 35907
		[Token(Token = "0x4008C43")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckType;

		// Token: 0x04008C44 RID: 35908
		[Token(Token = "0x4008C44")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008C45 RID: 35909
		[Token(Token = "0x4008C45")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x04008C46 RID: 35910
		[Token(Token = "0x4008C46")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckUpdate;

		// Token: 0x04008C47 RID: 35911
		[Token(Token = "0x4008C47")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetUpdate;

		// Token: 0x04008C48 RID: 35912
		[Token(Token = "0x4008C48")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetUpdateList;

		// Token: 0x04008C49 RID: 35913
		[Token(Token = "0x4008C49")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckType;
	}
}
