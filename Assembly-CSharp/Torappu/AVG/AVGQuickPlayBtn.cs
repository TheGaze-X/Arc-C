using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001EA8 RID: 7848
	[Token(Token = "0x2001EA8")]
	public class AVGQuickPlayBtn : MonoBehaviour
	{
		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x0600C261 RID: 49761 RVA: 0x00047580 File Offset: 0x00045780
		// (set) Token: 0x0600C262 RID: 49762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001740")]
		public bool isSelected
		{
			[Token(Token = "0x600C261")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C262")]
			[Address(RVA = "0x33F9270", Offset = "0x33F7E70", VA = "0x1833F9270")]
			set
			{
			}
		}

		// Token: 0x0600C263 RID: 49763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C263")]
		[Address(RVA = "0x33F91D0", Offset = "0x33F7DD0", VA = "0x1833F91D0")]
		public void OnClick()
		{
		}

		// Token: 0x0600C264 RID: 49764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C264")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AVGQuickPlayBtn()
		{
		}

		// Token: 0x0400C42F RID: 50223
		[Token(Token = "0x400C42F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selected;

		// Token: 0x0400C430 RID: 50224
		[Token(Token = "0x400C430")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AVGQuickPlay _quickPlayPanel;

		// Token: 0x0400C431 RID: 50225
		[Token(Token = "0x400C431")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isSelected;
	}
}
