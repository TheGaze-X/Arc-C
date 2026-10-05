using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Stencil;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036A5 RID: 13989
	[Token(Token = "0x20036A5")]
	public class CutinTemplate : MonoBehaviour, IHotfixable
	{
		// Token: 0x060163D1 RID: 91089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163D1")]
		[Address(RVA = "0xEB2AF0", Offset = "0xEB16F0", VA = "0x180EB2AF0")]
		public void ShowCutinMask(StencilChannel channel, CutinParam cutinParam, Action cb, Transform decoContainer)
		{
		}

		// Token: 0x060163D2 RID: 91090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163D2")]
		[Address(RVA = "0xEB3440", Offset = "0xEB2040", VA = "0x180EB3440")]
		public void UpdateCutinMask(CutinParam cutinParam)
		{
		}

		// Token: 0x060163D3 RID: 91091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163D3")]
		[Address(RVA = "0xEB27A0", Offset = "0xEB13A0", VA = "0x180EB27A0")]
		public void HideCutinMask(CutinParam cutinParam, Action cb)
		{
		}

		// Token: 0x060163D4 RID: 91092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163D4")]
		[Address(RVA = "0xEB3720", Offset = "0xEB2320", VA = "0x180EB3720")]
		private void _HideOncomplete(Action cb)
		{
		}

		// Token: 0x060163D5 RID: 91093 RVA: 0x000900F0 File Offset: 0x0008E2F0
		[Token(Token = "0x60163D5")]
		[Address(RVA = "0xEB3820", Offset = "0xEB2420", VA = "0x180EB3820")]
		private bool _ShowEmptyImage(string charName)
		{
			return default(bool);
		}

		// Token: 0x060163D6 RID: 91094 RVA: 0x00090108 File Offset: 0x0008E308
		[Token(Token = "0x60163D6")]
		[Address(RVA = "0xEB3650", Offset = "0xEB2250", VA = "0x180EB3650")]
		private bool _CacheName(string charName)
		{
			return default(bool);
		}

		// Token: 0x060163D7 RID: 91095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163D7")]
		[Address(RVA = "0xEB38D0", Offset = "0xEB24D0", VA = "0x180EB38D0")]
		public CutinTemplate()
		{
		}

		// Token: 0x0401ABCD RID: 109517
		[Token(Token = "0x401ABCD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public UIStencilGraphic _imgMask;

		// Token: 0x0401ABCE RID: 109518
		[Token(Token = "0x401ABCE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public UIStencilComponent[] _components;

		// Token: 0x0401ABCF RID: 109519
		[Token(Token = "0x401ABCF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _scaleX;

		// Token: 0x0401ABD0 RID: 109520
		[Token(Token = "0x401ABD0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _scaleY;

		// Token: 0x0401ABD1 RID: 109521
		[Token(Token = "0x401ABD1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _duration;

		// Token: 0x0401ABD2 RID: 109522
		[Token(Token = "0x401ABD2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0401ABD3 RID: 109523
		[Token(Token = "0x401ABD3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<UIAnimationLocation> _animLocs;

		// Token: 0x0401ABD4 RID: 109524
		[Token(Token = "0x401ABD4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _decoPrefab;

		// Token: 0x0401ABD5 RID: 109525
		[Token(Token = "0x401ABD5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _emptyImg;

		// Token: 0x0401ABD6 RID: 109526
		[Token(Token = "0x401ABD6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _scaleTrans;

		// Token: 0x0401ABD7 RID: 109527
		[Token(Token = "0x401ABD7")]
		private const float DEFAULT_FADE_DURATION = 3f;

		// Token: 0x0401ABD8 RID: 109528
		[Token(Token = "0x401ABD8")]
		private const float DEAFULT_ALPHA_ONE = 1f;

		// Token: 0x0401ABD9 RID: 109529
		[Token(Token = "0x401ABD9")]
		private const float DEAFULT_ALPHA_ZERO = 0f;

		// Token: 0x0401ABDA RID: 109530
		[Token(Token = "0x401ABDA")]
		private const string NAME_CHAR_EMPTY = "char_empty";

		// Token: 0x0401ABDB RID: 109531
		[Token(Token = "0x401ABDB")]
		[FieldOffset(Offset = "0x60")]
		private Sequence m_cutinSeq;

		// Token: 0x0401ABDC RID: 109532
		[Token(Token = "0x401ABDC")]
		[FieldOffset(Offset = "0x68")]
		private CutinTemplateDecoView m_cachedDeco;

		// Token: 0x0401ABDD RID: 109533
		[Token(Token = "0x401ABDD")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedName;

		// Token: 0x0401ABDE RID: 109534
		[Token(Token = "0x401ABDE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCutinMask;

		// Token: 0x0401ABDF RID: 109535
		[Token(Token = "0x401ABDF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateCutinMask;

		// Token: 0x0401ABE0 RID: 109536
		[Token(Token = "0x401ABE0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCutinMask;

		// Token: 0x0401ABE1 RID: 109537
		[Token(Token = "0x401ABE1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideOncomplete;

		// Token: 0x0401ABE2 RID: 109538
		[Token(Token = "0x401ABE2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowEmptyImage;

		// Token: 0x0401ABE3 RID: 109539
		[Token(Token = "0x401ABE3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CacheName;

		// Token: 0x0401ABE4 RID: 109540
		[Token(Token = "0x401ABE4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
