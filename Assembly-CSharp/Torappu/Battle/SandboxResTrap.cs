using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200260C RID: 9740
	[Token(Token = "0x200260C")]
	[SelectionBase]
	public class SandboxResTrap : Trap
	{
		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x0600FDD2 RID: 64978 RVA: 0x000601B0 File Offset: 0x0005E3B0
		[Token(Token = "0x1700222D")]
		public int maxStockCount
		{
			[Token(Token = "0x600FDD2")]
			[Address(RVA = "0x7601C0", Offset = "0x75EDC0", VA = "0x1807601C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x0600FDD3 RID: 64979 RVA: 0x000601C8 File Offset: 0x0005E3C8
		[Token(Token = "0x1700222E")]
		public int currentStockCount
		{
			[Token(Token = "0x600FDD3")]
			[Address(RVA = "0x760160", Offset = "0x75ED60", VA = "0x180760160")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x0600FDD4 RID: 64980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700222F")]
		public string rewardItemId
		{
			[Token(Token = "0x600FDD4")]
			[Address(RVA = "0x7602C0", Offset = "0x75EEC0", VA = "0x1807602C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x0600FDD5 RID: 64981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002230")]
		private GameModeFactory.SandboxGameMode sandboxGameMode
		{
			[Token(Token = "0x600FDD5")]
			[Address(RVA = "0x760330", Offset = "0x75EF30", VA = "0x180760330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x0600FDD6 RID: 64982 RVA: 0x000601E0 File Offset: 0x0005E3E0
		[Token(Token = "0x17002231")]
		public int notCollectedCount
		{
			[Token(Token = "0x600FDD6")]
			[Address(RVA = "0x760220", Offset = "0x75EE20", VA = "0x180760220")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600FDD7 RID: 64983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDD7")]
		[Address(RVA = "0x75FC00", Offset = "0x75E800", VA = "0x18075FC00", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600FDD8 RID: 64984 RVA: 0x000601F8 File Offset: 0x0005E3F8
		[Token(Token = "0x600FDD8")]
		[Address(RVA = "0x75FE10", Offset = "0x75EA10", VA = "0x18075FE10", Slot = "107")]
		protected override bool SetHpInternal(FP value, bool force, bool noSource, bool skipReborn)
		{
			return default(bool);
		}

		// Token: 0x0600FDD9 RID: 64985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDD9")]
		[Address(RVA = "0x75FB50", Offset = "0x75E750", VA = "0x18075FB50", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600FDDA RID: 64986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDDA")]
		[Address(RVA = "0x75F9D0", Offset = "0x75E5D0", VA = "0x18075F9D0")]
		public void DropItems(int count)
		{
		}

		// Token: 0x0600FDDB RID: 64987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDDB")]
		[Address(RVA = "0x75FDA0", Offset = "0x75E9A0", VA = "0x18075FDA0")]
		public void RefreshCurrentStock(int count)
		{
		}

		// Token: 0x0600FDDC RID: 64988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDDC")]
		[Address(RVA = "0x75FA90", Offset = "0x75E690", VA = "0x18075FA90", Slot = "172")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600FDDD RID: 64989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDDD")]
		[Address(RVA = "0x760100", Offset = "0x75ED00", VA = "0x180760100")]
		public SandboxResTrap()
		{
		}

		// Token: 0x0600FDDE RID: 64990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDDE")]
		[Address(RVA = "0x7600D0", Offset = "0x75ECD0", VA = "0x1807600D0")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600FDDF RID: 64991 RVA: 0x00060210 File Offset: 0x0005E410
		[Token(Token = "0x600FDDF")]
		[Address(RVA = "0x7600E0", Offset = "0x75ECE0", VA = "0x1807600E0")]
		private bool <>xLuaBaseProxy_SetHpInternal(FP P0, bool P1, bool P2, bool P3)
		{
			return default(bool);
		}

		// Token: 0x0600FDE0 RID: 64992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDE0")]
		[Address(RVA = "0x75EF70", Offset = "0x75DB70", VA = "0x18075EF70")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600FDE1 RID: 64993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDE1")]
		[Address(RVA = "0x7600C0", Offset = "0x75ECC0", VA = "0x1807600C0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x04011A1F RID: 72223
		[Token(Token = "0x4011A1F")]
		[FieldOffset(Offset = "0x578")]
		[SerializeField]
		protected string _dropEffect;

		// Token: 0x04011A20 RID: 72224
		[Token(Token = "0x4011A20")]
		[FieldOffset(Offset = "0x580")]
		private int m_maxStockCount;

		// Token: 0x04011A21 RID: 72225
		[Token(Token = "0x4011A21")]
		[FieldOffset(Offset = "0x584")]
		private int m_curStockCount;

		// Token: 0x04011A22 RID: 72226
		[Token(Token = "0x4011A22")]
		[FieldOffset(Offset = "0x588")]
		private SandboxV2RewardCommonConfig m_reward;

		// Token: 0x04011A23 RID: 72227
		[Token(Token = "0x4011A23")]
		[FieldOffset(Offset = "0x590")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x04011A24 RID: 72228
		[Token(Token = "0x4011A24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxStockCount;

		// Token: 0x04011A25 RID: 72229
		[Token(Token = "0x4011A25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentStockCount;

		// Token: 0x04011A26 RID: 72230
		[Token(Token = "0x4011A26")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rewardItemId;

		// Token: 0x04011A27 RID: 72231
		[Token(Token = "0x4011A27")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sandboxGameMode;

		// Token: 0x04011A28 RID: 72232
		[Token(Token = "0x4011A28")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_notCollectedCount;

		// Token: 0x04011A29 RID: 72233
		[Token(Token = "0x4011A29")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011A2A RID: 72234
		[Token(Token = "0x4011A2A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetHpInternal;

		// Token: 0x04011A2B RID: 72235
		[Token(Token = "0x4011A2B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04011A2C RID: 72236
		[Token(Token = "0x4011A2C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DropItems;

		// Token: 0x04011A2D RID: 72237
		[Token(Token = "0x4011A2D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshCurrentStock;

		// Token: 0x04011A2E RID: 72238
		[Token(Token = "0x4011A2E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04011A2F RID: 72239
		[Token(Token = "0x4011A2F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
