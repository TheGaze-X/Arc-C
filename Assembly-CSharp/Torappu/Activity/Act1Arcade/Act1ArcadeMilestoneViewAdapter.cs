using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007955 RID: 31061
	[Token(Token = "0x2007955")]
	public class Act1ArcadeMilestoneViewAdapter : DataBinder<Act1ArcadeMilestoneProperty>
	{
		// Token: 0x0602B94D RID: 178509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B94D")]
		[Address(RVA = "0x277E310", Offset = "0x277CF10", VA = "0x18277E310", Slot = "7")]
		public override void OnValueChanged(Act1ArcadeMilestoneProperty property)
		{
		}

		// Token: 0x0602B94E RID: 178510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B94E")]
		[Address(RVA = "0x277E290", Offset = "0x277CE90", VA = "0x18277E290")]
		public void FocusOnIndex(int idx)
		{
		}

		// Token: 0x0602B94F RID: 178511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B94F")]
		[Address(RVA = "0x277E3B0", Offset = "0x277CFB0", VA = "0x18277E3B0")]
		public Act1ArcadeMilestoneViewAdapter()
		{
		}

		// Token: 0x0403F09B RID: 258203
		[Token(Token = "0x403F09B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateActivityMilestoneHolder _holder;

		// Token: 0x0403F09C RID: 258204
		[Token(Token = "0x403F09C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F09D RID: 258205
		[Token(Token = "0x403F09D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FocusOnIndex;

		// Token: 0x0403F09E RID: 258206
		[Token(Token = "0x403F09E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
