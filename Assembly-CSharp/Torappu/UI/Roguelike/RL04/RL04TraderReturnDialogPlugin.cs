using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200569E RID: 22174
	[Token(Token = "0x200569E")]
	public class RL04TraderReturnDialogPlugin : RoguelikeTopicDialogPlugin
	{
		// Token: 0x0602085F RID: 133215 RVA: 0x000B64A8 File Offset: 0x000B46A8
		[Token(Token = "0x602085F")]
		[Address(RVA = "0x1AB6B00", Offset = "0x1AB5700", VA = "0x181AB6B00", Slot = "4")]
		public override KeyValuePair<string, RoguelikeDialogMgr> GetDialogMgr()
		{
			return default(KeyValuePair<string, RoguelikeDialogMgr>);
		}

		// Token: 0x06020860 RID: 133216 RVA: 0x000B64C0 File Offset: 0x000B46C0
		[Token(Token = "0x6020860")]
		[Address(RVA = "0x1AB6C40", Offset = "0x1AB5840", VA = "0x181AB6C40")]
		private static bool _CheckTraderReturnFlag()
		{
			return default(bool);
		}

		// Token: 0x06020861 RID: 133217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020861")]
		[Address(RVA = "0x1AB6D10", Offset = "0x1AB5910", VA = "0x181AB6D10")]
		private static List<PlayerRoguelikeV2.CurrentData.PlayerStatus.ZoneRewardItem> _GetTraderRewardList()
		{
			return null;
		}

		// Token: 0x06020862 RID: 133218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020862")]
		[Address(RVA = "0x1AB7060", Offset = "0x1AB5C60", VA = "0x181AB7060")]
		private static IEnumerator _ShowTraderReturnDialog(string topicId)
		{
			return null;
		}

		// Token: 0x06020863 RID: 133219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020863")]
		[Address(RVA = "0x1AB7110", Offset = "0x1AB5D10", VA = "0x181AB7110")]
		public RL04TraderReturnDialogPlugin()
		{
		}

		// Token: 0x0402C131 RID: 180529
		[Token(Token = "0x402C131")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x0402C132 RID: 180530
		[Token(Token = "0x402C132")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckTraderReturnFlag;

		// Token: 0x0402C133 RID: 180531
		[Token(Token = "0x402C133")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetTraderRewardList;

		// Token: 0x0402C134 RID: 180532
		[Token(Token = "0x402C134")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowTraderReturnDialog;

		// Token: 0x0402C135 RID: 180533
		[Token(Token = "0x402C135")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200569F RID: 22175
		[Token(Token = "0x200569F")]
		public class TraderDialogMgr : RoguelikeDialogMgr
		{
			// Token: 0x06020864 RID: 133220 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020864")]
			[Address(RVA = "0x1AB7F70", Offset = "0x1AB6B70", VA = "0x181AB7F70", Slot = "4")]
			public override IEnumerator OnShowDialog(UICompDialogMgr compDialogMgr, string topicId)
			{
				return null;
			}

			// Token: 0x06020865 RID: 133221 RVA: 0x000B64D8 File Offset: 0x000B46D8
			[Token(Token = "0x6020865")]
			[Address(RVA = "0x1AB7D20", Offset = "0x1AB6920", VA = "0x181AB7D20", Slot = "5")]
			public override bool OnCheckNeedShowDialog(string topicId, List<SortableString> sortableList)
			{
				return default(bool);
			}

			// Token: 0x06020866 RID: 133222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020866")]
			[Address(RVA = "0x1AB8040", Offset = "0x1AB6C40", VA = "0x181AB8040")]
			public TraderDialogMgr()
			{
			}

			// Token: 0x0402C136 RID: 180534
			[Token(Token = "0x402C136")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnShowDialog;

			// Token: 0x0402C137 RID: 180535
			[Token(Token = "0x402C137")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnCheckNeedShowDialog;

			// Token: 0x0402C138 RID: 180536
			[Token(Token = "0x402C138")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
