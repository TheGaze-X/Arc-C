using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072E5 RID: 29413
	[Token(Token = "0x20072E5")]
	public class Act45SideMailViewModel : IHotfixable
	{
		// Token: 0x17006265 RID: 25189
		// (get) Token: 0x060299EF RID: 170479 RVA: 0x000D60C8 File Offset: 0x000D42C8
		[Token(Token = "0x17006265")]
		public bool selectedIsLast
		{
			[Token(Token = "0x60299EF")]
			[Address(RVA = "0x24FB070", Offset = "0x24F9C70", VA = "0x1824FB070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006266 RID: 25190
		// (get) Token: 0x060299F0 RID: 170480 RVA: 0x000D60E0 File Offset: 0x000D42E0
		[Token(Token = "0x17006266")]
		public int selectedIndex
		{
			[Token(Token = "0x60299F0")]
			[Address(RVA = "0x24FB010", Offset = "0x24F9C10", VA = "0x1824FB010")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006267 RID: 25191
		// (get) Token: 0x060299F1 RID: 170481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006267")]
		public Act45SideMailItemViewModel selectedMail
		{
			[Token(Token = "0x60299F1")]
			[Address(RVA = "0x24FB0D0", Offset = "0x24F9CD0", VA = "0x1824FB0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060299F2 RID: 170482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299F2")]
		[Address(RVA = "0x24FAEC0", Offset = "0x24F9AC0", VA = "0x1824FAEC0")]
		public void SelectRight()
		{
		}

		// Token: 0x060299F3 RID: 170483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299F3")]
		[Address(RVA = "0x24FAE30", Offset = "0x24F9A30", VA = "0x1824FAE30")]
		public void SelectLeft()
		{
		}

		// Token: 0x060299F4 RID: 170484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299F4")]
		[Address(RVA = "0x24FA780", Offset = "0x24F9380", VA = "0x1824FA780")]
		public void LoadData(string actId, Act45SideMailDialog.EntryType inputEntryType)
		{
		}

		// Token: 0x060299F5 RID: 170485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299F5")]
		[Address(RVA = "0x24FAF60", Offset = "0x24F9B60", VA = "0x1824FAF60")]
		public Act45SideMailViewModel()
		{
		}

		// Token: 0x0403B88B RID: 243851
		[Token(Token = "0x403B88B")]
		[FieldOffset(Offset = "0x10")]
		public Act45SideMailDialog.EntryType entryType;

		// Token: 0x0403B88C RID: 243852
		[Token(Token = "0x403B88C")]
		[FieldOffset(Offset = "0x14")]
		public Act45SideMailViewModel.AnimType animType;

		// Token: 0x0403B88D RID: 243853
		[Token(Token = "0x403B88D")]
		[FieldOffset(Offset = "0x18")]
		public List<Act45SideMailItemViewModel> mailItems;

		// Token: 0x0403B88E RID: 243854
		[Token(Token = "0x403B88E")]
		[FieldOffset(Offset = "0x20")]
		private int m_selectedIndex;

		// Token: 0x0403B88F RID: 243855
		[Token(Token = "0x403B88F")]
		[FieldOffset(Offset = "0x24")]
		private int m_totalCnt;

		// Token: 0x0403B890 RID: 243856
		[Token(Token = "0x403B890")]
		[FieldOffset(Offset = "0x28")]
		private string m_timeStrFormat;

		// Token: 0x0403B891 RID: 243857
		[Token(Token = "0x403B891")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedIsLast;

		// Token: 0x0403B892 RID: 243858
		[Token(Token = "0x403B892")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedIndex;

		// Token: 0x0403B893 RID: 243859
		[Token(Token = "0x403B893")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedMail;

		// Token: 0x0403B894 RID: 243860
		[Token(Token = "0x403B894")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectRight;

		// Token: 0x0403B895 RID: 243861
		[Token(Token = "0x403B895")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SelectLeft;

		// Token: 0x0403B896 RID: 243862
		[Token(Token = "0x403B896")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403B897 RID: 243863
		[Token(Token = "0x403B897")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072E6 RID: 29414
		[Token(Token = "0x20072E6")]
		public enum AnimType
		{
			// Token: 0x0403B899 RID: 243865
			[Token(Token = "0x403B899")]
			ENTER,
			// Token: 0x0403B89A RID: 243866
			[Token(Token = "0x403B89A")]
			LEFT,
			// Token: 0x0403B89B RID: 243867
			[Token(Token = "0x403B89B")]
			RIGHT
		}
	}
}
