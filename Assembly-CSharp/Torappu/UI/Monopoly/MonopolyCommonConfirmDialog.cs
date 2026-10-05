using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047E1 RID: 18401
	[Token(Token = "0x20047E1")]
	public class MonopolyCommonConfirmDialog : UICompDialog<MonopolyCommonConfirmDialog.Option>
	{
		// Token: 0x0601BD6E RID: 114030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD6E")]
		[Address(RVA = "0x1523A40", Offset = "0x1522640", VA = "0x181523A40", Slot = "18")]
		protected override void OnRender(MonopolyCommonConfirmDialog.Option options)
		{
		}

		// Token: 0x0601BD6F RID: 114031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD6F")]
		[Address(RVA = "0x15237E0", Offset = "0x15223E0", VA = "0x1815237E0")]
		public void EventOnCancelClick()
		{
		}

		// Token: 0x0601BD70 RID: 114032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD70")]
		[Address(RVA = "0x15238D0", Offset = "0x15224D0", VA = "0x1815238D0")]
		public void EventOnConfirmClick()
		{
		}

		// Token: 0x0601BD71 RID: 114033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD71")]
		[Address(RVA = "0x15239C0", Offset = "0x15225C0", VA = "0x1815239C0")]
		public void EventOnSkipDialogToggleClick()
		{
		}

		// Token: 0x0601BD72 RID: 114034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD72")]
		[Address(RVA = "0x1523B70", Offset = "0x1522770", VA = "0x181523B70")]
		public MonopolyCommonConfirmDialog()
		{
		}

		// Token: 0x0402439E RID: 148382
		[Token(Token = "0x402439E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402439F RID: 148383
		[Token(Token = "0x402439F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _skipDialogToggleGo;

		// Token: 0x040243A0 RID: 148384
		[Token(Token = "0x40243A0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TwoStateToggle _skipDialogToggle;

		// Token: 0x040243A1 RID: 148385
		[Token(Token = "0x40243A1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _skipDialogDesc;

		// Token: 0x040243A2 RID: 148386
		[Token(Token = "0x40243A2")]
		[FieldOffset(Offset = "0x90")]
		private bool m_skipDialogSelected;

		// Token: 0x040243A3 RID: 148387
		[Token(Token = "0x40243A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040243A4 RID: 148388
		[Token(Token = "0x40243A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCancelClick;

		// Token: 0x040243A5 RID: 148389
		[Token(Token = "0x40243A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClick;

		// Token: 0x040243A6 RID: 148390
		[Token(Token = "0x40243A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnSkipDialogToggleClick;

		// Token: 0x040243A7 RID: 148391
		[Token(Token = "0x40243A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047E2 RID: 18402
		[Token(Token = "0x20047E2")]
		public class Option
		{
			// Token: 0x0601BD73 RID: 114035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BD73")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x040243A8 RID: 148392
			[Token(Token = "0x40243A8")]
			[FieldOffset(Offset = "0x10")]
			public string desc;

			// Token: 0x040243A9 RID: 148393
			[Token(Token = "0x40243A9")]
			[FieldOffset(Offset = "0x18")]
			public bool showSkipDialogToggle;

			// Token: 0x040243AA RID: 148394
			[Token(Token = "0x40243AA")]
			[FieldOffset(Offset = "0x20")]
			public string skipDialogDesc;
		}

		// Token: 0x020047E3 RID: 18403
		[Token(Token = "0x20047E3")]
		public class Output
		{
			// Token: 0x0601BD74 RID: 114036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BD74")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Output()
			{
			}

			// Token: 0x040243AB RID: 148395
			[Token(Token = "0x40243AB")]
			[FieldOffset(Offset = "0x10")]
			public bool isConfirm;

			// Token: 0x040243AC RID: 148396
			[Token(Token = "0x40243AC")]
			[FieldOffset(Offset = "0x11")]
			public bool isSkipDialogToggleSelect;
		}
	}
}
