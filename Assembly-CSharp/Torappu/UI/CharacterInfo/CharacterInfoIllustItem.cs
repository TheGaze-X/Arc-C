using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F55 RID: 24405
	[Token(Token = "0x2005F55")]
	public class CharacterInfoIllustItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602355F RID: 144735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602355F")]
		[Address(RVA = "0x1DD8EC0", Offset = "0x1DD7AC0", VA = "0x181DD8EC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023560 RID: 144736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023560")]
		[Address(RVA = "0x1DD8BA0", Offset = "0x1DD77A0", VA = "0x181DD8BA0")]
		public void Render(CharacterInfoHolderBean.CharViewModel viewModel, bool isMiddle)
		{
		}

		// Token: 0x06023561 RID: 144737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023561")]
		[Address(RVA = "0x1DD8DC0", Offset = "0x1DD79C0", VA = "0x181DD8DC0")]
		public void SetPos(float pos)
		{
		}

		// Token: 0x06023562 RID: 144738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023562")]
		[Address(RVA = "0x1DD8F90", Offset = "0x1DD7B90", VA = "0x181DD8F90")]
		public CharacterInfoIllustItem()
		{
		}

		// Token: 0x04030C31 RID: 199729
		[Token(Token = "0x4030C31")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04030C32 RID: 199730
		[Token(Token = "0x4030C32")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterInfoIllustWrapper _illustWrapper;

		// Token: 0x04030C33 RID: 199731
		[Token(Token = "0x4030C33")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _alphaGroup;

		// Token: 0x04030C34 RID: 199732
		[Token(Token = "0x4030C34")]
		private const float LENGTH_ILLUST = 1400f;

		// Token: 0x04030C35 RID: 199733
		[Token(Token = "0x4030C35")]
		[FieldOffset(Offset = "0x30")]
		private CharacterInfoIllustWrapper m_illustWrapper;

		// Token: 0x04030C36 RID: 199734
		[Token(Token = "0x4030C36")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04030C37 RID: 199735
		[Token(Token = "0x4030C37")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04030C38 RID: 199736
		[Token(Token = "0x4030C38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030C39 RID: 199737
		[Token(Token = "0x4030C39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030C3A RID: 199738
		[Token(Token = "0x4030C3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetPos;

		// Token: 0x04030C3B RID: 199739
		[Token(Token = "0x4030C3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
