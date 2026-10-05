using System;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C86 RID: 27782
	[Token(Token = "0x2006C86")]
	public class TemplateActivityEntryTimePlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x06027A43 RID: 162371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A43")]
		[Address(RVA = "0x22CD490", Offset = "0x22CC090", VA = "0x1822CD490", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027A44 RID: 162372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A44")]
		[Address(RVA = "0x22CD920", Offset = "0x22CC520", VA = "0x1822CD920")]
		public TemplateActivityEntryTimePlugin()
		{
		}

		// Token: 0x04038394 RID: 230292
		[Token(Token = "0x4038394")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbstractStageTime _stageTime;

		// Token: 0x04038395 RID: 230293
		[Token(Token = "0x4038395")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AbstractRemainTime _remainTime;

		// Token: 0x04038396 RID: 230294
		[Token(Token = "0x4038396")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _endTime;

		// Token: 0x04038397 RID: 230295
		[Token(Token = "0x4038397")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04038398 RID: 230296
		[Token(Token = "0x4038398")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
