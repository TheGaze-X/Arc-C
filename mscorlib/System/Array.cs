using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	[System.Serializable]
	public abstract class Array : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.ICloneable
	{
		// Token: 0x06000CC8 RID: 3272 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x4CF0E10", Offset = "0x4CEFA10", VA = "0x184CF0E10")]
		public static System.Array CreateInstance(System.Type elementType, params long[] lengths)
		{
			return null;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CC9")]
		public static System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly<T>(T[] array)
		{
			return null;
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCA")]
		public static void Resize<T>(ref T[] array, int newSize)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x0000C000 File Offset: 0x0000A200
		[Token(Token = "0x17000116")]
		private int Count
		{
			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x4CF1FC0", Offset = "0x4CF0BC0", VA = "0x184CF1FC0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0000C018 File Offset: 0x0000A218
		[Token(Token = "0x17000117")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000118")]
		private object Item
		{
			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0x4CF41B0", Offset = "0x4CF2DB0", VA = "0x184CF41B0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CCE")]
			[Address(RVA = "0x4CF41C0", Offset = "0x4CF2DC0", VA = "0x184CF41C0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0000C030 File Offset: 0x0000A230
		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x4CF3D30", Offset = "0x4CF2930", VA = "0x184CF3D30", Slot = "11")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0000C048 File Offset: 0x0000A248
		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x4CF3F90", Offset = "0x4CF2B90", VA = "0x184CF3F90", Slot = "12")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x4CF3D90", Offset = "0x4CF2990", VA = "0x184CF3D90", Slot = "13")]
		private void Clear()
		{
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x4CF1B80", Offset = "0x4CF0780", VA = "0x184CF1B80", Slot = "16")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x4CF4090", Offset = "0x4CF2C90", VA = "0x184CF4090", Slot = "17")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x4CF4150", Offset = "0x4CF2D50", VA = "0x184CF4150", Slot = "18")]
		private void Remove(object value)
		{
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x4CF40F0", Offset = "0x4CF2CF0", VA = "0x184CF40F0", Slot = "19")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x4CEF810", Offset = "0x4CEE410", VA = "0x184CEF810", Slot = "4")]
		public void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x3204BC0", Offset = "0x32037C0", VA = "0x183204BC0", Slot = "23")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0000C078 File Offset: 0x0000A278
		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x4CF41E0", Offset = "0x4CF2DE0", VA = "0x184CF41E0", Slot = "20")]
		private int CompareTo(object other, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0000C090 File Offset: 0x0000A290
		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x4CF4470", Offset = "0x4CF3070", VA = "0x184CF4470", Slot = "21")]
		private bool Equals(object other, System.Collections.IEqualityComparer comparer)
		{
			return default(bool);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x420DB20", Offset = "0x420C720", VA = "0x18420DB20")]
		internal static int CombineHashCodes(int h1, int h2)
		{
			return 0;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x4CF4690", Offset = "0x4CF3290", VA = "0x184CF4690", Slot = "22")]
		private int GetHashCode(System.Collections.IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x4CEED50", Offset = "0x4CED950", VA = "0x184CEED50")]
		public static int BinarySearch(System.Array array, object value)
		{
			return 0;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CDD")]
		public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, System.Converter<TInput, TOutput> converter)
		{
			return null;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x4CEF920", Offset = "0x4CEE520", VA = "0x184CEF920")]
		public static void Copy(System.Array sourceArray, System.Array destinationArray, long length)
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x4CEFBE0", Offset = "0x4CEE7E0", VA = "0x184CEFBE0")]
		public static void Copy(System.Array sourceArray, long sourceIndex, System.Array destinationArray, long destinationIndex, long length)
		{
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x4CEF690", Offset = "0x4CEE290", VA = "0x184CEF690")]
		public void CopyTo(System.Array array, long index)
		{
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE1")]
		public static void ForEach<T>(T[] array, System.Action<T> action)
		{
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x17000119")]
		public long LongLength
		{
			[Token(Token = "0x6000CE2")]
			[Address(RVA = "0x4CF48D0", Offset = "0x4CF34D0", VA = "0x184CF48D0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0000C108 File Offset: 0x0000A308
		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x4CF10C0", Offset = "0x4CEFCC0", VA = "0x184CF10C0")]
		public long GetLongLength(int dimension)
		{
			return 0L;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x4CF14D0", Offset = "0x4CF00D0", VA = "0x184CF14D0")]
		public object GetValue(long index)
		{
			return null;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x4CF1340", Offset = "0x4CEFF40", VA = "0x184CF1340")]
		public object GetValue(long index1, long index2)
		{
			return null;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x4CF1870", Offset = "0x4CF0470", VA = "0x184CF1870")]
		public object GetValue(long index1, long index2, long index3)
		{
			return null;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x4CF1570", Offset = "0x4CF0170", VA = "0x184CF1570")]
		public object GetValue(params long[] indices)
		{
			return null;
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0000C120 File Offset: 0x0000A320
		[Token(Token = "0x1700011A")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0000C138 File Offset: 0x0000A338
		[Token(Token = "0x1700011B")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0000C150 File Offset: 0x0000A350
		[Token(Token = "0x1700011C")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6000CEA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700011D")]
		public object SyncRoot
		{
			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0000C168 File Offset: 0x0000A368
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x4CEF340", Offset = "0x4CEDF40", VA = "0x184CEF340")]
		public static int BinarySearch(System.Array array, int index, int length, object value)
		{
			return 0;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0000C180 File Offset: 0x0000A380
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x4CEEE50", Offset = "0x4CEDA50", VA = "0x184CEEE50")]
		public static int BinarySearch(System.Array array, object value, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x4CEEF50", Offset = "0x4CEDB50", VA = "0x184CEEF50")]
		public static int BinarySearch(System.Array array, int index, int length, object value, System.Collections.IComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x4CF10E0", Offset = "0x4CEFCE0", VA = "0x184CF10E0")]
		private static int GetMedian(int low, int hi)
		{
			return 0;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		[Token(Token = "0x6000CF0")]
		public static int BinarySearch<T>(T[] array, T value)
		{
			return 0;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		[Token(Token = "0x6000CF1")]
		public static int BinarySearch<T>(T[] array, T value, System.Collections.Generic.IComparer<T> comparer)
		{
			return 0;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		[Token(Token = "0x6000CF2")]
		public static int BinarySearch<T>(T[] array, int index, int length, T value)
		{
			return 0;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0000C210 File Offset: 0x0000A410
		[Token(Token = "0x6000CF3")]
		public static int BinarySearch<T>(T[] array, int index, int length, T value, System.Collections.Generic.IComparer<T> comparer)
		{
			return 0;
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0000C228 File Offset: 0x0000A428
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x4CF1B80", Offset = "0x4CF0780", VA = "0x184CF1B80")]
		public static int IndexOf(System.Array array, object value)
		{
			return 0;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0000C240 File Offset: 0x0000A440
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x4CF1A80", Offset = "0x4CF0680", VA = "0x184CF1A80")]
		public static int IndexOf(System.Array array, object value, int startIndex)
		{
			return 0;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0000C258 File Offset: 0x0000A458
		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x4CF1C70", Offset = "0x4CF0870", VA = "0x184CF1C70")]
		public static int IndexOf(System.Array array, object value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0000C270 File Offset: 0x0000A470
		[Token(Token = "0x6000CF7")]
		public static int IndexOf<T>(T[] array, T value)
		{
			return 0;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0000C288 File Offset: 0x0000A488
		[Token(Token = "0x6000CF8")]
		public static int IndexOf<T>(T[] array, T value, int startIndex)
		{
			return 0;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		[Token(Token = "0x6000CF9")]
		public static int IndexOf<T>(T[] array, T value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x4CF2080", Offset = "0x4CF0C80", VA = "0x184CF2080")]
		public static int LastIndexOf(System.Array array, object value)
		{
			return 0;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x4CF21B0", Offset = "0x4CF0DB0", VA = "0x184CF21B0")]
		public static int LastIndexOf(System.Array array, object value, int startIndex)
		{
			return 0;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x4CF2230", Offset = "0x4CF0E30", VA = "0x184CF2230")]
		public static int LastIndexOf(System.Array array, object value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x6000CFD")]
		public static int LastIndexOf<T>(T[] array, T value)
		{
			return 0;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x6000CFE")]
		public static int LastIndexOf<T>(T[] array, T value, int startIndex)
		{
			return 0;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x6000CFF")]
		public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x4CF25B0", Offset = "0x4CF11B0", VA = "0x184CF25B0")]
		public static void Reverse(System.Array array)
		{
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x4CF2690", Offset = "0x4CF1290", VA = "0x184CF2690")]
		public static void Reverse(System.Array array, int index, int length)
		{
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D02")]
		public static void Reverse<T>(T[] array)
		{
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D03")]
		public static void Reverse<T>(T[] array, int index, int length)
		{
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x4CF2C60", Offset = "0x4CF1860", VA = "0x184CF2C60")]
		public void SetValue(object value, long index)
		{
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x4CF3110", Offset = "0x4CF1D10", VA = "0x184CF3110")]
		public void SetValue(object value, long index1, long index2)
		{
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x4CF2D00", Offset = "0x4CF1900", VA = "0x184CF2D00")]
		public void SetValue(object value, long index1, long index2, long index3)
		{
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x4CF29D0", Offset = "0x4CF15D0", VA = "0x184CF29D0")]
		public void SetValue(object value, params long[] indices)
		{
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x4CF3A20", Offset = "0x4CF2620", VA = "0x184CF3A20")]
		public static void Sort(System.Array array)
		{
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x4CF39F0", Offset = "0x4CF25F0", VA = "0x184CF39F0")]
		public static void Sort(System.Array array, int index, int length)
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x4CF3B00", Offset = "0x4CF2700", VA = "0x184CF3B00")]
		public static void Sort(System.Array array, System.Collections.IComparer comparer)
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x4CF3C00", Offset = "0x4CF2800", VA = "0x184CF3C00")]
		public static void Sort(System.Array array, int index, int length, System.Collections.IComparer comparer)
		{
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x4CF3C30", Offset = "0x4CF2830", VA = "0x184CF3C30")]
		public static void Sort(System.Array keys, System.Array items)
		{
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x4CF38F0", Offset = "0x4CF24F0", VA = "0x184CF38F0")]
		public static void Sort(System.Array keys, System.Array items, System.Collections.IComparer comparer)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x4CF38D0", Offset = "0x4CF24D0", VA = "0x184CF38D0")]
		public static void Sort(System.Array keys, System.Array items, int index, int length)
		{
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x4CF3490", Offset = "0x4CF2090", VA = "0x184CF3490")]
		public static void Sort(System.Array keys, System.Array items, int index, int length, System.Collections.IComparer comparer)
		{
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D10")]
		public static void Sort<T>(T[] array)
		{
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D11")]
		public static void Sort<T>(T[] array, int index, int length)
		{
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D12")]
		public static void Sort<T>(T[] array, System.Collections.Generic.IComparer<T> comparer)
		{
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D13")]
		public static void Sort<T>(T[] array, int index, int length, System.Collections.Generic.IComparer<T> comparer)
		{
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D14")]
		public static void Sort<T>(T[] array, System.Comparison<T> comparison)
		{
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D15")]
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items)
		{
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D16")]
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length)
		{
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D17")]
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, System.Collections.Generic.IComparer<TKey> comparer)
		{
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D18")]
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, System.Collections.Generic.IComparer<TKey> comparer)
		{
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x6000D19")]
		public static bool Exists<T>(T[] array, System.Predicate<T> match)
		{
			return default(bool);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1A")]
		public static void Fill<T>(T[] array, T value)
		{
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1B")]
		public static void Fill<T>(T[] array, T value, int startIndex, int count)
		{
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D1C")]
		public static T Find<T>(T[] array, System.Predicate<T> match)
		{
			return null;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D1D")]
		public static T[] FindAll<T>(T[] array, System.Predicate<T> match)
		{
			return null;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0000C360 File Offset: 0x0000A560
		[Token(Token = "0x6000D1E")]
		public static int FindIndex<T>(T[] array, System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0000C378 File Offset: 0x0000A578
		[Token(Token = "0x6000D1F")]
		public static int FindIndex<T>(T[] array, int startIndex, System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0000C390 File Offset: 0x0000A590
		[Token(Token = "0x6000D20")]
		public static int FindIndex<T>(T[] array, int startIndex, int count, System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D21")]
		public static T FindLast<T>(T[] array, System.Predicate<T> match)
		{
			return null;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		[Token(Token = "0x6000D22")]
		public static int FindLastIndex<T>(T[] array, System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		[Token(Token = "0x6000D23")]
		public static int FindLastIndex<T>(T[] array, int startIndex, System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		[Token(Token = "0x6000D24")]
		public static int FindLastIndex<T>(T[] array, int startIndex, int count, System.Predicate<T> match)
		{
			return 0;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		[Token(Token = "0x6000D25")]
		public static bool TrueForAll<T>(T[] array, System.Predicate<T> match)
		{
			return default(bool);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x4CF0FE0", Offset = "0x4CEFBE0", VA = "0x184CF0FE0", Slot = "8")]
		public System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private Array()
		{
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0000C408 File Offset: 0x0000A608
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x4CF1FC0", Offset = "0x4CF0BC0", VA = "0x184CF1FC0")]
		internal int InternalArray__ICollection_get_Count()
		{
			return 0;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0000C420 File Offset: 0x0000A620
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		internal bool InternalArray__ICollection_get_IsReadOnly()
		{
			return default(bool);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x4CF1100", Offset = "0x4CEFD00", VA = "0x184CF1100")]
		[MethodImpl(256)]
		internal ref byte GetRawSzArrayData()
		{
			return null;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D2B")]
		internal System.Collections.Generic.IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
		{
			return null;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x4CF1F60", Offset = "0x4CF0B60", VA = "0x184CF1F60")]
		internal void InternalArray__ICollection_Clear()
		{
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2D")]
		internal void InternalArray__ICollection_Add<T>(T item)
		{
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0000C438 File Offset: 0x0000A638
		[Token(Token = "0x6000D2E")]
		internal bool InternalArray__ICollection_Remove<T>(T item)
		{
			return default(bool);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0000C450 File Offset: 0x0000A650
		[Token(Token = "0x6000D2F")]
		internal bool InternalArray__ICollection_Contains<T>(T item)
		{
			return default(bool);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D30")]
		internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex)
		{
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D31")]
		internal T InternalArray__IReadOnlyList_get_Item<T>(int index)
		{
			return null;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0000C468 File Offset: 0x0000A668
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x4CF1FC0", Offset = "0x4CF0BC0", VA = "0x184CF1FC0")]
		internal int InternalArray__IReadOnlyCollection_get_Count()
		{
			return 0;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D33")]
		internal void InternalArray__Insert<T>(int index, T item)
		{
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x4CF2020", Offset = "0x4CF0C20", VA = "0x184CF2020")]
		internal void InternalArray__RemoveAt(int index)
		{
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0000C480 File Offset: 0x0000A680
		[Token(Token = "0x6000D35")]
		internal int InternalArray__IndexOf<T>(T item)
		{
			return 0;
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D36")]
		internal T InternalArray__get_Item<T>(int index)
		{
			return null;
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D37")]
		internal void InternalArray__set_Item<T>(int index, T item)
		{
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D38")]
		internal void GetGenericValueImpl<T>(int pos, out T value)
		{
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D39")]
		internal void SetGenericValueImpl<T>(int pos, ref T value)
		{
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0000C498 File Offset: 0x0000A698
		[Token(Token = "0x1700011E")]
		public int Length
		{
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x4CF1FC0", Offset = "0x4CF0BC0", VA = "0x184CF1FC0")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		[Token(Token = "0x1700011F")]
		public int Rank
		{
			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x4CF10F0", Offset = "0x4CEFCF0", VA = "0x184CF10F0")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000D3C RID: 3388
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x4CF10F0", Offset = "0x4CEFCF0", VA = "0x184CF10F0")]
		[MethodImpl(4096)]
		private extern int GetRank();

		// Token: 0x06000D3D RID: 3389
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x4CF10B0", Offset = "0x4CEFCB0", VA = "0x184CF10B0")]
		[MethodImpl(4096)]
		public extern int GetLength(int dimension);

		// Token: 0x06000D3E RID: 3390
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x4CF10D0", Offset = "0x4CEFCD0", VA = "0x184CF10D0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public extern int GetLowerBound(int dimension);

		// Token: 0x06000D3F RID: 3391
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x4CF14C0", Offset = "0x4CF00C0", VA = "0x184CF14C0")]
		[MethodImpl(4096)]
		public extern object GetValue(params int[] indices);

		// Token: 0x06000D40 RID: 3392
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x4CF2C50", Offset = "0x4CF1850", VA = "0x184CF2C50")]
		[MethodImpl(4096)]
		public extern void SetValue(object value, params int[] indices);

		// Token: 0x06000D41 RID: 3393
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x4CF1160", Offset = "0x4CEFD60", VA = "0x184CF1160")]
		[MethodImpl(4096)]
		internal extern object GetValueImpl(int pos);

		// Token: 0x06000D42 RID: 3394
		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x4CF2920", Offset = "0x4CF1520", VA = "0x184CF2920")]
		[MethodImpl(4096)]
		internal extern void SetValueImpl(object value, int pos);

		// Token: 0x06000D43 RID: 3395
		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x4CF0FD0", Offset = "0x4CEFBD0", VA = "0x184CF0FD0")]
		[MethodImpl(4096)]
		internal static extern bool FastCopy(System.Array source, int source_idx, System.Array dest, int dest_idx, int length);

		// Token: 0x06000D44 RID: 3396
		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x4CF0400", Offset = "0x4CEF000", VA = "0x184CF0400")]
		[MethodImpl(4096)]
		internal static extern System.Array CreateInstanceImpl(System.Type elementType, int[] lengths, int[] bounds);

		// Token: 0x06000D45 RID: 3397 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x4CF1120", Offset = "0x4CEFD20", VA = "0x184CF1120")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public int GetUpperBound(int dimension)
		{
			return 0;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x4CF1170", Offset = "0x4CEFD70", VA = "0x184CF1170")]
		public object GetValue(int index)
		{
			return null;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x4CF1740", Offset = "0x4CF0340", VA = "0x184CF1740")]
		public object GetValue(int index1, int index2)
		{
			return null;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x4CF17D0", Offset = "0x4CF03D0", VA = "0x184CF17D0")]
		public object GetValue(int index1, int index2, int index3)
		{
			return null;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x4CF2F20", Offset = "0x4CF1B20", VA = "0x184CF2F20")]
		public void SetValue(object value, int index)
		{
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x4CF2BB0", Offset = "0x4CF17B0", VA = "0x184CF2BB0")]
		public void SetValue(object value, int index1, int index2)
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x4CF2930", Offset = "0x4CF1530", VA = "0x184CF2930")]
		public void SetValue(object value, int index1, int index2, int index3)
		{
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x4CF48B0", Offset = "0x4CF34B0", VA = "0x184CF48B0")]
		internal static System.Array UnsafeCreateInstance(System.Type elementType, int[] lengths, int[] lowerBounds)
		{
			return null;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x4CF0480", Offset = "0x4CEF080", VA = "0x184CF0480")]
		internal static System.Array UnsafeCreateInstance(System.Type elementType, int length1, int length2)
		{
			return null;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x4CF48C0", Offset = "0x4CF34C0", VA = "0x184CF48C0")]
		internal static System.Array UnsafeCreateInstance(System.Type elementType, params int[] lengths)
		{
			return null;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x4CF0410", Offset = "0x4CEF010", VA = "0x184CF0410")]
		public static System.Array CreateInstance(System.Type elementType, int length)
		{
			return null;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x4CF0480", Offset = "0x4CEF080", VA = "0x184CF0480")]
		public static System.Array CreateInstance(System.Type elementType, int length1, int length2)
		{
			return null;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x4CF0D70", Offset = "0x4CEF970", VA = "0x184CF0D70")]
		public static System.Array CreateInstance(System.Type elementType, int length1, int length2, int length3)
		{
			return null;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x4CF0510", Offset = "0x4CEF110", VA = "0x184CF0510")]
		public static System.Array CreateInstance(System.Type elementType, params int[] lengths)
		{
			return null;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x4CF0820", Offset = "0x4CEF420", VA = "0x184CF0820")]
		public static System.Array CreateInstance(System.Type elementType, int[] lengths, int[] lowerBounds)
		{
			return null;
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x4CEF4D0", Offset = "0x4CEE0D0", VA = "0x184CEF4D0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static void Clear(System.Array array, int index, int length)
		{
		}

		// Token: 0x06000D55 RID: 3413
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x4CEF4C0", Offset = "0x4CEE0C0", VA = "0x184CEF4C0")]
		[MethodImpl(4096)]
		private static extern void ClearInternal(System.Array a, int index, int count);

		// Token: 0x06000D56 RID: 3414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x4CEFAC0", Offset = "0x4CEE6C0", VA = "0x184CEFAC0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static void Copy(System.Array sourceArray, System.Array destinationArray, int length)
		{
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x4CEFD70", Offset = "0x4CEE970", VA = "0x184CEFD70")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static void Copy(System.Array sourceArray, int sourceIndex, System.Array destinationArray, int destinationIndex, int length)
		{
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x4CF03B0", Offset = "0x4CEEFB0", VA = "0x184CF03B0")]
		private static System.ArrayTypeMismatchException CreateArrayTypeMismatchException()
		{
			return null;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x4CEF360", Offset = "0x4CEDF60", VA = "0x184CEF360")]
		private static bool CanAssignArrayElement(System.Type source, System.Type target)
		{
			return default(bool);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x4CEF680", Offset = "0x4CEE280", VA = "0x184CEF680")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static void ConstrainedCopy(System.Array sourceArray, int sourceIndex, System.Array destinationArray, int destinationIndex, int length)
		{
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D5B")]
		public static T[] Empty<T>()
		{
			return null;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Initialize()
		{
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		[Token(Token = "0x6000D5D")]
		private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0000C510 File Offset: 0x0000A710
		[Token(Token = "0x6000D5E")]
		private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x4CF32A0", Offset = "0x4CF1EA0", VA = "0x184CF32A0")]
		private static void SortImpl(System.Array keys, System.Array items, int index, int length, System.Collections.IComparer comparer)
		{
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D60")]
		internal static T UnsafeLoad<T>(T[] array, int index)
		{
			return null;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D61")]
		internal static void UnsafeStore<T>(T[] array, int index, T value)
		{
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000D62")]
		internal static R UnsafeMov<S, R>(S instance)
		{
			return null;
		}

		// Token: 0x02000169 RID: 361
		[Token(Token = "0x2000169")]
		private sealed class ArrayEnumerator : System.Collections.IEnumerator, System.ICloneable
		{
			// Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D63")]
			[Address(RVA = "0x4CEEB10", Offset = "0x4CED710", VA = "0x184CEEB10")]
			internal ArrayEnumerator(System.Array array)
			{
			}

			// Token: 0x06000D64 RID: 3428 RVA: 0x0000C528 File Offset: 0x0000A728
			[Token(Token = "0x6000D64")]
			[Address(RVA = "0x4CEEAF0", Offset = "0x4CED6F0", VA = "0x184CEEAF0", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000D65 RID: 3429 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D65")]
			[Address(RVA = "0x487E640", Offset = "0x487D240", VA = "0x18487E640", Slot = "6")]
			public void Reset()
			{
			}

			// Token: 0x06000D66 RID: 3430 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000D66")]
			[Address(RVA = "0x3204BC0", Offset = "0x32037C0", VA = "0x183204BC0", Slot = "7")]
			public object Clone()
			{
				return null;
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000120")]
			public object Current
			{
				[Token(Token = "0x6000D67")]
				[Address(RVA = "0x4CEEBB0", Offset = "0x4CED7B0", VA = "0x184CEEBB0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x040005C2 RID: 1474
			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private System.Array _array;

			// Token: 0x040005C3 RID: 1475
			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int _index;

			// Token: 0x040005C4 RID: 1476
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int _endIndex;
		}

		// Token: 0x0200016A RID: 362
		[Token(Token = "0x200016A")]
		[StructLayout(0)]
		private class RawData
		{
			// Token: 0x040005C5 RID: 1477
			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public System.IntPtr Bounds;

			// Token: 0x040005C6 RID: 1478
			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public System.IntPtr Count;

			// Token: 0x040005C7 RID: 1479
			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte Data;
		}

		// Token: 0x0200016B RID: 363
		[Token(Token = "0x200016B")]
		internal struct InternalEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
		{
			// Token: 0x06000D68 RID: 3432 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D68")]
			internal InternalEnumerator(System.Array array)
			{
			}

			// Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D69")]
			public void Dispose()
			{
			}

			// Token: 0x06000D6A RID: 3434 RVA: 0x0000C540 File Offset: 0x0000A740
			[Token(Token = "0x6000D6A")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000121")]
			public T Current
			{
				[Token(Token = "0x6000D6B")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D6C RID: 3436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D6C")]
			private void Reset()
			{
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x06000D6D RID: 3437 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000122")]
			private object Current
			{
				[Token(Token = "0x6000D6D")]
				get
				{
					return null;
				}
			}

			// Token: 0x040005C8 RID: 1480
			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly System.Array array;

			// Token: 0x040005C9 RID: 1481
			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int idx;
		}

		// Token: 0x0200016C RID: 364
		[Token(Token = "0x200016C")]
		internal class EmptyInternalEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
		{
			// Token: 0x06000D6E RID: 3438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D6E")]
			public void Dispose()
			{
			}

			// Token: 0x06000D6F RID: 3439 RVA: 0x0000C558 File Offset: 0x0000A758
			[Token(Token = "0x6000D6F")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000D70 RID: 3440 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000123")]
			public T Current
			{
				[Token(Token = "0x6000D70")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000D71 RID: 3441 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000124")]
			private object Current
			{
				[Token(Token = "0x6000D71")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D72 RID: 3442 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D72")]
			private void Reset()
			{
			}

			// Token: 0x06000D73 RID: 3443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D73")]
			public EmptyInternalEnumerator()
			{
			}

			// Token: 0x040005CA RID: 1482
			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly System.Array.EmptyInternalEnumerator<T> Value;
		}

		// Token: 0x0200016D RID: 365
		[Token(Token = "0x200016D")]
		private struct SorterObjectArray
		{
			// Token: 0x06000D75 RID: 3445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D75")]
			[Address(RVA = "0x4CFB2E0", Offset = "0x4CF9EE0", VA = "0x184CFB2E0")]
			internal SorterObjectArray(object[] keys, object[] items, System.Collections.IComparer comparer)
			{
			}

			// Token: 0x06000D76 RID: 3446 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D76")]
			[Address(RVA = "0x4CFAEB0", Offset = "0x4CF9AB0", VA = "0x184CFAEB0")]
			internal void SwapIfGreaterWithItems(int a, int b)
			{
			}

			// Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x4CFB100", Offset = "0x4CF9D00", VA = "0x184CFB100")]
			private void Swap(int i, int j)
			{
			}

			// Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D78")]
			[Address(RVA = "0x4CFAEA0", Offset = "0x4CF9AA0", VA = "0x184CFAEA0")]
			internal void Sort(int left, int length)
			{
			}

			// Token: 0x06000D79 RID: 3449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D79")]
			[Address(RVA = "0x4CFAC20", Offset = "0x4CF9820", VA = "0x184CFAC20")]
			private void IntrospectiveSort(int left, int length)
			{
			}

			// Token: 0x06000D7A RID: 3450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0x4CFAB40", Offset = "0x4CF9740", VA = "0x184CFAB40")]
			private void IntroSort(int lo, int hi, int depthLimit)
			{
			}

			// Token: 0x06000D7B RID: 3451 RVA: 0x0000C570 File Offset: 0x0000A770
			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0x4CFAD10", Offset = "0x4CF9910", VA = "0x184CFAD10")]
			private int PickPivotAndPartition(int lo, int hi)
			{
				return 0;
			}

			// Token: 0x06000D7C RID: 3452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x4CFA7A0", Offset = "0x4CF93A0", VA = "0x184CFA7A0")]
			private void Heapsort(int lo, int hi)
			{
			}

			// Token: 0x06000D7D RID: 3453 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x4CFA460", Offset = "0x4CF9060", VA = "0x184CFA460")]
			private void DownHeap(int i, int n, int lo)
			{
			}

			// Token: 0x06000D7E RID: 3454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x4CFA860", Offset = "0x4CF9460", VA = "0x184CFA860")]
			private void InsertionSort(int lo, int hi)
			{
			}

			// Token: 0x040005CB RID: 1483
			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object[] keys;

			// Token: 0x040005CC RID: 1484
			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private object[] items;

			// Token: 0x040005CD RID: 1485
			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private System.Collections.IComparer comparer;
		}

		// Token: 0x0200016E RID: 366
		[Token(Token = "0x200016E")]
		private struct SorterGenericArray
		{
			// Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x4CFA3B0", Offset = "0x4CF8FB0", VA = "0x184CFA3B0")]
			internal SorterGenericArray(System.Array keys, System.Array items, System.Collections.IComparer comparer)
			{
			}

			// Token: 0x06000D80 RID: 3456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D80")]
			[Address(RVA = "0x4CFA150", Offset = "0x4CF8D50", VA = "0x184CFA150")]
			internal void SwapIfGreaterWithItems(int a, int b)
			{
			}

			// Token: 0x06000D81 RID: 3457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D81")]
			[Address(RVA = "0x4CFA2C0", Offset = "0x4CF8EC0", VA = "0x184CFA2C0")]
			private void Swap(int i, int j)
			{
			}

			// Token: 0x06000D82 RID: 3458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D82")]
			[Address(RVA = "0x4CFA140", Offset = "0x4CF8D40", VA = "0x184CFA140")]
			internal void Sort(int left, int length)
			{
			}

			// Token: 0x06000D83 RID: 3459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D83")]
			[Address(RVA = "0x4CF9E60", Offset = "0x4CF8A60", VA = "0x184CF9E60")]
			private void IntrospectiveSort(int left, int length)
			{
			}

			// Token: 0x06000D84 RID: 3460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D84")]
			[Address(RVA = "0x4CF9D80", Offset = "0x4CF8980", VA = "0x184CF9D80")]
			private void IntroSort(int lo, int hi, int depthLimit)
			{
			}

			// Token: 0x06000D85 RID: 3461 RVA: 0x0000C588 File Offset: 0x0000A788
			[Token(Token = "0x6000D85")]
			[Address(RVA = "0x4CF9FA0", Offset = "0x4CF8BA0", VA = "0x184CF9FA0")]
			private int PickPivotAndPartition(int lo, int hi)
			{
				return 0;
			}

			// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D86")]
			[Address(RVA = "0x4CF9B10", Offset = "0x4CF8710", VA = "0x184CF9B10")]
			private void Heapsort(int lo, int hi)
			{
			}

			// Token: 0x06000D87 RID: 3463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x4CF98D0", Offset = "0x4CF84D0", VA = "0x184CF98D0")]
			private void DownHeap(int i, int n, int lo)
			{
			}

			// Token: 0x06000D88 RID: 3464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D88")]
			[Address(RVA = "0x4CF9BD0", Offset = "0x4CF87D0", VA = "0x184CF9BD0")]
			private void InsertionSort(int lo, int hi)
			{
			}

			// Token: 0x040005CE RID: 1486
			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private System.Array keys;

			// Token: 0x040005CF RID: 1487
			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private System.Array items;

			// Token: 0x040005D0 RID: 1488
			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private System.Collections.IComparer comparer;
		}
	}
}
