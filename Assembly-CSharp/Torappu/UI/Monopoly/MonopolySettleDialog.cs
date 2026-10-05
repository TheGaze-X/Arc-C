using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004835 RID: 18485
	[Token(Token = "0x2004835")]
	public class MonopolySettleDialog : UICompDialog<MonopolySettleDialog.Input>, IValueMsgReceiver
	{
		// Token: 0x0601BEE1 RID: 114401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEE1")]
		[Address(RVA = "0x155B4A0", Offset = "0x155A0A0", VA = "0x18155B4A0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601BEE2 RID: 114402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEE2")]
		[Address(RVA = "0x155B760", Offset = "0x155A360", VA = "0x18155B760", Slot = "18")]
		protected override void OnRender(MonopolySettleDialog.Input input)
		{
		}

		// Token: 0x0601BEE3 RID: 114403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEE3")]
		[Address(RVA = "0x155B520", Offset = "0x155A120", VA = "0x18155B520", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601BEE4 RID: 114404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEE4")]
		[Address(RVA = "0x155B8B0", Offset = "0x155A4B0", VA = "0x18155B8B0")]
		private void _OnClickContinue()
		{
		}

		// Token: 0x0601BEE5 RID: 114405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEE5")]
		[Address(RVA = "0x155BA60", Offset = "0x155A660", VA = "0x18155BA60")]
		public MonopolySettleDialog()
		{
		}

		// Token: 0x0601BEE7 RID: 114407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEE7")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x040246A4 RID: 149156
		[Token(Token = "0x40246A4")]
		[NonSerialized]
		public const int ON_CLICK_CONTINUE_BTN = 1;

		// Token: 0x040246A5 RID: 149157
		[Token(Token = "0x40246A5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MonopolySettleView _view;

		// Token: 0x040246A6 RID: 149158
		[Token(Token = "0x40246A6")]
		[FieldOffset(Offset = "0x78")]
		private MonopolySettleProperty m_property;

		// Token: 0x040246A7 RID: 149159
		[Token(Token = "0x40246A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040246A8 RID: 149160
		[Token(Token = "0x40246A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040246A9 RID: 149161
		[Token(Token = "0x40246A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040246AA RID: 149162
		[Token(Token = "0x40246AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnClickContinue;

		// Token: 0x040246AB RID: 149163
		[Token(Token = "0x40246AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004836 RID: 18486
		[Token(Token = "0x2004836")]
		public class Input
		{
			// Token: 0x0601BEE8 RID: 114408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BEE8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x040246AC RID: 149164
			[Token(Token = "0x40246AC")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x040246AD RID: 149165
			[Token(Token = "0x40246AD")]
			[FieldOffset(Offset = "0x18")]
			public MonopolySettleGameResponse settleResp;
		}
	}
}
