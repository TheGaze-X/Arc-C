using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200659B RID: 26011
	[Token(Token = "0x200659B")]
	public class ArtMagazineDiyDecorSelectNumPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025666 RID: 153190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025666")]
		[Address(RVA = "0x2060FB0", Offset = "0x205FBB0", VA = "0x182060FB0")]
		public void Render(ItemType itemType, IArtMagazineDiyRecycleGroupViewModel groupModel)
		{
		}

		// Token: 0x06025667 RID: 153191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025667")]
		[Address(RVA = "0x2060ED0", Offset = "0x205FAD0", VA = "0x182060ED0")]
		public void OnUnselectTypeClick()
		{
		}

		// Token: 0x06025668 RID: 153192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025668")]
		[Address(RVA = "0x2061210", Offset = "0x205FE10", VA = "0x182061210")]
		public ArtMagazineDiyDecorSelectNumPanel()
		{
		}

		// Token: 0x0403479D RID: 214941
		[Token(Token = "0x403479D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _decorTypeSmallIcon;

		// Token: 0x0403479E RID: 214942
		[Token(Token = "0x403479E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _currDecorSelectNum;

		// Token: 0x0403479F RID: 214943
		[Token(Token = "0x403479F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _maxDecorSelectNum;

		// Token: 0x040347A0 RID: 214944
		[Token(Token = "0x40347A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _selectNumToggle;

		// Token: 0x040347A1 RID: 214945
		[Token(Token = "0x40347A1")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040347A2 RID: 214946
		[Token(Token = "0x40347A2")]
		[FieldOffset(Offset = "0x48")]
		private ItemType m_cacheItemType;

		// Token: 0x040347A3 RID: 214947
		[Token(Token = "0x40347A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040347A4 RID: 214948
		[Token(Token = "0x40347A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUnselectTypeClick;

		// Token: 0x040347A5 RID: 214949
		[Token(Token = "0x40347A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
