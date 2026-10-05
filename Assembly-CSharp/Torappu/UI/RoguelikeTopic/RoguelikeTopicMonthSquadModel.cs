using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004583 RID: 17795
	[Token(Token = "0x2004583")]
	public class RoguelikeTopicMonthSquadModel : IHotfixable
	{
		// Token: 0x0601B183 RID: 110979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B183")]
		[Address(RVA = "0x143C230", Offset = "0x143AE30", VA = "0x18143C230")]
		public void LoadData(string topic, string monthTeam)
		{
		}

		// Token: 0x0601B184 RID: 110980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B184")]
		[Address(RVA = "0x143C5E0", Offset = "0x143B1E0", VA = "0x18143C5E0")]
		private void _LoadMonthSquadTaskStatus()
		{
		}

		// Token: 0x0601B185 RID: 110981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B185")]
		[Address(RVA = "0x143C900", Offset = "0x143B500", VA = "0x18143C900")]
		public RoguelikeTopicMonthSquadModel()
		{
		}

		// Token: 0x04022D9F RID: 142751
		[Token(Token = "0x4022D9F")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04022DA0 RID: 142752
		[Token(Token = "0x4022DA0")]
		[FieldOffset(Offset = "0x18")]
		public string monthTeamId;

		// Token: 0x04022DA1 RID: 142753
		[Token(Token = "0x4022DA1")]
		[FieldOffset(Offset = "0x20")]
		public string teamName;

		// Token: 0x04022DA2 RID: 142754
		[Token(Token = "0x4022DA2")]
		[FieldOffset(Offset = "0x28")]
		public string teamDes;

		// Token: 0x04022DA3 RID: 142755
		[Token(Token = "0x4022DA3")]
		[FieldOffset(Offset = "0x30")]
		public string teamColor;

		// Token: 0x04022DA4 RID: 142756
		[Token(Token = "0x4022DA4")]
		[FieldOffset(Offset = "0x38")]
		public string teamMonth;

		// Token: 0x04022DA5 RID: 142757
		[Token(Token = "0x4022DA5")]
		[FieldOffset(Offset = "0x40")]
		public string teamYear;

		// Token: 0x04022DA6 RID: 142758
		[Token(Token = "0x4022DA6")]
		[FieldOffset(Offset = "0x48")]
		public string descIndex;

		// Token: 0x04022DA7 RID: 142759
		[Token(Token = "0x4022DA7")]
		[FieldOffset(Offset = "0x50")]
		public string teamSubName;

		// Token: 0x04022DA8 RID: 142760
		[Token(Token = "0x4022DA8")]
		[FieldOffset(Offset = "0x58")]
		public string teamFlavorDesc;

		// Token: 0x04022DA9 RID: 142761
		[Token(Token = "0x4022DA9")]
		[FieldOffset(Offset = "0x60")]
		public List<RoguelikeTopicMonthSquadTeamChar> teamChars;

		// Token: 0x04022DAA RID: 142762
		[Token(Token = "0x4022DAA")]
		[FieldOffset(Offset = "0x68")]
		public int tokenRewardNum;

		// Token: 0x04022DAB RID: 142763
		[Token(Token = "0x4022DAB")]
		[FieldOffset(Offset = "0x70")]
		public List<ItemBundle> items;

		// Token: 0x04022DAC RID: 142764
		[Token(Token = "0x4022DAC")]
		[FieldOffset(Offset = "0x78")]
		public bool hasReceivedAward;

		// Token: 0x04022DAD RID: 142765
		[Token(Token = "0x4022DAD")]
		[FieldOffset(Offset = "0x79")]
		public bool hasUnlockedAllChat;

		// Token: 0x04022DAE RID: 142766
		[Token(Token = "0x4022DAE")]
		[FieldOffset(Offset = "0x80")]
		public string chatId;

		// Token: 0x04022DAF RID: 142767
		[Token(Token = "0x4022DAF")]
		[FieldOffset(Offset = "0x88")]
		public string monthSquadSystemName;

		// Token: 0x04022DB0 RID: 142768
		[Token(Token = "0x4022DB0")]
		[FieldOffset(Offset = "0x90")]
		public string targetZoneName;

		// Token: 0x04022DB1 RID: 142769
		[Token(Token = "0x4022DB1")]
		[FieldOffset(Offset = "0x98")]
		public bool hasTask;

		// Token: 0x04022DB2 RID: 142770
		[Token(Token = "0x4022DB2")]
		[FieldOffset(Offset = "0xA0")]
		public string taskDesc;

		// Token: 0x04022DB3 RID: 142771
		[Token(Token = "0x4022DB3")]
		[FieldOffset(Offset = "0xA8")]
		public int taskCurrProgress;

		// Token: 0x04022DB4 RID: 142772
		[Token(Token = "0x4022DB4")]
		[FieldOffset(Offset = "0xAC")]
		public int taskTotalProgress;

		// Token: 0x04022DB5 RID: 142773
		[Token(Token = "0x4022DB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04022DB6 RID: 142774
		[Token(Token = "0x4022DB6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadMonthSquadTaskStatus;

		// Token: 0x04022DB7 RID: 142775
		[Token(Token = "0x4022DB7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
