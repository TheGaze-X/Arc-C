using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056C9 RID: 22217
	[Token(Token = "0x20056C9")]
	public class RL04FragmentGainDialog : UICompDialog<RL04FragmentGainDialog.Options>, IHotfixable
	{
		// Token: 0x0602095A RID: 133466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602095A")]
		[Address(RVA = "0x1AAFA10", Offset = "0x1AAE610", VA = "0x181AAFA10", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602095B RID: 133467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602095B")]
		[Address(RVA = "0x1AAFA80", Offset = "0x1AAE680", VA = "0x181AAFA80", Slot = "18")]
		protected override void OnRender(RL04FragmentGainDialog.Options input)
		{
		}

		// Token: 0x0602095C RID: 133468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602095C")]
		[Address(RVA = "0x1AAFCE0", Offset = "0x1AAE8E0", VA = "0x181AAFCE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602095D RID: 133469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602095D")]
		[Address(RVA = "0x1AAFC30", Offset = "0x1AAE830", VA = "0x181AAFC30")]
		private void _EventOnNextBtnClick()
		{
		}

		// Token: 0x0602095E RID: 133470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602095E")]
		[Address(RVA = "0x1AAFB60", Offset = "0x1AAE760", VA = "0x181AAFB60")]
		private void _EventOnCloseBtnClick()
		{
		}

		// Token: 0x0602095F RID: 133471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602095F")]
		[Address(RVA = "0x1AAFF30", Offset = "0x1AAEB30", VA = "0x181AAFF30")]
		public RL04FragmentGainDialog()
		{
		}

		// Token: 0x06020960 RID: 133472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020960")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402C29E RID: 180894
		[Token(Token = "0x402C29E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RL04FragmentGainView _view;

		// Token: 0x0402C29F RID: 180895
		[Token(Token = "0x402C29F")]
		[FieldOffset(Offset = "0x78")]
		private RL04FragmentGainProperty m_property;

		// Token: 0x0402C2A0 RID: 180896
		[Token(Token = "0x402C2A0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0402C2A1 RID: 180897
		[Token(Token = "0x402C2A1")]
		[FieldOffset(Offset = "0x88")]
		private Action m_onConfirm;

		// Token: 0x0402C2A2 RID: 180898
		[Token(Token = "0x402C2A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402C2A3 RID: 180899
		[Token(Token = "0x402C2A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402C2A4 RID: 180900
		[Token(Token = "0x402C2A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C2A5 RID: 180901
		[Token(Token = "0x402C2A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnNextBtnClick;

		// Token: 0x0402C2A6 RID: 180902
		[Token(Token = "0x402C2A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnCloseBtnClick;

		// Token: 0x0402C2A7 RID: 180903
		[Token(Token = "0x402C2A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056CA RID: 22218
		[Token(Token = "0x20056CA")]
		public class Options
		{
			// Token: 0x06020961 RID: 133473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020961")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402C2A8 RID: 180904
			[Token(Token = "0x402C2A8")]
			[FieldOffset(Offset = "0x10")]
			public List<IRoguelikeFragmentItemModel> fragmentList;

			// Token: 0x0402C2A9 RID: 180905
			[Token(Token = "0x402C2A9")]
			[FieldOffset(Offset = "0x18")]
			public Action onConfirm;
		}
	}
}
