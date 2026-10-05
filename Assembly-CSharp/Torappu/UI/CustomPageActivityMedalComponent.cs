using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A9F RID: 15007
	[Token(Token = "0x2003A9F")]
	public class CustomPageActivityMedalComponent : CustomPageActivityComponent, IHotfixable
	{
		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x06017B63 RID: 97123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038E4")]
		public override string param
		{
			[Token(Token = "0x6017B63")]
			[Address(RVA = "0xFE5810", Offset = "0xFE4410", VA = "0x180FE5810", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017B64 RID: 97124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B64")]
		[Address(RVA = "0xFE54B0", Offset = "0xFE40B0", VA = "0x180FE54B0", Slot = "6")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06017B65 RID: 97125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B65")]
		[Address(RVA = "0xFE5740", Offset = "0xFE4340", VA = "0x180FE5740")]
		public CustomPageActivityMedalComponent()
		{
		}

		// Token: 0x0401C9DB RID: 117211
		[Token(Token = "0x401C9DB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color PROGRESS_DEFAULT_COLOR;

		// Token: 0x0401C9DC RID: 117212
		[Token(Token = "0x401C9DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0401C9DD RID: 117213
		[Token(Token = "0x401C9DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x0401C9DE RID: 117214
		[Token(Token = "0x401C9DE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _progressColor;

		// Token: 0x0401C9DF RID: 117215
		[Token(Token = "0x401C9DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x0401C9E0 RID: 117216
		[Token(Token = "0x401C9E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0401C9E1 RID: 117217
		[Token(Token = "0x401C9E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
