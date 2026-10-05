using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200739E RID: 29598
	[Token(Token = "0x200739E")]
	public class Act42D0MapStageSelectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170062CE RID: 25294
		// (get) Token: 0x06029D6B RID: 171371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062CE")]
		public GameObject btnGo
		{
			[Token(Token = "0x6029D6B")]
			[Address(RVA = "0x2572630", Offset = "0x2571230", VA = "0x182572630")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029D6C RID: 171372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D6C")]
		[Address(RVA = "0x25724C0", Offset = "0x25710C0", VA = "0x1825724C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D6D RID: 171373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D6D")]
		[Address(RVA = "0x2572010", Offset = "0x2570C10", VA = "0x182572010")]
		public void Render(Act42D0MapStageItemViewModel data, bool isHard, bool isSelected, int index, bool areaChanged)
		{
		}

		// Token: 0x06029D6E RID: 171374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D6E")]
		[Address(RVA = "0x2571F20", Offset = "0x2570B20", VA = "0x182571F20")]
		public void OnClick()
		{
		}

		// Token: 0x06029D6F RID: 171375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D6F")]
		[Address(RVA = "0x25725D0", Offset = "0x25711D0", VA = "0x1825725D0")]
		public Act42D0MapStageSelectItemView()
		{
		}

		// Token: 0x0403BEFC RID: 245500
		[Token(Token = "0x403BEFC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _stageNum;

		// Token: 0x0403BEFD RID: 245501
		[Token(Token = "0x403BEFD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _areaCode;

		// Token: 0x0403BEFE RID: 245502
		[Token(Token = "0x403BEFE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _areaCodeBkg;

		// Token: 0x0403BEFF RID: 245503
		[Token(Token = "0x403BEFF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgOperation;

		// Token: 0x0403BF00 RID: 245504
		[Token(Token = "0x403BF00")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _imgCompleted;

		// Token: 0x0403BF01 RID: 245505
		[Token(Token = "0x403BF01")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgBkgNotSelected;

		// Token: 0x0403BF02 RID: 245506
		[Token(Token = "0x403BF02")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _bkgSelectedNormal;

		// Token: 0x0403BF03 RID: 245507
		[Token(Token = "0x403BF03")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _bkgSelectedHard;

		// Token: 0x0403BF04 RID: 245508
		[Token(Token = "0x403BF04")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasObject _atlasAsset;

		// Token: 0x0403BF05 RID: 245509
		[Token(Token = "0x403BF05")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _imgNameBkgNotKeyStage;

		// Token: 0x0403BF06 RID: 245510
		[Token(Token = "0x403BF06")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _imgNameBkgKeyStage;

		// Token: 0x0403BF07 RID: 245511
		[Token(Token = "0x403BF07")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorStageNumNotSelected;

		// Token: 0x0403BF08 RID: 245512
		[Token(Token = "0x403BF08")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorStageNumSelected;

		// Token: 0x0403BF09 RID: 245513
		[Token(Token = "0x403BF09")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorAreaCodeHard;

		// Token: 0x0403BF0A RID: 245514
		[Token(Token = "0x403BF0A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorAreaCodeNormal;

		// Token: 0x0403BF0B RID: 245515
		[Token(Token = "0x403BF0B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorAreaCodeNotSelected;

		// Token: 0x0403BF0C RID: 245516
		[Token(Token = "0x403BF0C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorTagOperationNotSelected;

		// Token: 0x0403BF0D RID: 245517
		[Token(Token = "0x403BF0D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorTagOperationSelected;

		// Token: 0x0403BF0E RID: 245518
		[Token(Token = "0x403BF0E")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorAreaCodeBkgSelected;

		// Token: 0x0403BF0F RID: 245519
		[Token(Token = "0x403BF0F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Color Config")]
		private Color _colorAreaCodeBkgNotSelected;

		// Token: 0x0403BF10 RID: 245520
		[Token(Token = "0x403BF10")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIAnimationLocation _animSelected;

		// Token: 0x0403BF11 RID: 245521
		[Token(Token = "0x403BF11")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _btnGo;

		// Token: 0x0403BF12 RID: 245522
		[Token(Token = "0x403BF12")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isInited;

		// Token: 0x0403BF13 RID: 245523
		[Token(Token = "0x403BF13")]
		[FieldOffset(Offset = "0x120")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BF14 RID: 245524
		[Token(Token = "0x403BF14")]
		[FieldOffset(Offset = "0x130")]
		private int m_index;

		// Token: 0x0403BF15 RID: 245525
		[Token(Token = "0x403BF15")]
		[FieldOffset(Offset = "0x138")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0403BF16 RID: 245526
		[Token(Token = "0x403BF16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_btnGo;

		// Token: 0x0403BF17 RID: 245527
		[Token(Token = "0x403BF17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BF18 RID: 245528
		[Token(Token = "0x403BF18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BF19 RID: 245529
		[Token(Token = "0x403BF19")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403BF1A RID: 245530
		[Token(Token = "0x403BF1A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
