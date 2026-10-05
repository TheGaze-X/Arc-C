using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200425B RID: 16987
	[Token(Token = "0x200425B")]
	public class SandboxV2NodeDropItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x0601A2E5 RID: 107237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E30")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x601A2E5")]
			[Address(RVA = "0x131D740", Offset = "0x131C340", VA = "0x18131D740")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A2E6 RID: 107238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2E6")]
		[Address(RVA = "0x131D440", Offset = "0x131C040", VA = "0x18131D440")]
		public void Render(string topicId, string itemId, SandboxV2DropDetail dropDetail, SandboxV2DungeonViewConfig dungeonViewConfig)
		{
		}

		// Token: 0x0601A2E7 RID: 107239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2E7")]
		[Address(RVA = "0x131D6D0", Offset = "0x131C2D0", VA = "0x18131D6D0")]
		public SandboxV2NodeDropItemView()
		{
		}

		// Token: 0x0402119C RID: 135580
		[Token(Token = "0x402119C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgBkg;

		// Token: 0x0402119D RID: 135581
		[Token(Token = "0x402119D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageItem;

		// Token: 0x0402119E RID: 135582
		[Token(Token = "0x402119E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlEmpty;

		// Token: 0x0402119F RID: 135583
		[Token(Token = "0x402119F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x040211A0 RID: 135584
		[Token(Token = "0x40211A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _alphaEmpty;

		// Token: 0x040211A1 RID: 135585
		[Token(Token = "0x40211A1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _alphaNormal;

		// Token: 0x040211A2 RID: 135586
		[Token(Token = "0x40211A2")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedItemId;

		// Token: 0x040211A3 RID: 135587
		[Token(Token = "0x40211A3")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040211A4 RID: 135588
		[Token(Token = "0x40211A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x040211A5 RID: 135589
		[Token(Token = "0x40211A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040211A6 RID: 135590
		[Token(Token = "0x40211A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
