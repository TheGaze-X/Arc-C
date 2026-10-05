using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012C9 RID: 4809
	[Token(Token = "0x20012C9")]
	public class SandboxV2LogisticsData
	{
		// Token: 0x06007242 RID: 29250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007242")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2LogisticsData()
		{
		}

		// Token: 0x04006A3B RID: 27195
		[Token(Token = "0x4006A3B")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006A3C RID: 27196
		[Token(Token = "0x4006A3C")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x04006A3D RID: 27197
		[Token(Token = "0x4006A3D")]
		[FieldOffset(Offset = "0x20")]
		public string noBuffDesc;

		// Token: 0x04006A3E RID: 27198
		[Token(Token = "0x4006A3E")]
		[FieldOffset(Offset = "0x28")]
		public string iconId;

		// Token: 0x04006A3F RID: 27199
		[Token(Token = "0x4006A3F")]
		[FieldOffset(Offset = "0x30")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ProfessionCategory profession;

		// Token: 0x04006A40 RID: 27200
		[Token(Token = "0x4006A40")]
		[FieldOffset(Offset = "0x34")]
		public int sortId;

		// Token: 0x04006A41 RID: 27201
		[Token(Token = "0x4006A41")]
		[FieldOffset(Offset = "0x38")]
		public string[] levelParams;
	}
}
