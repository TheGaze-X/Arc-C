using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000603 RID: 1539
	[Token(Token = "0x2000603")]
	[Serializable]
	public struct GridPosition : IComparable<GridPosition>, IEquatable<GridPosition>
	{
		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600620B RID: 25099 RVA: 0x0002FFE8 File Offset: 0x0002E1E8
		[Token(Token = "0x17000CCE")]
		[JsonIgnore]
		public int manhattan
		{
			[Token(Token = "0x600620B")]
			[Address(RVA = "0x1DED3C0", Offset = "0x1DEBFC0", VA = "0x181DED3C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600620C RID: 25100 RVA: 0x00030000 File Offset: 0x0002E200
		[Token(Token = "0x17000CCF")]
		[JsonIgnore]
		public float magnitude
		{
			[Token(Token = "0x600620C")]
			[Address(RVA = "0x1DED390", Offset = "0x1DEBF90", VA = "0x181DED390")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x00030018 File Offset: 0x0002E218
		[Token(Token = "0x17000CD0")]
		[JsonIgnore]
		public int sqrMagnitude
		{
			[Token(Token = "0x600620D")]
			[Address(RVA = "0x1DED420", Offset = "0x1DEC020", VA = "0x181DED420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x0600620E RID: 25102 RVA: 0x00030030 File Offset: 0x0002E230
		[Token(Token = "0x17000CD1")]
		[JsonIgnore]
		public Vector2 asLocalPosition
		{
			[Token(Token = "0x600620E")]
			[Address(RVA = "0x1DED370", Offset = "0x1DEBF70", VA = "0x181DED370")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600620F")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public GridPosition(int row, int col)
		{
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006210")]
		[Address(RVA = "0x1DECEE0", Offset = "0x1DEBAE0", VA = "0x181DECEE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006211 RID: 25105 RVA: 0x00030048 File Offset: 0x0002E248
		[Token(Token = "0x6006211")]
		[Address(RVA = "0x1DECBA0", Offset = "0x1DEB7A0", VA = "0x181DECBA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06006212 RID: 25106 RVA: 0x00030060 File Offset: 0x0002E260
		[Token(Token = "0x6006212")]
		[Address(RVA = "0x1DECAE0", Offset = "0x1DEB6E0", VA = "0x181DECAE0", Slot = "4")]
		public int CompareTo(GridPosition other)
		{
			return 0;
		}

		// Token: 0x06006213 RID: 25107 RVA: 0x00030078 File Offset: 0x0002E278
		[Token(Token = "0x6006213")]
		[Address(RVA = "0x1DECCB0", Offset = "0x1DEB8B0", VA = "0x181DECCB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006214 RID: 25108 RVA: 0x00030090 File Offset: 0x0002E290
		[Token(Token = "0x6006214")]
		[Address(RVA = "0x1DECB50", Offset = "0x1DEB750", VA = "0x181DECB50")]
		public static int Encode(GridPosition position)
		{
			return 0;
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x000300A8 File Offset: 0x0002E2A8
		[Token(Token = "0x6006215")]
		[Address(RVA = "0x1DECB10", Offset = "0x1DEB710", VA = "0x181DECB10")]
		public static GridPosition Decode(int hashCode)
		{
			return default(GridPosition);
		}

		// Token: 0x06006216 RID: 25110 RVA: 0x000300C0 File Offset: 0x0002E2C0
		[Token(Token = "0x6006216")]
		[Address(RVA = "0x1DECC70", Offset = "0x1DEB870", VA = "0x181DECC70")]
		public static GridPosition FromVectorPosition(Vector2 vec)
		{
			return default(GridPosition);
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x000300D8 File Offset: 0x0002E2D8
		[Token(Token = "0x6006217")]
		[Address(RVA = "0x1DED5B0", Offset = "0x1DEC1B0", VA = "0x181DED5B0")]
		public static GridPosition operator -(GridPosition pos)
		{
			return default(GridPosition);
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x000300F0 File Offset: 0x0002E2F0
		[Token(Token = "0x6006218")]
		[Address(RVA = "0x1DED430", Offset = "0x1DEC030", VA = "0x181DED430")]
		public static GridPosition operator +(GridPosition lhs, GridPosition rhs)
		{
			return default(GridPosition);
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x00030108 File Offset: 0x0002E308
		[Token(Token = "0x6006219")]
		[Address(RVA = "0x1DED590", Offset = "0x1DEC190", VA = "0x181DED590")]
		public static GridPosition operator -(GridPosition lhs, GridPosition rhs)
		{
			return default(GridPosition);
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x00030120 File Offset: 0x0002E320
		[Token(Token = "0x600621A")]
		[Address(RVA = "0x1DED450", Offset = "0x1DEC050", VA = "0x181DED450")]
		public static bool operator ==(GridPosition lhs, GridPosition rhs)
		{
			return default(bool);
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x00030138 File Offset: 0x0002E338
		[Token(Token = "0x600621B")]
		[Address(RVA = "0x1DED470", Offset = "0x1DEC070", VA = "0x181DED470")]
		public static bool operator !=(GridPosition lhs, GridPosition rhs)
		{
			return default(bool);
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x00030150 File Offset: 0x0002E350
		[Token(Token = "0x600621C")]
		[Address(RVA = "0x1DED540", Offset = "0x1DEC140", VA = "0x181DED540")]
		public static Vector2 operator *(GridPosition lhs, Vector2 rhs)
		{
			return default(Vector2);
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x00030168 File Offset: 0x0002E368
		[Token(Token = "0x600621D")]
		[Address(RVA = "0x1DED4F0", Offset = "0x1DEC0F0", VA = "0x181DED4F0")]
		public static Vector2 operator *(Vector2 lhs, GridPosition rhs)
		{
			return default(Vector2);
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x00030180 File Offset: 0x0002E380
		[Token(Token = "0x600621E")]
		[Address(RVA = "0x1DED520", Offset = "0x1DEC120", VA = "0x181DED520")]
		public static GridPosition operator *(GridPosition lhs, int rhs)
		{
			return default(GridPosition);
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x00030198 File Offset: 0x0002E398
		[Token(Token = "0x600621F")]
		[Address(RVA = "0x1DED570", Offset = "0x1DEC170", VA = "0x181DED570")]
		public static GridPosition operator *(int lhs, GridPosition rhs)
		{
			return default(GridPosition);
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x000301B0 File Offset: 0x0002E3B0
		[Token(Token = "0x6006220")]
		[Address(RVA = "0x1DECAF0", Offset = "0x1DEB6F0", VA = "0x181DECAF0")]
		public static int Cross(GridPosition lhs, GridPosition rhs)
		{
			return 0;
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x000301C8 File Offset: 0x0002E3C8
		[Token(Token = "0x6006221")]
		[Address(RVA = "0x1DECB30", Offset = "0x1DEB730", VA = "0x181DECB30")]
		public static int Dot(GridPosition lhs, GridPosition rhs)
		{
			return 0;
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x000301E0 File Offset: 0x0002E3E0
		[Token(Token = "0x6006222")]
		[Address(RVA = "0x1DECD50", Offset = "0x1DEB950", VA = "0x181DECD50")]
		public static bool IsAdjacent(GridPosition lhs, GridPosition rhs)
		{
			return default(bool);
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x000301F8 File Offset: 0x0002E3F8
		[Token(Token = "0x6006223")]
		[Address(RVA = "0x1DECCC0", Offset = "0x1DEB8C0", VA = "0x181DECCC0")]
		public static bool IsAdjacent8Dirs(GridPosition lhs, GridPosition rhs)
		{
			return default(bool);
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x00030210 File Offset: 0x0002E410
		[Token(Token = "0x6006224")]
		[Address(RVA = "0x1DECE00", Offset = "0x1DEBA00", VA = "0x181DECE00")]
		public static GridPosition RotateVector(GridPosition pos, SharedConsts.Direction current, SharedConsts.Direction target)
		{
			return default(GridPosition);
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x00030228 File Offset: 0x0002E428
		[Token(Token = "0x6006225")]
		[Address(RVA = "0x1DECC50", Offset = "0x1DEB850", VA = "0x181DECC50", Slot = "5")]
		public bool Equals(GridPosition other)
		{
			return default(bool);
		}

		// Token: 0x04002D70 RID: 11632
		[Token(Token = "0x4002D70")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GridPosition GRID_ZERO;

		// Token: 0x04002D71 RID: 11633
		[Token(Token = "0x4002D71")]
		[FieldOffset(Offset = "0x8")]
		public static readonly GridPosition GRID_LEFT;

		// Token: 0x04002D72 RID: 11634
		[Token(Token = "0x4002D72")]
		[FieldOffset(Offset = "0x10")]
		public static readonly GridPosition GRID_RIGHT;

		// Token: 0x04002D73 RID: 11635
		[Token(Token = "0x4002D73")]
		[FieldOffset(Offset = "0x18")]
		public static readonly GridPosition GRID_UP;

		// Token: 0x04002D74 RID: 11636
		[Token(Token = "0x4002D74")]
		[FieldOffset(Offset = "0x20")]
		public static readonly GridPosition GRID_DOWN;

		// Token: 0x04002D75 RID: 11637
		[Token(Token = "0x4002D75")]
		[FieldOffset(Offset = "0x28")]
		public static readonly GridPosition GRID_UP_LEFT;

		// Token: 0x04002D76 RID: 11638
		[Token(Token = "0x4002D76")]
		[FieldOffset(Offset = "0x30")]
		public static readonly GridPosition GRID_UP_RIGHT;

		// Token: 0x04002D77 RID: 11639
		[Token(Token = "0x4002D77")]
		[FieldOffset(Offset = "0x38")]
		public static readonly GridPosition GRID_DOWN_LEFT;

		// Token: 0x04002D78 RID: 11640
		[Token(Token = "0x4002D78")]
		[FieldOffset(Offset = "0x40")]
		public static readonly GridPosition GRID_DOWN_RIGHT;

		// Token: 0x04002D79 RID: 11641
		[Token(Token = "0x4002D79")]
		[FieldOffset(Offset = "0x48")]
		public static readonly GridPosition GRID_DISABLE_DUMMY;

		// Token: 0x04002D7A RID: 11642
		[Token(Token = "0x4002D7A")]
		[FieldOffset(Offset = "0x50")]
		public static readonly GridPosition[] GRID_FOUR_WAYS;

		// Token: 0x04002D7B RID: 11643
		[Token(Token = "0x4002D7B")]
		[FieldOffset(Offset = "0x58")]
		public static readonly GridPosition[] GRID_EIGHT_WAYS;

		// Token: 0x04002D7C RID: 11644
		[Token(Token = "0x4002D7C")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public static readonly GridPosition ZERO;

		// Token: 0x04002D7D RID: 11645
		[Token(Token = "0x4002D7D")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public static readonly GridPosition ONE;

		// Token: 0x04002D7E RID: 11646
		[Token(Token = "0x4002D7E")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public static readonly GridPosition NEGATIVE_ONE;

		// Token: 0x04002D7F RID: 11647
		[Token(Token = "0x4002D7F")]
		[FieldOffset(Offset = "0x0")]
		public int row;

		// Token: 0x04002D80 RID: 11648
		[Token(Token = "0x4002D80")]
		[FieldOffset(Offset = "0x4")]
		public int col;
	}
}
