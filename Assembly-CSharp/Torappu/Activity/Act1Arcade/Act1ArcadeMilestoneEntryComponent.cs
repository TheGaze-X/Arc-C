using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200794E RID: 31054
	[Token(Token = "0x200794E")]
	public class Act1ArcadeMilestoneEntryComponent : CustomPageActivityMilestoneEntryComponent
	{
		// Token: 0x1700662A RID: 26154
		// (get) Token: 0x0602B928 RID: 178472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700662A")]
		public override string param
		{
			[Token(Token = "0x602B928")]
			[Address(RVA = "0x2776B00", Offset = "0x2775700", VA = "0x182776B00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B929 RID: 178473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B929")]
		[Address(RVA = "0x27769B0", Offset = "0x27755B0", VA = "0x1827769B0", Slot = "8")]
		protected override void OnViewModelRefresh(TemplateActivityMilestoneGroupViewModel viewModel)
		{
		}

		// Token: 0x0602B92A RID: 178474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B92A")]
		[Address(RVA = "0x2776AA0", Offset = "0x27756A0", VA = "0x182776AA0")]
		public Act1ArcadeMilestoneEntryComponent()
		{
		}

		// Token: 0x0403F075 RID: 258165
		[Token(Token = "0x403F075")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _lvlNumText;

		// Token: 0x0403F076 RID: 258166
		[Token(Token = "0x403F076")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x0403F077 RID: 258167
		[Token(Token = "0x403F077")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403F078 RID: 258168
		[Token(Token = "0x403F078")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
