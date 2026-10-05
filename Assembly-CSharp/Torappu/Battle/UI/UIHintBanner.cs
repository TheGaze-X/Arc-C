using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x020032EA RID: 13034
	[Token(Token = "0x20032EA")]
	public class UIHintBanner : MonoBehaviour
	{
		// Token: 0x06014B64 RID: 84836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B64")]
		[Address(RVA = "0xD2DA50", Offset = "0xD2C650", VA = "0x180D2DA50")]
		public void OnInit()
		{
		}

		// Token: 0x06014B65 RID: 84837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B65")]
		[Address(RVA = "0xD2DAF0", Offset = "0xD2C6F0", VA = "0x180D2DAF0")]
		public void OnShow(string text, float fadeIn, float fadeOut, float duration, Sprite background)
		{
		}

		// Token: 0x06014B66 RID: 84838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B66")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIHintBanner()
		{
		}

		// Token: 0x040189B8 RID: 100792
		[Token(Token = "0x40189B8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x040189B9 RID: 100793
		[Token(Token = "0x40189B9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _background;

		// Token: 0x040189BA RID: 100794
		[Token(Token = "0x40189BA")]
		[FieldOffset(Offset = "0x28")]
		private Sequence m_textSequence;

		// Token: 0x040189BB RID: 100795
		[Token(Token = "0x40189BB")]
		[FieldOffset(Offset = "0x30")]
		private Sequence m_backgroundSequence;

		// Token: 0x040189BC RID: 100796
		[Token(Token = "0x40189BC")]
		[FieldOffset(Offset = "0x38")]
		private Color m_textColor;

		// Token: 0x040189BD RID: 100797
		[Token(Token = "0x40189BD")]
		[FieldOffset(Offset = "0x48")]
		private Color m_backgroundColor;
	}
}
