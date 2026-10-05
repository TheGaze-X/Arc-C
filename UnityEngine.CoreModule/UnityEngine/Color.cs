using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	[NativeHeader("Runtime/Math/Color.h")]
	[NativeClass("ColorRGBAf")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public struct Color : IEquatable<Color>, IFormattable
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		[MethodImpl(256)]
		public Color(float r, float g, float b, float a)
		{
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x5949620", Offset = "0x5948220", VA = "0x185949620")]
		[MethodImpl(256)]
		public Color(float r, float g, float b)
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x5949370", Offset = "0x5947F70", VA = "0x185949370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x5949610", Offset = "0x5948210", VA = "0x185949610")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x5949380", Offset = "0x5947F80", VA = "0x185949380", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x114B8C0", Offset = "0x114A4C0", VA = "0x18114B8C0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x5948C20", Offset = "0x5947820", VA = "0x185948C20", Slot = "0")]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x5948D00", Offset = "0x5947900", VA = "0x185948D00", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(Color other)
		{
			return default(bool);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x5949920", Offset = "0x5948520", VA = "0x185949920")]
		[MethodImpl(256)]
		public static Color operator +(Color a, Color b)
		{
			return default(Color);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x5949BA0", Offset = "0x59487A0", VA = "0x185949BA0")]
		[MethodImpl(256)]
		public static Color operator -(Color a, Color b)
		{
			return default(Color);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x5949B40", Offset = "0x5948740", VA = "0x185949B40")]
		[MethodImpl(256)]
		public static Color operator *(Color a, Color b)
		{
			return default(Color);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x5949AA0", Offset = "0x59486A0", VA = "0x185949AA0")]
		[MethodImpl(256)]
		public static Color operator *(Color a, float b)
		{
			return default(Color);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x5949AF0", Offset = "0x59486F0", VA = "0x185949AF0")]
		[MethodImpl(256)]
		public static Color operator *(float b, Color a)
		{
			return default(Color);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x5949980", Offset = "0x5948580", VA = "0x185949980")]
		[MethodImpl(256)]
		public static Color operator /(Color a, float b)
		{
			return default(Color);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x59499A0", Offset = "0x59485A0", VA = "0x1859499A0")]
		[MethodImpl(256)]
		public static bool operator ==(Color lhs, Color rhs)
		{
			return default(bool);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x5949A30", Offset = "0x5948630", VA = "0x185949A30")]
		[MethodImpl(256)]
		public static bool operator !=(Color lhs, Color rhs)
		{
			return default(bool);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x59490F0", Offset = "0x5947CF0", VA = "0x1859490F0")]
		[MethodImpl(256)]
		public static Color Lerp(Color a, Color b, float t)
		{
			return default(Color);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x5949060", Offset = "0x5947C60", VA = "0x185949060")]
		[MethodImpl(256)]
		public static Color LerpUnclamped(Color a, Color b, float t)
		{
			return default(Color);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x59491F0", Offset = "0x5947DF0", VA = "0x1859491F0")]
		[MethodImpl(256)]
		internal Color RGBMultiplied(float multiplier)
		{
			return default(Color);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x5948BE0", Offset = "0x59477E0", VA = "0x185948BE0")]
		[MethodImpl(256)]
		internal Color AlphaMultiplied(float multiplier)
		{
			return default(Color);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x59491A0", Offset = "0x5947DA0", VA = "0x1859491A0")]
		[MethodImpl(256)]
		internal Color RGBMultiplied(Color multiplier)
		{
			return default(Color);
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x17000196")]
		public static Color red
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x59498F0", Offset = "0x59484F0", VA = "0x1859498F0")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x17000197")]
		public static Color green
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x59497C0", Offset = "0x59483C0", VA = "0x1859497C0")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x17000198")]
		public static Color blue
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x5949650", Offset = "0x5948250", VA = "0x185949650")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x17000199")]
		public static Color white
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x5949900", Offset = "0x5948500", VA = "0x185949900")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x1700019A")]
		public static Color black
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x5949640", Offset = "0x5948240", VA = "0x185949640")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x1700019B")]
		public static Color yellow
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x5949910", Offset = "0x5948510", VA = "0x185949910")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x1700019C")]
		public static Color cyan
		{
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x5949670", Offset = "0x5948270", VA = "0x185949670")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x1700019D")]
		public static Color magenta
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x59498C0", Offset = "0x59484C0", VA = "0x1859498C0")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x1700019E")]
		public static Color gray
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x5949770", Offset = "0x5948370", VA = "0x185949770")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x1700019F")]
		public static Color grey
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x5949770", Offset = "0x5948370", VA = "0x185949770")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x170001A0")]
		public static Color clear
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x5949660", Offset = "0x5948260", VA = "0x185949660")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x170001A1")]
		public float grayscale
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x5949780", Offset = "0x5948380", VA = "0x185949780")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x170001A2")]
		public Color linear
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x59497D0", Offset = "0x59483D0", VA = "0x1859497D0")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x170001A3")]
		public Color gamma
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x5949680", Offset = "0x5948280", VA = "0x185949680")]
			[MethodImpl(256)]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x170001A4")]
		public float maxColorComponent
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x59498D0", Offset = "0x59484D0", VA = "0x1859498D0")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x5949A10", Offset = "0x5948610", VA = "0x185949A10")]
		[MethodImpl(256)]
		public static implicit operator Vector4(Color c)
		{
			return default(Vector4);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x5949A10", Offset = "0x5948610", VA = "0x185949A10")]
		[MethodImpl(256)]
		public static implicit operator Color(Vector4 v)
		{
			return default(Color);
		}

		// Token: 0x170001A5 RID: 421
		[Token(Token = "0x170001A5")]
		public float this[int index]
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0xEBFEF0", Offset = "0xEBEAF0", VA = "0x180EBFEF0")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x5949C00", Offset = "0x5948800", VA = "0x185949C00")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x59492E0", Offset = "0x5947EE0", VA = "0x1859492E0")]
		public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V)
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x5949240", Offset = "0x5947E40", VA = "0x185949240")]
		private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V)
		{
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x5948D80", Offset = "0x5947980", VA = "0x185948D80")]
		[MethodImpl(256)]
		public static Color HSVToRGB(float H, float S, float V)
		{
			return default(Color);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x5948DB0", Offset = "0x59479B0", VA = "0x185948DB0")]
		public static Color HSVToRGB(float H, float S, float V, bool hdr)
		{
			return default(Color);
		}

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x0")]
		public float r;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x4")]
		public float g;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x8")]
		public float b;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0xC")]
		public float a;
	}
}
