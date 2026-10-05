using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064AD RID: 25773
	[Token(Token = "0x20064AD")]
	public class AutoChessBattleUISettleEndingDialog : UICompDialog<AutoChessBattleUISettleEndingDialog.Input>, IValueMsgReceiver
	{
		// Token: 0x060250D8 RID: 151768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250D8")]
		[Address(RVA = "0x1FEDE60", Offset = "0x1FECA60", VA = "0x181FEDE60", Slot = "18")]
		protected override void OnRender(AutoChessBattleUISettleEndingDialog.Input input)
		{
		}

		// Token: 0x060250D9 RID: 151769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250D9")]
		[Address(RVA = "0x1FEE1A0", Offset = "0x1FECDA0", VA = "0x181FEE1A0")]
		private void _PlayAudio(AutoChessSettleDataModel.EndingStatus endingStatus)
		{
		}

		// Token: 0x060250DA RID: 151770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250DA")]
		[Address(RVA = "0x1FEDD50", Offset = "0x1FEC950", VA = "0x181FEDD50", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060250DB RID: 151771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250DB")]
		[Address(RVA = "0x1FEE2D0", Offset = "0x1FECED0", VA = "0x181FEE2D0")]
		public AutoChessBattleUISettleEndingDialog()
		{
		}

		// Token: 0x04033DF3 RID: 212467
		[Token(Token = "0x4033DF3")]
		[NonSerialized]
		public const float MAX_SHOW_TIME = 4f;

		// Token: 0x04033DF4 RID: 212468
		[Token(Token = "0x4033DF4")]
		[NonSerialized]
		public const int MSG_CLOSE_DIALOG = 1;

		// Token: 0x04033DF5 RID: 212469
		[Token(Token = "0x4033DF5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AutoChessBattleUISettleEndingView[] _endingPrefabList;

		// Token: 0x04033DF6 RID: 212470
		[Token(Token = "0x4033DF6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _viewRoot;

		// Token: 0x04033DF7 RID: 212471
		[Token(Token = "0x4033DF7")]
		[FieldOffset(Offset = "0x80")]
		private AutoChessBattleUISettleEndingView m_endingView;

		// Token: 0x04033DF8 RID: 212472
		[Token(Token = "0x4033DF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033DF9 RID: 212473
		[Token(Token = "0x4033DF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayAudio;

		// Token: 0x04033DFA RID: 212474
		[Token(Token = "0x4033DFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04033DFB RID: 212475
		[Token(Token = "0x4033DFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064AE RID: 25774
		[Token(Token = "0x20064AE")]
		public class Input
		{
			// Token: 0x060250DC RID: 151772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250DC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04033DFC RID: 212476
			[Token(Token = "0x4033DFC")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessSettleDataModel settleModel;
		}
	}
}
