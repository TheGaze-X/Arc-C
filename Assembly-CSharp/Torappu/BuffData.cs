using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000ED8 RID: 3800
	[Token(Token = "0x2000ED8")]
	[Serializable]
	public class BuffData : IHotfixable
	{
		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06006BEE RID: 27630 RVA: 0x000316B0 File Offset: 0x0002F8B0
		[Token(Token = "0x17000D06")]
		public bool isAutoPriority
		{
			[Token(Token = "0x6006BEE")]
			[Address(RVA = "0x20068B0", Offset = "0x20054B0", VA = "0x1820068B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BEF")]
		[Address(RVA = "0x2006480", Offset = "0x2005080", VA = "0x182006480")]
		public string GetOverrideKey()
		{
			return null;
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF0")]
		[Address(RVA = "0x2006520", Offset = "0x2005120", VA = "0x182006520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF1")]
		[Address(RVA = "0x20063F0", Offset = "0x2004FF0", VA = "0x1820063F0")]
		public BuffData EnsureBuffData()
		{
			return null;
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF2")]
		[Address(RVA = "0x2006050", Offset = "0x2004C50", VA = "0x182006050")]
		public BuffData DeepClone()
		{
			return null;
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF3")]
		[Address(RVA = "0x2006770", Offset = "0x2005370", VA = "0x182006770")]
		public BuffData()
		{
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF4")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x04005084 RID: 20612
		[Token(Token = "0x4005084")]
		[FieldOffset(Offset = "0x10")]
		public AttributeModifierData attributes;

		// Token: 0x04005085 RID: 20613
		[Token(Token = "0x4005085")]
		[FieldOffset(Offset = "0x18")]
		public string buffKey;

		// Token: 0x04005086 RID: 20614
		[Token(Token = "0x4005086")]
		[FieldOffset(Offset = "0x20")]
		public bool loadFromDB;

		// Token: 0x04005087 RID: 20615
		[Token(Token = "0x4005087")]
		[FieldOffset(Offset = "0x21")]
		public bool isDurableBuff;

		// Token: 0x04005088 RID: 20616
		[Token(Token = "0x4005088")]
		[FieldOffset(Offset = "0x22")]
		public bool isDamageMissable;

		// Token: 0x04005089 RID: 20617
		[Token(Token = "0x4005089")]
		[FieldOffset(Offset = "0x23")]
		public bool isSilenceable;

		// Token: 0x0400508A RID: 20618
		[Token(Token = "0x400508A")]
		[FieldOffset(Offset = "0x24")]
		public bool isStunnable;

		// Token: 0x0400508B RID: 20619
		[Token(Token = "0x400508B")]
		[FieldOffset(Offset = "0x25")]
		public bool isFreezable;

		// Token: 0x0400508C RID: 20620
		[Token(Token = "0x400508C")]
		[FieldOffset(Offset = "0x26")]
		public bool isLevitatable;

		// Token: 0x0400508D RID: 20621
		[Token(Token = "0x400508D")]
		[FieldOffset(Offset = "0x27")]
		public BuffData.StatusResistable statusResistable;

		// Token: 0x0400508E RID: 20622
		[Token(Token = "0x400508E")]
		[FieldOffset(Offset = "0x28")]
		public string templateKey;

		// Token: 0x0400508F RID: 20623
		[Token(Token = "0x400508F")]
		[FieldOffset(Offset = "0x30")]
		public bool disableOverride;

		// Token: 0x04005090 RID: 20624
		[Token(Token = "0x4005090")]
		[FieldOffset(Offset = "0x38")]
		public string overrideKey;

		// Token: 0x04005091 RID: 20625
		[Token(Token = "0x4005091")]
		[FieldOffset(Offset = "0x40")]
		public BuffData.OverrideType overrideType;

		// Token: 0x04005092 RID: 20626
		[Token(Token = "0x4005092")]
		[FieldOffset(Offset = "0x44")]
		public int maxStackCnt;

		// Token: 0x04005093 RID: 20627
		[Token(Token = "0x4005093")]
		[FieldOffset(Offset = "0x48")]
		public bool refreshRemainingTimeWhenStackMax;

		// Token: 0x04005094 RID: 20628
		[Token(Token = "0x4005094")]
		[FieldOffset(Offset = "0x49")]
		public bool clearAllStackCntWhenTimeUp;

		// Token: 0x04005095 RID: 20629
		[Token(Token = "0x4005095")]
		[FieldOffset(Offset = "0x4C")]
		public int maxValidStackCnt;

		// Token: 0x04005096 RID: 20630
		[Token(Token = "0x4005096")]
		[FieldOffset(Offset = "0x50")]
		public bool independentCharacterSource;

		// Token: 0x04005097 RID: 20631
		[Token(Token = "0x4005097")]
		[FieldOffset(Offset = "0x58")]
		public string overrideEffectKey;

		// Token: 0x04005098 RID: 20632
		[Token(Token = "0x4005098")]
		[FieldOffset(Offset = "0x60")]
		public bool overrideOnEventPriority;

		// Token: 0x04005099 RID: 20633
		[Token(Token = "0x4005099")]
		[FieldOffset(Offset = "0x64")]
		public BuffData.OnEventPriority onEventPriority;

		// Token: 0x0400509A RID: 20634
		[Token(Token = "0x400509A")]
		[FieldOffset(Offset = "0x68")]
		public string audioSignal;

		// Token: 0x0400509B RID: 20635
		[Token(Token = "0x400509B")]
		[FieldOffset(Offset = "0x70")]
		public LifeType lifeTimeType;

		// Token: 0x0400509C RID: 20636
		[Token(Token = "0x400509C")]
		[FieldOffset(Offset = "0x71")]
		public bool takeSnapshotWhenExtend;

		// Token: 0x0400509D RID: 20637
		[Token(Token = "0x400509D")]
		[FieldOffset(Offset = "0x78")]
		public string durationKey;

		// Token: 0x0400509E RID: 20638
		[Token(Token = "0x400509E")]
		[FieldOffset(Offset = "0x80")]
		public float lifeTime;

		// Token: 0x0400509F RID: 20639
		[Token(Token = "0x400509F")]
		[FieldOffset(Offset = "0x84")]
		public LifeType triggerLifeType;

		// Token: 0x040050A0 RID: 20640
		[Token(Token = "0x40050A0")]
		[FieldOffset(Offset = "0x88")]
		public int triggerCnt;

		// Token: 0x040050A1 RID: 20641
		[Token(Token = "0x40050A1")]
		[FieldOffset(Offset = "0x8C")]
		public float triggerInterval;

		// Token: 0x040050A2 RID: 20642
		[Token(Token = "0x40050A2")]
		[FieldOffset(Offset = "0x90")]
		public bool waitFirstTriggerInterval;

		// Token: 0x040050A3 RID: 20643
		[Token(Token = "0x40050A3")]
		[FieldOffset(Offset = "0x94")]
		public float firstTriggerInterval;

		// Token: 0x040050A4 RID: 20644
		[Token(Token = "0x40050A4")]
		[FieldOffset(Offset = "0x98")]
		public int priority;

		// Token: 0x040050A5 RID: 20645
		[Token(Token = "0x40050A5")]
		[FieldOffset(Offset = "0xA0")]
		public string[] priorityBBKeys;

		// Token: 0x040050A6 RID: 20646
		[Token(Token = "0x40050A6")]
		[FieldOffset(Offset = "0xA8")]
		public bool stripBlackboardParamsWithBuffKey;

		// Token: 0x040050A7 RID: 20647
		[Token(Token = "0x40050A7")]
		[FieldOffset(Offset = "0xB0")]
		public List<Blackboard.DataPair> blackboard;

		// Token: 0x040050A8 RID: 20648
		[Token(Token = "0x40050A8")]
		[FieldOffset(Offset = "0xB8")]
		public bool enableInitDirectionFromSource;

		// Token: 0x040050A9 RID: 20649
		[Token(Token = "0x40050A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isAutoPriority;

		// Token: 0x040050AA RID: 20650
		[Token(Token = "0x40050AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetOverrideKey;

		// Token: 0x040050AB RID: 20651
		[Token(Token = "0x40050AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToString;

		// Token: 0x040050AC RID: 20652
		[Token(Token = "0x40050AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EnsureBuffData;

		// Token: 0x040050AD RID: 20653
		[Token(Token = "0x40050AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DeepClone;

		// Token: 0x040050AE RID: 20654
		[Token(Token = "0x40050AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000ED9 RID: 3801
		[Token(Token = "0x2000ED9")]
		public enum OverrideType
		{
			// Token: 0x040050B0 RID: 20656
			[Token(Token = "0x40050B0")]
			DEFAULT,
			// Token: 0x040050B1 RID: 20657
			[Token(Token = "0x40050B1")]
			STACK,
			// Token: 0x040050B2 RID: 20658
			[Token(Token = "0x40050B2")]
			UNIQUE,
			// Token: 0x040050B3 RID: 20659
			[Token(Token = "0x40050B3")]
			EXTEND,
			// Token: 0x040050B4 RID: 20660
			[Token(Token = "0x40050B4")]
			EXTEND_TIME
		}

		// Token: 0x02000EDA RID: 3802
		[Token(Token = "0x2000EDA")]
		public enum StatusResistable : byte
		{
			// Token: 0x040050B6 RID: 20662
			[Token(Token = "0x40050B6")]
			NO,
			// Token: 0x040050B7 RID: 20663
			[Token(Token = "0x40050B7")]
			YES,
			// Token: 0x040050B8 RID: 20664
			[Token(Token = "0x40050B8")]
			AUTOMATIC
		}

		// Token: 0x02000EDB RID: 3803
		[Token(Token = "0x2000EDB")]
		public enum OnEventPriority
		{
			// Token: 0x040050BA RID: 20666
			[Token(Token = "0x40050BA")]
			HIGHER_PRIORITY = 2000,
			// Token: 0x040050BB RID: 20667
			[Token(Token = "0x40050BB")]
			HIGH_PRIORITY = 1000,
			// Token: 0x040050BC RID: 20668
			[Token(Token = "0x40050BC")]
			DEFAULT = 0,
			// Token: 0x040050BD RID: 20669
			[Token(Token = "0x40050BD")]
			LOW_PRIORITY = -1000,
			// Token: 0x040050BE RID: 20670
			[Token(Token = "0x40050BE")]
			LOWER_PRIORITY = -2000,
			// Token: 0x040050BF RID: 20671
			[Token(Token = "0x40050BF")]
			LOWEST_PRIORITY = -3000,
			// Token: 0x040050C0 RID: 20672
			[Token(Token = "0x40050C0")]
			TITI_DOZE_PRIORITY = -4000
		}
	}
}
