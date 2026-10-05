using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class SettingsBindableAttribute : Attribute
	{
		// Token: 0x06000CD3 RID: 3283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public SettingsBindableAttribute(bool bindable)
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x170002A7")]
		public bool Bindable
		{
			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x5173CA0", Offset = "0x51728A0", VA = "0x185173CA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x000071E8 File Offset: 0x000053E8
		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x5173D40", Offset = "0x5172940", VA = "0x185173D40", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SettingsBindableAttribute Yes;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x8")]
		public static readonly SettingsBindableAttribute No;
	}
}
