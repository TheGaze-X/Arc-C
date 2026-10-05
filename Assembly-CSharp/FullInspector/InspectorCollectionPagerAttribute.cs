using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BF2 RID: 31730
	[Token(Token = "0x2007BF2")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorCollectionPagerAttribute : Attribute
	{
		// Token: 0x170067FD RID: 26621
		// (get) Token: 0x0602C65B RID: 181851 RVA: 0x000DFF98 File Offset: 0x000DE198
		// (set) Token: 0x0602C65A RID: 181850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067FD")]
		public bool AlwaysHide
		{
			[Token(Token = "0x602C65B")]
			[Address(RVA = "0x1EF14C0", Offset = "0x1EF00C0", VA = "0x181EF14C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C65A")]
			[Address(RVA = "0x2861240", Offset = "0x285FE40", VA = "0x182861240")]
			set
			{
			}
		}

		// Token: 0x170067FE RID: 26622
		// (get) Token: 0x0602C65D RID: 181853 RVA: 0x000DFFB0 File Offset: 0x000DE1B0
		// (set) Token: 0x0602C65C RID: 181852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067FE")]
		public bool AlwaysShow
		{
			[Token(Token = "0x602C65D")]
			[Address(RVA = "0x9262F0", Offset = "0x924EF0", VA = "0x1809262F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C65C")]
			[Address(RVA = "0x28612C0", Offset = "0x285FEC0", VA = "0x1828612C0")]
			set
			{
			}
		}

		// Token: 0x0602C65E RID: 181854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C65E")]
		[Address(RVA = "0x28611D0", Offset = "0x285FDD0", VA = "0x1828611D0")]
		public InspectorCollectionPagerAttribute()
		{
		}

		// Token: 0x0602C65F RID: 181855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C65F")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public InspectorCollectionPagerAttribute(int pageMinimumCollectionLength)
		{
		}

		// Token: 0x04040292 RID: 262802
		[Token(Token = "0x4040292")]
		[FieldOffset(Offset = "0x10")]
		public int PageMinimumCollectionLength;
	}
}
