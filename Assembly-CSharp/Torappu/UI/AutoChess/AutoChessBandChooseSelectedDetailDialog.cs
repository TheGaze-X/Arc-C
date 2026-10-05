using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006292 RID: 25234
	[Token(Token = "0x2006292")]
	public class AutoChessBandChooseSelectedDetailDialog : UICompDialog<AutoChessBandChooseSelectedDetailDialog.Input>, IHotfixable
	{
		// Token: 0x06024622 RID: 149026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024622")]
		[Address(RVA = "0x1F24C80", Offset = "0x1F23880", VA = "0x181F24C80", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06024623 RID: 149027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024623")]
		[Address(RVA = "0x1F24D50", Offset = "0x1F23950", VA = "0x181F24D50", Slot = "18")]
		protected override void OnRender(AutoChessBandChooseSelectedDetailDialog.Input input)
		{
		}

		// Token: 0x06024624 RID: 149028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024624")]
		[Address(RVA = "0x1F24BC0", Offset = "0x1F237C0", VA = "0x181F24BC0")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06024625 RID: 149029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024625")]
		[Address(RVA = "0x1F24FB0", Offset = "0x1F23BB0", VA = "0x181F24FB0")]
		public AutoChessBandChooseSelectedDetailDialog()
		{
		}

		// Token: 0x06024626 RID: 149030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024626")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x040329D2 RID: 207314
		[Token(Token = "0x40329D2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x040329D3 RID: 207315
		[Token(Token = "0x40329D3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textNickName;

		// Token: 0x040329D4 RID: 207316
		[Token(Token = "0x40329D4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textNickNum;

		// Token: 0x040329D5 RID: 207317
		[Token(Token = "0x40329D5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imgBandIcon;

		// Token: 0x040329D6 RID: 207318
		[Token(Token = "0x40329D6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textBandHp;

		// Token: 0x040329D7 RID: 207319
		[Token(Token = "0x40329D7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textBandName;

		// Token: 0x040329D8 RID: 207320
		[Token(Token = "0x40329D8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textBandDesc;

		// Token: 0x040329D9 RID: 207321
		[Token(Token = "0x40329D9")]
		[FieldOffset(Offset = "0xA8")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x040329DA RID: 207322
		[Token(Token = "0x40329DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040329DB RID: 207323
		[Token(Token = "0x40329DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040329DC RID: 207324
		[Token(Token = "0x40329DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x040329DD RID: 207325
		[Token(Token = "0x40329DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006293 RID: 25235
		[Token(Token = "0x2006293")]
		public class Input
		{
			// Token: 0x06024627 RID: 149031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024627")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x040329DE RID: 207326
			[Token(Token = "0x40329DE")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessBandChoosePlayerModel playerModel;
		}
	}
}
