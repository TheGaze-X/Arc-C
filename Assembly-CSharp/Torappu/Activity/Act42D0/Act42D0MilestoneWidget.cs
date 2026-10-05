using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073A1 RID: 29601
	[Token(Token = "0x20073A1")]
	public class Act42D0MilestoneWidget : TemplateActivityMilestoneWidget
	{
		// Token: 0x06029D7C RID: 171388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D7C")]
		[Address(RVA = "0x2572890", Offset = "0x2571490", VA = "0x182572890", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel milestoneViewModel)
		{
		}

		// Token: 0x06029D7D RID: 171389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D7D")]
		[Address(RVA = "0x2572D50", Offset = "0x2571950", VA = "0x182572D50")]
		public Act42D0MilestoneWidget()
		{
		}

		// Token: 0x0403BF43 RID: 245571
		[Token(Token = "0x403BF43")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textSkinName;

		// Token: 0x0403BF44 RID: 245572
		[Token(Token = "0x403BF44")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCharName;

		// Token: 0x0403BF45 RID: 245573
		[Token(Token = "0x403BF45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textSkinNeed;

		// Token: 0x0403BF46 RID: 245574
		[Token(Token = "0x403BF46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textMilestoneAreaName;

		// Token: 0x0403BF47 RID: 245575
		[Token(Token = "0x403BF47")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0403BF48 RID: 245576
		[Token(Token = "0x403BF48")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0403BF49 RID: 245577
		[Token(Token = "0x403BF49")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objMax;

		// Token: 0x0403BF4A RID: 245578
		[Token(Token = "0x403BF4A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x0403BF4B RID: 245579
		[Token(Token = "0x403BF4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BF4C RID: 245580
		[Token(Token = "0x403BF4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
