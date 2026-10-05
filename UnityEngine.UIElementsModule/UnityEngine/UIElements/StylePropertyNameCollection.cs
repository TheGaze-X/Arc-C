using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	public struct StylePropertyNameCollection : IEnumerable<StylePropertyName>, IEnumerable
	{
		// Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
		internal StylePropertyNameCollection(List<StylePropertyName> list)
		{
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x5B12D60", Offset = "0x5B11960", VA = "0x185B12D60")]
		public StylePropertyNameCollection.Enumerator GetEnumerator()
		{
			return default(StylePropertyNameCollection.Enumerator);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x5B12E00", Offset = "0x5B11A00", VA = "0x185B12E00", Slot = "4")]
		private IEnumerator<StylePropertyName> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x5B12EC0", Offset = "0x5B11AC0", VA = "0x185B12EC0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x0")]
		internal List<StylePropertyName> propertiesList;

		// Token: 0x020001EB RID: 491
		[Token(Token = "0x20001EB")]
		public struct Enumerator : IEnumerator<StylePropertyName>, IEnumerator, IDisposable
		{
			// Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D09")]
			[Address(RVA = "0x552EFE0", Offset = "0x552DBE0", VA = "0x18552EFE0")]
			internal Enumerator(List<StylePropertyName>.Enumerator enumerator)
			{
			}

			// Token: 0x06000D0A RID: 3338 RVA: 0x00006870 File Offset: 0x00004A70
			[Token(Token = "0x6000D0A")]
			[Address(RVA = "0x5B06CC0", Offset = "0x5B058C0", VA = "0x185B06CC0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170002F8 RID: 760
			// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00006888 File Offset: 0x00004A88
			[Token(Token = "0x170002F8")]
			public StylePropertyName Current
			{
				[Token(Token = "0x6000D0B")]
				[Address(RVA = "0x5B06D70", Offset = "0x5B05970", VA = "0x185B06D70", Slot = "4")]
				get
				{
					return default(StylePropertyName);
				}
			}

			// Token: 0x170002F9 RID: 761
			// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x170002F9")]
			private object Current
			{
				[Token(Token = "0x6000D0C")]
				[Address(RVA = "0x5B06D00", Offset = "0x5B05900", VA = "0x185B06D00", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D0D RID: 3341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D0E")]
			[Address(RVA = "0x5B06C80", Offset = "0x5B05880", VA = "0x185B06C80", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x040006B4 RID: 1716
			[Token(Token = "0x40006B4")]
			[FieldOffset(Offset = "0x0")]
			private List<StylePropertyName>.Enumerator m_Enumerator;
		}
	}
}
