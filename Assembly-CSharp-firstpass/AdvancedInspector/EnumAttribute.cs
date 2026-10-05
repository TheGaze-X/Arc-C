using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class EnumAttribute : Attribute, IListAttribute
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000021C0 File Offset: 0x000003C0
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public bool Masked
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public EnumDisplay Display
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return EnumDisplay.DropDown;
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000021F0 File Offset: 0x000003F0
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public int MaxItemsPerRow
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x4EEB00", Offset = "0x4ED700", VA = "0x1804EEB00")]
		public EnumAttribute(bool masked)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x4EEA90", Offset = "0x4ED690", VA = "0x1804EEA90")]
		public EnumAttribute(EnumDisplay display)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x4EEAC0", Offset = "0x4ED6C0", VA = "0x1804EEAC0")]
		public EnumAttribute(bool masked, EnumDisplay display)
		{
		}

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x10")]
		private bool masked;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x14")]
		private EnumDisplay display;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		private int maxItemsPerRow;
	}
}
