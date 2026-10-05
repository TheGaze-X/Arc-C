using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act35side
{
	// Token: 0x02007477 RID: 29815
	[Token(Token = "0x2007477")]
	public class Act35sideMilestoneDisplayRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A0DD RID: 172253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0DD")]
		[Address(RVA = "0x2598440", Offset = "0x2597040", VA = "0x182598440")]
		public void Render(Act35sideMilestoneDisplayRewardItemViewModel viewModel)
		{
		}

		// Token: 0x0602A0DE RID: 172254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0DE")]
		[Address(RVA = "0x2598540", Offset = "0x2597140", VA = "0x182598540")]
		public Act35sideMilestoneDisplayRewardItemView()
		{
		}

		// Token: 0x0403C580 RID: 247168
		[Token(Token = "0x403C580")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objRoot;

		// Token: 0x0403C581 RID: 247169
		[Token(Token = "0x403C581")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0403C582 RID: 247170
		[Token(Token = "0x403C582")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x0403C583 RID: 247171
		[Token(Token = "0x403C583")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C584 RID: 247172
		[Token(Token = "0x403C584")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
