using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020013A7 RID: 5031
	[Token(Token = "0x20013A7")]
	[Serializable]
	public class TalentData : IHotfixable
	{
		// Token: 0x0600738A RID: 29578 RVA: 0x00033600 File Offset: 0x00031800
		[Token(Token = "0x600738A")]
		[Address(RVA = "0x2215B00", Offset = "0x2214700", VA = "0x182215B00")]
		public bool ShouldSerializetokenKey()
		{
			return default(bool);
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x0600738B RID: 29579 RVA: 0x00033618 File Offset: 0x00031818
		[Token(Token = "0x17000E21")]
		public virtual bool displayRange
		{
			[Token(Token = "0x600738B")]
			[Address(RVA = "0x2205D70", Offset = "0x2204970", VA = "0x182205D70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600738C")]
		[Address(RVA = "0x2205D10", Offset = "0x2204910", VA = "0x182205D10", Slot = "5")]
		public virtual string GetDescription()
		{
			return null;
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600738D")]
		[Address(RVA = "0x2215980", Offset = "0x2214580", VA = "0x182215980")]
		public TalentData Duplicate()
		{
			return null;
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600738E")]
		[Address(RVA = "0x2215B70", Offset = "0x2214770", VA = "0x182215B70")]
		public TalentData()
		{
		}

		// Token: 0x04006FD1 RID: 28625
		[Token(Token = "0x4006FD1")]
		[FieldOffset(Offset = "0x10")]
		public CharacterData.UnlockCondition unlockCondition;

		// Token: 0x04006FD2 RID: 28626
		[Token(Token = "0x4006FD2")]
		[FieldOffset(Offset = "0x18")]
		public int requiredPotentialRank;

		// Token: 0x04006FD3 RID: 28627
		[Token(Token = "0x4006FD3")]
		[FieldOffset(Offset = "0x20")]
		public string prefabKey;

		// Token: 0x04006FD4 RID: 28628
		[Token(Token = "0x4006FD4")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04006FD5 RID: 28629
		[Token(Token = "0x4006FD5")]
		[FieldOffset(Offset = "0x30")]
		public string description;

		// Token: 0x04006FD6 RID: 28630
		[Token(Token = "0x4006FD6")]
		[FieldOffset(Offset = "0x38")]
		public string rangeId;

		// Token: 0x04006FD7 RID: 28631
		[Token(Token = "0x4006FD7")]
		[FieldOffset(Offset = "0x40")]
		public Blackboard blackboard;

		// Token: 0x04006FD8 RID: 28632
		[Token(Token = "0x4006FD8")]
		[FieldOffset(Offset = "0x48")]
		public string tokenKey;

		// Token: 0x04006FD9 RID: 28633
		[Token(Token = "0x4006FD9")]
		[FieldOffset(Offset = "0x50")]
		public bool isHideTalent;

		// Token: 0x04006FDA RID: 28634
		[Token(Token = "0x4006FDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShouldSerializetokenKey;

		// Token: 0x04006FDB RID: 28635
		[Token(Token = "0x4006FDB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_displayRange;

		// Token: 0x04006FDC RID: 28636
		[Token(Token = "0x4006FDC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDescription;

		// Token: 0x04006FDD RID: 28637
		[Token(Token = "0x4006FDD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Duplicate;

		// Token: 0x04006FDE RID: 28638
		[Token(Token = "0x4006FDE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
