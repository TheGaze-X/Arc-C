using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	internal static class ArrayHelpers
	{
		// Token: 0x06001434 RID: 5172 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x6001434")]
		public static int LengthSafe<TValue>(this TValue[] array)
		{
			return 0;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001435")]
		public static void Clear<TValue>(this TValue[] array)
		{
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001436")]
		public static void Clear<TValue>(this TValue[] array, int count)
		{
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001437")]
		public static void Clear<TValue>(this TValue[] array, ref int count)
		{
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001438")]
		public static void EnsureCapacity<TValue>(ref TValue[] array, int count, int capacity, int capacityIncrement = 10)
		{
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001439")]
		public static void DuplicateWithCapacity<TValue>(ref TValue[] array, int count, int capacity, int capacityIncrement = 10)
		{
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0000A848 File Offset: 0x00008A48
		[Token(Token = "0x600143A")]
		public static bool Contains<TValue>(TValue[] array, TValue value)
		{
			return default(bool);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x600143B")]
		public static bool ContainsReference<TValue>(this TValue[] array, TValue value) where TValue : class
		{
			return default(bool);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0000A878 File Offset: 0x00008A78
		[Token(Token = "0x600143C")]
		public static bool ContainsReference<TFirst, TSecond>(this TFirst[] array, int count, TSecond value) where TFirst : TSecond where TSecond : class
		{
			return default(bool);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0000A890 File Offset: 0x00008A90
		[Token(Token = "0x600143D")]
		public static bool ContainsReference<TFirst, TSecond>(this TFirst[] array, int startIndex, int count, TSecond value) where TFirst : TSecond where TSecond : class
		{
			return default(bool);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[Token(Token = "0x600143E")]
		public static bool HaveDuplicateReferences<TFirst>(this TFirst[] first, int index, int count)
		{
			return default(bool);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		[Token(Token = "0x600143F")]
		public static bool HaveEqualElements<TValue>(TValue[] first, TValue[] second, int count = 2147483647)
		{
			return default(bool);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x6001440")]
		public static int IndexOf<TValue>(TValue[] array, TValue value, int startIndex = 0, int count = -1)
		{
			return 0;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Token(Token = "0x6001441")]
		public static int IndexOf<TValue>(this TValue[] array, Predicate<TValue> predicate)
		{
			return 0;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x6001442")]
		public static int IndexOf<TValue>(this TValue[] array, Predicate<TValue> predicate, int startIndex = 0, int count = -1)
		{
			return 0;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x6001443")]
		public static int IndexOfReference<TFirst, TSecond>(this TFirst[] array, TSecond value, int count = -1) where TFirst : TSecond where TSecond : class
		{
			return 0;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x6001444")]
		public static int IndexOfReference<TFirst, TSecond>(this TFirst[] array, TSecond value, int startIndex, int count) where TFirst : TSecond where TSecond : class
		{
			return 0;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0000A950 File Offset: 0x00008B50
		[Token(Token = "0x6001445")]
		public static int IndexOfValue<TValue>(this TValue[] array, TValue value, int startIndex = 0, int count = -1) where TValue : struct, IEquatable<TValue>
		{
			return 0;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001446")]
		public static void Resize<TValue>(ref NativeArray<TValue> array, int newSize, Allocator allocator) where TValue : struct
		{
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0000A968 File Offset: 0x00008B68
		[Token(Token = "0x6001447")]
		public static int Append<TValue>(ref TValue[] array, TValue value)
		{
			return 0;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0000A980 File Offset: 0x00008B80
		[Token(Token = "0x6001448")]
		public static int Append<TValue>(ref TValue[] array, IEnumerable<TValue> values)
		{
			return 0;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0000A998 File Offset: 0x00008B98
		[Token(Token = "0x6001449")]
		public static int AppendToImmutable<TValue>(ref TValue[] array, TValue[] values)
		{
			return 0;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		[Token(Token = "0x600144A")]
		public static int AppendWithCapacity<TValue>(ref TValue[] array, ref int count, TValue value, int capacityIncrement = 10)
		{
			return 0;
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		[Token(Token = "0x600144B")]
		public static int AppendListWithCapacity<TValue, TValues>(ref TValue[] array, ref int length, TValues values, int capacityIncrement = 10) where TValues : IReadOnlyList<TValue>
		{
			return 0;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Token(Token = "0x600144C")]
		public static int AppendWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, TValue value, int capacityIncrement = 10, Allocator allocator = Allocator.Persistent) where TValue : struct
		{
			return 0;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144D")]
		public static void InsertAt<TValue>(ref TValue[] array, int index, TValue value)
		{
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144E")]
		public static void InsertAtWithCapacity<TValue>(ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement = 10)
		{
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144F")]
		public static void PutAtIfNotSet<TValue>(ref TValue[] array, int index, Func<TValue> valueFn)
		{
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[Token(Token = "0x6001450")]
		public static int GrowBy<TValue>(ref TValue[] array, int count)
		{
			return 0;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x6001451")]
		public static int GrowBy<TValue>(ref NativeArray<TValue> array, int count, Allocator allocator = Allocator.Persistent) where TValue : struct
		{
			return 0;
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0000AA28 File Offset: 0x00008C28
		[Token(Token = "0x6001452")]
		public static int GrowWithCapacity<TValue>(ref TValue[] array, ref int count, int growBy, int capacityIncrement = 10)
		{
			return 0;
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0000AA40 File Offset: 0x00008C40
		[Token(Token = "0x6001453")]
		public static int GrowWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, int growBy, int capacityIncrement = 10, Allocator allocator = Allocator.Persistent) where TValue : struct
		{
			return 0;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001454")]
		public static TValue[] Join<TValue>(TValue value, params TValue[] values)
		{
			return null;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001455")]
		public static TValue[] Merge<TValue>(TValue[] first, TValue[] second) where TValue : IEquatable<TValue>
		{
			return null;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001456")]
		public static TValue[] Merge<TValue>(TValue[] first, TValue[] second, IEqualityComparer<TValue> comparer)
		{
			return null;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001457")]
		public static void EraseAt<TValue>(ref TValue[] array, int index)
		{
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001458")]
		public static void EraseAtWithCapacity<TValue>(this TValue[] array, ref int count, int index)
		{
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001459")]
		public static void EraseAtWithCapacity<TValue>(NativeArray<TValue> array, ref int count, int index) where TValue : struct
		{
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0000AA58 File Offset: 0x00008C58
		[Token(Token = "0x600145A")]
		public static bool Erase<TValue>(ref TValue[] array, TValue value)
		{
			return default(bool);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145B")]
		public static void EraseAtByMovingTail<TValue>(TValue[] array, ref int count, int index)
		{
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600145C")]
		public static TValue[] Copy<TValue>(TValue[] array)
		{
			return null;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600145D")]
		public static TValue[] Clone<TValue>(TValue[] array) where TValue : ICloneable
		{
			return null;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600145E")]
		public static TNew[] Select<TOld, TNew>(TOld[] array, Func<TOld, TNew> converter)
		{
			return null;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145F")]
		private static void Swap<TValue>(ref TValue first, ref TValue second)
		{
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001460")]
		public static void MoveSlice<TValue>(TValue[] array, int sourceIndex, int destinationIndex, int count)
		{
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001461")]
		public static void EraseSliceWithCapacity<TValue>(ref TValue[] array, ref int length, int index, int count)
		{
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001462")]
		public static void SwapElements<TValue>(this TValue[] array, int index1, int index2)
		{
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001463")]
		public static void SwapElements<TValue>(this NativeArray<TValue> array, int index1, int index2) where TValue : struct
		{
		}
	}
}
