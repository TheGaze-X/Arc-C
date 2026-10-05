using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043A5 RID: 17317
	[Token(Token = "0x20043A5")]
	public class SandboxV2RiftTeamSelectViewModel : IHotfixable
	{
		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x0601A92E RID: 108846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EFE")]
		public string selectedTeamId
		{
			[Token(Token = "0x601A92E")]
			[Address(RVA = "0x13B9CA0", Offset = "0x13B88A0", VA = "0x1813B9CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A92F RID: 108847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A92F")]
		[Address(RVA = "0x13B9570", Offset = "0x13B8170", VA = "0x1813B9570")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601A930 RID: 108848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A930")]
		[Address(RVA = "0x13B9B20", Offset = "0x13B8720", VA = "0x1813B9B20")]
		public void UpdateSelectTeam(string teamId)
		{
		}

		// Token: 0x0601A931 RID: 108849 RVA: 0x000A2660 File Offset: 0x000A0860
		[Token(Token = "0x601A931")]
		[Address(RVA = "0x13B94C0", Offset = "0x13B80C0", VA = "0x1813B94C0")]
		public bool IsTeamSame(string teamId)
		{
			return default(bool);
		}

		// Token: 0x0601A932 RID: 108850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A932")]
		[Address(RVA = "0x13B9BF0", Offset = "0x13B87F0", VA = "0x1813B9BF0")]
		public SandboxV2RiftTeamSelectViewModel()
		{
		}

		// Token: 0x04021DC0 RID: 138688
		[Token(Token = "0x4021DC0")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, SandboxV2RiftTeamSelectItemModel> teamItemDict;

		// Token: 0x04021DC1 RID: 138689
		[Token(Token = "0x4021DC1")]
		[FieldOffset(Offset = "0x18")]
		public int teamLevel;

		// Token: 0x04021DC2 RID: 138690
		[Token(Token = "0x4021DC2")]
		[FieldOffset(Offset = "0x20")]
		public string noTeamName;

		// Token: 0x04021DC3 RID: 138691
		[Token(Token = "0x4021DC3")]
		[FieldOffset(Offset = "0x28")]
		public string noTeamBgId;

		// Token: 0x04021DC4 RID: 138692
		[Token(Token = "0x4021DC4")]
		[FieldOffset(Offset = "0x30")]
		public string noTeamDesc;

		// Token: 0x04021DC5 RID: 138693
		[Token(Token = "0x4021DC5")]
		[FieldOffset(Offset = "0x38")]
		public string noTeamBigIconId;

		// Token: 0x04021DC6 RID: 138694
		[Token(Token = "0x4021DC6")]
		[FieldOffset(Offset = "0x40")]
		private string m_selectedTeamId;

		// Token: 0x04021DC7 RID: 138695
		[Token(Token = "0x4021DC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedTeamId;

		// Token: 0x04021DC8 RID: 138696
		[Token(Token = "0x4021DC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021DC9 RID: 138697
		[Token(Token = "0x4021DC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateSelectTeam;

		// Token: 0x04021DCA RID: 138698
		[Token(Token = "0x4021DCA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsTeamSame;

		// Token: 0x04021DCB RID: 138699
		[Token(Token = "0x4021DCB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
