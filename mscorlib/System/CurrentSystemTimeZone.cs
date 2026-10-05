using System;
using System.Collections;
using System.Globalization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	[System.Obsolete("System.CurrentSystemTimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo.Local instead.")]
	[System.Serializable]
	internal class CurrentSystemTimeZone : System.TimeZone
	{
		// Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x4CB5130", Offset = "0x4CB3D30", VA = "0x184CB5130")]
		internal CurrentSystemTimeZone()
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x4CB4EA0", Offset = "0x4CB3AA0", VA = "0x184CB4EA0", Slot = "5")]
		public override System.Globalization.DaylightTime GetDaylightChanges(int year)
		{
			return null;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x4CB48C0", Offset = "0x4CB34C0", VA = "0x184CB48C0")]
		private static System.Globalization.DaylightTime CreateDaylightChanges(int year)
		{
			return null;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00006450 File Offset: 0x00004650
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x4CB4F90", Offset = "0x4CB3B90", VA = "0x184CB4F90", Slot = "4")]
		public override System.TimeSpan GetUtcOffset(System.DateTime time)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x4CB4C20", Offset = "0x4CB3820", VA = "0x184CB4C20")]
		private System.Globalization.DaylightTime GetCachedDaylightChanges(int year)
		{
			return null;
		}

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x10")]
		private long m_ticksOffset;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x18")]
		private string m_standardName;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x20")]
		private string m_daylightName;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x28")]
		private readonly System.Collections.Hashtable m_CachedDaylightChanges;
	}
}
