using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	public static class Misc
	{
		// Token: 0x0600065D RID: 1629 RVA: 0x00006164 File Offset: 0x00004364
		[Token(Token = "0x600065D")]
		public static KeyValuePair<Key, Value> MakePair<Key, Value>(Key key, Value value)
		{
			return default(KeyValuePair<Key, Value>);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600065E")]
		public static void Swap<T>(IList<T> list, int a, int b)
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000617C File Offset: 0x0000437C
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x5522320", Offset = "0x5520F20", VA = "0x185522320")]
		public static bool CheckMaskByIndex(int mask, int bitIndex)
		{
			return default(bool);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00006194 File Offset: 0x00004394
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x5023760", Offset = "0x5022360", VA = "0x185023760")]
		public static bool CheckMaskByValue(int mask, int bitValue)
		{
			return default(bool);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000061AC File Offset: 0x000043AC
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x5522310", Offset = "0x5520F10", VA = "0x185522310")]
		public static int AddMaskBits(int mask, int bitValue)
		{
			return 0;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000061C4 File Offset: 0x000043C4
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x5522950", Offset = "0x5521550", VA = "0x185522950")]
		public static int RemoveMaskBits(int mask, int bitValue)
		{
			return 0;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000061DC File Offset: 0x000043DC
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x5522340", Offset = "0x5520F40", VA = "0x185522340")]
		public static int DeltaToIncrement(int delta)
		{
			return 0;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000664")]
		public static T GetLifeValue<T>(T value, LifeType type, T infinity) where T : struct
		{
			return null;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000061F4 File Offset: 0x000043F4
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x55223D0", Offset = "0x5520FD0", VA = "0x1855223D0")]
		public static bool IndexBelongToBinaryMask(int index, int mask)
		{
			return default(bool);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0000620C File Offset: 0x0000440C
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x55223F0", Offset = "0x5520FF0", VA = "0x1855223F0")]
		public static bool IndexBelongToBinaryMask(int index, long mask)
		{
			return default(bool);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00006224 File Offset: 0x00004424
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x5522420", Offset = "0x5521020", VA = "0x185522420")]
		public static bool IndexEqualsToBinaryMask(int index, int mask)
		{
			return default(bool);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0000623C File Offset: 0x0000443C
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x5522410", Offset = "0x5521010", VA = "0x185522410")]
		public static int IndexConvertToBinaryMask(int index)
		{
			return 0;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00006254 File Offset: 0x00004454
		[Token(Token = "0x6000669")]
		public static bool TryParseEnum<T>(string str, bool ignoreCase, out T result)
		{
			return default(bool);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0000626C File Offset: 0x0000446C
		[Token(Token = "0x600066A")]
		public static bool TryParseMaskEnum<T>(string str, char[] separator, bool ignoreCase, out T result)
		{
			return default(bool);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x5522960", Offset = "0x5521560", VA = "0x185522960")]
		public static void Reset(this Transform transform)
		{
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x5522A60", Offset = "0x5521660", VA = "0x185522A60")]
		public static string SafeValue(this string str)
		{
			return null;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00006284 File Offset: 0x00004484
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x4D5C9B0", Offset = "0x4D5B5B0", VA = "0x184D5C9B0")]
		public static int GenRandomSeed()
		{
			return 0;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0000629C File Offset: 0x0000449C
		[Token(Token = "0x600066E")]
		public static bool CheckAtLeastOneIntersect<T>(IList<T> lhsList, IList<T> rhsList) where T : IComparable
		{
			return default(bool);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x5522730", Offset = "0x5521330", VA = "0x185522730")]
		public static byte[] ReadAllBytes(this Stream input, long offset = 0L)
		{
			return null;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x5522370", Offset = "0x5520F70", VA = "0x185522370")]
		public static StringBuilder FormatJsonStyleString(StringBuilder sb)
		{
			return null;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000062B4 File Offset: 0x000044B4
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x5522430", Offset = "0x5521030", VA = "0x185522430")]
		public static Rect ParseRect(string rectStr)
		{
			return default(Rect);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000062CC File Offset: 0x000044CC
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x5522350", Offset = "0x5520F50", VA = "0x185522350")]
		public static Vector2 FlipXY(this Vector2 vector)
		{
			return default(Vector2);
		}

		// Token: 0x02000106 RID: 262
		[Token(Token = "0x2000106")]
		public struct EnumOnce<T> : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x06000673 RID: 1651 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000673")]
			public EnumOnce(T value)
			{
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x06000674 RID: 1652 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700007F")]
			public T Current
			{
				[Token(Token = "0x6000674")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x06000675 RID: 1653 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000080")]
			private object Current
			{
				[Token(Token = "0x6000675")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000676 RID: 1654 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000676")]
			public void Dispose()
			{
			}

			// Token: 0x06000677 RID: 1655 RVA: 0x000062E4 File Offset: 0x000044E4
			[Token(Token = "0x6000677")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000678 RID: 1656 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000678")]
			public void Reset()
			{
			}

			// Token: 0x040005A3 RID: 1443
			[Token(Token = "0x40005A3")]
			[FieldOffset(Offset = "0x0")]
			private T m_value;

			// Token: 0x040005A4 RID: 1444
			[Token(Token = "0x40005A4")]
			[FieldOffset(Offset = "0x0")]
			private int m_index;
		}

		// Token: 0x02000107 RID: 263
		[Token(Token = "0x2000107")]
		public class ObjectRef
		{
			// Token: 0x06000679 RID: 1657 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x5523820", Offset = "0x5522420", VA = "0x185523820")]
			public IEnumerator WaitForResult()
			{
				return null;
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x55238A0", Offset = "0x55224A0", VA = "0x1855238A0")]
			public IEnumerator WaitUtilNotError(object blockError)
			{
				return null;
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ObjectRef()
			{
			}

			// Token: 0x040005A5 RID: 1445
			[Token(Token = "0x40005A5")]
			[FieldOffset(Offset = "0x10")]
			public object value;

			// Token: 0x040005A6 RID: 1446
			[Token(Token = "0x40005A6")]
			[FieldOffset(Offset = "0x18")]
			public object error;
		}

		// Token: 0x0200010A RID: 266
		[Token(Token = "0x200010A")]
		public struct TRS
		{
			// Token: 0x06000688 RID: 1672 RVA: 0x0000632C File Offset: 0x0000452C
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x5528090", Offset = "0x5526C90", VA = "0x185528090")]
			public static Misc.TRS FromTransform(Transform transform)
			{
				return default(Misc.TRS);
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x5527FD0", Offset = "0x5526BD0", VA = "0x185527FD0")]
			public void Apply(Transform transform)
			{
			}

			// Token: 0x040005AE RID: 1454
			[Token(Token = "0x40005AE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Misc.TRS DEFAULT;

			// Token: 0x040005AF RID: 1455
			[Token(Token = "0x40005AF")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 localPosition;

			// Token: 0x040005B0 RID: 1456
			[Token(Token = "0x40005B0")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion localRotation;

			// Token: 0x040005B1 RID: 1457
			[Token(Token = "0x40005B1")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 localScale;
		}
	}
}
