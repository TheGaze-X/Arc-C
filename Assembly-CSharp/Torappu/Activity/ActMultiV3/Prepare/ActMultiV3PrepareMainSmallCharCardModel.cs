using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007046 RID: 28742
	[Token(Token = "0x2007046")]
	public class ActMultiV3PrepareMainSmallCharCardModel : IHotfixable
	{
		// Token: 0x17006073 RID: 24691
		// (get) Token: 0x06028CDE RID: 167134 RVA: 0x000D3140 File Offset: 0x000D1340
		// (set) Token: 0x06028CDF RID: 167135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006073")]
		public int innerInstId
		{
			[Token(Token = "0x6028CDE")]
			[Address(RVA = "0x243E340", Offset = "0x243CF40", VA = "0x18243E340")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028CDF")]
			[Address(RVA = "0x243E620", Offset = "0x243D220", VA = "0x18243E620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006074 RID: 24692
		// (get) Token: 0x06028CE0 RID: 167136 RVA: 0x000D3158 File Offset: 0x000D1358
		// (set) Token: 0x06028CE1 RID: 167137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006074")]
		public ActMultiV3IdentityType identityType
		{
			[Token(Token = "0x6028CE0")]
			[Address(RVA = "0x243E2E0", Offset = "0x243CEE0", VA = "0x18243E2E0")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3IdentityType.NONE;
			}
			[Token(Token = "0x6028CE1")]
			[Address(RVA = "0x243E5B0", Offset = "0x243D1B0", VA = "0x18243E5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006075 RID: 24693
		// (get) Token: 0x06028CE2 RID: 167138 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028CE3 RID: 167139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006075")]
		public ActMultiV3CharCardBase.Param baseParam
		{
			[Token(Token = "0x6028CE2")]
			[Address(RVA = "0x243E220", Offset = "0x243CE20", VA = "0x18243E220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028CE3")]
			[Address(RVA = "0x243E4B0", Offset = "0x243D0B0", VA = "0x18243E4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006076 RID: 24694
		// (get) Token: 0x06028CE4 RID: 167140 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028CE5 RID: 167141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006076")]
		public ActMultiV3CharViewModel baseViewModel
		{
			[Token(Token = "0x6028CE4")]
			[Address(RVA = "0x243E280", Offset = "0x243CE80", VA = "0x18243E280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028CE5")]
			[Address(RVA = "0x243E530", Offset = "0x243D130", VA = "0x18243E530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006077 RID: 24695
		// (get) Token: 0x06028CE6 RID: 167142 RVA: 0x000D3170 File Offset: 0x000D1370
		[Token(Token = "0x17006077")]
		public bool isEmpty
		{
			[Token(Token = "0x6028CE6")]
			[Address(RVA = "0x243E3A0", Offset = "0x243CFA0", VA = "0x18243E3A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06028CE7 RID: 167143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CE7")]
		[Address(RVA = "0x243DF20", Offset = "0x243CB20", VA = "0x18243DF20")]
		public void Load(int instId, ActMultiV3CharViewModel cardViewModel, ActMultiV3IdentityType iType)
		{
		}

		// Token: 0x06028CE8 RID: 167144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CE8")]
		[Address(RVA = "0x243E1C0", Offset = "0x243CDC0", VA = "0x18243E1C0")]
		public ActMultiV3PrepareMainSmallCharCardModel()
		{
		}

		// Token: 0x0403A30B RID: 238347
		[Token(Token = "0x403A30B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_innerInstId;

		// Token: 0x0403A30C RID: 238348
		[Token(Token = "0x403A30C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_innerInstId;

		// Token: 0x0403A30D RID: 238349
		[Token(Token = "0x403A30D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_identityType;

		// Token: 0x0403A30E RID: 238350
		[Token(Token = "0x403A30E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_identityType;

		// Token: 0x0403A30F RID: 238351
		[Token(Token = "0x403A30F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_baseParam;

		// Token: 0x0403A310 RID: 238352
		[Token(Token = "0x403A310")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_baseParam;

		// Token: 0x0403A311 RID: 238353
		[Token(Token = "0x403A311")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_baseViewModel;

		// Token: 0x0403A312 RID: 238354
		[Token(Token = "0x403A312")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_baseViewModel;

		// Token: 0x0403A313 RID: 238355
		[Token(Token = "0x403A313")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0403A314 RID: 238356
		[Token(Token = "0x403A314")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0403A315 RID: 238357
		[Token(Token = "0x403A315")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
