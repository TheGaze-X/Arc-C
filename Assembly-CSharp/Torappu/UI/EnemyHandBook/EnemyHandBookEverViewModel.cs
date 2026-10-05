using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F3E RID: 20286
	[Token(Token = "0x2004F3E")]
	public class EnemyHandBookEverViewModel : IHotfixable, IComparable<EnemyHandBookEverViewModel>
	{
		// Token: 0x0601E358 RID: 123736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E358")]
		[Address(RVA = "0x17E84A0", Offset = "0x17E70A0", VA = "0x1817E84A0")]
		private void _GenAttriParam()
		{
		}

		// Token: 0x170046D1 RID: 18129
		// (get) Token: 0x0601E359 RID: 123737 RVA: 0x000ADDA8 File Offset: 0x000ABFA8
		[Token(Token = "0x170046D1")]
		public bool frozenImmune
		{
			[Token(Token = "0x601E359")]
			[Address(RVA = "0x17E92E0", Offset = "0x17E7EE0", VA = "0x1817E92E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170046D2 RID: 18130
		// (get) Token: 0x0601E35A RID: 123738 RVA: 0x000ADDC0 File Offset: 0x000ABFC0
		[Token(Token = "0x170046D2")]
		public bool levitateImmune
		{
			[Token(Token = "0x601E35A")]
			[Address(RVA = "0x17E9350", Offset = "0x17E7F50", VA = "0x1817E9350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170046D3 RID: 18131
		// (get) Token: 0x0601E35B RID: 123739 RVA: 0x000ADDD8 File Offset: 0x000ABFD8
		[Token(Token = "0x170046D3")]
		public bool stunImmune
		{
			[Token(Token = "0x601E35B")]
			[Address(RVA = "0x17E94A0", Offset = "0x17E80A0", VA = "0x1817E94A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170046D4 RID: 18132
		// (get) Token: 0x0601E35C RID: 123740 RVA: 0x000ADDF0 File Offset: 0x000ABFF0
		[Token(Token = "0x170046D4")]
		public bool disarmImmune
		{
			[Token(Token = "0x601E35C")]
			[Address(RVA = "0x17E9200", Offset = "0x17E7E00", VA = "0x1817E9200")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170046D5 RID: 18133
		// (get) Token: 0x0601E35D RID: 123741 RVA: 0x000ADE08 File Offset: 0x000AC008
		[Token(Token = "0x170046D5")]
		public bool sleepImmune
		{
			[Token(Token = "0x601E35D")]
			[Address(RVA = "0x17E9430", Offset = "0x17E8030", VA = "0x1817E9430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170046D6 RID: 18134
		// (get) Token: 0x0601E35E RID: 123742 RVA: 0x000ADE20 File Offset: 0x000AC020
		[Token(Token = "0x170046D6")]
		public bool fearedImmune
		{
			[Token(Token = "0x601E35E")]
			[Address(RVA = "0x17E9270", Offset = "0x17E7E70", VA = "0x1817E9270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170046D7 RID: 18135
		// (get) Token: 0x0601E35F RID: 123743 RVA: 0x000ADE38 File Offset: 0x000AC038
		[Token(Token = "0x170046D7")]
		public bool palsyImmune
		{
			[Token(Token = "0x601E35F")]
			[Address(RVA = "0x17E93C0", Offset = "0x17E7FC0", VA = "0x1817E93C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170046D8 RID: 18136
		// (get) Token: 0x0601E360 RID: 123744 RVA: 0x000ADE50 File Offset: 0x000AC050
		[Token(Token = "0x170046D8")]
		public bool attractImmune
		{
			[Token(Token = "0x601E360")]
			[Address(RVA = "0x17E9190", Offset = "0x17E7D90", VA = "0x1817E9190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170046D9 RID: 18137
		// (get) Token: 0x0601E361 RID: 123745 RVA: 0x000ADE68 File Offset: 0x000AC068
		[Token(Token = "0x170046D9")]
		public int weight
		{
			[Token(Token = "0x601E361")]
			[Address(RVA = "0x17E9510", Offset = "0x17E8110", VA = "0x1817E9510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601E362 RID: 123746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E362")]
		[Address(RVA = "0x17E8D50", Offset = "0x17E7950", VA = "0x1817E8D50")]
		private void _RefreshAttribute(EnemyHandbookLevelInfoData.RangePair pair, string level, float value, ref string text)
		{
		}

		// Token: 0x0601E363 RID: 123747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E363")]
		[Address(RVA = "0x17E8E20", Offset = "0x17E7A20", VA = "0x1817E8E20")]
		public EnemyHandBookEverViewModel(LevelData.EnemyDataDbReference enemyBattleData, EnemyHandBookData enemyHandBookData, bool unlockType)
		{
		}

		// Token: 0x0601E364 RID: 123748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E364")]
		[Address(RVA = "0x17E8FE0", Offset = "0x17E7BE0", VA = "0x1817E8FE0")]
		public EnemyHandBookEverViewModel(EnemyHandBookData enemyHandBookData, bool unlockType)
		{
		}

		// Token: 0x0601E365 RID: 123749 RVA: 0x000ADE80 File Offset: 0x000AC080
		[Token(Token = "0x601E365")]
		[Address(RVA = "0x17E8400", Offset = "0x17E7000", VA = "0x1817E8400", Slot = "4")]
		public int CompareTo(EnemyHandBookEverViewModel other)
		{
			return 0;
		}

		// Token: 0x04028434 RID: 164916
		[Token(Token = "0x4028434")]
		[FieldOffset(Offset = "0x10")]
		public InternalEnemyHBData enemyData;

		// Token: 0x04028435 RID: 164917
		[Token(Token = "0x4028435")]
		[FieldOffset(Offset = "0x18")]
		public EnemyHandBookData data;

		// Token: 0x04028436 RID: 164918
		[Token(Token = "0x4028436")]
		[FieldOffset(Offset = "0x20")]
		public string hp;

		// Token: 0x04028437 RID: 164919
		[Token(Token = "0x4028437")]
		[FieldOffset(Offset = "0x28")]
		public string moveSpeed;

		// Token: 0x04028438 RID: 164920
		[Token(Token = "0x4028438")]
		[FieldOffset(Offset = "0x30")]
		public string attack;

		// Token: 0x04028439 RID: 164921
		[Token(Token = "0x4028439")]
		[FieldOffset(Offset = "0x38")]
		public string def;

		// Token: 0x0402843A RID: 164922
		[Token(Token = "0x402843A")]
		[FieldOffset(Offset = "0x40")]
		public string magDef;

		// Token: 0x0402843B RID: 164923
		[Token(Token = "0x402843B")]
		[FieldOffset(Offset = "0x48")]
		public string attackSpeed;

		// Token: 0x0402843C RID: 164924
		[Token(Token = "0x402843C")]
		[FieldOffset(Offset = "0x50")]
		public string raceName;

		// Token: 0x0402843D RID: 164925
		[Token(Token = "0x402843D")]
		[FieldOffset(Offset = "0x58")]
		public string enemyDamageRes;

		// Token: 0x0402843E RID: 164926
		[Token(Token = "0x402843E")]
		[FieldOffset(Offset = "0x60")]
		public string enemyRes;

		// Token: 0x0402843F RID: 164927
		[Token(Token = "0x402843F")]
		[FieldOffset(Offset = "0x68")]
		public bool isSp;

		// Token: 0x04028440 RID: 164928
		[Token(Token = "0x4028440")]
		[FieldOffset(Offset = "0x69")]
		public bool invisible;

		// Token: 0x04028441 RID: 164929
		[Token(Token = "0x4028441")]
		[FieldOffset(Offset = "0x70")]
		public List<EnemyHandBookEverViewModel.LinkEnemy> linkEnemies;

		// Token: 0x04028442 RID: 164930
		[Token(Token = "0x4028442")]
		[FieldOffset(Offset = "0x78")]
		public bool isInStage;

		// Token: 0x04028443 RID: 164931
		[Token(Token = "0x4028443")]
		[FieldOffset(Offset = "0x79")]
		public bool unlockType;

		// Token: 0x04028444 RID: 164932
		[Token(Token = "0x4028444")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GenAttriParam;

		// Token: 0x04028445 RID: 164933
		[Token(Token = "0x4028445")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_frozenImmune;

		// Token: 0x04028446 RID: 164934
		[Token(Token = "0x4028446")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_levitateImmune;

		// Token: 0x04028447 RID: 164935
		[Token(Token = "0x4028447")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_stunImmune;

		// Token: 0x04028448 RID: 164936
		[Token(Token = "0x4028448")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_disarmImmune;

		// Token: 0x04028449 RID: 164937
		[Token(Token = "0x4028449")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_sleepImmune;

		// Token: 0x0402844A RID: 164938
		[Token(Token = "0x402844A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_fearedImmune;

		// Token: 0x0402844B RID: 164939
		[Token(Token = "0x402844B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_palsyImmune;

		// Token: 0x0402844C RID: 164940
		[Token(Token = "0x402844C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_attractImmune;

		// Token: 0x0402844D RID: 164941
		[Token(Token = "0x402844D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_weight;

		// Token: 0x0402844E RID: 164942
		[Token(Token = "0x402844E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshAttribute;

		// Token: 0x0402844F RID: 164943
		[Token(Token = "0x402844F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04028450 RID: 164944
		[Token(Token = "0x4028450")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x04028451 RID: 164945
		[Token(Token = "0x4028451")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x02004F3F RID: 20287
		[Token(Token = "0x2004F3F")]
		public class LinkEnemy
		{
			// Token: 0x0601E366 RID: 123750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E366")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LinkEnemy()
			{
			}

			// Token: 0x04028452 RID: 164946
			[Token(Token = "0x4028452")]
			[FieldOffset(Offset = "0x10")]
			public string enemyId;

			// Token: 0x04028453 RID: 164947
			[Token(Token = "0x4028453")]
			[FieldOffset(Offset = "0x18")]
			public string enemyName;

			// Token: 0x04028454 RID: 164948
			[Token(Token = "0x4028454")]
			[FieldOffset(Offset = "0x20")]
			public bool isUnlocked;
		}
	}
}
