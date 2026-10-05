using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004765 RID: 18277
	[Token(Token = "0x2004765")]
	public class RecruitSpecialGachaInitView : DataBinder<RecruitSpecialGachaProperty>, IHotfixable
	{
		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x0601BAD2 RID: 113362 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BAD3 RID: 113363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041C3")]
		public Action onDetailBtnClicked
		{
			[Token(Token = "0x601BAD2")]
			[Address(RVA = "0x151B730", Offset = "0x151A330", VA = "0x18151B730")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BAD3")]
			[Address(RVA = "0x151B7F0", Offset = "0x151A3F0", VA = "0x18151B7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x0601BAD4 RID: 113364 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BAD5 RID: 113365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041C4")]
		public Action onSelectCharBtnClicked
		{
			[Token(Token = "0x601BAD4")]
			[Address(RVA = "0x151B790", Offset = "0x151A390", VA = "0x18151B790")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BAD5")]
			[Address(RVA = "0x151B870", Offset = "0x151A470", VA = "0x18151B870")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BAD6 RID: 113366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAD6")]
		[Address(RVA = "0x151B560", Offset = "0x151A160", VA = "0x18151B560", Slot = "7")]
		public override void OnValueChanged(RecruitSpecialGachaProperty property)
		{
		}

		// Token: 0x0601BAD7 RID: 113367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAD7")]
		[Address(RVA = "0x151B340", Offset = "0x1519F40", VA = "0x18151B340")]
		public void EventOnDetailBtnClicked()
		{
		}

		// Token: 0x0601BAD8 RID: 113368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAD8")]
		[Address(RVA = "0x151B450", Offset = "0x151A050", VA = "0x18151B450")]
		public void EventOnSelectCharBtnClicked()
		{
		}

		// Token: 0x0601BAD9 RID: 113369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAD9")]
		[Address(RVA = "0x151B6C0", Offset = "0x151A2C0", VA = "0x18151B6C0")]
		public RecruitSpecialGachaInitView()
		{
		}

		// Token: 0x04023F1D RID: 147229
		[Token(Token = "0x4023F1D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04023F1E RID: 147230
		[Token(Token = "0x4023F1E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textIntro;

		// Token: 0x04023F1F RID: 147231
		[Token(Token = "0x4023F1F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTime;

		// Token: 0x04023F22 RID: 147234
		[Token(Token = "0x4023F22")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04023F23 RID: 147235
		[Token(Token = "0x4023F23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onDetailBtnClicked;

		// Token: 0x04023F24 RID: 147236
		[Token(Token = "0x4023F24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onDetailBtnClicked;

		// Token: 0x04023F25 RID: 147237
		[Token(Token = "0x4023F25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onSelectCharBtnClicked;

		// Token: 0x04023F26 RID: 147238
		[Token(Token = "0x4023F26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onSelectCharBtnClicked;

		// Token: 0x04023F27 RID: 147239
		[Token(Token = "0x4023F27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023F28 RID: 147240
		[Token(Token = "0x4023F28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnDetailBtnClicked;

		// Token: 0x04023F29 RID: 147241
		[Token(Token = "0x4023F29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnSelectCharBtnClicked;

		// Token: 0x04023F2A RID: 147242
		[Token(Token = "0x4023F2A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
