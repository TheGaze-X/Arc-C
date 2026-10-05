using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x02007493 RID: 29843
	[Token(Token = "0x2007493")]
	public class Act29signDynChoiceView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006336 RID: 25398
		// (get) Token: 0x0602A166 RID: 172390 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A167 RID: 172391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006336")]
		public Action<string> confirmAction
		{
			[Token(Token = "0x602A166")]
			[Address(RVA = "0x25B6F70", Offset = "0x25B5B70", VA = "0x1825B6F70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A167")]
			[Address(RVA = "0x25B6FD0", Offset = "0x25B5BD0", VA = "0x1825B6FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602A168 RID: 172392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A168")]
		[Address(RVA = "0x25B6610", Offset = "0x25B5210", VA = "0x1825B6610")]
		public void Render(Act29signDynViewModel viewModel)
		{
		}

		// Token: 0x0602A169 RID: 172393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A169")]
		[Address(RVA = "0x25B6B50", Offset = "0x25B5750", VA = "0x1825B6B50")]
		private void _OnConfirmClick(string btnOption)
		{
		}

		// Token: 0x0602A16A RID: 172394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A16A")]
		[Address(RVA = "0x25B6E50", Offset = "0x25B5A50", VA = "0x1825B6E50")]
		private void _RenderExpandView(bool isShow)
		{
		}

		// Token: 0x0602A16B RID: 172395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A16B")]
		[Address(RVA = "0x25B6860", Offset = "0x25B5460", VA = "0x1825B6860")]
		private void _EnsureConfirmBtnCount(int count)
		{
		}

		// Token: 0x0602A16C RID: 172396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A16C")]
		[Address(RVA = "0x25B6C20", Offset = "0x25B5820", VA = "0x1825B6C20")]
		private void _RenderConfirmBtn(Act29signDynViewModel viewModel)
		{
		}

		// Token: 0x0602A16D RID: 172397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A16D")]
		[Address(RVA = "0x25B6F10", Offset = "0x25B5B10", VA = "0x1825B6F10")]
		public Act29signDynChoiceView()
		{
		}

		// Token: 0x0403C6A9 RID: 247465
		[Token(Token = "0x403C6A9")]
		private const float EXPAND_DELAY = 0.16f;

		// Token: 0x0403C6AA RID: 247466
		[Token(Token = "0x403C6AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act29signExpandView _expandView;

		// Token: 0x0403C6AB RID: 247467
		[Token(Token = "0x403C6AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act29signChoiceConfirmBtnView _choiceConfirmBtn;

		// Token: 0x0403C6AC RID: 247468
		[Token(Token = "0x403C6AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _choiceConfirmBtnContainer;

		// Token: 0x0403C6AD RID: 247469
		[Token(Token = "0x403C6AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _questionDescText;

		// Token: 0x0403C6AE RID: 247470
		[Token(Token = "0x403C6AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _initDayOnlyReturnBtn;

		// Token: 0x0403C6AF RID: 247471
		[Token(Token = "0x403C6AF")]
		[FieldOffset(Offset = "0x40")]
		private Act29signExpandView.Model m_expandViewModel;

		// Token: 0x0403C6B0 RID: 247472
		[Token(Token = "0x403C6B0")]
		[FieldOffset(Offset = "0x50")]
		private List<Act29signChoiceConfirmBtnView> m_confirmBtnList;

		// Token: 0x0403C6B1 RID: 247473
		[Token(Token = "0x403C6B1")]
		[FieldOffset(Offset = "0x58")]
		private int m_expandIndex;

		// Token: 0x0403C6B2 RID: 247474
		[Token(Token = "0x403C6B2")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_lockConfirm;

		// Token: 0x0403C6B4 RID: 247476
		[Token(Token = "0x403C6B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_confirmAction;

		// Token: 0x0403C6B5 RID: 247477
		[Token(Token = "0x403C6B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_confirmAction;

		// Token: 0x0403C6B6 RID: 247478
		[Token(Token = "0x403C6B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C6B7 RID: 247479
		[Token(Token = "0x403C6B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnConfirmClick;

		// Token: 0x0403C6B8 RID: 247480
		[Token(Token = "0x403C6B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderExpandView;

		// Token: 0x0403C6B9 RID: 247481
		[Token(Token = "0x403C6B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EnsureConfirmBtnCount;

		// Token: 0x0403C6BA RID: 247482
		[Token(Token = "0x403C6BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderConfirmBtn;

		// Token: 0x0403C6BB RID: 247483
		[Token(Token = "0x403C6BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
