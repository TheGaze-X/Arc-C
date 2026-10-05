using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007927 RID: 31015
	[Token(Token = "0x2007927")]
	public class Act1ArcadeBadgeBookDetailViewModel : IHotfixable
	{
		// Token: 0x170065EF RID: 26095
		// (get) Token: 0x0602B832 RID: 178226 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B833 RID: 178227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065EF")]
		public string actId
		{
			[Token(Token = "0x602B832")]
			[Address(RVA = "0x2767AD0", Offset = "0x27666D0", VA = "0x182767AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B833")]
			[Address(RVA = "0x2767CB0", Offset = "0x27668B0", VA = "0x182767CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170065F0 RID: 26096
		// (get) Token: 0x0602B834 RID: 178228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065F0")]
		public List<Act1ArcadeBadgeBookItemViewModel> mappedItems
		{
			[Token(Token = "0x602B834")]
			[Address(RVA = "0x2767B90", Offset = "0x2766790", VA = "0x182767B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170065F1 RID: 26097
		// (get) Token: 0x0602B835 RID: 178229 RVA: 0x000DC518 File Offset: 0x000DA718
		// (set) Token: 0x0602B836 RID: 178230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065F1")]
		public int presentingIndex
		{
			[Token(Token = "0x602B835")]
			[Address(RVA = "0x2767BF0", Offset = "0x27667F0", VA = "0x182767BF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602B836")]
			[Address(RVA = "0x2767DA0", Offset = "0x27669A0", VA = "0x182767DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170065F2 RID: 26098
		// (get) Token: 0x0602B837 RID: 178231 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B838 RID: 178232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065F2")]
		public Act1ArcadeBadgeBookItemViewModel presentingItem
		{
			[Token(Token = "0x602B837")]
			[Address(RVA = "0x2767C50", Offset = "0x2766850", VA = "0x182767C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B838")]
			[Address(RVA = "0x2767E10", Offset = "0x2766A10", VA = "0x182767E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170065F3 RID: 26099
		// (get) Token: 0x0602B839 RID: 178233 RVA: 0x000DC530 File Offset: 0x000DA730
		// (set) Token: 0x0602B83A RID: 178234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170065F3")]
		public bool initShow
		{
			[Token(Token = "0x602B839")]
			[Address(RVA = "0x2767B30", Offset = "0x2766730", VA = "0x182767B30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B83A")]
			[Address(RVA = "0x2767D30", Offset = "0x2766930", VA = "0x182767D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602B83B RID: 178235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B83B")]
		[Address(RVA = "0x2767190", Offset = "0x2765D90", VA = "0x182767190")]
		public void LoadData(string actId, Act1ArcadeBadgeBookItemViewModel ultimateItem, Dictionary<string, Act1ArcadeBadgeBookGroupViewModel> badgeGroups, string presentingBadgeId)
		{
		}

		// Token: 0x0602B83C RID: 178236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B83C")]
		[Address(RVA = "0x2767490", Offset = "0x2766090", VA = "0x182767490")]
		public void SwitchItem(bool forward)
		{
		}

		// Token: 0x0602B83D RID: 178237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B83D")]
		[Address(RVA = "0x2767670", Offset = "0x2766270", VA = "0x182767670")]
		private void _MapItems(string presentingBadgeId)
		{
		}

		// Token: 0x0602B83E RID: 178238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B83E")]
		[Address(RVA = "0x27679D0", Offset = "0x27665D0", VA = "0x1827679D0")]
		public Act1ArcadeBadgeBookDetailViewModel()
		{
		}

		// Token: 0x0403EEA6 RID: 257702
		[Token(Token = "0x403EEA6")]
		[FieldOffset(Offset = "0x10")]
		private Act1ArcadeBadgeBookItemViewModel m_ultimateItem;

		// Token: 0x0403EEA7 RID: 257703
		[Token(Token = "0x403EEA7")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<Act1ArcadeBadgeBookGroupViewModel> m_badgeGroupList;

		// Token: 0x0403EEA8 RID: 257704
		[Token(Token = "0x403EEA8")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<Act1ArcadeBadgeBookItemViewModel> m_mappedItems;

		// Token: 0x0403EEAD RID: 257709
		[Token(Token = "0x403EEAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403EEAE RID: 257710
		[Token(Token = "0x403EEAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0403EEAF RID: 257711
		[Token(Token = "0x403EEAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_mappedItems;

		// Token: 0x0403EEB0 RID: 257712
		[Token(Token = "0x403EEB0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_presentingIndex;

		// Token: 0x0403EEB1 RID: 257713
		[Token(Token = "0x403EEB1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_presentingIndex;

		// Token: 0x0403EEB2 RID: 257714
		[Token(Token = "0x403EEB2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_presentingItem;

		// Token: 0x0403EEB3 RID: 257715
		[Token(Token = "0x403EEB3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_presentingItem;

		// Token: 0x0403EEB4 RID: 257716
		[Token(Token = "0x403EEB4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_initShow;

		// Token: 0x0403EEB5 RID: 257717
		[Token(Token = "0x403EEB5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_initShow;

		// Token: 0x0403EEB6 RID: 257718
		[Token(Token = "0x403EEB6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403EEB7 RID: 257719
		[Token(Token = "0x403EEB7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SwitchItem;

		// Token: 0x0403EEB8 RID: 257720
		[Token(Token = "0x403EEB8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__MapItems;

		// Token: 0x0403EEB9 RID: 257721
		[Token(Token = "0x403EEB9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
