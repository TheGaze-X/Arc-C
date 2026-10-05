using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B75 RID: 23413
	[Token(Token = "0x2005B75")]
	public class SocialGetHeadIconView : MonoBehaviour
	{
		// Token: 0x06021FD2 RID: 139218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FD2")]
		[Address(RVA = "0x1C81F40", Offset = "0x1C80B40", VA = "0x181C81F40")]
		public void ApplyData(string charId, int usedTimes = 0)
		{
		}

		// Token: 0x06021FD3 RID: 139219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FD3")]
		[Address(RVA = "0x1C82310", Offset = "0x1C80F10", VA = "0x181C82310")]
		public void ApplyEmpty()
		{
		}

		// Token: 0x06021FD4 RID: 139220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FD4")]
		[Address(RVA = "0x1C82180", Offset = "0x1C80D80", VA = "0x181C82180")]
		public void ApplyData(PlayerCharacter charData)
		{
		}

		// Token: 0x06021FD5 RID: 139221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FD5")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public SocialGetHeadIconView()
		{
		}

		// Token: 0x0402E965 RID: 190821
		[Token(Token = "0x402E965")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _headIcon;

		// Token: 0x0402E966 RID: 190822
		[Token(Token = "0x402E966")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _eliteSprite;

		// Token: 0x0402E967 RID: 190823
		[Token(Token = "0x402E967")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _level;

		// Token: 0x0402E968 RID: 190824
		[Token(Token = "0x402E968")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _ablePart;

		// Token: 0x0402E969 RID: 190825
		[Token(Token = "0x402E969")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _notAblePart;

		// Token: 0x0402E96A RID: 190826
		[Token(Token = "0x402E96A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _usedTimesText;
	}
}
