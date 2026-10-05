using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu.Audio.Engine.FMOD
{
	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public class ParamData
	{
		// Token: 0x06000E47 RID: 3655 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ParamData()
		{
		}

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x10")]
		public string property;

		// Token: 0x04000EDA RID: 3802
		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public AudioParamValueTrans trans;
	}
}
