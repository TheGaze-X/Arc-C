using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000567 RID: 1383
	[Token(Token = "0x2000567")]
	[System.Serializable]
	public class DaylightTime
	{
		// Token: 0x06002911 RID: 10513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002911")]
		[Address(RVA = "0x4C2F070", Offset = "0x4C2DC70", VA = "0x184C2F070")]
		public DaylightTime(System.DateTime start, System.DateTime end, System.TimeSpan delta)
		{
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x000168D8 File Offset: 0x00014AD8
		[Token(Token = "0x17000613")]
		public System.DateTime Start
		{
			[Token(Token = "0x6002912")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x000168F0 File Offset: 0x00014AF0
		[Token(Token = "0x17000614")]
		public System.DateTime End
		{
			[Token(Token = "0x6002913")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return default(System.DateTime);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x00016908 File Offset: 0x00014B08
		[Token(Token = "0x17000615")]
		public System.TimeSpan Delta
		{
			[Token(Token = "0x6002914")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return default(System.TimeSpan);
			}
		}

		// Token: 0x0400174B RID: 5963
		[Token(Token = "0x400174B")]
		[FieldOffset(Offset = "0x10")]
		private readonly System.DateTime _start;

		// Token: 0x0400174C RID: 5964
		[Token(Token = "0x400174C")]
		[FieldOffset(Offset = "0x18")]
		private readonly System.DateTime _end;

		// Token: 0x0400174D RID: 5965
		[Token(Token = "0x400174D")]
		[FieldOffset(Offset = "0x20")]
		private readonly System.TimeSpan _delta;
	}
}
