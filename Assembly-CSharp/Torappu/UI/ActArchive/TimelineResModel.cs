using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C3C RID: 27708
	[Token(Token = "0x2006C3C")]
	public class TimelineResModel<T> where T : ArchiveItemModel
	{
		// Token: 0x17005D5D RID: 23901
		// (get) Token: 0x060278D8 RID: 162008 RVA: 0x000CEAC0 File Offset: 0x000CCCC0
		[Token(Token = "0x17005D5D")]
		public int stackNum
		{
			[Token(Token = "0x60278D8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005D5E RID: 23902
		// (get) Token: 0x060278D9 RID: 162009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D5E")]
		public T topItem
		{
			[Token(Token = "0x60278D9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D5F RID: 23903
		// (get) Token: 0x060278DA RID: 162010 RVA: 0x000CEAD8 File Offset: 0x000CCCD8
		[Token(Token = "0x17005D5F")]
		public bool locked
		{
			[Token(Token = "0x60278DA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005D60 RID: 23904
		// (get) Token: 0x060278DB RID: 162011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D60")]
		public string lockedToast
		{
			[Token(Token = "0x60278DB")]
			get
			{
				return null;
			}
		}

		// Token: 0x060278DC RID: 162012 RVA: 0x000CEAF0 File Offset: 0x000CCCF0
		[Token(Token = "0x60278DC")]
		public bool IsChecked()
		{
			return default(bool);
		}

		// Token: 0x060278DD RID: 162013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278DD")]
		public TimelineResModel()
		{
		}

		// Token: 0x04038157 RID: 229719
		[Token(Token = "0x4038157")]
		[FieldOffset(Offset = "0x0")]
		public List<T> items;
	}
}
