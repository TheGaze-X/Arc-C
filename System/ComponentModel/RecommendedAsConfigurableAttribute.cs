using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	[AttributeUsage(AttributeTargets.Property)]
	[Obsolete("Use System.ComponentModel.SettingsBindableAttribute instead to work with the new settings model.")]
	public class RecommendedAsConfigurableAttribute : Attribute
	{
		// Token: 0x06000CA3 RID: 3235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public RecommendedAsConfigurableAttribute(bool recommendedAsConfigurable)
		{
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x1700029F")]
		public bool RecommendedAsConfigurable
		{
			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x5162620", Offset = "0x5161220", VA = "0x185162620", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000070B0 File Offset: 0x000052B0
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x160BEE0", Offset = "0x160AAE0", VA = "0x18160BEE0", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RecommendedAsConfigurableAttribute No;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x8")]
		public static readonly RecommendedAsConfigurableAttribute Yes;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x10")]
		public static readonly RecommendedAsConfigurableAttribute Default;
	}
}
