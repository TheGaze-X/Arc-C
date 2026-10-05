using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059C5 RID: 22981
	[Token(Token = "0x20059C5")]
	public class CrisisV2NodeTipsView : DataBinder<CrisisV2MapProp>
	{
		// Token: 0x060217EC RID: 137196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217EC")]
		[Address(RVA = "0x1BD9820", Offset = "0x1BD8420", VA = "0x181BD9820", Slot = "7")]
		public override void OnValueChanged(CrisisV2MapProp property)
		{
		}

		// Token: 0x060217ED RID: 137197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217ED")]
		[Address(RVA = "0x1BD9EF0", Offset = "0x1BD8AF0", VA = "0x181BD9EF0")]
		private void _RenderView(CrisisV2TipsInfo tipsInfo)
		{
		}

		// Token: 0x060217EE RID: 137198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217EE")]
		[Address(RVA = "0x1BD9BB0", Offset = "0x1BD87B0", VA = "0x181BD9BB0")]
		private void _CloseTipsAfterDelay()
		{
		}

		// Token: 0x060217EF RID: 137199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217EF")]
		[Address(RVA = "0x1BD9D30", Offset = "0x1BD8930", VA = "0x181BD9D30")]
		private IEnumerator _CloseTipsCoroutine()
		{
			return null;
		}

		// Token: 0x060217F0 RID: 137200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217F0")]
		[Address(RVA = "0x1BD9DE0", Offset = "0x1BD89E0", VA = "0x181BD9DE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060217F1 RID: 137201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217F1")]
		[Address(RVA = "0x1BDA260", Offset = "0x1BD8E60", VA = "0x181BDA260")]
		public CrisisV2NodeTipsView()
		{
		}

		// Token: 0x0402DC2C RID: 187436
		[Token(Token = "0x402DC2C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402DC2D RID: 187437
		[Token(Token = "0x402DC2D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402DC2E RID: 187438
		[Token(Token = "0x402DC2E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textScore;

		// Token: 0x0402DC2F RID: 187439
		[Token(Token = "0x402DC2F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgBg;

		// Token: 0x0402DC30 RID: 187440
		[Token(Token = "0x402DC30")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _unavailDeco;

		// Token: 0x0402DC31 RID: 187441
		[Token(Token = "0x402DC31")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _removeDeco;

		// Token: 0x0402DC32 RID: 187442
		[Token(Token = "0x402DC32")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _unavailTitleBg;

		// Token: 0x0402DC33 RID: 187443
		[Token(Token = "0x402DC33")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _removeTitleBg;

		// Token: 0x0402DC34 RID: 187444
		[Token(Token = "0x402DC34")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorBgUnavail;

		// Token: 0x0402DC35 RID: 187445
		[Token(Token = "0x402DC35")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorTitleUnavail;

		// Token: 0x0402DC36 RID: 187446
		[Token(Token = "0x402DC36")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _colorDescUnavail;

		// Token: 0x0402DC37 RID: 187447
		[Token(Token = "0x402DC37")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _colorBgRemove;

		// Token: 0x0402DC38 RID: 187448
		[Token(Token = "0x402DC38")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _colorTitleRemove;

		// Token: 0x0402DC39 RID: 187449
		[Token(Token = "0x402DC39")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _colorDescRemove;

		// Token: 0x0402DC3A RID: 187450
		[Token(Token = "0x402DC3A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x0402DC3B RID: 187451
		[Token(Token = "0x402DC3B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _closeDelay;

		// Token: 0x0402DC3C RID: 187452
		[Token(Token = "0x402DC3C")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAtlasImage _imgDimension;

		// Token: 0x0402DC3D RID: 187453
		[Token(Token = "0x402DC3D")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIAtlasObject _dimensionAtlas;

		// Token: 0x0402DC3E RID: 187454
		[Token(Token = "0x402DC3E")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_hasInited;

		// Token: 0x0402DC3F RID: 187455
		[Token(Token = "0x402DC3F")]
		[FieldOffset(Offset = "0xF0")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402DC40 RID: 187456
		[Token(Token = "0x402DC40")]
		[FieldOffset(Offset = "0xF8")]
		private int m_cacheTipsSeqNum;

		// Token: 0x0402DC41 RID: 187457
		[Token(Token = "0x402DC41")]
		[FieldOffset(Offset = "0x100")]
		private Coroutine m_delayCloseCoroutine;

		// Token: 0x0402DC42 RID: 187458
		[Token(Token = "0x402DC42")]
		[FieldOffset(Offset = "0x108")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402DC43 RID: 187459
		[Token(Token = "0x402DC43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402DC44 RID: 187460
		[Token(Token = "0x402DC44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0402DC45 RID: 187461
		[Token(Token = "0x402DC45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CloseTipsAfterDelay;

		// Token: 0x0402DC46 RID: 187462
		[Token(Token = "0x402DC46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CloseTipsCoroutine;

		// Token: 0x0402DC47 RID: 187463
		[Token(Token = "0x402DC47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DC48 RID: 187464
		[Token(Token = "0x402DC48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
