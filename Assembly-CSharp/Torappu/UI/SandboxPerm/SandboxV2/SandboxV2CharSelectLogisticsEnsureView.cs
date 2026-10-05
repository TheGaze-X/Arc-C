using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004024 RID: 16420
	[Token(Token = "0x2004024")]
	public class SandboxV2CharSelectLogisticsEnsureView : SandboxV2AdminCharAbstractEnsureView
	{
		// Token: 0x060196AA RID: 104106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196AA")]
		[Address(RVA = "0x121E5A0", Offset = "0x121D1A0", VA = "0x18121E5A0")]
		public void OnClick()
		{
		}

		// Token: 0x060196AB RID: 104107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196AB")]
		[Address(RVA = "0x121E500", Offset = "0x121D100", VA = "0x18121E500")]
		public void OnClear()
		{
		}

		// Token: 0x060196AC RID: 104108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196AC")]
		[Address(RVA = "0x121E660", Offset = "0x121D260", VA = "0x18121E660")]
		public void OnProduceDrink()
		{
		}

		// Token: 0x060196AD RID: 104109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196AD")]
		[Address(RVA = "0x121E700", Offset = "0x121D300", VA = "0x18121E700", Slot = "4")]
		public override void OnUpdateData(SandboxV2CharListViewModel viewModel)
		{
		}

		// Token: 0x060196AE RID: 104110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196AE")]
		[Address(RVA = "0x121EA50", Offset = "0x121D650", VA = "0x18121EA50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060196AF RID: 104111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196AF")]
		[Address(RVA = "0x121EB30", Offset = "0x121D730", VA = "0x18121EB30")]
		public SandboxV2CharSelectLogisticsEnsureView()
		{
		}

		// Token: 0x0401FA0F RID: 129551
		[Token(Token = "0x401FA0F")]
		private const string FORMAT_TOTAL_POPULATION = "/{0}";

		// Token: 0x0401FA10 RID: 129552
		[Token(Token = "0x401FA10")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtDuration;

		// Token: 0x0401FA11 RID: 129553
		[Token(Token = "0x401FA11")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtDrink;

		// Token: 0x0401FA12 RID: 129554
		[Token(Token = "0x401FA12")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtDrinkCapacity;

		// Token: 0x0401FA13 RID: 129555
		[Token(Token = "0x401FA13")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtPopulation;

		// Token: 0x0401FA14 RID: 129556
		[Token(Token = "0x401FA14")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtTotalPopulation;

		// Token: 0x0401FA15 RID: 129557
		[Token(Token = "0x401FA15")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgDrinkIcon;

		// Token: 0x0401FA16 RID: 129558
		[Token(Token = "0x401FA16")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroupNoDrink;

		// Token: 0x0401FA17 RID: 129559
		[Token(Token = "0x401FA17")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401FA18 RID: 129560
		[Token(Token = "0x401FA18")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_noDrinkSwitchTween;

		// Token: 0x0401FA19 RID: 129561
		[Token(Token = "0x401FA19")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FA1A RID: 129562
		[Token(Token = "0x401FA1A")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2CharListViewModel m_cachedViewModel;

		// Token: 0x0401FA1B RID: 129563
		[Token(Token = "0x401FA1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401FA1C RID: 129564
		[Token(Token = "0x401FA1C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClear;

		// Token: 0x0401FA1D RID: 129565
		[Token(Token = "0x401FA1D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProduceDrink;

		// Token: 0x0401FA1E RID: 129566
		[Token(Token = "0x401FA1E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUpdateData;

		// Token: 0x0401FA1F RID: 129567
		[Token(Token = "0x401FA1F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FA20 RID: 129568
		[Token(Token = "0x401FA20")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
