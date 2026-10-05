using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012A3 RID: 4771
	[Token(Token = "0x20012A3")]
	public class SandboxV2FoodMatData
	{
		// Token: 0x0600721B RID: 29211 RVA: 0x00032C58 File Offset: 0x00030E58
		[Token(Token = "0x600721B")]
		[Address(RVA = "0x1FF9BE0", Offset = "0x1FF87E0", VA = "0x181FF9BE0")]
		public bool ShouldSerializeattribute()
		{
			return default(bool);
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x00032C70 File Offset: 0x00030E70
		[Token(Token = "0x600721C")]
		[Address(RVA = "0x1FF92B0", Offset = "0x1FF7EB0", VA = "0x181FF92B0")]
		public bool ShouldSerializevariantType()
		{
			return default(bool);
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x00032C88 File Offset: 0x00030E88
		[Token(Token = "0x600721D")]
		[Address(RVA = "0x22101D0", Offset = "0x220EDD0", VA = "0x1822101D0")]
		public bool ShouldSerializebonusDuration()
		{
			return default(bool);
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x00032CA0 File Offset: 0x00030EA0
		[Token(Token = "0x600721E")]
		[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0")]
		public bool ShouldSerializebuffDesc()
		{
			return default(bool);
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600721F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2FoodMatData()
		{
		}

		// Token: 0x0400691F RID: 26911
		[Token(Token = "0x400691F")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006920 RID: 26912
		[Token(Token = "0x4006920")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2FoodMatType type;

		// Token: 0x04006921 RID: 26913
		[Token(Token = "0x4006921")]
		[FieldOffset(Offset = "0x1C")]
		public SandboxV2FoodAttribute attribute;

		// Token: 0x04006922 RID: 26914
		[Token(Token = "0x4006922")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2FoodVariantType variantType;

		// Token: 0x04006923 RID: 26915
		[Token(Token = "0x4006923")]
		[FieldOffset(Offset = "0x24")]
		public int bonusDuration;

		// Token: 0x04006924 RID: 26916
		[Token(Token = "0x4006924")]
		[FieldOffset(Offset = "0x28")]
		public string buffDesc;

		// Token: 0x04006925 RID: 26917
		[Token(Token = "0x4006925")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;
	}
}
