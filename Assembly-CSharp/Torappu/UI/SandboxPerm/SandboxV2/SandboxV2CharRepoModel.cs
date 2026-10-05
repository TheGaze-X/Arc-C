using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004423 RID: 17443
	[Token(Token = "0x2004423")]
	public class SandboxV2CharRepoModel : IHotfixable
	{
		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x0601AA36 RID: 109110 RVA: 0x000A2A50 File Offset: 0x000A0C50
		// (set) Token: 0x0601AA37 RID: 109111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F1D")]
		public bool isProfessionFilterShow
		{
			[Token(Token = "0x601AA36")]
			[Address(RVA = "0x13C11F0", Offset = "0x13BFDF0", VA = "0x1813C11F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601AA37")]
			[Address(RVA = "0x13C12B0", Offset = "0x13BFEB0", VA = "0x1813C12B0")]
			set
			{
			}
		}

		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x0601AA38 RID: 109112 RVA: 0x000A2A68 File Offset: 0x000A0C68
		// (set) Token: 0x0601AA39 RID: 109113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F1E")]
		public bool isStatusFilterShow
		{
			[Token(Token = "0x601AA38")]
			[Address(RVA = "0x13C1250", Offset = "0x13BFE50", VA = "0x1813C1250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601AA39")]
			[Address(RVA = "0x13C1320", Offset = "0x13BFF20", VA = "0x1813C1320")]
			set
			{
			}
		}

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x0601AA3A RID: 109114 RVA: 0x000A2A80 File Offset: 0x000A0C80
		[Token(Token = "0x17003F1F")]
		public ProfessionCategory filteredProfession
		{
			[Token(Token = "0x601AA3A")]
			[Address(RVA = "0x13C1130", Offset = "0x13BFD30", VA = "0x1813C1130")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x0601AA3B RID: 109115 RVA: 0x000A2A98 File Offset: 0x000A0C98
		[Token(Token = "0x17003F20")]
		public SandboxV2CharFilter filteredStatus
		{
			[Token(Token = "0x601AA3B")]
			[Address(RVA = "0x13C1190", Offset = "0x13BFD90", VA = "0x1813C1190")]
			get
			{
				return SandboxV2CharFilter.NONE;
			}
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x0601AA3C RID: 109116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F21")]
		public List<SandboxV2CharViewModel> displayList
		{
			[Token(Token = "0x601AA3C")]
			[Address(RVA = "0x13C10D0", Offset = "0x13BFCD0", VA = "0x1813C10D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AA3D RID: 109117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA3D")]
		[Address(RVA = "0x13C0760", Offset = "0x13BF360", VA = "0x1813C0760")]
		public void Init(string topicId)
		{
		}

		// Token: 0x0601AA3E RID: 109118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA3E")]
		[Address(RVA = "0x13C0C20", Offset = "0x13BF820", VA = "0x1813C0C20")]
		public void UpdateCharListPlayerData()
		{
		}

		// Token: 0x0601AA3F RID: 109119 RVA: 0x000A2AB0 File Offset: 0x000A0CB0
		[Token(Token = "0x601AA3F")]
		[Address(RVA = "0x13C0B10", Offset = "0x13BF710", VA = "0x1813C0B10")]
		public bool TryGetCharModelByInstId(int charInstId, out SandboxV2CharViewModel result)
		{
			return default(bool);
		}

		// Token: 0x0601AA40 RID: 109120 RVA: 0x000A2AC8 File Offset: 0x000A0CC8
		[Token(Token = "0x601AA40")]
		[Address(RVA = "0x13C09F0", Offset = "0x13BF5F0", VA = "0x1813C09F0")]
		public bool TryFilterProfession(ProfessionCategory profession)
		{
			return default(bool);
		}

		// Token: 0x0601AA41 RID: 109121 RVA: 0x000A2AE0 File Offset: 0x000A0CE0
		[Token(Token = "0x601AA41")]
		[Address(RVA = "0x13C0A80", Offset = "0x13BF680", VA = "0x1813C0A80")]
		public bool TryFilterStatus(SandboxV2CharFilter charStatus)
		{
			return default(bool);
		}

		// Token: 0x0601AA42 RID: 109122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA42")]
		[Address(RVA = "0x13C0D00", Offset = "0x13BF900", VA = "0x1813C0D00")]
		private void _CalcFilterSortList()
		{
		}

		// Token: 0x0601AA43 RID: 109123 RVA: 0x000A2AF8 File Offset: 0x000A0CF8
		[Token(Token = "0x601AA43")]
		[Address(RVA = "0x13C0F40", Offset = "0x13BFB40", VA = "0x1813C0F40")]
		private int _SortByCustomRule(SandboxV2CharViewModel x, SandboxV2CharViewModel y)
		{
			return 0;
		}

		// Token: 0x0601AA44 RID: 109124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA44")]
		[Address(RVA = "0x13C0FE0", Offset = "0x13BFBE0", VA = "0x1813C0FE0")]
		public SandboxV2CharRepoModel()
		{
		}

		// Token: 0x04021FAB RID: 139179
		[Token(Token = "0x4021FAB")]
		[FieldOffset(Offset = "0x10")]
		private List<SandboxV2CharViewModel> m_charList;

		// Token: 0x04021FAC RID: 139180
		[Token(Token = "0x4021FAC")]
		[FieldOffset(Offset = "0x18")]
		private List<SandboxV2CharViewModel> m_filterSortList;

		// Token: 0x04021FAD RID: 139181
		[Token(Token = "0x4021FAD")]
		[FieldOffset(Offset = "0x20")]
		private ProfessionCategory m_filteredProfession;

		// Token: 0x04021FAE RID: 139182
		[Token(Token = "0x4021FAE")]
		[FieldOffset(Offset = "0x24")]
		private bool m_isProfessionFilterShow;

		// Token: 0x04021FAF RID: 139183
		[Token(Token = "0x4021FAF")]
		[FieldOffset(Offset = "0x28")]
		private SandboxV2CharFilter m_filteredStatus;

		// Token: 0x04021FB0 RID: 139184
		[Token(Token = "0x4021FB0")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isStatusFilterShow;

		// Token: 0x04021FB1 RID: 139185
		[Token(Token = "0x4021FB1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isProfessionFilterShow;

		// Token: 0x04021FB2 RID: 139186
		[Token(Token = "0x4021FB2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isProfessionFilterShow;

		// Token: 0x04021FB3 RID: 139187
		[Token(Token = "0x4021FB3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isStatusFilterShow;

		// Token: 0x04021FB4 RID: 139188
		[Token(Token = "0x4021FB4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isStatusFilterShow;

		// Token: 0x04021FB5 RID: 139189
		[Token(Token = "0x4021FB5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_filteredProfession;

		// Token: 0x04021FB6 RID: 139190
		[Token(Token = "0x4021FB6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_filteredStatus;

		// Token: 0x04021FB7 RID: 139191
		[Token(Token = "0x4021FB7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_displayList;

		// Token: 0x04021FB8 RID: 139192
		[Token(Token = "0x4021FB8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04021FB9 RID: 139193
		[Token(Token = "0x4021FB9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateCharListPlayerData;

		// Token: 0x04021FBA RID: 139194
		[Token(Token = "0x4021FBA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryGetCharModelByInstId;

		// Token: 0x04021FBB RID: 139195
		[Token(Token = "0x4021FBB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryFilterProfession;

		// Token: 0x04021FBC RID: 139196
		[Token(Token = "0x4021FBC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryFilterStatus;

		// Token: 0x04021FBD RID: 139197
		[Token(Token = "0x4021FBD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CalcFilterSortList;

		// Token: 0x04021FBE RID: 139198
		[Token(Token = "0x4021FBE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SortByCustomRule;

		// Token: 0x04021FBF RID: 139199
		[Token(Token = "0x4021FBF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
