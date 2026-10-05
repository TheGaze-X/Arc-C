using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039B7 RID: 14775
	[Token(Token = "0x20039B7")]
	public class SetDateView : DataBinder<SetDateProperty>
	{
		// Token: 0x0601758F RID: 95631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601758F")]
		[Address(RVA = "0xFB7680", Offset = "0xFB6280", VA = "0x180FB7680", Slot = "7")]
		public override void OnValueChanged(SetDateProperty property)
		{
		}

		// Token: 0x06017590 RID: 95632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017590")]
		[Address(RVA = "0xFB7830", Offset = "0xFB6430", VA = "0x180FB7830")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017591 RID: 95633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017591")]
		[Address(RVA = "0xFB7900", Offset = "0xFB6500", VA = "0x180FB7900")]
		public SetDateView()
		{
		}

		// Token: 0x0401C310 RID: 115472
		[Token(Token = "0x401C310")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SetDatePagerView _monthPagerView;

		// Token: 0x0401C311 RID: 115473
		[Token(Token = "0x401C311")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SetDatePagerView _dayPagerView;

		// Token: 0x0401C312 RID: 115474
		[Token(Token = "0x401C312")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SetDateItemView _itemPrefab;

		// Token: 0x0401C313 RID: 115475
		[Token(Token = "0x401C313")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<int> onMonthItemClicked;

		// Token: 0x0401C314 RID: 115476
		[Token(Token = "0x401C314")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<int> onDayItemClicked;

		// Token: 0x0401C315 RID: 115477
		[Token(Token = "0x401C315")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401C316 RID: 115478
		[Token(Token = "0x401C316")]
		[FieldOffset(Offset = "0x4C")]
		private int m_cachedMonthIdx;

		// Token: 0x0401C317 RID: 115479
		[Token(Token = "0x401C317")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401C318 RID: 115480
		[Token(Token = "0x401C318")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C319 RID: 115481
		[Token(Token = "0x401C319")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
