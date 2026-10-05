using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B62 RID: 2914
	[Token(Token = "0x2000B62")]
	public class TowerTactical
	{
		// Token: 0x06006802 RID: 26626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006802")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TowerTactical()
		{
		}

		// Token: 0x04003CA1 RID: 15521
		[Token(Token = "0x4003CA1")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "PIONEER")]
		public string pioneer;

		// Token: 0x04003CA2 RID: 15522
		[Token(Token = "0x4003CA2")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "WARRIOR")]
		public string warrior;

		// Token: 0x04003CA3 RID: 15523
		[Token(Token = "0x4003CA3")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty(PropertyName = "TANK")]
		public string tank;

		// Token: 0x04003CA4 RID: 15524
		[Token(Token = "0x4003CA4")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty(PropertyName = "SNIPER")]
		public string sniper;

		// Token: 0x04003CA5 RID: 15525
		[Token(Token = "0x4003CA5")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty(PropertyName = "CASTER")]
		public string caster;

		// Token: 0x04003CA6 RID: 15526
		[Token(Token = "0x4003CA6")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty(PropertyName = "SUPPORT")]
		public string support;

		// Token: 0x04003CA7 RID: 15527
		[Token(Token = "0x4003CA7")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty(PropertyName = "MEDIC")]
		public string medic;

		// Token: 0x04003CA8 RID: 15528
		[Token(Token = "0x4003CA8")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty(PropertyName = "SPECIAL")]
		public string special;
	}
}
