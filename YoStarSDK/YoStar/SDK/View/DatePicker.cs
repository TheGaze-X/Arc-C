using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UI.Tables;
using UnityEngine;
using YoStar.SDK.View.Dates;

namespace YoStar.SDK.View
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	[ExecuteInEditMode]
	public class DatePicker : MonoBehaviour
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		private DatePicker_Button_Pool buttonPool
		{
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x5C4D020", Offset = "0x5C4BC20", VA = "0x185C4D020")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x5C48240", Offset = "0x5C46E40", VA = "0x185C48240")]
		private void Awake()
		{
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x5C4B600", Offset = "0x5C4A200", VA = "0x185C4B600")]
		private void Start()
		{
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x5C4BE20", Offset = "0x5C4AA20", VA = "0x185C4BE20")]
		private void Update()
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x5C4AC00", Offset = "0x5C49800", VA = "0x185C4AC00")]
		private void OnEnable()
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x5C4ABC0", Offset = "0x5C497C0", VA = "0x185C4ABC0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x5C4AE50", Offset = "0x5C49A50", VA = "0x185C4AE50")]
		private void SetupUI()
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x5C4C140", Offset = "0x5C4AD40", VA = "0x185C4C140")]
		private void _UpdateMonth()
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x5C4CF20", Offset = "0x5C4BB20", VA = "0x185C4CF20")]
		public void backYearSelector()
		{
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x5C4A9B0", Offset = "0x5C495B0", VA = "0x185C4A9B0")]
		private void InitializeYear()
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x5C474A0", Offset = "0x5C460A0", VA = "0x185C474A0")]
		private void AdjustYearRange(int focusYear)
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x5C4ACE0", Offset = "0x5C498E0", VA = "0x185C4ACE0")]
		private void SetupHoldButtons()
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x5C4B400", Offset = "0x5C4A000", VA = "0x185C4B400")]
		public void ShowPreviousYear()
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x5C4B3A0", Offset = "0x5C49FA0", VA = "0x185C4B3A0")]
		public void ShowNextYear()
		{
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x5C4ACA0", Offset = "0x5C498A0", VA = "0x185C4ACA0")]
		public void UpdateDisplay()
		{
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x5C4C830", Offset = "0x5C4B430", VA = "0x185C4C830")]
		private void _UpdateYear()
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x5C4BC10", Offset = "0x5C4A810", VA = "0x185C4BC10")]
		private void UpdateBorder()
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x5C4BC40", Offset = "0x5C4A840", VA = "0x185C4BC40")]
		private void UpdateHeader()
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x5C4AA20", Offset = "0x5C49620", VA = "0x185C4AA20")]
		public void InvalidateAllDayButtonTemplates()
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x5C4AA60", Offset = "0x5C49660", VA = "0x185C4AA60")]
		public void InvalidateDayButtonTemplate(DatePickerButtonType type)
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x5C4BE40", Offset = "0x5C4AA40", VA = "0x185C4BE40")]
		public void YearButtonClicked(int year)
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x5C4AB10", Offset = "0x5C49710", VA = "0x185C4AB10")]
		public void MouseButtonClicked(DateTime date)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x5C4B840", Offset = "0x5C4A440", VA = "0x185C4B840")]
		public void ToggleDisplay()
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x5C4B460", Offset = "0x5C4A060", VA = "0x185C4B460")]
		public void Show()
		{
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x5C4ACB0", Offset = "0x5C498B0", VA = "0x185C4ACB0")]
		private void PlayAnimation(YoStar.SDK.View.Dates.Animation animation, AnimationType animationType, [Optional] Action onComplete)
		{
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x5C4A380", Offset = "0x5C48F80", VA = "0x185C4A380")]
		public void Hide()
		{
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x5C4BFB0", Offset = "0x5C4ABB0", VA = "0x185C4BFB0")]
		private void _Hide()
		{
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000726")]
		private static T FindParentOfType<T>(GameObject childObject) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000727")]
		protected void SetProperty<T>(ref T currentValue, T newValue)
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x5C4ACA0", Offset = "0x5C498A0", VA = "0x185C4ACA0")]
		private void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x5C4CEF0", Offset = "0x5C4BAF0", VA = "0x185C4CEF0")]
		public DatePicker()
		{
		}

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int startYearLimit;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int endYearLimit;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int startYear;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int endYear;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		private const int yearRangeInterval = 12;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DatePickerConfig Config;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("References")]
		public RectTransform Ref_DatePickerTransform;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DatePicker_Header Ref_Header;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TableLayout Ref_MonthTable;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TableLayout Ref_YearTable;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TableCell Ref_TableContainer;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DatePicker_ContentLayout Ref_ContentLayout;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DatePicker_Button Ref_Template_Year;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DatePicker_Button Ref_Template_Month;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DatePicker_Animator Ref_Animator;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RectTransform Ref_Viewport;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private DatePicker_Button Ref_Header_Month;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DatePicker_Animator Ref_MonthTableAnimator;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DatePicker_Animator Ref_YearTableAnimator;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int selectYear;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<DateTime> months;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int totalRows;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int monthsPerRow;

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private DatePicker_Button_Pool _buttonPool;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_initialized;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		private bool m_updateScheduled;
	}
}
