using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055E5 RID: 21989
	[Token(Token = "0x20055E5")]
	public class RL05MenuWrathTagObject : MonoBehaviour
	{
		// Token: 0x0602047E RID: 132222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602047E")]
		[Address(RVA = "0x1A6A5F0", Offset = "0x1A691F0", VA = "0x181A6A5F0")]
		public void Init()
		{
		}

		// Token: 0x0602047F RID: 132223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602047F")]
		[Address(RVA = "0x1A6A660", Offset = "0x1A69260", VA = "0x181A6A660")]
		public void Render(Sprite wrathIcon, RL05WrathTagItemViewModel wrathData, bool showRedPoint)
		{
		}

		// Token: 0x06020480 RID: 132224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020480")]
		[Address(RVA = "0x1A6AAF0", Offset = "0x1A696F0", VA = "0x181A6AAF0")]
		private string _GetWrathIconBgId(RL05WrathTagItemViewModel wrathData)
		{
			return null;
		}

		// Token: 0x06020481 RID: 132225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020481")]
		[Address(RVA = "0x1A6AB50", Offset = "0x1A69750", VA = "0x181A6AB50")]
		private void _ResetVisual()
		{
		}

		// Token: 0x06020482 RID: 132226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020482")]
		[Address(RVA = "0x1A6A7F0", Offset = "0x1A693F0", VA = "0x181A6A7F0")]
		public void Show(float delay = 0f)
		{
		}

		// Token: 0x06020483 RID: 132227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020483")]
		[Address(RVA = "0x1A6A590", Offset = "0x1A69190", VA = "0x181A6A590")]
		public void Hide(float duration = 0.5f)
		{
		}

		// Token: 0x06020484 RID: 132228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020484")]
		[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
		public UIColorGraphic GetColorGraphic()
		{
			return null;
		}

		// Token: 0x06020485 RID: 132229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020485")]
		[Address(RVA = "0x1A6A600", Offset = "0x1A69200", VA = "0x181A6A600")]
		private void _killTween()
		{
		}

		// Token: 0x06020486 RID: 132230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020486")]
		[Address(RVA = "0x1A6A600", Offset = "0x1A69200", VA = "0x181A6A600")]
		private void OnDestroy()
		{
		}

		// Token: 0x06020487 RID: 132231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020487")]
		[Address(RVA = "0x1A6AC00", Offset = "0x1A69800", VA = "0x181A6AC00")]
		public RL05MenuWrathTagObject()
		{
		}

		// Token: 0x0402BAD4 RID: 178900
		[Token(Token = "0x402BAD4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgWrath;

		// Token: 0x0402BAD5 RID: 178901
		[Token(Token = "0x402BAD5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgWrathBg;

		// Token: 0x0402BAD6 RID: 178902
		[Token(Token = "0x402BAD6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0402BAD7 RID: 178903
		[Token(Token = "0x402BAD7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0402BAD8 RID: 178904
		[Token(Token = "0x402BAD8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _targetMinWidth;

		// Token: 0x0402BAD9 RID: 178905
		[Token(Token = "0x402BAD9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402BADA RID: 178906
		[Token(Token = "0x402BADA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelRedPoint;

		// Token: 0x0402BADB RID: 178907
		[Token(Token = "0x402BADB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasObject _wrathAtlas;

		// Token: 0x0402BADC RID: 178908
		[Token(Token = "0x402BADC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _bkgVariation;

		// Token: 0x0402BADD RID: 178909
		[Token(Token = "0x402BADD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _bkgNormal;

		// Token: 0x0402BADE RID: 178910
		[Token(Token = "0x402BADE")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_widthExpandTween;

		// Token: 0x0402BADF RID: 178911
		[Token(Token = "0x402BADF")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_animationTween;

		// Token: 0x0402BAE0 RID: 178912
		[Token(Token = "0x402BAE0")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BAE1 RID: 178913
		[Token(Token = "0x402BAE1")]
		[FieldOffset(Offset = "0x88")]
		private RL05WrathTagItemViewModel m_wrathData;

		// Token: 0x0402BAE2 RID: 178914
		[Token(Token = "0x402BAE2")]
		[FieldOffset(Offset = "0x90")]
		private Sequence m_showSequence;

		// Token: 0x0402BAE3 RID: 178915
		[Token(Token = "0x402BAE3")]
		[FieldOffset(Offset = "0x98")]
		private string WRATH_SHOW_ANIM_NAME;
	}
}
