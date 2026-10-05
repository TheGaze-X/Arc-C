using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F20 RID: 24352
	[Token(Token = "0x2005F20")]
	public class CharacterLvlupWheelViewModel : IHotfixable
	{
		// Token: 0x1700536A RID: 21354
		// (get) Token: 0x06023463 RID: 144483 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023464 RID: 144484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700536A")]
		public string widgetID
		{
			[Token(Token = "0x6023463")]
			[Address(RVA = "0x1DCCFD0", Offset = "0x1DCBBD0", VA = "0x181DCCFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023464")]
			[Address(RVA = "0x1DCD0A0", Offset = "0x1DCBCA0", VA = "0x181DCD0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700536B RID: 21355
		// (get) Token: 0x06023465 RID: 144485 RVA: 0x000C06D8 File Offset: 0x000BE8D8
		// (set) Token: 0x06023466 RID: 144486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700536B")]
		public long dragContextID
		{
			[Token(Token = "0x6023465")]
			[Address(RVA = "0x1DCCEB0", Offset = "0x1DCBAB0", VA = "0x181DCCEB0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6023466")]
			[Address(RVA = "0x1DCD030", Offset = "0x1DCBC30", VA = "0x181DCD030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700536C RID: 21356
		// (get) Token: 0x06023467 RID: 144487 RVA: 0x000C06F0 File Offset: 0x000BE8F0
		[Token(Token = "0x1700536C")]
		public int pagerSelectedPage
		{
			[Token(Token = "0x6023467")]
			[Address(RVA = "0x1DCCF70", Offset = "0x1DCBB70", VA = "0x181DCCF70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700536D RID: 21357
		// (get) Token: 0x06023468 RID: 144488 RVA: 0x000C0708 File Offset: 0x000BE908
		[Token(Token = "0x1700536D")]
		public int pagerMaxAttainablePage
		{
			[Token(Token = "0x6023468")]
			[Address(RVA = "0x1DCCF10", Offset = "0x1DCBB10", VA = "0x181DCCF10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06023469 RID: 144489 RVA: 0x000C0720 File Offset: 0x000BE920
		[Token(Token = "0x6023469")]
		[Address(RVA = "0x1DCC780", Offset = "0x1DCB380", VA = "0x181DCC780")]
		public int ConvertItemIndexToPageNum(int index)
		{
			return 0;
		}

		// Token: 0x0602346A RID: 144490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602346A")]
		[Address(RVA = "0x1DCC8E0", Offset = "0x1DCB4E0", VA = "0x181DCC8E0")]
		public void LoadData(int startNum, int maxNum, int lastAttainableNum)
		{
		}

		// Token: 0x0602346B RID: 144491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602346B")]
		[Address(RVA = "0x1DCCD00", Offset = "0x1DCB900", VA = "0x181DCCD00")]
		public void UpdateSelectedItem(int num)
		{
		}

		// Token: 0x0602346C RID: 144492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602346C")]
		[Address(RVA = "0x1DCC820", Offset = "0x1DCB420", VA = "0x181DCC820")]
		public void ForceUpdateDragContext()
		{
		}

		// Token: 0x0602346D RID: 144493 RVA: 0x000C0738 File Offset: 0x000BE938
		[Token(Token = "0x602346D")]
		[Address(RVA = "0x1DCCBD0", Offset = "0x1DCB7D0", VA = "0x181DCCBD0")]
		public bool TryGetLevelNumFromPage(int page, out int level)
		{
			return default(bool);
		}

		// Token: 0x0602346E RID: 144494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602346E")]
		[Address(RVA = "0x1DCCDF0", Offset = "0x1DCB9F0", VA = "0x181DCCDF0")]
		public CharacterLvlupWheelViewModel()
		{
		}

		// Token: 0x04030A08 RID: 199176
		[Token(Token = "0x4030A08")]
		[FieldOffset(Offset = "0x20")]
		public List<CharacterLvlupWheelItemViewModel> items;

		// Token: 0x04030A09 RID: 199177
		[Token(Token = "0x4030A09")]
		[FieldOffset(Offset = "0x28")]
		public int selectedItemIndex;

		// Token: 0x04030A0A RID: 199178
		[Token(Token = "0x4030A0A")]
		[FieldOffset(Offset = "0x2C")]
		private int m_startNum;

		// Token: 0x04030A0B RID: 199179
		[Token(Token = "0x4030A0B")]
		[FieldOffset(Offset = "0x30")]
		private int m_maxAttainableIndex;

		// Token: 0x04030A0C RID: 199180
		[Token(Token = "0x4030A0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_widgetID;

		// Token: 0x04030A0D RID: 199181
		[Token(Token = "0x4030A0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_widgetID;

		// Token: 0x04030A0E RID: 199182
		[Token(Token = "0x4030A0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dragContextID;

		// Token: 0x04030A0F RID: 199183
		[Token(Token = "0x4030A0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_dragContextID;

		// Token: 0x04030A10 RID: 199184
		[Token(Token = "0x4030A10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_pagerSelectedPage;

		// Token: 0x04030A11 RID: 199185
		[Token(Token = "0x4030A11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_pagerMaxAttainablePage;

		// Token: 0x04030A12 RID: 199186
		[Token(Token = "0x4030A12")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ConvertItemIndexToPageNum;

		// Token: 0x04030A13 RID: 199187
		[Token(Token = "0x4030A13")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030A14 RID: 199188
		[Token(Token = "0x4030A14")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateSelectedItem;

		// Token: 0x04030A15 RID: 199189
		[Token(Token = "0x4030A15")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ForceUpdateDragContext;

		// Token: 0x04030A16 RID: 199190
		[Token(Token = "0x4030A16")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryGetLevelNumFromPage;

		// Token: 0x04030A17 RID: 199191
		[Token(Token = "0x4030A17")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
