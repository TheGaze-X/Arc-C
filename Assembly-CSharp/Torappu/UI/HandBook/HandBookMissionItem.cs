using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200666F RID: 26223
	[Token(Token = "0x200666F")]
	public class HandBookMissionItem : MonoBehaviour
	{
		// Token: 0x06025A6E RID: 154222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A6E")]
		[Address(RVA = "0x209B070", Offset = "0x2099C70", VA = "0x18209B070")]
		public void InitData(HandBookCardViewModel handbookViewModel)
		{
		}

		// Token: 0x06025A6F RID: 154223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A6F")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookMissionItem()
		{
		}

		// Token: 0x04034E47 RID: 216647
		[Token(Token = "0x4034E47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookCardView _cardView;

		// Token: 0x04034E48 RID: 216648
		[Token(Token = "0x4034E48")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x04034E49 RID: 216649
		[Token(Token = "0x4034E49")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _bar;

		// Token: 0x04034E4A RID: 216650
		[Token(Token = "0x4034E4A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _cardScale;

		// Token: 0x04034E4B RID: 216651
		[Token(Token = "0x4034E4B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _barMax;

		// Token: 0x04034E4C RID: 216652
		[Token(Token = "0x4034E4C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _barMin;

		// Token: 0x04034E4D RID: 216653
		[Token(Token = "0x4034E4D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _barPart;

		// Token: 0x04034E4E RID: 216654
		[Token(Token = "0x4034E4E")]
		[FieldOffset(Offset = "0x48")]
		private HandBookCardView m_cardView;
	}
}
