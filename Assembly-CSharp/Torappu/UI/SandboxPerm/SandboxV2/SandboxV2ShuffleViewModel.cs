using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200405A RID: 16474
	[Token(Token = "0x200405A")]
	public class SandboxV2ShuffleViewModel
	{
		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x060197BC RID: 104380 RVA: 0x0009E460 File Offset: 0x0009C660
		// (set) Token: 0x060197BD RID: 104381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CAE")]
		public bool isProfessionFilterShow
		{
			[Token(Token = "0x60197BC")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60197BD")]
			[Address(RVA = "0x4EAC50", Offset = "0x4E9850", VA = "0x1804EAC50")]
			set
			{
			}
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x060197BE RID: 104382 RVA: 0x0009E478 File Offset: 0x0009C678
		// (set) Token: 0x060197BF RID: 104383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CAF")]
		public bool isStatusFilterShow
		{
			[Token(Token = "0x60197BE")]
			[Address(RVA = "0x12411F0", Offset = "0x123FDF0", VA = "0x1812411F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60197BF")]
			[Address(RVA = "0x1241210", Offset = "0x123FE10", VA = "0x181241210")]
			set
			{
			}
		}

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x060197C0 RID: 104384 RVA: 0x0009E490 File Offset: 0x0009C690
		// (set) Token: 0x060197C1 RID: 104385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CB0")]
		public ProfessionCategory filteredProfession
		{
			[Token(Token = "0x60197C0")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return ProfessionCategory.NONE;
			}
			[Token(Token = "0x60197C1")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x060197C2 RID: 104386 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
		// (set) Token: 0x060197C3 RID: 104387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CB1")]
		public SandboxV2CharFilter filteredStatus
		{
			[Token(Token = "0x60197C2")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return SandboxV2CharFilter.NONE;
			}
			[Token(Token = "0x60197C3")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x060197C4 RID: 104388 RVA: 0x0009E4C0 File Offset: 0x0009C6C0
		// (set) Token: 0x060197C5 RID: 104389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CB2")]
		public bool needFilterStatus
		{
			[Token(Token = "0x60197C4")]
			[Address(RVA = "0x1241200", Offset = "0x123FE00", VA = "0x181241200")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60197C5")]
			[Address(RVA = "0x1241220", Offset = "0x123FE20", VA = "0x181241220")]
			set
			{
			}
		}

		// Token: 0x060197C6 RID: 104390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197C6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ShuffleViewModel()
		{
		}

		// Token: 0x0401FC34 RID: 130100
		[Token(Token = "0x401FC34")]
		[FieldOffset(Offset = "0x10")]
		private ProfessionCategory m_filteredProfession;

		// Token: 0x0401FC35 RID: 130101
		[Token(Token = "0x401FC35")]
		[FieldOffset(Offset = "0x14")]
		private bool m_isProfessionFilterShow;

		// Token: 0x0401FC36 RID: 130102
		[Token(Token = "0x401FC36")]
		[FieldOffset(Offset = "0x18")]
		private SandboxV2CharFilter m_filteredStatus;

		// Token: 0x0401FC37 RID: 130103
		[Token(Token = "0x401FC37")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_isStatusFilterShow;

		// Token: 0x0401FC38 RID: 130104
		[Token(Token = "0x401FC38")]
		[FieldOffset(Offset = "0x1D")]
		private bool m_needFilterStatus;
	}
}
