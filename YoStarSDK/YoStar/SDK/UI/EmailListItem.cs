using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	public class EmailListItem : MonoBehaviour
	{
		// Token: 0x06000951 RID: 2385 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x5C61380", Offset = "0x5C5FF80", VA = "0x185C61380")]
		private void Awake()
		{
		}

		// Token: 0x170000A9 RID: 169
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000A9")]
		public Dictionary<string, object> Data
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x5C615E0", Offset = "0x5C601E0", VA = "0x185C615E0")]
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000AA")]
		public Action<Dictionary<string, object>> OnSelectedItem
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x5C614A0", Offset = "0x5C600A0", VA = "0x185C614A0")]
		private void DealData()
		{
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public EmailListItem()
		{
		}

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x18")]
		private Text contentText;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, object> data;

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x28")]
		private Action<Dictionary<string, object>> onSelectedItem;
	}
}
