using System;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E8A RID: 28298
	[Token(Token = "0x2006E8A")]
	public class VecBreakOffenseInfoProvider : VecBreakStageInfoProvider
	{
		// Token: 0x17005F1D RID: 24349
		// (get) Token: 0x0602846F RID: 164975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F1D")]
		public override string squadSaveKey
		{
			[Token(Token = "0x602846F")]
			[Address(RVA = "0x2399210", Offset = "0x2397E10", VA = "0x182399210", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F1E RID: 24350
		// (get) Token: 0x06028470 RID: 164976 RVA: 0x000D12E0 File Offset: 0x000CF4E0
		[Token(Token = "0x17005F1E")]
		public override int squadSlotMax
		{
			[Token(Token = "0x6028470")]
			[Address(RVA = "0x2399280", Offset = "0x2397E80", VA = "0x182399280", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005F1F RID: 24351
		// (get) Token: 0x06028471 RID: 164977 RVA: 0x000D12F8 File Offset: 0x000CF4F8
		[Token(Token = "0x17005F1F")]
		public override bool initFillWithPlayerSquad
		{
			[Token(Token = "0x6028471")]
			[Address(RVA = "0x23991B0", Offset = "0x2397DB0", VA = "0x1823991B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005F20 RID: 24352
		// (get) Token: 0x06028472 RID: 164978 RVA: 0x000D1310 File Offset: 0x000CF510
		[Token(Token = "0x17005F20")]
		public override bool canAssist
		{
			[Token(Token = "0x6028472")]
			[Address(RVA = "0x2399030", Offset = "0x2397C30", VA = "0x182399030", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005F21 RID: 24353
		// (get) Token: 0x06028473 RID: 164979 RVA: 0x000D1328 File Offset: 0x000CF528
		[Token(Token = "0x17005F21")]
		public override BattleStageMeta stageMeta
		{
			[Token(Token = "0x6028473")]
			[Address(RVA = "0x23992E0", Offset = "0x2397EE0", VA = "0x1823992E0", Slot = "8")]
			get
			{
				return default(BattleStageMeta);
			}
		}

		// Token: 0x17005F22 RID: 24354
		// (get) Token: 0x06028474 RID: 164980 RVA: 0x000D1340 File Offset: 0x000CF540
		[Token(Token = "0x17005F22")]
		public override GameModeMeta gameModeMeta
		{
			[Token(Token = "0x6028474")]
			[Address(RVA = "0x2399090", Offset = "0x2397C90", VA = "0x182399090", Slot = "9")]
			get
			{
				return default(GameModeMeta);
			}
		}

		// Token: 0x17005F23 RID: 24355
		// (get) Token: 0x06028475 RID: 164981 RVA: 0x000D1358 File Offset: 0x000CF558
		[Token(Token = "0x17005F23")]
		public override GameTagMeta gameTagMeta
		{
			[Token(Token = "0x6028475")]
			[Address(RVA = "0x2399110", Offset = "0x2397D10", VA = "0x182399110", Slot = "10")]
			get
			{
				return default(GameTagMeta);
			}
		}

		// Token: 0x06028476 RID: 164982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028476")]
		[Address(RVA = "0x2398C90", Offset = "0x2397890", VA = "0x182398C90", Slot = "12")]
		public override IFinishBattleServiceConfig CreateFinishBattleConfig()
		{
			return null;
		}

		// Token: 0x06028477 RID: 164983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028477")]
		[Address(RVA = "0x2398D60", Offset = "0x2397960", VA = "0x182398D60", Slot = "11")]
		public override IStartBattleServiceConfig CreateStartBattleConfig(CommonStartBattleRequest.SquadModel squadModel, SquadFriendData assistFriend)
		{
			return null;
		}

		// Token: 0x06028478 RID: 164984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028478")]
		[Address(RVA = "0x2398F70", Offset = "0x2397B70", VA = "0x182398F70", Slot = "13")]
		protected override void OnInit()
		{
		}

		// Token: 0x06028479 RID: 164985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028479")]
		[Address(RVA = "0x2398FD0", Offset = "0x2397BD0", VA = "0x182398FD0")]
		public VecBreakOffenseInfoProvider()
		{
		}

		// Token: 0x040393DE RID: 234462
		[Token(Token = "0x40393DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadSaveKey;

		// Token: 0x040393DF RID: 234463
		[Token(Token = "0x40393DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_squadSlotMax;

		// Token: 0x040393E0 RID: 234464
		[Token(Token = "0x40393E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_initFillWithPlayerSquad;

		// Token: 0x040393E1 RID: 234465
		[Token(Token = "0x40393E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_canAssist;

		// Token: 0x040393E2 RID: 234466
		[Token(Token = "0x40393E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageMeta;

		// Token: 0x040393E3 RID: 234467
		[Token(Token = "0x40393E3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_gameModeMeta;

		// Token: 0x040393E4 RID: 234468
		[Token(Token = "0x40393E4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_gameTagMeta;

		// Token: 0x040393E5 RID: 234469
		[Token(Token = "0x40393E5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateFinishBattleConfig;

		// Token: 0x040393E6 RID: 234470
		[Token(Token = "0x40393E6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CreateStartBattleConfig;

		// Token: 0x040393E7 RID: 234471
		[Token(Token = "0x40393E7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040393E8 RID: 234472
		[Token(Token = "0x40393E8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
