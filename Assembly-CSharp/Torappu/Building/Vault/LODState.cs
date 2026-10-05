using System;
using Il2CppDummyDll;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A10 RID: 6672
	[Token(Token = "0x2001A10")]
	public class LODState
	{
		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x0600A73C RID: 42812 RVA: 0x00040B30 File Offset: 0x0003ED30
		[Token(Token = "0x1700134B")]
		public bool dirty
		{
			[Token(Token = "0x600A73C")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x00040B48 File Offset: 0x0003ED48
		// (set) Token: 0x0600A73E RID: 42814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700134C")]
		public int lodValue
		{
			[Token(Token = "0x600A73D")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600A73E")]
			[Address(RVA = "0x3224E50", Offset = "0x3223A50", VA = "0x183224E50")]
			set
			{
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x0600A73F RID: 42815 RVA: 0x00040B60 File Offset: 0x0003ED60
		[Token(Token = "0x1700134D")]
		public BuildingData.LODLEVEL lodLevel
		{
			[Token(Token = "0x600A73F")]
			[Address(RVA = "0x3224DC0", Offset = "0x32239C0", VA = "0x183224DC0")]
			get
			{
				return BuildingData.LODLEVEL.HIGHEST;
			}
		}

		// Token: 0x0600A740 RID: 42816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A740")]
		[Address(RVA = "0x3224DB0", Offset = "0x32239B0", VA = "0x183224DB0")]
		public LODState()
		{
		}

		// Token: 0x04009F6D RID: 40813
		[Token(Token = "0x4009F6D")]
		[FieldOffset(Offset = "0x10")]
		private int m_lodValue;

		// Token: 0x04009F6E RID: 40814
		[Token(Token = "0x4009F6E")]
		[FieldOffset(Offset = "0x14")]
		private BuildingData.LODLEVEL m_level;

		// Token: 0x04009F6F RID: 40815
		[Token(Token = "0x4009F6F")]
		[FieldOffset(Offset = "0x18")]
		private bool m_dirty;
	}
}
