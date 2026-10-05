using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class TableListAttribute : Attribute
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public bool ShowPaging
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x4E1BBB0", Offset = "0x4E1A7B0", VA = "0x184E1BBB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x4E1BBD0", Offset = "0x4E1A7D0", VA = "0x184E1BBD0")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x17000054")]
		public bool ShowPagingHasValue
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		public int ScrollViewHeight
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x4E1BB50", Offset = "0x4E1A750", VA = "0x184E1BB50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x4E1BBC0", Offset = "0x4E1A7C0", VA = "0x184E1BBC0")]
			set
			{
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x4E1BB30", Offset = "0x4E1A730", VA = "0x184E1BB30")]
		public TableListAttribute()
		{
		}

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x10")]
		public int NumberOfItemsPerPage;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x14")]
		public bool IsReadOnly;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x18")]
		public int DefaultMinColumnWidth;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x1C")]
		public bool ShowIndexLabels;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x1D")]
		public bool DrawScrollView;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		public int MinScrollViewHeight;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x24")]
		public int MaxScrollViewHeight;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x28")]
		public bool AlwaysExpanded;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x29")]
		public bool HideToolbar;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x2C")]
		public int CellPadding;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private bool showPagingHasValue;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x31")]
		[HideInInspector]
		[SerializeField]
		private bool showPaging;
	}
}
