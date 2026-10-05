using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020069D4 RID: 27092
	[Token(Token = "0x20069D4")]
	public class ZoneGroupViewModel
	{
		// Token: 0x06026C21 RID: 158753 RVA: 0x000CC330 File Offset: 0x000CA530
		[Token(Token = "0x6026C21")]
		[Address(RVA = "0x21DB1C0", Offset = "0x21D9DC0", VA = "0x1821DB1C0")]
		public bool CheckIfZoneEdged(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06026C22 RID: 158754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C22")]
		[Address(RVA = "0x21DB2E0", Offset = "0x21D9EE0", VA = "0x1821DB2E0")]
		public ZoneViewModel FindFirstLockedZone()
		{
			return null;
		}

		// Token: 0x06026C23 RID: 158755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C23")]
		[Address(RVA = "0x21DB390", Offset = "0x21D9F90", VA = "0x1821DB390")]
		public ZoneViewModel FindLastUnlockZone()
		{
			return null;
		}

		// Token: 0x06026C24 RID: 158756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C24")]
		[Address(RVA = "0x21DB420", Offset = "0x21DA020", VA = "0x1821DB420")]
		public ZoneViewModel FindZone(string zoneId)
		{
			return null;
		}

		// Token: 0x06026C25 RID: 158757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C25")]
		[Address(RVA = "0x21DB4F0", Offset = "0x21DA0F0", VA = "0x1821DB4F0")]
		public ZoneGroupViewModel()
		{
		}

		// Token: 0x04036BF4 RID: 224244
		[Token(Token = "0x4036BF4")]
		[FieldOffset(Offset = "0x10")]
		public ZoneType zoneType;

		// Token: 0x04036BF5 RID: 224245
		[Token(Token = "0x4036BF5")]
		[FieldOffset(Offset = "0x14")]
		public ZoneViewType zoneViewType;

		// Token: 0x04036BF6 RID: 224246
		[Token(Token = "0x4036BF6")]
		[FieldOffset(Offset = "0x18")]
		public string focusZoneId;

		// Token: 0x04036BF7 RID: 224247
		[Token(Token = "0x4036BF7")]
		[FieldOffset(Offset = "0x20")]
		public List<ZoneViewModel> zones;
	}
}
