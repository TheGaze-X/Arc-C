using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C89 RID: 15497
	[Token(Token = "0x2003C89")]
	public class TuningCommonCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601833E RID: 99134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601833E")]
		[Address(RVA = "0x10B33F0", Offset = "0x10B1FF0", VA = "0x1810B33F0")]
		public void RenderCard(TuningCommonCardModel cardModel)
		{
		}

		// Token: 0x0601833F RID: 99135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601833F")]
		[Address(RVA = "0x10B37A0", Offset = "0x10B23A0", VA = "0x1810B37A0")]
		public void SetScaler(float scaler)
		{
		}

		// Token: 0x06018340 RID: 99136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018340")]
		[Address(RVA = "0x10B3870", Offset = "0x10B2470", VA = "0x1810B3870")]
		public TuningCommonCard()
		{
		}

		// Token: 0x0401D78D RID: 120717
		[Token(Token = "0x401D78D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _cardImg;

		// Token: 0x0401D78E RID: 120718
		[Token(Token = "0x401D78E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _orcheImg;

		// Token: 0x0401D78F RID: 120719
		[Token(Token = "0x401D78F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Image> _fragmentImgList;

		// Token: 0x0401D790 RID: 120720
		[Token(Token = "0x401D790")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _fragmentGroupObj;

		// Token: 0x0401D791 RID: 120721
		[Token(Token = "0x401D791")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D792 RID: 120722
		[Token(Token = "0x401D792")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0401D793 RID: 120723
		[Token(Token = "0x401D793")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetScaler;

		// Token: 0x0401D794 RID: 120724
		[Token(Token = "0x401D794")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
