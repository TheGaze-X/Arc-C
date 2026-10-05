using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005979 RID: 22905
	[Token(Token = "0x2005979")]
	public abstract class CrisisV2RuneBaseViewModel : IHotfixable
	{
		// Token: 0x06021661 RID: 136801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021661")]
		[Address(RVA = "0x1BCB730", Offset = "0x1BCA330", VA = "0x181BCB730", Slot = "4")]
		public virtual string GetGlobalId()
		{
			return null;
		}

		// Token: 0x06021662 RID: 136802 RVA: 0x000BA138 File Offset: 0x000B8338
		[Token(Token = "0x6021662")]
		[Address(RVA = "0x1BCB6D0", Offset = "0x1BCA2D0", VA = "0x181BCB6D0", Slot = "5")]
		public virtual CrisisV2RuneBaseViewModel.ViewType GetDetailViewType()
		{
			return CrisisV2RuneBaseViewModel.ViewType.NONE;
		}

		// Token: 0x17004E96 RID: 20118
		// (get) Token: 0x06021663 RID: 136803 RVA: 0x000BA150 File Offset: 0x000B8350
		// (set) Token: 0x06021664 RID: 136804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E96")]
		public virtual CrisisV2RuneBaseViewModel.SingleViewInfoBgType itemBgType
		{
			[Token(Token = "0x6021663")]
			[Address(RVA = "0x1BCB800", Offset = "0x1BCA400", VA = "0x181BCB800", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return CrisisV2RuneBaseViewModel.SingleViewInfoBgType.NONE;
			}
			[Token(Token = "0x6021664")]
			[Address(RVA = "0x1BCB860", Offset = "0x1BCA460", VA = "0x181BCB860", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06021665 RID: 136805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021665")]
		[Address(RVA = "0x1BCB7A0", Offset = "0x1BCA3A0", VA = "0x181BCB7A0")]
		protected CrisisV2RuneBaseViewModel()
		{
		}

		// Token: 0x0402D8DE RID: 186590
		[Token(Token = "0x402D8DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetGlobalId;

		// Token: 0x0402D8DF RID: 186591
		[Token(Token = "0x402D8DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDetailViewType;

		// Token: 0x0402D8E0 RID: 186592
		[Token(Token = "0x402D8E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemBgType;

		// Token: 0x0402D8E1 RID: 186593
		[Token(Token = "0x402D8E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_itemBgType;

		// Token: 0x0402D8E2 RID: 186594
		[Token(Token = "0x402D8E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200597A RID: 22906
		[Token(Token = "0x200597A")]
		public enum ViewType
		{
			// Token: 0x0402D8E4 RID: 186596
			[Token(Token = "0x402D8E4")]
			NONE,
			// Token: 0x0402D8E5 RID: 186597
			[Token(Token = "0x402D8E5")]
			SINGLE,
			// Token: 0x0402D8E6 RID: 186598
			[Token(Token = "0x402D8E6")]
			GROUP
		}

		// Token: 0x0200597B RID: 22907
		[Token(Token = "0x200597B")]
		public enum SingleViewInfoBgType
		{
			// Token: 0x0402D8E8 RID: 186600
			[Token(Token = "0x402D8E8")]
			NONE,
			// Token: 0x0402D8E9 RID: 186601
			[Token(Token = "0x402D8E9")]
			DARK,
			// Token: 0x0402D8EA RID: 186602
			[Token(Token = "0x402D8EA")]
			GRAY
		}
	}
}
