using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	public class UserCenterActionItemScript : MonoBehaviour
	{
		// Token: 0x0600096A RID: 2410 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x5C6D010", Offset = "0x5C6BC10", VA = "0x185C6D010")]
		private void Awake()
		{
		}

		// Token: 0x170000AD RID: 173
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000AD")]
		public bool ShowActionText
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x5C6D440", Offset = "0x5C6C040", VA = "0x185C6D440")]
			set
			{
			}
		}

		// Token: 0x170000AE RID: 174
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000AE")]
		public bool ShowSubTitleText
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x5C6D4C0", Offset = "0x5C6C0C0", VA = "0x185C6D4C0")]
			set
			{
			}
		}

		// Token: 0x170000AF RID: 175
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000AF")]
		public bool ShowEmailText
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x5C6D480", Offset = "0x5C6C080", VA = "0x185C6D480")]
			set
			{
			}
		}

		// Token: 0x170000B0 RID: 176
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000B0")]
		public string TitleTextContent
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x5C6D5B0", Offset = "0x5C6C1B0", VA = "0x185C6D5B0")]
			set
			{
			}
		}

		// Token: 0x170000B1 RID: 177
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000B1")]
		public string SubTitleTextContent
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x5C6D500", Offset = "0x5C6C100", VA = "0x185C6D500")]
			set
			{
			}
		}

		// Token: 0x170000B2 RID: 178
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000B2")]
		public string ActionTextContent
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x5C6D2E0", Offset = "0x5C6BEE0", VA = "0x185C6D2E0")]
			set
			{
			}
		}

		// Token: 0x170000B3 RID: 179
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000B3")]
		public string EmailTextContent
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x5C6D390", Offset = "0x5C6BF90", VA = "0x185C6D390")]
			set
			{
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x5C6D190", Offset = "0x5C6BD90", VA = "0x185C6D190")]
		private void Update()
		{
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UserCenterActionItemScript()
		{
		}

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x18")]
		private Text titleText;

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x20")]
		private Text emailText;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x28")]
		private Text subTitleText;

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x30")]
		private Text actionText;
	}
}
