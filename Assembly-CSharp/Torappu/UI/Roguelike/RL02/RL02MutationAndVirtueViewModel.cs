using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200579B RID: 22427
	[Token(Token = "0x200579B")]
	public class RL02MutationAndVirtueViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x17004CE7 RID: 19687
		// (get) Token: 0x06020CE1 RID: 134369 RVA: 0x000B75D0 File Offset: 0x000B57D0
		[Token(Token = "0x17004CE7")]
		public bool hasMutation
		{
			[Token(Token = "0x6020CE1")]
			[Address(RVA = "0x1B248A0", Offset = "0x1B234A0", VA = "0x181B248A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004CE8 RID: 19688
		// (get) Token: 0x06020CE2 RID: 134370 RVA: 0x000B75E8 File Offset: 0x000B57E8
		[Token(Token = "0x17004CE8")]
		public bool hasVirtue
		{
			[Token(Token = "0x6020CE2")]
			[Address(RVA = "0x1B24930", Offset = "0x1B23530", VA = "0x181B24930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06020CE3 RID: 134371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CE3")]
		[Address(RVA = "0x1B24150", Offset = "0x1B22D50", VA = "0x181B24150", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x06020CE4 RID: 134372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CE4")]
		[Address(RVA = "0x1B247A0", Offset = "0x1B233A0", VA = "0x181B247A0")]
		public RL02MutationAndVirtueViewModel()
		{
		}

		// Token: 0x06020CE5 RID: 134373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CE5")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402C937 RID: 182583
		[Token(Token = "0x402C937")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402C938 RID: 182584
		[Token(Token = "0x402C938")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeCharBuffModel currMutation;

		// Token: 0x0402C939 RID: 182585
		[Token(Token = "0x402C939")]
		[FieldOffset(Offset = "0x58")]
		public List<string> mutationCharList;

		// Token: 0x0402C93A RID: 182586
		[Token(Token = "0x402C93A")]
		[FieldOffset(Offset = "0x60")]
		public List<RoguelikeSquadBuffModel> currVirtueList;

		// Token: 0x0402C93B RID: 182587
		[Token(Token = "0x402C93B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasMutation;

		// Token: 0x0402C93C RID: 182588
		[Token(Token = "0x402C93C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasVirtue;

		// Token: 0x0402C93D RID: 182589
		[Token(Token = "0x402C93D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C93E RID: 182590
		[Token(Token = "0x402C93E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
