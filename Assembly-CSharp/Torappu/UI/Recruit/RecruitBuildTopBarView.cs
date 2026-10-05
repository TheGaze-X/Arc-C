using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004729 RID: 18217
	[Token(Token = "0x2004729")]
	public class RecruitBuildTopBarView : DataBinder<BuildTopBarProperty>
	{
		// Token: 0x0601B9C1 RID: 113089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9C1")]
		[Address(RVA = "0x14F9760", Offset = "0x14F8360", VA = "0x1814F9760", Slot = "7")]
		public override void OnValueChanged(BuildTopBarProperty property)
		{
		}

		// Token: 0x0601B9C2 RID: 113090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9C2")]
		[Address(RVA = "0x14F9950", Offset = "0x14F8550", VA = "0x1814F9950")]
		public RecruitBuildTopBarView()
		{
		}

		// Token: 0x04023C92 RID: 146578
		[Token(Token = "0x4023C92")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggleHasAct;

		// Token: 0x04023C93 RID: 146579
		[Token(Token = "0x4023C93")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _toggleUsed;

		// Token: 0x04023C94 RID: 146580
		[Token(Token = "0x4023C94")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _tagName;

		// Token: 0x04023C95 RID: 146581
		[Token(Token = "0x4023C95")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04023C96 RID: 146582
		[Token(Token = "0x4023C96")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _time;

		// Token: 0x04023C97 RID: 146583
		[Token(Token = "0x4023C97")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _descUsed;

		// Token: 0x04023C98 RID: 146584
		[Token(Token = "0x4023C98")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _timeUsed;

		// Token: 0x04023C99 RID: 146585
		[Token(Token = "0x4023C99")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _layout;

		// Token: 0x04023C9A RID: 146586
		[Token(Token = "0x4023C9A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _layoutUsed;

		// Token: 0x04023C9B RID: 146587
		[Token(Token = "0x4023C9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023C9C RID: 146588
		[Token(Token = "0x4023C9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
