using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075C5 RID: 30149
	[Token(Token = "0x20075C5")]
	public struct Act24sideMeldingProgressChangeInfo : IHotfixable
	{
		// Token: 0x0602A745 RID: 173893 RVA: 0x000D8A08 File Offset: 0x000D6C08
		[Token(Token = "0x602A745")]
		[Address(RVA = "0x26229B0", Offset = "0x26215B0", VA = "0x1826229B0")]
		public static Act24sideMeldingProgressChangeInfo Create(int fromPrice, int toPrice, int segmentPrice, int curSegmentIndex, int maxSegmentCount)
		{
			return default(Act24sideMeldingProgressChangeInfo);
		}

		// Token: 0x0602A746 RID: 173894 RVA: 0x000D8A20 File Offset: 0x000D6C20
		[Token(Token = "0x602A746")]
		[Address(RVA = "0x2622770", Offset = "0x2621370", VA = "0x182622770")]
		public static Act24sideMeldingProgressChangeInfo CreateAddFullSegment(int fromPrice, int segmentPrice, int curSegmentIndex, int maxSegmentCount)
		{
			return default(Act24sideMeldingProgressChangeInfo);
		}

		// Token: 0x0602A747 RID: 173895 RVA: 0x000D8A38 File Offset: 0x000D6C38
		[Token(Token = "0x602A747")]
		[Address(RVA = "0x2622890", Offset = "0x2621490", VA = "0x182622890")]
		public static Act24sideMeldingProgressChangeInfo CreateMinusFullSegment(int fromPrice, int segmentPrice, int curSegmentIndex, int maxSegmentCount)
		{
			return default(Act24sideMeldingProgressChangeInfo);
		}

		// Token: 0x0602A748 RID: 173896 RVA: 0x000D8A50 File Offset: 0x000D6C50
		[Token(Token = "0x602A748")]
		[Address(RVA = "0x2622D70", Offset = "0x2621970", VA = "0x182622D70")]
		private static float _GetValueBetweenZoneAndOne(float v)
		{
			return 0f;
		}

		// Token: 0x0403D16F RID: 250223
		[Token(Token = "0x403D16F")]
		[FieldOffset(Offset = "0x0")]
		public int segmentPrice;

		// Token: 0x0403D170 RID: 250224
		[Token(Token = "0x403D170")]
		[FieldOffset(Offset = "0x4")]
		public int fromPrice;

		// Token: 0x0403D171 RID: 250225
		[Token(Token = "0x403D171")]
		[FieldOffset(Offset = "0x8")]
		public int toPrice;

		// Token: 0x0403D172 RID: 250226
		[Token(Token = "0x403D172")]
		[FieldOffset(Offset = "0xC")]
		public int changePrice;

		// Token: 0x0403D173 RID: 250227
		[Token(Token = "0x403D173")]
		[FieldOffset(Offset = "0x10")]
		public Act24sideMeldingProgressChangeInfo.PRICE_CHANGE_TYPE priceChangeType;

		// Token: 0x0403D174 RID: 250228
		[Token(Token = "0x403D174")]
		[FieldOffset(Offset = "0x14")]
		public float fromSliderPercent;

		// Token: 0x0403D175 RID: 250229
		[Token(Token = "0x403D175")]
		[FieldOffset(Offset = "0x18")]
		public float toSliderPercent;

		// Token: 0x0403D176 RID: 250230
		[Token(Token = "0x403D176")]
		[FieldOffset(Offset = "0x1C")]
		public float changeSliderPercent;

		// Token: 0x0403D177 RID: 250231
		[Token(Token = "0x403D177")]
		[FieldOffset(Offset = "0x20")]
		public int relatedSlotIndex;

		// Token: 0x0403D178 RID: 250232
		[Token(Token = "0x403D178")]
		[FieldOffset(Offset = "0x24")]
		public float relatedSlotPercent;

		// Token: 0x0403D179 RID: 250233
		[Token(Token = "0x403D179")]
		[FieldOffset(Offset = "0x28")]
		public Act24sideMeldingProgressChangeInfo.SLOT_LIGHT_CHANGE_TYPE slotLightChangeType;

		// Token: 0x0403D17A RID: 250234
		[Token(Token = "0x403D17A")]
		[FieldOffset(Offset = "0x0")]
		public static Act24sideMeldingProgressChangeInfo EMPTY;

		// Token: 0x0403D17B RID: 250235
		[Token(Token = "0x403D17B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0403D17C RID: 250236
		[Token(Token = "0x403D17C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateAddFullSegment;

		// Token: 0x0403D17D RID: 250237
		[Token(Token = "0x403D17D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CreateMinusFullSegment;

		// Token: 0x0403D17E RID: 250238
		[Token(Token = "0x403D17E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetValueBetweenZoneAndOne;

		// Token: 0x020075C6 RID: 30150
		[Token(Token = "0x20075C6")]
		public enum PRICE_CHANGE_TYPE
		{
			// Token: 0x0403D180 RID: 250240
			[Token(Token = "0x403D180")]
			NONE,
			// Token: 0x0403D181 RID: 250241
			[Token(Token = "0x403D181")]
			ADD,
			// Token: 0x0403D182 RID: 250242
			[Token(Token = "0x403D182")]
			MINUS
		}

		// Token: 0x020075C7 RID: 30151
		[Token(Token = "0x20075C7")]
		public enum SLOT_LIGHT_CHANGE_TYPE
		{
			// Token: 0x0403D184 RID: 250244
			[Token(Token = "0x403D184")]
			NONE,
			// Token: 0x0403D185 RID: 250245
			[Token(Token = "0x403D185")]
			LIGHT_ON,
			// Token: 0x0403D186 RID: 250246
			[Token(Token = "0x403D186")]
			LIGHT_OFF
		}
	}
}
