using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E86 RID: 24198
	[Token(Token = "0x2005E86")]
	public class ItemRepoVoucherSkillStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x17005316 RID: 21270
		// (get) Token: 0x06023111 RID: 143633 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023112 RID: 143634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005316")]
		public string curCharId
		{
			[Token(Token = "0x6023111")]
			[Address(RVA = "0x1DA4CB0", Offset = "0x1DA38B0", VA = "0x181DA4CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023112")]
			[Address(RVA = "0x1DA4DD0", Offset = "0x1DA39D0", VA = "0x181DA4DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005317 RID: 21271
		// (get) Token: 0x06023113 RID: 143635 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023114 RID: 143636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005317")]
		public string curSkillId
		{
			[Token(Token = "0x6023113")]
			[Address(RVA = "0x1DA4D10", Offset = "0x1DA3910", VA = "0x181DA4D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023114")]
			[Address(RVA = "0x1DA4E50", Offset = "0x1DA3A50", VA = "0x181DA4E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005318 RID: 21272
		// (get) Token: 0x06023115 RID: 143637 RVA: 0x000BFDD8 File Offset: 0x000BDFD8
		// (set) Token: 0x06023116 RID: 143638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005318")]
		public int curSkillLevel
		{
			[Token(Token = "0x6023115")]
			[Address(RVA = "0x1DA4D70", Offset = "0x1DA3970", VA = "0x181DA4D70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6023116")]
			[Address(RVA = "0x1DA4ED0", Offset = "0x1DA3AD0", VA = "0x181DA4ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06023117 RID: 143639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023117")]
		[Address(RVA = "0x1DA4940", Offset = "0x1DA3540", VA = "0x181DA4940")]
		public void UpdateSelectedSkill(int selectedIdx)
		{
		}

		// Token: 0x06023118 RID: 143640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023118")]
		[Address(RVA = "0x1DA4550", Offset = "0x1DA3150", VA = "0x181DA4550")]
		public void LoadData()
		{
		}

		// Token: 0x06023119 RID: 143641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023119")]
		[Address(RVA = "0x1DA4BC0", Offset = "0x1DA37C0", VA = "0x181DA4BC0")]
		public ItemRepoVoucherSkillStateBean()
		{
		}

		// Token: 0x040304AD RID: 197805
		[Token(Token = "0x40304AD")]
		[FieldOffset(Offset = "0x18")]
		public ItemRepoVoucherSkillViewProperty viewProperty;

		// Token: 0x040304AE RID: 197806
		[Token(Token = "0x40304AE")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int charInstId;

		// Token: 0x040304AF RID: 197807
		[Token(Token = "0x40304AF")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public UIItemViewModel voucherItemModel;

		// Token: 0x040304B3 RID: 197811
		[Token(Token = "0x40304B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curCharId;

		// Token: 0x040304B4 RID: 197812
		[Token(Token = "0x40304B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_curCharId;

		// Token: 0x040304B5 RID: 197813
		[Token(Token = "0x40304B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_curSkillId;

		// Token: 0x040304B6 RID: 197814
		[Token(Token = "0x40304B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_curSkillId;

		// Token: 0x040304B7 RID: 197815
		[Token(Token = "0x40304B7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_curSkillLevel;

		// Token: 0x040304B8 RID: 197816
		[Token(Token = "0x40304B8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_curSkillLevel;

		// Token: 0x040304B9 RID: 197817
		[Token(Token = "0x40304B9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateSelectedSkill;

		// Token: 0x040304BA RID: 197818
		[Token(Token = "0x40304BA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040304BB RID: 197819
		[Token(Token = "0x40304BB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
