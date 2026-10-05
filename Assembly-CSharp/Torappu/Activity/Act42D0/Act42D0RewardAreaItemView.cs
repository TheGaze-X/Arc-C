using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073A2 RID: 29602
	[Token(Token = "0x20073A2")]
	public class Act42D0RewardAreaItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029D7E RID: 171390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D7E")]
		[Address(RVA = "0x2572EB0", Offset = "0x2571AB0", VA = "0x182572EB0")]
		public void Render(string selectedAreaId, Act42D0RewardAreaViewModel viewModel)
		{
		}

		// Token: 0x06029D7F RID: 171391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D7F")]
		[Address(RVA = "0x2573120", Offset = "0x2571D20", VA = "0x182573120")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D80 RID: 171392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D80")]
		[Address(RVA = "0x2572DB0", Offset = "0x25719B0", VA = "0x182572DB0")]
		public void OnClick()
		{
		}

		// Token: 0x06029D81 RID: 171393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D81")]
		[Address(RVA = "0x2573220", Offset = "0x2571E20", VA = "0x182573220")]
		public Act42D0RewardAreaItemView()
		{
		}

		// Token: 0x0403BF4D RID: 245581
		[Token(Token = "0x403BF4D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _code;

		// Token: 0x0403BF4E RID: 245582
		[Token(Token = "0x403BF4E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _codeSelect;

		// Token: 0x0403BF4F RID: 245583
		[Token(Token = "0x403BF4F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _selectCanvasGroup;

		// Token: 0x0403BF50 RID: 245584
		[Token(Token = "0x403BF50")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0403BF51 RID: 245585
		[Token(Token = "0x403BF51")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0403BF52 RID: 245586
		[Token(Token = "0x403BF52")]
		[FieldOffset(Offset = "0x40")]
		private string m_selectedId;

		// Token: 0x0403BF53 RID: 245587
		[Token(Token = "0x403BF53")]
		[FieldOffset(Offset = "0x48")]
		private Act42D0RewardAreaViewModel m_cachedViewModel;

		// Token: 0x0403BF54 RID: 245588
		[Token(Token = "0x403BF54")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403BF55 RID: 245589
		[Token(Token = "0x403BF55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BF56 RID: 245590
		[Token(Token = "0x403BF56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BF57 RID: 245591
		[Token(Token = "0x403BF57")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403BF58 RID: 245592
		[Token(Token = "0x403BF58")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
