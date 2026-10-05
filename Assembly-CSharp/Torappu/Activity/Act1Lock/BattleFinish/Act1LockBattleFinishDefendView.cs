using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.BattleFinish
{
	// Token: 0x020078DB RID: 30939
	[Token(Token = "0x20078DB")]
	public class Act1LockBattleFinishDefendView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006596 RID: 26006
		// (get) Token: 0x0602B62A RID: 177706 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B62B RID: 177707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006596")]
		public Action onConfirmClicked
		{
			[Token(Token = "0x602B62A")]
			[Address(RVA = "0x2755080", Offset = "0x2753C80", VA = "0x182755080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B62B")]
			[Address(RVA = "0x27551C0", Offset = "0x2753DC0", VA = "0x1827551C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006597 RID: 26007
		// (get) Token: 0x0602B62C RID: 177708 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B62D RID: 177709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006597")]
		public Action onCancelClicked
		{
			[Token(Token = "0x602B62C")]
			[Address(RVA = "0x2755020", Offset = "0x2753C20", VA = "0x182755020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B62D")]
			[Address(RVA = "0x2755140", Offset = "0x2753D40", VA = "0x182755140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006598 RID: 26008
		// (get) Token: 0x0602B62E RID: 177710 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B62F RID: 177711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006598")]
		public Action onDefendSucClicked
		{
			[Token(Token = "0x602B62E")]
			[Address(RVA = "0x27550E0", Offset = "0x2753CE0", VA = "0x1827550E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B62F")]
			[Address(RVA = "0x2755240", Offset = "0x2753E40", VA = "0x182755240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B630 RID: 177712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B630")]
		[Address(RVA = "0x2754380", Offset = "0x2752F80", VA = "0x182754380")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0602B631 RID: 177713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B631")]
		[Address(RVA = "0x2754270", Offset = "0x2752E70", VA = "0x182754270")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x0602B632 RID: 177714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B632")]
		[Address(RVA = "0x2754490", Offset = "0x2753090", VA = "0x182754490")]
		public void EventOnDefendSucClicked()
		{
		}

		// Token: 0x0602B633 RID: 177715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B633")]
		[Address(RVA = "0x27546B0", Offset = "0x27532B0", VA = "0x1827546B0")]
		public void Render(InterlockStageDefendModel viewModel)
		{
		}

		// Token: 0x0602B634 RID: 177716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B634")]
		[Address(RVA = "0x27548C0", Offset = "0x27534C0", VA = "0x1827548C0")]
		public IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0602B635 RID: 177717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B635")]
		[Address(RVA = "0x2754970", Offset = "0x2753570", VA = "0x182754970")]
		public IEnumerator ShowDefendSucCoroutine()
		{
			return null;
		}

		// Token: 0x0602B636 RID: 177718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B636")]
		[Address(RVA = "0x27545A0", Offset = "0x27531A0", VA = "0x1827545A0")]
		public void Hide()
		{
		}

		// Token: 0x0602B637 RID: 177719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B637")]
		[Address(RVA = "0x2754A20", Offset = "0x2753620", VA = "0x182754A20")]
		private void _RenderDefend()
		{
		}

		// Token: 0x0602B638 RID: 177720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B638")]
		[Address(RVA = "0x2754C90", Offset = "0x2753890", VA = "0x182754C90")]
		private void _RenderReplace()
		{
		}

		// Token: 0x0602B639 RID: 177721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B639")]
		[Address(RVA = "0x2754FC0", Offset = "0x2753BC0", VA = "0x182754FC0")]
		public Act1LockBattleFinishDefendView()
		{
		}

		// Token: 0x0403EBDC RID: 256988
		[Token(Token = "0x403EBDC")]
		private const float FADE_TIME = 0.2f;

		// Token: 0x0403EBDD RID: 256989
		[Token(Token = "0x403EBDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403EBDE RID: 256990
		[Token(Token = "0x403EBDE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _defendSucCanvasGroup;

		// Token: 0x0403EBDF RID: 256991
		[Token(Token = "0x403EBDF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403EBE0 RID: 256992
		[Token(Token = "0x403EBE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _animDefendSuc;

		// Token: 0x0403EBE1 RID: 256993
		[Token(Token = "0x403EBE1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIFullScreenImage _blurBkg;

		// Token: 0x0403EBE2 RID: 256994
		[Token(Token = "0x403EBE2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<TwoStateToggle> _battleRanks;

		// Token: 0x0403EBE3 RID: 256995
		[Token(Token = "0x403EBE3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textStageCode;

		// Token: 0x0403EBE4 RID: 256996
		[Token(Token = "0x403EBE4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x0403EBE5 RID: 256997
		[Token(Token = "0x403EBE5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textDefendSucStageCode;

		// Token: 0x0403EBE6 RID: 256998
		[Token(Token = "0x403EBE6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDefendSucStageName;

		// Token: 0x0403EBE7 RID: 256999
		[Token(Token = "0x403EBE7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textCharCntBefore;

		// Token: 0x0403EBE8 RID: 257000
		[Token(Token = "0x403EBE8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textCharCntAfter;

		// Token: 0x0403EBE9 RID: 257001
		[Token(Token = "0x403EBE9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403EBEA RID: 257002
		[Token(Token = "0x403EBEA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private EasyInstancePool _charsBefore;

		// Token: 0x0403EBEB RID: 257003
		[Token(Token = "0x403EBEB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private EasyInstancePool _charsAfter;

		// Token: 0x0403EBEC RID: 257004
		[Token(Token = "0x403EBEC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _panelDefendSuc;

		// Token: 0x0403EBED RID: 257005
		[Token(Token = "0x403EBED")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIRenderTextureImage _defendSucBlurBkg;

		// Token: 0x0403EBEE RID: 257006
		[Token(Token = "0x403EBEE")]
		[FieldOffset(Offset = "0xA0")]
		private InterlockStageDefendModel m_cacheModel;

		// Token: 0x0403EBF2 RID: 257010
		[Token(Token = "0x403EBF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onConfirmClicked;

		// Token: 0x0403EBF3 RID: 257011
		[Token(Token = "0x403EBF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onConfirmClicked;

		// Token: 0x0403EBF4 RID: 257012
		[Token(Token = "0x403EBF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCancelClicked;

		// Token: 0x0403EBF5 RID: 257013
		[Token(Token = "0x403EBF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCancelClicked;

		// Token: 0x0403EBF6 RID: 257014
		[Token(Token = "0x403EBF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onDefendSucClicked;

		// Token: 0x0403EBF7 RID: 257015
		[Token(Token = "0x403EBF7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onDefendSucClicked;

		// Token: 0x0403EBF8 RID: 257016
		[Token(Token = "0x403EBF8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0403EBF9 RID: 257017
		[Token(Token = "0x403EBF9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x0403EBFA RID: 257018
		[Token(Token = "0x403EBFA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnDefendSucClicked;

		// Token: 0x0403EBFB RID: 257019
		[Token(Token = "0x403EBFB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EBFC RID: 257020
		[Token(Token = "0x403EBFC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403EBFD RID: 257021
		[Token(Token = "0x403EBFD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ShowDefendSucCoroutine;

		// Token: 0x0403EBFE RID: 257022
		[Token(Token = "0x403EBFE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0403EBFF RID: 257023
		[Token(Token = "0x403EBFF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderDefend;

		// Token: 0x0403EC00 RID: 257024
		[Token(Token = "0x403EC00")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RenderReplace;

		// Token: 0x0403EC01 RID: 257025
		[Token(Token = "0x403EC01")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
