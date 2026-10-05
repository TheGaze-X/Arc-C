using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A75 RID: 14965
	[Token(Token = "0x2003A75")]
	public class UISimpleTabPagerHandler : UITabPagerWrapper.ITabPagerWrapperHost, IHotfixable
	{
		// Token: 0x06017A8F RID: 96911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A8F")]
		[Address(RVA = "0xFF7850", Offset = "0xFF6450", VA = "0x180FF7850")]
		private UISimpleTabPagerHandler()
		{
		}

		// Token: 0x06017A90 RID: 96912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A90")]
		[Address(RVA = "0xFF7670", Offset = "0xFF6270", VA = "0x180FF7670")]
		public UISimpleTabPagerHandler(UISimpleTabPagerHandler.Option option)
		{
		}

		// Token: 0x06017A91 RID: 96913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A91")]
		[Address(RVA = "0xFF6E70", Offset = "0xFF5A70", VA = "0x180FF6E70")]
		public void Dispose()
		{
		}

		// Token: 0x06017A92 RID: 96914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A92")]
		[Address(RVA = "0xFF7470", Offset = "0xFF6070", VA = "0x180FF7470")]
		public void SelectTab(string tabId)
		{
		}

		// Token: 0x06017A93 RID: 96915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017A93")]
		[Address(RVA = "0xFF6F90", Offset = "0xFF5B90", VA = "0x180FF6F90")]
		public string GetSelectTabId()
		{
			return null;
		}

		// Token: 0x06017A94 RID: 96916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A94")]
		[Address(RVA = "0xFF6DC0", Offset = "0xFF59C0", VA = "0x180FF6DC0")]
		public void ClearSelection()
		{
		}

		// Token: 0x06017A95 RID: 96917 RVA: 0x00097968 File Offset: 0x00095B68
		[Token(Token = "0x6017A95")]
		[Address(RVA = "0xFF72D0", Offset = "0xFF5ED0", VA = "0x180FF72D0")]
		public bool IsStable()
		{
			return default(bool);
		}

		// Token: 0x06017A96 RID: 96918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A96")]
		[Address(RVA = "0xFF7380", Offset = "0xFF5F80", VA = "0x180FF7380")]
		public void ReLoadData([Optional] UITabPager.LoadOptions loadOptions)
		{
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x06017A97 RID: 96919 RVA: 0x00097980 File Offset: 0x00095B80
		[Token(Token = "0x170038C8")]
		public int tabCount
		{
			[Token(Token = "0x6017A97")]
			[Address(RVA = "0xFF7990", Offset = "0xFF6590", VA = "0x180FF7990", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x06017A98 RID: 96920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038C9")]
		public string defaultTab
		{
			[Token(Token = "0x6017A98")]
			[Address(RVA = "0xFF7930", Offset = "0xFF6530", VA = "0x180FF7930", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017A99 RID: 96921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017A99")]
		[Address(RVA = "0xFF70E0", Offset = "0xFF5CE0", VA = "0x180FF70E0", Slot = "6")]
		public string GetTabId(int index)
		{
			return null;
		}

		// Token: 0x06017A9A RID: 96922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017A9A")]
		[Address(RVA = "0xFF7230", Offset = "0xFF5E30", VA = "0x180FF7230", Slot = "7")]
		public string GetTabResPath(int index)
		{
			return null;
		}

		// Token: 0x06017A9B RID: 96923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017A9B")]
		[Address(RVA = "0xFF7040", Offset = "0xFF5C40", VA = "0x180FF7040", Slot = "8")]
		public Type GetTabDialogType(int index)
		{
			return null;
		}

		// Token: 0x06017A9C RID: 96924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017A9C")]
		[Address(RVA = "0xFF7180", Offset = "0xFF5D80", VA = "0x180FF7180", Slot = "9")]
		public object GetTabInput(int index)
		{
			return null;
		}

		// Token: 0x06017A9D RID: 96925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017A9D")]
		[Address(RVA = "0xFF7530", Offset = "0xFF6130", VA = "0x180FF7530", Slot = "10")]
		public CustomYieldInstruction TabPagerCallback(int index, ValueBundle output)
		{
			return null;
		}

		// Token: 0x0401C8BF RID: 116927
		[Token(Token = "0x401C8BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<UISimpleTabPagerHandler.TabPagerDialogConfig> m_dialogConfigs;

		// Token: 0x0401C8C0 RID: 116928
		[Token(Token = "0x401C8C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_defaultTabId;

		// Token: 0x0401C8C1 RID: 116929
		[Token(Token = "0x401C8C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UITabPagerWrapper m_tabPagerWrapper;

		// Token: 0x0401C8C2 RID: 116930
		[Token(Token = "0x401C8C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C8C3 RID: 116931
		[Token(Token = "0x401C8C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x0401C8C4 RID: 116932
		[Token(Token = "0x401C8C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401C8C5 RID: 116933
		[Token(Token = "0x401C8C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectTab;

		// Token: 0x0401C8C6 RID: 116934
		[Token(Token = "0x401C8C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSelectTabId;

		// Token: 0x0401C8C7 RID: 116935
		[Token(Token = "0x401C8C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClearSelection;

		// Token: 0x0401C8C8 RID: 116936
		[Token(Token = "0x401C8C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsStable;

		// Token: 0x0401C8C9 RID: 116937
		[Token(Token = "0x401C8C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ReLoadData;

		// Token: 0x0401C8CA RID: 116938
		[Token(Token = "0x401C8CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_tabCount;

		// Token: 0x0401C8CB RID: 116939
		[Token(Token = "0x401C8CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_defaultTab;

		// Token: 0x0401C8CC RID: 116940
		[Token(Token = "0x401C8CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetTabId;

		// Token: 0x0401C8CD RID: 116941
		[Token(Token = "0x401C8CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetTabResPath;

		// Token: 0x0401C8CE RID: 116942
		[Token(Token = "0x401C8CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetTabDialogType;

		// Token: 0x0401C8CF RID: 116943
		[Token(Token = "0x401C8CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetTabInput;

		// Token: 0x0401C8D0 RID: 116944
		[Token(Token = "0x401C8D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TabPagerCallback;

		// Token: 0x02003A76 RID: 14966
		[Token(Token = "0x2003A76")]
		public class TabPagerDialogConfig
		{
			// Token: 0x06017A9E RID: 96926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A9E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TabPagerDialogConfig()
			{
			}

			// Token: 0x0401C8D1 RID: 116945
			[Token(Token = "0x401C8D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string tabId;

			// Token: 0x0401C8D2 RID: 116946
			[Token(Token = "0x401C8D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string resPath;

			// Token: 0x0401C8D3 RID: 116947
			[Token(Token = "0x401C8D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Type dialogType;

			// Token: 0x0401C8D4 RID: 116948
			[Token(Token = "0x401C8D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Func<object> tabInputFuc;

			// Token: 0x0401C8D5 RID: 116949
			[Token(Token = "0x401C8D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Func<ValueBundle, CustomYieldInstruction> tabCallback;
		}

		// Token: 0x02003A77 RID: 14967
		[Token(Token = "0x2003A77")]
		public struct Option
		{
			// Token: 0x0401C8D6 RID: 116950
			[Token(Token = "0x401C8D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UITabPager tabPager;

			// Token: 0x0401C8D7 RID: 116951
			[Token(Token = "0x401C8D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public UnityEngine.Object dlgHost;

			// Token: 0x0401C8D8 RID: 116952
			[Token(Token = "0x401C8D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<UISimpleTabPagerHandler.TabPagerDialogConfig> dialogConfigs;

			// Token: 0x0401C8D9 RID: 116953
			[Token(Token = "0x401C8D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string defaultSelectTabId;

			// Token: 0x0401C8DA RID: 116954
			[Token(Token = "0x401C8DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<Camera> cameras;
		}
	}
}
