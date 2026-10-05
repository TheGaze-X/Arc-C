using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2.BattleFinish
{
	// Token: 0x02004460 RID: 17504
	[Token(Token = "0x2004460")]
	public class SandboxV2RacerInfoModel : IHotfixable
	{
		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x0601AC0D RID: 109581 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AC0E RID: 109582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F91")]
		public string instId
		{
			[Token(Token = "0x601AC0D")]
			[Address(RVA = "0x13E3F40", Offset = "0x13E2B40", VA = "0x1813E3F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AC0E")]
			[Address(RVA = "0x13E4280", Offset = "0x13E2E80", VA = "0x1813E4280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x0601AC0F RID: 109583 RVA: 0x000A3398 File Offset: 0x000A1598
		// (set) Token: 0x0601AC10 RID: 109584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F92")]
		public int time
		{
			[Token(Token = "0x601AC0F")]
			[Address(RVA = "0x13E41C0", Offset = "0x13E2DC0", VA = "0x1813E41C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601AC10")]
			[Address(RVA = "0x13E4400", Offset = "0x13E3000", VA = "0x1813E4400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x0601AC11 RID: 109585 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AC12 RID: 109586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F93")]
		public string name
		{
			[Token(Token = "0x601AC11")]
			[Address(RVA = "0x13E40A0", Offset = "0x13E2CA0", VA = "0x1813E40A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AC12")]
			[Address(RVA = "0x13E4380", Offset = "0x13E2F80", VA = "0x1813E4380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x0601AC13 RID: 109587 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AC14 RID: 109588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F94")]
		public string typeName
		{
			[Token(Token = "0x601AC13")]
			[Address(RVA = "0x13E4220", Offset = "0x13E2E20", VA = "0x1813E4220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AC14")]
			[Address(RVA = "0x13E4470", Offset = "0x13E3070", VA = "0x1813E4470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x0601AC15 RID: 109589 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AC16 RID: 109590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F95")]
		public string itemId
		{
			[Token(Token = "0x601AC15")]
			[Address(RVA = "0x13E4040", Offset = "0x13E2C40", VA = "0x1813E4040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AC16")]
			[Address(RVA = "0x13E4300", Offset = "0x13E2F00", VA = "0x1813E4300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x0601AC17 RID: 109591 RVA: 0x000A33B0 File Offset: 0x000A15B0
		[Token(Token = "0x17003F96")]
		public bool isUnfinished
		{
			[Token(Token = "0x601AC17")]
			[Address(RVA = "0x13E3FA0", Offset = "0x13E2BA0", VA = "0x1813E3FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x0601AC18 RID: 109592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F97")]
		public string pos
		{
			[Token(Token = "0x601AC18")]
			[Address(RVA = "0x13E4100", Offset = "0x13E2D00", VA = "0x1813E4100")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AC19 RID: 109593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC19")]
		[Address(RVA = "0x13E3B70", Offset = "0x13E2770", VA = "0x1813E3B70")]
		public void LoadData(int position, string topicId, SandboxV2RacingBattleFinishResponse.RacerInfo racerInfo)
		{
		}

		// Token: 0x0601AC1A RID: 109594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC1A")]
		[Address(RVA = "0x13E3EE0", Offset = "0x13E2AE0", VA = "0x1813E3EE0")]
		public SandboxV2RacerInfoModel()
		{
		}

		// Token: 0x04022327 RID: 140071
		[Token(Token = "0x4022327")]
		[FieldOffset(Offset = "0x10")]
		private int m_position;

		// Token: 0x0402232D RID: 140077
		[Token(Token = "0x402232D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0402232E RID: 140078
		[Token(Token = "0x402232E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_instId;

		// Token: 0x0402232F RID: 140079
		[Token(Token = "0x402232F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_time;

		// Token: 0x04022330 RID: 140080
		[Token(Token = "0x4022330")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_time;

		// Token: 0x04022331 RID: 140081
		[Token(Token = "0x4022331")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x04022332 RID: 140082
		[Token(Token = "0x4022332")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x04022333 RID: 140083
		[Token(Token = "0x4022333")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_typeName;

		// Token: 0x04022334 RID: 140084
		[Token(Token = "0x4022334")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_typeName;

		// Token: 0x04022335 RID: 140085
		[Token(Token = "0x4022335")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x04022336 RID: 140086
		[Token(Token = "0x4022336")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_itemId;

		// Token: 0x04022337 RID: 140087
		[Token(Token = "0x4022337")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isUnfinished;

		// Token: 0x04022338 RID: 140088
		[Token(Token = "0x4022338")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_pos;

		// Token: 0x04022339 RID: 140089
		[Token(Token = "0x4022339")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402233A RID: 140090
		[Token(Token = "0x402233A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
