using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022A7 RID: 8871
	[Token(Token = "0x20022A7")]
	public class EnvToEmitBranch : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DEF0 RID: 57072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEF0")]
		[Address(RVA = "0x3656F90", Offset = "0x3655B90", VA = "0x183656F90", Slot = "19")]
		public override void OnEnvChanged(string status)
		{
		}

		// Token: 0x0600DEF1 RID: 57073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEF1")]
		[Address(RVA = "0x3657160", Offset = "0x3655D60", VA = "0x183657160")]
		private void _MoveNextBranch(EnvToEmitBranch.BranchSetting setting)
		{
		}

		// Token: 0x0600DEF2 RID: 57074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEF2")]
		[Address(RVA = "0x36572D0", Offset = "0x3655ED0", VA = "0x1836572D0")]
		public EnvToEmitBranch()
		{
		}

		// Token: 0x0600DEF3 RID: 57075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEF3")]
		[Address(RVA = "0x3652050", Offset = "0x3650C50", VA = "0x183652050")]
		private void <>xLuaBaseProxy_OnEnvChanged(string P0)
		{
		}

		// Token: 0x0400F215 RID: 61973
		[Token(Token = "0x400F215")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<EnvToEmitBranch.BranchSetting> _branchSettings;

		// Token: 0x0400F216 RID: 61974
		[Token(Token = "0x400F216")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F217 RID: 61975
		[Token(Token = "0x400F217")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__MoveNextBranch;

		// Token: 0x0400F218 RID: 61976
		[Token(Token = "0x400F218")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022A8 RID: 8872
		[Token(Token = "0x20022A8")]
		[Serializable]
		private class BranchSetting
		{
			// Token: 0x0600DEF4 RID: 57076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DEF4")]
			[Address(RVA = "0x364FF80", Offset = "0x364EB80", VA = "0x18364FF80")]
			public BranchSetting()
			{
			}

			// Token: 0x0400F219 RID: 61977
			[Token(Token = "0x400F219")]
			[FieldOffset(Offset = "0x10")]
			public string envName;

			// Token: 0x0400F21A RID: 61978
			[Token(Token = "0x400F21A")]
			[FieldOffset(Offset = "0x18")]
			public string branchIdKey;

			// Token: 0x0400F21B RID: 61979
			[Token(Token = "0x400F21B")]
			[FieldOffset(Offset = "0x20")]
			public string defaultBranchId;

			// Token: 0x0400F21C RID: 61980
			[Token(Token = "0x400F21C")]
			[FieldOffset(Offset = "0x28")]
			public bool isLoop;
		}
	}
}
