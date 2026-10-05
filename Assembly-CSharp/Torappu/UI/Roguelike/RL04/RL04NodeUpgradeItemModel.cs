using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056F9 RID: 22265
	[Token(Token = "0x20056F9")]
	public abstract class RL04NodeUpgradeItemModel : IHotfixable
	{
		// Token: 0x17004C92 RID: 19602
		// (get) Token: 0x06020A88 RID: 133768 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020A89 RID: 133769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C92")]
		public string upgradeId
		{
			[Token(Token = "0x6020A88")]
			[Address(RVA = "0x1ACA040", Offset = "0x1AC8C40", VA = "0x181ACA040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020A89")]
			[Address(RVA = "0x1ACA2F0", Offset = "0x1AC8EF0", VA = "0x181ACA2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17004C93 RID: 19603
		// (get) Token: 0x06020A8A RID: 133770 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020A8B RID: 133771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C93")]
		public string desc
		{
			[Token(Token = "0x6020A8A")]
			[Address(RVA = "0x1AC9F20", Offset = "0x1AC8B20", VA = "0x181AC9F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020A8B")]
			[Address(RVA = "0x1ACA190", Offset = "0x1AC8D90", VA = "0x181ACA190")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17004C94 RID: 19604
		// (get) Token: 0x06020A8C RID: 133772 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020A8D RID: 133773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C94")]
		public string costItemId
		{
			[Token(Token = "0x6020A8C")]
			[Address(RVA = "0x1AC9EC0", Offset = "0x1AC8AC0", VA = "0x181AC9EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020A8D")]
			[Address(RVA = "0x1ACA110", Offset = "0x1AC8D10", VA = "0x181ACA110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17004C95 RID: 19605
		// (get) Token: 0x06020A8E RID: 133774 RVA: 0x000B6B80 File Offset: 0x000B4D80
		// (set) Token: 0x06020A8F RID: 133775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C95")]
		public int costItemCount
		{
			[Token(Token = "0x6020A8E")]
			[Address(RVA = "0x1AC9E60", Offset = "0x1AC8A60", VA = "0x181AC9E60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020A8F")]
			[Address(RVA = "0x1ACA0A0", Offset = "0x1AC8CA0", VA = "0x181ACA0A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17004C96 RID: 19606
		// (get) Token: 0x06020A90 RID: 133776 RVA: 0x000B6B98 File Offset: 0x000B4D98
		// (set) Token: 0x06020A91 RID: 133777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C96")]
		public bool isUnlock
		{
			[Token(Token = "0x6020A90")]
			[Address(RVA = "0x1AC9F80", Offset = "0x1AC8B80", VA = "0x181AC9F80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6020A91")]
			[Address(RVA = "0x1ACA210", Offset = "0x1AC8E10", VA = "0x181ACA210")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17004C97 RID: 19607
		// (get) Token: 0x06020A92 RID: 133778 RVA: 0x000B6BB0 File Offset: 0x000B4DB0
		// (set) Token: 0x06020A93 RID: 133779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C97")]
		public int showSeqNum
		{
			[Token(Token = "0x6020A92")]
			[Address(RVA = "0x1AC9FE0", Offset = "0x1AC8BE0", VA = "0x181AC9FE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020A93")]
			[Address(RVA = "0x1ACA280", Offset = "0x1AC8E80", VA = "0x181ACA280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C98 RID: 19608
		// (get) Token: 0x06020A94 RID: 133780
		[Token(Token = "0x17004C98")]
		public abstract bool isTemp { [Token(Token = "0x6020A94")] get; }

		// Token: 0x06020A95 RID: 133781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A95")]
		[Address(RVA = "0x1AC9BA0", Offset = "0x1AC87A0", VA = "0x181AC9BA0")]
		public void UpdateShowSeqNum()
		{
		}

		// Token: 0x06020A96 RID: 133782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A96")]
		[Address(RVA = "0x1AC9C60", Offset = "0x1AC8860", VA = "0x181AC9C60")]
		public void UpdateUnlockStatus(List<string> upgradeList)
		{
		}

		// Token: 0x06020A97 RID: 133783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A97")]
		[Address(RVA = "0x1AC9E00", Offset = "0x1AC8A00", VA = "0x181AC9E00")]
		protected RL04NodeUpgradeItemModel()
		{
		}

		// Token: 0x0402C4FA RID: 181498
		[Token(Token = "0x402C4FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_upgradeId;

		// Token: 0x0402C4FB RID: 181499
		[Token(Token = "0x402C4FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_upgradeId;

		// Token: 0x0402C4FC RID: 181500
		[Token(Token = "0x402C4FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0402C4FD RID: 181501
		[Token(Token = "0x402C4FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x0402C4FE RID: 181502
		[Token(Token = "0x402C4FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_costItemId;

		// Token: 0x0402C4FF RID: 181503
		[Token(Token = "0x402C4FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_costItemId;

		// Token: 0x0402C500 RID: 181504
		[Token(Token = "0x402C500")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_costItemCount;

		// Token: 0x0402C501 RID: 181505
		[Token(Token = "0x402C501")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_costItemCount;

		// Token: 0x0402C502 RID: 181506
		[Token(Token = "0x402C502")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x0402C503 RID: 181507
		[Token(Token = "0x402C503")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isUnlock;

		// Token: 0x0402C504 RID: 181508
		[Token(Token = "0x402C504")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_showSeqNum;

		// Token: 0x0402C505 RID: 181509
		[Token(Token = "0x402C505")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_showSeqNum;

		// Token: 0x0402C506 RID: 181510
		[Token(Token = "0x402C506")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateShowSeqNum;

		// Token: 0x0402C507 RID: 181511
		[Token(Token = "0x402C507")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateUnlockStatus;

		// Token: 0x0402C508 RID: 181512
		[Token(Token = "0x402C508")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
