using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu
{
	// Token: 0x02001322 RID: 4898
	[Token(Token = "0x2001322")]
	[Serializable]
	public class SkillData : ISkillData, IHotfixable
	{
		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x060072A4 RID: 29348 RVA: 0x00032EF8 File Offset: 0x000310F8
		[Token(Token = "0x17000E0E")]
		[JsonIgnore]
		public bool isValid
		{
			[Token(Token = "0x60072A4")]
			[Address(RVA = "0x2212020", Offset = "0x2210C20", VA = "0x182212020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x060072A5 RID: 29349 RVA: 0x00032F10 File Offset: 0x00031110
		[Token(Token = "0x17000E0F")]
		[JsonIgnore]
		public bool needToDisplay
		{
			[Token(Token = "0x60072A5")]
			[Address(RVA = "0x2212230", Offset = "0x2210E30", VA = "0x182212230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x060072A6 RID: 29350 RVA: 0x00032F28 File Offset: 0x00031128
		[Token(Token = "0x17000E10")]
		[JsonIgnore]
		public int spCost
		{
			[Token(Token = "0x60072A6")]
			[Address(RVA = "0x22122A0", Offset = "0x2210EA0", VA = "0x1822122A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x060072A7 RID: 29351 RVA: 0x00032F40 File Offset: 0x00031140
		[Token(Token = "0x17000E11")]
		[JsonIgnore]
		public int maxSp
		{
			[Token(Token = "0x60072A7")]
			[Address(RVA = "0x2212090", Offset = "0x2210C90", VA = "0x182212090")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A8")]
		[Address(RVA = "0x2211E40", Offset = "0x2210A40", VA = "0x182211E40")]
		public void InitIfNot()
		{
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A9")]
		[Address(RVA = "0x2211AB0", Offset = "0x22106B0", VA = "0x182211AB0")]
		public static SkillData CreateInvalid()
		{
			return null;
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AA")]
		[Address(RVA = "0x2211DE0", Offset = "0x22109E0", VA = "0x182211DE0", Slot = "4")]
		public string GetSkillId()
		{
			return null;
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AB")]
		[Address(RVA = "0x2211D80", Offset = "0x2210980", VA = "0x182211D80", Slot = "5")]
		public string GetIconId()
		{
			return null;
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AC")]
		[Address(RVA = "0x2211B30", Offset = "0x2210730", VA = "0x182211B30")]
		public SkillData Duplicate()
		{
			return null;
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072AD")]
		[Address(RVA = "0x2211F30", Offset = "0x2210B30", VA = "0x182211F30")]
		public SkillData()
		{
		}

		// Token: 0x04006C8B RID: 27787
		[Token(Token = "0x4006C8B")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04006C8C RID: 27788
		[Token(Token = "0x4006C8C")]
		[FieldOffset(Offset = "0x18")]
		public string skillId;

		// Token: 0x04006C8D RID: 27789
		[Token(Token = "0x4006C8D")]
		[FieldOffset(Offset = "0x20")]
		public string rangeId;

		// Token: 0x04006C8E RID: 27790
		[Token(Token = "0x4006C8E")]
		[FieldOffset(Offset = "0x28")]
		public string iconId;

		// Token: 0x04006C8F RID: 27791
		[Token(Token = "0x4006C8F")]
		[FieldOffset(Offset = "0x30")]
		public int level;

		// Token: 0x04006C90 RID: 27792
		[Token(Token = "0x4006C90")]
		[FieldOffset(Offset = "0x38")]
		public string description;

		// Token: 0x04006C91 RID: 27793
		[Token(Token = "0x4006C91")]
		[FieldOffset(Offset = "0x40")]
		public SkillType skillType;

		// Token: 0x04006C92 RID: 27794
		[Token(Token = "0x4006C92")]
		[FieldOffset(Offset = "0x44")]
		public SkillDurationType durationType;

		// Token: 0x04006C93 RID: 27795
		[Token(Token = "0x4006C93")]
		[FieldOffset(Offset = "0x48")]
		public SpData spData;

		// Token: 0x04006C94 RID: 27796
		[Token(Token = "0x4006C94")]
		[FieldOffset(Offset = "0x50")]
		public string prefabKey;

		// Token: 0x04006C95 RID: 27797
		[Token(Token = "0x4006C95")]
		[FieldOffset(Offset = "0x58")]
		public float duration;

		// Token: 0x04006C96 RID: 27798
		[Token(Token = "0x4006C96")]
		[FieldOffset(Offset = "0x60")]
		public Blackboard blackboard;

		// Token: 0x04006C97 RID: 27799
		[Token(Token = "0x4006C97")]
		[FieldOffset(Offset = "0x68")]
		[JsonIgnore]
		public bool isPrefabKeyOverridden;

		// Token: 0x04006C98 RID: 27800
		[Token(Token = "0x4006C98")]
		[FieldOffset(Offset = "0x69")]
		private bool m_inited;

		// Token: 0x04006C99 RID: 27801
		[Token(Token = "0x4006C99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x04006C9A RID: 27802
		[Token(Token = "0x4006C9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToDisplay;

		// Token: 0x04006C9B RID: 27803
		[Token(Token = "0x4006C9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_spCost;

		// Token: 0x04006C9C RID: 27804
		[Token(Token = "0x4006C9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_maxSp;

		// Token: 0x04006C9D RID: 27805
		[Token(Token = "0x4006C9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04006C9E RID: 27806
		[Token(Token = "0x4006C9E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateInvalid;

		// Token: 0x04006C9F RID: 27807
		[Token(Token = "0x4006C9F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetSkillId;

		// Token: 0x04006CA0 RID: 27808
		[Token(Token = "0x4006CA0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetIconId;

		// Token: 0x04006CA1 RID: 27809
		[Token(Token = "0x4006CA1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Duplicate;

		// Token: 0x04006CA2 RID: 27810
		[Token(Token = "0x4006CA2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
