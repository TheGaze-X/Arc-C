using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	public static class RandomUtil
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x000063EC File Offset: 0x000045EC
		[Token(Token = "0x17000088")]
		public static float value
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x55260D0", Offset = "0x5524CD0", VA = "0x1855260D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AF")]
		public static T Uniform<T>(IList<T> items)
		{
			return null;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B0")]
		public static T UniformExcept<T>(IList<T> items, T except)
		{
			return null;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B1")]
		public static T UniformExceptIndex<T>(IList<T> items, int index)
		{
			return null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B2")]
		public static T UniformWithWeight<T>(IList<T> items) where T : IItemWithWeight
		{
			return null;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B3")]
		public static T UniformWithWeight<T>(IList<T> items, T except) where T : class, IItemWithWeight
		{
			return null;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00006404 File Offset: 0x00004604
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x5525E20", Offset = "0x5524A20", VA = "0x185525E20")]
		public static Vector2 RandomVector2(Vector2 randomRange)
		{
			return default(Vector2);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0000641C File Offset: 0x0000461C
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x5525FC0", Offset = "0x5524BC0", VA = "0x185525FC0")]
		public static Vector3 RandomVector3(Vector3 randomRange)
		{
			return default(Vector3);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00006434 File Offset: 0x00004634
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x5525E80", Offset = "0x5524A80", VA = "0x185525E80")]
		public static Vector2 RandomVector2(Vector2 a, Vector3 b)
		{
			return default(Vector2);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000644C File Offset: 0x0000464C
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x5525F00", Offset = "0x5524B00", VA = "0x185525F00")]
		public static Vector3 RandomVector3(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00006464 File Offset: 0x00004664
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x5525C50", Offset = "0x5524850", VA = "0x185525C50")]
		public static Vector2 RandomDirectionV2()
		{
			return default(Vector2);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0000647C File Offset: 0x0000467C
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x5525BA0", Offset = "0x55247A0", VA = "0x185525BA0")]
		public static bool Dice(float prob)
		{
			return default(bool);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00006494 File Offset: 0x00004694
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x5526050", Offset = "0x5524C50", VA = "0x185526050")]
		public static int Range(int min, int max)
		{
			return 0;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000064AC File Offset: 0x000046AC
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x55260B0", Offset = "0x5524CB0", VA = "0x1855260B0")]
		public static float Range(float min, float max)
		{
			return 0f;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000064C4 File Offset: 0x000046C4
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x5526070", Offset = "0x5524C70", VA = "0x185526070")]
		public static float Range(Vector2 range)
		{
			return 0f;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006BD")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006BE")]
		public static void Shuffle<T>(this IList<T> list, int count)
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006BF")]
		public static void Shuffle<T>(this IList<T> list, int count, int offset)
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000064DC File Offset: 0x000046DC
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x5525CA0", Offset = "0x55248A0", VA = "0x185525CA0")]
		public static double RandomNormal(double miu = 0.0, double sigma = 1.0)
		{
			return 0.0;
		}
	}
}
