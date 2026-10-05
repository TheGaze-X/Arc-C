using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	public class BindAccountItem : MonoBehaviour
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x5C561F0", Offset = "0x5C54DF0", VA = "0x185C561F0")]
		private void Awake()
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x5C56BA0", Offset = "0x5C557A0", VA = "0x185C56BA0")]
		private void OnClick(Button bindButton)
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x5C56520", Offset = "0x5C55120", VA = "0x185C56520")]
		private void DealData()
		{
		}

		// Token: 0x170000A7 RID: 167
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000A7")]
		public Dictionary<string, object> DataInfo
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x5C56C50", Offset = "0x5C55850", VA = "0x185C56C50")]
			set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000A8")]
		public Action<Dictionary<string, object>> AccountAction
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x5C56BC0", Offset = "0x5C557C0", VA = "0x185C56BC0")]
		public BindAccountItem()
		{
		}

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x18")]
		private Text descriptionInfoText;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x20")]
		private Image headerImage;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x28")]
		private Button bindButton;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x30")]
		private Text platformNameText;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x38")]
		private Text nickNameText;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x40")]
		private Action<Dictionary<string, object>> accountAction;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, object> dataInfo;
	}
}
