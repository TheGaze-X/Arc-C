using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005212 RID: 21010
	[Token(Token = "0x2005212")]
	public class RoguelikeZoneRewardDialogPlugin : IHotfixable
	{
		// Token: 0x0601F01B RID: 127003 RVA: 0x000B0700 File Offset: 0x000AE900
		[Token(Token = "0x601F01B")]
		[Address(RVA = "0x18C3660", Offset = "0x18C2260", VA = "0x1818C3660")]
		public static bool CheckOpenFlag(RoguelikeGameItemType showItemType)
		{
			return default(bool);
		}

		// Token: 0x0601F01C RID: 127004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F01C")]
		[Address(RVA = "0x18C37A0", Offset = "0x18C23A0", VA = "0x1818C37A0")]
		public static List<string> GetRewardList(RoguelikeGameItemType showItemType)
		{
			return null;
		}

		// Token: 0x0601F01D RID: 127005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F01D")]
		[Address(RVA = "0x18C3A90", Offset = "0x18C2690", VA = "0x1818C3A90")]
		public static IEnumerator ShowDialog(string topicId, IRoguelikeZoneRewardDialogConfig config)
		{
			return null;
		}

		// Token: 0x0601F01E RID: 127006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F01E")]
		[Address(RVA = "0x18C3B60", Offset = "0x18C2760", VA = "0x1818C3B60")]
		public RoguelikeZoneRewardDialogPlugin()
		{
		}

		// Token: 0x04029989 RID: 170377
		[Token(Token = "0x4029989")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckOpenFlag;

		// Token: 0x0402998A RID: 170378
		[Token(Token = "0x402998A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRewardList;

		// Token: 0x0402998B RID: 170379
		[Token(Token = "0x402998B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowDialog;

		// Token: 0x0402998C RID: 170380
		[Token(Token = "0x402998C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005213 RID: 21011
		[Token(Token = "0x2005213")]
		public class DialogMgr : RoguelikeDialogMgr
		{
			// Token: 0x0601F01F RID: 127007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F01F")]
			[Address(RVA = "0x18AE8D0", Offset = "0x18AD4D0", VA = "0x1818AE8D0", Slot = "4")]
			public override IEnumerator OnShowDialog(UICompDialogMgr compDialogMgr, string topicId)
			{
				return null;
			}

			// Token: 0x0601F020 RID: 127008 RVA: 0x000B0718 File Offset: 0x000AE918
			[Token(Token = "0x601F020")]
			[Address(RVA = "0x18AD960", Offset = "0x18AC560", VA = "0x1818AD960", Slot = "5")]
			public override bool OnCheckNeedShowDialog(string topicId, List<SortableString> sortableList)
			{
				return default(bool);
			}

			// Token: 0x0601F021 RID: 127009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F021")]
			[Address(RVA = "0x18AE9B0", Offset = "0x18AD5B0", VA = "0x1818AE9B0")]
			public DialogMgr(Type configType)
			{
			}

			// Token: 0x0402998D RID: 170381
			[Token(Token = "0x402998D")]
			[FieldOffset(Offset = "0x10")]
			private IRoguelikeZoneRewardDialogConfig m_config;

			// Token: 0x0402998E RID: 170382
			[Token(Token = "0x402998E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnShowDialog;

			// Token: 0x0402998F RID: 170383
			[Token(Token = "0x402998F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnCheckNeedShowDialog;

			// Token: 0x04029990 RID: 170384
			[Token(Token = "0x4029990")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
