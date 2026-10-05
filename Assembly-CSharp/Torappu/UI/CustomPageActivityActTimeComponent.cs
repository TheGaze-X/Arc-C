using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A9D RID: 15005
	[Token(Token = "0x2003A9D")]
	public class CustomPageActivityActTimeComponent : CustomPageActivityComponent
	{
		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x06017B5C RID: 97116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038E2")]
		public override string param
		{
			[Token(Token = "0x6017B5C")]
			[Address(RVA = "0xFE45A0", Offset = "0xFE31A0", VA = "0x180FE45A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017B5D RID: 97117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B5D")]
		[Address(RVA = "0xFE4050", Offset = "0xFE2C50", VA = "0x180FE4050", Slot = "6")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06017B5E RID: 97118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B5E")]
		[Address(RVA = "0xFE44E0", Offset = "0xFE30E0", VA = "0x180FE44E0")]
		public CustomPageActivityActTimeComponent()
		{
		}

		// Token: 0x0401C9D1 RID: 117201
		[Token(Token = "0x401C9D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AbstractStageTime _stageTime;

		// Token: 0x0401C9D2 RID: 117202
		[Token(Token = "0x401C9D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbstractRemainTime _remainTime;

		// Token: 0x0401C9D3 RID: 117203
		[Token(Token = "0x401C9D3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _endTime;

		// Token: 0x0401C9D4 RID: 117204
		[Token(Token = "0x401C9D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[ReadOnly]
		private string _param;

		// Token: 0x0401C9D5 RID: 117205
		[Token(Token = "0x401C9D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x0401C9D6 RID: 117206
		[Token(Token = "0x401C9D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0401C9D7 RID: 117207
		[Token(Token = "0x401C9D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
