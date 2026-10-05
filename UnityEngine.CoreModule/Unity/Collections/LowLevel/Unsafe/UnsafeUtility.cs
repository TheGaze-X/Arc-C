using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[StaticAccessor("UnsafeUtility", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
	public static class UnsafeUtility
	{
		// Token: 0x06000064 RID: 100
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x5946F00", Offset = "0x5945B00", VA = "0x185946F00")]
		[ThreadSafe(ThrowsException = true)]
		[MethodImpl(4096)]
		public unsafe static extern void* Malloc(long size, int alignment, Allocator allocator);

		// Token: 0x06000065 RID: 101
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5946AD0", Offset = "0x59456D0", VA = "0x185946AD0")]
		[ThreadSafe(ThrowsException = true)]
		[MethodImpl(4096)]
		public unsafe static extern void Free(void* memory, Allocator allocator);

		// Token: 0x06000066 RID: 102
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x5947060", Offset = "0x5945C60", VA = "0x185947060")]
		[ThreadSafe(ThrowsException = true)]
		[MethodImpl(4096)]
		public unsafe static extern void MemCpy(void* destination, void* source, long size);

		// Token: 0x06000067 RID: 103
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x5947000", Offset = "0x5945C00", VA = "0x185947000")]
		[ThreadSafe(ThrowsException = true)]
		[MethodImpl(4096)]
		public unsafe static extern void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count);

		// Token: 0x06000068 RID: 104
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x59470C0", Offset = "0x5945CC0", VA = "0x1859470C0")]
		[ThreadSafe(ThrowsException = true)]
		[MethodImpl(4096)]
		public unsafe static extern void MemMove(void* destination, void* source, long size);

		// Token: 0x06000069 RID: 105
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x5947120", Offset = "0x5945D20", VA = "0x185947120")]
		[ThreadSafe(ThrowsException = true)]
		[MethodImpl(4096)]
		public unsafe static extern void MemSet(void* destination, byte value, long size);

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x5946F50", Offset = "0x5945B50", VA = "0x185946F50")]
		public unsafe static void MemClear(void* destination, long size)
		{
		}

		// Token: 0x0600006B RID: 107
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x5946FA0", Offset = "0x5945BA0", VA = "0x185946FA0")]
		[ThreadSafe(ThrowsException = true)]
		[MethodImpl(4096)]
		public unsafe static extern int MemCmp(void* ptr1, void* ptr2, long size);

		// Token: 0x0600006C RID: 108
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x5947180", Offset = "0x5945D80", VA = "0x185947180")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern int SizeOf(Type type);

		// Token: 0x0600006D RID: 109
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x5946EC0", Offset = "0x5945AC0", VA = "0x185946EC0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern bool IsBlittable(Type type);

		// Token: 0x0600006E RID: 110 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x5946E60", Offset = "0x5945A60", VA = "0x185946E60")]
		private static bool IsBlittableValueType(Type t)
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x5946BA0", Offset = "0x59457A0", VA = "0x185946BA0")]
		private static string GetReasonForTypeNonBlittableImpl(Type t, string name)
		{
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x5946DB0", Offset = "0x59459B0", VA = "0x185946DB0")]
		internal static bool IsArrayBlittable(Array arr)
		{
			return default(bool);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x5946B10", Offset = "0x5945710", VA = "0x185946B10")]
		internal static string GetReasonForArrayNonBlittable(Array arr)
		{
			return null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x6000072")]
		public static int AlignOf<T>() where T : struct
		{
			return 0;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000073")]
		[MethodImpl(256)]
		public unsafe static T ReadArrayElement<T>(void* source, int index)
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000074")]
		[MethodImpl(256)]
		public unsafe static T ReadArrayElementWithStride<T>(void* source, int index, int stride)
		{
			return null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[MethodImpl(256)]
		public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[MethodImpl(256)]
		public unsafe static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000077")]
		[MethodImpl(256)]
		public unsafe static void* AddressOf<T>(ref T output) where T : struct
		{
			return null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000078")]
		[MethodImpl(256)]
		public static int SizeOf<T>() where T : struct
		{
			return 0;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6000079")]
		[MethodImpl(256)]
		public static int EnumToInt<T>(T enumValue) where T : struct, IConvertible
		{
			return 0;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[MethodImpl(256)]
		private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x600007B")]
		[MethodImpl(256)]
		public static bool EnumEquals<T>(T lhs, T rhs) where T : struct, IConvertible
		{
			return default(bool);
		}

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		private struct AlignOfHelper<T> where T : struct
		{
			// Token: 0x0400006C RID: 108
			[Token(Token = "0x400006C")]
			[FieldOffset(Offset = "0x0")]
			public byte dummy;

			// Token: 0x0400006D RID: 109
			[Token(Token = "0x400006D")]
			[FieldOffset(Offset = "0x0")]
			public T data;
		}
	}
}
