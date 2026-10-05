using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007855 RID: 30805
	[Token(Token = "0x2007855")]
	public class Act1MainSSZoneGroupView : TemplateActivityCommonPlugin
	{
		// Token: 0x0602B31E RID: 176926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B31E")]
		[Address(RVA = "0x271B310", Offset = "0x2719F10", VA = "0x18271B310", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602B31F RID: 176927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B31F")]
		[Address(RVA = "0x271B440", Offset = "0x271A040", VA = "0x18271B440")]
		public Act1MainSSZoneGroupView()
		{
		}

		// Token: 0x0403E72B RID: 255787
		[Token(Token = "0x403E72B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _inTimePart;

		// Token: 0x0403E72C RID: 255788
		[Token(Token = "0x403E72C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _availPart;

		// Token: 0x0403E72D RID: 255789
		[Token(Token = "0x403E72D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _notAvailPart;

		// Token: 0x0403E72E RID: 255790
		[Token(Token = "0x403E72E")]
		[FieldOffset(Offset = "0x40")]
		private Act1MainSSZoneGroupViewModel m_viewModel;

		// Token: 0x0403E72F RID: 255791
		[Token(Token = "0x403E72F")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_finder;

		// Token: 0x0403E730 RID: 255792
		[Token(Token = "0x403E730")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403E731 RID: 255793
		[Token(Token = "0x403E731")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
