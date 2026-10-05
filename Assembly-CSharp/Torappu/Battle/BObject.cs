using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200219B RID: 8603
	[Token(Token = "0x200219B")]
	public class BObject : VisualObject, IReusableObject, IReusable, IPtrObject, IComparable<BObject>, IComparable, RandomExtensions.IPRDRandomEntity
	{
		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x0600D502 RID: 54530 RVA: 0x0004D028 File Offset: 0x0004B228
		// (set) Token: 0x0600D503 RID: 54531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019CE")]
		public uint instanceUid
		{
			[Token(Token = "0x600D502")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600D503")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x0600D504 RID: 54532 RVA: 0x0004D040 File Offset: 0x0004B240
		// (set) Token: 0x0600D505 RID: 54533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019CF")]
		public SideType side
		{
			[Token(Token = "0x600D504")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return SideType.NONE;
			}
			[Token(Token = "0x600D505")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x0600D506 RID: 54534 RVA: 0x0004D058 File Offset: 0x0004B258
		// (set) Token: 0x0600D507 RID: 54535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019D0")]
		public PlayerSide playerSide
		{
			[Token(Token = "0x600D506")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return PlayerSide.DEFAULT;
			}
			[Token(Token = "0x600D507")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x0600D508 RID: 54536 RVA: 0x0004D070 File Offset: 0x0004B270
		// (set) Token: 0x0600D509 RID: 54537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019D1")]
		public bool inited
		{
			[Token(Token = "0x600D508")]
			[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D509")]
			[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x0600D50A RID: 54538 RVA: 0x0004D088 File Offset: 0x0004B288
		// (set) Token: 0x0600D50B RID: 54539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019D2")]
		public bool borned
		{
			[Token(Token = "0x600D50A")]
			[Address(RVA = "0x4EA870", Offset = "0x4E9470", VA = "0x1804EA870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D50B")]
			[Address(RVA = "0x4EAC00", Offset = "0x4E9800", VA = "0x1804EAC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x0600D50C RID: 54540 RVA: 0x0004D0A0 File Offset: 0x0004B2A0
		[Token(Token = "0x170019D3")]
		public bool isValid
		{
			[Token(Token = "0x600D50C")]
			[Address(RVA = "0x21109C0", Offset = "0x210F5C0", VA = "0x1821109C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x0600D50D RID: 54541 RVA: 0x0004D0B8 File Offset: 0x0004B2B8
		[Token(Token = "0x170019D4")]
		public bool validAndBorned
		{
			[Token(Token = "0x600D50D")]
			[Address(RVA = "0x3581DC0", Offset = "0x35809C0", VA = "0x183581DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x0600D50E RID: 54542 RVA: 0x0004D0D0 File Offset: 0x0004B2D0
		// (set) Token: 0x0600D50F RID: 54543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019D5")]
		public bool isDisappeared
		{
			[Token(Token = "0x600D50E")]
			[Address(RVA = "0x3581DB0", Offset = "0x35809B0", VA = "0x183581DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D50F")]
			[Address(RVA = "0x3581DE0", Offset = "0x35809E0", VA = "0x183581DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x0600D510 RID: 54544 RVA: 0x0004D0E8 File Offset: 0x0004B2E8
		[Token(Token = "0x170019D6")]
		public virtual int priority
		{
			[Token(Token = "0x600D510")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "23")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600D511 RID: 54545 RVA: 0x0004D100 File Offset: 0x0004B300
		[Token(Token = "0x600D511")]
		[Address(RVA = "0x3581140", Offset = "0x357FD40", VA = "0x183581140", Slot = "17")]
		public int CompareTo(BObject another)
		{
			return 0;
		}

		// Token: 0x0600D512 RID: 54546 RVA: 0x0004D118 File Offset: 0x0004B318
		[Token(Token = "0x600D512")]
		[Address(RVA = "0x35812B0", Offset = "0x357FEB0", VA = "0x1835812B0", Slot = "18")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0600D513 RID: 54547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D513")]
		[Address(RVA = "0x3581D20", Offset = "0x3580920", VA = "0x183581D20")]
		protected BObject()
		{
		}

		// Token: 0x0600D514 RID: 54548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D514")]
		[Address(RVA = "0x3581100", Offset = "0x357FD00", VA = "0x183581100", Slot = "24")]
		public virtual void Born()
		{
		}

		// Token: 0x0600D515 RID: 54549 RVA: 0x0004D130 File Offset: 0x0004B330
		[Token(Token = "0x600D515")]
		[Address(RVA = "0x3581970", Offset = "0x3580570", VA = "0x183581970")]
		public bool SetDisappeared(bool value)
		{
			return default(bool);
		}

		// Token: 0x0600D516 RID: 54550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D516")]
		[Address(RVA = "0x35817A0", Offset = "0x35803A0", VA = "0x1835817A0")]
		protected void PreInit(SideType sideType, PlayerSide playerSide)
		{
		}

		// Token: 0x0600D517 RID: 54551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D517")]
		[Address(RVA = "0x35815E0", Offset = "0x35801E0", VA = "0x1835815E0")]
		protected void Init(SideType side, PlayerSide playerSide, Vector2 pos, float height)
		{
		}

		// Token: 0x0600D518 RID: 54552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D518")]
		[Address(RVA = "0x3581A00", Offset = "0x3580600", VA = "0x183581A00")]
		protected void UpdateSideAndLayer(SideType side)
		{
		}

		// Token: 0x0600D519 RID: 54553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D519")]
		[Address(RVA = "0x3581920", Offset = "0x3580520", VA = "0x183581920")]
		protected void Reset()
		{
		}

		// Token: 0x0600D51A RID: 54554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D51A")]
		[Address(RVA = "0x3581540", Offset = "0x3580140", VA = "0x183581540")]
		protected void DestroyMe()
		{
		}

		// Token: 0x0600D51B RID: 54555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D51B")]
		[Address(RVA = "0x3581490", Offset = "0x3580090", VA = "0x183581490")]
		protected void DestroyMe(float delay)
		{
		}

		// Token: 0x0600D51C RID: 54556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D51C")]
		[Address(RVA = "0x3581660", Offset = "0x3580260", VA = "0x183581660", Slot = "25")]
		public virtual void OnAllocate()
		{
		}

		// Token: 0x0600D51D RID: 54557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D51D")]
		[Address(RVA = "0x3581740", Offset = "0x3580340", VA = "0x183581740", Slot = "26")]
		public virtual void OnRecycle()
		{
		}

		// Token: 0x0600D51E RID: 54558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D51E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "27")]
		public virtual void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600D51F RID: 54559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D51F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "28")]
		public virtual void OnLateTick(FP deltaTime)
		{
		}

		// Token: 0x0600D520 RID: 54560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D520")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		protected virtual void OnReset()
		{
		}

		// Token: 0x0600D521 RID: 54561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D521")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "30")]
		protected virtual void OnInit(float initHeight)
		{
		}

		// Token: 0x0600D522 RID: 54562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D522")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
		protected virtual void OnPostInit()
		{
		}

		// Token: 0x0600D523 RID: 54563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D523")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "32")]
		protected virtual void OnBorn()
		{
		}

		// Token: 0x0600D524 RID: 54564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D524")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "33")]
		protected virtual void OnBeforeDisappearChanged(bool newValue)
		{
		}

		// Token: 0x0600D525 RID: 54565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D525")]
		[Address(RVA = "0x3581710", Offset = "0x3580310", VA = "0x183581710", Slot = "34")]
		protected virtual void OnDisappearChanged(bool newValue)
		{
		}

		// Token: 0x0600D526 RID: 54566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D526")]
		[Address(RVA = "0x3581B20", Offset = "0x3580720", VA = "0x183581B20", Slot = "13")]
		protected override void _AssignLocalPosInternal(Vector3 localPos)
		{
		}

		// Token: 0x0600D527 RID: 54567 RVA: 0x0004D148 File Offset: 0x0004B348
		[Token(Token = "0x600D527")]
		[Address(RVA = "0x3581590", Offset = "0x3580190", VA = "0x183581590", Slot = "19")]
		public RandomExtensions.PRDEntityHash GetPRDEntityHash(RandomExtensions.PRDRandomCategory category)
		{
			return default(RandomExtensions.PRDEntityHash);
		}

		// Token: 0x0600D528 RID: 54568 RVA: 0x0004D160 File Offset: 0x0004B360
		[Token(Token = "0x600D528")]
		[Address(RVA = "0x35810A0", Offset = "0x357FCA0", VA = "0x1835810A0", Slot = "20")]
		public int AllocatePRDEntitySubHash(RandomExtensions.PRDRandomCategory category, RandomExtensions.IPRDRandomEntity child)
		{
			return 0;
		}

		// Token: 0x0600D529 RID: 54569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D529")]
		[Address(RVA = "0x35817B0", Offset = "0x35803B0", VA = "0x1835817B0", Slot = "21")]
		public void ResetPRDEntity()
		{
		}

		// Token: 0x0400E4AA RID: 58538
		[Token(Token = "0x400E4AA")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_globalCounter;

		// Token: 0x0400E4B1 RID: 58545
		[Token(Token = "0x400E4B1")]
		[FieldOffset(Offset = "0x28")]
		private int m_prdCounter;

		// Token: 0x0400E4B2 RID: 58546
		[Token(Token = "0x400E4B2")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<RandomExtensions.IPRDRandomEntity> m_prdSubEntities;
	}
}
