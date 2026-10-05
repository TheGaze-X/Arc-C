using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home
{
	// Token: 0x02004BF7 RID: 19447
	[Token(Token = "0x2004BF7")]
	public class HomeAnnounceTab : MonoBehaviour
	{
		// Token: 0x0601D37F RID: 119679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D37F")]
		[Address(RVA = "0x16BE8A0", Offset = "0x16BD4A0", VA = "0x1816BE8A0")]
		public void InitData(AnnounceSinglePageData data)
		{
		}

		// Token: 0x0601D380 RID: 119680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D380")]
		[Address(RVA = "0x16BEB60", Offset = "0x16BD760", VA = "0x1816BEB60")]
		public void SetOnSelect(int index)
		{
		}

		// Token: 0x0601D381 RID: 119681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D381")]
		[Address(RVA = "0x16BE880", Offset = "0x16BD480", VA = "0x1816BE880")]
		public void AnnounceSelectClick()
		{
		}

		// Token: 0x0601D382 RID: 119682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D382")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HomeAnnounceTab()
		{
		}

		// Token: 0x04026623 RID: 157219
		[Token(Token = "0x4026623")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _twoStateToggle;

		// Token: 0x04026624 RID: 157220
		[Token(Token = "0x4026624")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Action<int> announceClick;

		// Token: 0x04026625 RID: 157221
		[Token(Token = "0x4026625")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public int announceIndex;

		// Token: 0x04026626 RID: 157222
		[Token(Token = "0x4026626")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public AnnounceSinglePageData cacheData;

		// Token: 0x04026627 RID: 157223
		[Token(Token = "0x4026627")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _day;

		// Token: 0x04026628 RID: 157224
		[Token(Token = "0x4026628")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _month;

		// Token: 0x04026629 RID: 157225
		[Token(Token = "0x4026629")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _title;

		// Token: 0x0402662A RID: 157226
		[Token(Token = "0x402662A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _dayB;

		// Token: 0x0402662B RID: 157227
		[Token(Token = "0x402662B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _monthB;

		// Token: 0x0402662C RID: 157228
		[Token(Token = "0x402662C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _titleB;

		// Token: 0x0402662D RID: 157229
		[Token(Token = "0x402662D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _newTag;
	}
}
