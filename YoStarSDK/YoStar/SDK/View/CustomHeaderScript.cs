using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.View
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	public class CustomHeaderScript : MonoBehaviour
	{
		// Token: 0x060006B7 RID: 1719 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x5C26660", Offset = "0x5C25260", VA = "0x185C26660")]
		private void Awake()
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x5C26A80", Offset = "0x5C25680", VA = "0x185C26A80")]
		private void OnClickAction(Button button)
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000078")]
		public string TitleContent
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x5C26C70", Offset = "0x5C25870", VA = "0x185C26C70")]
			set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x000032B4 File Offset: 0x000014B4
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000079")]
		public bool ActiveBack
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x5C26BF0", Offset = "0x5C257F0", VA = "0x185C26BF0")]
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x000032CC File Offset: 0x000014CC
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700007A")]
		public bool ActiveClose
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x5C26C30", Offset = "0x5C25830", VA = "0x185C26C30")]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x000032E4 File Offset: 0x000014E4
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700007B")]
		public float TitleWidth
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x4E48960", Offset = "0x4E47560", VA = "0x184E48960")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1DE3EA0", Offset = "0x1DE2AA0", VA = "0x181DE3EA0")]
			set
			{
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x5C26BE0", Offset = "0x5C257E0", VA = "0x185C26BE0")]
		public CustomHeaderScript()
		{
		}

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x18")]
		private Button backButton;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x20")]
		private Button closeButton;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x28")]
		private Image line;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x30")]
		private Text titleText;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x38")]
		private string titleContent;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x40")]
		private bool activeBack;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x41")]
		private bool activeClose;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x44")]
		private float titleWidth;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x48")]
		public Action OnBackClick;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x50")]
		public Action OnCloseClick;
	}
}
