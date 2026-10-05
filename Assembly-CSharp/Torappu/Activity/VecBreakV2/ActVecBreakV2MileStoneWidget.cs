using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E44 RID: 28228
	[Token(Token = "0x2006E44")]
	public class ActVecBreakV2MileStoneWidget : TemplateActivityMilestoneWithPrizeWidget
	{
		// Token: 0x060282BE RID: 164542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282BE")]
		[Address(RVA = "0x23766F0", Offset = "0x23752F0", VA = "0x1823766F0", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel model)
		{
		}

		// Token: 0x060282BF RID: 164543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282BF")]
		[Address(RVA = "0x23769A0", Offset = "0x23755A0", VA = "0x1823769A0")]
		public ActVecBreakV2MileStoneWidget()
		{
		}

		// Token: 0x060282C0 RID: 164544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282C0")]
		[Address(RVA = "0x2376990", Offset = "0x2375590", VA = "0x182376990")]
		private void <>xLuaBaseProxy_Render(TemplateActivityMilestoneGroupViewModel P0)
		{
		}

		// Token: 0x040390CD RID: 233677
		[Token(Token = "0x40390CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _maxTagGo;

		// Token: 0x040390CE RID: 233678
		[Token(Token = "0x40390CE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _lvNumText;

		// Token: 0x040390CF RID: 233679
		[Token(Token = "0x40390CF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Slider _progressBar;

		// Token: 0x040390D0 RID: 233680
		[Token(Token = "0x40390D0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _curPointText;

		// Token: 0x040390D1 RID: 233681
		[Token(Token = "0x40390D1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _maxPointText;

		// Token: 0x040390D2 RID: 233682
		[Token(Token = "0x40390D2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _progressMaxGo;

		// Token: 0x040390D3 RID: 233683
		[Token(Token = "0x40390D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040390D4 RID: 233684
		[Token(Token = "0x40390D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
