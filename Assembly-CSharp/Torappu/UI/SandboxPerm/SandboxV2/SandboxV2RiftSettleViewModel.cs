using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004182 RID: 16770
	[Token(Token = "0x2004182")]
	public class SandboxV2RiftSettleViewModel
	{
		// Token: 0x06019E0D RID: 105997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E0D")]
		[Address(RVA = "0x12C7EB0", Offset = "0x12C6AB0", VA = "0x1812C7EB0")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x06019E0E RID: 105998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E0E")]
		[Address(RVA = "0x12C84A0", Offset = "0x12C70A0", VA = "0x1812C84A0")]
		private void _GenerateRewardItemViewModel(List<PlayerSandboxV2.RiftInfo.RewardItem> rewards, ref List<UIItemViewModel> outList)
		{
		}

		// Token: 0x06019E0F RID: 105999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E0F")]
		[Address(RVA = "0x12C86F0", Offset = "0x12C72F0", VA = "0x1812C86F0")]
		public SandboxV2RiftSettleViewModel()
		{
		}

		// Token: 0x0402086C RID: 133228
		[Token(Token = "0x402086C")]
		[FieldOffset(Offset = "0x10")]
		public string riftTopicId;

		// Token: 0x0402086D RID: 133229
		[Token(Token = "0x402086D")]
		[FieldOffset(Offset = "0x18")]
		public bool hasSubTarget;

		// Token: 0x0402086E RID: 133230
		[Token(Token = "0x402086E")]
		[FieldOffset(Offset = "0x19")]
		public bool isSubTargetComplete;

		// Token: 0x0402086F RID: 133231
		[Token(Token = "0x402086F")]
		[FieldOffset(Offset = "0x1A")]
		public bool isMainTargetComplete;

		// Token: 0x04020870 RID: 133232
		[Token(Token = "0x4020870")]
		[FieldOffset(Offset = "0x1B")]
		public bool isMainTargetFail;

		// Token: 0x04020871 RID: 133233
		[Token(Token = "0x4020871")]
		[FieldOffset(Offset = "0x1C")]
		public bool useDifficulty;

		// Token: 0x04020872 RID: 133234
		[Token(Token = "0x4020872")]
		[FieldOffset(Offset = "0x20")]
		public string mainTargetTitle;

		// Token: 0x04020873 RID: 133235
		[Token(Token = "0x4020873")]
		[FieldOffset(Offset = "0x28")]
		public int randomRiftDifficultyLevel;

		// Token: 0x04020874 RID: 133236
		[Token(Token = "0x4020874")]
		[FieldOffset(Offset = "0x2C")]
		public int portHpPercent;

		// Token: 0x04020875 RID: 133237
		[Token(Token = "0x4020875")]
		[FieldOffset(Offset = "0x30")]
		public string riftTeamName;

		// Token: 0x04020876 RID: 133238
		[Token(Token = "0x4020876")]
		[FieldOffset(Offset = "0x38")]
		public string riftTeamIconId;

		// Token: 0x04020877 RID: 133239
		[Token(Token = "0x4020877")]
		[FieldOffset(Offset = "0x40")]
		public int riftStayDayCount;

		// Token: 0x04020878 RID: 133240
		[Token(Token = "0x4020878")]
		[FieldOffset(Offset = "0x48")]
		public string mainTargetDesc;

		// Token: 0x04020879 RID: 133241
		[Token(Token = "0x4020879")]
		[FieldOffset(Offset = "0x50")]
		public int mainTargetProgress;

		// Token: 0x0402087A RID: 133242
		[Token(Token = "0x402087A")]
		[FieldOffset(Offset = "0x54")]
		public int mainTargetTotal;

		// Token: 0x0402087B RID: 133243
		[Token(Token = "0x402087B")]
		[FieldOffset(Offset = "0x58")]
		public string subTargetDesc;

		// Token: 0x0402087C RID: 133244
		[Token(Token = "0x402087C")]
		[FieldOffset(Offset = "0x60")]
		public int subTargetProgress;

		// Token: 0x0402087D RID: 133245
		[Token(Token = "0x402087D")]
		[FieldOffset(Offset = "0x64")]
		public int subTargetTotal;

		// Token: 0x0402087E RID: 133246
		[Token(Token = "0x402087E")]
		[FieldOffset(Offset = "0x68")]
		public List<UIItemViewModel> mainReward;

		// Token: 0x0402087F RID: 133247
		[Token(Token = "0x402087F")]
		[FieldOffset(Offset = "0x70")]
		public List<UIItemViewModel> subReward;
	}
}
