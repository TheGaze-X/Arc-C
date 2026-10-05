using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001292 RID: 4754
	[Token(Token = "0x2001292")]
	public class SandboxV2WeatherData
	{
		// Token: 0x0600720A RID: 29194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2WeatherData()
		{
		}

		// Token: 0x040068C7 RID: 26823
		[Token(Token = "0x40068C7")]
		[FieldOffset(Offset = "0x10")]
		public string weatherId;

		// Token: 0x040068C8 RID: 26824
		[Token(Token = "0x40068C8")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040068C9 RID: 26825
		[Token(Token = "0x40068C9")]
		[FieldOffset(Offset = "0x20")]
		public int weatherLevel;

		// Token: 0x040068CA RID: 26826
		[Token(Token = "0x40068CA")]
		[FieldOffset(Offset = "0x24")]
		public SandboxV2WeatherType weatherType;

		// Token: 0x040068CB RID: 26827
		[Token(Token = "0x40068CB")]
		[FieldOffset(Offset = "0x28")]
		public string weatherTypeName;

		// Token: 0x040068CC RID: 26828
		[Token(Token = "0x40068CC")]
		[FieldOffset(Offset = "0x30")]
		public string weatherIconId;

		// Token: 0x040068CD RID: 26829
		[Token(Token = "0x40068CD")]
		[FieldOffset(Offset = "0x38")]
		public string functionDesc;

		// Token: 0x040068CE RID: 26830
		[Token(Token = "0x40068CE")]
		[FieldOffset(Offset = "0x40")]
		public string description;

		// Token: 0x040068CF RID: 26831
		[Token(Token = "0x40068CF")]
		[FieldOffset(Offset = "0x48")]
		public string buffId;
	}
}
