using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E74 RID: 20084
	[Token(Token = "0x2004E74")]
	public class FireworkPuzzleResultView : DataBinder<FireworkPuzzleResultProp>
	{
		// Token: 0x0601DF9A RID: 122778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF9A")]
		[Address(RVA = "0x17ADC50", Offset = "0x17AC850", VA = "0x1817ADC50", Slot = "7")]
		public override void OnValueChanged(FireworkPuzzleResultProp property)
		{
		}

		// Token: 0x0601DF9B RID: 122779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF9B")]
		[Address(RVA = "0x17AE270", Offset = "0x17ACE70", VA = "0x1817AE270")]
		private void _RenderNpc(FireworkPuzzleResultModel resultModel)
		{
		}

		// Token: 0x0601DF9C RID: 122780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF9C")]
		[Address(RVA = "0x17ADF10", Offset = "0x17ACB10", VA = "0x1817ADF10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DF9D RID: 122781 RVA: 0x000AD118 File Offset: 0x000AB318
		[Token(Token = "0x601DF9D")]
		[Address(RVA = "0x17ADBE0", Offset = "0x17AC7E0", VA = "0x1817ADBE0")]
		public bool IsTweening()
		{
			return default(bool);
		}

		// Token: 0x0601DF9E RID: 122782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF9E")]
		[Address(RVA = "0x17AE070", Offset = "0x17ACC70", VA = "0x1817AE070")]
		private void _PlayEnterAnimIfNeed()
		{
		}

		// Token: 0x0601DF9F RID: 122783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF9F")]
		[Address(RVA = "0x17AE460", Offset = "0x17AD060", VA = "0x1817AE460")]
		public FireworkPuzzleResultView()
		{
		}

		// Token: 0x04027CED RID: 163053
		[Token(Token = "0x4027CED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04027CEE RID: 163054
		[Token(Token = "0x4027CEE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _plateContainer;

		// Token: 0x04027CEF RID: 163055
		[Token(Token = "0x4027CEF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UISpineWrapper _spineWrapper;

		// Token: 0x04027CF0 RID: 163056
		[Token(Token = "0x4027CF0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04027CF1 RID: 163057
		[Token(Token = "0x4027CF1")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x04027CF2 RID: 163058
		[Token(Token = "0x4027CF2")]
		[FieldOffset(Offset = "0x4C")]
		private int m_cachedEnterSeqNum;

		// Token: 0x04027CF3 RID: 163059
		[Token(Token = "0x4027CF3")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_enterTween;

		// Token: 0x04027CF4 RID: 163060
		[Token(Token = "0x4027CF4")]
		[FieldOffset(Offset = "0x58")]
		private FireworkPuzzleResultModel m_resultModel;

		// Token: 0x04027CF5 RID: 163061
		[Token(Token = "0x4027CF5")]
		[FieldOffset(Offset = "0x60")]
		private FireworkPlateViewStyle m_plateStyle;

		// Token: 0x04027CF6 RID: 163062
		[Token(Token = "0x4027CF6")]
		[FieldOffset(Offset = "0x68")]
		private FireworkPlateView m_plateView;

		// Token: 0x04027CF7 RID: 163063
		[Token(Token = "0x4027CF7")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04027CF8 RID: 163064
		[Token(Token = "0x4027CF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027CF9 RID: 163065
		[Token(Token = "0x4027CF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderNpc;

		// Token: 0x04027CFA RID: 163066
		[Token(Token = "0x4027CFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027CFB RID: 163067
		[Token(Token = "0x4027CFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsTweening;

		// Token: 0x04027CFC RID: 163068
		[Token(Token = "0x4027CFC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEnterAnimIfNeed;

		// Token: 0x04027CFD RID: 163069
		[Token(Token = "0x4027CFD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
