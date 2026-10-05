using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023B9 RID: 9145
	[Token(Token = "0x20023B9")]
	public struct Modifier : ILuaCallCSharp, IHotfixable
	{
		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x0600E885 RID: 59525 RVA: 0x00054DF8 File Offset: 0x00052FF8
		// (set) Token: 0x0600E886 RID: 59526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D57")]
		public Modifier.TargetType targetType
		{
			[Token(Token = "0x600E885")]
			[Address(RVA = "0x5DA060", Offset = "0x5D8C60", VA = "0x1805DA060")]
			[CompilerGenerated]
			readonly get
			{
				return Modifier.TargetType.HP;
			}
			[Token(Token = "0x600E886")]
			[Address(RVA = "0x5DAC20", Offset = "0x5D9820", VA = "0x1805DAC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x0600E887 RID: 59527 RVA: 0x00054E10 File Offset: 0x00053010
		// (set) Token: 0x0600E888 RID: 59528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D58")]
		public Modifier.DeltaType deltaType
		{
			[Token(Token = "0x600E887")]
			[Address(RVA = "0x5D91A0", Offset = "0x5D7DA0", VA = "0x1805D91A0")]
			[CompilerGenerated]
			readonly get
			{
				return Modifier.DeltaType.CANCELLED;
			}
			[Token(Token = "0x600E888")]
			[Address(RVA = "0x5DA720", Offset = "0x5D9320", VA = "0x1805DA720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x0600E889 RID: 59529 RVA: 0x00054E28 File Offset: 0x00053028
		[Token(Token = "0x17001D59")]
		public bool isCancelled
		{
			[Token(Token = "0x600E889")]
			[Address(RVA = "0x5D9560", Offset = "0x5D8160", VA = "0x1805D9560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x0600E88A RID: 59530 RVA: 0x00054E40 File Offset: 0x00053040
		[Token(Token = "0x17001D5A")]
		public bool isCritical
		{
			[Token(Token = "0x600E88A")]
			[Address(RVA = "0x5D96B0", Offset = "0x5D82B0", VA = "0x1805D96B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x0600E88B RID: 59531 RVA: 0x00054E58 File Offset: 0x00053058
		[Token(Token = "0x17001D5B")]
		public bool isDamage
		{
			[Token(Token = "0x600E88B")]
			[Address(RVA = "0x5D9810", Offset = "0x5D8410", VA = "0x1805D9810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x0600E88C RID: 59532 RVA: 0x00054E70 File Offset: 0x00053070
		[Token(Token = "0x17001D5C")]
		public bool isHeal
		{
			[Token(Token = "0x600E88C")]
			[Address(RVA = "0x5D9BC0", Offset = "0x5D87C0", VA = "0x1805D9BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x0600E88D RID: 59533 RVA: 0x00054E88 File Offset: 0x00053088
		[Token(Token = "0x17001D5D")]
		public bool isElementDamage
		{
			[Token(Token = "0x600E88D")]
			[Address(RVA = "0x5D9960", Offset = "0x5D8560", VA = "0x1805D9960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x0600E88E RID: 59534 RVA: 0x00054EA0 File Offset: 0x000530A0
		[Token(Token = "0x17001D5E")]
		public bool isElementHeal
		{
			[Token(Token = "0x600E88E")]
			[Address(RVA = "0x5D9A90", Offset = "0x5D8690", VA = "0x1805D9A90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x0600E88F RID: 59535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D5F")]
		public Entity source
		{
			[Token(Token = "0x600E88F")]
			[Address(RVA = "0x5D9F60", Offset = "0x5D8B60", VA = "0x1805D9F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x0600E890 RID: 59536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D60")]
		public Entity target
		{
			[Token(Token = "0x600E890")]
			[Address(RVA = "0x5DA140", Offset = "0x5D8D40", VA = "0x1805DA140")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x0600E891 RID: 59537 RVA: 0x00054EB8 File Offset: 0x000530B8
		// (set) Token: 0x0600E892 RID: 59538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D61")]
		public DamageType damageType
		{
			[Token(Token = "0x600E891")]
			[Address(RVA = "0x5D90C0", Offset = "0x5D7CC0", VA = "0x1805D90C0")]
			[CompilerGenerated]
			readonly get
			{
				return DamageType.NONE;
			}
			[Token(Token = "0x600E892")]
			[Address(RVA = "0x5DA620", Offset = "0x5D9220", VA = "0x1805DA620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x0600E893 RID: 59539 RVA: 0x00054ED0 File Offset: 0x000530D0
		// (set) Token: 0x0600E894 RID: 59540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D62")]
		public SourceApplyWay applyWay
		{
			[Token(Token = "0x600E893")]
			[Address(RVA = "0x5D8E20", Offset = "0x5D7A20", VA = "0x1805D8E20")]
			[CompilerGenerated]
			readonly get
			{
				return SourceApplyWay.NONE;
			}
			[Token(Token = "0x600E894")]
			[Address(RVA = "0x5DA320", Offset = "0x5D8F20", VA = "0x1805DA320")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x0600E895 RID: 59541 RVA: 0x00054EE8 File Offset: 0x000530E8
		// (set) Token: 0x0600E896 RID: 59542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D63")]
		public Modifier.CancelReason cancelReason
		{
			[Token(Token = "0x600E895")]
			[Address(RVA = "0x5D8FE0", Offset = "0x5D7BE0", VA = "0x1805D8FE0")]
			[CompilerGenerated]
			readonly get
			{
				return Modifier.CancelReason.NONE;
			}
			[Token(Token = "0x600E896")]
			[Address(RVA = "0x5DA520", Offset = "0x5D9120", VA = "0x1805DA520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x0600E897 RID: 59543 RVA: 0x00054F00 File Offset: 0x00053100
		// (set) Token: 0x0600E898 RID: 59544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D64")]
		public Modifier.SourceAttackType attackType
		{
			[Token(Token = "0x600E897")]
			[Address(RVA = "0x5D8F00", Offset = "0x5D7B00", VA = "0x1805D8F00")]
			[CompilerGenerated]
			readonly get
			{
				return Modifier.SourceAttackType.NONE;
			}
			[Token(Token = "0x600E898")]
			[Address(RVA = "0x5DA420", Offset = "0x5D9020", VA = "0x1805DA420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x0600E899 RID: 59545 RVA: 0x00054F18 File Offset: 0x00053118
		// (set) Token: 0x0600E89A RID: 59546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D65")]
		public ElementType elementType
		{
			[Token(Token = "0x600E899")]
			[Address(RVA = "0x5D9280", Offset = "0x5D7E80", VA = "0x1805D9280")]
			[CompilerGenerated]
			readonly get
			{
				return ElementType.NONE;
			}
			[Token(Token = "0x600E89A")]
			[Address(RVA = "0x5DA820", Offset = "0x5D9420", VA = "0x1805DA820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x0600E89B RID: 59547 RVA: 0x00054F30 File Offset: 0x00053130
		// (set) Token: 0x0600E89C RID: 59548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D66")]
		public FP originAtk
		{
			[Token(Token = "0x600E89B")]
			[Address(RVA = "0x5D9CC0", Offset = "0x5D88C0", VA = "0x1805D9CC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(FP);
			}
			[Token(Token = "0x600E89C")]
			[Address(RVA = "0x5DA920", Offset = "0x5D9520", VA = "0x1805DA920")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x0600E89D RID: 59549 RVA: 0x00054F48 File Offset: 0x00053148
		// (set) Token: 0x0600E89E RID: 59550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D67")]
		public FP originValue
		{
			[Token(Token = "0x600E89D")]
			[Address(RVA = "0x5D9DA0", Offset = "0x5D89A0", VA = "0x1805D9DA0")]
			[CompilerGenerated]
			readonly get
			{
				return default(FP);
			}
			[Token(Token = "0x600E89E")]
			[Address(RVA = "0x5DAA20", Offset = "0x5D9620", VA = "0x1805DAA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x0600E89F RID: 59551 RVA: 0x00054F60 File Offset: 0x00053160
		[Token(Token = "0x17001D68")]
		public FP finalDelta
		{
			[Token(Token = "0x600E89F")]
			[Address(RVA = "0x5D9360", Offset = "0x5D7F60", VA = "0x1805D9360")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x0600E8A0 RID: 59552 RVA: 0x00054F78 File Offset: 0x00053178
		// (set) Token: 0x0600E8A1 RID: 59553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D69")]
		public FP value
		{
			[Token(Token = "0x600E8A0")]
			[Address(RVA = "0x5DA240", Offset = "0x5D8E40", VA = "0x1805DA240")]
			get
			{
				return default(FP);
			}
			[Token(Token = "0x600E8A1")]
			[Address(RVA = "0x5DAD20", Offset = "0x5D9920", VA = "0x1805DAD20")]
			set
			{
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x0600E8A2 RID: 59554 RVA: 0x00054F90 File Offset: 0x00053190
		// (set) Token: 0x0600E8A3 RID: 59555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D6A")]
		public PlayerSide playerSide
		{
			[Token(Token = "0x600E8A2")]
			[Address(RVA = "0x5D9E80", Offset = "0x5D8A80", VA = "0x1805D9E80")]
			[CompilerGenerated]
			readonly get
			{
				return PlayerSide.DEFAULT;
			}
			[Token(Token = "0x600E8A3")]
			[Address(RVA = "0x5DAB20", Offset = "0x5D9720", VA = "0x1805DAB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600E8A4 RID: 59556 RVA: 0x00054FA8 File Offset: 0x000531A8
		[Token(Token = "0x600E8A4")]
		[Address(RVA = "0x5D6160", Offset = "0x5D4D60", VA = "0x1805D6160")]
		public bool Cancel(Modifier.CancelReason reason)
		{
			return default(bool);
		}

		// Token: 0x0600E8A5 RID: 59557 RVA: 0x00054FC0 File Offset: 0x000531C0
		[Token(Token = "0x600E8A5")]
		[Address(RVA = "0x5D6440", Offset = "0x5D5040", VA = "0x1805D6440")]
		public bool CheckIgnoreCancel(Modifier.CancelReason reason)
		{
			return default(bool);
		}

		// Token: 0x0600E8A6 RID: 59558 RVA: 0x00054FD8 File Offset: 0x000531D8
		[Token(Token = "0x600E8A6")]
		[Address(RVA = "0x5D8760", Offset = "0x5D7360", VA = "0x1805D8760")]
		private bool _CheckIgnoreMiss(Modifier.CancelReason reason)
		{
			return default(bool);
		}

		// Token: 0x0600E8A7 RID: 59559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8A7")]
		[Address(RVA = "0x5D5F50", Offset = "0x5D4B50", VA = "0x1805D5F50")]
		public void Assign(Modifier another)
		{
		}

		// Token: 0x0600E8A8 RID: 59560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8A8")]
		[Address(RVA = "0x5D5E40", Offset = "0x5D4A40", VA = "0x1805D5E40")]
		public void AssignSource(ObjectPtr<Entity> source)
		{
		}

		// Token: 0x0600E8A9 RID: 59561 RVA: 0x00054FF0 File Offset: 0x000531F0
		[Token(Token = "0x600E8A9")]
		[Address(RVA = "0x5D8560", Offset = "0x5D7160", VA = "0x1805D8560")]
		public Modifier Split(int cnt)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8AA RID: 59562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8AA")]
		[Address(RVA = "0x5D8340", Offset = "0x5D6F40", VA = "0x1805D8340")]
		public void SetSharedFlag(int flag)
		{
		}

		// Token: 0x0600E8AB RID: 59563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8AB")]
		[Address(RVA = "0x5D8440", Offset = "0x5D7040", VA = "0x1805D8440")]
		public void SetSharedFlag(Modifier.SharedFlagIndex flagIndex)
		{
		}

		// Token: 0x0600E8AC RID: 59564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8AC")]
		[Address(RVA = "0x5D5C80", Offset = "0x5D4880", VA = "0x1805D5C80")]
		public void AddCustomKey(string key)
		{
		}

		// Token: 0x0600E8AD RID: 59565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8AD")]
		[Address(RVA = "0x5D7F10", Offset = "0x5D6B10", VA = "0x1805D7F10")]
		public void RemoveSharedFlag(int flag)
		{
		}

		// Token: 0x0600E8AE RID: 59566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8AE")]
		[Address(RVA = "0x5D8010", Offset = "0x5D6C10", VA = "0x1805D8010")]
		public void RemoveSharedFlag(Modifier.SharedFlagIndex flagIndex)
		{
		}

		// Token: 0x0600E8AF RID: 59567 RVA: 0x00055008 File Offset: 0x00053208
		[Token(Token = "0x600E8AF")]
		[Address(RVA = "0x5D6690", Offset = "0x5D5290", VA = "0x1805D6690")]
		public bool CheckSharedFlag(int flag)
		{
			return default(bool);
		}

		// Token: 0x0600E8B0 RID: 59568 RVA: 0x00055020 File Offset: 0x00053220
		[Token(Token = "0x600E8B0")]
		[Address(RVA = "0x5D6570", Offset = "0x5D5170", VA = "0x1805D6570")]
		public bool CheckSharedFlag(Modifier.SharedFlagIndex flagIndex)
		{
			return default(bool);
		}

		// Token: 0x0600E8B1 RID: 59569 RVA: 0x00055038 File Offset: 0x00053238
		[Token(Token = "0x600E8B1")]
		[Address(RVA = "0x5D62E0", Offset = "0x5D4EE0", VA = "0x1805D62E0")]
		public bool CheckCustomKey(string key)
		{
			return default(bool);
		}

		// Token: 0x0600E8B2 RID: 59570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8B2")]
		[Address(RVA = "0x5D8230", Offset = "0x5D6E30", VA = "0x1805D8230")]
		[Obsolete("Use |ignoreCancelReasonMask| instead")]
		public void SetIgnoreMissFlag(DamageTypeMask flag, bool isOr = false)
		{
		}

		// Token: 0x0600E8B3 RID: 59571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8B3")]
		[Address(RVA = "0x5D8130", Offset = "0x5D6D30", VA = "0x1805D8130")]
		public void SetIgnoreCancelReasonMask(Modifier.CancelReasonMask mask)
		{
		}

		// Token: 0x0600E8B4 RID: 59572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8B4")]
		[Address(RVA = "0x5D8B60", Offset = "0x5D7760", VA = "0x1805D8B60")]
		private Modifier(Modifier.TargetType targetType, Modifier.DeltaType deltaType, FP value, FP rawValue, Entity source, Entity target, PlayerSide playerSide)
		{
		}

		// Token: 0x0600E8B5 RID: 59573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8B5")]
		[Address(RVA = "0x5D89E0", Offset = "0x5D75E0", VA = "0x1805D89E0")]
		private Modifier(Modifier.TargetType targetType, Modifier.DeltaType deltaType, FP value, Entity source, Entity target, PlayerSide playerSide)
		{
		}

		// Token: 0x0600E8B6 RID: 59574 RVA: 0x00055050 File Offset: 0x00053250
		[Token(Token = "0x600E8B6")]
		[Address(RVA = "0x5D6B30", Offset = "0x5D5730", VA = "0x1805D6B30")]
		public static Modifier NewDamageModifierAfterCalculate(FP value, DamageType damageType, SourceApplyWay applyWay, Entity source, Entity target, Modifier.SourceAttackType attackType, FP originAtk)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8B7 RID: 59575 RVA: 0x00055068 File Offset: 0x00053268
		[Token(Token = "0x600E8B7")]
		[Address(RVA = "0x5D6D60", Offset = "0x5D5960", VA = "0x1805D6D60")]
		public static Modifier NewDamageModifierAfterCalculate(FP value, FP rawValue, DamageType damageType, SourceApplyWay applyWay, Entity source, Entity target, Modifier.SourceAttackType attackType, FP originAtk)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8B8 RID: 59576 RVA: 0x00055080 File Offset: 0x00053280
		[Token(Token = "0x600E8B8")]
		[Address(RVA = "0x5D6FA0", Offset = "0x5D5BA0", VA = "0x1805D6FA0")]
		public static Modifier NewElementDamageModifierAfterCalculate(FP value, Entity source, Entity target, ElementType elementDamageType)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8B9 RID: 59577 RVA: 0x00055098 File Offset: 0x00053298
		[Token(Token = "0x600E8B9")]
		[Address(RVA = "0x5D73E0", Offset = "0x5D5FE0", VA = "0x1805D73E0")]
		public static Modifier NewHeal(FP value, Entity source, Entity target, bool isCont)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8BA RID: 59578 RVA: 0x000550B0 File Offset: 0x000532B0
		[Token(Token = "0x600E8BA")]
		[Address(RVA = "0x5D71C0", Offset = "0x5D5DC0", VA = "0x1805D71C0")]
		public static Modifier NewElementHeal(FP value, Entity source, Entity target, bool isCont)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8BB RID: 59579 RVA: 0x000550C8 File Offset: 0x000532C8
		[Token(Token = "0x600E8BB")]
		[Address(RVA = "0x5D7600", Offset = "0x5D6200", VA = "0x1805D7600")]
		public static Modifier NewHp(FP value, Entity source, Entity target)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8BC RID: 59580 RVA: 0x000550E0 File Offset: 0x000532E0
		[Token(Token = "0x600E8BC")]
		[Address(RVA = "0x5D7B70", Offset = "0x5D6770", VA = "0x1805D7B70")]
		public static Modifier NewSp(FP value, Entity source, Entity target)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8BD RID: 59581 RVA: 0x000550F8 File Offset: 0x000532F8
		[Token(Token = "0x600E8BD")]
		[Address(RVA = "0x5D6960", Offset = "0x5D5560", VA = "0x1805D6960")]
		public static Modifier NewCost(FP value, Entity source, PlayerSide playerSide)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8BE RID: 59582 RVA: 0x00055110 File Offset: 0x00053310
		[Token(Token = "0x600E8BE")]
		[Address(RVA = "0x5D79A0", Offset = "0x5D65A0", VA = "0x1805D79A0")]
		public static Modifier NewMaxCost(FP value, Entity source, PlayerSide playerSide)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8BF RID: 59583 RVA: 0x00055128 File Offset: 0x00053328
		[Token(Token = "0x600E8BF")]
		[Address(RVA = "0x5D6790", Offset = "0x5D5390", VA = "0x1805D6790")]
		public static Modifier NewCharacterLimitDelta(int value, Entity source, PlayerSide playerSide)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8C0 RID: 59584 RVA: 0x00055140 File Offset: 0x00053340
		[Token(Token = "0x600E8C0")]
		[Address(RVA = "0x5D77D0", Offset = "0x5D63D0", VA = "0x1805D77D0")]
		public static Modifier NewLifePointDelta(int value, Entity source, PlayerSide playerSide)
		{
			return default(Modifier);
		}

		// Token: 0x0600E8C1 RID: 59585 RVA: 0x00055158 File Offset: 0x00053358
		[Token(Token = "0x600E8C1")]
		[Address(RVA = "0x5D7D40", Offset = "0x5D6940", VA = "0x1805D7D40")]
		public static Modifier NewTrySetHpZero(FP value, Entity source, PlayerSide playerSide)
		{
			return default(Modifier);
		}

		// Token: 0x0401001D RID: 65565
		[Token(Token = "0x401001D")]
		public const int IS_CONTINUOUS_FLAG = 1;

		// Token: 0x0401001E RID: 65566
		[Token(Token = "0x401001E")]
		public const int FORCE_TO_DISPLAY_NUMBER_FLAG = 2;

		// Token: 0x0401001F RID: 65567
		[Token(Token = "0x401001F")]
		public const int FORCE_NOT_TO_DISPLAY_SP_FLAG = 4;

		// Token: 0x04010020 RID: 65568
		[Token(Token = "0x4010020")]
		public const int DAMAGE_IS_UNDEADABLE_THIS_TIME = 8;

		// Token: 0x04010021 RID: 65569
		[Token(Token = "0x4010021")]
		public const int IS_ENVIRONMENT_DAMAGE = 32;

		// Token: 0x04010022 RID: 65570
		[Token(Token = "0x4010022")]
		public const int FORCE_TO_DISPLAY_NEGATIVE_NUMBER_FLAG = 64;

		// Token: 0x04010023 RID: 65571
		[Token(Token = "0x4010023")]
		public const int SKIP_MODIFIER_EVENT = 128;

		// Token: 0x04010024 RID: 65572
		[Token(Token = "0x4010024")]
		public const int DAMAGE_CAN_HURT_SLEEPING_ENTITY = 256;

		// Token: 0x04010025 RID: 65573
		[Token(Token = "0x4010025")]
		public const int LIFE_POINT_LOSS_BY_REACH_EXIT = 512;

		// Token: 0x04010026 RID: 65574
		[Token(Token = "0x4010026")]
		public const int HEAL_CAN_GENERAL_SHIELD_FLAG = 1024;

		// Token: 0x04010027 RID: 65575
		[Token(Token = "0x4010027")]
		public const int ALLOW_ADD_TEMP_LIFE_POINT_FLAG = 4096;

		// Token: 0x04010028 RID: 65576
		[Token(Token = "0x4010028")]
		public const int INSTANT_KILL_LIKE_DAMAGE_FLAG = 8192;

		// Token: 0x04010029 RID: 65577
		[Token(Token = "0x4010029")]
		public const int SKIP_MODIFIER_CONSIDER_UNHURTABLE = 32768;

		// Token: 0x0401002A RID: 65578
		[Token(Token = "0x401002A")]
		public const int IS_NOT_CHANGEABLE_VALUE_MODIFIER = 65536;

		// Token: 0x0401002B RID: 65579
		[Token(Token = "0x401002B")]
		public const int IS_RETRIGGER_SKILL_USING = 131072;

		// Token: 0x0401002C RID: 65580
		[Token(Token = "0x401002C")]
		public const int IS_CAST_SKILL_WITH_COST_USING = 262144;

		// Token: 0x0401002D RID: 65581
		[Token(Token = "0x401002D")]
		public const int APPLY_TO_HAMMER_SUBCLASS_MAIN_TARGET = 524288;

		// Token: 0x0401002E RID: 65582
		[Token(Token = "0x401002E")]
		public const int APPLY_TO_HAMMER_SUBCLASS_SPLASH_TARGET = 1048576;

		// Token: 0x0401002F RID: 65583
		[Token(Token = "0x401002F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Modifier EMPTY;

		// Token: 0x04010030 RID: 65584
		[Token(Token = "0x4010030")]
		[FieldOffset(Offset = "0x0")]
		private ObjectPtr<Entity> m_source;

		// Token: 0x04010031 RID: 65585
		[Token(Token = "0x4010031")]
		[FieldOffset(Offset = "0x10")]
		private ObjectPtr<Entity> m_target;

		// Token: 0x04010032 RID: 65586
		[Token(Token = "0x4010032")]
		[FieldOffset(Offset = "0x20")]
		private FP m_value;

		// Token: 0x04010033 RID: 65587
		[Token(Token = "0x4010033")]
		[FieldOffset(Offset = "0x28")]
		public bool ignoreForSp;

		// Token: 0x04010034 RID: 65588
		[Token(Token = "0x4010034")]
		[FieldOffset(Offset = "0x2C")]
		public int sharedFlagMask;

		// Token: 0x04010035 RID: 65589
		[Token(Token = "0x4010035")]
		[FieldOffset(Offset = "0x30")]
		public DamageTypeMask ignoreMissFlag;

		// Token: 0x04010036 RID: 65590
		[Token(Token = "0x4010036")]
		[FieldOffset(Offset = "0x34")]
		public Modifier.CancelReasonMask ignoreCancelReasonMask;

		// Token: 0x04010037 RID: 65591
		[Token(Token = "0x4010037")]
		[FieldOffset(Offset = "0x38")]
		public FP realDelta;

		// Token: 0x04010038 RID: 65592
		[Token(Token = "0x4010038")]
		[FieldOffset(Offset = "0x40")]
		public FP extraData;

		// Token: 0x04010039 RID: 65593
		[Token(Token = "0x4010039")]
		[FieldOffset(Offset = "0x48")]
		public List<string> customKeys;

		// Token: 0x04010044 RID: 65604
		[Token(Token = "0x4010044")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_targetType;

		// Token: 0x04010045 RID: 65605
		[Token(Token = "0x4010045")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_targetType;

		// Token: 0x04010046 RID: 65606
		[Token(Token = "0x4010046")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_deltaType;

		// Token: 0x04010047 RID: 65607
		[Token(Token = "0x4010047")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_deltaType;

		// Token: 0x04010048 RID: 65608
		[Token(Token = "0x4010048")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_isCancelled;

		// Token: 0x04010049 RID: 65609
		[Token(Token = "0x4010049")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_isCritical;

		// Token: 0x0401004A RID: 65610
		[Token(Token = "0x401004A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_isDamage;

		// Token: 0x0401004B RID: 65611
		[Token(Token = "0x401004B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_isHeal;

		// Token: 0x0401004C RID: 65612
		[Token(Token = "0x401004C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_isElementDamage;

		// Token: 0x0401004D RID: 65613
		[Token(Token = "0x401004D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_isElementHeal;

		// Token: 0x0401004E RID: 65614
		[Token(Token = "0x401004E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_source;

		// Token: 0x0401004F RID: 65615
		[Token(Token = "0x401004F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x04010050 RID: 65616
		[Token(Token = "0x4010050")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_damageType;

		// Token: 0x04010051 RID: 65617
		[Token(Token = "0x4010051")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_set_damageType;

		// Token: 0x04010052 RID: 65618
		[Token(Token = "0x4010052")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_applyWay;

		// Token: 0x04010053 RID: 65619
		[Token(Token = "0x4010053")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_set_applyWay;

		// Token: 0x04010054 RID: 65620
		[Token(Token = "0x4010054")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_cancelReason;

		// Token: 0x04010055 RID: 65621
		[Token(Token = "0x4010055")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_set_cancelReason;

		// Token: 0x04010056 RID: 65622
		[Token(Token = "0x4010056")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_attackType;

		// Token: 0x04010057 RID: 65623
		[Token(Token = "0x4010057")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_set_attackType;

		// Token: 0x04010058 RID: 65624
		[Token(Token = "0x4010058")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_elementType;

		// Token: 0x04010059 RID: 65625
		[Token(Token = "0x4010059")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_set_elementType;

		// Token: 0x0401005A RID: 65626
		[Token(Token = "0x401005A")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_originAtk;

		// Token: 0x0401005B RID: 65627
		[Token(Token = "0x401005B")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_set_originAtk;

		// Token: 0x0401005C RID: 65628
		[Token(Token = "0x401005C")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_originValue;

		// Token: 0x0401005D RID: 65629
		[Token(Token = "0x401005D")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_set_originValue;

		// Token: 0x0401005E RID: 65630
		[Token(Token = "0x401005E")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_finalDelta;

		// Token: 0x0401005F RID: 65631
		[Token(Token = "0x401005F")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_value;

		// Token: 0x04010060 RID: 65632
		[Token(Token = "0x4010060")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_set_value;

		// Token: 0x04010061 RID: 65633
		[Token(Token = "0x4010061")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_playerSide;

		// Token: 0x04010062 RID: 65634
		[Token(Token = "0x4010062")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_set_playerSide;

		// Token: 0x04010063 RID: 65635
		[Token(Token = "0x4010063")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_Cancel;

		// Token: 0x04010064 RID: 65636
		[Token(Token = "0x4010064")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_CheckIgnoreCancel;

		// Token: 0x04010065 RID: 65637
		[Token(Token = "0x4010065")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__CheckIgnoreMiss;

		// Token: 0x04010066 RID: 65638
		[Token(Token = "0x4010066")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_Assign;

		// Token: 0x04010067 RID: 65639
		[Token(Token = "0x4010067")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_AssignSource;

		// Token: 0x04010068 RID: 65640
		[Token(Token = "0x4010068")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_Split;

		// Token: 0x04010069 RID: 65641
		[Token(Token = "0x4010069")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_SetSharedFlag;

		// Token: 0x0401006A RID: 65642
		[Token(Token = "0x401006A")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix1_SetSharedFlag;

		// Token: 0x0401006B RID: 65643
		[Token(Token = "0x401006B")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_AddCustomKey;

		// Token: 0x0401006C RID: 65644
		[Token(Token = "0x401006C")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_RemoveSharedFlag;

		// Token: 0x0401006D RID: 65645
		[Token(Token = "0x401006D")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix1_RemoveSharedFlag;

		// Token: 0x0401006E RID: 65646
		[Token(Token = "0x401006E")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_CheckSharedFlag;

		// Token: 0x0401006F RID: 65647
		[Token(Token = "0x401006F")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix1_CheckSharedFlag;

		// Token: 0x04010070 RID: 65648
		[Token(Token = "0x4010070")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_CheckCustomKey;

		// Token: 0x04010071 RID: 65649
		[Token(Token = "0x4010071")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_SetIgnoreMissFlag;

		// Token: 0x04010072 RID: 65650
		[Token(Token = "0x4010072")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_SetIgnoreCancelReasonMask;

		// Token: 0x04010073 RID: 65651
		[Token(Token = "0x4010073")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04010074 RID: 65652
		[Token(Token = "0x4010074")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x04010075 RID: 65653
		[Token(Token = "0x4010075")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_NewDamageModifierAfterCalculate;

		// Token: 0x04010076 RID: 65654
		[Token(Token = "0x4010076")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix1_NewDamageModifierAfterCalculate;

		// Token: 0x04010077 RID: 65655
		[Token(Token = "0x4010077")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_NewElementDamageModifierAfterCalculate;

		// Token: 0x04010078 RID: 65656
		[Token(Token = "0x4010078")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_NewHeal;

		// Token: 0x04010079 RID: 65657
		[Token(Token = "0x4010079")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_NewElementHeal;

		// Token: 0x0401007A RID: 65658
		[Token(Token = "0x401007A")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_NewHp;

		// Token: 0x0401007B RID: 65659
		[Token(Token = "0x401007B")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_NewSp;

		// Token: 0x0401007C RID: 65660
		[Token(Token = "0x401007C")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_NewCost;

		// Token: 0x0401007D RID: 65661
		[Token(Token = "0x401007D")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_NewMaxCost;

		// Token: 0x0401007E RID: 65662
		[Token(Token = "0x401007E")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_NewCharacterLimitDelta;

		// Token: 0x0401007F RID: 65663
		[Token(Token = "0x401007F")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_NewLifePointDelta;

		// Token: 0x04010080 RID: 65664
		[Token(Token = "0x4010080")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_NewTrySetHpZero;

		// Token: 0x020023BA RID: 9146
		[Token(Token = "0x20023BA")]
		public enum SharedFlagIndex : short
		{
			// Token: 0x04010082 RID: 65666
			[Token(Token = "0x4010082")]
			IS_CONTINUOUS,
			// Token: 0x04010083 RID: 65667
			[Token(Token = "0x4010083")]
			FORCE_TO_DISPLAY_NUMBER,
			// Token: 0x04010084 RID: 65668
			[Token(Token = "0x4010084")]
			FORCE_NOT_TO_DISPLAY_SP,
			// Token: 0x04010085 RID: 65669
			[Token(Token = "0x4010085")]
			DAMAGE_IS_UNDEADABLE_THIS_TIME,
			// Token: 0x04010086 RID: 65670
			[Token(Token = "0x4010086")]
			DAMAGE_WITHOUT_MODIFY,
			// Token: 0x04010087 RID: 65671
			[Token(Token = "0x4010087")]
			IS_ENVIRONMENT_DAMAGE,
			// Token: 0x04010088 RID: 65672
			[Token(Token = "0x4010088")]
			FORCE_TO_DISPLAY_NEGATIVE_NUMER,
			// Token: 0x04010089 RID: 65673
			[Token(Token = "0x4010089")]
			SKIP_MODIFIER_EVENT,
			// Token: 0x0401008A RID: 65674
			[Token(Token = "0x401008A")]
			DAMAGE_CAN_HURT_SLEEPING_ENTITY,
			// Token: 0x0401008B RID: 65675
			[Token(Token = "0x401008B")]
			LIFE_POINT_LOSS_BY_REACH_EXIT,
			// Token: 0x0401008C RID: 65676
			[Token(Token = "0x401008C")]
			HEAL_CAN_GENERAL_SHIELD,
			// Token: 0x0401008D RID: 65677
			[Token(Token = "0x401008D")]
			FORCE_TO_DISPLAY_CRITICAL_NUMBER,
			// Token: 0x0401008E RID: 65678
			[Token(Token = "0x401008E")]
			ALLOW_ADD_TEMP_LIFE_POINT_FLAG,
			// Token: 0x0401008F RID: 65679
			[Token(Token = "0x401008F")]
			INSTANT_KILL_LIKE_DAMAGE,
			// Token: 0x04010090 RID: 65680
			[Token(Token = "0x4010090")]
			IS_ENVIRONMENT_ELEMENT_DAMAGE,
			// Token: 0x04010091 RID: 65681
			[Token(Token = "0x4010091")]
			SKIP_MODIFIER_CONSIDER_UNHURTABLE,
			// Token: 0x04010092 RID: 65682
			[Token(Token = "0x4010092")]
			IS_NOT_CHANGEABLE_VALUE_MODIFIER,
			// Token: 0x04010093 RID: 65683
			[Token(Token = "0x4010093")]
			IS_RETRIGGER_SKILL_USING,
			// Token: 0x04010094 RID: 65684
			[Token(Token = "0x4010094")]
			IS_CAST_SKILL_WITH_COST_USING,
			// Token: 0x04010095 RID: 65685
			[Token(Token = "0x4010095")]
			APPLY_TO_HAMMER_SUBCLASS_MAIN_TARGET,
			// Token: 0x04010096 RID: 65686
			[Token(Token = "0x4010096")]
			APPLY_TO_HAMMER_SUBCLASS_SPLASH_TARGET
		}

		// Token: 0x020023BB RID: 9147
		[Token(Token = "0x20023BB")]
		public enum DeltaType
		{
			// Token: 0x04010098 RID: 65688
			[Token(Token = "0x4010098")]
			CANCELLED,
			// Token: 0x04010099 RID: 65689
			[Token(Token = "0x4010099")]
			ADD,
			// Token: 0x0401009A RID: 65690
			[Token(Token = "0x401009A")]
			MINUS
		}

		// Token: 0x020023BC RID: 9148
		[Token(Token = "0x20023BC")]
		public enum SourceAttackType
		{
			// Token: 0x0401009C RID: 65692
			[Token(Token = "0x401009C")]
			NONE,
			// Token: 0x0401009D RID: 65693
			[Token(Token = "0x401009D")]
			NORMAL,
			// Token: 0x0401009E RID: 65694
			[Token(Token = "0x401009E")]
			SPLASH,
			// Token: 0x0401009F RID: 65695
			[Token(Token = "0x401009F")]
			BUFF = 4,
			// Token: 0x040100A0 RID: 65696
			[Token(Token = "0x40100A0")]
			ADDITION = 8
		}

		// Token: 0x020023BD RID: 9149
		[Token(Token = "0x20023BD")]
		public enum TargetType
		{
			// Token: 0x040100A2 RID: 65698
			[Token(Token = "0x40100A2")]
			HP,
			// Token: 0x040100A3 RID: 65699
			[Token(Token = "0x40100A3")]
			SP,
			// Token: 0x040100A4 RID: 65700
			[Token(Token = "0x40100A4")]
			COST,
			// Token: 0x040100A5 RID: 65701
			[Token(Token = "0x40100A5")]
			CHARCTER_LIMIT,
			// Token: 0x040100A6 RID: 65702
			[Token(Token = "0x40100A6")]
			LIFE_POINT,
			// Token: 0x040100A7 RID: 65703
			[Token(Token = "0x40100A7")]
			EP,
			// Token: 0x040100A8 RID: 65704
			[Token(Token = "0x40100A8")]
			MAX_COST,
			// Token: 0x040100A9 RID: 65705
			[Token(Token = "0x40100A9")]
			TRY_SET_HP_ZERO
		}

		// Token: 0x020023BE RID: 9150
		[Token(Token = "0x20023BE")]
		public enum CancelReason
		{
			// Token: 0x040100AB RID: 65707
			[Token(Token = "0x40100AB")]
			NONE,
			// Token: 0x040100AC RID: 65708
			[Token(Token = "0x40100AC")]
			UNHURTABLE,
			// Token: 0x040100AD RID: 65709
			[Token(Token = "0x40100AD")]
			MISS,
			// Token: 0x040100AE RID: 65710
			[Token(Token = "0x40100AE")]
			BLOCKED,
			// Token: 0x040100AF RID: 65711
			[Token(Token = "0x40100AF")]
			BLOCKED_WITH_DAMAGE_NUMBER,
			// Token: 0x040100B0 RID: 65712
			[Token(Token = "0x40100B0")]
			INTERRUPT,
			// Token: 0x040100B1 RID: 65713
			[Token(Token = "0x40100B1")]
			HIT_FAILED,
			// Token: 0x040100B2 RID: 65714
			[Token(Token = "0x40100B2")]
			MINUS_HEALTH
		}

		// Token: 0x020023BF RID: 9151
		[Token(Token = "0x20023BF")]
		[Flags]
		public enum CancelReasonMask
		{
			// Token: 0x040100B4 RID: 65716
			[Token(Token = "0x40100B4")]
			NONE = 0,
			// Token: 0x040100B5 RID: 65717
			[Token(Token = "0x40100B5")]
			UNHURTABLE = 2,
			// Token: 0x040100B6 RID: 65718
			[Token(Token = "0x40100B6")]
			MISS = 4,
			// Token: 0x040100B7 RID: 65719
			[Token(Token = "0x40100B7")]
			BLOCKED = 8,
			// Token: 0x040100B8 RID: 65720
			[Token(Token = "0x40100B8")]
			BLOCKED_WITH_DAMAGE_NUMBER = 16,
			// Token: 0x040100B9 RID: 65721
			[Token(Token = "0x40100B9")]
			INTERRUPT = 32,
			// Token: 0x040100BA RID: 65722
			[Token(Token = "0x40100BA")]
			HIT_FAILED = 64,
			// Token: 0x040100BB RID: 65723
			[Token(Token = "0x40100BB")]
			MINUS_HEALTH = 128
		}
	}
}
