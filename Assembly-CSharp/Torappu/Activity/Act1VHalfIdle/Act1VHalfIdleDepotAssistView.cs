using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200778B RID: 30603
	[Token(Token = "0x200778B")]
	public class Act1VHalfIdleDepotAssistView : DataBinder<Act1VHalfIdleDepotAssistProperty>
	{
		// Token: 0x0602AFA8 RID: 176040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFA8")]
		[Address(RVA = "0x26C6700", Offset = "0x26C5300", VA = "0x1826C6700")]
		private void _InitIfNot(string actId)
		{
		}

		// Token: 0x0602AFA9 RID: 176041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFA9")]
		[Address(RVA = "0x26C6560", Offset = "0x26C5160", VA = "0x1826C6560", Slot = "7")]
		public override void OnValueChanged(Act1VHalfIdleDepotAssistProperty property)
		{
		}

		// Token: 0x0602AFAA RID: 176042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFAA")]
		[Address(RVA = "0x26C68E0", Offset = "0x26C54E0", VA = "0x1826C68E0")]
		public Act1VHalfIdleDepotAssistView()
		{
		}

		// Token: 0x0403E04A RID: 254026
		[Token(Token = "0x403E04A")]
		private const int MAX_ASSIST_SLOT_NUM = 4;

		// Token: 0x0403E04B RID: 254027
		[Token(Token = "0x403E04B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1VHalfIdleDepotAssistSlotView _slotViewAsset;

		// Token: 0x0403E04C RID: 254028
		[Token(Token = "0x403E04C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _slotViewRoot;

		// Token: 0x0403E04D RID: 254029
		[Token(Token = "0x403E04D")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<int> onClickAssist;

		// Token: 0x0403E04E RID: 254030
		[Token(Token = "0x403E04E")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<int> onClickClear;

		// Token: 0x0403E04F RID: 254031
		[Token(Token = "0x403E04F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403E050 RID: 254032
		[Token(Token = "0x403E050")]
		[FieldOffset(Offset = "0x48")]
		private Act1VHalfIdleDepotAssistSlotView[] m_slotView;

		// Token: 0x0403E051 RID: 254033
		[Token(Token = "0x403E051")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E052 RID: 254034
		[Token(Token = "0x403E052")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E053 RID: 254035
		[Token(Token = "0x403E053")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
