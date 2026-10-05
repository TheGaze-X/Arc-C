using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	[Preserve]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000018")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
			get
			{
				return MemberSerialization.OptOut;
			}
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x509F70", Offset = "0x508B70", VA = "0x180509F70")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002190 File Offset: 0x00000390
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000019")]
		public Required ItemRequired
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x4D65DE0", Offset = "0x4D649E0", VA = "0x184D65DE0")]
			get
			{
				return Required.Default;
			}
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x4D65E30", Offset = "0x4D64A30", VA = "0x184D65E30")]
			set
			{
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public JsonObjectAttribute()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x4D65DB0", Offset = "0x4D649B0", VA = "0x184D65DB0")]
		public JsonObjectAttribute(MemberSerialization memberSerialization)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public JsonObjectAttribute(string id)
		{
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x50")]
		private MemberSerialization _memberSerialization;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x54")]
		internal Required? _itemRequired;
	}
}
