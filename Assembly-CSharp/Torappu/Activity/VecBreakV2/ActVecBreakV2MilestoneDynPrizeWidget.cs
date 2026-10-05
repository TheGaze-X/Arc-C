using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E3C RID: 28220
	[Token(Token = "0x2006E3C")]
	public class ActVecBreakV2MilestoneDynPrizeWidget : TemplateActivityMilestoneDynPrizeWidget
	{
		// Token: 0x0602829F RID: 164511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602829F")]
		[Address(RVA = "0x2376A90", Offset = "0x2375690", VA = "0x182376A90", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel milestoneViewModel)
		{
		}

		// Token: 0x060282A0 RID: 164512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282A0")]
		[Address(RVA = "0x2376A00", Offset = "0x2375600", VA = "0x182376A00")]
		public void OnClickCharSkin()
		{
		}

		// Token: 0x060282A1 RID: 164513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282A1")]
		[Address(RVA = "0x2376E80", Offset = "0x2375A80", VA = "0x182376E80")]
		public ActVecBreakV2MilestoneDynPrizeWidget()
		{
		}

		// Token: 0x0403909B RID: 233627
		[Token(Token = "0x403909B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _skinNameText;

		// Token: 0x0403909C RID: 233628
		[Token(Token = "0x403909C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _skinCharNameText;

		// Token: 0x0403909D RID: 233629
		[Token(Token = "0x403909D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _skinLvText;

		// Token: 0x0403909E RID: 233630
		[Token(Token = "0x403909E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _furnNameText;

		// Token: 0x0403909F RID: 233631
		[Token(Token = "0x403909F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _furnLvText;

		// Token: 0x040390A0 RID: 233632
		[Token(Token = "0x40390A0")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040390A1 RID: 233633
		[Token(Token = "0x40390A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040390A2 RID: 233634
		[Token(Token = "0x40390A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickCharSkin;

		// Token: 0x040390A3 RID: 233635
		[Token(Token = "0x40390A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
