using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004713 RID: 18195
	[Token(Token = "0x2004713")]
	public class RecruitUpCharSlotSelectDialogView : DataBinder<RecruitUpCharSlotSelectViewProperty>
	{
		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x0601B955 RID: 112981 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B954 RID: 112980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041A9")]
		public Action<int> onCardClick
		{
			[Token(Token = "0x601B955")]
			[Address(RVA = "0x14ED540", Offset = "0x14EC140", VA = "0x1814ED540")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B954")]
			[Address(RVA = "0x14ED5A0", Offset = "0x14EC1A0", VA = "0x1814ED5A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B956 RID: 112982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B956")]
		[Address(RVA = "0x14ED1F0", Offset = "0x14EBDF0", VA = "0x1814ED1F0", Slot = "7")]
		public override void OnValueChanged(RecruitUpCharSlotSelectViewProperty property)
		{
		}

		// Token: 0x0601B957 RID: 112983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B957")]
		[Address(RVA = "0x14ED4D0", Offset = "0x14EC0D0", VA = "0x1814ED4D0")]
		public RecruitUpCharSlotSelectDialogView()
		{
		}

		// Token: 0x04023BB5 RID: 146357
		[Token(Token = "0x4023BB5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<RecruitUpCharSlotSelectCard> _selectCards;

		// Token: 0x04023BB6 RID: 146358
		[Token(Token = "0x4023BB6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _btnConfirm;

		// Token: 0x04023BB8 RID: 146360
		[Token(Token = "0x4023BB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onCardClick;

		// Token: 0x04023BB9 RID: 146361
		[Token(Token = "0x4023BB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onCardClick;

		// Token: 0x04023BBA RID: 146362
		[Token(Token = "0x4023BBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023BBB RID: 146363
		[Token(Token = "0x4023BBB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
