using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002789 RID: 10121
	[Token(Token = "0x2002789")]
	public struct AutoChessBattleShopSlot : IEquatable<AutoChessBattleShopSlot>
	{
		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x06010837 RID: 67639 RVA: 0x00064B18 File Offset: 0x00062D18
		// (set) Token: 0x06010838 RID: 67640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700241B")]
		public int slotNum
		{
			[Token(Token = "0x6010837")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6010838")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06010839 RID: 67641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010839")]
		[Address(RVA = "0x849120", Offset = "0x847D20", VA = "0x180849120")]
		public AutoChessBattleShopSlot(int id)
		{
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x0601083A RID: 67642 RVA: 0x00064B30 File Offset: 0x00062D30
		[Token(Token = "0x1700241C")]
		public bool isGoods
		{
			[Token(Token = "0x601083A")]
			[Address(RVA = "0x849170", Offset = "0x847D70", VA = "0x180849170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x0601083B RID: 67643 RVA: 0x00064B48 File Offset: 0x00062D48
		[Token(Token = "0x1700241D")]
		public bool isUpgrade
		{
			[Token(Token = "0x601083B")]
			[Address(RVA = "0x8491C0", Offset = "0x847DC0", VA = "0x1808491C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601083C RID: 67644 RVA: 0x00064B60 File Offset: 0x00062D60
		[Token(Token = "0x601083C")]
		[Address(RVA = "0x8492C0", Offset = "0x847EC0", VA = "0x1808492C0")]
		public static implicit operator AutoChessBattleShopSlot(int v)
		{
			return default(AutoChessBattleShopSlot);
		}

		// Token: 0x0601083D RID: 67645 RVA: 0x00064B78 File Offset: 0x00062D78
		[Token(Token = "0x601083D")]
		[Address(RVA = "0x849310", Offset = "0x847F10", VA = "0x180849310")]
		public static implicit operator int(AutoChessBattleShopSlot id)
		{
			return 0;
		}

		// Token: 0x0601083E RID: 67646 RVA: 0x00064B90 File Offset: 0x00062D90
		[Token(Token = "0x601083E")]
		[Address(RVA = "0x848EB0", Offset = "0x847AB0", VA = "0x180848EB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0601083F RID: 67647 RVA: 0x00064BA8 File Offset: 0x00062DA8
		[Token(Token = "0x601083F")]
		[Address(RVA = "0x848FA0", Offset = "0x847BA0", VA = "0x180848FA0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06010840 RID: 67648 RVA: 0x00064BC0 File Offset: 0x00062DC0
		[Token(Token = "0x6010840")]
		[Address(RVA = "0x849270", Offset = "0x847E70", VA = "0x180849270")]
		public static bool operator ==(AutoChessBattleShopSlot lh, AutoChessBattleShopSlot rh)
		{
			return default(bool);
		}

		// Token: 0x06010841 RID: 67649 RVA: 0x00064BD8 File Offset: 0x00062DD8
		[Token(Token = "0x6010841")]
		[Address(RVA = "0x849360", Offset = "0x847F60", VA = "0x180849360")]
		public static bool operator !=(AutoChessBattleShopSlot lh, AutoChessBattleShopSlot rh)
		{
			return default(bool);
		}

		// Token: 0x06010842 RID: 67650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010842")]
		[Address(RVA = "0x849000", Offset = "0x847C00", VA = "0x180849000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06010843 RID: 67651 RVA: 0x00064BF0 File Offset: 0x00062DF0
		[Token(Token = "0x6010843")]
		[Address(RVA = "0x848F50", Offset = "0x847B50", VA = "0x180848F50", Slot = "4")]
		public bool Equals(AutoChessBattleShopSlot other)
		{
			return default(bool);
		}

		// Token: 0x04012874 RID: 75892
		[Token(Token = "0x4012874")]
		private const int GOODS_SLOTS_MIN_NUM = 0;

		// Token: 0x04012875 RID: 75893
		[Token(Token = "0x4012875")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AutoChessBattleShopSlot NONE;

		// Token: 0x04012876 RID: 75894
		[Token(Token = "0x4012876")]
		[FieldOffset(Offset = "0x4")]
		public static readonly AutoChessBattleShopSlot UPGRADE;
	}
}
