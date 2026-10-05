using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056CE RID: 22222
	[Token(Token = "0x20056CE")]
	public class RL04FragmentDialog : RoguelikeFragmentDialog, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x06020972 RID: 133490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020972")]
		[Address(RVA = "0x1ABB540", Offset = "0x1ABA140", VA = "0x181ABB540", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06020973 RID: 133491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020973")]
		[Address(RVA = "0x1ABB5B0", Offset = "0x1ABA1B0", VA = "0x181ABB5B0", Slot = "18")]
		protected override void OnRender(RoguelikeFragmentDialog.Options input)
		{
		}

		// Token: 0x06020974 RID: 133492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020974")]
		[Address(RVA = "0x1ABB250", Offset = "0x1AB9E50", VA = "0x181ABB250", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06020975 RID: 133493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020975")]
		[Address(RVA = "0x1ABB190", Offset = "0x1AB9D90", VA = "0x181ABB190")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06020976 RID: 133494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020976")]
		[Address(RVA = "0x1ABB340", Offset = "0x1AB9F40", VA = "0x181ABB340", Slot = "19")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06020977 RID: 133495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020977")]
		[Address(RVA = "0x1ABBFB0", Offset = "0x1ABABB0", VA = "0x181ABBFB0")]
		private void _HandleFragmentDetailCallback(ValueBundle output)
		{
		}

		// Token: 0x06020978 RID: 133496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020978")]
		[Address(RVA = "0x1ABBEE0", Offset = "0x1ABAAE0", VA = "0x181ABBEE0")]
		private void _HandleFragmentCharSelectCallback(ValueBundle output)
		{
		}

		// Token: 0x06020979 RID: 133497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020979")]
		[Address(RVA = "0x1ABC0A0", Offset = "0x1ABACA0", VA = "0x181ABC0A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602097A RID: 133498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602097A")]
		[Address(RVA = "0x1ABBAB0", Offset = "0x1ABA6B0", VA = "0x181ABBAB0")]
		private void _EventOnItemClicked(string instId)
		{
		}

		// Token: 0x0602097B RID: 133499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602097B")]
		[Address(RVA = "0x1ABB850", Offset = "0x1ABA450", VA = "0x181ABB850")]
		private void _EventOnCharCardClicked(int index)
		{
		}

		// Token: 0x0602097C RID: 133500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602097C")]
		[Address(RVA = "0x1ABBDB0", Offset = "0x1ABA9B0", VA = "0x181ABBDB0")]
		private void _EventOnListSwitchBtnClicked()
		{
		}

		// Token: 0x0602097D RID: 133501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602097D")]
		[Address(RVA = "0x1ABC480", Offset = "0x1ABB080", VA = "0x181ABC480")]
		public RL04FragmentDialog()
		{
		}

		// Token: 0x0602097E RID: 133502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602097E")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0602097F RID: 133503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602097F")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0402C2C7 RID: 180935
		[Token(Token = "0x402C2C7")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "rl04_fragment";

		// Token: 0x0402C2C8 RID: 180936
		[Token(Token = "0x402C2C8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0402C2C9 RID: 180937
		[Token(Token = "0x402C2C9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402C2CA RID: 180938
		[Token(Token = "0x402C2CA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RL04FragmentWeightView _weightView;

		// Token: 0x0402C2CB RID: 180939
		[Token(Token = "0x402C2CB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RL04FragmentListView _listView;

		// Token: 0x0402C2CC RID: 180940
		[Token(Token = "0x402C2CC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIGuidebookTrigger _guidebookTrigger;

		// Token: 0x0402C2CD RID: 180941
		[Token(Token = "0x402C2CD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _panelBackRt;

		// Token: 0x0402C2CE RID: 180942
		[Token(Token = "0x402C2CE")]
		[FieldOffset(Offset = "0xA8")]
		private RL04FragmentProperty m_property;

		// Token: 0x0402C2CF RID: 180943
		[Token(Token = "0x402C2CF")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x0402C2D0 RID: 180944
		[Token(Token = "0x402C2D0")]
		[FieldOffset(Offset = "0xB8")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0402C2D1 RID: 180945
		[Token(Token = "0x402C2D1")]
		[FieldOffset(Offset = "0xC0")]
		private int m_fragmentDialogInst;

		// Token: 0x0402C2D2 RID: 180946
		[Token(Token = "0x402C2D2")]
		[FieldOffset(Offset = "0xC4")]
		private int m_fragmentCharSelectDialogInst;

		// Token: 0x0402C2D3 RID: 180947
		[Token(Token = "0x402C2D3")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_enterAnim;

		// Token: 0x0402C2D4 RID: 180948
		[Token(Token = "0x402C2D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402C2D5 RID: 180949
		[Token(Token = "0x402C2D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402C2D6 RID: 180950
		[Token(Token = "0x402C2D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0402C2D7 RID: 180951
		[Token(Token = "0x402C2D7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x0402C2D8 RID: 180952
		[Token(Token = "0x402C2D8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402C2D9 RID: 180953
		[Token(Token = "0x402C2D9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HandleFragmentDetailCallback;

		// Token: 0x0402C2DA RID: 180954
		[Token(Token = "0x402C2DA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleFragmentCharSelectCallback;

		// Token: 0x0402C2DB RID: 180955
		[Token(Token = "0x402C2DB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C2DC RID: 180956
		[Token(Token = "0x402C2DC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnItemClicked;

		// Token: 0x0402C2DD RID: 180957
		[Token(Token = "0x402C2DD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnCharCardClicked;

		// Token: 0x0402C2DE RID: 180958
		[Token(Token = "0x402C2DE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnListSwitchBtnClicked;

		// Token: 0x0402C2DF RID: 180959
		[Token(Token = "0x402C2DF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056CF RID: 22223
		[Token(Token = "0x20056CF")]
		private class FragmentDialogSwitchTween : UISwitchTween, IHotfixable
		{
			// Token: 0x06020980 RID: 133504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020980")]
			[Address(RVA = "0x1ABA9C0", Offset = "0x1AB95C0", VA = "0x181ABA9C0")]
			public FragmentDialogSwitchTween(RL04FragmentDialog closure)
			{
			}

			// Token: 0x06020981 RID: 133505 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020981")]
			[Address(RVA = "0x1ABA630", Offset = "0x1AB9230", VA = "0x181ABA630", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06020982 RID: 133506 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020982")]
			[Address(RVA = "0x1ABA740", Offset = "0x1AB9340", VA = "0x181ABA740", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06020983 RID: 133507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020983")]
			[Address(RVA = "0x1ABA8A0", Offset = "0x1AB94A0", VA = "0x181ABA8A0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06020984 RID: 133508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020984")]
			[Address(RVA = "0x1ABA580", Offset = "0x1AB9180", VA = "0x181ABA580", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06020985 RID: 133509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020985")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x06020986 RID: 133510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020986")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0402C2E0 RID: 180960
			[Token(Token = "0x402C2E0")]
			[FieldOffset(Offset = "0x48")]
			private RL04FragmentDialog m_closure;

			// Token: 0x0402C2E1 RID: 180961
			[Token(Token = "0x402C2E1")]
			[FieldOffset(Offset = "0x50")]
			private float m_duration;

			// Token: 0x0402C2E2 RID: 180962
			[Token(Token = "0x402C2E2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C2E3 RID: 180963
			[Token(Token = "0x402C2E3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402C2E4 RID: 180964
			[Token(Token = "0x402C2E4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402C2E5 RID: 180965
			[Token(Token = "0x402C2E5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0402C2E6 RID: 180966
			[Token(Token = "0x402C2E6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;
		}
	}
}
