using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Stage.Campaign
{
	// Token: 0x02006A4A RID: 27210
	[Token(Token = "0x2006A4A")]
	public class LadderItem
	{
		// Token: 0x17005BB7 RID: 23479
		// (get) Token: 0x06026E46 RID: 159302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005BB7")]
		public List<int> dataList
		{
			[Token(Token = "0x6026E46")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005BB8 RID: 23480
		// (get) Token: 0x06026E47 RID: 159303 RVA: 0x000CC990 File Offset: 0x000CAB90
		[Token(Token = "0x17005BB8")]
		public LadderItem.Type type
		{
			[Token(Token = "0x6026E47")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return LadderItem.Type.KILL_CNT;
			}
		}

		// Token: 0x06026E48 RID: 159304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E48")]
		[Address(RVA = "0x21EA350", Offset = "0x21E8F50", VA = "0x1821EA350")]
		public LadderItem(LadderItem.Type type)
		{
		}

		// Token: 0x06026E49 RID: 159305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E49")]
		[Address(RVA = "0x21EA2B0", Offset = "0x21E8EB0", VA = "0x1821EA2B0")]
		public void AddData(int val)
		{
		}

		// Token: 0x04036FF9 RID: 225273
		[Token(Token = "0x4036FF9")]
		[FieldOffset(Offset = "0x10")]
		private LadderItem.Type m_type;

		// Token: 0x04036FFA RID: 225274
		[Token(Token = "0x4036FFA")]
		[FieldOffset(Offset = "0x18")]
		private List<int> m_dataList;

		// Token: 0x02006A4B RID: 27211
		[Token(Token = "0x2006A4B")]
		public enum Type
		{
			// Token: 0x04036FFC RID: 225276
			[Token(Token = "0x4036FFC")]
			KILL_CNT,
			// Token: 0x04036FFD RID: 225277
			[Token(Token = "0x4036FFD")]
			AP_RETURN,
			// Token: 0x04036FFE RID: 225278
			[Token(Token = "0x4036FFE")]
			DIAMOND_GAIN
		}
	}
}
