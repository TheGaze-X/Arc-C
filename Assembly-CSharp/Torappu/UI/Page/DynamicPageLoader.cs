using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Page
{
	// Token: 0x02005A5D RID: 23133
	[Token(Token = "0x2005A5D")]
	public class DynamicPageLoader : IUIPageRouter
	{
		// Token: 0x06021A9F RID: 137887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A9F")]
		[Address(RVA = "0x1C1A0D0", Offset = "0x1C18CD0", VA = "0x181C1A0D0")]
		public DynamicPageLoader(UIDynamicPageHub dynamicPageHub)
		{
		}

		// Token: 0x06021AA0 RID: 137888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AA0")]
		[Address(RVA = "0x1C19930", Offset = "0x1C18530", VA = "0x181C19930")]
		public void AddPageConfigs(UIDynamicPageHub newHub)
		{
		}

		// Token: 0x06021AA1 RID: 137889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021AA1")]
		[Address(RVA = "0x1C199A0", Offset = "0x1C185A0", VA = "0x181C199A0", Slot = "4")]
		public IEnumerable<IUIPageConfig> EnumPages()
		{
			return null;
		}

		// Token: 0x06021AA2 RID: 137890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021AA2")]
		[Address(RVA = "0x1C19A20", Offset = "0x1C18620", VA = "0x181C19A20", Slot = "5")]
		public IUIPageConfig GetPageByName(string name)
		{
			return null;
		}

		// Token: 0x06021AA3 RID: 137891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AA3")]
		[Address(RVA = "0x1C19BF0", Offset = "0x1C187F0", VA = "0x181C19BF0")]
		private void _AddPageConfigsByHub(UIDynamicPageHub dynamicPageHub)
		{
		}

		// Token: 0x06021AA4 RID: 137892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AA4")]
		[Address(RVA = "0x1C19D60", Offset = "0x1C18960", VA = "0x181C19D60")]
		private void _LoadDynamicPagesFromActAssetMap()
		{
		}

		// Token: 0x06021AA5 RID: 137893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021AA5")]
		[Address(RVA = "0x1C19FE0", Offset = "0x1C18BE0", VA = "0x181C19FE0")]
		private UIPage _LoadPageAsset(string name, string resPath)
		{
			return null;
		}

		// Token: 0x06021AA6 RID: 137894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AA6")]
		[Address(RVA = "0x1C19A80", Offset = "0x1C18680", VA = "0x181C19A80")]
		public void UnloadUnusedPages(IList<string> usedPages)
		{
		}

		// Token: 0x0402E065 RID: 188517
		[Token(Token = "0x402E065")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, IUIPageConfig> m_configs;

		// Token: 0x0402E066 RID: 188518
		[Token(Token = "0x402E066")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, UIPage> m_loadedPages;

		// Token: 0x02005A5E RID: 23134
		[Token(Token = "0x2005A5E")]
		public class DynamicPageConfig : IUIPageConfig
		{
			// Token: 0x06021AA7 RID: 137895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021AA7")]
			[Address(RVA = "0x1C198C0", Offset = "0x1C184C0", VA = "0x181C198C0")]
			public DynamicPageConfig(DynamicPageLoader loader, string name, string resPath)
			{
			}

			// Token: 0x06021AA8 RID: 137896 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021AA8")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			public string GetName()
			{
				return null;
			}

			// Token: 0x06021AA9 RID: 137897 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021AA9")]
			[Address(RVA = "0x1C197C0", Offset = "0x1C183C0", VA = "0x181C197C0", Slot = "5")]
			public UIPage LoadPage()
			{
				return null;
			}

			// Token: 0x0402E067 RID: 188519
			[Token(Token = "0x402E067")]
			[FieldOffset(Offset = "0x10")]
			private string m_name;

			// Token: 0x0402E068 RID: 188520
			[Token(Token = "0x402E068")]
			[FieldOffset(Offset = "0x18")]
			private string m_resPath;

			// Token: 0x0402E069 RID: 188521
			[Token(Token = "0x402E069")]
			[FieldOffset(Offset = "0x20")]
			private DynamicPageLoader m_loader;
		}
	}
}
