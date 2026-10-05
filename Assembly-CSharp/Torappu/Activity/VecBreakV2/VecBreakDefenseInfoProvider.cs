using System;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E8B RID: 28299
	[Token(Token = "0x2006E8B")]
	public class VecBreakDefenseInfoProvider : VecBreakStageInfoProvider
	{
		// Token: 0x17005F24 RID: 24356
		// (get) Token: 0x0602847A RID: 164986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F24")]
		public override string squadSaveKey
		{
			[Token(Token = "0x602847A")]
			[Address(RVA = "0x2397EF0", Offset = "0x2396AF0", VA = "0x182397EF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F25 RID: 24357
		// (get) Token: 0x0602847B RID: 164987 RVA: 0x000D1370 File Offset: 0x000CF570
		[Token(Token = "0x17005F25")]
		public override int squadSlotMax
		{
			[Token(Token = "0x602847B")]
			[Address(RVA = "0x2397FB0", Offset = "0x2396BB0", VA = "0x182397FB0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005F26 RID: 24358
		// (get) Token: 0x0602847C RID: 164988 RVA: 0x000D1388 File Offset: 0x000CF588
		[Token(Token = "0x17005F26")]
		public override bool initFillWithPlayerSquad
		{
			[Token(Token = "0x602847C")]
			[Address(RVA = "0x2397E90", Offset = "0x2396A90", VA = "0x182397E90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005F27 RID: 24359
		// (get) Token: 0x0602847D RID: 164989 RVA: 0x000D13A0 File Offset: 0x000CF5A0
		[Token(Token = "0x17005F27")]
		public override bool canAssist
		{
			[Token(Token = "0x602847D")]
			[Address(RVA = "0x2397D00", Offset = "0x2396900", VA = "0x182397D00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005F28 RID: 24360
		// (get) Token: 0x0602847E RID: 164990 RVA: 0x000D13B8 File Offset: 0x000CF5B8
		[Token(Token = "0x17005F28")]
		public override BattleStageMeta stageMeta
		{
			[Token(Token = "0x602847E")]
			[Address(RVA = "0x2398020", Offset = "0x2396C20", VA = "0x182398020", Slot = "8")]
			get
			{
				return default(BattleStageMeta);
			}
		}

		// Token: 0x17005F29 RID: 24361
		// (get) Token: 0x0602847F RID: 164991 RVA: 0x000D13D0 File Offset: 0x000CF5D0
		[Token(Token = "0x17005F29")]
		public override GameModeMeta gameModeMeta
		{
			[Token(Token = "0x602847F")]
			[Address(RVA = "0x2397D60", Offset = "0x2396960", VA = "0x182397D60", Slot = "9")]
			get
			{
				return default(GameModeMeta);
			}
		}

		// Token: 0x17005F2A RID: 24362
		// (get) Token: 0x06028480 RID: 164992 RVA: 0x000D13E8 File Offset: 0x000CF5E8
		[Token(Token = "0x17005F2A")]
		public override GameTagMeta gameTagMeta
		{
			[Token(Token = "0x6028480")]
			[Address(RVA = "0x2397DF0", Offset = "0x23969F0", VA = "0x182397DF0", Slot = "10")]
			get
			{
				return default(GameTagMeta);
			}
		}

		// Token: 0x06028481 RID: 164993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028481")]
		[Address(RVA = "0x2397930", Offset = "0x2396530", VA = "0x182397930", Slot = "12")]
		public override IFinishBattleServiceConfig CreateFinishBattleConfig()
		{
			return null;
		}

		// Token: 0x06028482 RID: 164994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028482")]
		[Address(RVA = "0x2397A00", Offset = "0x2396600", VA = "0x182397A00", Slot = "11")]
		public override IStartBattleServiceConfig CreateStartBattleConfig(CommonStartBattleRequest.SquadModel squadModel, SquadFriendData assistFriend)
		{
			return null;
		}

		// Token: 0x06028483 RID: 164995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028483")]
		[Address(RVA = "0x2397BF0", Offset = "0x23967F0", VA = "0x182397BF0", Slot = "13")]
		protected override void OnInit()
		{
		}

		// Token: 0x06028484 RID: 164996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028484")]
		[Address(RVA = "0x2397CA0", Offset = "0x23968A0", VA = "0x182397CA0")]
		public VecBreakDefenseInfoProvider()
		{
		}

		// Token: 0x040393E9 RID: 234473
		[Token(Token = "0x40393E9")]
		[FieldOffset(Offset = "0x38")]
		private ActVecBreakV2DefenseDetailData m_defenseDetailData;

		// Token: 0x040393EA RID: 234474
		[Token(Token = "0x40393EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadSaveKey;

		// Token: 0x040393EB RID: 234475
		[Token(Token = "0x40393EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_squadSlotMax;

		// Token: 0x040393EC RID: 234476
		[Token(Token = "0x40393EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_initFillWithPlayerSquad;

		// Token: 0x040393ED RID: 234477
		[Token(Token = "0x40393ED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_canAssist;

		// Token: 0x040393EE RID: 234478
		[Token(Token = "0x40393EE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageMeta;

		// Token: 0x040393EF RID: 234479
		[Token(Token = "0x40393EF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_gameModeMeta;

		// Token: 0x040393F0 RID: 234480
		[Token(Token = "0x40393F0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_gameTagMeta;

		// Token: 0x040393F1 RID: 234481
		[Token(Token = "0x40393F1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateFinishBattleConfig;

		// Token: 0x040393F2 RID: 234482
		[Token(Token = "0x40393F2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CreateStartBattleConfig;

		// Token: 0x040393F3 RID: 234483
		[Token(Token = "0x40393F3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040393F4 RID: 234484
		[Token(Token = "0x40393F4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
