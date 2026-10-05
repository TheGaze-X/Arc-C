using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class DisplayAsParentAttribute : Attribute
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public bool HideParent
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4EEA80", Offset = "0x4ED680", VA = "0x1804EEA80")]
		public DisplayAsParentAttribute()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x4EEA50", Offset = "0x4ED650", VA = "0x1804EEA50")]
		public DisplayAsParentAttribute(bool hideParent)
		{
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x10")]
		private bool hideParent;
	}
}
