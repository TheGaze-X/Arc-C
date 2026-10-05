using System;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C7B RID: 27771
	[Token(Token = "0x2006C7B")]
	public abstract class AbstractTemplateActivityEntryMilestonePlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x06027A24 RID: 162340
		[Token(Token = "0x6027A24")]
		protected abstract void OnViewModelRefresh(TemplateActivityMilestoneGroupViewModel viewModel);

		// Token: 0x06027A25 RID: 162341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A25")]
		[Address(RVA = "0x22BCF70", Offset = "0x22BBB70", VA = "0x1822BCF70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027A26 RID: 162342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A26")]
		[Address(RVA = "0x22BCAD0", Offset = "0x22BB6D0", VA = "0x1822BCAD0", Slot = "5")]
		public sealed override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027A27 RID: 162343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A27")]
		[Address(RVA = "0x22BC880", Offset = "0x22BB480", VA = "0x1822BC880")]
		public void EventOnOpenMilestone()
		{
		}

		// Token: 0x06027A28 RID: 162344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A28")]
		[Address(RVA = "0x22BD0A0", Offset = "0x22BBCA0", VA = "0x1822BD0A0")]
		protected AbstractTemplateActivityEntryMilestonePlugin()
		{
		}

		// Token: 0x0403835A RID: 230234
		[Token(Token = "0x403835A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected UIActTrackPoint _trackPointAvail;

		// Token: 0x0403835B RID: 230235
		[Token(Token = "0x403835B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected UIActTrackPoint _trackPointNew;

		// Token: 0x0403835C RID: 230236
		[Token(Token = "0x403835C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403835D RID: 230237
		[Token(Token = "0x403835D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x0403835E RID: 230238
		[Token(Token = "0x403835E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelMax;

		// Token: 0x0403835F RID: 230239
		[Token(Token = "0x403835F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textLvl;

		// Token: 0x04038360 RID: 230240
		[Token(Token = "0x4038360")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x04038361 RID: 230241
		[Token(Token = "0x4038361")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x04038362 RID: 230242
		[Token(Token = "0x4038362")]
		[FieldOffset(Offset = "0x68")]
		protected TrackPointViewProperty availProperty;

		// Token: 0x04038363 RID: 230243
		[Token(Token = "0x4038363")]
		[FieldOffset(Offset = "0x70")]
		protected TrackPointViewProperty newProperty;

		// Token: 0x04038364 RID: 230244
		[Token(Token = "0x4038364")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038365 RID: 230245
		[Token(Token = "0x4038365")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04038366 RID: 230246
		[Token(Token = "0x4038366")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnOpenMilestone;

		// Token: 0x04038367 RID: 230247
		[Token(Token = "0x4038367")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
