using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F36 RID: 20278
	[Token(Token = "0x2004F36")]
	public class EnemyHandbookShuffleViewModel : IHotfixable
	{
		// Token: 0x0601E340 RID: 123712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E340")]
		[Address(RVA = "0x17EFA30", Offset = "0x17EE630", VA = "0x1817EFA30")]
		public EnemyHandbookShuffleViewModel.ShufflePatch CreateShufflePatch()
		{
			return null;
		}

		// Token: 0x0601E341 RID: 123713 RVA: 0x000ADD00 File Offset: 0x000ABF00
		[Token(Token = "0x601E341")]
		[Address(RVA = "0x17EF200", Offset = "0x17EDE00", VA = "0x1817EF200")]
		public bool CheckShuffleInfo(EnemyHandBookEverViewModel everViewModel)
		{
			return default(bool);
		}

		// Token: 0x0601E342 RID: 123714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E342")]
		[Address(RVA = "0x17EF5C0", Offset = "0x17EE1C0", VA = "0x1817EF5C0")]
		public void CleanShuffleSelect()
		{
		}

		// Token: 0x0601E343 RID: 123715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E343")]
		[Address(RVA = "0x17EFB40", Offset = "0x17EE740", VA = "0x1817EFB40")]
		public void InitShuffleViewModel()
		{
		}

		// Token: 0x0601E344 RID: 123716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E344")]
		[Address(RVA = "0x17F07F0", Offset = "0x17EF3F0", VA = "0x1817F07F0")]
		private void _dealWithMotionMode()
		{
		}

		// Token: 0x0601E345 RID: 123717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E345")]
		[Address(RVA = "0x17F04D0", Offset = "0x17EF0D0", VA = "0x1817F04D0")]
		private void _dealWithAttackType()
		{
		}

		// Token: 0x0601E346 RID: 123718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E346")]
		[Address(RVA = "0x17F0620", Offset = "0x17EF220", VA = "0x1817F0620")]
		private void _dealWithDamageType()
		{
		}

		// Token: 0x0601E347 RID: 123719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E347")]
		[Address(RVA = "0x17F0260", Offset = "0x17EEE60", VA = "0x1817F0260")]
		public EnemyHandbookShuffleViewModel()
		{
		}

		// Token: 0x04028406 RID: 164870
		[Token(Token = "0x4028406")]
		[FieldOffset(Offset = "0x10")]
		public List<EnemyHandbookShuffleViewModel.MotionTypeShuffleItem> motionTypeList;

		// Token: 0x04028407 RID: 164871
		[Token(Token = "0x4028407")]
		[FieldOffset(Offset = "0x18")]
		public int motionTypeSelectedCount;

		// Token: 0x04028408 RID: 164872
		[Token(Token = "0x4028408")]
		[FieldOffset(Offset = "0x20")]
		public List<EnemyHandbookShuffleViewModel.AttackTypeShuffleItem> attackTypeList;

		// Token: 0x04028409 RID: 164873
		[Token(Token = "0x4028409")]
		[FieldOffset(Offset = "0x28")]
		public int attackTypeSelectedCount;

		// Token: 0x0402840A RID: 164874
		[Token(Token = "0x402840A")]
		[FieldOffset(Offset = "0x30")]
		public List<EnemyHandbookShuffleViewModel.DamageTypeShuffleItem> damageTypeList;

		// Token: 0x0402840B RID: 164875
		[Token(Token = "0x402840B")]
		[FieldOffset(Offset = "0x38")]
		public int damageTypeSelectedCount;

		// Token: 0x0402840C RID: 164876
		[Token(Token = "0x402840C")]
		[FieldOffset(Offset = "0x40")]
		public List<EnemyHandbookShuffleViewModel.RaceShuffleItem> raceShuffleItems;

		// Token: 0x0402840D RID: 164877
		[Token(Token = "0x402840D")]
		[FieldOffset(Offset = "0x48")]
		public int raceSelectedCount;

		// Token: 0x0402840E RID: 164878
		[Token(Token = "0x402840E")]
		[FieldOffset(Offset = "0x50")]
		public EnemyHandbookShuffleViewModel.BossShuffleItem bossShuffleItems;

		// Token: 0x0402840F RID: 164879
		[Token(Token = "0x402840F")]
		[FieldOffset(Offset = "0x58")]
		public bool isIncrease;

		// Token: 0x04028410 RID: 164880
		[Token(Token = "0x4028410")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateShufflePatch;

		// Token: 0x04028411 RID: 164881
		[Token(Token = "0x4028411")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckShuffleInfo;

		// Token: 0x04028412 RID: 164882
		[Token(Token = "0x4028412")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CleanShuffleSelect;

		// Token: 0x04028413 RID: 164883
		[Token(Token = "0x4028413")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitShuffleViewModel;

		// Token: 0x04028414 RID: 164884
		[Token(Token = "0x4028414")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__dealWithMotionMode;

		// Token: 0x04028415 RID: 164885
		[Token(Token = "0x4028415")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__dealWithAttackType;

		// Token: 0x04028416 RID: 164886
		[Token(Token = "0x4028416")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__dealWithDamageType;

		// Token: 0x04028417 RID: 164887
		[Token(Token = "0x4028417")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F37 RID: 20279
		[Token(Token = "0x2004F37")]
		public abstract class ShuffleItem : IHotfixable
		{
			// Token: 0x0601E348 RID: 123720
			[Token(Token = "0x601E348")]
			public abstract bool CheckViewModelMatch(EnemyHandBookEverViewModel viewModel);

			// Token: 0x0601E349 RID: 123721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E349")]
			[Address(RVA = "0x17F50E0", Offset = "0x17F3CE0", VA = "0x1817F50E0")]
			protected ShuffleItem()
			{
			}

			// Token: 0x04028418 RID: 164888
			[Token(Token = "0x4028418")]
			[FieldOffset(Offset = "0x10")]
			public bool isSelected;

			// Token: 0x04028419 RID: 164889
			[Token(Token = "0x4028419")]
			[FieldOffset(Offset = "0x14")]
			public int index;

			// Token: 0x0402841A RID: 164890
			[Token(Token = "0x402841A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004F38 RID: 20280
		[Token(Token = "0x2004F38")]
		public class MotionTypeShuffleItem : EnemyHandbookShuffleViewModel.ShuffleItem
		{
			// Token: 0x0601E34A RID: 123722 RVA: 0x000ADD18 File Offset: 0x000ABF18
			[Token(Token = "0x601E34A")]
			[Address(RVA = "0x17F4960", Offset = "0x17F3560", VA = "0x1817F4960", Slot = "4")]
			public override bool CheckViewModelMatch(EnemyHandBookEverViewModel viewModel)
			{
				return default(bool);
			}

			// Token: 0x0601E34B RID: 123723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E34B")]
			[Address(RVA = "0x17F4A00", Offset = "0x17F3600", VA = "0x1817F4A00")]
			public MotionTypeShuffleItem()
			{
			}

			// Token: 0x0402841B RID: 164891
			[Token(Token = "0x402841B")]
			[FieldOffset(Offset = "0x18")]
			public MotionMode motionMode;

			// Token: 0x0402841C RID: 164892
			[Token(Token = "0x402841C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckViewModelMatch;

			// Token: 0x0402841D RID: 164893
			[Token(Token = "0x402841D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004F39 RID: 20281
		[Token(Token = "0x2004F39")]
		public class AttackTypeShuffleItem : EnemyHandbookShuffleViewModel.ShuffleItem
		{
			// Token: 0x0601E34C RID: 123724 RVA: 0x000ADD30 File Offset: 0x000ABF30
			[Token(Token = "0x601E34C")]
			[Address(RVA = "0x17E0A80", Offset = "0x17DF680", VA = "0x1817E0A80", Slot = "4")]
			public override bool CheckViewModelMatch(EnemyHandBookEverViewModel viewModel)
			{
				return default(bool);
			}

			// Token: 0x0601E34D RID: 123725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E34D")]
			[Address(RVA = "0x17E0B30", Offset = "0x17DF730", VA = "0x1817E0B30")]
			public AttackTypeShuffleItem()
			{
			}

			// Token: 0x0402841E RID: 164894
			[Token(Token = "0x402841E")]
			[FieldOffset(Offset = "0x18")]
			public SourceApplyWay applyWay;

			// Token: 0x0402841F RID: 164895
			[Token(Token = "0x402841F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckViewModelMatch;

			// Token: 0x04028420 RID: 164896
			[Token(Token = "0x4028420")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004F3A RID: 20282
		[Token(Token = "0x2004F3A")]
		public class DamageTypeShuffleItem : EnemyHandbookShuffleViewModel.ShuffleItem
		{
			// Token: 0x0601E34E RID: 123726 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E34E")]
			[Address(RVA = "0x17E10B0", Offset = "0x17DFCB0", VA = "0x1817E10B0")]
			public string GetDamageTypeName()
			{
				return null;
			}

			// Token: 0x0601E34F RID: 123727 RVA: 0x000ADD48 File Offset: 0x000ABF48
			[Token(Token = "0x601E34F")]
			[Address(RVA = "0x17E0FF0", Offset = "0x17DFBF0", VA = "0x1817E0FF0", Slot = "4")]
			public override bool CheckViewModelMatch(EnemyHandBookEverViewModel viewModel)
			{
				return default(bool);
			}

			// Token: 0x0601E350 RID: 123728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E350")]
			[Address(RVA = "0x17E1110", Offset = "0x17DFD10", VA = "0x1817E1110")]
			public DamageTypeShuffleItem()
			{
			}

			// Token: 0x04028421 RID: 164897
			[Token(Token = "0x4028421")]
			[FieldOffset(Offset = "0x18")]
			public EnemyHandBookDamageType damageType;

			// Token: 0x04028422 RID: 164898
			[Token(Token = "0x4028422")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDamageTypeName;

			// Token: 0x04028423 RID: 164899
			[Token(Token = "0x4028423")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CheckViewModelMatch;

			// Token: 0x04028424 RID: 164900
			[Token(Token = "0x4028424")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004F3B RID: 20283
		[Token(Token = "0x2004F3B")]
		public class RaceShuffleItem : EnemyHandbookShuffleViewModel.ShuffleItem
		{
			// Token: 0x170046D0 RID: 18128
			// (get) Token: 0x0601E351 RID: 123729 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170046D0")]
			public string raceName
			{
				[Token(Token = "0x601E351")]
				[Address(RVA = "0x17F5050", Offset = "0x17F3C50", VA = "0x1817F5050")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601E352 RID: 123730 RVA: 0x000ADD60 File Offset: 0x000ABF60
			[Token(Token = "0x601E352")]
			[Address(RVA = "0x17F4EB0", Offset = "0x17F3AB0", VA = "0x1817F4EB0", Slot = "4")]
			public override bool CheckViewModelMatch(EnemyHandBookEverViewModel viewModel)
			{
				return default(bool);
			}

			// Token: 0x0601E353 RID: 123731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E353")]
			[Address(RVA = "0x17F4FB0", Offset = "0x17F3BB0", VA = "0x1817F4FB0")]
			public RaceShuffleItem()
			{
			}

			// Token: 0x04028425 RID: 164901
			[Token(Token = "0x4028425")]
			[FieldOffset(Offset = "0x18")]
			public bool isOther;

			// Token: 0x04028426 RID: 164902
			[Token(Token = "0x4028426")]
			[FieldOffset(Offset = "0x20")]
			public EnemyHandbookRaceData data;

			// Token: 0x04028427 RID: 164903
			[Token(Token = "0x4028427")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_raceName;

			// Token: 0x04028428 RID: 164904
			[Token(Token = "0x4028428")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CheckViewModelMatch;

			// Token: 0x04028429 RID: 164905
			[Token(Token = "0x4028429")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004F3C RID: 20284
		[Token(Token = "0x2004F3C")]
		public class BossShuffleItem : EnemyHandbookShuffleViewModel.ShuffleItem
		{
			// Token: 0x0601E354 RID: 123732 RVA: 0x000ADD78 File Offset: 0x000ABF78
			[Token(Token = "0x601E354")]
			[Address(RVA = "0x17E0BD0", Offset = "0x17DF7D0", VA = "0x1817E0BD0", Slot = "4")]
			public override bool CheckViewModelMatch(EnemyHandBookEverViewModel viewModel)
			{
				return default(bool);
			}

			// Token: 0x0601E355 RID: 123733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E355")]
			[Address(RVA = "0x17E0C60", Offset = "0x17DF860", VA = "0x1817E0C60")]
			public BossShuffleItem()
			{
			}

			// Token: 0x0402842A RID: 164906
			[Token(Token = "0x402842A")]
			[FieldOffset(Offset = "0x18")]
			public EnemyLevelMask levelMask;

			// Token: 0x0402842B RID: 164907
			[Token(Token = "0x402842B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckViewModelMatch;

			// Token: 0x0402842C RID: 164908
			[Token(Token = "0x402842C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004F3D RID: 20285
		[Token(Token = "0x2004F3D")]
		public class ShufflePatch : IHotfixable
		{
			// Token: 0x0601E356 RID: 123734 RVA: 0x000ADD90 File Offset: 0x000ABF90
			[Token(Token = "0x601E356")]
			[Address(RVA = "0x17F5140", Offset = "0x17F3D40", VA = "0x1817F5140")]
			public bool SelectedCountEqual(EnemyHandbookShuffleViewModel.ShufflePatch patch)
			{
				return default(bool);
			}

			// Token: 0x0601E357 RID: 123735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E357")]
			[Address(RVA = "0x17F51F0", Offset = "0x17F3DF0", VA = "0x1817F51F0")]
			public ShufflePatch()
			{
			}

			// Token: 0x0402842D RID: 164909
			[Token(Token = "0x402842D")]
			[FieldOffset(Offset = "0x10")]
			public int motionTypeSelectedCount;

			// Token: 0x0402842E RID: 164910
			[Token(Token = "0x402842E")]
			[FieldOffset(Offset = "0x14")]
			public int attackTypeSelectedCount;

			// Token: 0x0402842F RID: 164911
			[Token(Token = "0x402842F")]
			[FieldOffset(Offset = "0x18")]
			public int damageTypeSelectedCount;

			// Token: 0x04028430 RID: 164912
			[Token(Token = "0x4028430")]
			[FieldOffset(Offset = "0x1C")]
			public int raceSelectedCount;

			// Token: 0x04028431 RID: 164913
			[Token(Token = "0x4028431")]
			[FieldOffset(Offset = "0x20")]
			public EnemyLevelMask levelMask;

			// Token: 0x04028432 RID: 164914
			[Token(Token = "0x4028432")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SelectedCountEqual;

			// Token: 0x04028433 RID: 164915
			[Token(Token = "0x4028433")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
