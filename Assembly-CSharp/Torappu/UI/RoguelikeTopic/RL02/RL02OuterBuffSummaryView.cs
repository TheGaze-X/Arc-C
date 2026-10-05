using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004624 RID: 17956
	[Token(Token = "0x2004624")]
	public class RL02OuterBuffSummaryView : DataBinder<RL02OuterBuffListProperty>, IHotfixable
	{
		// Token: 0x1700410A RID: 16650
		// (get) Token: 0x0601B49B RID: 111771 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B49C RID: 111772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700410A")]
		public Action onBackBtnClicked
		{
			[Token(Token = "0x601B49B")]
			[Address(RVA = "0x14A2300", Offset = "0x14A0F00", VA = "0x1814A2300")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B49C")]
			[Address(RVA = "0x14A2360", Offset = "0x14A0F60", VA = "0x1814A2360")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B49D RID: 111773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B49D")]
		[Address(RVA = "0x14A1F30", Offset = "0x14A0B30", VA = "0x1814A1F30")]
		public void OnInit(UIPage page)
		{
		}

		// Token: 0x0601B49E RID: 111774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B49E")]
		[Address(RVA = "0x14A2100", Offset = "0x14A0D00", VA = "0x1814A2100", Slot = "7")]
		public override void OnValueChanged(RL02OuterBuffListProperty property)
		{
		}

		// Token: 0x0601B49F RID: 111775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B49F")]
		[Address(RVA = "0x14A1E20", Offset = "0x14A0A20", VA = "0x1814A1E20")]
		public void OnBackClicked()
		{
		}

		// Token: 0x0601B4A0 RID: 111776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4A0")]
		[Address(RVA = "0x14A2260", Offset = "0x14A0E60", VA = "0x1814A2260")]
		public RL02OuterBuffSummaryView()
		{
		}

		// Token: 0x0402339E RID: 144286
		[Token(Token = "0x402339E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL02OuterBuffSummaryMergedGroupView _mergedBuffView;

		// Token: 0x0402339F RID: 144287
		[Token(Token = "0x402339F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL02OuterBuffSummaryRawTextNodeGroupView _rawTextNodeNodeBuffView;

		// Token: 0x040233A0 RID: 144288
		[Token(Token = "0x40233A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x040233A1 RID: 144289
		[Token(Token = "0x40233A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _formatProgress;

		// Token: 0x040233A2 RID: 144290
		[Token(Token = "0x40233A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _backBtnRaycast;

		// Token: 0x040233A4 RID: 144292
		[Token(Token = "0x40233A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBackBtnClicked;

		// Token: 0x040233A5 RID: 144293
		[Token(Token = "0x40233A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBackBtnClicked;

		// Token: 0x040233A6 RID: 144294
		[Token(Token = "0x40233A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040233A7 RID: 144295
		[Token(Token = "0x40233A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040233A8 RID: 144296
		[Token(Token = "0x40233A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x040233A9 RID: 144297
		[Token(Token = "0x40233A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
