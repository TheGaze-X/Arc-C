using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004766 RID: 18278
	[Token(Token = "0x2004766")]
	public class RecruitSpecialGachaItemView : RecruitGachaItemViewBase, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x0601BADA RID: 113370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170041C5")]
		public override string gachaPoolId
		{
			[Token(Token = "0x601BADA")]
			[Address(RVA = "0x151C320", Offset = "0x151AF20", VA = "0x18151C320", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BADB RID: 113371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BADB")]
		[Address(RVA = "0x151BAE0", Offset = "0x151A6E0", VA = "0x18151BAE0", Slot = "5")]
		protected override void OnRefreshData()
		{
		}

		// Token: 0x0601BADC RID: 113372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BADC")]
		[Address(RVA = "0x151B8F0", Offset = "0x151A4F0", VA = "0x18151B8F0")]
		public void ApplyData(int index, GachaPoolClientData data)
		{
		}

		// Token: 0x0601BADD RID: 113373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BADD")]
		[Address(RVA = "0x151B9F0", Offset = "0x151A5F0", VA = "0x18151B9F0", Slot = "8")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601BADE RID: 113374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BADE")]
		[Address(RVA = "0x151BBA0", Offset = "0x151A7A0", VA = "0x18151BBA0")]
		private void _EventOnSelectCharBtnClicked()
		{
		}

		// Token: 0x0601BADF RID: 113375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BADF")]
		[Address(RVA = "0x151BE30", Offset = "0x151AA30", VA = "0x18151BE30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BAE0 RID: 113376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAE0")]
		[Address(RVA = "0x151C220", Offset = "0x151AE20", VA = "0x18151C220")]
		public RecruitSpecialGachaItemView()
		{
		}

		// Token: 0x04023F2B RID: 147243
		[Token(Token = "0x4023F2B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RecruitSpecialGachaInitView _initView;

		// Token: 0x04023F2C RID: 147244
		[Token(Token = "0x4023F2C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RecruitSpecialGachaNormalView _normalView;

		// Token: 0x04023F2D RID: 147245
		[Token(Token = "0x4023F2D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorTheme;

		// Token: 0x04023F2E RID: 147246
		[Token(Token = "0x4023F2E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _selectJudgeTextId;

		// Token: 0x04023F2F RID: 147247
		[Token(Token = "0x4023F2F")]
		[FieldOffset(Offset = "0x88")]
		private RecruitSpecialGachaProperty m_property;

		// Token: 0x04023F30 RID: 147248
		[Token(Token = "0x4023F30")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04023F31 RID: 147249
		[Token(Token = "0x4023F31")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04023F32 RID: 147250
		[Token(Token = "0x4023F32")]
		[FieldOffset(Offset = "0xA8")]
		private int m_dialogInstId;

		// Token: 0x04023F33 RID: 147251
		[Token(Token = "0x4023F33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gachaPoolId;

		// Token: 0x04023F34 RID: 147252
		[Token(Token = "0x4023F34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04023F35 RID: 147253
		[Token(Token = "0x4023F35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04023F36 RID: 147254
		[Token(Token = "0x4023F36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04023F37 RID: 147255
		[Token(Token = "0x4023F37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnSelectCharBtnClicked;

		// Token: 0x04023F38 RID: 147256
		[Token(Token = "0x4023F38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023F39 RID: 147257
		[Token(Token = "0x4023F39")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
