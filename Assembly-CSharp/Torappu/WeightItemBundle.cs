using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020010B9 RID: 4281
	[Token(Token = "0x20010B9")]
	[Serializable]
	public class WeightItemBundle
	{
		// Token: 0x06006E51 RID: 28241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E51")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WeightItemBundle()
		{
		}

		// Token: 0x06006E52 RID: 28242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E52")]
		[Address(RVA = "0x2117A20", Offset = "0x2116620", VA = "0x182117A20")]
		public WeightItemBundle(string itemId_, ItemType itemType_, int count_, int weight_, StageDropType dropType_)
		{
		}

		// Token: 0x04005BA3 RID: 23459
		[Token(Token = "0x4005BA3")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005BA4 RID: 23460
		[Token(Token = "0x4005BA4")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;

		// Token: 0x04005BA5 RID: 23461
		[Token(Token = "0x4005BA5")]
		[FieldOffset(Offset = "0x1C")]
		public StageDropType dropType;

		// Token: 0x04005BA6 RID: 23462
		[Token(Token = "0x4005BA6")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x04005BA7 RID: 23463
		[Token(Token = "0x4005BA7")]
		[FieldOffset(Offset = "0x24")]
		public int weight;
	}
}
