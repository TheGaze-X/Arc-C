using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FC2 RID: 28610
	[Token(Token = "0x2006FC2")]
	public class ActMultiV3SquadEffectSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005FEC RID: 24556
		// (get) Token: 0x06028A0E RID: 166414 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028A0F RID: 166415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FEC")]
		public string actId
		{
			[Token(Token = "0x6028A0E")]
			[Address(RVA = "0x23F28B0", Offset = "0x23F14B0", VA = "0x1823F28B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028A0F")]
			[Address(RVA = "0x23F29D0", Offset = "0x23F15D0", VA = "0x1823F29D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FED RID: 24557
		// (get) Token: 0x06028A10 RID: 166416 RVA: 0x000D2780 File Offset: 0x000D0980
		// (set) Token: 0x06028A11 RID: 166417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FED")]
		public ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028A10")]
			[Address(RVA = "0x23F2910", Offset = "0x23F1510", VA = "0x1823F2910")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
			[Token(Token = "0x6028A11")]
			[Address(RVA = "0x23F2A50", Offset = "0x23F1650", VA = "0x1823F2A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FEE RID: 24558
		// (get) Token: 0x06028A12 RID: 166418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FEE")]
		public ActMultiV3SquadEffectSelectProp prop
		{
			[Token(Token = "0x6028A12")]
			[Address(RVA = "0x23F2970", Offset = "0x23F1570", VA = "0x1823F2970")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028A13 RID: 166419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A13")]
		[Address(RVA = "0x23F2690", Offset = "0x23F1290", VA = "0x1823F2690")]
		public void SetActIdAndSquadMode(string actId, ActMultiV3MapModeType modeType)
		{
		}

		// Token: 0x06028A14 RID: 166420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A14")]
		[Address(RVA = "0x23F27C0", Offset = "0x23F13C0", VA = "0x1823F27C0")]
		public ActMultiV3SquadEffectSelectStateBean()
		{
		}

		// Token: 0x04039E25 RID: 237093
		[Token(Token = "0x4039E25")]
		[FieldOffset(Offset = "0x10")]
		private ActMultiV3SquadEffectSelectProp m_prop;

		// Token: 0x04039E28 RID: 237096
		[Token(Token = "0x4039E28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04039E29 RID: 237097
		[Token(Token = "0x4039E29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04039E2A RID: 237098
		[Token(Token = "0x4039E2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x04039E2B RID: 237099
		[Token(Token = "0x4039E2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_modeType;

		// Token: 0x04039E2C RID: 237100
		[Token(Token = "0x4039E2C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x04039E2D RID: 237101
		[Token(Token = "0x4039E2D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetActIdAndSquadMode;

		// Token: 0x04039E2E RID: 237102
		[Token(Token = "0x4039E2E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
