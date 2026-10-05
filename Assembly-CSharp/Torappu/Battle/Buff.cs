using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.ObjectPool;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200219D RID: 8605
	[Token(Token = "0x200219D")]
	public class Buff : Attributes.IAttributesModifier, IShieldSource, IReusableObject, IReusable, IPtrObject, IComparable<Buff>, IHotfixable
	{
		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x0600D52E RID: 54574 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D52F RID: 54575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019D8")]
		public string key
		{
			[Token(Token = "0x600D52E")]
			[Address(RVA = "0x3597310", Offset = "0x3595F10", VA = "0x183597310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D52F")]
			[Address(RVA = "0x3598570", Offset = "0x3597170", VA = "0x183598570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x0600D530 RID: 54576 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D531 RID: 54577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019D9")]
		public string overrideKey
		{
			[Token(Token = "0x600D530")]
			[Address(RVA = "0x35975C0", Offset = "0x35961C0", VA = "0x1835975C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D531")]
			[Address(RVA = "0x3598720", Offset = "0x3597320", VA = "0x183598720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x0600D532 RID: 54578 RVA: 0x0004D178 File Offset: 0x0004B378
		// (set) Token: 0x0600D533 RID: 54579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019DA")]
		public uint instanceUid
		{
			[Token(Token = "0x600D532")]
			[Address(RVA = "0x3596FC0", Offset = "0x3595BC0", VA = "0x183596FC0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600D533")]
			[Address(RVA = "0x3598440", Offset = "0x3597040", VA = "0x183598440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x0600D534 RID: 54580 RVA: 0x0004D190 File Offset: 0x0004B390
		// (set) Token: 0x0600D535 RID: 54581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019DB")]
		public int priority
		{
			[Token(Token = "0x600D534")]
			[Address(RVA = "0x35976C0", Offset = "0x35962C0", VA = "0x1835976C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600D535")]
			[Address(RVA = "0x35987B0", Offset = "0x35973B0", VA = "0x1835987B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x0600D536 RID: 54582 RVA: 0x0004D1A8 File Offset: 0x0004B3A8
		[Token(Token = "0x170019DC")]
		public int triggerCnt
		{
			[Token(Token = "0x600D536")]
			[Address(RVA = "0x3597BC0", Offset = "0x35967C0", VA = "0x183597BC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x0600D537 RID: 54583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170019DD")]
		public Entity owner
		{
			[Token(Token = "0x600D537")]
			[Address(RVA = "0x3597640", Offset = "0x3596240", VA = "0x183597640")]
			get
			{
				return null;
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x0600D538 RID: 54584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170019DE")]
		public Entity source
		{
			[Token(Token = "0x600D538")]
			[Address(RVA = "0x3597AB0", Offset = "0x35966B0", VA = "0x183597AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x0600D539 RID: 54585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170019DF")]
		public Projectile sourceProjectile
		{
			[Token(Token = "0x600D539")]
			[Address(RVA = "0x3597A20", Offset = "0x3596620", VA = "0x183597A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x0600D53A RID: 54586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170019E0")]
		public Context context
		{
			[Token(Token = "0x600D53A")]
			[Address(RVA = "0x3596CB0", Offset = "0x35958B0", VA = "0x183596CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x0600D53B RID: 54587 RVA: 0x0004D1C0 File Offset: 0x0004B3C0
		// (set) Token: 0x0600D53C RID: 54588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019E1")]
		public long attributeMask
		{
			[Token(Token = "0x600D53B")]
			[Address(RVA = "0x3596B30", Offset = "0x3595730", VA = "0x183596B30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600D53C")]
			[Address(RVA = "0x3598150", Offset = "0x3596D50", VA = "0x183598150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x0600D53D RID: 54589 RVA: 0x0004D1D8 File Offset: 0x0004B3D8
		// (set) Token: 0x0600D53E RID: 54590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019E2")]
		public long abnormalFlagMask
		{
			[Token(Token = "0x600D53D")]
			[Address(RVA = "0x3596A30", Offset = "0x3595630", VA = "0x183596A30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600D53E")]
			[Address(RVA = "0x3598030", Offset = "0x3596C30", VA = "0x183598030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x0600D53F RID: 54591 RVA: 0x0004D1F0 File Offset: 0x0004B3F0
		// (set) Token: 0x0600D540 RID: 54592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019E3")]
		public long abnormalImmuneMask
		{
			[Token(Token = "0x600D53F")]
			[Address(RVA = "0x3596AB0", Offset = "0x35956B0", VA = "0x183596AB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600D540")]
			[Address(RVA = "0x35980C0", Offset = "0x3596CC0", VA = "0x1835980C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x0600D541 RID: 54593 RVA: 0x0004D208 File Offset: 0x0004B408
		// (set) Token: 0x0600D542 RID: 54594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019E4")]
		public long abnormalAntiMask
		{
			[Token(Token = "0x600D541")]
			[Address(RVA = "0x35968B0", Offset = "0x35954B0", VA = "0x1835968B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600D542")]
			[Address(RVA = "0x3597E80", Offset = "0x3596A80", VA = "0x183597E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x0600D543 RID: 54595 RVA: 0x0004D220 File Offset: 0x0004B420
		// (set) Token: 0x0600D544 RID: 54596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019E5")]
		public long abnormalComboMask
		{
			[Token(Token = "0x600D543")]
			[Address(RVA = "0x35969B0", Offset = "0x35955B0", VA = "0x1835969B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600D544")]
			[Address(RVA = "0x3597FA0", Offset = "0x3596BA0", VA = "0x183597FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x0600D545 RID: 54597 RVA: 0x0004D238 File Offset: 0x0004B438
		// (set) Token: 0x0600D546 RID: 54598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019E6")]
		public long abnormalComboImmuneMask
		{
			[Token(Token = "0x600D545")]
			[Address(RVA = "0x3596930", Offset = "0x3595530", VA = "0x183596930", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600D546")]
			[Address(RVA = "0x3597F10", Offset = "0x3596B10", VA = "0x183597F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x0600D547 RID: 54599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170019E7")]
		public Blackboard blackboard
		{
			[Token(Token = "0x600D547")]
			[Address(RVA = "0x3596C30", Offset = "0x3595830", VA = "0x183596C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x0600D548 RID: 54600 RVA: 0x0004D250 File Offset: 0x0004B450
		[Token(Token = "0x170019E8")]
		public RuntimeAttributesSnapshot runtimeAttributesSnapshot
		{
			[Token(Token = "0x600D548")]
			[Address(RVA = "0x35978C0", Offset = "0x35964C0", VA = "0x1835978C0")]
			get
			{
				return default(RuntimeAttributesSnapshot);
			}
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x0600D549 RID: 54601 RVA: 0x0004D268 File Offset: 0x0004B468
		[Token(Token = "0x170019E9")]
		public FP lifeTime
		{
			[Token(Token = "0x600D549")]
			[Address(RVA = "0x3597390", Offset = "0x3595F90", VA = "0x183597390")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x0600D54A RID: 54602 RVA: 0x0004D280 File Offset: 0x0004B480
		[Token(Token = "0x170019EA")]
		public FP remainingTime
		{
			[Token(Token = "0x600D54A")]
			[Address(RVA = "0x3597840", Offset = "0x3596440", VA = "0x183597840")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x0600D54B RID: 54603 RVA: 0x0004D298 File Offset: 0x0004B498
		[Token(Token = "0x170019EB")]
		public FP existingTime
		{
			[Token(Token = "0x600D54B")]
			[Address(RVA = "0x3596EC0", Offset = "0x3595AC0", VA = "0x183596EC0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x0600D54C RID: 54604 RVA: 0x0004D2B0 File Offset: 0x0004B4B0
		[Token(Token = "0x170019EC")]
		public FP remainingRatio
		{
			[Token(Token = "0x600D54C")]
			[Address(RVA = "0x3597730", Offset = "0x3596330", VA = "0x183597730")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x0600D54D RID: 54605 RVA: 0x0004D2C8 File Offset: 0x0004B4C8
		[Token(Token = "0x170019ED")]
		public FP triggerInterval
		{
			[Token(Token = "0x600D54D")]
			[Address(RVA = "0x3597C30", Offset = "0x3596830", VA = "0x183597C30")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x0600D54E RID: 54606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170019EE")]
		public PrecisePeriodicTimer triggerTimer
		{
			[Token(Token = "0x600D54E")]
			[Address(RVA = "0x3597CC0", Offset = "0x35968C0", VA = "0x183597CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x0600D54F RID: 54607 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D550 RID: 54608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019EF")]
		public string effectKey
		{
			[Token(Token = "0x600D54F")]
			[Address(RVA = "0x3596DC0", Offset = "0x35959C0", VA = "0x183596DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D550")]
			[Address(RVA = "0x3598280", Offset = "0x3596E80", VA = "0x183598280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x0600D551 RID: 54609 RVA: 0x0004D2E0 File Offset: 0x0004B4E0
		// (set) Token: 0x0600D552 RID: 54610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019F0")]
		public bool enableInitDirectionFromSource
		{
			[Token(Token = "0x600D551")]
			[Address(RVA = "0x3596E40", Offset = "0x3595A40", VA = "0x183596E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D552")]
			[Address(RVA = "0x3598320", Offset = "0x3596F20", VA = "0x183598320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x0600D553 RID: 54611 RVA: 0x0004D2F8 File Offset: 0x0004B4F8
		// (set) Token: 0x0600D554 RID: 54612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019F1")]
		public BuffData.OnEventPriority onEventPriority
		{
			[Token(Token = "0x600D553")]
			[Address(RVA = "0x35974A0", Offset = "0x35960A0", VA = "0x1835974A0")]
			[CompilerGenerated]
			get
			{
				return BuffData.OnEventPriority.DEFAULT;
			}
			[Token(Token = "0x600D554")]
			[Address(RVA = "0x3598690", Offset = "0x3597290", VA = "0x183598690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x0600D555 RID: 54613 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D556 RID: 54614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019F2")]
		public string audioSignal
		{
			[Token(Token = "0x600D555")]
			[Address(RVA = "0x3596BB0", Offset = "0x35957B0", VA = "0x183596BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D556")]
			[Address(RVA = "0x35981E0", Offset = "0x3596DE0", VA = "0x1835981E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x0600D557 RID: 54615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170019F3")]
		public Ability ability
		{
			[Token(Token = "0x600D557")]
			[Address(RVA = "0x3596820", Offset = "0x3595420", VA = "0x183596820")]
			get
			{
				return null;
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x0600D558 RID: 54616 RVA: 0x0004D310 File Offset: 0x0004B510
		// (set) Token: 0x0600D559 RID: 54617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019F4")]
		public bool triggerable
		{
			[Token(Token = "0x600D558")]
			[Address(RVA = "0x3597D40", Offset = "0x3596940", VA = "0x183597D40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D559")]
			[Address(RVA = "0x3598840", Offset = "0x3597440", VA = "0x183598840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x0600D55A RID: 54618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170019F5")]
		public List<ObjectPtr<Buff>> derivedBuffs
		{
			[Token(Token = "0x600D55A")]
			[Address(RVA = "0x3596D40", Offset = "0x3595940", VA = "0x183596D40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x0600D55B RID: 54619 RVA: 0x0004D328 File Offset: 0x0004B528
		// (set) Token: 0x0600D55C RID: 54620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019F6")]
		public bool isEnabled
		{
			[Token(Token = "0x600D55B")]
			[Address(RVA = "0x3597030", Offset = "0x3595C30", VA = "0x183597030")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D55C")]
			[Address(RVA = "0x35984D0", Offset = "0x35970D0", VA = "0x1835984D0")]
			private set
			{
			}
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x0600D55D RID: 54621 RVA: 0x0004D340 File Offset: 0x0004B540
		[Token(Token = "0x170019F7")]
		public bool isFinished
		{
			[Token(Token = "0x600D55D")]
			[Address(RVA = "0x3597150", Offset = "0x3595D50", VA = "0x183597150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x0600D55E RID: 54622 RVA: 0x0004D358 File Offset: 0x0004B558
		// (set) Token: 0x0600D55F RID: 54623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019F8")]
		public bool needRemove
		{
			[Token(Token = "0x600D55E")]
			[Address(RVA = "0x3597410", Offset = "0x3596010", VA = "0x183597410")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D55F")]
			[Address(RVA = "0x3598600", Offset = "0x3597200", VA = "0x183598600")]
			set
			{
			}
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x0600D560 RID: 54624 RVA: 0x0004D370 File Offset: 0x0004B570
		[Token(Token = "0x170019F9")]
		public bool isFinishedOrDisabled
		{
			[Token(Token = "0x600D560")]
			[Address(RVA = "0x35970B0", Offset = "0x3595CB0", VA = "0x1835970B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x0600D561 RID: 54625 RVA: 0x0004D388 File Offset: 0x0004B588
		[Token(Token = "0x170019FA")]
		public int stackCnt
		{
			[Token(Token = "0x600D561")]
			[Address(RVA = "0x3597B40", Offset = "0x3596740", VA = "0x183597B40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x0600D562 RID: 54626 RVA: 0x0004D3A0 File Offset: 0x0004B5A0
		[Token(Token = "0x170019FB")]
		public int validStackCnt
		{
			[Token(Token = "0x600D562")]
			[Address(RVA = "0x3597DC0", Offset = "0x35969C0", VA = "0x183597DC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x0600D563 RID: 54627 RVA: 0x0004D3B8 File Offset: 0x0004B5B8
		[Token(Token = "0x170019FC")]
		public int overridableStackCnt
		{
			[Token(Token = "0x600D563")]
			[Address(RVA = "0x3597520", Offset = "0x3596120", VA = "0x183597520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x0600D564 RID: 54628 RVA: 0x0004D3D0 File Offset: 0x0004B5D0
		[Token(Token = "0x170019FD")]
		public bool isValid
		{
			[Token(Token = "0x600D564")]
			[Address(RVA = "0x3597290", Offset = "0x3595E90", VA = "0x183597290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x0600D565 RID: 54629 RVA: 0x0004D3E8 File Offset: 0x0004B5E8
		[Token(Token = "0x170019FE")]
		public bool isStatusResistable
		{
			[Token(Token = "0x600D565")]
			[Address(RVA = "0x3597210", Offset = "0x3595E10", VA = "0x183597210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600D566 RID: 54630 RVA: 0x0004D400 File Offset: 0x0004B600
		[Token(Token = "0x600D566")]
		[Address(RVA = "0x358A760", Offset = "0x3589360", VA = "0x18358A760", Slot = "16")]
		public int CompareTo(Buff another)
		{
			return 0;
		}

		// Token: 0x0600D567 RID: 54631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D567")]
		[Address(RVA = "0x3596610", Offset = "0x3595210", VA = "0x183596610")]
		private Buff()
		{
		}

		// Token: 0x0600D568 RID: 54632 RVA: 0x0004D418 File Offset: 0x0004B618
		[Token(Token = "0x600D568")]
		[Address(RVA = "0x3594810", Offset = "0x3593410", VA = "0x183594810")]
		private bool _IsActionValid(Buff.Event ev)
		{
			return default(bool);
		}

		// Token: 0x0600D569 RID: 54633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D569")]
		[Address(RVA = "0x3591510", Offset = "0x3590110", VA = "0x183591510")]
		protected void Reset(BuffConfig config, Buff.BuffContainer container, Entity source, Ability ability, Blackboard extraBlackboard, Blackboard extraBlackboard2, [Optional] Projectile sourceProjectile)
		{
		}

		// Token: 0x0600D56A RID: 54634 RVA: 0x0004D430 File Offset: 0x0004B630
		[Token(Token = "0x600D56A")]
		[Address(RVA = "0x358B570", Offset = "0x358A170", VA = "0x18358B570", Slot = "10")]
		public bool GetValue(AttributeType attribute, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
		{
			return default(bool);
		}

		// Token: 0x0600D56B RID: 54635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D56B")]
		[Address(RVA = "0x3595910", Offset = "0x3594510", VA = "0x183595910")]
		private void _ResetTriggerTimer()
		{
		}

		// Token: 0x0600D56C RID: 54636 RVA: 0x0004D448 File Offset: 0x0004B648
		[Token(Token = "0x600D56C")]
		[Address(RVA = "0x3592840", Offset = "0x3591440", VA = "0x183592840")]
		public bool Trigger(bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600D56D RID: 54637 RVA: 0x0004D460 File Offset: 0x0004B660
		[Token(Token = "0x600D56D")]
		[Address(RVA = "0x3591460", Offset = "0x3590060", VA = "0x183591460")]
		public bool OverrideEffectKey(string effectKey)
		{
			return default(bool);
		}

		// Token: 0x0600D56E RID: 54638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D56E")]
		[Address(RVA = "0x358B8A0", Offset = "0x358A4A0", VA = "0x18358B8A0")]
		public void MarkFinish(bool updateOverrideMap)
		{
		}

		// Token: 0x0600D56F RID: 54639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D56F")]
		[Address(RVA = "0x358ACB0", Offset = "0x35898B0", VA = "0x18358ACB0")]
		public void DecStackCntOrMarkFinish(bool updateOverrideMap, bool isTimeUp = false, int decCnt = 1)
		{
		}

		// Token: 0x0600D570 RID: 54640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D570")]
		[Address(RVA = "0x3595E40", Offset = "0x3594A40", VA = "0x183595E40")]
		private void _SetAttributeModifier(AttributeType attribute, FP addition, FP scale, FP finalAddition, FP finalScaler)
		{
		}

		// Token: 0x0600D571 RID: 54641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D571")]
		[Address(RVA = "0x3595FA0", Offset = "0x3594BA0", VA = "0x183595FA0")]
		private void _SetAttributeModifier(AttributeType attribute, AttributeModifierData.AttributeModifier.FormulaItemType formula, FP value)
		{
		}

		// Token: 0x0600D572 RID: 54642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D572")]
		[Address(RVA = "0x3592A80", Offset = "0x3591680", VA = "0x183592A80")]
		public void TryUpdateAttributeModifier(AttributeType attribute, FP addition, FP scale, FP finalAddition, FP finalScaler)
		{
		}

		// Token: 0x0600D573 RID: 54643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D573")]
		[Address(RVA = "0x3592970", Offset = "0x3591570", VA = "0x183592970")]
		public void TryUpdateAttributeModifier(AttributeType attribute, FP addition, FP scale, FP finalAddition)
		{
		}

		// Token: 0x0600D574 RID: 54644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D574")]
		[Address(RVA = "0x3592DE0", Offset = "0x35919E0", VA = "0x183592DE0")]
		public void TryUpdateAttributeModifier(AttributeType attribute, FP addition, FP scale)
		{
		}

		// Token: 0x0600D575 RID: 54645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D575")]
		[Address(RVA = "0x3593070", Offset = "0x3591C70", VA = "0x183593070")]
		public void TryUpdateAttributeModifier(AttributeType attribute, FP addition)
		{
		}

		// Token: 0x0600D576 RID: 54646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D576")]
		[Address(RVA = "0x3592EE0", Offset = "0x3591AE0", VA = "0x183592EE0")]
		public void TryUpdateAttributeModifier(AttributeType attribute, AttributeModifierData.AttributeModifier.FormulaItemType formula, FP value)
		{
		}

		// Token: 0x0600D577 RID: 54647 RVA: 0x0004D478 File Offset: 0x0004B678
		[Token(Token = "0x600D577")]
		[Address(RVA = "0x358A400", Offset = "0x3589000", VA = "0x18358A400")]
		public bool CheckAttributeModifier(AttributeType attribute, AttributeModifierData.AttributeModifier.FormulaItemType type, FP value)
		{
			return default(bool);
		}

		// Token: 0x0600D578 RID: 54648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D578")]
		[Address(RVA = "0x3592490", Offset = "0x3591090", VA = "0x183592490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600D579 RID: 54649 RVA: 0x0004D490 File Offset: 0x0004B690
		[Token(Token = "0x600D579")]
		[Address(RVA = "0x358AE10", Offset = "0x3589A10", VA = "0x18358AE10")]
		public static FP FetchDuration(BuffData data, Blackboard extraBlackboard, Blackboard extraBlackboard2)
		{
			return default(FP);
		}

		// Token: 0x0600D57A RID: 54650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D57A")]
		[Address(RVA = "0x3589F00", Offset = "0x3588B00", VA = "0x183589F00")]
		public static void AddDerivedBuffSafe(Buff parentBuff, Buff derivedBuff, bool finishDerivedBuffIfParentFinish = false)
		{
		}

		// Token: 0x0600D57B RID: 54651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D57B")]
		[Address(RVA = "0x358B480", Offset = "0x358A080", VA = "0x18358B480")]
		[Obsolete("You SHALL NOT use it, unless you know what you are doing.")]
		public void ForceSetLifeTimeAndRemainingTime_Unsafe(FP newLifeTime)
		{
		}

		// Token: 0x0600D57C RID: 54652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D57C")]
		[Address(RVA = "0x358C1A0", Offset = "0x358ADA0", VA = "0x18358C1A0", Slot = "13")]
		public void OnAllocate()
		{
		}

		// Token: 0x0600D57D RID: 54653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D57D")]
		[Address(RVA = "0x3590410", Offset = "0x358F010", VA = "0x183590410", Slot = "14")]
		public void OnRecycle()
		{
		}

		// Token: 0x0600D57E RID: 54654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D57E")]
		[Address(RVA = "0x358E070", Offset = "0x358CC70", VA = "0x18358E070")]
		protected void OnEnable()
		{
		}

		// Token: 0x0600D57F RID: 54655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D57F")]
		[Address(RVA = "0x358DE40", Offset = "0x358CA40", VA = "0x18358DE40")]
		protected void OnDisable()
		{
		}

		// Token: 0x0600D580 RID: 54656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D580")]
		[Address(RVA = "0x35908B0", Offset = "0x358F4B0", VA = "0x1835908B0")]
		protected void OnStart()
		{
		}

		// Token: 0x0600D581 RID: 54657 RVA: 0x0004D4A8 File Offset: 0x0004B6A8
		[Token(Token = "0x600D581")]
		[Address(RVA = "0x358E730", Offset = "0x358D330", VA = "0x18358E730")]
		protected bool OnFinish(bool immediatelyFinishEffect)
		{
			return default(bool);
		}

		// Token: 0x0600D582 RID: 54658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D582")]
		[Address(RVA = "0x35912C0", Offset = "0x358FEC0", VA = "0x1835912C0")]
		protected void OnTrigger()
		{
		}

		// Token: 0x0600D583 RID: 54659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D583")]
		[Address(RVA = "0x3590DF0", Offset = "0x358F9F0", VA = "0x183590DF0")]
		protected void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600D584 RID: 54660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D584")]
		[Address(RVA = "0x358EB30", Offset = "0x358D730", VA = "0x18358EB30")]
		protected void OnLateTick()
		{
		}

		// Token: 0x0600D585 RID: 54661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D585")]
		[Address(RVA = "0x358A030", Offset = "0x3588C30", VA = "0x18358A030")]
		public void AddDerivedBuff(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x0600D586 RID: 54662 RVA: 0x0004D4C0 File Offset: 0x0004B6C0
		[Token(Token = "0x600D586")]
		[Address(RVA = "0x358A880", Offset = "0x3589480", VA = "0x18358A880")]
		public bool ContainsAnyDerivedBuff()
		{
			return default(bool);
		}

		// Token: 0x0600D587 RID: 54663 RVA: 0x0004D4D8 File Offset: 0x0004B6D8
		[Token(Token = "0x600D587")]
		[Address(RVA = "0x358A9C0", Offset = "0x35895C0", VA = "0x18358A9C0")]
		public bool ContainsDerivedBuff(string buffKey)
		{
			return default(bool);
		}

		// Token: 0x0600D588 RID: 54664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D588")]
		[Address(RVA = "0x358F940", Offset = "0x358E540", VA = "0x18358F940")]
		protected void OnOwnerBorn()
		{
		}

		// Token: 0x0600D589 RID: 54665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D589")]
		[Address(RVA = "0x358FFD0", Offset = "0x358EBD0", VA = "0x18358FFD0")]
		protected void OnOwnerPostBorn()
		{
		}

		// Token: 0x0600D58A RID: 54666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D58A")]
		[Address(RVA = "0x358FE70", Offset = "0x358EA70", VA = "0x18358FE70")]
		protected void OnOwnerLocate()
		{
		}

		// Token: 0x0600D58B RID: 54667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D58B")]
		[Address(RVA = "0x358FAA0", Offset = "0x358E6A0", VA = "0x18358FAA0")]
		protected void OnOwnerFinish(Entity.FinishReason reason, Entity source)
		{
		}

		// Token: 0x0600D58C RID: 54668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D58C")]
		[Address(RVA = "0x3590080", Offset = "0x358EC80", VA = "0x183590080")]
		protected void OnOwnerReborn()
		{
		}

		// Token: 0x0600D58D RID: 54669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D58D")]
		[Address(RVA = "0x358F9F0", Offset = "0x358E5F0", VA = "0x18358F9F0")]
		protected void OnOwnerDying()
		{
		}

		// Token: 0x0600D58E RID: 54670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D58E")]
		[Address(RVA = "0x358E870", Offset = "0x358D470", VA = "0x18358E870")]
		protected void OnGameOver()
		{
		}

		// Token: 0x0600D58F RID: 54671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D58F")]
		[Address(RVA = "0x358CA40", Offset = "0x358B640", VA = "0x18358CA40")]
		protected void OnBeforeApplyingModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600D590 RID: 54672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D590")]
		[Address(RVA = "0x358C490", Offset = "0x358B090", VA = "0x18358C490")]
		protected void OnApplyingModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600D591 RID: 54673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D591")]
		[Address(RVA = "0x358C2C0", Offset = "0x358AEC0", VA = "0x18358C2C0")]
		protected void OnAppliedModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600D592 RID: 54674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D592")]
		[Address(RVA = "0x358C660", Offset = "0x358B260", VA = "0x18358C660")]
		protected void OnApplyingSkippedModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600D593 RID: 54675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D593")]
		[Address(RVA = "0x358F4B0", Offset = "0x358E0B0", VA = "0x18358F4B0")]
		protected void OnOutputModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600D594 RID: 54676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D594")]
		[Address(RVA = "0x358D190", Offset = "0x358BD90", VA = "0x18358D190")]
		protected void OnBeforeTargetApplyModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600D595 RID: 54677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D595")]
		[Address(RVA = "0x358BF30", Offset = "0x358AB30", VA = "0x18358BF30")]
		protected void OnAfterOutputDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600D596 RID: 54678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D596")]
		[Address(RVA = "0x358C0D0", Offset = "0x358ACD0", VA = "0x18358C0D0")]
		protected void OnAfterOutputHeal(ref Modifier modifier)
		{
		}

		// Token: 0x0600D597 RID: 54679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D597")]
		[Address(RVA = "0x358C000", Offset = "0x358AC00", VA = "0x18358C000")]
		protected void OnAfterOutputElementDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600D598 RID: 54680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D598")]
		[Address(RVA = "0x358D9E0", Offset = "0x358C5E0", VA = "0x18358D9E0")]
		protected void OnCalculateCachedProjectileDamage(ref BattleFormula.AttackInfo atkInfo)
		{
		}

		// Token: 0x0600D599 RID: 54681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D599")]
		[Address(RVA = "0x358DB60", Offset = "0x358C760", VA = "0x18358DB60")]
		protected void OnCalculateDamage(ref BattleFormula.AttackInfo atkInfo)
		{
		}

		// Token: 0x0600D59A RID: 54682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D59A")]
		[Address(RVA = "0x358BE80", Offset = "0x358AA80", VA = "0x18358BE80")]
		protected void OnAfterCalculateDamage()
		{
		}

		// Token: 0x0600D59B RID: 54683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D59B")]
		[Address(RVA = "0x358D5E0", Offset = "0x358C1E0", VA = "0x18358D5E0")]
		protected void OnBeingCalculateDamage(ref BattleFormula.AttackInfo atkInfo)
		{
		}

		// Token: 0x0600D59C RID: 54684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D59C")]
		[Address(RVA = "0x3590990", Offset = "0x358F590", VA = "0x183590990")]
		protected void OnTakeDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600D59D RID: 54685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D59D")]
		[Address(RVA = "0x3590B60", Offset = "0x358F760", VA = "0x183590B60")]
		protected void OnTakeEPDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600D59E RID: 54686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D59E")]
		[Address(RVA = "0x358F2E0", Offset = "0x358DEE0", VA = "0x18358F2E0")]
		protected void OnOutputDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600D59F RID: 54687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D59F")]
		[Address(RVA = "0x358F230", Offset = "0x358DE30", VA = "0x18358F230")]
		protected void OnOutputAtkOrHeal()
		{
		}

		// Token: 0x0600D5A0 RID: 54688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5A0")]
		[Address(RVA = "0x358F180", Offset = "0x358DD80", VA = "0x18358F180")]
		protected void OnOutputAtkOrHealEachSpell()
		{
		}

		// Token: 0x0600D5A1 RID: 54689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5A1")]
		[Address(RVA = "0x358E560", Offset = "0x358D160", VA = "0x18358E560")]
		protected void OnEvadeDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600D5A2 RID: 54690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5A2")]
		[Address(RVA = "0x358D760", Offset = "0x358C360", VA = "0x18358D760")]
		protected void OnBlockDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600D5A3 RID: 54691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5A3")]
		[Address(RVA = "0x3590D30", Offset = "0x358F930", VA = "0x183590D30")]
		protected void OnTargetKilled(Entity target)
		{
		}

		// Token: 0x0600D5A4 RID: 54692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5A4")]
		[Address(RVA = "0x358BD20", Offset = "0x358A920", VA = "0x18358BD20")]
		protected void OnAbilityStart()
		{
		}

		// Token: 0x0600D5A5 RID: 54693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5A5")]
		[Address(RVA = "0x358F020", Offset = "0x358DC20", VA = "0x18358F020")]
		protected void OnOtherBuffStart()
		{
		}

		// Token: 0x0600D5A6 RID: 54694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5A6")]
		[Address(RVA = "0x358BB10", Offset = "0x358A710", VA = "0x18358BB10")]
		protected void OnAbilityFinish()
		{
		}

		// Token: 0x0600D5A7 RID: 54695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5A7")]
		[Address(RVA = "0x358C8E0", Offset = "0x358B4E0", VA = "0x18358C8E0")]
		protected void OnBeforeAbilitySpellOn()
		{
		}

		// Token: 0x0600D5A8 RID: 54696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5A8")]
		[Address(RVA = "0x358BC70", Offset = "0x358A870", VA = "0x18358BC70")]
		protected void OnAbilitySpellOn()
		{
		}

		// Token: 0x0600D5A9 RID: 54697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5A9")]
		[Address(RVA = "0x358BA60", Offset = "0x358A660", VA = "0x18358BA60")]
		protected void OnAbilityCastOnTarget()
		{
		}

		// Token: 0x0600D5AA RID: 54698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5AA")]
		[Address(RVA = "0x3590750", Offset = "0x358F350", VA = "0x183590750")]
		protected void OnSkillStart()
		{
		}

		// Token: 0x0600D5AB RID: 54699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5AB")]
		[Address(RVA = "0x3591160", Offset = "0x358FD60", VA = "0x183591160")]
		protected void OnToggleSkillStart()
		{
		}

		// Token: 0x0600D5AC RID: 54700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5AC")]
		[Address(RVA = "0x35906A0", Offset = "0x358F2A0", VA = "0x1835906A0")]
		protected void OnSkillRetriggered()
		{
		}

		// Token: 0x0600D5AD RID: 54701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5AD")]
		[Address(RVA = "0x3590540", Offset = "0x358F140", VA = "0x183590540")]
		protected void OnSkillCastSucceed()
		{
		}

		// Token: 0x0600D5AE RID: 54702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5AE")]
		[Address(RVA = "0x35905F0", Offset = "0x358F1F0", VA = "0x1835905F0")]
		protected void OnSkillFinish()
		{
		}

		// Token: 0x0600D5AF RID: 54703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5AF")]
		[Address(RVA = "0x358CC10", Offset = "0x358B810", VA = "0x18358CC10")]
		protected void OnBeforeAttack()
		{
		}

		// Token: 0x0600D5B0 RID: 54704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5B0")]
		[Address(RVA = "0x358BDD0", Offset = "0x358A9D0", VA = "0x18358BDD0")]
		protected void OnAfterAttack()
		{
		}

		// Token: 0x0600D5B1 RID: 54705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5B1")]
		[Address(RVA = "0x358D410", Offset = "0x358C010", VA = "0x18358D410")]
		protected void OnBeforeTrySetHpZero(ref Modifier modifier)
		{
		}

		// Token: 0x0600D5B2 RID: 54706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5B2")]
		[Address(RVA = "0x3590290", Offset = "0x358EE90", VA = "0x183590290")]
		protected void OnPostTrySetHpZero()
		{
		}

		// Token: 0x0600D5B3 RID: 54707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5B3")]
		[Address(RVA = "0x358D360", Offset = "0x358BF60", VA = "0x18358D360")]
		protected void OnBeforeTrySetEpZero()
		{
		}

		// Token: 0x0600D5B4 RID: 54708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5B4")]
		[Address(RVA = "0x358CD70", Offset = "0x358B970", VA = "0x18358CD70")]
		protected void OnBeforeDisappear()
		{
		}

		// Token: 0x0600D5B5 RID: 54709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5B5")]
		[Address(RVA = "0x358C990", Offset = "0x358B590", VA = "0x18358C990")]
		protected void OnBeforeAppear()
		{
		}

		// Token: 0x0600D5B6 RID: 54710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5B6")]
		[Address(RVA = "0x358F680", Offset = "0x358E280", VA = "0x18358F680")]
		protected void OnOwnerAbnormalFlagDirty()
		{
		}

		// Token: 0x0600D5B7 RID: 54711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5B7")]
		[Address(RVA = "0x358F890", Offset = "0x358E490", VA = "0x18358F890")]
		protected void OnOwnerBlockeeChanged()
		{
		}

		// Token: 0x0600D5B8 RID: 54712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5B8")]
		[Address(RVA = "0x358F7E0", Offset = "0x358E3E0", VA = "0x18358F7E0")]
		protected void OnOwnerBlockModeChanged()
		{
		}

		// Token: 0x0600D5B9 RID: 54713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5B9")]
		[Address(RVA = "0x358DCE0", Offset = "0x358C8E0", VA = "0x18358DCE0")]
		protected void OnCollideWithHighLand()
		{
		}

		// Token: 0x0600D5BA RID: 54714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5BA")]
		[Address(RVA = "0x358D030", Offset = "0x358BC30", VA = "0x18358D030")]
		protected void OnBeforeExitUnbalancedState()
		{
		}

		// Token: 0x0600D5BB RID: 54715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5BB")]
		[Address(RVA = "0x358E350", Offset = "0x358CF50", VA = "0x18358E350")]
		protected void OnEnterUnbalancedState()
		{
		}

		// Token: 0x0600D5BC RID: 54716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5BC")]
		[Address(RVA = "0x358E2A0", Offset = "0x358CEA0", VA = "0x18358E2A0")]
		protected void OnEnterMagicCircuit()
		{
		}

		// Token: 0x0600D5BD RID: 54717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5BD")]
		[Address(RVA = "0x358EC00", Offset = "0x358D800", VA = "0x18358EC00")]
		protected void OnLeaveMagicCircuit()
		{
		}

		// Token: 0x0600D5BE RID: 54718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5BE")]
		[Address(RVA = "0x358BBC0", Offset = "0x358A7C0", VA = "0x18358BBC0")]
		protected void OnAbilityInterrupted()
		{
		}

		// Token: 0x0600D5BF RID: 54719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5BF")]
		[Address(RVA = "0x3590130", Offset = "0x358ED30", VA = "0x183590130")]
		protected void OnOwnerRootTileChanged()
		{
		}

		// Token: 0x0600D5C0 RID: 54720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5C0")]
		[Address(RVA = "0x358F0D0", Offset = "0x358DCD0", VA = "0x18358F0D0")]
		protected void OnOtherResistableBuffStart()
		{
		}

		// Token: 0x0600D5C1 RID: 54721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5C1")]
		[Address(RVA = "0x358E4B0", Offset = "0x358D0B0", VA = "0x18358E4B0")]
		protected void OnEsOverZero()
		{
		}

		// Token: 0x0600D5C2 RID: 54722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5C2")]
		[Address(RVA = "0x358EF70", Offset = "0x358DB70", VA = "0x18358EF70")]
		protected void OnMotionModeChanged()
		{
		}

		// Token: 0x0600D5C3 RID: 54723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5C3")]
		[Address(RVA = "0x358DD90", Offset = "0x358C990", VA = "0x18358DD90")]
		protected void OnDirectionChanged()
		{
		}

		// Token: 0x0600D5C4 RID: 54724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5C4")]
		[Address(RVA = "0x358CCC0", Offset = "0x358B8C0", VA = "0x18358CCC0")]
		protected void OnBeforeDirectionChange()
		{
		}

		// Token: 0x0600D5C5 RID: 54725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5C5")]
		[Address(RVA = "0x358EEC0", Offset = "0x358DAC0", VA = "0x18358EEC0")]
		protected void OnMakeEnemyUnbalanced()
		{
		}

		// Token: 0x0600D5C6 RID: 54726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5C6")]
		[Address(RVA = "0x358E1F0", Offset = "0x358CDF0", VA = "0x18358E1F0")]
		protected void OnEnterLevitateState()
		{
		}

		// Token: 0x0600D5C7 RID: 54727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5C7")]
		[Address(RVA = "0x358DFC0", Offset = "0x358CBC0", VA = "0x18358DFC0")]
		protected void OnEPBreakStart()
		{
		}

		// Token: 0x0600D5C8 RID: 54728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5C8")]
		[Address(RVA = "0x358CED0", Offset = "0x358BAD0", VA = "0x18358CED0")]
		protected void OnBeforeEPBreakStart()
		{
		}

		// Token: 0x0600D5C9 RID: 54729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5C9")]
		[Address(RVA = "0x358DF10", Offset = "0x358CB10", VA = "0x18358DF10")]
		protected void OnEPBreakFinish()
		{
		}

		// Token: 0x0600D5CA RID: 54730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5CA")]
		[Address(RVA = "0x358CE20", Offset = "0x358BA20", VA = "0x18358CE20")]
		protected void OnBeforeEPBreakFinish()
		{
		}

		// Token: 0x0600D5CB RID: 54731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5CB")]
		[Address(RVA = "0x358CF80", Offset = "0x358BB80", VA = "0x18358CF80")]
		protected void OnBeforeExitLevitateState()
		{
		}

		// Token: 0x0600D5CC RID: 54732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5CC")]
		[Address(RVA = "0x358E140", Offset = "0x358CD40", VA = "0x18358E140")]
		protected void OnEndPulling()
		{
		}

		// Token: 0x0600D5CD RID: 54733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5CD")]
		[Address(RVA = "0x358D0E0", Offset = "0x358BCE0", VA = "0x18358D0E0")]
		protected void OnBeforeFallDown()
		{
		}

		// Token: 0x0600D5CE RID: 54734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5CE")]
		[Address(RVA = "0x358FF20", Offset = "0x358EB20", VA = "0x18358FF20")]
		protected void OnOwnerOverlapped()
		{
		}

		// Token: 0x0600D5CF RID: 54735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5CF")]
		[Address(RVA = "0x358D930", Offset = "0x358C530", VA = "0x18358D930")]
		protected void OnBossWaveWillStart()
		{
		}

		// Token: 0x0600D5D0 RID: 54736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5D0")]
		[Address(RVA = "0x3590800", Offset = "0x358F400", VA = "0x183590800")]
		protected void OnStageEnd()
		{
		}

		// Token: 0x0600D5D1 RID: 54737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5D1")]
		[Address(RVA = "0x358ED60", Offset = "0x358D960", VA = "0x18358ED60")]
		protected void OnLegionModeDrawCard()
		{
		}

		// Token: 0x0600D5D2 RID: 54738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5D2")]
		[Address(RVA = "0x358EE10", Offset = "0x358DA10", VA = "0x18358EE10")]
		protected void OnLegionModeRefreshCard()
		{
		}

		// Token: 0x0600D5D3 RID: 54739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5D3")]
		[Address(RVA = "0x3590490", Offset = "0x358F090", VA = "0x183590490")]
		protected void OnSandboxOwnerResChanged()
		{
		}

		// Token: 0x0600D5D4 RID: 54740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5D4")]
		[Address(RVA = "0x358C830", Offset = "0x358B430", VA = "0x18358C830")]
		protected void OnAutoChessModeChanged()
		{
		}

		// Token: 0x0600D5D5 RID: 54741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5D5")]
		[Address(RVA = "0x358E400", Offset = "0x358D000", VA = "0x18358E400")]
		protected void OnEntityWillOverlap()
		{
		}

		// Token: 0x0600D5D6 RID: 54742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5D6")]
		[Address(RVA = "0x358F730", Offset = "0x358E330", VA = "0x18358F730")]
		protected void OnOwnerBeforeDead()
		{
		}

		// Token: 0x0600D5D7 RID: 54743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5D7")]
		[Address(RVA = "0x358FDC0", Offset = "0x358E9C0", VA = "0x18358FDC0")]
		protected void OnOwnerHpFull()
		{
		}

		// Token: 0x0600D5D8 RID: 54744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5D8")]
		[Address(RVA = "0x35913B0", Offset = "0x358FFB0", VA = "0x1835913B0")]
		protected void OnUnitSwitchMode()
		{
		}

		// Token: 0x0600D5D9 RID: 54745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5D9")]
		[Address(RVA = "0x35901E0", Offset = "0x358EDE0", VA = "0x1835901E0")]
		protected void OnPalsyOverflow()
		{
		}

		// Token: 0x0600D5DA RID: 54746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5DA")]
		[Address(RVA = "0x3591210", Offset = "0x358FE10", VA = "0x183591210")]
		protected void OnTriggerPalsy()
		{
		}

		// Token: 0x0600D5DB RID: 54747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5DB")]
		[Address(RVA = "0x358AB50", Offset = "0x3589750", VA = "0x18358AB50")]
		protected void CooperatePlayerDying()
		{
		}

		// Token: 0x0600D5DC RID: 54748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5DC")]
		[Address(RVA = "0x358AC00", Offset = "0x3589800", VA = "0x18358AC00")]
		protected void CooperatePlayerRevive()
		{
		}

		// Token: 0x0600D5DD RID: 54749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5DD")]
		[Address(RVA = "0x358ECB0", Offset = "0x358D8B0", VA = "0x18358ECB0")]
		protected void OnLegionModeDangerLevelRefresh()
		{
		}

		// Token: 0x0600D5DE RID: 54750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5DE")]
		[Address(RVA = "0x358EA80", Offset = "0x358D680", VA = "0x18358EA80")]
		protected void OnHalfIdleTrapCheckUpgrade()
		{
		}

		// Token: 0x0600D5DF RID: 54751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5DF")]
		[Address(RVA = "0x358E9D0", Offset = "0x358D5D0", VA = "0x18358E9D0")]
		protected void OnHalfIdleKawaPolluted()
		{
		}

		// Token: 0x0600D5E0 RID: 54752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5E0")]
		[Address(RVA = "0x358E920", Offset = "0x358D520", VA = "0x18358E920")]
		protected void OnHalfIdleKawaCleaned()
		{
		}

		// Token: 0x0600D5E1 RID: 54753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5E1")]
		[Address(RVA = "0x358B740", Offset = "0x358A340", VA = "0x18358B740")]
		protected void HalfIdleGainEquip()
		{
		}

		// Token: 0x0600D5E2 RID: 54754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5E2")]
		[Address(RVA = "0x358B7F0", Offset = "0x358A3F0", VA = "0x18358B7F0")]
		protected void HalfIdleGainTrap()
		{
		}

		// Token: 0x0600D5E3 RID: 54755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5E3")]
		[Address(RVA = "0x3590340", Offset = "0x358EF40", VA = "0x183590340")]
		protected void OnProjectileSelectTargets(int targetCount)
		{
		}

		// Token: 0x0600D5E4 RID: 54756 RVA: 0x0004D4F0 File Offset: 0x0004B6F0
		[Token(Token = "0x600D5E4")]
		[Address(RVA = "0x35959C0", Offset = "0x35945C0", VA = "0x1835959C0")]
		private Context.Snapshot _RunActions(Buff.Event ev, bool setMeAsTarget = true)
		{
			return default(Context.Snapshot);
		}

		// Token: 0x0600D5E5 RID: 54757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5E5")]
		[Address(RVA = "0x3594B00", Offset = "0x3593700", VA = "0x183594B00")]
		private void _LoadAttributesModifier(AttributeModifierData data, int stackCnt)
		{
		}

		// Token: 0x0600D5E6 RID: 54758 RVA: 0x0004D508 File Offset: 0x0004B708
		[Token(Token = "0x600D5E6")]
		[Address(RVA = "0x358A350", Offset = "0x3588F50", VA = "0x18358A350")]
		public bool CheckAbnormalFlagAnti(long antiMask)
		{
			return default(bool);
		}

		// Token: 0x0600D5E7 RID: 54759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5E7")]
		[Address(RVA = "0x35923A0", Offset = "0x3590FA0", VA = "0x1835923A0")]
		private void TakeSnapshotToBuffAttribute()
		{
		}

		// Token: 0x0600D5E8 RID: 54760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5E8")]
		[Address(RVA = "0x35954F0", Offset = "0x35940F0", VA = "0x1835954F0")]
		private void _ModifyLifeTimeFinally()
		{
		}

		// Token: 0x0600D5E9 RID: 54761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5E9")]
		[Address(RVA = "0x35948F0", Offset = "0x35934F0", VA = "0x1835948F0")]
		private void _LoadActions(BuffTemplate.EventToActionMap eventToActions)
		{
		}

		// Token: 0x0600D5EA RID: 54762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5EA")]
		[Address(RVA = "0x35953E0", Offset = "0x3593FE0", VA = "0x1835953E0")]
		private void _MarkAttributeDirty(AttributeType attribute)
		{
		}

		// Token: 0x0600D5EB RID: 54763 RVA: 0x0004D520 File Offset: 0x0004B720
		[Token(Token = "0x600D5EB")]
		[Address(RVA = "0x3593600", Offset = "0x3592200", VA = "0x183593600")]
		private long _CalcAbnormalMask(IList<AbnormalFlag> flags)
		{
			return 0L;
		}

		// Token: 0x0600D5EC RID: 54764 RVA: 0x0004D538 File Offset: 0x0004B738
		[Token(Token = "0x600D5EC")]
		[Address(RVA = "0x35933D0", Offset = "0x3591FD0", VA = "0x1835933D0")]
		private long _CalcAbnormalCombo(IList<AbnormalCombo> combos)
		{
			return 0L;
		}

		// Token: 0x0600D5ED RID: 54765 RVA: 0x0004D550 File Offset: 0x0004B750
		[Token(Token = "0x600D5ED")]
		[Address(RVA = "0x3593830", Offset = "0x3592430", VA = "0x183593830")]
		private int _CalculatePriority(BuffConfig config)
		{
			return 0;
		}

		// Token: 0x0600D5EE RID: 54766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5EE")]
		[Address(RVA = "0x3593B40", Offset = "0x3592740", VA = "0x183593B40")]
		private void _DoUpdateStack()
		{
		}

		// Token: 0x0600D5EF RID: 54767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5EF")]
		[Address(RVA = "0x3593170", Offset = "0x3591D70", VA = "0x183593170")]
		private void _AddStack(Buff buff)
		{
		}

		// Token: 0x0600D5F0 RID: 54768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5F0")]
		[Address(RVA = "0x3593E20", Offset = "0x3592A20", VA = "0x183593E20")]
		private void _FillRemainingTimeWhenStackMax(Buff buff)
		{
		}

		// Token: 0x0600D5F1 RID: 54769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5F1")]
		[Address(RVA = "0x3593F00", Offset = "0x3592B00", VA = "0x183593F00")]
		private void _FillRemainingTime(Buff buff)
		{
		}

		// Token: 0x0600D5F2 RID: 54770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5F2")]
		[Address(RVA = "0x3593C30", Offset = "0x3592830", VA = "0x183593C30")]
		private void _ExtendRemainingTime(Buff buff)
		{
		}

		// Token: 0x0600D5F3 RID: 54771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5F3")]
		[Address(RVA = "0x35960C0", Offset = "0x3594CC0", VA = "0x1835960C0")]
		private void _UpdateIsEnabledIfNotFinished()
		{
		}

		// Token: 0x0600D5F4 RID: 54772 RVA: 0x0004D568 File Offset: 0x0004B768
		[Token(Token = "0x600D5F4")]
		[Address(RVA = "0x3594440", Offset = "0x3593040", VA = "0x183594440")]
		private bool _InitIsStatusResistable()
		{
			return default(bool);
		}

		// Token: 0x0600D5F5 RID: 54773 RVA: 0x0004D580 File Offset: 0x0004B780
		[Token(Token = "0x600D5F5")]
		[Address(RVA = "0x35940E0", Offset = "0x3592CE0", VA = "0x1835940E0")]
		private bool _InitIsEpBreakBuff()
		{
			return default(bool);
		}

		// Token: 0x0600D5F6 RID: 54774 RVA: 0x0004D598 File Offset: 0x0004B798
		[Token(Token = "0x600D5F6")]
		[Address(RVA = "0x3593260", Offset = "0x3591E60", VA = "0x183593260")]
		private bool _AutoCalcIsStatusResistable()
		{
			return default(bool);
		}

		// Token: 0x0600D5F7 RID: 54775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5F7")]
		[Address(RVA = "0x35956F0", Offset = "0x35942F0", VA = "0x1835956F0")]
		private void _PreprocessDeltaTime(ref FP deltaTime)
		{
		}

		// Token: 0x0600D5F8 RID: 54776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5F8")]
		[Address(RVA = "0x358B150", Offset = "0x3589D50", VA = "0x18358B150")]
		public void FinishDerivedBuff(string buffKey, bool decCntIfStack, bool updateOverrideMap)
		{
		}

		// Token: 0x0600D5F9 RID: 54777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5F9")]
		[Address(RVA = "0x358A560", Offset = "0x3589160", VA = "0x18358A560")]
		public void ClearDerivedBuffsIfNot(bool updateOverrideMap)
		{
		}

		// Token: 0x0600D5FA RID: 54778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5FA")]
		[Address(RVA = "0x3596410", Offset = "0x3595010", VA = "0x183596410")]
		private void _UpdateOverrideMap()
		{
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x0600D5FB RID: 54779 RVA: 0x0004D5B0 File Offset: 0x0004B7B0
		// (set) Token: 0x0600D5FC RID: 54780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019FF")]
		public bool hasShield
		{
			[Token(Token = "0x600D5FB")]
			[Address(RVA = "0x3596F40", Offset = "0x3595B40", VA = "0x183596F40", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D5FC")]
			[Address(RVA = "0x35983B0", Offset = "0x3596FB0", VA = "0x1835983B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600D5FD RID: 54781 RVA: 0x0004D5C8 File Offset: 0x0004B7C8
		[Token(Token = "0x600D5FD")]
		[Address(RVA = "0x358A230", Offset = "0x3588E30", VA = "0x18358A230", Slot = "12")]
		public Entity.ShieldUIController.ShieldData CalculateShieldData()
		{
			return default(Entity.ShieldUIController.ShieldData);
		}

		// Token: 0x0600D5FE RID: 54782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D5FE")]
		[Address(RVA = "0x3594640", Offset = "0x3593240", VA = "0x183594640")]
		private void _InitShieldSource()
		{
		}

		// Token: 0x0600D600 RID: 54784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D600")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x0400E4B8 RID: 58552
		[Token(Token = "0x400E4B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x0400E4B9 RID: 58553
		[Token(Token = "0x400E4B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly AbnormalFlag[] ABFLAGS_IS_AUTO_STATUS_RESISTABLE;

		// Token: 0x0400E4BA RID: 58554
		[Token(Token = "0x400E4BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly AbnormalFlag[] ABFLAGS_ABLE_TO_BE_RESISTED;

		// Token: 0x0400E4BB RID: 58555
		[Token(Token = "0x400E4BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public static readonly FP INFINITY_TIME;

		// Token: 0x0400E4BC RID: 58556
		[Token(Token = "0x400E4BC")]
		[NonSerialized]
		public const int EVENT_NUM = 101;

		// Token: 0x0400E4BD RID: 58557
		[Token(Token = "0x400E4BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Buff.BuffContainer m_container;

		// Token: 0x0400E4BE RID: 58558
		[Token(Token = "0x400E4BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ObjectPtr<Entity> m_source;

		// Token: 0x0400E4BF RID: 58559
		[Token(Token = "0x400E4BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ObjectPtr<Ability> m_ability;

		// Token: 0x0400E4C0 RID: 58560
		[Token(Token = "0x400E4C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectPtr<Projectile> m_sourceProjectile;

		// Token: 0x0400E4C1 RID: 58561
		[Token(Token = "0x400E4C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FP[] m_attributeMultipliers;

		// Token: 0x0400E4C2 RID: 58562
		[Token(Token = "0x400E4C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FP[] m_attributeAdditions;

		// Token: 0x0400E4C3 RID: 58563
		[Token(Token = "0x400E4C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private FP[] m_attributeFinalAdditions;

		// Token: 0x0400E4C4 RID: 58564
		[Token(Token = "0x400E4C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FP[] m_attributeFinalScalers;

		// Token: 0x0400E4C5 RID: 58565
		[Token(Token = "0x400E4C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BuffData m_data;

		// Token: 0x0400E4C6 RID: 58566
		[Token(Token = "0x400E4C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private FP m_lifeTime;

		// Token: 0x0400E4C7 RID: 58567
		[Token(Token = "0x400E4C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FP m_remainingTime;

		// Token: 0x0400E4C8 RID: 58568
		[Token(Token = "0x400E4C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FP m_existingTime;

		// Token: 0x0400E4C9 RID: 58569
		[Token(Token = "0x400E4C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int m_triggerCnt;

		// Token: 0x0400E4CA RID: 58570
		[Token(Token = "0x400E4CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int m_stackCnt;

		// Token: 0x0400E4CB RID: 58571
		[Token(Token = "0x400E4CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int m_maxValidStackCnt;

		// Token: 0x0400E4CC RID: 58572
		[Token(Token = "0x400E4CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool m_refreshRemainingTimeWhenStackMax;

		// Token: 0x0400E4CD RID: 58573
		[Token(Token = "0x400E4CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool m_clearAllStackCntWhenTimeUp;

		// Token: 0x0400E4CE RID: 58574
		[Token(Token = "0x400E4CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private PrecisePeriodicTimer m_triggerTimer;

		// Token: 0x0400E4CF RID: 58575
		[Token(Token = "0x400E4CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ActionNode[][] m_actions;

		// Token: 0x0400E4D0 RID: 58576
		[Token(Token = "0x400E4D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Blackboard m_blackboard;

		// Token: 0x0400E4D1 RID: 58577
		[Token(Token = "0x400E4D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RuntimeAttributesSnapshot m_runtimeAttributesSnapshot;

		// Token: 0x0400E4D2 RID: 58578
		[Token(Token = "0x400E4D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool m_isDurableBuff;

		// Token: 0x0400E4D3 RID: 58579
		[Token(Token = "0x400E4D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool m_isDamageMissable;

		// Token: 0x0400E4D4 RID: 58580
		[Token(Token = "0x400E4D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		private bool m_isSilenceable;

		// Token: 0x0400E4D5 RID: 58581
		[Token(Token = "0x400E4D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		private bool m_isStunnable;

		// Token: 0x0400E4D6 RID: 58582
		[Token(Token = "0x400E4D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool m_isFreezable;

		// Token: 0x0400E4D7 RID: 58583
		[Token(Token = "0x400E4D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool m_isStatusResistable;

		// Token: 0x0400E4D8 RID: 58584
		[Token(Token = "0x400E4D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		private bool m_isLevitatable;

		// Token: 0x0400E4D9 RID: 58585
		[Token(Token = "0x400E4D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E7")]
		private bool m_started;

		// Token: 0x0400E4DA RID: 58586
		[Token(Token = "0x400E4DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private bool m_isFinished;

		// Token: 0x0400E4DB RID: 58587
		[Token(Token = "0x400E4DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E9")]
		private bool m_isActuallyFinished;

		// Token: 0x0400E4DC RID: 58588
		[Token(Token = "0x400E4DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EA")]
		private bool m_needRemove;

		// Token: 0x0400E4DD RID: 58589
		[Token(Token = "0x400E4DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EB")]
		private bool m_isActuallyEnabled;

		// Token: 0x0400E4DE RID: 58590
		[Token(Token = "0x400E4DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private bool m_isLateEnabled;

		// Token: 0x0400E4DF RID: 58591
		[Token(Token = "0x400E4DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
		private bool m_isManuallyEnabled;

		// Token: 0x0400E4E0 RID: 58592
		[Token(Token = "0x400E4E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EE")]
		private bool m_isValid;

		// Token: 0x0400E4E1 RID: 58593
		[Token(Token = "0x400E4E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EF")]
		private bool m_isEpBreakBuff;

		// Token: 0x0400E4F1 RID: 58609
		[Token(Token = "0x400E4F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private List<ObjectPtr<Buff>> m_derivedBuffs;

		// Token: 0x0400E4F2 RID: 58610
		[Token(Token = "0x400E4F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private DamageTypeMask m_shieldMask;

		// Token: 0x0400E4F4 RID: 58612
		[Token(Token = "0x400E4F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_key;

		// Token: 0x0400E4F5 RID: 58613
		[Token(Token = "0x400E4F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_key;

		// Token: 0x0400E4F6 RID: 58614
		[Token(Token = "0x400E4F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_overrideKey;

		// Token: 0x0400E4F7 RID: 58615
		[Token(Token = "0x400E4F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_overrideKey;

		// Token: 0x0400E4F8 RID: 58616
		[Token(Token = "0x400E4F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_instanceUid;

		// Token: 0x0400E4F9 RID: 58617
		[Token(Token = "0x400E4F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_instanceUid;

		// Token: 0x0400E4FA RID: 58618
		[Token(Token = "0x400E4FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_priority;

		// Token: 0x0400E4FB RID: 58619
		[Token(Token = "0x400E4FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_priority;

		// Token: 0x0400E4FC RID: 58620
		[Token(Token = "0x400E4FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_triggerCnt;

		// Token: 0x0400E4FD RID: 58621
		[Token(Token = "0x400E4FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x0400E4FE RID: 58622
		[Token(Token = "0x400E4FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_source;

		// Token: 0x0400E4FF RID: 58623
		[Token(Token = "0x400E4FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_sourceProjectile;

		// Token: 0x0400E500 RID: 58624
		[Token(Token = "0x400E500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_context;

		// Token: 0x0400E501 RID: 58625
		[Token(Token = "0x400E501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_attributeMask;

		// Token: 0x0400E502 RID: 58626
		[Token(Token = "0x400E502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_attributeMask;

		// Token: 0x0400E503 RID: 58627
		[Token(Token = "0x400E503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

		// Token: 0x0400E504 RID: 58628
		[Token(Token = "0x400E504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_abnormalFlagMask;

		// Token: 0x0400E505 RID: 58629
		[Token(Token = "0x400E505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

		// Token: 0x0400E506 RID: 58630
		[Token(Token = "0x400E506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_abnormalImmuneMask;

		// Token: 0x0400E507 RID: 58631
		[Token(Token = "0x400E507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

		// Token: 0x0400E508 RID: 58632
		[Token(Token = "0x400E508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_abnormalAntiMask;

		// Token: 0x0400E509 RID: 58633
		[Token(Token = "0x400E509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_abnormalComboMask;

		// Token: 0x0400E50A RID: 58634
		[Token(Token = "0x400E50A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_abnormalComboMask;

		// Token: 0x0400E50B RID: 58635
		[Token(Token = "0x400E50B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

		// Token: 0x0400E50C RID: 58636
		[Token(Token = "0x400E50C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_set_abnormalComboImmuneMask;

		// Token: 0x0400E50D RID: 58637
		[Token(Token = "0x400E50D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_blackboard;

		// Token: 0x0400E50E RID: 58638
		[Token(Token = "0x400E50E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_runtimeAttributesSnapshot;

		// Token: 0x0400E50F RID: 58639
		[Token(Token = "0x400E50F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_lifeTime;

		// Token: 0x0400E510 RID: 58640
		[Token(Token = "0x400E510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_remainingTime;

		// Token: 0x0400E511 RID: 58641
		[Token(Token = "0x400E511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_existingTime;

		// Token: 0x0400E512 RID: 58642
		[Token(Token = "0x400E512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_remainingRatio;

		// Token: 0x0400E513 RID: 58643
		[Token(Token = "0x400E513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_triggerInterval;

		// Token: 0x0400E514 RID: 58644
		[Token(Token = "0x400E514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_triggerTimer;

		// Token: 0x0400E515 RID: 58645
		[Token(Token = "0x400E515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_effectKey;

		// Token: 0x0400E516 RID: 58646
		[Token(Token = "0x400E516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_set_effectKey;

		// Token: 0x0400E517 RID: 58647
		[Token(Token = "0x400E517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_enableInitDirectionFromSource;

		// Token: 0x0400E518 RID: 58648
		[Token(Token = "0x400E518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_set_enableInitDirectionFromSource;

		// Token: 0x0400E519 RID: 58649
		[Token(Token = "0x400E519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_onEventPriority;

		// Token: 0x0400E51A RID: 58650
		[Token(Token = "0x400E51A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_set_onEventPriority;

		// Token: 0x0400E51B RID: 58651
		[Token(Token = "0x400E51B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_audioSignal;

		// Token: 0x0400E51C RID: 58652
		[Token(Token = "0x400E51C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_set_audioSignal;

		// Token: 0x0400E51D RID: 58653
		[Token(Token = "0x400E51D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_ability;

		// Token: 0x0400E51E RID: 58654
		[Token(Token = "0x400E51E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_triggerable;

		// Token: 0x0400E51F RID: 58655
		[Token(Token = "0x400E51F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_set_triggerable;

		// Token: 0x0400E520 RID: 58656
		[Token(Token = "0x400E520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_derivedBuffs;

		// Token: 0x0400E521 RID: 58657
		[Token(Token = "0x400E521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_isEnabled;

		// Token: 0x0400E522 RID: 58658
		[Token(Token = "0x400E522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_set_isEnabled;

		// Token: 0x0400E523 RID: 58659
		[Token(Token = "0x400E523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_isFinished;

		// Token: 0x0400E524 RID: 58660
		[Token(Token = "0x400E524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_get_needRemove;

		// Token: 0x0400E525 RID: 58661
		[Token(Token = "0x400E525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_set_needRemove;

		// Token: 0x0400E526 RID: 58662
		[Token(Token = "0x400E526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_get_isFinishedOrDisabled;

		// Token: 0x0400E527 RID: 58663
		[Token(Token = "0x400E527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_get_stackCnt;

		// Token: 0x0400E528 RID: 58664
		[Token(Token = "0x400E528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_get_validStackCnt;

		// Token: 0x0400E529 RID: 58665
		[Token(Token = "0x400E529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_get_overridableStackCnt;

		// Token: 0x0400E52A RID: 58666
		[Token(Token = "0x400E52A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0400E52B RID: 58667
		[Token(Token = "0x400E52B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_get_isStatusResistable;

		// Token: 0x0400E52C RID: 58668
		[Token(Token = "0x400E52C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0400E52D RID: 58669
		[Token(Token = "0x400E52D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400E52E RID: 58670
		[Token(Token = "0x400E52E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__IsActionValid;

		// Token: 0x0400E52F RID: 58671
		[Token(Token = "0x400E52F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400E530 RID: 58672
		[Token(Token = "0x400E530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x0400E531 RID: 58673
		[Token(Token = "0x400E531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__ResetTriggerTimer;

		// Token: 0x0400E532 RID: 58674
		[Token(Token = "0x400E532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_Trigger;

		// Token: 0x0400E533 RID: 58675
		[Token(Token = "0x400E533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_OverrideEffectKey;

		// Token: 0x0400E534 RID: 58676
		[Token(Token = "0x400E534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_MarkFinish;

		// Token: 0x0400E535 RID: 58677
		[Token(Token = "0x400E535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_DecStackCntOrMarkFinish;

		// Token: 0x0400E536 RID: 58678
		[Token(Token = "0x400E536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__SetAttributeModifier;

		// Token: 0x0400E537 RID: 58679
		[Token(Token = "0x400E537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix1__SetAttributeModifier;

		// Token: 0x0400E538 RID: 58680
		[Token(Token = "0x400E538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_TryUpdateAttributeModifier;

		// Token: 0x0400E539 RID: 58681
		[Token(Token = "0x400E539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix1_TryUpdateAttributeModifier;

		// Token: 0x0400E53A RID: 58682
		[Token(Token = "0x400E53A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix2_TryUpdateAttributeModifier;

		// Token: 0x0400E53B RID: 58683
		[Token(Token = "0x400E53B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix3_TryUpdateAttributeModifier;

		// Token: 0x0400E53C RID: 58684
		[Token(Token = "0x400E53C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix4_TryUpdateAttributeModifier;

		// Token: 0x0400E53D RID: 58685
		[Token(Token = "0x400E53D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_CheckAttributeModifier;

		// Token: 0x0400E53E RID: 58686
		[Token(Token = "0x400E53E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_ToString;

		// Token: 0x0400E53F RID: 58687
		[Token(Token = "0x400E53F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_FetchDuration;

		// Token: 0x0400E540 RID: 58688
		[Token(Token = "0x400E540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_AddDerivedBuffSafe;

		// Token: 0x0400E541 RID: 58689
		[Token(Token = "0x400E541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_ForceSetLifeTimeAndRemainingTime_Unsafe;

		// Token: 0x0400E542 RID: 58690
		[Token(Token = "0x400E542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x0400E543 RID: 58691
		[Token(Token = "0x400E543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0400E544 RID: 58692
		[Token(Token = "0x400E544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400E545 RID: 58693
		[Token(Token = "0x400E545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400E546 RID: 58694
		[Token(Token = "0x400E546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0400E547 RID: 58695
		[Token(Token = "0x400E547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400E548 RID: 58696
		[Token(Token = "0x400E548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400E549 RID: 58697
		[Token(Token = "0x400E549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400E54A RID: 58698
		[Token(Token = "0x400E54A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_OnLateTick;

		// Token: 0x0400E54B RID: 58699
		[Token(Token = "0x400E54B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_AddDerivedBuff;

		// Token: 0x0400E54C RID: 58700
		[Token(Token = "0x400E54C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_ContainsAnyDerivedBuff;

		// Token: 0x0400E54D RID: 58701
		[Token(Token = "0x400E54D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_ContainsDerivedBuff;

		// Token: 0x0400E54E RID: 58702
		[Token(Token = "0x400E54E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_OnOwnerBorn;

		// Token: 0x0400E54F RID: 58703
		[Token(Token = "0x400E54F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_OnOwnerPostBorn;

		// Token: 0x0400E550 RID: 58704
		[Token(Token = "0x400E550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_OnOwnerLocate;

		// Token: 0x0400E551 RID: 58705
		[Token(Token = "0x400E551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_OnOwnerFinish;

		// Token: 0x0400E552 RID: 58706
		[Token(Token = "0x400E552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_OnOwnerReborn;

		// Token: 0x0400E553 RID: 58707
		[Token(Token = "0x400E553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_OnOwnerDying;

		// Token: 0x0400E554 RID: 58708
		[Token(Token = "0x400E554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0400E555 RID: 58709
		[Token(Token = "0x400E555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_OnBeforeApplyingModifier;

		// Token: 0x0400E556 RID: 58710
		[Token(Token = "0x400E556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_OnApplyingModifier;

		// Token: 0x0400E557 RID: 58711
		[Token(Token = "0x400E557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_OnAppliedModifier;

		// Token: 0x0400E558 RID: 58712
		[Token(Token = "0x400E558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_OnApplyingSkippedModifier;

		// Token: 0x0400E559 RID: 58713
		[Token(Token = "0x400E559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_OnOutputModifier;

		// Token: 0x0400E55A RID: 58714
		[Token(Token = "0x400E55A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_OnBeforeTargetApplyModifier;

		// Token: 0x0400E55B RID: 58715
		[Token(Token = "0x400E55B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_OnAfterOutputDamage;

		// Token: 0x0400E55C RID: 58716
		[Token(Token = "0x400E55C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_OnAfterOutputHeal;

		// Token: 0x0400E55D RID: 58717
		[Token(Token = "0x400E55D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_OnAfterOutputElementDamage;

		// Token: 0x0400E55E RID: 58718
		[Token(Token = "0x400E55E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_OnCalculateCachedProjectileDamage;

		// Token: 0x0400E55F RID: 58719
		[Token(Token = "0x400E55F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_OnCalculateDamage;

		// Token: 0x0400E560 RID: 58720
		[Token(Token = "0x400E560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_OnAfterCalculateDamage;

		// Token: 0x0400E561 RID: 58721
		[Token(Token = "0x400E561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_OnBeingCalculateDamage;

		// Token: 0x0400E562 RID: 58722
		[Token(Token = "0x400E562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x0400E563 RID: 58723
		[Token(Token = "0x400E563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_OnTakeEPDamage;

		// Token: 0x0400E564 RID: 58724
		[Token(Token = "0x400E564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_OnOutputDamage;

		// Token: 0x0400E565 RID: 58725
		[Token(Token = "0x400E565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_OnOutputAtkOrHeal;

		// Token: 0x0400E566 RID: 58726
		[Token(Token = "0x400E566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_OnOutputAtkOrHealEachSpell;

		// Token: 0x0400E567 RID: 58727
		[Token(Token = "0x400E567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_OnEvadeDamage;

		// Token: 0x0400E568 RID: 58728
		[Token(Token = "0x400E568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_OnBlockDamage;

		// Token: 0x0400E569 RID: 58729
		[Token(Token = "0x400E569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_OnTargetKilled;

		// Token: 0x0400E56A RID: 58730
		[Token(Token = "0x400E56A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_OnAbilityStart;

		// Token: 0x0400E56B RID: 58731
		[Token(Token = "0x400E56B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_OnOtherBuffStart;

		// Token: 0x0400E56C RID: 58732
		[Token(Token = "0x400E56C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_OnAbilityFinish;

		// Token: 0x0400E56D RID: 58733
		[Token(Token = "0x400E56D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_OnBeforeAbilitySpellOn;

		// Token: 0x0400E56E RID: 58734
		[Token(Token = "0x400E56E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_OnAbilitySpellOn;

		// Token: 0x0400E56F RID: 58735
		[Token(Token = "0x400E56F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_OnAbilityCastOnTarget;

		// Token: 0x0400E570 RID: 58736
		[Token(Token = "0x400E570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_OnSkillStart;

		// Token: 0x0400E571 RID: 58737
		[Token(Token = "0x400E571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_OnToggleSkillStart;

		// Token: 0x0400E572 RID: 58738
		[Token(Token = "0x400E572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_OnSkillRetriggered;

		// Token: 0x0400E573 RID: 58739
		[Token(Token = "0x400E573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_OnSkillCastSucceed;

		// Token: 0x0400E574 RID: 58740
		[Token(Token = "0x400E574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_OnSkillFinish;

		// Token: 0x0400E575 RID: 58741
		[Token(Token = "0x400E575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_OnBeforeAttack;

		// Token: 0x0400E576 RID: 58742
		[Token(Token = "0x400E576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_OnAfterAttack;

		// Token: 0x0400E577 RID: 58743
		[Token(Token = "0x400E577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_OnBeforeTrySetHpZero;

		// Token: 0x0400E578 RID: 58744
		[Token(Token = "0x400E578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix0_OnPostTrySetHpZero;

		// Token: 0x0400E579 RID: 58745
		[Token(Token = "0x400E579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_OnBeforeTrySetEpZero;

		// Token: 0x0400E57A RID: 58746
		[Token(Token = "0x400E57A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		private static DelegateBridge __Hotfix0_OnBeforeDisappear;

		// Token: 0x0400E57B RID: 58747
		[Token(Token = "0x400E57B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		private static DelegateBridge __Hotfix0_OnBeforeAppear;

		// Token: 0x0400E57C RID: 58748
		[Token(Token = "0x400E57C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		private static DelegateBridge __Hotfix0_OnOwnerAbnormalFlagDirty;

		// Token: 0x0400E57D RID: 58749
		[Token(Token = "0x400E57D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private static DelegateBridge __Hotfix0_OnOwnerBlockeeChanged;

		// Token: 0x0400E57E RID: 58750
		[Token(Token = "0x400E57E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private static DelegateBridge __Hotfix0_OnOwnerBlockModeChanged;

		// Token: 0x0400E57F RID: 58751
		[Token(Token = "0x400E57F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		private static DelegateBridge __Hotfix0_OnCollideWithHighLand;

		// Token: 0x0400E580 RID: 58752
		[Token(Token = "0x400E580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private static DelegateBridge __Hotfix0_OnBeforeExitUnbalancedState;

		// Token: 0x0400E581 RID: 58753
		[Token(Token = "0x400E581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		private static DelegateBridge __Hotfix0_OnEnterUnbalancedState;

		// Token: 0x0400E582 RID: 58754
		[Token(Token = "0x400E582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private static DelegateBridge __Hotfix0_OnEnterMagicCircuit;

		// Token: 0x0400E583 RID: 58755
		[Token(Token = "0x400E583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private static DelegateBridge __Hotfix0_OnLeaveMagicCircuit;

		// Token: 0x0400E584 RID: 58756
		[Token(Token = "0x400E584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		private static DelegateBridge __Hotfix0_OnAbilityInterrupted;

		// Token: 0x0400E585 RID: 58757
		[Token(Token = "0x400E585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private static DelegateBridge __Hotfix0_OnOwnerRootTileChanged;

		// Token: 0x0400E586 RID: 58758
		[Token(Token = "0x400E586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		private static DelegateBridge __Hotfix0_OnOtherResistableBuffStart;

		// Token: 0x0400E587 RID: 58759
		[Token(Token = "0x400E587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		private static DelegateBridge __Hotfix0_OnEsOverZero;

		// Token: 0x0400E588 RID: 58760
		[Token(Token = "0x400E588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		private static DelegateBridge __Hotfix0_OnMotionModeChanged;

		// Token: 0x0400E589 RID: 58761
		[Token(Token = "0x400E589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		private static DelegateBridge __Hotfix0_OnDirectionChanged;

		// Token: 0x0400E58A RID: 58762
		[Token(Token = "0x400E58A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		private static DelegateBridge __Hotfix0_OnBeforeDirectionChange;

		// Token: 0x0400E58B RID: 58763
		[Token(Token = "0x400E58B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		private static DelegateBridge __Hotfix0_OnMakeEnemyUnbalanced;

		// Token: 0x0400E58C RID: 58764
		[Token(Token = "0x400E58C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		private static DelegateBridge __Hotfix0_OnEnterLevitateState;

		// Token: 0x0400E58D RID: 58765
		[Token(Token = "0x400E58D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		private static DelegateBridge __Hotfix0_OnEPBreakStart;

		// Token: 0x0400E58E RID: 58766
		[Token(Token = "0x400E58E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		private static DelegateBridge __Hotfix0_OnBeforeEPBreakStart;

		// Token: 0x0400E58F RID: 58767
		[Token(Token = "0x400E58F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		private static DelegateBridge __Hotfix0_OnEPBreakFinish;

		// Token: 0x0400E590 RID: 58768
		[Token(Token = "0x400E590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		private static DelegateBridge __Hotfix0_OnBeforeEPBreakFinish;

		// Token: 0x0400E591 RID: 58769
		[Token(Token = "0x400E591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		private static DelegateBridge __Hotfix0_OnBeforeExitLevitateState;

		// Token: 0x0400E592 RID: 58770
		[Token(Token = "0x400E592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		private static DelegateBridge __Hotfix0_OnEndPulling;

		// Token: 0x0400E593 RID: 58771
		[Token(Token = "0x400E593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		private static DelegateBridge __Hotfix0_OnBeforeFallDown;

		// Token: 0x0400E594 RID: 58772
		[Token(Token = "0x400E594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private static DelegateBridge __Hotfix0_OnOwnerOverlapped;

		// Token: 0x0400E595 RID: 58773
		[Token(Token = "0x400E595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		private static DelegateBridge __Hotfix0_OnBossWaveWillStart;

		// Token: 0x0400E596 RID: 58774
		[Token(Token = "0x400E596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		private static DelegateBridge __Hotfix0_OnStageEnd;

		// Token: 0x0400E597 RID: 58775
		[Token(Token = "0x400E597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		private static DelegateBridge __Hotfix0_OnLegionModeDrawCard;

		// Token: 0x0400E598 RID: 58776
		[Token(Token = "0x400E598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		private static DelegateBridge __Hotfix0_OnLegionModeRefreshCard;

		// Token: 0x0400E599 RID: 58777
		[Token(Token = "0x400E599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		private static DelegateBridge __Hotfix0_OnSandboxOwnerResChanged;

		// Token: 0x0400E59A RID: 58778
		[Token(Token = "0x400E59A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		private static DelegateBridge __Hotfix0_OnAutoChessModeChanged;

		// Token: 0x0400E59B RID: 58779
		[Token(Token = "0x400E59B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		private static DelegateBridge __Hotfix0_OnEntityWillOverlap;

		// Token: 0x0400E59C RID: 58780
		[Token(Token = "0x400E59C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		private static DelegateBridge __Hotfix0_OnOwnerBeforeDead;

		// Token: 0x0400E59D RID: 58781
		[Token(Token = "0x400E59D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		private static DelegateBridge __Hotfix0_OnOwnerHpFull;

		// Token: 0x0400E59E RID: 58782
		[Token(Token = "0x400E59E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		private static DelegateBridge __Hotfix0_OnUnitSwitchMode;

		// Token: 0x0400E59F RID: 58783
		[Token(Token = "0x400E59F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		private static DelegateBridge __Hotfix0_OnPalsyOverflow;

		// Token: 0x0400E5A0 RID: 58784
		[Token(Token = "0x400E5A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		private static DelegateBridge __Hotfix0_OnTriggerPalsy;

		// Token: 0x0400E5A1 RID: 58785
		[Token(Token = "0x400E5A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		private static DelegateBridge __Hotfix0_CooperatePlayerDying;

		// Token: 0x0400E5A2 RID: 58786
		[Token(Token = "0x400E5A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		private static DelegateBridge __Hotfix0_CooperatePlayerRevive;

		// Token: 0x0400E5A3 RID: 58787
		[Token(Token = "0x400E5A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		private static DelegateBridge __Hotfix0_OnLegionModeDangerLevelRefresh;

		// Token: 0x0400E5A4 RID: 58788
		[Token(Token = "0x400E5A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		private static DelegateBridge __Hotfix0_OnHalfIdleTrapCheckUpgrade;

		// Token: 0x0400E5A5 RID: 58789
		[Token(Token = "0x400E5A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		private static DelegateBridge __Hotfix0_OnHalfIdleKawaPolluted;

		// Token: 0x0400E5A6 RID: 58790
		[Token(Token = "0x400E5A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		private static DelegateBridge __Hotfix0_OnHalfIdleKawaCleaned;

		// Token: 0x0400E5A7 RID: 58791
		[Token(Token = "0x400E5A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		private static DelegateBridge __Hotfix0_HalfIdleGainEquip;

		// Token: 0x0400E5A8 RID: 58792
		[Token(Token = "0x400E5A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		private static DelegateBridge __Hotfix0_HalfIdleGainTrap;

		// Token: 0x0400E5A9 RID: 58793
		[Token(Token = "0x400E5A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		private static DelegateBridge __Hotfix0_OnProjectileSelectTargets;

		// Token: 0x0400E5AA RID: 58794
		[Token(Token = "0x400E5AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		private static DelegateBridge __Hotfix0__RunActions;

		// Token: 0x0400E5AB RID: 58795
		[Token(Token = "0x400E5AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		private static DelegateBridge __Hotfix0__LoadAttributesModifier;

		// Token: 0x0400E5AC RID: 58796
		[Token(Token = "0x400E5AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		private static DelegateBridge __Hotfix0_CheckAbnormalFlagAnti;

		// Token: 0x0400E5AD RID: 58797
		[Token(Token = "0x400E5AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		private static DelegateBridge __Hotfix0_TakeSnapshotToBuffAttribute;

		// Token: 0x0400E5AE RID: 58798
		[Token(Token = "0x400E5AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		private static DelegateBridge __Hotfix0__ModifyLifeTimeFinally;

		// Token: 0x0400E5AF RID: 58799
		[Token(Token = "0x400E5AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		private static DelegateBridge __Hotfix0__LoadActions;

		// Token: 0x0400E5B0 RID: 58800
		[Token(Token = "0x400E5B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		private static DelegateBridge __Hotfix0__MarkAttributeDirty;

		// Token: 0x0400E5B1 RID: 58801
		[Token(Token = "0x400E5B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		private static DelegateBridge __Hotfix0__CalcAbnormalMask;

		// Token: 0x0400E5B2 RID: 58802
		[Token(Token = "0x400E5B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		private static DelegateBridge __Hotfix0__CalcAbnormalCombo;

		// Token: 0x0400E5B3 RID: 58803
		[Token(Token = "0x400E5B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		private static DelegateBridge __Hotfix0__CalculatePriority;

		// Token: 0x0400E5B4 RID: 58804
		[Token(Token = "0x400E5B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		private static DelegateBridge __Hotfix0__DoUpdateStack;

		// Token: 0x0400E5B5 RID: 58805
		[Token(Token = "0x400E5B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		private static DelegateBridge __Hotfix0__AddStack;

		// Token: 0x0400E5B6 RID: 58806
		[Token(Token = "0x400E5B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x630")]
		private static DelegateBridge __Hotfix0__FillRemainingTimeWhenStackMax;

		// Token: 0x0400E5B7 RID: 58807
		[Token(Token = "0x400E5B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x638")]
		private static DelegateBridge __Hotfix0__FillRemainingTime;

		// Token: 0x0400E5B8 RID: 58808
		[Token(Token = "0x400E5B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x640")]
		private static DelegateBridge __Hotfix0__ExtendRemainingTime;

		// Token: 0x0400E5B9 RID: 58809
		[Token(Token = "0x400E5B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x648")]
		private static DelegateBridge __Hotfix0__UpdateIsEnabledIfNotFinished;

		// Token: 0x0400E5BA RID: 58810
		[Token(Token = "0x400E5BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x650")]
		private static DelegateBridge __Hotfix0__InitIsStatusResistable;

		// Token: 0x0400E5BB RID: 58811
		[Token(Token = "0x400E5BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x658")]
		private static DelegateBridge __Hotfix0__InitIsEpBreakBuff;

		// Token: 0x0400E5BC RID: 58812
		[Token(Token = "0x400E5BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x660")]
		private static DelegateBridge __Hotfix0__AutoCalcIsStatusResistable;

		// Token: 0x0400E5BD RID: 58813
		[Token(Token = "0x400E5BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x668")]
		private static DelegateBridge __Hotfix0__PreprocessDeltaTime;

		// Token: 0x0400E5BE RID: 58814
		[Token(Token = "0x400E5BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x670")]
		private static DelegateBridge __Hotfix0_FinishDerivedBuff;

		// Token: 0x0400E5BF RID: 58815
		[Token(Token = "0x400E5BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x678")]
		private static DelegateBridge __Hotfix0_ClearDerivedBuffsIfNot;

		// Token: 0x0400E5C0 RID: 58816
		[Token(Token = "0x400E5C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x680")]
		private static DelegateBridge __Hotfix0__UpdateOverrideMap;

		// Token: 0x0400E5C1 RID: 58817
		[Token(Token = "0x400E5C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x688")]
		private static DelegateBridge __Hotfix0_get_hasShield;

		// Token: 0x0400E5C2 RID: 58818
		[Token(Token = "0x400E5C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x690")]
		private static DelegateBridge __Hotfix0_set_hasShield;

		// Token: 0x0400E5C3 RID: 58819
		[Token(Token = "0x400E5C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x698")]
		private static DelegateBridge __Hotfix0_CalculateShieldData;

		// Token: 0x0400E5C4 RID: 58820
		[Token(Token = "0x400E5C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
		private static DelegateBridge __Hotfix0__InitShieldSource;

		// Token: 0x0200219E RID: 8606
		[Token(Token = "0x200219E")]
		public class DoubleBufferedBuffList : DoubleBufferedList<ObjectPtr<Buff>>
		{
			// Token: 0x0600D601 RID: 54785 RVA: 0x0004D5E0 File Offset: 0x0004B7E0
			[Token(Token = "0x600D601")]
			[Address(RVA = "0x35BDBB0", Offset = "0x35BC7B0", VA = "0x1835BDBB0")]
			public bool Remove(Buff buff)
			{
				return default(bool);
			}

			// Token: 0x0600D602 RID: 54786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D602")]
			[Address(RVA = "0x35BD8F0", Offset = "0x35BC4F0", VA = "0x1835BD8F0")]
			public void ClearInvalidElementsIfNotLoop()
			{
			}

			// Token: 0x0600D603 RID: 54787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D603")]
			[Address(RVA = "0x35BDA20", Offset = "0x35BC620", VA = "0x1835BDA20")]
			public void ClearWithWhiteList(List<string> whiteList)
			{
			}

			// Token: 0x0600D604 RID: 54788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D604")]
			[Address(RVA = "0x35BDD80", Offset = "0x35BC980", VA = "0x1835BDD80")]
			public DoubleBufferedBuffList()
			{
			}

			// Token: 0x0400E5C5 RID: 58821
			[Token(Token = "0x400E5C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Remove;

			// Token: 0x0400E5C6 RID: 58822
			[Token(Token = "0x400E5C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ClearInvalidElementsIfNotLoop;

			// Token: 0x0400E5C7 RID: 58823
			[Token(Token = "0x400E5C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ClearWithWhiteList;

			// Token: 0x0400E5C8 RID: 58824
			[Token(Token = "0x400E5C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200219F RID: 8607
		[Token(Token = "0x200219F")]
		public class SortedDoubleBufferedBuffList : Buff.DoubleBufferedBuffList
		{
			// Token: 0x0600D605 RID: 54789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D605")]
			[Address(RVA = "0x35BEA70", Offset = "0x35BD670", VA = "0x1835BEA70", Slot = "6")]
			public override void Add(ObjectPtr<Buff> element)
			{
			}

			// Token: 0x0600D606 RID: 54790 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D606")]
			[Address(RVA = "0x35BECD0", Offset = "0x35BD8D0", VA = "0x1835BECD0")]
			public SortedDoubleBufferedBuffList()
			{
			}

			// Token: 0x0400E5C9 RID: 58825
			[Token(Token = "0x400E5C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Add;

			// Token: 0x0400E5CA RID: 58826
			[Token(Token = "0x400E5CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020021A0 RID: 8608
		[Token(Token = "0x20021A0")]
		public class OverrideGroup
		{
			// Token: 0x17001A00 RID: 6656
			// (get) Token: 0x0600D607 RID: 54791 RVA: 0x0004D5F8 File Offset: 0x0004B7F8
			[Token(Token = "0x17001A00")]
			public int stackCnt
			{
				[Token(Token = "0x600D607")]
				[Address(RVA = "0x35BE9E0", Offset = "0x35BD5E0", VA = "0x1835BE9E0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600D608 RID: 54792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D608")]
			[Address(RVA = "0x35BE870", Offset = "0x35BD470", VA = "0x1835BE870")]
			public OverrideGroup(Buff initialBuff)
			{
			}

			// Token: 0x0600D609 RID: 54793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D609")]
			[Address(RVA = "0x35BE010", Offset = "0x35BCC10", VA = "0x1835BE010")]
			public void ResetWithBuff(Buff initialBuff)
			{
			}

			// Token: 0x0600D60A RID: 54794 RVA: 0x0004D610 File Offset: 0x0004B810
			[Token(Token = "0x600D60A")]
			[Address(RVA = "0x35BDDF0", Offset = "0x35BC9F0", VA = "0x1835BDDF0")]
			public bool Add(Buff buff)
			{
				return default(bool);
			}

			// Token: 0x0600D60B RID: 54795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D60B")]
			[Address(RVA = "0x35BDFA0", Offset = "0x35BCBA0", VA = "0x1835BDFA0")]
			public void Remove(Buff buff)
			{
			}

			// Token: 0x0600D60C RID: 54796 RVA: 0x0004D628 File Offset: 0x0004B828
			[Token(Token = "0x600D60C")]
			[Address(RVA = "0x35BE190", Offset = "0x35BCD90", VA = "0x1835BE190")]
			public int SafeCount()
			{
				return 0;
			}

			// Token: 0x0600D60D RID: 54797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D60D")]
			[Address(RVA = "0x35BE2F0", Offset = "0x35BCEF0", VA = "0x1835BE2F0")]
			public void UpdateMe()
			{
			}

			// Token: 0x0600D60E RID: 54798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D60E")]
			[Address(RVA = "0x35BDEC0", Offset = "0x35BCAC0", VA = "0x1835BDEC0")]
			public void Clear()
			{
			}

			// Token: 0x0600D60F RID: 54799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D60F")]
			[Address(RVA = "0x35BDF80", Offset = "0x35BCB80", VA = "0x1835BDF80")]
			public void ExtendStackCnt(int extend)
			{
			}

			// Token: 0x0600D610 RID: 54800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D610")]
			[Address(RVA = "0x35BE1E0", Offset = "0x35BCDE0", VA = "0x1835BE1E0")]
			public void SetMaxStackCnt(int count, bool updateCurrentStack = false)
			{
			}

			// Token: 0x0600D611 RID: 54801 RVA: 0x0004D640 File Offset: 0x0004B840
			[Token(Token = "0x600D611")]
			[Address(RVA = "0x35BE300", Offset = "0x35BCF00", VA = "0x1835BE300")]
			private bool _DoAddInternal(Buff buff)
			{
				return default(bool);
			}

			// Token: 0x0600D612 RID: 54802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D612")]
			[Address(RVA = "0x35BE760", Offset = "0x35BD360", VA = "0x1835BE760")]
			private void _DoUpdateInternal()
			{
			}

			// Token: 0x0400E5CB RID: 58827
			[Token(Token = "0x400E5CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private PriorityQueue<Buff> m_queue;

			// Token: 0x0400E5CC RID: 58828
			[Token(Token = "0x400E5CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private BuffData.OverrideType m_type;

			// Token: 0x0400E5CD RID: 58829
			[Token(Token = "0x400E5CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_maxStackCnt;

			// Token: 0x0400E5CE RID: 58830
			[Token(Token = "0x400E5CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_maxValidStackCnt;
		}

		// Token: 0x020021A1 RID: 8609
		[Token(Token = "0x20021A1")]
		public class BuffContainer : IHotfixable
		{
			// Token: 0x17001A01 RID: 6657
			// (get) Token: 0x0600D613 RID: 54803 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D614 RID: 54804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A01")]
			public Entity owner
			{
				[Token(Token = "0x600D613")]
				[Address(RVA = "0x35B7020", Offset = "0x35B5C20", VA = "0x1835B7020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600D614")]
				[Address(RVA = "0x35B7100", Offset = "0x35B5D00", VA = "0x1835B7100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001A02 RID: 6658
			// (get) Token: 0x0600D615 RID: 54805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A02")]
			public Attributes attributes
			{
				[Token(Token = "0x600D615")]
				[Address(RVA = "0x35B6E70", Offset = "0x35B5A70", VA = "0x1835B6E70")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A03 RID: 6659
			// (get) Token: 0x0600D616 RID: 54806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A03")]
			public Context context
			{
				[Token(Token = "0x600D616")]
				[Address(RVA = "0x35B6FA0", Offset = "0x35B5BA0", VA = "0x1835B6FA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A04 RID: 6660
			// (get) Token: 0x0600D617 RID: 54807 RVA: 0x0004D658 File Offset: 0x0004B858
			[Token(Token = "0x17001A04")]
			public int buffCnt
			{
				[Token(Token = "0x600D617")]
				[Address(RVA = "0x35B6F20", Offset = "0x35B5B20", VA = "0x1835B6F20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001A05 RID: 6661
			// (get) Token: 0x0600D618 RID: 54808 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A05")]
			private ObjectPool<Buff> pool
			{
				[Token(Token = "0x600D618")]
				[Address(RVA = "0x35B7080", Offset = "0x35B5C80", VA = "0x1835B7080")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600D619 RID: 54809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D619")]
			[Address(RVA = "0x359FA30", Offset = "0x359E630", VA = "0x18359FA30")]
			public static Buff CreateBuff()
			{
				return null;
			}

			// Token: 0x0600D61A RID: 54810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D61A")]
			[Address(RVA = "0x35B6C40", Offset = "0x35B5840", VA = "0x1835B6C40")]
			public BuffContainer(Entity owner)
			{
			}

			// Token: 0x0600D61B RID: 54811 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D61B")]
			[Address(RVA = "0x35A18B0", Offset = "0x35A04B0", VA = "0x1835A18B0")]
			public Buff NewBuff(BuffConfig input, Entity source, Ability ability, Blackboard extraBlackboard, Blackboard extraBlackboard2, [Optional] Projectile sourceProjectile, [Optional] string customOverrideEffectKey)
			{
				return null;
			}

			// Token: 0x0600D61C RID: 54812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D61C")]
			[Address(RVA = "0x359FD70", Offset = "0x359E970", VA = "0x18359FD70")]
			public Buff.OverrideGroup EnsureOverrideGroup(Buff buff)
			{
				return null;
			}

			// Token: 0x0600D61D RID: 54813 RVA: 0x0004D670 File Offset: 0x0004B870
			[Token(Token = "0x600D61D")]
			[Address(RVA = "0x35B20A0", Offset = "0x35B0CA0", VA = "0x1835B20A0")]
			public bool RemoveBuff(uint instanceUid)
			{
				return default(bool);
			}

			// Token: 0x0600D61E RID: 54814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D61E")]
			[Address(RVA = "0x35B2720", Offset = "0x35B1320", VA = "0x1835B2720")]
			public void RemoveBuffs(IList<uint> instanceUids)
			{
			}

			// Token: 0x0600D61F RID: 54815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D61F")]
			[Address(RVA = "0x35B24A0", Offset = "0x35B10A0", VA = "0x1835B24A0")]
			public void RemoveBuffs(string buffKey)
			{
			}

			// Token: 0x0600D620 RID: 54816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D620")]
			[Address(RVA = "0x35B29C0", Offset = "0x35B15C0", VA = "0x1835B29C0")]
			public void RemoveOneBuffByKey(string buffKey, bool checkBuffFinished = false)
			{
			}

			// Token: 0x0600D621 RID: 54817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D621")]
			[Address(RVA = "0x35B2170", Offset = "0x35B0D70", VA = "0x1835B2170")]
			public void RemoveBuffsByBuffSource(Entity entity, string buffKey, bool alsoClearNullSource)
			{
			}

			// Token: 0x0600D622 RID: 54818 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D622")]
			[Address(RVA = "0x359E230", Offset = "0x359CE30", VA = "0x18359E230")]
			public ReusableList<Entity> CollectBuffSourceByBuffKey_DISPOSE(string buffkey)
			{
				return null;
			}

			// Token: 0x0600D623 RID: 54819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D623")]
			[Address(RVA = "0x35B1E50", Offset = "0x35B0A50", VA = "0x1835B1E50")]
			public void RemoveAllStatusResistableBuffs()
			{
			}

			// Token: 0x0600D624 RID: 54820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D624")]
			[Address(RVA = "0x35B1BB0", Offset = "0x35B07B0", VA = "0x1835B1BB0")]
			public void RemoveAllBuffsWithCertainAbnormalFlag(AbnormalFlag abnormalFlag)
			{
			}

			// Token: 0x0600D625 RID: 54821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D625")]
			[Address(RVA = "0x35A02D0", Offset = "0x359EED0", VA = "0x1835A02D0")]
			public void ForceRefreshFinishedBuffs()
			{
			}

			// Token: 0x0600D626 RID: 54822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D626")]
			[Address(RVA = "0x35B2BF0", Offset = "0x35B17F0", VA = "0x1835B2BF0")]
			public void ResetAllBuffsTriggerTimer()
			{
			}

			// Token: 0x0600D627 RID: 54823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D627")]
			[Address(RVA = "0x359FAC0", Offset = "0x359E6C0", VA = "0x18359FAC0")]
			public void DecStackCntBuffsOrMarkFinish(string buffKey, bool updateOverrideMap, int decCnt = 1)
			{
			}

			// Token: 0x0600D628 RID: 54824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D628")]
			[Address(RVA = "0x35A05F0", Offset = "0x359F1F0", VA = "0x1835A05F0")]
			public Buff GetBuffByUid(uint instanceUid)
			{
				return null;
			}

			// Token: 0x0600D629 RID: 54825 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D629")]
			[Address(RVA = "0x35A0D40", Offset = "0x359F940", VA = "0x1835A0D40")]
			public Buff GetFirstBuffByKey(string buffKey)
			{
				return null;
			}

			// Token: 0x0600D62A RID: 54826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D62A")]
			[Address(RVA = "0x35A0330", Offset = "0x359EF30", VA = "0x1835A0330")]
			public void GetAllBuffsByKey(string buffKey, List<Buff> outBuffs)
			{
			}

			// Token: 0x0600D62B RID: 54827 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D62B")]
			[Address(RVA = "0x35A0AD0", Offset = "0x359F6D0", VA = "0x1835A0AD0")]
			public Buff GetFirstBuffByKeyAndSource(string buffKey, Entity source)
			{
				return null;
			}

			// Token: 0x0600D62C RID: 54828 RVA: 0x0004D688 File Offset: 0x0004B888
			[Token(Token = "0x600D62C")]
			[Address(RVA = "0x359CE60", Offset = "0x359BA60", VA = "0x18359CE60")]
			public bool CheckTriggerableBuffByKeys(string[] buffKeys, [Optional] Buff excludedBuff)
			{
				return default(bool);
			}

			// Token: 0x0600D62D RID: 54829 RVA: 0x0004D6A0 File Offset: 0x0004B8A0
			[Token(Token = "0x600D62D")]
			[Address(RVA = "0x35B35B0", Offset = "0x35B21B0", VA = "0x1835B35B0")]
			public bool TriggerBuffByKeys(string[] buffKeys, [Optional] Buff excludedBuff, bool force = false)
			{
				return default(bool);
			}

			// Token: 0x0600D62E RID: 54830 RVA: 0x0004D6B8 File Offset: 0x0004B8B8
			[Token(Token = "0x600D62E")]
			[Address(RVA = "0x35B32D0", Offset = "0x35B1ED0", VA = "0x1835B32D0")]
			public bool TriggerAllBuffsByKeys(string[] buffKeys, [Optional] Buff excludedBuff, bool force = false)
			{
				return default(bool);
			}

			// Token: 0x0600D62F RID: 54831 RVA: 0x0004D6D0 File Offset: 0x0004B8D0
			[Token(Token = "0x600D62F")]
			[Address(RVA = "0x35B5280", Offset = "0x35B3E80", VA = "0x1835B5280")]
			public bool TryGetOverrideGroup(string overrideKey, out Buff.OverrideGroup group)
			{
				return default(bool);
			}

			// Token: 0x0600D630 RID: 54832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D630")]
			[Address(RVA = "0x35A1080", Offset = "0x359FC80", VA = "0x1835A1080")]
			public string GetOverrideKeyCandidate(string independentKey)
			{
				return null;
			}

			// Token: 0x0600D631 RID: 54833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D631")]
			[Address(RVA = "0x35A0190", Offset = "0x359ED90", VA = "0x1835A0190")]
			public void EnsureOverrideIndependentKey(string independentKey, string overrideKey)
			{
			}

			// Token: 0x0600D632 RID: 54834 RVA: 0x0004D6E8 File Offset: 0x0004B8E8
			[Token(Token = "0x600D632")]
			[Address(RVA = "0x35B5340", Offset = "0x35B3F40", VA = "0x1835B5340")]
			public bool TryGetOverrideGroup(Buff buff, out Buff.OverrideGroup group)
			{
				return default(bool);
			}

			// Token: 0x0600D633 RID: 54835 RVA: 0x0004D700 File Offset: 0x0004B900
			[Token(Token = "0x600D633")]
			[Address(RVA = "0x359EC30", Offset = "0x359D830", VA = "0x18359EC30")]
			public bool ContainsBuff(string buffKey)
			{
				return default(bool);
			}

			// Token: 0x0600D634 RID: 54836 RVA: 0x0004D718 File Offset: 0x0004B918
			[Token(Token = "0x600D634")]
			[Address(RVA = "0x359E7E0", Offset = "0x359D3E0", VA = "0x18359E7E0")]
			public bool ContainsBuffFromCertainSource(string buffKey, Entity source)
			{
				return default(bool);
			}

			// Token: 0x0600D635 RID: 54837 RVA: 0x0004D730 File Offset: 0x0004B930
			[Token(Token = "0x600D635")]
			[Address(RVA = "0x359E560", Offset = "0x359D160", VA = "0x18359E560")]
			public bool ContainsBuffFromCertainCardUid(string buffKey, uint cardUid)
			{
				return default(bool);
			}

			// Token: 0x0600D636 RID: 54838 RVA: 0x0004D748 File Offset: 0x0004B948
			[Token(Token = "0x600D636")]
			[Address(RVA = "0x359EA40", Offset = "0x359D640", VA = "0x18359EA40")]
			public bool ContainsBuffWithValidator(Func<Buff, bool> validator)
			{
				return default(bool);
			}

			// Token: 0x0600D637 RID: 54839 RVA: 0x0004D760 File Offset: 0x0004B960
			[Token(Token = "0x600D637")]
			[Address(RVA = "0x359F390", Offset = "0x359DF90", VA = "0x18359F390")]
			public bool ContainsStatusResistableBuff()
			{
				return default(bool);
			}

			// Token: 0x0600D638 RID: 54840 RVA: 0x0004D778 File Offset: 0x0004B978
			[Token(Token = "0x600D638")]
			[Address(RVA = "0x359F100", Offset = "0x359DD00", VA = "0x18359F100")]
			public bool ContainsResistableAbnormalFlagsBuff()
			{
				return default(bool);
			}

			// Token: 0x0600D639 RID: 54841 RVA: 0x0004D790 File Offset: 0x0004B990
			[Token(Token = "0x600D639")]
			[Address(RVA = "0x359EE60", Offset = "0x359DA60", VA = "0x18359EE60")]
			public bool ContainsIrresistibleAbnormalFlagsBuff()
			{
				return default(bool);
			}

			// Token: 0x0600D63A RID: 54842 RVA: 0x0004D7A8 File Offset: 0x0004B9A8
			[Token(Token = "0x600D63A")]
			[Address(RVA = "0x35B4AD0", Offset = "0x35B36D0", VA = "0x1835B4AD0")]
			public bool TryGetFirstBuffStackCount(string buffKey, out int stackCnt)
			{
				return default(bool);
			}

			// Token: 0x0600D63B RID: 54843 RVA: 0x0004D7C0 File Offset: 0x0004B9C0
			[Token(Token = "0x600D63B")]
			[Address(RVA = "0x35B4830", Offset = "0x35B3430", VA = "0x1835B4830")]
			public bool TryGetFirstBuffStackCountFromCertainSource(string buffKey, Entity source, out int stackCnt)
			{
				return default(bool);
			}

			// Token: 0x0600D63C RID: 54844 RVA: 0x0004D7D8 File Offset: 0x0004B9D8
			[Token(Token = "0x600D63C")]
			[Address(RVA = "0x35B4FF0", Offset = "0x35B3BF0", VA = "0x1835B4FF0")]
			public bool TryGetFirstBuffValidStackCount(string buffKey, out int validStackCnt)
			{
				return default(bool);
			}

			// Token: 0x0600D63D RID: 54845 RVA: 0x0004D7F0 File Offset: 0x0004B9F0
			[Token(Token = "0x600D63D")]
			[Address(RVA = "0x35B4D10", Offset = "0x35B3910", VA = "0x1835B4D10")]
			public bool TryGetFirstBuffValidStackCountFromCertainSource(string buffKey, Entity source, out int validStackCnt)
			{
				return default(bool);
			}

			// Token: 0x0600D63E RID: 54846 RVA: 0x0004D808 File Offset: 0x0004BA08
			[Token(Token = "0x600D63E")]
			[Address(RVA = "0x35A0F70", Offset = "0x359FB70", VA = "0x1835A0F70")]
			public int GetOverridableBuffStackCount(string overrideKey)
			{
				return 0;
			}

			// Token: 0x0600D63F RID: 54847 RVA: 0x0004D820 File Offset: 0x0004BA20
			[Token(Token = "0x600D63F")]
			[Address(RVA = "0x35B4580", Offset = "0x35B3180", VA = "0x1835B4580")]
			public bool TryGetBuffCountByKeyFromAllBuffs(string buffKey, out int count)
			{
				return default(bool);
			}

			// Token: 0x0600D640 RID: 54848 RVA: 0x0004D838 File Offset: 0x0004BA38
			[Token(Token = "0x600D640")]
			[Address(RVA = "0x35A06F0", Offset = "0x359F2F0", VA = "0x1835A06F0")]
			public FP GetBuffValueMultiplierByKeyFromAllBuffs(string buffKey, string blackboardKeys, out int cnt, [Optional] Func<FP, FP> getResultFromBlackboardValue)
			{
				return default(FP);
			}

			// Token: 0x0600D641 RID: 54849 RVA: 0x0004D850 File Offset: 0x0004BA50
			[Token(Token = "0x600D641")]
			[Address(RVA = "0x35B4280", Offset = "0x35B2E80", VA = "0x1835B4280")]
			public bool TryGetBuffCountByKeyFromAllBuffsWithCertainSource(string buffKey, Entity source, out int count)
			{
				return default(bool);
			}

			// Token: 0x0600D642 RID: 54850 RVA: 0x0004D868 File Offset: 0x0004BA68
			[Token(Token = "0x600D642")]
			[Address(RVA = "0x35B3F30", Offset = "0x35B2B30", VA = "0x1835B3F30")]
			public bool TryGetBuffCountByBlackboardFromAll(string buffKey, string blackboardKey, int blackboardValue, out int count)
			{
				return default(bool);
			}

			// Token: 0x0600D643 RID: 54851 RVA: 0x0004D880 File Offset: 0x0004BA80
			[Token(Token = "0x600D643")]
			[Address(RVA = "0x35B3810", Offset = "0x35B2410", VA = "0x1835B3810")]
			public bool TryGetBuffBlackboardValueByBlackboardFromAll(string buffKey, string blackboardKey, int blackboardValue, string resultBlackboardKey, out int result)
			{
				return default(bool);
			}

			// Token: 0x0600D644 RID: 54852 RVA: 0x0004D898 File Offset: 0x0004BA98
			[Token(Token = "0x600D644")]
			[Address(RVA = "0x35B3B20", Offset = "0x35B2720", VA = "0x1835B3B20")]
			public bool TryGetBuffBlackboardValueByBuffKey(string buffKey, string blackboardKey, bool getMax, out FP result)
			{
				return default(bool);
			}

			// Token: 0x0600D645 RID: 54853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D645")]
			[Address(RVA = "0x35B2E30", Offset = "0x35B1A30", VA = "0x1835B2E30")]
			public void Tick(FP deltaTime)
			{
			}

			// Token: 0x0600D646 RID: 54854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D646")]
			[Address(RVA = "0x359DCC0", Offset = "0x359C8C0", VA = "0x18359DCC0")]
			public void Clear(bool immediatelyFinishEffect = false)
			{
			}

			// Token: 0x0600D647 RID: 54855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D647")]
			[Address(RVA = "0x359D0A0", Offset = "0x359BCA0", VA = "0x18359D0A0")]
			public void ClearWithWhiteList(List<string> inPutWhiteList, bool alsoRemoveDurableBuff = false)
			{
			}

			// Token: 0x0600D648 RID: 54856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D648")]
			[Address(RVA = "0x35B5F40", Offset = "0x35B4B40", VA = "0x1835B5F40")]
			private void _ClearBuffOverrideMapWithWhiteList(List<string> whiteList)
			{
			}

			// Token: 0x0600D649 RID: 54857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D649")]
			[Address(RVA = "0x35B6290", Offset = "0x35B4E90", VA = "0x1835B6290")]
			private void _ClearBuffUidMapWithWhiteList(List<uint> whiteList)
			{
			}

			// Token: 0x0600D64A RID: 54858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D64A")]
			[Address(RVA = "0x35B5660", Offset = "0x35B4260", VA = "0x1835B5660")]
			private void _CheckFinishedBuffs()
			{
			}

			// Token: 0x0600D64B RID: 54859 RVA: 0x0004D8B0 File Offset: 0x0004BAB0
			[Token(Token = "0x600D64B")]
			[Address(RVA = "0x35B5450", Offset = "0x35B4050", VA = "0x1835B5450")]
			private bool _CheckBuffsActionValid(Buff.Event ev)
			{
				return default(bool);
			}

			// Token: 0x0600D64C RID: 54860 RVA: 0x0004D8C8 File Offset: 0x0004BAC8
			[Token(Token = "0x600D64C")]
			[Address(RVA = "0x35B5AB0", Offset = "0x35B46B0", VA = "0x1835B5AB0")]
			private bool _CheckThroughBuffAbnormalAnti(BuffData data)
			{
				return default(bool);
			}

			// Token: 0x0600D64D RID: 54861 RVA: 0x0004D8E0 File Offset: 0x0004BAE0
			[Token(Token = "0x600D64D")]
			[Address(RVA = "0x35B5C90", Offset = "0x35B4890", VA = "0x1835B5C90")]
			private bool _CheckThroughBuffStatusResistableAnti(Buff buff)
			{
				return default(bool);
			}

			// Token: 0x0600D64E RID: 54862 RVA: 0x0004D8F8 File Offset: 0x0004BAF8
			[Token(Token = "0x600D64E")]
			[Address(RVA = "0x35B5D50", Offset = "0x35B4950", VA = "0x1835B5D50")]
			private bool _CheckThroughLevitateBuffCondition(BuffData data)
			{
				return default(bool);
			}

			// Token: 0x0600D64F RID: 54863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D64F")]
			[Address(RVA = "0x35B65D0", Offset = "0x35B51D0", VA = "0x1835B65D0")]
			private void _FilterBuffAbnormalAnti(long antiMask)
			{
			}

			// Token: 0x0600D650 RID: 54864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D650")]
			[Address(RVA = "0x35B6840", Offset = "0x35B5440", VA = "0x1835B6840")]
			private void _FinishAndRemoveBuff(Buff buff)
			{
			}

			// Token: 0x0600D651 RID: 54865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D651")]
			[Address(RVA = "0x35B6AD0", Offset = "0x35B56D0", VA = "0x1835B6AD0")]
			private void _FinishBuff(Buff buff, bool updateOverrideMap, bool delayToRecycle, bool immediatelyFinishEffect = false)
			{
			}

			// Token: 0x0600D652 RID: 54866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D652")]
			[Address(RVA = "0x35AD750", Offset = "0x35AC350", VA = "0x1835AD750")]
			public void OnOwnerBorn()
			{
			}

			// Token: 0x0600D653 RID: 54867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D653")]
			[Address(RVA = "0x35AE640", Offset = "0x35AD240", VA = "0x1835AE640")]
			public void OnOwnerPostBorn()
			{
			}

			// Token: 0x0600D654 RID: 54868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D654")]
			[Address(RVA = "0x35AE0F0", Offset = "0x35ACCF0", VA = "0x1835AE0F0")]
			public void OnOwnerLocate()
			{
			}

			// Token: 0x0600D655 RID: 54869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D655")]
			[Address(RVA = "0x35ADC00", Offset = "0x35AC800", VA = "0x1835ADC00")]
			public void OnOwnerFinish(Entity.FinishReason reason, Entity source)
			{
			}

			// Token: 0x0600D656 RID: 54870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D656")]
			[Address(RVA = "0x35AE890", Offset = "0x35AD490", VA = "0x1835AE890")]
			public void OnOwnerReborn()
			{
			}

			// Token: 0x0600D657 RID: 54871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D657")]
			[Address(RVA = "0x35AD9B0", Offset = "0x35AC5B0", VA = "0x1835AD9B0")]
			public void OnOwnerDying()
			{
			}

			// Token: 0x0600D658 RID: 54872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D658")]
			[Address(RVA = "0x35AA1E0", Offset = "0x35A8DE0", VA = "0x1835AA1E0")]
			public void OnGameOver()
			{
			}

			// Token: 0x0600D659 RID: 54873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D659")]
			[Address(RVA = "0x35A52E0", Offset = "0x35A3EE0", VA = "0x1835A52E0")]
			public void OnBeforeApplyingModifier(ref Modifier modifier)
			{
			}

			// Token: 0x0600D65A RID: 54874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D65A")]
			[Address(RVA = "0x35A43C0", Offset = "0x35A2FC0", VA = "0x1835A43C0")]
			public void OnApplyingModifier(ref Modifier modifier)
			{
			}

			// Token: 0x0600D65B RID: 54875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D65B")]
			[Address(RVA = "0x35A4020", Offset = "0x35A2C20", VA = "0x1835A4020")]
			public void OnAppliedModifier(ref Modifier modifier)
			{
			}

			// Token: 0x0600D65C RID: 54876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D65C")]
			[Address(RVA = "0x35A4760", Offset = "0x35A3360", VA = "0x1835A4760")]
			public void OnApplyingSkippedModifier(ref Modifier modifier)
			{
			}

			// Token: 0x0600D65D RID: 54877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D65D")]
			[Address(RVA = "0x35ACA40", Offset = "0x35AB640", VA = "0x1835ACA40")]
			public void OnOutputModifier(ref Modifier modifier)
			{
			}

			// Token: 0x0600D65E RID: 54878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D65E")]
			[Address(RVA = "0x35A69D0", Offset = "0x35A55D0", VA = "0x1835A69D0")]
			public void OnBeforeTargetApplyModifier(ref Modifier modifier)
			{
			}

			// Token: 0x0600D65F RID: 54879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D65F")]
			[Address(RVA = "0x35A3500", Offset = "0x35A2100", VA = "0x1835A3500")]
			public void OnAfterOutputDamage(ref Modifier modifier)
			{
			}

			// Token: 0x0600D660 RID: 54880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D660")]
			[Address(RVA = "0x35A3C60", Offset = "0x35A2860", VA = "0x1835A3C60")]
			public void OnAfterOutputHeal(ref Modifier modifier)
			{
			}

			// Token: 0x0600D661 RID: 54881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D661")]
			[Address(RVA = "0x35A38A0", Offset = "0x35A24A0", VA = "0x1835A38A0")]
			public void OnAfterOutputElementDamage(ref Modifier modifier)
			{
			}

			// Token: 0x0600D662 RID: 54882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D662")]
			[Address(RVA = "0x35A9E40", Offset = "0x35A8A40", VA = "0x1835A9E40")]
			public void OnEvadeDamage(ref Modifier modifier)
			{
			}

			// Token: 0x0600D663 RID: 54883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D663")]
			[Address(RVA = "0x35A7770", Offset = "0x35A6370", VA = "0x1835A7770")]
			public void OnBlockDamage(ref Modifier modifier)
			{
			}

			// Token: 0x0600D664 RID: 54884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D664")]
			[Address(RVA = "0x35B08D0", Offset = "0x35AF4D0", VA = "0x1835B08D0")]
			public void OnTakeDamage(ref Modifier modifier)
			{
			}

			// Token: 0x0600D665 RID: 54885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D665")]
			[Address(RVA = "0x35B0C70", Offset = "0x35AF870", VA = "0x1835B0C70")]
			public void OnTakeEPDamage(ref Modifier modifier)
			{
			}

			// Token: 0x0600D666 RID: 54886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D666")]
			[Address(RVA = "0x35A8BE0", Offset = "0x35A77E0", VA = "0x1835A8BE0")]
			public void OnEPBreakStart()
			{
			}

			// Token: 0x0600D667 RID: 54887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D667")]
			[Address(RVA = "0x35A6020", Offset = "0x35A4C20", VA = "0x1835A6020")]
			public void OnBeforeEPBreakStart()
			{
			}

			// Token: 0x0600D668 RID: 54888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D668")]
			[Address(RVA = "0x35A8970", Offset = "0x35A7570", VA = "0x1835A8970")]
			public void OnEPBreakFinish()
			{
			}

			// Token: 0x0600D669 RID: 54889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D669")]
			[Address(RVA = "0x35A5DB0", Offset = "0x35A49B0", VA = "0x1835A5DB0")]
			public void OnBeforeEPBreakFinish()
			{
			}

			// Token: 0x0600D66A RID: 54890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D66A")]
			[Address(RVA = "0x35AC6A0", Offset = "0x35AB2A0", VA = "0x1835AC6A0")]
			public void OnOutputDamage(ref Modifier modifier)
			{
			}

			// Token: 0x0600D66B RID: 54891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D66B")]
			[Address(RVA = "0x35AC360", Offset = "0x35AAF60", VA = "0x1835AC360")]
			public void OnOutputAtkOrHeal(Ability ability)
			{
			}

			// Token: 0x0600D66C RID: 54892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D66C")]
			[Address(RVA = "0x35AC020", Offset = "0x35AAC20", VA = "0x1835AC020")]
			public void OnOutputAtkOrHealEachSpell(Ability ability)
			{
			}

			// Token: 0x0600D66D RID: 54893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D66D")]
			[Address(RVA = "0x35B1030", Offset = "0x35AFC30", VA = "0x1835B1030")]
			public void OnTargetKilled(Entity target)
			{
			}

			// Token: 0x0600D66E RID: 54894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D66E")]
			[Address(RVA = "0x35A7DA0", Offset = "0x35A69A0", VA = "0x1835A7DA0")]
			public void OnCalculateCachedProjectileDamage(Entity target, ref BattleFormula.AttackInfo atkInfo)
			{
			}

			// Token: 0x0600D66F RID: 54895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D66F")]
			[Address(RVA = "0x35A8120", Offset = "0x35A6D20", VA = "0x1835A8120")]
			public void OnCalculateDamage(Entity target, ref BattleFormula.AttackInfo atkInfo)
			{
			}

			// Token: 0x0600D670 RID: 54896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D670")]
			[Address(RVA = "0x35A31E0", Offset = "0x35A1DE0", VA = "0x1835A31E0")]
			public void OnAfterCalculateDamage(Entity target)
			{
			}

			// Token: 0x0600D671 RID: 54897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D671")]
			[Address(RVA = "0x35A7400", Offset = "0x35A6000", VA = "0x1835A7400")]
			public void OnBeingCalculateDamage(ref BattleFormula.AttackInfo atkInfo)
			{
			}

			// Token: 0x0600D672 RID: 54898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D672")]
			[Address(RVA = "0x35A2B60", Offset = "0x35A1760", VA = "0x1835A2B60")]
			public void OnAbilityStart(Ability ability)
			{
			}

			// Token: 0x0600D673 RID: 54899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D673")]
			[Address(RVA = "0x35AB530", Offset = "0x35AA130", VA = "0x1835AB530")]
			public void OnMakeEnemyUnbalanced(Entity target)
			{
			}

			// Token: 0x0600D674 RID: 54900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D674")]
			[Address(RVA = "0x35A9140", Offset = "0x35A7D40", VA = "0x1835A9140")]
			public void OnEnterLevitateState()
			{
			}

			// Token: 0x0600D675 RID: 54901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D675")]
			[Address(RVA = "0x35A6290", Offset = "0x35A4E90", VA = "0x1835A6290")]
			public void OnBeforeExitLevitateState()
			{
			}

			// Token: 0x0600D676 RID: 54902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D676")]
			[Address(RVA = "0x35A8E50", Offset = "0x35A7A50", VA = "0x1835A8E50")]
			public void OnEndPulling(Entity target)
			{
			}

			// Token: 0x0600D677 RID: 54903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D677")]
			[Address(RVA = "0x35A6760", Offset = "0x35A5360", VA = "0x1835A6760")]
			public void OnBeforeFallDown()
			{
			}

			// Token: 0x0600D678 RID: 54904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D678")]
			[Address(RVA = "0x35AE350", Offset = "0x35ACF50", VA = "0x1835AE350")]
			public void OnOwnerOverlapped(Entity source)
			{
			}

			// Token: 0x0600D679 RID: 54905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D679")]
			[Address(RVA = "0x35A7B30", Offset = "0x35A6730", VA = "0x1835A7B30")]
			public void OnBossWaveWillStart()
			{
			}

			// Token: 0x0600D67A RID: 54906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D67A")]
			[Address(RVA = "0x35B0660", Offset = "0x35AF260", VA = "0x1835B0660")]
			public void OnStageEnd()
			{
			}

			// Token: 0x0600D67B RID: 54907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D67B")]
			[Address(RVA = "0x35ABA90", Offset = "0x35AA690", VA = "0x1835ABA90")]
			public void OnOtherBuffStart(Buff otherBuff)
			{
			}

			// Token: 0x0600D67C RID: 54908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D67C")]
			[Address(RVA = "0x35ABD30", Offset = "0x35AA930", VA = "0x1835ABD30")]
			public void OnOtherResistableBuffStart(Buff otherBuff)
			{
			}

			// Token: 0x0600D67D RID: 54909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D67D")]
			[Address(RVA = "0x35A21F0", Offset = "0x35A0DF0", VA = "0x1835A21F0")]
			public void OnAbilityFinish(Ability ability)
			{
			}

			// Token: 0x0600D67E RID: 54910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D67E")]
			[Address(RVA = "0x35A2530", Offset = "0x35A1130", VA = "0x1835A2530")]
			public void OnAbilityInterrupted(Ability ability)
			{
			}

			// Token: 0x0600D67F RID: 54911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D67F")]
			[Address(RVA = "0x35A4D80", Offset = "0x35A3980", VA = "0x1835A4D80")]
			public void OnBeforeAbilitySpellOn(Ability ability)
			{
			}

			// Token: 0x0600D680 RID: 54912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D680")]
			[Address(RVA = "0x35A2820", Offset = "0x35A1420", VA = "0x1835A2820")]
			public void OnAbilitySpellOn(Ability ability)
			{
			}

			// Token: 0x0600D681 RID: 54913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D681")]
			[Address(RVA = "0x35A1DC0", Offset = "0x35A09C0", VA = "0x1835A1DC0")]
			public void OnAbilityCastOnTarget(Ability ability, Entity target)
			{
			}

			// Token: 0x0600D682 RID: 54914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D682")]
			[Address(RVA = "0x35B0310", Offset = "0x35AEF10", VA = "0x1835B0310")]
			public void OnSkillStart(BasicSkill skill)
			{
			}

			// Token: 0x0600D683 RID: 54915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D683")]
			[Address(RVA = "0x35B1380", Offset = "0x35AFF80", VA = "0x1835B1380")]
			public void OnToggleSkillStart(BasicSkill skill)
			{
			}

			// Token: 0x0600D684 RID: 54916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D684")]
			[Address(RVA = "0x35AFFC0", Offset = "0x35AEBC0", VA = "0x1835AFFC0")]
			public void OnSkillRetriggered(RetriggerableCastSkillWithCost skill)
			{
			}

			// Token: 0x0600D685 RID: 54917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D685")]
			[Address(RVA = "0x35AF970", Offset = "0x35AE570", VA = "0x1835AF970")]
			public void OnSkillCastSucceed(BasicSkill skill)
			{
			}

			// Token: 0x0600D686 RID: 54918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D686")]
			[Address(RVA = "0x35AFC70", Offset = "0x35AE870", VA = "0x1835AFC70")]
			public void OnSkillFinish(BasicSkill skill)
			{
			}

			// Token: 0x0600D687 RID: 54919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D687")]
			[Address(RVA = "0x35A5680", Offset = "0x35A4280", VA = "0x1835A5680")]
			public void OnBeforeAttack()
			{
			}

			// Token: 0x0600D688 RID: 54920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D688")]
			[Address(RVA = "0x35A2EA0", Offset = "0x35A1AA0", VA = "0x1835A2EA0")]
			public void OnAfterAttack(Ability ability)
			{
			}

			// Token: 0x0600D689 RID: 54921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D689")]
			[Address(RVA = "0x35A6FF0", Offset = "0x35A5BF0", VA = "0x1835A6FF0")]
			public void OnBeforeTrySetHpZero(ref Modifier modifier, out Buff consumer)
			{
			}

			// Token: 0x0600D68A RID: 54922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D68A")]
			[Address(RVA = "0x35AF050", Offset = "0x35ADC50", VA = "0x1835AF050")]
			public void OnPostTrySetHpZero(Buff consumerBuff)
			{
			}

			// Token: 0x0600D68B RID: 54923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D68B")]
			[Address(RVA = "0x35A6D90", Offset = "0x35A5990", VA = "0x1835A6D90")]
			public void OnBeforeTrySetEpZero()
			{
			}

			// Token: 0x0600D68C RID: 54924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D68C")]
			[Address(RVA = "0x35A5B50", Offset = "0x35A4750", VA = "0x1835A5B50")]
			public void OnBeforeDisappear()
			{
			}

			// Token: 0x0600D68D RID: 54925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D68D")]
			[Address(RVA = "0x35A5070", Offset = "0x35A3C70", VA = "0x1835A5070")]
			public void OnBeforeAppear()
			{
			}

			// Token: 0x0600D68E RID: 54926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D68E")]
			[Address(RVA = "0x35ACDE0", Offset = "0x35AB9E0", VA = "0x1835ACDE0")]
			public void OnOwnerAbnormalFlagDirty()
			{
			}

			// Token: 0x0600D68F RID: 54927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D68F")]
			[Address(RVA = "0x35AD4F0", Offset = "0x35AC0F0", VA = "0x1835AD4F0")]
			public void OnOwnerBlockeeChanged()
			{
			}

			// Token: 0x0600D690 RID: 54928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D690")]
			[Address(RVA = "0x35AD290", Offset = "0x35ABE90", VA = "0x1835AD290")]
			public void OnOwnerBlockModeChanged()
			{
			}

			// Token: 0x0600D691 RID: 54929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D691")]
			[Address(RVA = "0x35A84A0", Offset = "0x35A70A0", VA = "0x1835A84A0")]
			public void OnCollideWithHighLand()
			{
			}

			// Token: 0x0600D692 RID: 54930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D692")]
			[Address(RVA = "0x35A6500", Offset = "0x35A5100", VA = "0x1835A6500")]
			public void OnBeforeExitUnbalancedState()
			{
			}

			// Token: 0x0600D693 RID: 54931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D693")]
			[Address(RVA = "0x35A9610", Offset = "0x35A8210", VA = "0x1835A9610")]
			public void OnEnterUnbalancedState()
			{
			}

			// Token: 0x0600D694 RID: 54932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D694")]
			[Address(RVA = "0x35A93B0", Offset = "0x35A7FB0", VA = "0x1835A93B0")]
			public void OnEnterMagicCircuit()
			{
			}

			// Token: 0x0600D695 RID: 54933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D695")]
			[Address(RVA = "0x35AAB80", Offset = "0x35A9780", VA = "0x1835AAB80")]
			public void OnLeaveMagicCircuit()
			{
			}

			// Token: 0x0600D696 RID: 54934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D696")]
			[Address(RVA = "0x35AEAE0", Offset = "0x35AD6E0", VA = "0x1835AEAE0")]
			public void OnOwnerRootTileChanged(Tile newTile)
			{
			}

			// Token: 0x0600D697 RID: 54935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D697")]
			[Address(RVA = "0x35AB820", Offset = "0x35AA420", VA = "0x1835AB820")]
			public void OnMotionModeChanged()
			{
			}

			// Token: 0x0600D698 RID: 54936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D698")]
			[Address(RVA = "0x35A8700", Offset = "0x35A7300", VA = "0x1835A8700")]
			public void OnDirectionChanged()
			{
			}

			// Token: 0x0600D699 RID: 54937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D699")]
			[Address(RVA = "0x35A58E0", Offset = "0x35A44E0", VA = "0x1835A58E0")]
			public void OnBeforeDirectionChange()
			{
			}

			// Token: 0x0600D69A RID: 54938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D69A")]
			[Address(RVA = "0x35A9BE0", Offset = "0x35A87E0", VA = "0x1835A9BE0")]
			public void OnEsOverZero()
			{
			}

			// Token: 0x0600D69B RID: 54939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D69B")]
			[Address(RVA = "0x35AB050", Offset = "0x35A9C50", VA = "0x1835AB050")]
			public void OnLegionModeDrawCard()
			{
			}

			// Token: 0x0600D69C RID: 54940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D69C")]
			[Address(RVA = "0x35AB2C0", Offset = "0x35A9EC0", VA = "0x1835AB2C0")]
			public void OnLegionModeRefreshCard()
			{
			}

			// Token: 0x0600D69D RID: 54941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D69D")]
			[Address(RVA = "0x35AF710", Offset = "0x35AE310", VA = "0x1835AF710")]
			public void OnSandboxOwnerResChanged()
			{
			}

			// Token: 0x0600D69E RID: 54942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D69E")]
			[Address(RVA = "0x35A4B20", Offset = "0x35A3720", VA = "0x1835A4B20")]
			public void OnAutoChessModeChanged()
			{
			}

			// Token: 0x0600D69F RID: 54943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D69F")]
			[Address(RVA = "0x35A9880", Offset = "0x35A8480", VA = "0x1835A9880")]
			public void OnEntityWillOverlap(Entity entity, SharedConsts.Direction direction)
			{
			}

			// Token: 0x0600D6A0 RID: 54944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6A0")]
			[Address(RVA = "0x35AD040", Offset = "0x35ABC40", VA = "0x1835AD040")]
			public void OnOwnerBeforeDead()
			{
			}

			// Token: 0x0600D6A1 RID: 54945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6A1")]
			[Address(RVA = "0x35ADE80", Offset = "0x35ACA80", VA = "0x1835ADE80")]
			public void OnOwnerHpFull()
			{
			}

			// Token: 0x0600D6A2 RID: 54946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6A2")]
			[Address(RVA = "0x35B1940", Offset = "0x35B0540", VA = "0x1835B1940")]
			public void OnUnitSwitchMode()
			{
			}

			// Token: 0x0600D6A3 RID: 54947 RVA: 0x0004D910 File Offset: 0x0004BB10
			[Token(Token = "0x600D6A3")]
			[Address(RVA = "0x35AEDD0", Offset = "0x35AD9D0", VA = "0x1835AEDD0")]
			public bool OnPalsyOverflow()
			{
				return default(bool);
			}

			// Token: 0x0600D6A4 RID: 54948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6A4")]
			[Address(RVA = "0x35B16D0", Offset = "0x35B02D0", VA = "0x1835B16D0")]
			public void OnTriggerPalsy()
			{
			}

			// Token: 0x0600D6A5 RID: 54949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6A5")]
			[Address(RVA = "0x359F550", Offset = "0x359E150", VA = "0x18359F550")]
			public void CooperatePlayerDying()
			{
			}

			// Token: 0x0600D6A6 RID: 54950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6A6")]
			[Address(RVA = "0x359F7C0", Offset = "0x359E3C0", VA = "0x18359F7C0")]
			public void CooperatePlayerRevive()
			{
			}

			// Token: 0x0600D6A7 RID: 54951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6A7")]
			[Address(RVA = "0x35AADE0", Offset = "0x35A99E0", VA = "0x1835AADE0")]
			public void OnLegionModeDangerLevelRefresh()
			{
			}

			// Token: 0x0600D6A8 RID: 54952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6A8")]
			[Address(RVA = "0x35AA910", Offset = "0x35A9510", VA = "0x1835AA910")]
			public void OnHalfIdleTrapCheckUpgrade()
			{
			}

			// Token: 0x0600D6A9 RID: 54953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6A9")]
			[Address(RVA = "0x35AA6A0", Offset = "0x35A92A0", VA = "0x1835AA6A0")]
			public void OnHalfIdleKawaPolluted()
			{
			}

			// Token: 0x0600D6AA RID: 54954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6AA")]
			[Address(RVA = "0x35AA430", Offset = "0x35A9030", VA = "0x1835AA430")]
			public void OnHalfIdleKawaCleaned()
			{
			}

			// Token: 0x0600D6AB RID: 54955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6AB")]
			[Address(RVA = "0x35AF340", Offset = "0x35ADF40", VA = "0x1835AF340")]
			public void OnProjectileSelectTargets(Projectile projectile, int targetCount)
			{
			}

			// Token: 0x0600D6AC RID: 54956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6AC")]
			[Address(RVA = "0x35A1250", Offset = "0x359FE50", VA = "0x1835A1250")]
			public void HalfIdleGainEquip(Entity gainEquipSource)
			{
			}

			// Token: 0x0600D6AD RID: 54957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D6AD")]
			[Address(RVA = "0x35A1580", Offset = "0x35A0180", VA = "0x1835A1580")]
			public void HalfIdleGainTrap(Entity gainTrapSource)
			{
			}

			// Token: 0x0600D6AE RID: 54958 RVA: 0x0004D928 File Offset: 0x0004BB28
			[Token(Token = "0x600D6AE")]
			[Address(RVA = "0x359CB60", Offset = "0x359B760", VA = "0x18359CB60")]
			public FP CalculateShieldValue()
			{
				return default(FP);
			}

			// Token: 0x0400E5D0 RID: 58832
			[Token(Token = "0x400E5D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Buff.SortedDoubleBufferedBuffList m_buffs;

			// Token: 0x0400E5D1 RID: 58833
			[Token(Token = "0x400E5D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Dictionary<string, Buff.OverrideGroup> m_buffOverrideMap;

			// Token: 0x0400E5D2 RID: 58834
			[Token(Token = "0x400E5D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<uint, Buff> m_buffUidMap;

			// Token: 0x0400E5D3 RID: 58835
			[Token(Token = "0x400E5D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x0400E5D4 RID: 58836
			[Token(Token = "0x400E5D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_owner;

			// Token: 0x0400E5D5 RID: 58837
			[Token(Token = "0x400E5D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_attributes;

			// Token: 0x0400E5D6 RID: 58838
			[Token(Token = "0x400E5D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_context;

			// Token: 0x0400E5D7 RID: 58839
			[Token(Token = "0x400E5D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_buffCnt;

			// Token: 0x0400E5D8 RID: 58840
			[Token(Token = "0x400E5D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_pool;

			// Token: 0x0400E5D9 RID: 58841
			[Token(Token = "0x400E5D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CreateBuff;

			// Token: 0x0400E5DA RID: 58842
			[Token(Token = "0x400E5DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400E5DB RID: 58843
			[Token(Token = "0x400E5DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_NewBuff;

			// Token: 0x0400E5DC RID: 58844
			[Token(Token = "0x400E5DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_EnsureOverrideGroup;

			// Token: 0x0400E5DD RID: 58845
			[Token(Token = "0x400E5DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_RemoveBuff;

			// Token: 0x0400E5DE RID: 58846
			[Token(Token = "0x400E5DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_RemoveBuffs;

			// Token: 0x0400E5DF RID: 58847
			[Token(Token = "0x400E5DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix1_RemoveBuffs;

			// Token: 0x0400E5E0 RID: 58848
			[Token(Token = "0x400E5E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_RemoveOneBuffByKey;

			// Token: 0x0400E5E1 RID: 58849
			[Token(Token = "0x400E5E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_RemoveBuffsByBuffSource;

			// Token: 0x0400E5E2 RID: 58850
			[Token(Token = "0x400E5E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_CollectBuffSourceByBuffKey_DISPOSE;

			// Token: 0x0400E5E3 RID: 58851
			[Token(Token = "0x400E5E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_RemoveAllStatusResistableBuffs;

			// Token: 0x0400E5E4 RID: 58852
			[Token(Token = "0x400E5E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_RemoveAllBuffsWithCertainAbnormalFlag;

			// Token: 0x0400E5E5 RID: 58853
			[Token(Token = "0x400E5E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_ForceRefreshFinishedBuffs;

			// Token: 0x0400E5E6 RID: 58854
			[Token(Token = "0x400E5E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_ResetAllBuffsTriggerTimer;

			// Token: 0x0400E5E7 RID: 58855
			[Token(Token = "0x400E5E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_DecStackCntBuffsOrMarkFinish;

			// Token: 0x0400E5E8 RID: 58856
			[Token(Token = "0x400E5E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_GetBuffByUid;

			// Token: 0x0400E5E9 RID: 58857
			[Token(Token = "0x400E5E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_GetFirstBuffByKey;

			// Token: 0x0400E5EA RID: 58858
			[Token(Token = "0x400E5EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_GetAllBuffsByKey;

			// Token: 0x0400E5EB RID: 58859
			[Token(Token = "0x400E5EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_GetFirstBuffByKeyAndSource;

			// Token: 0x0400E5EC RID: 58860
			[Token(Token = "0x400E5EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_CheckTriggerableBuffByKeys;

			// Token: 0x0400E5ED RID: 58861
			[Token(Token = "0x400E5ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_TriggerBuffByKeys;

			// Token: 0x0400E5EE RID: 58862
			[Token(Token = "0x400E5EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_TriggerAllBuffsByKeys;

			// Token: 0x0400E5EF RID: 58863
			[Token(Token = "0x400E5EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_TryGetOverrideGroup;

			// Token: 0x0400E5F0 RID: 58864
			[Token(Token = "0x400E5F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_GetOverrideKeyCandidate;

			// Token: 0x0400E5F1 RID: 58865
			[Token(Token = "0x400E5F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_EnsureOverrideIndependentKey;

			// Token: 0x0400E5F2 RID: 58866
			[Token(Token = "0x400E5F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix1_TryGetOverrideGroup;

			// Token: 0x0400E5F3 RID: 58867
			[Token(Token = "0x400E5F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_ContainsBuff;

			// Token: 0x0400E5F4 RID: 58868
			[Token(Token = "0x400E5F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_ContainsBuffFromCertainSource;

			// Token: 0x0400E5F5 RID: 58869
			[Token(Token = "0x400E5F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0_ContainsBuffFromCertainCardUid;

			// Token: 0x0400E5F6 RID: 58870
			[Token(Token = "0x400E5F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_ContainsBuffWithValidator;

			// Token: 0x0400E5F7 RID: 58871
			[Token(Token = "0x400E5F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_ContainsStatusResistableBuff;

			// Token: 0x0400E5F8 RID: 58872
			[Token(Token = "0x400E5F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_ContainsResistableAbnormalFlagsBuff;

			// Token: 0x0400E5F9 RID: 58873
			[Token(Token = "0x400E5F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_ContainsIrresistibleAbnormalFlagsBuff;

			// Token: 0x0400E5FA RID: 58874
			[Token(Token = "0x400E5FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0_TryGetFirstBuffStackCount;

			// Token: 0x0400E5FB RID: 58875
			[Token(Token = "0x400E5FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0_TryGetFirstBuffStackCountFromCertainSource;

			// Token: 0x0400E5FC RID: 58876
			[Token(Token = "0x400E5FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0_TryGetFirstBuffValidStackCount;

			// Token: 0x0400E5FD RID: 58877
			[Token(Token = "0x400E5FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0_TryGetFirstBuffValidStackCountFromCertainSource;

			// Token: 0x0400E5FE RID: 58878
			[Token(Token = "0x400E5FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0_GetOverridableBuffStackCount;

			// Token: 0x0400E5FF RID: 58879
			[Token(Token = "0x400E5FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_TryGetBuffCountByKeyFromAllBuffs;

			// Token: 0x0400E600 RID: 58880
			[Token(Token = "0x400E600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0_GetBuffValueMultiplierByKeyFromAllBuffs;

			// Token: 0x0400E601 RID: 58881
			[Token(Token = "0x400E601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0_TryGetBuffCountByKeyFromAllBuffsWithCertainSource;

			// Token: 0x0400E602 RID: 58882
			[Token(Token = "0x400E602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0_TryGetBuffCountByBlackboardFromAll;

			// Token: 0x0400E603 RID: 58883
			[Token(Token = "0x400E603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0_TryGetBuffBlackboardValueByBlackboardFromAll;

			// Token: 0x0400E604 RID: 58884
			[Token(Token = "0x400E604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private static DelegateBridge __Hotfix0_TryGetBuffBlackboardValueByBuffKey;

			// Token: 0x0400E605 RID: 58885
			[Token(Token = "0x400E605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x0400E606 RID: 58886
			[Token(Token = "0x400E606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private static DelegateBridge __Hotfix0_Clear;

			// Token: 0x0400E607 RID: 58887
			[Token(Token = "0x400E607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private static DelegateBridge __Hotfix0_ClearWithWhiteList;

			// Token: 0x0400E608 RID: 58888
			[Token(Token = "0x400E608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private static DelegateBridge __Hotfix0__ClearBuffOverrideMapWithWhiteList;

			// Token: 0x0400E609 RID: 58889
			[Token(Token = "0x400E609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			private static DelegateBridge __Hotfix0__ClearBuffUidMapWithWhiteList;

			// Token: 0x0400E60A RID: 58890
			[Token(Token = "0x400E60A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private static DelegateBridge __Hotfix0__CheckFinishedBuffs;

			// Token: 0x0400E60B RID: 58891
			[Token(Token = "0x400E60B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private static DelegateBridge __Hotfix0__CheckBuffsActionValid;

			// Token: 0x0400E60C RID: 58892
			[Token(Token = "0x400E60C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private static DelegateBridge __Hotfix0__CheckThroughBuffAbnormalAnti;

			// Token: 0x0400E60D RID: 58893
			[Token(Token = "0x400E60D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private static DelegateBridge __Hotfix0__CheckThroughBuffStatusResistableAnti;

			// Token: 0x0400E60E RID: 58894
			[Token(Token = "0x400E60E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private static DelegateBridge __Hotfix0__CheckThroughLevitateBuffCondition;

			// Token: 0x0400E60F RID: 58895
			[Token(Token = "0x400E60F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private static DelegateBridge __Hotfix0__FilterBuffAbnormalAnti;

			// Token: 0x0400E610 RID: 58896
			[Token(Token = "0x400E610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private static DelegateBridge __Hotfix0__FinishAndRemoveBuff;

			// Token: 0x0400E611 RID: 58897
			[Token(Token = "0x400E611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private static DelegateBridge __Hotfix0__FinishBuff;

			// Token: 0x0400E612 RID: 58898
			[Token(Token = "0x400E612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private static DelegateBridge __Hotfix0_OnOwnerBorn;

			// Token: 0x0400E613 RID: 58899
			[Token(Token = "0x400E613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private static DelegateBridge __Hotfix0_OnOwnerPostBorn;

			// Token: 0x0400E614 RID: 58900
			[Token(Token = "0x400E614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private static DelegateBridge __Hotfix0_OnOwnerLocate;

			// Token: 0x0400E615 RID: 58901
			[Token(Token = "0x400E615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private static DelegateBridge __Hotfix0_OnOwnerFinish;

			// Token: 0x0400E616 RID: 58902
			[Token(Token = "0x400E616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private static DelegateBridge __Hotfix0_OnOwnerReborn;

			// Token: 0x0400E617 RID: 58903
			[Token(Token = "0x400E617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private static DelegateBridge __Hotfix0_OnOwnerDying;

			// Token: 0x0400E618 RID: 58904
			[Token(Token = "0x400E618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			private static DelegateBridge __Hotfix0_OnGameOver;

			// Token: 0x0400E619 RID: 58905
			[Token(Token = "0x400E619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
			private static DelegateBridge __Hotfix0_OnBeforeApplyingModifier;

			// Token: 0x0400E61A RID: 58906
			[Token(Token = "0x400E61A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			private static DelegateBridge __Hotfix0_OnApplyingModifier;

			// Token: 0x0400E61B RID: 58907
			[Token(Token = "0x400E61B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
			private static DelegateBridge __Hotfix0_OnAppliedModifier;

			// Token: 0x0400E61C RID: 58908
			[Token(Token = "0x400E61C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
			private static DelegateBridge __Hotfix0_OnApplyingSkippedModifier;

			// Token: 0x0400E61D RID: 58909
			[Token(Token = "0x400E61D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
			private static DelegateBridge __Hotfix0_OnOutputModifier;

			// Token: 0x0400E61E RID: 58910
			[Token(Token = "0x400E61E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
			private static DelegateBridge __Hotfix0_OnBeforeTargetApplyModifier;

			// Token: 0x0400E61F RID: 58911
			[Token(Token = "0x400E61F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
			private static DelegateBridge __Hotfix0_OnAfterOutputDamage;

			// Token: 0x0400E620 RID: 58912
			[Token(Token = "0x400E620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
			private static DelegateBridge __Hotfix0_OnAfterOutputHeal;

			// Token: 0x0400E621 RID: 58913
			[Token(Token = "0x400E621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
			private static DelegateBridge __Hotfix0_OnAfterOutputElementDamage;

			// Token: 0x0400E622 RID: 58914
			[Token(Token = "0x400E622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
			private static DelegateBridge __Hotfix0_OnEvadeDamage;

			// Token: 0x0400E623 RID: 58915
			[Token(Token = "0x400E623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
			private static DelegateBridge __Hotfix0_OnBlockDamage;

			// Token: 0x0400E624 RID: 58916
			[Token(Token = "0x400E624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
			private static DelegateBridge __Hotfix0_OnTakeDamage;

			// Token: 0x0400E625 RID: 58917
			[Token(Token = "0x400E625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
			private static DelegateBridge __Hotfix0_OnTakeEPDamage;

			// Token: 0x0400E626 RID: 58918
			[Token(Token = "0x400E626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
			private static DelegateBridge __Hotfix0_OnEPBreakStart;

			// Token: 0x0400E627 RID: 58919
			[Token(Token = "0x400E627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
			private static DelegateBridge __Hotfix0_OnBeforeEPBreakStart;

			// Token: 0x0400E628 RID: 58920
			[Token(Token = "0x400E628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
			private static DelegateBridge __Hotfix0_OnEPBreakFinish;

			// Token: 0x0400E629 RID: 58921
			[Token(Token = "0x400E629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
			private static DelegateBridge __Hotfix0_OnBeforeEPBreakFinish;

			// Token: 0x0400E62A RID: 58922
			[Token(Token = "0x400E62A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
			private static DelegateBridge __Hotfix0_OnOutputDamage;

			// Token: 0x0400E62B RID: 58923
			[Token(Token = "0x400E62B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
			private static DelegateBridge __Hotfix0_OnOutputAtkOrHeal;

			// Token: 0x0400E62C RID: 58924
			[Token(Token = "0x400E62C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			private static DelegateBridge __Hotfix0_OnOutputAtkOrHealEachSpell;

			// Token: 0x0400E62D RID: 58925
			[Token(Token = "0x400E62D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			private static DelegateBridge __Hotfix0_OnTargetKilled;

			// Token: 0x0400E62E RID: 58926
			[Token(Token = "0x400E62E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			private static DelegateBridge __Hotfix0_OnCalculateCachedProjectileDamage;

			// Token: 0x0400E62F RID: 58927
			[Token(Token = "0x400E62F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			private static DelegateBridge __Hotfix0_OnCalculateDamage;

			// Token: 0x0400E630 RID: 58928
			[Token(Token = "0x400E630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
			private static DelegateBridge __Hotfix0_OnAfterCalculateDamage;

			// Token: 0x0400E631 RID: 58929
			[Token(Token = "0x400E631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
			private static DelegateBridge __Hotfix0_OnBeingCalculateDamage;

			// Token: 0x0400E632 RID: 58930
			[Token(Token = "0x400E632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
			private static DelegateBridge __Hotfix0_OnAbilityStart;

			// Token: 0x0400E633 RID: 58931
			[Token(Token = "0x400E633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
			private static DelegateBridge __Hotfix0_OnMakeEnemyUnbalanced;

			// Token: 0x0400E634 RID: 58932
			[Token(Token = "0x400E634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
			private static DelegateBridge __Hotfix0_OnEnterLevitateState;

			// Token: 0x0400E635 RID: 58933
			[Token(Token = "0x400E635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
			private static DelegateBridge __Hotfix0_OnBeforeExitLevitateState;

			// Token: 0x0400E636 RID: 58934
			[Token(Token = "0x400E636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
			private static DelegateBridge __Hotfix0_OnEndPulling;

			// Token: 0x0400E637 RID: 58935
			[Token(Token = "0x400E637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
			private static DelegateBridge __Hotfix0_OnBeforeFallDown;

			// Token: 0x0400E638 RID: 58936
			[Token(Token = "0x400E638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
			private static DelegateBridge __Hotfix0_OnOwnerOverlapped;

			// Token: 0x0400E639 RID: 58937
			[Token(Token = "0x400E639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
			private static DelegateBridge __Hotfix0_OnBossWaveWillStart;

			// Token: 0x0400E63A RID: 58938
			[Token(Token = "0x400E63A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
			private static DelegateBridge __Hotfix0_OnStageEnd;

			// Token: 0x0400E63B RID: 58939
			[Token(Token = "0x400E63B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
			private static DelegateBridge __Hotfix0_OnOtherBuffStart;

			// Token: 0x0400E63C RID: 58940
			[Token(Token = "0x400E63C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
			private static DelegateBridge __Hotfix0_OnOtherResistableBuffStart;

			// Token: 0x0400E63D RID: 58941
			[Token(Token = "0x400E63D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
			private static DelegateBridge __Hotfix0_OnAbilityFinish;

			// Token: 0x0400E63E RID: 58942
			[Token(Token = "0x400E63E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
			private static DelegateBridge __Hotfix0_OnAbilityInterrupted;

			// Token: 0x0400E63F RID: 58943
			[Token(Token = "0x400E63F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
			private static DelegateBridge __Hotfix0_OnBeforeAbilitySpellOn;

			// Token: 0x0400E640 RID: 58944
			[Token(Token = "0x400E640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
			private static DelegateBridge __Hotfix0_OnAbilitySpellOn;

			// Token: 0x0400E641 RID: 58945
			[Token(Token = "0x400E641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
			private static DelegateBridge __Hotfix0_OnAbilityCastOnTarget;

			// Token: 0x0400E642 RID: 58946
			[Token(Token = "0x400E642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
			private static DelegateBridge __Hotfix0_OnSkillStart;

			// Token: 0x0400E643 RID: 58947
			[Token(Token = "0x400E643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
			private static DelegateBridge __Hotfix0_OnToggleSkillStart;

			// Token: 0x0400E644 RID: 58948
			[Token(Token = "0x400E644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
			private static DelegateBridge __Hotfix0_OnSkillRetriggered;

			// Token: 0x0400E645 RID: 58949
			[Token(Token = "0x400E645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
			private static DelegateBridge __Hotfix0_OnSkillCastSucceed;

			// Token: 0x0400E646 RID: 58950
			[Token(Token = "0x400E646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
			private static DelegateBridge __Hotfix0_OnSkillFinish;

			// Token: 0x0400E647 RID: 58951
			[Token(Token = "0x400E647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
			private static DelegateBridge __Hotfix0_OnBeforeAttack;

			// Token: 0x0400E648 RID: 58952
			[Token(Token = "0x400E648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
			private static DelegateBridge __Hotfix0_OnAfterAttack;

			// Token: 0x0400E649 RID: 58953
			[Token(Token = "0x400E649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
			private static DelegateBridge __Hotfix0_OnBeforeTrySetHpZero;

			// Token: 0x0400E64A RID: 58954
			[Token(Token = "0x400E64A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
			private static DelegateBridge __Hotfix0_OnPostTrySetHpZero;

			// Token: 0x0400E64B RID: 58955
			[Token(Token = "0x400E64B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
			private static DelegateBridge __Hotfix0_OnBeforeTrySetEpZero;

			// Token: 0x0400E64C RID: 58956
			[Token(Token = "0x400E64C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
			private static DelegateBridge __Hotfix0_OnBeforeDisappear;

			// Token: 0x0400E64D RID: 58957
			[Token(Token = "0x400E64D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
			private static DelegateBridge __Hotfix0_OnBeforeAppear;

			// Token: 0x0400E64E RID: 58958
			[Token(Token = "0x400E64E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
			private static DelegateBridge __Hotfix0_OnOwnerAbnormalFlagDirty;

			// Token: 0x0400E64F RID: 58959
			[Token(Token = "0x400E64F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
			private static DelegateBridge __Hotfix0_OnOwnerBlockeeChanged;

			// Token: 0x0400E650 RID: 58960
			[Token(Token = "0x400E650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
			private static DelegateBridge __Hotfix0_OnOwnerBlockModeChanged;

			// Token: 0x0400E651 RID: 58961
			[Token(Token = "0x400E651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
			private static DelegateBridge __Hotfix0_OnCollideWithHighLand;

			// Token: 0x0400E652 RID: 58962
			[Token(Token = "0x400E652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
			private static DelegateBridge __Hotfix0_OnBeforeExitUnbalancedState;

			// Token: 0x0400E653 RID: 58963
			[Token(Token = "0x400E653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
			private static DelegateBridge __Hotfix0_OnEnterUnbalancedState;

			// Token: 0x0400E654 RID: 58964
			[Token(Token = "0x400E654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
			private static DelegateBridge __Hotfix0_OnEnterMagicCircuit;

			// Token: 0x0400E655 RID: 58965
			[Token(Token = "0x400E655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
			private static DelegateBridge __Hotfix0_OnLeaveMagicCircuit;

			// Token: 0x0400E656 RID: 58966
			[Token(Token = "0x400E656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
			private static DelegateBridge __Hotfix0_OnOwnerRootTileChanged;

			// Token: 0x0400E657 RID: 58967
			[Token(Token = "0x400E657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
			private static DelegateBridge __Hotfix0_OnMotionModeChanged;

			// Token: 0x0400E658 RID: 58968
			[Token(Token = "0x400E658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
			private static DelegateBridge __Hotfix0_OnDirectionChanged;

			// Token: 0x0400E659 RID: 58969
			[Token(Token = "0x400E659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
			private static DelegateBridge __Hotfix0_OnBeforeDirectionChange;

			// Token: 0x0400E65A RID: 58970
			[Token(Token = "0x400E65A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
			private static DelegateBridge __Hotfix0_OnEsOverZero;

			// Token: 0x0400E65B RID: 58971
			[Token(Token = "0x400E65B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
			private static DelegateBridge __Hotfix0_OnLegionModeDrawCard;

			// Token: 0x0400E65C RID: 58972
			[Token(Token = "0x400E65C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
			private static DelegateBridge __Hotfix0_OnLegionModeRefreshCard;

			// Token: 0x0400E65D RID: 58973
			[Token(Token = "0x400E65D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
			private static DelegateBridge __Hotfix0_OnSandboxOwnerResChanged;

			// Token: 0x0400E65E RID: 58974
			[Token(Token = "0x400E65E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
			private static DelegateBridge __Hotfix0_OnAutoChessModeChanged;

			// Token: 0x0400E65F RID: 58975
			[Token(Token = "0x400E65F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
			private static DelegateBridge __Hotfix0_OnEntityWillOverlap;

			// Token: 0x0400E660 RID: 58976
			[Token(Token = "0x400E660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
			private static DelegateBridge __Hotfix0_OnOwnerBeforeDead;

			// Token: 0x0400E661 RID: 58977
			[Token(Token = "0x400E661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
			private static DelegateBridge __Hotfix0_OnOwnerHpFull;

			// Token: 0x0400E662 RID: 58978
			[Token(Token = "0x400E662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
			private static DelegateBridge __Hotfix0_OnUnitSwitchMode;

			// Token: 0x0400E663 RID: 58979
			[Token(Token = "0x400E663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
			private static DelegateBridge __Hotfix0_OnPalsyOverflow;

			// Token: 0x0400E664 RID: 58980
			[Token(Token = "0x400E664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
			private static DelegateBridge __Hotfix0_OnTriggerPalsy;

			// Token: 0x0400E665 RID: 58981
			[Token(Token = "0x400E665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
			private static DelegateBridge __Hotfix0_CooperatePlayerDying;

			// Token: 0x0400E666 RID: 58982
			[Token(Token = "0x400E666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
			private static DelegateBridge __Hotfix0_CooperatePlayerRevive;

			// Token: 0x0400E667 RID: 58983
			[Token(Token = "0x400E667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
			private static DelegateBridge __Hotfix0_OnLegionModeDangerLevelRefresh;

			// Token: 0x0400E668 RID: 58984
			[Token(Token = "0x400E668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
			private static DelegateBridge __Hotfix0_OnHalfIdleTrapCheckUpgrade;

			// Token: 0x0400E669 RID: 58985
			[Token(Token = "0x400E669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
			private static DelegateBridge __Hotfix0_OnHalfIdleKawaPolluted;

			// Token: 0x0400E66A RID: 58986
			[Token(Token = "0x400E66A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
			private static DelegateBridge __Hotfix0_OnHalfIdleKawaCleaned;

			// Token: 0x0400E66B RID: 58987
			[Token(Token = "0x400E66B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
			private static DelegateBridge __Hotfix0_OnProjectileSelectTargets;

			// Token: 0x0400E66C RID: 58988
			[Token(Token = "0x400E66C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
			private static DelegateBridge __Hotfix0_HalfIdleGainEquip;

			// Token: 0x0400E66D RID: 58989
			[Token(Token = "0x400E66D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
			private static DelegateBridge __Hotfix0_HalfIdleGainTrap;

			// Token: 0x0400E66E RID: 58990
			[Token(Token = "0x400E66E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
			private static DelegateBridge __Hotfix0_CalculateShieldValue;
		}

		// Token: 0x020021A2 RID: 8610
		[Token(Token = "0x20021A2")]
		public enum Event
		{
			// Token: 0x0400E670 RID: 58992
			[Token(Token = "0x400E670")]
			[RunActionsWhenDisabled(true)]
			ON_BUFF_START,
			// Token: 0x0400E671 RID: 58993
			[Token(Token = "0x400E671")]
			[RunActionsWhenDisabled(true)]
			ON_BUFF_FINISH,
			// Token: 0x0400E672 RID: 58994
			[Token(Token = "0x400E672")]
			[RunActionsWhenDisabled(false)]
			ON_BUFF_TRIGGER,
			// Token: 0x0400E673 RID: 58995
			[Token(Token = "0x400E673")]
			[RunActionsWhenDisabled(true)]
			ON_OWNER_KILLED,
			// Token: 0x0400E674 RID: 58996
			[Token(Token = "0x400E674")]
			[RunActionsWhenDisabled(true)]
			ON_OWNER_FINISH,
			// Token: 0x0400E675 RID: 58997
			[Token(Token = "0x400E675")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_APPLYING_MODIFIER,
			// Token: 0x0400E676 RID: 58998
			[Token(Token = "0x400E676")]
			[RunActionsWhenDisabled(false)]
			ON_APPLYING_MODIFIER,
			// Token: 0x0400E677 RID: 58999
			[Token(Token = "0x400E677")]
			[RunActionsWhenDisabled(false)]
			ON_APPLIED_MODIFIER,
			// Token: 0x0400E678 RID: 59000
			[Token(Token = "0x400E678")]
			[RunActionsWhenDisabled(false)]
			ON_OUTPUT_MODIFIER,
			// Token: 0x0400E679 RID: 59001
			[Token(Token = "0x400E679")]
			[RunActionsWhenDisabled(false)]
			ON_TARGET_KILLED,
			// Token: 0x0400E67A RID: 59002
			[Token(Token = "0x400E67A")]
			[RunActionsWhenDisabled(false)]
			ON_TAKE_DAMAGE,
			// Token: 0x0400E67B RID: 59003
			[Token(Token = "0x400E67B")]
			[RunActionsWhenDisabled(false)]
			ON_OUTPUT_DAMAGE,
			// Token: 0x0400E67C RID: 59004
			[Token(Token = "0x400E67C")]
			[RunActionsWhenDisabled(false)]
			ON_OWNER_BORN,
			// Token: 0x0400E67D RID: 59005
			[Token(Token = "0x400E67D")]
			[RunActionsWhenDisabled(false)]
			ON_OWNER_LOCATE,
			// Token: 0x0400E67E RID: 59006
			[Token(Token = "0x400E67E")]
			[RunActionsWhenDisabled(false)]
			ON_CALCULATE_DAMAGE,
			// Token: 0x0400E67F RID: 59007
			[Token(Token = "0x400E67F")]
			[RunActionsWhenDisabled(false)]
			ON_EVADE_DAMAGE,
			// Token: 0x0400E680 RID: 59008
			[Token(Token = "0x400E680")]
			[RunActionsWhenDisabled(false)]
			ON_ABILITY_START,
			// Token: 0x0400E681 RID: 59009
			[Token(Token = "0x400E681")]
			[RunActionsWhenDisabled(false)]
			ON_ABILITY_FINISH,
			// Token: 0x0400E682 RID: 59010
			[Token(Token = "0x400E682")]
			[RunActionsWhenDisabled(false)]
			ON_ABILITY_SPELL_ON,
			// Token: 0x0400E683 RID: 59011
			[Token(Token = "0x400E683")]
			[RunActionsWhenDisabled(false)]
			ON_ABILITY_CAST_ON_TARGET,
			// Token: 0x0400E684 RID: 59012
			[Token(Token = "0x400E684")]
			[RunActionsWhenDisabled(false)]
			ON_SKILL_FINISH,
			// Token: 0x0400E685 RID: 59013
			[Token(Token = "0x400E685")]
			[RunActionsWhenDisabled(false)]
			ON_AFTER_OUTPUT_DAMAGE,
			// Token: 0x0400E686 RID: 59014
			[Token(Token = "0x400E686")]
			[RunActionsWhenDisabled(false)]
			ON_OUTPUT_ATK_OR_HEAL,
			// Token: 0x0400E687 RID: 59015
			[Token(Token = "0x400E687")]
			[RunActionsWhenDisabled(false)]
			ON_AFTER_ATTACK,
			// Token: 0x0400E688 RID: 59016
			[Token(Token = "0x400E688")]
			[RunActionsWhenDisabled(true)]
			ON_BUFF_ENABLE,
			// Token: 0x0400E689 RID: 59017
			[Token(Token = "0x400E689")]
			[RunActionsWhenDisabled(true)]
			ON_BUFF_DISABLE,
			// Token: 0x0400E68A RID: 59018
			[Token(Token = "0x400E68A")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_ATTACK,
			// Token: 0x0400E68B RID: 59019
			[Token(Token = "0x400E68B")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_TRY_SET_HP_ZERO,
			// Token: 0x0400E68C RID: 59020
			[Token(Token = "0x400E68C")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_DISAPPEAR,
			// Token: 0x0400E68D RID: 59021
			[Token(Token = "0x400E68D")]
			[RunActionsWhenDisabled(true)]
			ON_OWNER_KILLED_BY_MAIN_TARGET,
			// Token: 0x0400E68E RID: 59022
			[Token(Token = "0x400E68E")]
			[RunActionsWhenDisabled(false)]
			ON_ABNORMAL_FLAG_DIRTY,
			// Token: 0x0400E68F RID: 59023
			[Token(Token = "0x400E68F")]
			[RunActionsWhenDisabled(false)]
			ON_AFTER_CALCULATE_DAMAGE,
			// Token: 0x0400E690 RID: 59024
			[Token(Token = "0x400E690")]
			[RunActionsWhenDisabled(false)]
			ON_BUFF_LATE_ENABLE,
			// Token: 0x0400E691 RID: 59025
			[Token(Token = "0x400E691")]
			[RunActionsWhenDisabled(false)]
			ON_SKILL_START,
			// Token: 0x0400E692 RID: 59026
			[Token(Token = "0x400E692")]
			[RunActionsWhenDisabled(true)]
			ON_OWNER_REACH_EXIT,
			// Token: 0x0400E693 RID: 59027
			[Token(Token = "0x400E693")]
			[RunActionsWhenDisabled(true)]
			ON_OWNER_POST_BORN,
			// Token: 0x0400E694 RID: 59028
			[Token(Token = "0x400E694")]
			[RunActionsWhenDisabled(false)]
			ON_OTHER_BUFF_START,
			// Token: 0x0400E695 RID: 59029
			[Token(Token = "0x400E695")]
			[RunActionsWhenDisabled(false)]
			ON_OWNER_BLOCKEE_CHANGED,
			// Token: 0x0400E696 RID: 59030
			[Token(Token = "0x400E696")]
			[RunActionsWhenDisabled(false)]
			ON_COLLIDE_WITH_HIGHLAND,
			// Token: 0x0400E697 RID: 59031
			[Token(Token = "0x400E697")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_EXIT_UNBALANCED_STATE,
			// Token: 0x0400E698 RID: 59032
			[Token(Token = "0x400E698")]
			[RunActionsWhenDisabled(false)]
			ON_CALCULATE_CACHED_PROJECTILE_DAMAGE,
			// Token: 0x0400E699 RID: 59033
			[Token(Token = "0x400E699")]
			[RunActionsWhenDisabled(false)]
			ON_APPLYING_SKIPPED_MODIFIER,
			// Token: 0x0400E69A RID: 59034
			[Token(Token = "0x400E69A")]
			[RunActionsWhenDisabled(false)]
			ON_ABILITY_INTERRUPTED,
			// Token: 0x0400E69B RID: 59035
			[Token(Token = "0x400E69B")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_APPEAR,
			// Token: 0x0400E69C RID: 59036
			[Token(Token = "0x400E69C")]
			[RunActionsWhenDisabled(false)]
			ON_OWNER_ROOT_TILE_CHANGED,
			// Token: 0x0400E69D RID: 59037
			[Token(Token = "0x400E69D")]
			[RunActionsWhenDisabled(false)]
			ON_OTHER_RESISTABLE_BUFF_START,
			// Token: 0x0400E69E RID: 59038
			[Token(Token = "0x400E69E")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_TRY_SET_EP_ZERO,
			// Token: 0x0400E69F RID: 59039
			[Token(Token = "0x400E69F")]
			[RunActionsWhenDisabled(false)]
			ON_ES_OVER_ZERO,
			// Token: 0x0400E6A0 RID: 59040
			[Token(Token = "0x400E6A0")]
			[RunActionsWhenDisabled(false)]
			ON_ENTER_MAGICCIRCUIT,
			// Token: 0x0400E6A1 RID: 59041
			[Token(Token = "0x400E6A1")]
			[RunActionsWhenDisabled(false)]
			ON_LEAVE_MAGICCIRCUIT,
			// Token: 0x0400E6A2 RID: 59042
			[Token(Token = "0x400E6A2")]
			[RunActionsWhenDisabled(true)]
			ON_OWNER_DYING,
			// Token: 0x0400E6A3 RID: 59043
			[Token(Token = "0x400E6A3")]
			[RunActionsWhenDisabled(true)]
			ON_GAME_OVER,
			// Token: 0x0400E6A4 RID: 59044
			[Token(Token = "0x400E6A4")]
			[RunActionsWhenDisabled(false)]
			ON_MAKE_ENEMY_UNBALANCED,
			// Token: 0x0400E6A5 RID: 59045
			[Token(Token = "0x400E6A5")]
			[RunActionsWhenDisabled(false)]
			ON_END_PULLING,
			// Token: 0x0400E6A6 RID: 59046
			[Token(Token = "0x400E6A6")]
			[RunActionsWhenDisabled(false)]
			ON_BLOCK_DAMAGE,
			// Token: 0x0400E6A7 RID: 59047
			[Token(Token = "0x400E6A7")]
			[RunActionsWhenDisabled(false)]
			ON_OWNER_OVERLAPPED,
			// Token: 0x0400E6A8 RID: 59048
			[Token(Token = "0x400E6A8")]
			[RunActionsWhenDisabled(false)]
			ON_BOSS_WAVE_WILL_START,
			// Token: 0x0400E6A9 RID: 59049
			[Token(Token = "0x400E6A9")]
			[RunActionsWhenDisabled(false)]
			ON_LEGION_MODE_DRAW_CARD,
			// Token: 0x0400E6AA RID: 59050
			[Token(Token = "0x400E6AA")]
			[RunActionsWhenDisabled(false)]
			ON_LEGION_MODE_REFRESH_CARD,
			// Token: 0x0400E6AB RID: 59051
			[Token(Token = "0x400E6AB")]
			[RunActionsWhenDisabled(false)]
			ON_MOTION_MODE_CHANGED,
			// Token: 0x0400E6AC RID: 59052
			[Token(Token = "0x400E6AC")]
			[RunActionsWhenDisabled(false)]
			ON_SANDBOX_OWNER_RES_CHANGED,
			// Token: 0x0400E6AD RID: 59053
			[Token(Token = "0x400E6AD")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_TARGET_APPLY_MODIFIER,
			// Token: 0x0400E6AE RID: 59054
			[Token(Token = "0x400E6AE")]
			[RunActionsWhenDisabled(false)]
			ON_ENTER_LEVITATE_STATE,
			// Token: 0x0400E6AF RID: 59055
			[Token(Token = "0x400E6AF")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_EXIT_LEVITATE_STATE,
			// Token: 0x0400E6B0 RID: 59056
			[Token(Token = "0x400E6B0")]
			[RunActionsWhenDisabled(false)]
			ON_ENTITY_WILL_OVERLAP,
			// Token: 0x0400E6B1 RID: 59057
			[Token(Token = "0x400E6B1")]
			[RunActionsWhenDisabled(false)]
			ON_SKILL_CAST_SUCCEED,
			// Token: 0x0400E6B2 RID: 59058
			[Token(Token = "0x400E6B2")]
			[RunActionsWhenDisabled(false)]
			ON_DIRECTION_CHANGED,
			// Token: 0x0400E6B3 RID: 59059
			[Token(Token = "0x400E6B3")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_DIRECTION_CHANGE,
			// Token: 0x0400E6B4 RID: 59060
			[Token(Token = "0x400E6B4")]
			[RunActionsWhenDisabled(false)]
			ON_TAKE_EP_DAMAGE,
			// Token: 0x0400E6B5 RID: 59061
			[Token(Token = "0x400E6B5")]
			[RunActionsWhenDisabled(false)]
			ON_EP_BREAK_START,
			// Token: 0x0400E6B6 RID: 59062
			[Token(Token = "0x400E6B6")]
			[RunActionsWhenDisabled(false)]
			ON_EP_BREAK_FINISH,
			// Token: 0x0400E6B7 RID: 59063
			[Token(Token = "0x400E6B7")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_FALLDOWN,
			// Token: 0x0400E6B8 RID: 59064
			[Token(Token = "0x400E6B8")]
			[RunActionsWhenDisabled(true)]
			ON_OWNER_BEFORE_DEAD,
			// Token: 0x0400E6B9 RID: 59065
			[Token(Token = "0x400E6B9")]
			[RunActionsWhenDisabled(false)]
			ON_BEING_CALCULATE_DAMAGE,
			// Token: 0x0400E6BA RID: 59066
			[Token(Token = "0x400E6BA")]
			[RunActionsWhenDisabled(false)]
			ON_STAGE_END,
			// Token: 0x0400E6BB RID: 59067
			[Token(Token = "0x400E6BB")]
			[RunActionsWhenDisabled(false)]
			ON_UNIT_SWITCH_MODE,
			// Token: 0x0400E6BC RID: 59068
			[Token(Token = "0x400E6BC")]
			[RunActionsWhenDisabled(false)]
			COOPERATE_PLAYER_DYING,
			// Token: 0x0400E6BD RID: 59069
			[Token(Token = "0x400E6BD")]
			[RunActionsWhenDisabled(false)]
			COOPERATE_PLAYER_REVIVE,
			// Token: 0x0400E6BE RID: 59070
			[Token(Token = "0x400E6BE")]
			[RunActionsWhenDisabled(false)]
			ON_ENTER_UNBALANCED_STATE,
			// Token: 0x0400E6BF RID: 59071
			[Token(Token = "0x400E6BF")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_EP_BREAK_FINISH,
			// Token: 0x0400E6C0 RID: 59072
			[Token(Token = "0x400E6C0")]
			[RunActionsWhenDisabled(false)]
			ON_TOGGLE_SKILL_START,
			// Token: 0x0400E6C1 RID: 59073
			[Token(Token = "0x400E6C1")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_EP_BREAK_START,
			// Token: 0x0400E6C2 RID: 59074
			[Token(Token = "0x400E6C2")]
			[RunActionsWhenDisabled(false)]
			ON_POST_TRY_SET_HP_ZERO,
			// Token: 0x0400E6C3 RID: 59075
			[Token(Token = "0x400E6C3")]
			[RunActionsWhenDisabled(false)]
			ON_AFTER_OUTPUT_ELEMENT_DAMAGE,
			// Token: 0x0400E6C4 RID: 59076
			[Token(Token = "0x400E6C4")]
			[RunActionsWhenDisabled(false)]
			ON_BEFORE_ABILITY_SPELL_ON,
			// Token: 0x0400E6C5 RID: 59077
			[Token(Token = "0x400E6C5")]
			[RunActionsWhenDisabled(false)]
			ON_AFTER_OUTPUT_HEAL,
			// Token: 0x0400E6C6 RID: 59078
			[Token(Token = "0x400E6C6")]
			[RunActionsWhenDisabled(false)]
			ON_LEGION_MODE_DANGER_LEVEL_REFRESH,
			// Token: 0x0400E6C7 RID: 59079
			[Token(Token = "0x400E6C7")]
			[RunActionsWhenDisabled(false)]
			ON_HALF_IDLE_TRAP_CHECK_UPGRADE,
			// Token: 0x0400E6C8 RID: 59080
			[Token(Token = "0x400E6C8")]
			[RunActionsWhenDisabled(false)]
			ON_HALF_IDLE_KAWA_CLEANED,
			// Token: 0x0400E6C9 RID: 59081
			[Token(Token = "0x400E6C9")]
			[RunActionsWhenDisabled(false)]
			ON_HALF_IDLE_KAWA_POLLUTED,
			// Token: 0x0400E6CA RID: 59082
			[Token(Token = "0x400E6CA")]
			[RunActionsWhenDisabled(false)]
			HALF_IDLE_GAIN_EQUIP,
			// Token: 0x0400E6CB RID: 59083
			[Token(Token = "0x400E6CB")]
			[RunActionsWhenDisabled(false)]
			HALF_IDLE_GAIN_TRAP,
			// Token: 0x0400E6CC RID: 59084
			[Token(Token = "0x400E6CC")]
			[RunActionsWhenDisabled(false)]
			ON_OUTPUT_ATK_OR_HEAL_EACH_SPELL,
			// Token: 0x0400E6CD RID: 59085
			[Token(Token = "0x400E6CD")]
			[RunActionsWhenDisabled(false)]
			ON_PALSY_OVERFLOW,
			// Token: 0x0400E6CE RID: 59086
			[Token(Token = "0x400E6CE")]
			[RunActionsWhenDisabled(false)]
			ON_TRIGGER_PALSY,
			// Token: 0x0400E6CF RID: 59087
			[Token(Token = "0x400E6CF")]
			[RunActionsWhenDisabled(false)]
			ON_SKILL_RETRIGGERED,
			// Token: 0x0400E6D0 RID: 59088
			[Token(Token = "0x400E6D0")]
			[RunActionsWhenDisabled(false)]
			ON_AUTO_CHESS_MODE_CHANGED,
			// Token: 0x0400E6D1 RID: 59089
			[Token(Token = "0x400E6D1")]
			[RunActionsWhenDisabled(false)]
			ON_OWNER_BLOCK_MODE_CHANGED,
			// Token: 0x0400E6D2 RID: 59090
			[Token(Token = "0x400E6D2")]
			[RunActionsWhenDisabled(false)]
			ON_OWNER_HP_FULL,
			// Token: 0x0400E6D3 RID: 59091
			[Token(Token = "0x400E6D3")]
			[RunActionsWhenDisabled(false)]
			ON_PROJECTILE_SELECT_TARGETS,
			// Token: 0x0400E6D4 RID: 59092
			[Token(Token = "0x400E6D4")]
			[RunActionsWhenDisabled(false)]
			ON_OWNER_REBORN,
			// Token: 0x0400E6D5 RID: 59093
			[Token(Token = "0x400E6D5")]
			E_NUM
		}
	}
}
