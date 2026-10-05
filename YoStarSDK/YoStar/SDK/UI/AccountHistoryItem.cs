using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public class AccountHistoryItem : MonoBehaviour
	{
		// Token: 0x0600092C RID: 2348 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x5C55910", Offset = "0x5C54510", VA = "0x185C55910")]
		private void Awake()
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000A4")]
		public string Data
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x5C56030", Offset = "0x5C54C30", VA = "0x185C56030")]
			set
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000A5")]
		public Action<string> OnSelectedItem
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000A6")]
		public Action<string> OnDeleteItem
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			set
			{
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x5C55FF0", Offset = "0x5C54BF0", VA = "0x185C55FF0")]
		private void DeleteItem()
		{
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x5C55BC0", Offset = "0x5C547C0", VA = "0x185C55BC0")]
		private void DealData()
		{
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AccountHistoryItem()
		{
		}

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x18")]
		private Image headerImage;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x20")]
		private Button closeButton;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x28")]
		private Text nickNameText;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x30")]
		private Text loginTimeText;

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x38")]
		private string data;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x40")]
		private Action<string> onSelectedItem;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x48")]
		private Action<string> onDeleteItem;
	}
}
