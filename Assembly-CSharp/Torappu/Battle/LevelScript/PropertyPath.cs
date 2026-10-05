using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200288B RID: 10379
	[Token(Token = "0x200288B")]
	[Serializable]
	public struct PropertyPath : IEquatable<PropertyPath>
	{
		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x0601149C RID: 70812 RVA: 0x0006A788 File Offset: 0x00068988
		// (set) Token: 0x0601149D RID: 70813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002637")]
		public int length
		{
			[Token(Token = "0x601149C")]
			[Address(RVA = "0x928510", Offset = "0x927110", VA = "0x180928510")]
			get
			{
				return 0;
			}
			[Token(Token = "0x601149D")]
			[Address(RVA = "0x928520", Offset = "0x927120", VA = "0x180928520")]
			set
			{
			}
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x0601149E RID: 70814 RVA: 0x0006A7A0 File Offset: 0x000689A0
		[Token(Token = "0x17002638")]
		public bool isEmpty
		{
			[Token(Token = "0x601149E")]
			[Address(RVA = "0x928430", Offset = "0x927030", VA = "0x180928430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601149F RID: 70815 RVA: 0x0006A7B8 File Offset: 0x000689B8
		[Token(Token = "0x601149F")]
		[Address(RVA = "0x928100", Offset = "0x926D00", VA = "0x180928100")]
		public PropertyPath TrimFirstKey()
		{
			return default(PropertyPath);
		}

		// Token: 0x060114A0 RID: 70816 RVA: 0x0006A7D0 File Offset: 0x000689D0
		[Token(Token = "0x60114A0")]
		[Address(RVA = "0x9279C0", Offset = "0x9265C0", VA = "0x1809279C0")]
		public PropertyPath Concat(string another, bool isPrefix = false)
		{
			return default(PropertyPath);
		}

		// Token: 0x060114A1 RID: 70817 RVA: 0x0006A7E8 File Offset: 0x000689E8
		[Token(Token = "0x60114A1")]
		[Address(RVA = "0x927730", Offset = "0x926330", VA = "0x180927730")]
		public PropertyPath Concat(PropertyPath another, bool isPrefix)
		{
			return default(PropertyPath);
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x060114A2 RID: 70818 RVA: 0x0006A800 File Offset: 0x00068A00
		[Token(Token = "0x17002639")]
		public static PropertyPath empty
		{
			[Token(Token = "0x60114A2")]
			[Address(RVA = "0x928370", Offset = "0x926F70", VA = "0x180928370")]
			get
			{
				return default(PropertyPath);
			}
		}

		// Token: 0x060114A3 RID: 70819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114A3")]
		[Address(RVA = "0x9281F0", Offset = "0x926DF0", VA = "0x1809281F0")]
		public PropertyPath(string key0)
		{
		}

		// Token: 0x060114A4 RID: 70820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114A4")]
		[Address(RVA = "0x9281B0", Offset = "0x926DB0", VA = "0x1809281B0")]
		public PropertyPath(string key0, string key1)
		{
		}

		// Token: 0x060114A5 RID: 70821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114A5")]
		[Address(RVA = "0x928310", Offset = "0x926F10", VA = "0x180928310")]
		public PropertyPath(string key0, string key1, string key2)
		{
		}

		// Token: 0x060114A6 RID: 70822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114A6")]
		[Address(RVA = "0x9282A0", Offset = "0x926EA0", VA = "0x1809282A0")]
		public PropertyPath(string key0, string key1, string key2, string key3)
		{
		}

		// Token: 0x060114A7 RID: 70823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60114A7")]
		[Address(RVA = "0x927FF0", Offset = "0x926BF0", VA = "0x180927FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060114A8 RID: 70824 RVA: 0x0006A818 File Offset: 0x00068A18
		[Token(Token = "0x60114A8")]
		[Address(RVA = "0x927E50", Offset = "0x926A50", VA = "0x180927E50")]
		public static PropertyPath Parse(string stringValue)
		{
			return default(PropertyPath);
		}

		// Token: 0x060114A9 RID: 70825 RVA: 0x0006A830 File Offset: 0x00068A30
		[Token(Token = "0x60114A9")]
		[Address(RVA = "0x927BC0", Offset = "0x9267C0", VA = "0x180927BC0", Slot = "4")]
		public bool Equals(PropertyPath other)
		{
			return default(bool);
		}

		// Token: 0x060114AA RID: 70826 RVA: 0x0006A848 File Offset: 0x00068A48
		[Token(Token = "0x60114AA")]
		[Address(RVA = "0x927B10", Offset = "0x926710", VA = "0x180927B10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060114AB RID: 70827 RVA: 0x0006A860 File Offset: 0x00068A60
		[Token(Token = "0x60114AB")]
		[Address(RVA = "0x927DA0", Offset = "0x9269A0", VA = "0x180927DA0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040134F4 RID: 79092
		[Token(Token = "0x40134F4")]
		public const int MAX_LENGTH = 4;

		// Token: 0x040134F5 RID: 79093
		[Token(Token = "0x40134F5")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public int lengthMinusOne;

		// Token: 0x040134F6 RID: 79094
		[Token(Token = "0x40134F6")]
		[FieldOffset(Offset = "0x8")]
		public string key0;

		// Token: 0x040134F7 RID: 79095
		[Token(Token = "0x40134F7")]
		[FieldOffset(Offset = "0x10")]
		public string key1;

		// Token: 0x040134F8 RID: 79096
		[Token(Token = "0x40134F8")]
		[FieldOffset(Offset = "0x18")]
		public string key2;

		// Token: 0x040134F9 RID: 79097
		[Token(Token = "0x40134F9")]
		[FieldOffset(Offset = "0x20")]
		public string key3;
	}
}
