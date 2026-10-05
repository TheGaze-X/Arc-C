using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D39 RID: 19769
	[Token(Token = "0x2004D39")]
	public class MagneticDotSliderViewModel : IHotfixable
	{
		// Token: 0x1700457D RID: 17789
		// (get) Token: 0x0601D97C RID: 121212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700457D")]
		public List<MagneticDotItemViewModel> dotItemList
		{
			[Token(Token = "0x601D97C")]
			[Address(RVA = "0x1733FD0", Offset = "0x1732BD0", VA = "0x181733FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D97D RID: 121213 RVA: 0x000AC0E0 File Offset: 0x000AA2E0
		[Token(Token = "0x601D97D")]
		[Address(RVA = "0x1733B30", Offset = "0x1732730", VA = "0x181733B30")]
		public int GetSelectIndex()
		{
			return 0;
		}

		// Token: 0x0601D97E RID: 121214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D97E")]
		[Address(RVA = "0x1733B90", Offset = "0x1732790", VA = "0x181733B90")]
		public void LoadData(List<int> input)
		{
		}

		// Token: 0x0601D97F RID: 121215 RVA: 0x000AC0F8 File Offset: 0x000AA2F8
		[Token(Token = "0x601D97F")]
		[Address(RVA = "0x1733DC0", Offset = "0x17329C0", VA = "0x181733DC0")]
		public bool UpdateSelection(float curIndex, float dotBias)
		{
			return default(bool);
		}

		// Token: 0x0601D980 RID: 121216 RVA: 0x000AC110 File Offset: 0x000AA310
		[Token(Token = "0x601D980")]
		[Address(RVA = "0x1733A60", Offset = "0x1732660", VA = "0x181733A60")]
		public int GetCurValue()
		{
			return 0;
		}

		// Token: 0x0601D981 RID: 121217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D981")]
		[Address(RVA = "0x1733F10", Offset = "0x1732B10", VA = "0x181733F10")]
		public MagneticDotSliderViewModel()
		{
		}

		// Token: 0x04027156 RID: 160086
		[Token(Token = "0x4027156")]
		[FieldOffset(Offset = "0x10")]
		private List<MagneticDotItemViewModel> m_dotItemList;

		// Token: 0x04027157 RID: 160087
		[Token(Token = "0x4027157")]
		[FieldOffset(Offset = "0x18")]
		private int m_selectIndex;

		// Token: 0x04027158 RID: 160088
		[Token(Token = "0x4027158")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dotItemList;

		// Token: 0x04027159 RID: 160089
		[Token(Token = "0x4027159")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSelectIndex;

		// Token: 0x0402715A RID: 160090
		[Token(Token = "0x402715A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402715B RID: 160091
		[Token(Token = "0x402715B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateSelection;

		// Token: 0x0402715C RID: 160092
		[Token(Token = "0x402715C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCurValue;

		// Token: 0x0402715D RID: 160093
		[Token(Token = "0x402715D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
