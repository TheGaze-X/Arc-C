using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[NativeType("Runtime/Math/Vector2Int.h")]
	[DefaultMember("Item")]
	[UsedByNativeCode]
	[Il2CppEagerStaticClassConstruction]
	public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00005388 File Offset: 0x00003588
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D0")]
		public int x
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x000053A0 File Offset: 0x000035A0
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D1")]
		public int y
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x566210", Offset = "0x564E10", VA = "0x180566210")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		[MethodImpl(256)]
		public Vector2Int(int x, int y)
		{
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x170001D2")]
		public float magnitude
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x5953980", Offset = "0x5952580", VA = "0x185953980")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x5953AD0", Offset = "0x59526D0", VA = "0x185953AD0")]
		[MethodImpl(256)]
		public static implicit operator Vector2(Vector2Int v)
		{
			return default(Vector2);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x5953480", Offset = "0x5952080", VA = "0x185953480")]
		[MethodImpl(256)]
		public static Vector2Int FloorToInt(Vector2 v)
		{
			return default(Vector2Int);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x5953590", Offset = "0x5952190", VA = "0x185953590")]
		[MethodImpl(256)]
		public static Vector2Int RoundToInt(Vector2 v)
		{
			return default(Vector2Int);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x5953AB0", Offset = "0x59526B0", VA = "0x185953AB0")]
		[MethodImpl(256)]
		public static bool operator ==(Vector2Int lhs, Vector2Int rhs)
		{
			return default(bool);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x5953AF0", Offset = "0x59526F0", VA = "0x185953AF0")]
		[MethodImpl(256)]
		public static bool operator !=(Vector2Int lhs, Vector2Int rhs)
		{
			return default(bool);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x59533D0", Offset = "0x5951FD0", VA = "0x1859533D0", Slot = "0")]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x59533B0", Offset = "0x5951FB0", VA = "0x1859533B0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(Vector2Int other)
		{
			return default(bool);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x5953540", Offset = "0x5952140", VA = "0x185953540", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x5953800", Offset = "0x5952400", VA = "0x185953800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x5953640", Offset = "0x5952240", VA = "0x185953640", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x170001D3")]
		public static Vector2Int zero
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x5953A70", Offset = "0x5952670", VA = "0x185953A70")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x170001D4")]
		public static Vector2Int one
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x59539B0", Offset = "0x59525B0", VA = "0x1859539B0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x170001D5")]
		public static Vector2Int up
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x5953A30", Offset = "0x5952630", VA = "0x185953A30")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x170001D6")]
		public static Vector2Int down
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x5953900", Offset = "0x5952500", VA = "0x185953900")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000054F0 File Offset: 0x000036F0
		[Token(Token = "0x170001D7")]
		public static Vector2Int left
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x5953940", Offset = "0x5952540", VA = "0x185953940")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x170001D8")]
		public static Vector2Int right
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x59539F0", Offset = "0x59525F0", VA = "0x1859539F0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x0")]
		private int m_X;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x4")]
		private int m_Y;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2Int s_Zero;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2Int s_One;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2Int s_Up;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Vector2Int s_Down;

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Vector2Int s_Left;

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x28")]
		private static readonly Vector2Int s_Right;
	}
}
