using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu;
using XLua;

namespace HGSDK.Test
{
	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	public class DebugAccountMgr : Singleton<DebugAccountMgr>
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x251DAB0", Offset = "0x251C6B0", VA = "0x18251DAB0")]
		private DebugAccountMgr()
		{
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x251D2D0", Offset = "0x251BED0", VA = "0x18251D2D0")]
		public void Register(HGSDK sdk)
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x251D350", Offset = "0x251BF50", VA = "0x18251D350")]
		public void TraceGameInfo()
		{
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x251D160", Offset = "0x251BD60", VA = "0x18251D160")]
		public bool DeleteAccount(int idx)
		{
			return default(bool);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x251D7A0", Offset = "0x251C3A0", VA = "0x18251D7A0")]
		private void _DoSave()
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x251CF20", Offset = "0x251BB20", VA = "0x18251CF20")]
		public bool ApplyAccount(int idx)
		{
			return default(bool);
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000137")]
		public IEnumerable<DebugAccountMgr.AccountInfo> accIter
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x251DB20", Offset = "0x251C720", VA = "0x18251DB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x251D8D0", Offset = "0x251C4D0", VA = "0x18251D8D0")]
		private void _Init()
		{
		}

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		private const string STORAGE_FILE = "HGSDK_DebugAccountHistory.json";

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		[FieldOffset(Offset = "0x10")]
		private List<DebugAccountMgr.AccountInfo> m_history;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		[FieldOffset(Offset = "0x18")]
		private HGSDK m_sdk;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TraceGameInfo;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DeleteAccount;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoSave;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyAccount;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_accIter;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x020001E6 RID: 486
		[Token(Token = "0x20001E6")]
		public class AccountInfo
		{
			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000880 RID: 2176 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000138")]
			public string uid
			{
				[Token(Token = "0x6000880")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x251CD00", Offset = "0x251B900", VA = "0x18251CD00")]
			public string GetDisplayName()
			{
				return null;
			}

			// Token: 0x06000882 RID: 2178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AccountInfo()
			{
			}

			// Token: 0x04000AC3 RID: 2755
			[Token(Token = "0x4000AC3")]
			[FieldOffset(Offset = "0x10")]
			public long lastUse;

			// Token: 0x04000AC4 RID: 2756
			[Token(Token = "0x4000AC4")]
			[FieldOffset(Offset = "0x18")]
			public bool isGuest;

			// Token: 0x04000AC5 RID: 2757
			[Token(Token = "0x4000AC5")]
			[FieldOffset(Offset = "0x20")]
			public HGSDK.LoginResult info;

			// Token: 0x04000AC6 RID: 2758
			[Token(Token = "0x4000AC6")]
			[FieldOffset(Offset = "0x38")]
			public string platformUid;

			// Token: 0x04000AC7 RID: 2759
			[Token(Token = "0x4000AC7")]
			[FieldOffset(Offset = "0x40")]
			public string userName;

			// Token: 0x04000AC8 RID: 2760
			[Token(Token = "0x4000AC8")]
			[FieldOffset(Offset = "0x48")]
			public string account;
		}
	}
}
