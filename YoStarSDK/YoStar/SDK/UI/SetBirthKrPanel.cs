using System;
using Il2CppDummyDll;
using UnityEngine.UI;
using YoStar.SDK.View;

namespace YoStar.SDK.UI
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	public class SetBirthKrPanel : BasePanel
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x5C7B310", Offset = "0x5C79F10", VA = "0x185C7B310", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x5C7A6F0", Offset = "0x5C792F0", VA = "0x185C7A6F0")]
		private new void Awake()
		{
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x5C7B7F0", Offset = "0x5C7A3F0", VA = "0x185C7B7F0")]
		private void Start()
		{
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x5C7B470", Offset = "0x5C7A070", VA = "0x185C7B470")]
		private void OnYearOrMonthChanged(string value)
		{
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x5C7BE90", Offset = "0x5C7AA90", VA = "0x185C7BE90")]
		private void UpdateDaysDropdown(int year, int month)
		{
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x5C7B220", Offset = "0x5C79E20", VA = "0x185C7B220")]
		private void OnClick(Button button)
		{
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x5C7AE10", Offset = "0x5C79A10", VA = "0x185C7AE10")]
		private void ConfirmAgain()
		{
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x5C7B750", Offset = "0x5C7A350", VA = "0x185C7B750")]
		private void SetBirth()
		{
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public SetBirthKrPanel()
		{
		}

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x50")]
		private Button confirmButton;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x58")]
		private Button closeButton;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x60")]
		private YMDDropdown yearDropdown;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x68")]
		private YMDDropdown monthDropdown;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x70")]
		private YMDDropdown dayDropdown;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x78")]
		private DateTime currentDate;

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x80")]
		private int selectedYear;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x84")]
		private int selectedMonth;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x88")]
		private int selectedDay;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x90")]
		private Action<int> action;
	}
}
