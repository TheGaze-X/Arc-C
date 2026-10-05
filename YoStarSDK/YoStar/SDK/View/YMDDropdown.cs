using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace YoStar.SDK.View
{
	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000100")]
	public class YMDDropdown : MonoBehaviour
	{
		// Token: 0x060006E2 RID: 1762 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x5C3AC50", Offset = "0x5C39850", VA = "0x185C3AC50")]
		private void Awake()
		{
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Start()
		{
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00003314 File Offset: 0x00001514
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x5C3B2B0", Offset = "0x5C39EB0", VA = "0x185C3B2B0")]
		private float GetDropdownCellHeight()
		{
			return 0f;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x5C3B880", Offset = "0x5C3A480", VA = "0x185C3B880")]
		private void Update()
		{
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x5C3B620", Offset = "0x5C3A220", VA = "0x185C3B620")]
		private void OpenDropdown()
		{
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x5C3AFC0", Offset = "0x5C39BC0", VA = "0x185C3AFC0")]
		private void CloseDropdown()
		{
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0000332C File Offset: 0x0000152C
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x5C3B3B0", Offset = "0x5C39FB0", VA = "0x185C3B3B0")]
		private bool IsDropdownOpen()
		{
			return default(bool);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x5C3AFF0", Offset = "0x5C39BF0", VA = "0x185C3AFF0")]
		private Transform FindDropdownListTransform(Transform parent)
		{
			return null;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x5C3B540", Offset = "0x5C3A140", VA = "0x185C3B540")]
		private void OnDropdownValueChanged(int value)
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x5C3B830", Offset = "0x5C3A430", VA = "0x185C3B830")]
		private void UpdatePlaceholderEnabled(bool enabled)
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xD231C0", Offset = "0xD21DC0", VA = "0x180D231C0")]
		public void SetPlaceholderText(string value)
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x5C3AA00", Offset = "0x5C39600", VA = "0x185C3AA00")]
		public void AddOptionsToDropdown(List<string> options, string currentDate)
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x5C3B7C0", Offset = "0x5C3A3C0", VA = "0x185C3B7C0")]
		private IEnumerator<WaitForEndOfFrame> ScrollToItem()
		{
			return null;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
		public void SetOnValueChangeCallback(UnityAction<string> callback)
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
		public string GetSelectedOption()
		{
			return null;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x5C3B450", Offset = "0x5C3A050", VA = "0x185C3B450")]
		private void OnDestroy()
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public YMDDropdown()
		{
		}

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x18")]
		private Text Placeholder;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x20")]
		private Text Label;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x28")]
		private Image Arrow;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x30")]
		private Dropdown dropdown;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x38")]
		private Sprite ArrowClickedSprite;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x40")]
		private Sprite ArrowDefaultSprite;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x48")]
		public UnityAction<string> OnValueChangeCallback;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x50")]
		private bool isDropdownOpen;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x58")]
		private string selectedValue;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x60")]
		private float cellHeight;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x64")]
		private float targetPosY;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x68")]
		private int currentIndex;
	}
}
