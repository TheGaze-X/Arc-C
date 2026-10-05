using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu
{
	// Token: 0x02001320 RID: 4896
	[Token(Token = "0x2001320")]
	[Serializable]
	public class SpData : IHotfixable
	{
		// Token: 0x06007299 RID: 29337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007299")]
		[Address(RVA = "0x2212B70", Offset = "0x2211770", VA = "0x182212B70")]
		public static SpData GetDefault()
		{
			return null;
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x0600729A RID: 29338 RVA: 0x00032EC8 File Offset: 0x000310C8
		[Token(Token = "0x17000E0B")]
		[JsonIgnore]
		public ObscuredInt maxSp
		{
			[Token(Token = "0x600729A")]
			[Address(RVA = "0x2213150", Offset = "0x2211D50", VA = "0x182213150")]
			get
			{
				return default(ObscuredInt);
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x0600729B RID: 29339 RVA: 0x00032EE0 File Offset: 0x000310E0
		[Token(Token = "0x17000E0C")]
		[JsonIgnore]
		public bool inited
		{
			[Token(Token = "0x600729B")]
			[Address(RVA = "0x22130D0", Offset = "0x2211CD0", VA = "0x1822130D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x0600729C RID: 29340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E0D")]
		[JsonIgnore]
		public float[] incrementsForAllSpTypes
		{
			[Token(Token = "0x600729C")]
			[Address(RVA = "0x2213060", Offset = "0x2211C60", VA = "0x182213060")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600729D")]
		[Address(RVA = "0x2212C20", Offset = "0x2211820", VA = "0x182212C20")]
		public void Init(Blackboard blackboard)
		{
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729E")]
		[Address(RVA = "0x22128E0", Offset = "0x22114E0", VA = "0x1822128E0")]
		public static SpData CreateFrom(LevelData.EnemyData.ESpData eSpData, Blackboard blackboard)
		{
			return null;
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600729F")]
		[Address(RVA = "0x2212A90", Offset = "0x2211690", VA = "0x182212A90")]
		public SpData Duplicate()
		{
			return null;
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A0")]
		[Address(RVA = "0x2212F20", Offset = "0x2211B20", VA = "0x182212F20")]
		public SpData()
		{
		}

		// Token: 0x04006C7B RID: 27771
		[Token(Token = "0x4006C7B")]
		[FieldOffset(Offset = "0x0")]
		[JsonIgnore]
		private static readonly SpData DEFAULT;

		// Token: 0x04006C7C RID: 27772
		[Token(Token = "0x4006C7C")]
		[FieldOffset(Offset = "0x10")]
		public SpType spType;

		// Token: 0x04006C7D RID: 27773
		[Token(Token = "0x4006C7D")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle[] levelUpCost;

		// Token: 0x04006C7E RID: 27774
		[Token(Token = "0x4006C7E")]
		[FieldOffset(Offset = "0x20")]
		public ObscuredInt maxChargeTime;

		// Token: 0x04006C7F RID: 27775
		[Token(Token = "0x4006C7F")]
		[FieldOffset(Offset = "0x34")]
		public ObscuredInt spCost;

		// Token: 0x04006C80 RID: 27776
		[Token(Token = "0x4006C80")]
		[FieldOffset(Offset = "0x48")]
		public ObscuredInt initSp;

		// Token: 0x04006C81 RID: 27777
		[Token(Token = "0x4006C81")]
		[FieldOffset(Offset = "0x5C")]
		public ObscuredFloat increment;

		// Token: 0x04006C82 RID: 27778
		[Token(Token = "0x4006C82")]
		[FieldOffset(Offset = "0x78")]
		[JsonIgnore]
		private float[] m_incrementsForAllSpTypes;

		// Token: 0x04006C83 RID: 27779
		[Token(Token = "0x4006C83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDefault;

		// Token: 0x04006C84 RID: 27780
		[Token(Token = "0x4006C84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxSp;

		// Token: 0x04006C85 RID: 27781
		[Token(Token = "0x4006C85")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_inited;

		// Token: 0x04006C86 RID: 27782
		[Token(Token = "0x4006C86")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_incrementsForAllSpTypes;

		// Token: 0x04006C87 RID: 27783
		[Token(Token = "0x4006C87")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04006C88 RID: 27784
		[Token(Token = "0x4006C88")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateFrom;

		// Token: 0x04006C89 RID: 27785
		[Token(Token = "0x4006C89")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Duplicate;

		// Token: 0x04006C8A RID: 27786
		[Token(Token = "0x4006C8A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
