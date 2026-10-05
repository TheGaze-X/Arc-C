using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200433D RID: 17213
	[Token(Token = "0x200433D")]
	public class SandboxV2LogisticsComplexBuffItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A70B RID: 108299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A70B")]
		[Address(RVA = "0x13872D0", Offset = "0x1385ED0", VA = "0x1813872D0")]
		public void Render(SandboxV2LogisticsBuffViewModel buffViewModel, SandboxV2LogisticsCharViewModel charViewModel)
		{
		}

		// Token: 0x0601A70C RID: 108300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A70C")]
		[Address(RVA = "0x1387740", Offset = "0x1386340", VA = "0x181387740")]
		public SandboxV2LogisticsComplexBuffItemView()
		{
		}

		// Token: 0x0402199B RID: 137627
		[Token(Token = "0x402199B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0402199C RID: 137628
		[Token(Token = "0x402199C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtBuffDesc;

		// Token: 0x0402199D RID: 137629
		[Token(Token = "0x402199D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2LogisticsCharBeanView _charBeanView;

		// Token: 0x0402199E RID: 137630
		[Token(Token = "0x402199E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtBuffCount;

		// Token: 0x0402199F RID: 137631
		[Token(Token = "0x402199F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorCountDefault;

		// Token: 0x040219A0 RID: 137632
		[Token(Token = "0x40219A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorCountNormal;

		// Token: 0x040219A1 RID: 137633
		[Token(Token = "0x40219A1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorCountOverflow;

		// Token: 0x040219A2 RID: 137634
		[Token(Token = "0x40219A2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelOverflow;

		// Token: 0x040219A3 RID: 137635
		[Token(Token = "0x40219A3")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040219A4 RID: 137636
		[Token(Token = "0x40219A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040219A5 RID: 137637
		[Token(Token = "0x40219A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
