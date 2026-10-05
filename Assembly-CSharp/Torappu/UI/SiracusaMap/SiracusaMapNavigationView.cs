using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EF3 RID: 16115
	[Token(Token = "0x2003EF3")]
	public class SiracusaMapNavigationView : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x0601901B RID: 102427 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601901C RID: 102428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BAC")]
		public SiracusaMapController closure
		{
			[Token(Token = "0x601901B")]
			[Address(RVA = "0x11BCD30", Offset = "0x11BB930", VA = "0x1811BCD30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601901C")]
			[Address(RVA = "0x11BCDF0", Offset = "0x11BB9F0", VA = "0x1811BCDF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x0601901D RID: 102429 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601901E RID: 102430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BAD")]
		public Action<string, SiracusaData.NavigationType> onNavigationClick
		{
			[Token(Token = "0x601901D")]
			[Address(RVA = "0x11BCD90", Offset = "0x11BB990", VA = "0x1811BCD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601901E")]
			[Address(RVA = "0x11BCE70", Offset = "0x11BBA70", VA = "0x1811BCE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601901F RID: 102431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601901F")]
		[Address(RVA = "0x11BC5C0", Offset = "0x11BB1C0", VA = "0x1811BC5C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019020 RID: 102432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019020")]
		[Address(RVA = "0x11BC450", Offset = "0x11BB050", VA = "0x1811BC450")]
		private string _GetAnimNameByState(bool isFold)
		{
			return null;
		}

		// Token: 0x06019021 RID: 102433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019021")]
		[Address(RVA = "0x11BC4E0", Offset = "0x11BB0E0", VA = "0x1811BC4E0")]
		private void _InitEntryFoldAnim(string animName, bool sampleAtStart = true)
		{
		}

		// Token: 0x06019022 RID: 102434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019022")]
		[Address(RVA = "0x11BCA20", Offset = "0x11BB620", VA = "0x1811BCA20")]
		private void _PlayEntryFoldAnim(bool isFold)
		{
		}

		// Token: 0x06019023 RID: 102435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019023")]
		[Address(RVA = "0x11BC8E0", Offset = "0x11BB4E0", VA = "0x1811BC8E0")]
		private void _OnNavigationBtnClick(string entryId, SiracusaData.NavigationType entryType)
		{
		}

		// Token: 0x06019024 RID: 102436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019024")]
		[Address(RVA = "0x11BCBA0", Offset = "0x11BB7A0", VA = "0x1811BCBA0")]
		private void _RenderDotsPart(int dotsShowCount)
		{
		}

		// Token: 0x06019025 RID: 102437 RVA: 0x0009CAC8 File Offset: 0x0009ACC8
		[Token(Token = "0x6019025")]
		[Address(RVA = "0x11BC2D0", Offset = "0x11BAED0", VA = "0x1811BC2D0")]
		private bool _CheckIfNaviNeedShowNew(string entryId)
		{
			return default(bool);
		}

		// Token: 0x06019026 RID: 102438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019026")]
		[Address(RVA = "0x11BBB20", Offset = "0x11BA720", VA = "0x1811BBB20", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x06019027 RID: 102439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019027")]
		[Address(RVA = "0x11BBAB0", Offset = "0x11BA6B0", VA = "0x1811BBAB0")]
		public void OnFoldClick()
		{
		}

		// Token: 0x06019028 RID: 102440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019028")]
		[Address(RVA = "0x11BCCC0", Offset = "0x11BB8C0", VA = "0x1811BCCC0")]
		public SiracusaMapNavigationView()
		{
		}

		// Token: 0x0401EE80 RID: 126592
		[Token(Token = "0x401EE80")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SiracusaMapNavigationStageButtonView> _entryStageBtnList;

		// Token: 0x0401EE81 RID: 126593
		[Token(Token = "0x401EE81")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objExtraPart;

		// Token: 0x0401EE82 RID: 126594
		[Token(Token = "0x401EE82")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SiracusaMapNavigationCharButtonView _entryCharCardBtn;

		// Token: 0x0401EE83 RID: 126595
		[Token(Token = "0x401EE83")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _objDots;

		// Token: 0x0401EE84 RID: 126596
		[Token(Token = "0x401EE84")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationWrapper _foldAnimWrapper;

		// Token: 0x0401EE85 RID: 126597
		[Token(Token = "0x401EE85")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x0401EE86 RID: 126598
		[Token(Token = "0x401EE86")]
		private const string FOLD_ANIM = "siracusa_map_nav_fold";

		// Token: 0x0401EE87 RID: 126599
		[Token(Token = "0x401EE87")]
		private const string UNFOLD_ANIM = "siracusa_map_nav_unfold";

		// Token: 0x0401EE88 RID: 126600
		[Token(Token = "0x401EE88")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isFold;

		// Token: 0x0401EE89 RID: 126601
		[Token(Token = "0x401EE89")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isPlayingFoldAnim;

		// Token: 0x0401EE8A RID: 126602
		[Token(Token = "0x401EE8A")]
		[FieldOffset(Offset = "0x58")]
		private string m_actId;

		// Token: 0x0401EE8B RID: 126603
		[Token(Token = "0x401EE8B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0401EE8C RID: 126604
		[Token(Token = "0x401EE8C")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x0401EE8F RID: 126607
		[Token(Token = "0x401EE8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_closure;

		// Token: 0x0401EE90 RID: 126608
		[Token(Token = "0x401EE90")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_closure;

		// Token: 0x0401EE91 RID: 126609
		[Token(Token = "0x401EE91")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onNavigationClick;

		// Token: 0x0401EE92 RID: 126610
		[Token(Token = "0x401EE92")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onNavigationClick;

		// Token: 0x0401EE93 RID: 126611
		[Token(Token = "0x401EE93")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EE94 RID: 126612
		[Token(Token = "0x401EE94")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetAnimNameByState;

		// Token: 0x0401EE95 RID: 126613
		[Token(Token = "0x401EE95")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitEntryFoldAnim;

		// Token: 0x0401EE96 RID: 126614
		[Token(Token = "0x401EE96")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayEntryFoldAnim;

		// Token: 0x0401EE97 RID: 126615
		[Token(Token = "0x401EE97")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnNavigationBtnClick;

		// Token: 0x0401EE98 RID: 126616
		[Token(Token = "0x401EE98")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderDotsPart;

		// Token: 0x0401EE99 RID: 126617
		[Token(Token = "0x401EE99")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckIfNaviNeedShowNew;

		// Token: 0x0401EE9A RID: 126618
		[Token(Token = "0x401EE9A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401EE9B RID: 126619
		[Token(Token = "0x401EE9B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnFoldClick;

		// Token: 0x0401EE9C RID: 126620
		[Token(Token = "0x401EE9C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
