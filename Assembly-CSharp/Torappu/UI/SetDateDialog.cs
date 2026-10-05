using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039AF RID: 14767
	[Token(Token = "0x20039AF")]
	public class SetDateDialog : UICompDialog<SetDateDialog.Option>
	{
		// Token: 0x06017572 RID: 95602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017572")]
		[Address(RVA = "0xFB5D30", Offset = "0xFB4930", VA = "0x180FB5D30")]
		public void DismissSelf()
		{
		}

		// Token: 0x06017573 RID: 95603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017573")]
		[Address(RVA = "0xFB5B10", Offset = "0xFB4710", VA = "0x180FB5B10")]
		public void ConfirmDate()
		{
		}

		// Token: 0x06017574 RID: 95604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017574")]
		[Address(RVA = "0xFB5DF0", Offset = "0xFB49F0", VA = "0x180FB5DF0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06017575 RID: 95605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017575")]
		[Address(RVA = "0xFB5FE0", Offset = "0xFB4BE0", VA = "0x180FB5FE0", Slot = "18")]
		protected override void OnRender(SetDateDialog.Option options)
		{
		}

		// Token: 0x06017576 RID: 95606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017576")]
		[Address(RVA = "0xFB6280", Offset = "0xFB4E80", VA = "0x180FB6280")]
		private void _OnMonthItemClicked(int monthPageIdx)
		{
		}

		// Token: 0x06017577 RID: 95607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017577")]
		[Address(RVA = "0xFB61A0", Offset = "0xFB4DA0", VA = "0x180FB61A0")]
		private void _OnDayItemClicked(int dayPageIdx)
		{
		}

		// Token: 0x06017578 RID: 95608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017578")]
		[Address(RVA = "0xFB6370", Offset = "0xFB4F70", VA = "0x180FB6370")]
		public SetDateDialog()
		{
		}

		// Token: 0x06017579 RID: 95609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017579")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0401C2D7 RID: 115415
		[Token(Token = "0x401C2D7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0401C2D8 RID: 115416
		[Token(Token = "0x401C2D8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0401C2D9 RID: 115417
		[Token(Token = "0x401C2D9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SetDateView _view;

		// Token: 0x0401C2DA RID: 115418
		[Token(Token = "0x401C2DA")]
		[FieldOffset(Offset = "0x88")]
		private SetDateProperty m_prop;

		// Token: 0x0401C2DB RID: 115419
		[Token(Token = "0x401C2DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DismissSelf;

		// Token: 0x0401C2DC RID: 115420
		[Token(Token = "0x401C2DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConfirmDate;

		// Token: 0x0401C2DD RID: 115421
		[Token(Token = "0x401C2DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401C2DE RID: 115422
		[Token(Token = "0x401C2DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401C2DF RID: 115423
		[Token(Token = "0x401C2DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnMonthItemClicked;

		// Token: 0x0401C2E0 RID: 115424
		[Token(Token = "0x401C2E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnDayItemClicked;

		// Token: 0x0401C2E1 RID: 115425
		[Token(Token = "0x401C2E1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039B0 RID: 14768
		[Token(Token = "0x20039B0")]
		public class Option
		{
			// Token: 0x0601757A RID: 95610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601757A")]
			[Address(RVA = "0xFB1E50", Offset = "0xFB0A50", VA = "0x180FB1E50")]
			public Option()
			{
			}

			// Token: 0x0401C2E2 RID: 115426
			[Token(Token = "0x401C2E2")]
			[FieldOffset(Offset = "0x10")]
			public string titleStr;

			// Token: 0x0401C2E3 RID: 115427
			[Token(Token = "0x401C2E3")]
			[FieldOffset(Offset = "0x18")]
			public int initMonth;

			// Token: 0x0401C2E4 RID: 115428
			[Token(Token = "0x401C2E4")]
			[FieldOffset(Offset = "0x1C")]
			public int initDay;
		}

		// Token: 0x020039B1 RID: 14769
		[Token(Token = "0x20039B1")]
		public class DateResult
		{
			// Token: 0x0601757B RID: 95611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601757B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DateResult()
			{
			}

			// Token: 0x0401C2E5 RID: 115429
			[Token(Token = "0x401C2E5")]
			[FieldOffset(Offset = "0x10")]
			public int month;

			// Token: 0x0401C2E6 RID: 115430
			[Token(Token = "0x401C2E6")]
			[FieldOffset(Offset = "0x14")]
			public int day;
		}
	}
}
