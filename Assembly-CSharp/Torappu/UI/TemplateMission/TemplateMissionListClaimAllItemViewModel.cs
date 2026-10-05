using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DAF RID: 15791
	[Token(Token = "0x2003DAF")]
	public class TemplateMissionListClaimAllItemViewModel : ITemplateMissionListItemViewModel, IHotfixable
	{
		// Token: 0x060188DB RID: 100571 RVA: 0x0009ABA8 File Offset: 0x00098DA8
		[Token(Token = "0x60188DB")]
		[Address(RVA = "0x1112960", Offset = "0x1111560", VA = "0x181112960", Slot = "4")]
		public TemplateMissionListItemViewType GetItemViewType()
		{
			return TemplateMissionListItemViewType.NORMAL_ITEM;
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x060188DC RID: 100572 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060188DD RID: 100573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A99")]
		public string claimAllTips
		{
			[Token(Token = "0x60188DC")]
			[Address(RVA = "0x1112C80", Offset = "0x1111880", VA = "0x181112C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60188DD")]
			[Address(RVA = "0x1112DD0", Offset = "0x11119D0", VA = "0x181112DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x060188DE RID: 100574 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060188DF RID: 100575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A9A")]
		public string btnColor
		{
			[Token(Token = "0x60188DE")]
			[Address(RVA = "0x1112BC0", Offset = "0x11117C0", VA = "0x181112BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60188DF")]
			[Address(RVA = "0x1112CE0", Offset = "0x11118E0", VA = "0x181112CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x060188E0 RID: 100576 RVA: 0x0009ABC0 File Offset: 0x00098DC0
		// (set) Token: 0x060188E1 RID: 100577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A9B")]
		public bool checkIfCanClaim
		{
			[Token(Token = "0x60188E0")]
			[Address(RVA = "0x1112C20", Offset = "0x1111820", VA = "0x181112C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60188E1")]
			[Address(RVA = "0x1112D60", Offset = "0x1111960", VA = "0x181112D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060188E2 RID: 100578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188E2")]
		[Address(RVA = "0x1112A40", Offset = "0x1111640", VA = "0x181112A40")]
		public TemplateMissionListClaimAllItemViewModel(string tips, string btnCol, bool canClaim)
		{
		}

		// Token: 0x060188E3 RID: 100579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188E3")]
		[Address(RVA = "0x11129C0", Offset = "0x11115C0", VA = "0x1811129C0")]
		public void RefreshCanClaimState(bool canClaim)
		{
		}

		// Token: 0x0401E1B4 RID: 123316
		[Token(Token = "0x401E1B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetItemViewType;

		// Token: 0x0401E1B5 RID: 123317
		[Token(Token = "0x401E1B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_claimAllTips;

		// Token: 0x0401E1B6 RID: 123318
		[Token(Token = "0x401E1B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_claimAllTips;

		// Token: 0x0401E1B7 RID: 123319
		[Token(Token = "0x401E1B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_btnColor;

		// Token: 0x0401E1B8 RID: 123320
		[Token(Token = "0x401E1B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_btnColor;

		// Token: 0x0401E1B9 RID: 123321
		[Token(Token = "0x401E1B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_checkIfCanClaim;

		// Token: 0x0401E1BA RID: 123322
		[Token(Token = "0x401E1BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_checkIfCanClaim;

		// Token: 0x0401E1BB RID: 123323
		[Token(Token = "0x401E1BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401E1BC RID: 123324
		[Token(Token = "0x401E1BC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshCanClaimState;
	}
}
