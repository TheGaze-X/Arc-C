using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	[DefaultMember("Item")]
	[UsedByNativeCode]
	[Il2CppEagerStaticClassConstruction]
	public struct Vector3Int : IEquatable<Vector3Int>, IFormattable
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00005520 File Offset: 0x00003720
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D9")]
		public int x
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00005538 File Offset: 0x00003738
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DA")]
		public int y
		{
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x566210", Offset = "0x564E10", VA = "0x180566210")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00005550 File Offset: 0x00003750
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DB")]
		public int z
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x4226DD0", Offset = "0x42259D0", VA = "0x184226DD0")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x4CD2130", Offset = "0x4CD0D30", VA = "0x184CD2130")]
		[MethodImpl(256)]
		public Vector3Int(int x, int y, int z)
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x5955210", Offset = "0x5953E10", VA = "0x185955210")]
		[MethodImpl(256)]
		public static implicit operator Vector3(Vector3Int v)
		{
			return default(Vector3);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x59551B0", Offset = "0x5953DB0", VA = "0x1859551B0")]
		[MethodImpl(256)]
		public static Vector3Int operator +(Vector3Int a, Vector3Int b)
		{
			return default(Vector3Int);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00005598 File Offset: 0x00003798
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x59552E0", Offset = "0x5953EE0", VA = "0x1859552E0")]
		[MethodImpl(256)]
		public static Vector3Int operator -(Vector3Int a, Vector3Int b)
		{
			return default(Vector3Int);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000055B0 File Offset: 0x000037B0
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x59552A0", Offset = "0x5953EA0", VA = "0x1859552A0")]
		[MethodImpl(256)]
		public static Vector3Int operator *(Vector3Int a, int b)
		{
			return default(Vector3Int);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000055C8 File Offset: 0x000037C8
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x59551F0", Offset = "0x5953DF0", VA = "0x1859551F0")]
		[MethodImpl(256)]
		public static bool operator ==(Vector3Int lhs, Vector3Int rhs)
		{
			return default(bool);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000055E0 File Offset: 0x000037E0
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x5955250", Offset = "0x5953E50", VA = "0x185955250")]
		[MethodImpl(256)]
		public static bool operator !=(Vector3Int lhs, Vector3Int rhs)
		{
			return default(bool);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x5954C30", Offset = "0x5953830", VA = "0x185954C30", Slot = "0")]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00005610 File Offset: 0x00003810
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x5954D00", Offset = "0x5953900", VA = "0x185954D00", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(Vector3Int other)
		{
			return default(bool);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x5954D50", Offset = "0x5953950", VA = "0x185954D50", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x5954DD0", Offset = "0x59539D0", VA = "0x185954DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x5955000", Offset = "0x5953C00", VA = "0x185955000")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x5954DE0", Offset = "0x59539E0", VA = "0x185954DE0", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x170001DC")]
		public static Vector3Int zero
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x5955160", Offset = "0x5953D60", VA = "0x185955160")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3Int);
			}
		}

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x0")]
		private int m_X;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x4")]
		private int m_Y;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x8")]
		private int m_Z;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3Int s_Zero;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0xC")]
		private static readonly Vector3Int s_One;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Vector3Int s_Up;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x24")]
		private static readonly Vector3Int s_Down;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Vector3Int s_Left;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly Vector3Int s_Right;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x48")]
		private static readonly Vector3Int s_Forward;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x54")]
		private static readonly Vector3Int s_Back;
	}
}
