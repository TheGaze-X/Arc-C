using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x020004D2 RID: 1234
	[Token(Token = "0x20004D2")]
	public static class RandomExtensions
	{
		// Token: 0x06004DC6 RID: 19910 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
		[Token(Token = "0x6004DC6")]
		[Address(RVA = "0x188F170", Offset = "0x188DD70", VA = "0x18188F170")]
		public static float Value(this System.Random random)
		{
			return 0f;
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x0002DC00 File Offset: 0x0002BE00
		[Token(Token = "0x6004DC7")]
		[Address(RVA = "0x188EEA0", Offset = "0x188DAA0", VA = "0x18188EEA0")]
		public static int Range(this System.Random random, int min, int max)
		{
			return 0;
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x0002DC18 File Offset: 0x0002BE18
		[Token(Token = "0x6004DC8")]
		[Address(RVA = "0x188EF00", Offset = "0x188DB00", VA = "0x18188EF00")]
		public static float Range(this System.Random random, float min, float max)
		{
			return 0f;
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x0002DC30 File Offset: 0x0002BE30
		[Token(Token = "0x6004DC9")]
		[Address(RVA = "0x188EFA0", Offset = "0x188DBA0", VA = "0x18188EFA0")]
		public static double Range(this System.Random random, double min, double max)
		{
			return 0.0;
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x0002DC48 File Offset: 0x0002BE48
		[Token(Token = "0x6004DCA")]
		[Address(RVA = "0x188F010", Offset = "0x188DC10", VA = "0x18188F010")]
		public static FP Range(this System.Random random, FP min, FP max)
		{
			return default(FP);
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCB")]
		public static T Uniform<T>(this System.Random random, IList<T> items)
		{
			return null;
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x0002DC60 File Offset: 0x0002BE60
		[Token(Token = "0x6004DCC")]
		[Address(RVA = "0x188EB00", Offset = "0x188D700", VA = "0x18188EB00")]
		public static Vector2 RandomVector2(this System.Random random, Vector2 randomRange)
		{
			return default(Vector2);
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x0002DC78 File Offset: 0x0002BE78
		[Token(Token = "0x6004DCD")]
		[Address(RVA = "0x188EC80", Offset = "0x188D880", VA = "0x18188EC80")]
		public static Vector3 RandomVector3(this System.Random random, Vector3 randomRange)
		{
			return default(Vector3);
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x0002DC90 File Offset: 0x0002BE90
		[Token(Token = "0x6004DCE")]
		[Address(RVA = "0x188E950", Offset = "0x188D550", VA = "0x18188E950")]
		public static Vector2 RandomDirectionV2(this System.Random random)
		{
			return default(Vector2);
		}

		// Token: 0x06004DCF RID: 19919 RVA: 0x0002DCA8 File Offset: 0x0002BEA8
		[Token(Token = "0x6004DCF")]
		[Address(RVA = "0x188E780", Offset = "0x188D380", VA = "0x18188E780")]
		public static bool Dice(this System.Random random, float prob)
		{
			return default(bool);
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		[Token(Token = "0x6004DD0")]
		[Address(RVA = "0x188E8C0", Offset = "0x188D4C0", VA = "0x18188E8C0")]
		public static bool Dice(this System.Random random, FP prob)
		{
			return default(bool);
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD1")]
		public static void Shuffle<T>(this System.Random random, IList<T> list)
		{
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD2")]
		public static void Shuffle<T>(this System.Random random, IList<T> list, int count)
		{
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD3")]
		public static void AdvancedShuffle<T>(this System.Random random, IList<T> list, int selectCnt, int deckCnt, int offset)
		{
		}

		// Token: 0x06004DD4 RID: 19924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD4")]
		public static T UniformWithWeight<T>(this System.Random random, IList<T> items) where T : IItemWithWeight
		{
			return null;
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD5")]
		public static IList<T> SortByWeight<T>(this System.Random random, IList<T> items) where T : IItemWithWeight
		{
			return null;
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x0002DCD8 File Offset: 0x0002BED8
		[Token(Token = "0x6004DD6")]
		[Address(RVA = "0x188E440", Offset = "0x188D040", VA = "0x18188E440")]
		public static bool DicePRD(this System.Random random, RandomExtensions.IPRDRandomEntity entity, RandomExtensions.PRDRandomCategory category, float baseProb, int maxMultiplier = -1)
		{
			return default(bool);
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD7")]
		[Address(RVA = "0x188F100", Offset = "0x188DD00", VA = "0x18188F100")]
		public static void ResetPRDRandom()
		{
		}

		// Token: 0x040011DC RID: 4572
		[Token(Token = "0x40011DC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<RandomExtensions.PRDEntityHash, int> s_prdMultiplierDict;

		// Token: 0x020004D3 RID: 1235
		[Token(Token = "0x20004D3")]
		public enum PRDRandomCategory
		{
			// Token: 0x040011DE RID: 4574
			[Token(Token = "0x40011DE")]
			UNKNOWN,
			// Token: 0x040011DF RID: 4575
			[Token(Token = "0x40011DF")]
			B_OBJECT_ABILITY
		}

		// Token: 0x020004D4 RID: 1236
		[Token(Token = "0x20004D4")]
		public struct PRDEntityHash
		{
			// Token: 0x06004DD9 RID: 19929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004DD9")]
			[Address(RVA = "0x188E2D0", Offset = "0x188CED0", VA = "0x18188E2D0")]
			public void AssignNextPriority(int p)
			{
			}

			// Token: 0x06004DDA RID: 19930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004DDA")]
			[Address(RVA = "0x188E430", Offset = "0x188D030", VA = "0x18188E430")]
			public PRDEntityHash(int p1)
			{
			}

			// Token: 0x06004DDB RID: 19931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004DDB")]
			[Address(RVA = "0x188E420", Offset = "0x188D020", VA = "0x18188E420")]
			public PRDEntityHash(RandomExtensions.PRDRandomCategory category, int p1)
			{
			}

			// Token: 0x06004DDC RID: 19932 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004DDC")]
			[Address(RVA = "0x188E360", Offset = "0x188CF60", VA = "0x18188E360", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040011E0 RID: 4576
			[Token(Token = "0x40011E0")]
			[FieldOffset(Offset = "0x0")]
			public RandomExtensions.PRDRandomCategory category;

			// Token: 0x040011E1 RID: 4577
			[Token(Token = "0x40011E1")]
			[FieldOffset(Offset = "0x4")]
			public int p1;

			// Token: 0x040011E2 RID: 4578
			[Token(Token = "0x40011E2")]
			[FieldOffset(Offset = "0x8")]
			public int p2;
		}

		// Token: 0x020004D5 RID: 1237
		[Token(Token = "0x20004D5")]
		public interface IPRDRandomEntity
		{
			// Token: 0x06004DDD RID: 19933
			[Token(Token = "0x6004DDD")]
			RandomExtensions.PRDEntityHash GetPRDEntityHash(RandomExtensions.PRDRandomCategory category);

			// Token: 0x06004DDE RID: 19934
			[Token(Token = "0x6004DDE")]
			int AllocatePRDEntitySubHash(RandomExtensions.PRDRandomCategory category, RandomExtensions.IPRDRandomEntity child);

			// Token: 0x06004DDF RID: 19935
			[Token(Token = "0x6004DDF")]
			void ResetPRDEntity();
		}
	}
}
