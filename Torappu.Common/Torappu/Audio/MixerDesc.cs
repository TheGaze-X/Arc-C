using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu.Audio
{
	// Token: 0x0200025A RID: 602
	[Token(Token = "0x200025A")]
	public struct MixerDesc
	{
		// Token: 0x06000DC8 RID: 3528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x5583A00", Offset = "0x5582600", VA = "0x185583A00")]
		public string CreateSign()
		{
			return null;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00008E64 File Offset: 0x00007064
		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x5583AE0", Offset = "0x55826E0", VA = "0x185583AE0")]
		public static bool Same(MixerDesc lhs, MixerDesc rhs)
		{
			return default(bool);
		}

		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MixerDesc MASTER;

		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		[FieldOffset(Offset = "0x0")]
		public MixerDesc.Category category;

		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0x8")]
		public string customGroup;

		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x10")]
		public bool important;

		// Token: 0x0200025B RID: 603
		[Token(Token = "0x200025B")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum Category
		{
			// Token: 0x04000E6F RID: 3695
			[Token(Token = "0x4000E6F")]
			CUSTOM,
			// Token: 0x04000E70 RID: 3696
			[Token(Token = "0x4000E70")]
			FX_UI,
			// Token: 0x04000E71 RID: 3697
			[Token(Token = "0x4000E71")]
			FX_BATTLE,
			// Token: 0x04000E72 RID: 3698
			[Token(Token = "0x4000E72")]
			MUSIC,
			// Token: 0x04000E73 RID: 3699
			[Token(Token = "0x4000E73")]
			VOICE,
			// Token: 0x04000E74 RID: 3700
			[Token(Token = "0x4000E74")]
			MASTER
		}
	}
}
