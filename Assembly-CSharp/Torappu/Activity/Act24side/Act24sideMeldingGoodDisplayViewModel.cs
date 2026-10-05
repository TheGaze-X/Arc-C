using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075C1 RID: 30145
	[Token(Token = "0x20075C1")]
	public class Act24sideMeldingGoodDisplayViewModel : IHotfixable
	{
		// Token: 0x170063D8 RID: 25560
		// (get) Token: 0x0602A72A RID: 173866 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A72B RID: 173867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063D8")]
		public string themeColor
		{
			[Token(Token = "0x602A72A")]
			[Address(RVA = "0x2609DE0", Offset = "0x26089E0", VA = "0x182609DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A72B")]
			[Address(RVA = "0x2609EB0", Offset = "0x2608AB0", VA = "0x182609EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170063D9 RID: 25561
		// (get) Token: 0x0602A72C RID: 173868 RVA: 0x000D88E8 File Offset: 0x000D6AE8
		// (set) Token: 0x0602A72D RID: 173869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063D9")]
		public Act24SideData.MeldingGoodDisplayType goodDisplayType
		{
			[Token(Token = "0x602A72C")]
			[Address(RVA = "0x2609D80", Offset = "0x2608980", VA = "0x182609D80")]
			[CompilerGenerated]
			get
			{
				return Act24SideData.MeldingGoodDisplayType.NONE;
			}
			[Token(Token = "0x602A72D")]
			[Address(RVA = "0x2609E40", Offset = "0x2608A40", VA = "0x182609E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602A72E RID: 173870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A72E")]
		[Address(RVA = "0x2609A50", Offset = "0x2608650", VA = "0x182609A50")]
		public static Act24sideMeldingGoodDisplayViewModel CreateDisplayViewModel(string theme, Act24SideData.MeldingGoodDisplayType displayType, string actId)
		{
			return null;
		}

		// Token: 0x0602A72F RID: 173871 RVA: 0x000D8900 File Offset: 0x000D6B00
		[Token(Token = "0x602A72F")]
		[Address(RVA = "0x2609C40", Offset = "0x2608840", VA = "0x182609C40")]
		public bool IsGachaDisplayTypeGoodAllTakeOut()
		{
			return default(bool);
		}

		// Token: 0x0602A730 RID: 173872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A730")]
		[Address(RVA = "0x2609D20", Offset = "0x2608920", VA = "0x182609D20")]
		public Act24sideMeldingGoodDisplayViewModel()
		{
		}

		// Token: 0x0403D140 RID: 250176
		[Token(Token = "0x403D140")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403D143 RID: 250179
		[Token(Token = "0x403D143")]
		[FieldOffset(Offset = "0x28")]
		public List<Act24sideMeldingGoodItemViewModel> goodItemViewModelList;

		// Token: 0x0403D144 RID: 250180
		[Token(Token = "0x403D144")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_themeColor;

		// Token: 0x0403D145 RID: 250181
		[Token(Token = "0x403D145")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_themeColor;

		// Token: 0x0403D146 RID: 250182
		[Token(Token = "0x403D146")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_goodDisplayType;

		// Token: 0x0403D147 RID: 250183
		[Token(Token = "0x403D147")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_goodDisplayType;

		// Token: 0x0403D148 RID: 250184
		[Token(Token = "0x403D148")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateDisplayViewModel;

		// Token: 0x0403D149 RID: 250185
		[Token(Token = "0x403D149")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsGachaDisplayTypeGoodAllTakeOut;

		// Token: 0x0403D14A RID: 250186
		[Token(Token = "0x403D14A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
