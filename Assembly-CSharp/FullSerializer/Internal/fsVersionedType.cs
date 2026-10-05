using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B9B RID: 31643
	[Token(Token = "0x2007B9B")]
	public struct fsVersionedType
	{
		// Token: 0x0602C4C7 RID: 181447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4C7")]
		[Address(RVA = "0x2877CD0", Offset = "0x28768D0", VA = "0x182877CD0")]
		public object Migrate(object ancestorInstance)
		{
			return null;
		}

		// Token: 0x0602C4C8 RID: 181448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4C8")]
		[Address(RVA = "0x2877D90", Offset = "0x2876990", VA = "0x182877D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0602C4C9 RID: 181449 RVA: 0x000DF608 File Offset: 0x000DD808
		[Token(Token = "0x602C4C9")]
		[Address(RVA = "0x28780B0", Offset = "0x2876CB0", VA = "0x1828780B0")]
		public static bool operator ==(fsVersionedType a, fsVersionedType b)
		{
			return default(bool);
		}

		// Token: 0x0602C4CA RID: 181450 RVA: 0x000DF620 File Offset: 0x000DD820
		[Token(Token = "0x602C4CA")]
		[Address(RVA = "0x2878130", Offset = "0x2876D30", VA = "0x182878130")]
		public static bool operator !=(fsVersionedType a, fsVersionedType b)
		{
			return default(bool);
		}

		// Token: 0x0602C4CB RID: 181451 RVA: 0x000DF638 File Offset: 0x000DD838
		[Token(Token = "0x602C4CB")]
		[Address(RVA = "0x2877C20", Offset = "0x2876820", VA = "0x182877C20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0602C4CC RID: 181452 RVA: 0x000DF650 File Offset: 0x000DD850
		[Token(Token = "0x602C4CC")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040401EE RID: 262638
		[Token(Token = "0x40401EE")]
		[FieldOffset(Offset = "0x0")]
		public fsVersionedType[] Ancestors;

		// Token: 0x040401EF RID: 262639
		[Token(Token = "0x40401EF")]
		[FieldOffset(Offset = "0x8")]
		public string VersionString;

		// Token: 0x040401F0 RID: 262640
		[Token(Token = "0x40401F0")]
		[FieldOffset(Offset = "0x10")]
		public Type ModelType;
	}
}
