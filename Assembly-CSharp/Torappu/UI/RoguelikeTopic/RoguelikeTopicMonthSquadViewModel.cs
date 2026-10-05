using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004584 RID: 17796
	[Token(Token = "0x2004584")]
	public class RoguelikeTopicMonthSquadViewModel : IHotfixable
	{
		// Token: 0x0601B186 RID: 110982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B186")]
		[Address(RVA = "0x143C960", Offset = "0x143B560", VA = "0x18143C960")]
		public void LoadData(string topic, RoguelikeTopicModeViewModel outerModel)
		{
		}

		// Token: 0x0601B187 RID: 110983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B187")]
		[Address(RVA = "0x143D380", Offset = "0x143BF80", VA = "0x18143D380")]
		public void SetCurrentMonthSquadId(string monthSquadId)
		{
		}

		// Token: 0x0601B188 RID: 110984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B188")]
		[Address(RVA = "0x143D460", Offset = "0x143C060", VA = "0x18143D460")]
		public void SwitchMonthSquadList(int delta)
		{
		}

		// Token: 0x0601B189 RID: 110985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B189")]
		[Address(RVA = "0x143D5F0", Offset = "0x143C1F0", VA = "0x18143D5F0")]
		public RoguelikeTopicMonthSquadViewModel()
		{
		}

		// Token: 0x04022DB8 RID: 142776
		[Token(Token = "0x4022DB8")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04022DB9 RID: 142777
		[Token(Token = "0x4022DB9")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, RoguelikeTopicMonthSquadModel> monthSquadList;

		// Token: 0x04022DBA RID: 142778
		[Token(Token = "0x4022DBA")]
		[FieldOffset(Offset = "0x20")]
		public string bpPointItemId;

		// Token: 0x04022DBB RID: 142779
		[Token(Token = "0x4022DBB")]
		[FieldOffset(Offset = "0x28")]
		public ItemType bpPointItemType;

		// Token: 0x04022DBC RID: 142780
		[Token(Token = "0x4022DBC")]
		[FieldOffset(Offset = "0x30")]
		public string bpPointItemName;

		// Token: 0x04022DBD RID: 142781
		[Token(Token = "0x4022DBD")]
		[FieldOffset(Offset = "0x38")]
		public string tipButtonName;

		// Token: 0x04022DBE RID: 142782
		[Token(Token = "0x4022DBE")]
		[FieldOffset(Offset = "0x40")]
		public string descSquadName;

		// Token: 0x04022DBF RID: 142783
		[Token(Token = "0x4022DBF")]
		[FieldOffset(Offset = "0x48")]
		public bool isBpMax;

		// Token: 0x04022DC0 RID: 142784
		[Token(Token = "0x4022DC0")]
		[FieldOffset(Offset = "0x49")]
		public bool isFullStored;

		// Token: 0x04022DC1 RID: 142785
		[Token(Token = "0x4022DC1")]
		[FieldOffset(Offset = "0x4C")]
		public MonthSquadCardSwitchDirection switchDirection;

		// Token: 0x04022DC2 RID: 142786
		[Token(Token = "0x4022DC2")]
		[FieldOffset(Offset = "0x50")]
		public string selectedMonthSquad;

		// Token: 0x04022DC3 RID: 142787
		[Token(Token = "0x4022DC3")]
		[FieldOffset(Offset = "0x58")]
		public string currUpdateSquad;

		// Token: 0x04022DC4 RID: 142788
		[Token(Token = "0x4022DC4")]
		[FieldOffset(Offset = "0x60")]
		public long currUpdateSquadEndTime;

		// Token: 0x04022DC5 RID: 142789
		[Token(Token = "0x4022DC5")]
		[FieldOffset(Offset = "0x68")]
		public bool currUpdateSquadReceivedAward;

		// Token: 0x04022DC6 RID: 142790
		[Token(Token = "0x4022DC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04022DC7 RID: 142791
		[Token(Token = "0x4022DC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetCurrentMonthSquadId;

		// Token: 0x04022DC8 RID: 142792
		[Token(Token = "0x4022DC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SwitchMonthSquadList;

		// Token: 0x04022DC9 RID: 142793
		[Token(Token = "0x4022DC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
