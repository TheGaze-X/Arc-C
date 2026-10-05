using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001F04 RID: 7940
	[Token(Token = "0x2001F04")]
	public class PostDisplayHandler : IDisposable
	{
		// Token: 0x0600C51D RID: 50461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C51D")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public PostDisplayHandler(PostDisplayItem item)
		{
		}

		// Token: 0x0600C51E RID: 50462 RVA: 0x000483F0 File Offset: 0x000465F0
		[Token(Token = "0x600C51E")]
		[Address(RVA = "0x3430720", Offset = "0x342F320", VA = "0x183430720")]
		public PostDisplayKey GetKey()
		{
			return default(PostDisplayKey);
		}

		// Token: 0x0600C51F RID: 50463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C51F")]
		[Address(RVA = "0x3430770", Offset = "0x342F370", VA = "0x183430770")]
		public void SetTextures(PostDisplayItem.Textures textures)
		{
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x0600C520 RID: 50464 RVA: 0x00048408 File Offset: 0x00046608
		[Token(Token = "0x1700177C")]
		public bool isDisposed
		{
			[Token(Token = "0x600C520")]
			[Address(RVA = "0x34307E0", Offset = "0x342F3E0", VA = "0x1834307E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C521 RID: 50465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C521")]
		[Address(RVA = "0x34306E0", Offset = "0x342F2E0", VA = "0x1834306E0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400C9A6 RID: 51622
		[Token(Token = "0x400C9A6")]
		[FieldOffset(Offset = "0x10")]
		private PostDisplayItem m_item;
	}
}
