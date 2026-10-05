using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A76 RID: 31350
	[Token(Token = "0x2007A76")]
	public class CharmModel
	{
		// Token: 0x0602BEA0 RID: 179872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEA0")]
		[Address(RVA = "0x13D53A0", Offset = "0x13D3FA0", VA = "0x1813D53A0")]
		public CharmModel(CharmItemData charmData, int cnt = 0)
		{
		}

		// Token: 0x170066FC RID: 26364
		// (get) Token: 0x0602BEA1 RID: 179873 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BEA2 RID: 179874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066FC")]
		public CharmItemData data
		{
			[Token(Token = "0x602BEA1")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602BEA2")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170066FD RID: 26365
		// (get) Token: 0x0602BEA3 RID: 179875 RVA: 0x000DDAC0 File Offset: 0x000DBCC0
		// (set) Token: 0x0602BEA4 RID: 179876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066FD")]
		public int count
		{
			[Token(Token = "0x602BEA3")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602BEA4")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602BEA5 RID: 179877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEA5")]
		[Address(RVA = "0x27D4B20", Offset = "0x27D3720", VA = "0x1827D4B20")]
		public void RefreshStatus()
		{
		}

		// Token: 0x0403F98D RID: 260493
		[Token(Token = "0x403F98D")]
		[FieldOffset(Offset = "0x1C")]
		public bool newUnlock;

		// Token: 0x0403F98E RID: 260494
		[Token(Token = "0x403F98E")]
		[FieldOffset(Offset = "0x1D")]
		public bool selected;

		// Token: 0x0403F98F RID: 260495
		[Token(Token = "0x403F98F")]
		[FieldOffset(Offset = "0x20")]
		public int typeSelIdx;
	}
}
