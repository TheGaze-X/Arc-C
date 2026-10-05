using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[NativeHeader("Runtime/Math/Rect.h")]
	[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public struct Rect : IEquatable<Rect>, IFormattable
	{
		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		public Rect(float x, float y, float width, float height)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x57C0100", Offset = "0x57BED00", VA = "0x1857C0100")]
		public Rect(Vector2 position, Vector2 size)
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x576A1B0", Offset = "0x5768DB0", VA = "0x18576A1B0")]
		public Rect(Rect source)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x1700008D")]
		public static Rect zero
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x59389F0", Offset = "0x59375F0", VA = "0x1859389F0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x5938390", Offset = "0x5936F90", VA = "0x185938390")]
		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
		{
			return default(Rect);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00002B80 File Offset: 0x00000D80
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008E")]
		public float x
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x592C440", Offset = "0x592B040", VA = "0x18592C440")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x8772C0", Offset = "0x875EC0", VA = "0x1808772C0")]
			set
			{
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00002B98 File Offset: 0x00000D98
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008F")]
		public float y
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x5916B50", Offset = "0x5915750", VA = "0x185916B50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x8772B0", Offset = "0x875EB0", VA = "0x1808772B0")]
			set
			{
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000090")]
		public Vector2 position
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x5938990", Offset = "0x5937590", VA = "0x185938990")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x57A9A70", Offset = "0x57A8670", VA = "0x1857A9A70")]
			set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00002BC8 File Offset: 0x00000DC8
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000091")]
		public Vector2 center
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x5938920", Offset = "0x5937520", VA = "0x185938920")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x5938AA0", Offset = "0x59376A0", VA = "0x185938AA0")]
			set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00002BE0 File Offset: 0x00000DE0
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000092")]
		public Vector2 min
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x5938970", Offset = "0x5937570", VA = "0x185938970")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x5938B10", Offset = "0x5937710", VA = "0x185938B10")]
			set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00002BF8 File Offset: 0x00000DF8
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000093")]
		public Vector2 max
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x5938950", Offset = "0x5937550", VA = "0x185938950")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x5938AE0", Offset = "0x59376E0", VA = "0x185938AE0")]
			set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00002C10 File Offset: 0x00000E10
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000094")]
		public float width
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x592C420", Offset = "0x592B020", VA = "0x18592C420")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x5DE4E0", Offset = "0x5DD0E0", VA = "0x1805DE4E0")]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00002C28 File Offset: 0x00000E28
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		public float height
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x5917F50", Offset = "0x5916B50", VA = "0x185917F50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x8772A0", Offset = "0x875EA0", VA = "0x1808772A0")]
			set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00002C40 File Offset: 0x00000E40
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000096")]
		public Vector2 size
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x59389B0", Offset = "0x59375B0", VA = "0x1859389B0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x57C2460", Offset = "0x57C1060", VA = "0x1857C2460")]
			set
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00002C58 File Offset: 0x00000E58
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000097")]
		public float xMin
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x592C440", Offset = "0x592B040", VA = "0x18592C440")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x5938B60", Offset = "0x5937760", VA = "0x185938B60")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00002C70 File Offset: 0x00000E70
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000098")]
		public float yMin
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x5916B50", Offset = "0x5915750", VA = "0x185916B50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x5938B90", Offset = "0x5937790", VA = "0x185938B90")]
			set
			{
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00002C88 File Offset: 0x00000E88
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000099")]
		public float xMax
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x59389D0", Offset = "0x59375D0", VA = "0x1859389D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x5938B50", Offset = "0x5937750", VA = "0x185938B50")]
			set
			{
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00002CA0 File Offset: 0x00000EA0
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009A")]
		public float yMax
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x59389E0", Offset = "0x59375E0", VA = "0x1859389E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x5938B80", Offset = "0x5937780", VA = "0x185938B80")]
			set
			{
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x59380B0", Offset = "0x5936CB0", VA = "0x1859380B0")]
		public bool Contains(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x59380F0", Offset = "0x5936CF0", VA = "0x1859380F0")]
		public bool Contains(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x59383D0", Offset = "0x5936FD0", VA = "0x1859383D0")]
		private static Rect OrderMinMax(Rect rect)
		{
			return default(Rect);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x5938570", Offset = "0x5937170", VA = "0x185938570")]
		public bool Overlaps(Rect other)
		{
			return default(bool);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x5938420", Offset = "0x5937020", VA = "0x185938420")]
		public bool Overlaps(Rect other, bool allowInverse)
		{
			return default(bool);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x59385C0", Offset = "0x59371C0", VA = "0x1859385C0")]
		public static Vector2 PointToNormalized(Rect rectangle, Vector2 point)
		{
			return default(Vector2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x5938A40", Offset = "0x5937640", VA = "0x185938A40")]
		public static bool operator !=(Rect lhs, Rect rhs)
		{
			return default(bool);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x5938A00", Offset = "0x5937600", VA = "0x185938A00")]
		public static bool operator ==(Rect lhs, Rect rhs)
		{
			return default(bool);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x59382F0", Offset = "0x5936EF0", VA = "0x1859382F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x5938130", Offset = "0x5936D30", VA = "0x185938130", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x5938240", Offset = "0x5936E40", VA = "0x185938240", Slot = "4")]
		public bool Equals(Rect other)
		{
			return default(bool);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x5938660", Offset = "0x5937260", VA = "0x185938660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x5938670", Offset = "0x5937270", VA = "0x185938670", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("x")]
		private float m_XMin;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x4")]
		[NativeName("y")]
		private float m_YMin;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x8")]
		[NativeName("width")]
		private float m_Width;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0xC")]
		[NativeName("height")]
		private float m_Height;
	}
}
