using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077BF RID: 30655
	[Token(Token = "0x20077BF")]
	public class Act1VHalfIdleMilestoneWidget : TemplateActivityMilestoneWidget
	{
		// Token: 0x0602B07B RID: 176251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B07B")]
		[Address(RVA = "0x26DA170", Offset = "0x26D8D70", VA = "0x1826DA170", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel milestoneViewModel)
		{
		}

		// Token: 0x0602B07C RID: 176252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B07C")]
		[Address(RVA = "0x26DA7F0", Offset = "0x26D93F0", VA = "0x1826DA7F0")]
		private void _RenderSkinReward(TemplateActivityMilestoneGroupViewModel milestoneViewModel)
		{
		}

		// Token: 0x0602B07D RID: 176253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B07D")]
		[Address(RVA = "0x26DA640", Offset = "0x26D9240", VA = "0x1826DA640")]
		private void _RenderFurnReward(TemplateActivityMilestoneGroupViewModel milestoneViewModel)
		{
		}

		// Token: 0x0602B07E RID: 176254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B07E")]
		[Address(RVA = "0x26DA0E0", Offset = "0x26D8CE0", VA = "0x1826DA0E0")]
		public void OnSkinRewardPreviewClick()
		{
		}

		// Token: 0x0602B07F RID: 176255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B07F")]
		[Address(RVA = "0x26DAA20", Offset = "0x26D9620", VA = "0x1826DAA20")]
		public Act1VHalfIdleMilestoneWidget()
		{
		}

		// Token: 0x0403E22A RID: 254506
		[Token(Token = "0x403E22A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textSkinName;

		// Token: 0x0403E22B RID: 254507
		[Token(Token = "0x403E22B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCharName;

		// Token: 0x0403E22C RID: 254508
		[Token(Token = "0x403E22C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textSkinNeed;

		// Token: 0x0403E22D RID: 254509
		[Token(Token = "0x403E22D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textFurnName;

		// Token: 0x0403E22E RID: 254510
		[Token(Token = "0x403E22E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textFurnNeed;

		// Token: 0x0403E22F RID: 254511
		[Token(Token = "0x403E22F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0403E230 RID: 254512
		[Token(Token = "0x403E230")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textProgressMax;

		// Token: 0x0403E231 RID: 254513
		[Token(Token = "0x403E231")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0403E232 RID: 254514
		[Token(Token = "0x403E232")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _levelObj;

		// Token: 0x0403E233 RID: 254515
		[Token(Token = "0x403E233")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objMax;

		// Token: 0x0403E234 RID: 254516
		[Token(Token = "0x403E234")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x0403E235 RID: 254517
		[Token(Token = "0x403E235")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403E236 RID: 254518
		[Token(Token = "0x403E236")]
		[FieldOffset(Offset = "0x80")]
		private string m_furnId;

		// Token: 0x0403E237 RID: 254519
		[Token(Token = "0x403E237")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E238 RID: 254520
		[Token(Token = "0x403E238")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSkinReward;

		// Token: 0x0403E239 RID: 254521
		[Token(Token = "0x403E239")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderFurnReward;

		// Token: 0x0403E23A RID: 254522
		[Token(Token = "0x403E23A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSkinRewardPreviewClick;

		// Token: 0x0403E23B RID: 254523
		[Token(Token = "0x403E23B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
