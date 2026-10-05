using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057D9 RID: 22489
	[Token(Token = "0x20057D9")]
	public class ItemPool<T> where T : MonoBehaviour
	{
		// Token: 0x06020E4F RID: 134735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E4F")]
		public ItemPool(Func<T> creator)
		{
		}

		// Token: 0x06020E50 RID: 134736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E50")]
		public void Clear()
		{
		}

		// Token: 0x06020E51 RID: 134737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020E51")]
		public T FetchItem()
		{
			return null;
		}

		// Token: 0x17004D31 RID: 19761
		// (get) Token: 0x06020E52 RID: 134738 RVA: 0x000B7B40 File Offset: 0x000B5D40
		[Token(Token = "0x17004D31")]
		public int count
		{
			[Token(Token = "0x6020E52")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004D32 RID: 19762
		[Token(Token = "0x17004D32")]
		public T this[int index]
		{
			[Token(Token = "0x6020E53")]
			get
			{
				return null;
			}
		}

		// Token: 0x0402CB1B RID: 183067
		[Token(Token = "0x402CB1B")]
		[FieldOffset(Offset = "0x0")]
		private Func<T> m_creator;

		// Token: 0x0402CB1C RID: 183068
		[Token(Token = "0x402CB1C")]
		[FieldOffset(Offset = "0x0")]
		private List<T> m_items;

		// Token: 0x0402CB1D RID: 183069
		[Token(Token = "0x402CB1D")]
		[FieldOffset(Offset = "0x0")]
		private List<T> m_usingItems;
	}
}
