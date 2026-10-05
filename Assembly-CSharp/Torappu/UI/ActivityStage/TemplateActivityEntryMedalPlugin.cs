using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C84 RID: 27780
	[Token(Token = "0x2006C84")]
	public class TemplateActivityEntryMedalPlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x06027A3D RID: 162365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A3D")]
		[Address(RVA = "0x22CC7D0", Offset = "0x22CB3D0", VA = "0x1822CC7D0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027A3E RID: 162366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A3E")]
		[Address(RVA = "0x22CCA70", Offset = "0x22CB670", VA = "0x1822CCA70")]
		public TemplateActivityEntryMedalPlugin()
		{
		}

		// Token: 0x04038386 RID: 230278
		[Token(Token = "0x4038386")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x04038387 RID: 230279
		[Token(Token = "0x4038387")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x04038388 RID: 230280
		[Token(Token = "0x4038388")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useOverrideProgressColor;

		// Token: 0x04038389 RID: 230281
		[Token(Token = "0x4038389")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Color _overrideProgressColor;

		// Token: 0x0403838A RID: 230282
		[Token(Token = "0x403838A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403838B RID: 230283
		[Token(Token = "0x403838B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
