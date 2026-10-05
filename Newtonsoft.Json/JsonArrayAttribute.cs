using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[Preserve]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonArrayAttribute : JsonContainerAttribute
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000C")]
		public bool AllowNullItems
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x150B0D0", Offset = "0x1509CD0", VA = "0x18150B0D0")]
			set
			{
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public JsonArrayAttribute()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x4D60EA0", Offset = "0x4D5FAA0", VA = "0x184D60EA0")]
		public JsonArrayAttribute(bool allowNullItems)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public JsonArrayAttribute(string id)
		{
		}

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x50")]
		private bool _allowNullItems;
	}
}
