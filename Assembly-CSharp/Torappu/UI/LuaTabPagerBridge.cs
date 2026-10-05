using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A70 RID: 14960
	[Token(Token = "0x2003A70")]
	public class LuaTabPagerBridge : IHotfixable, ICompDialogCallBack
	{
		// Token: 0x06017A75 RID: 96885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A75")]
		[Address(RVA = "0xFEAEF0", Offset = "0xFE9AF0", VA = "0x180FEAEF0", Slot = "4")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06017A76 RID: 96886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017A76")]
		[Address(RVA = "0xFEAC80", Offset = "0xFE9880", VA = "0x180FEAC80", Slot = "5")]
		public CustomYieldInstruction HandleCallBackAsync(int instId, ValueBundle output)
		{
			return null;
		}

		// Token: 0x06017A77 RID: 96887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A77")]
		[Address(RVA = "0xFEB770", Offset = "0xFEA370", VA = "0x180FEB770")]
		private LuaTabPagerBridge()
		{
		}

		// Token: 0x06017A78 RID: 96888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A78")]
		[Address(RVA = "0xFEB030", Offset = "0xFE9C30", VA = "0x180FEB030")]
		private void _Init(LuaTabPagerBridge.ILuaObject impl, UITabPager pager, UnityEngine.Object dlgHost, Camera[] cameras)
		{
		}

		// Token: 0x06017A79 RID: 96889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A79")]
		[Address(RVA = "0xFEAF80", Offset = "0xFE9B80", VA = "0x180FEAF80")]
		private void _Dispose()
		{
		}

		// Token: 0x0401C8AD RID: 116909
		[Token(Token = "0x401C8AD")]
		[FieldOffset(Offset = "0x10")]
		private LuaTabPagerBridge.ILuaObject m_impl;

		// Token: 0x0401C8AE RID: 116910
		[Token(Token = "0x401C8AE")]
		[FieldOffset(Offset = "0x18")]
		private UITabPager.Core m_tabCore;

		// Token: 0x0401C8AF RID: 116911
		[Token(Token = "0x401C8AF")]
		[FieldOffset(Offset = "0x20")]
		private UITabPager m_tabPager;

		// Token: 0x0401C8B0 RID: 116912
		[Token(Token = "0x401C8B0")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, LuaTabPagerBridge.TabModel> m_tabModels;

		// Token: 0x0401C8B1 RID: 116913
		[Token(Token = "0x401C8B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0401C8B2 RID: 116914
		[Token(Token = "0x401C8B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleCallBackAsync;

		// Token: 0x0401C8B3 RID: 116915
		[Token(Token = "0x401C8B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C8B4 RID: 116916
		[Token(Token = "0x401C8B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0401C8B5 RID: 116917
		[Token(Token = "0x401C8B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Dispose;

		// Token: 0x02003A71 RID: 14961
		[Token(Token = "0x2003A71")]
		public interface ILuaObject : ICSharpCallLua
		{
			// Token: 0x06017A7A RID: 96890
			[Token(Token = "0x6017A7A")]
			int CSTabCount();

			// Token: 0x06017A7B RID: 96891
			[Token(Token = "0x6017A7B")]
			string CSDefaultTab();

			// Token: 0x06017A7C RID: 96892
			[Token(Token = "0x6017A7C")]
			string CSTabId(int indexFrom1);

			// Token: 0x06017A7D RID: 96893
			[Token(Token = "0x6017A7D")]
			string CSTabResPath(int indexFrom1);

			// Token: 0x06017A7E RID: 96894
			[Token(Token = "0x6017A7E")]
			Type CSTabDialogType(int indexFrom1);

			// Token: 0x06017A7F RID: 96895
			[Token(Token = "0x6017A7F")]
			object CSTabInput(int indexFrom1);

			// Token: 0x06017A80 RID: 96896
			[Token(Token = "0x6017A80")]
			ILuaAsyncInstruction CSCallback(int indexFrom1, ValueBundle output);
		}

		// Token: 0x02003A72 RID: 14962
		[Token(Token = "0x2003A72")]
		public class CallFromLua : ILuaCallCSharp
		{
			// Token: 0x06017A81 RID: 96897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A81")]
			[Address(RVA = "0xFE0FF0", Offset = "0xFDFBF0", VA = "0x180FE0FF0")]
			public CallFromLua()
			{
			}

			// Token: 0x06017A82 RID: 96898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A82")]
			[Address(RVA = "0xFE0F10", Offset = "0xFDFB10", VA = "0x180FE0F10")]
			public void Init(LuaTabPagerBridge.ILuaObject impl, UITabPager pager, UnityEngine.Object dlgHost, Camera[] cameras)
			{
			}

			// Token: 0x06017A83 RID: 96899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A83")]
			[Address(RVA = "0xFE0E20", Offset = "0xFDFA20", VA = "0x180FE0E20")]
			public void Dispose()
			{
			}

			// Token: 0x06017A84 RID: 96900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A84")]
			[Address(RVA = "0xFE0FC0", Offset = "0xFDFBC0", VA = "0x180FE0FC0")]
			public void SelectTab(string tabId)
			{
			}

			// Token: 0x06017A85 RID: 96901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A85")]
			[Address(RVA = "0xFE0EE0", Offset = "0xFDFAE0", VA = "0x180FE0EE0")]
			public string GetSelectTabId()
			{
				return null;
			}

			// Token: 0x06017A86 RID: 96902 RVA: 0x00097938 File Offset: 0x00095B38
			[Token(Token = "0x6017A86")]
			[Address(RVA = "0xFE0F40", Offset = "0xFDFB40", VA = "0x180FE0F40")]
			public bool IsStable()
			{
				return default(bool);
			}

			// Token: 0x06017A87 RID: 96903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A87")]
			[Address(RVA = "0xFE0DF0", Offset = "0xFDF9F0", VA = "0x180FE0DF0")]
			public void ClearSelection()
			{
			}

			// Token: 0x06017A88 RID: 96904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A88")]
			[Address(RVA = "0xFE0F70", Offset = "0xFDFB70", VA = "0x180FE0F70")]
			public void ReloadData()
			{
			}

			// Token: 0x0401C8B6 RID: 116918
			[Token(Token = "0x401C8B6")]
			[FieldOffset(Offset = "0x10")]
			private LuaTabPagerBridge m_closure;
		}

		// Token: 0x02003A73 RID: 14963
		[Token(Token = "0x2003A73")]
		private class TabModel : UITabPager.TabPageViewModel
		{
			// Token: 0x06017A89 RID: 96905 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A89")]
			[Address(RVA = "0xFEF0D0", Offset = "0xFEDCD0", VA = "0x180FEF0D0", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x06017A8A RID: 96906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A8A")]
			[Address(RVA = "0xFEF250", Offset = "0xFEDE50", VA = "0x180FEF250")]
			public TabModel()
			{
			}

			// Token: 0x06017A8B RID: 96907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A8B")]
			[Address(RVA = "0xFEF1F0", Offset = "0xFEDDF0", VA = "0x180FEF1F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x0401C8B7 RID: 116919
			[Token(Token = "0x401C8B7")]
			[FieldOffset(Offset = "0x30")]
			public int indexFrom1;

			// Token: 0x0401C8B8 RID: 116920
			[Token(Token = "0x401C8B8")]
			[FieldOffset(Offset = "0x38")]
			public LuaTabPagerBridge closure;

			// Token: 0x0401C8B9 RID: 116921
			[Token(Token = "0x401C8B9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x0401C8BA RID: 116922
			[Token(Token = "0x401C8BA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A74 RID: 14964
		[Token(Token = "0x2003A74")]
		private class TabSource : UITabPager.TabDataSource
		{
			// Token: 0x06017A8C RID: 96908 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017A8C")]
			[Address(RVA = "0xFEF9A0", Offset = "0xFEE5A0", VA = "0x180FEF9A0", Slot = "5")]
			public override UITabPager.TabPageViewModel GetTab(int index)
			{
				return null;
			}

			// Token: 0x06017A8D RID: 96909 RVA: 0x00097950 File Offset: 0x00095B50
			[Token(Token = "0x6017A8D")]
			[Address(RVA = "0xFEF820", Offset = "0xFEE420", VA = "0x180FEF820", Slot = "4")]
			public override int GetTabCount()
			{
				return 0;
			}

			// Token: 0x06017A8E RID: 96910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017A8E")]
			[Address(RVA = "0xFEFBC0", Offset = "0xFEE7C0", VA = "0x180FEFBC0")]
			public TabSource()
			{
			}

			// Token: 0x0401C8BB RID: 116923
			[Token(Token = "0x401C8BB")]
			[FieldOffset(Offset = "0x10")]
			public LuaTabPagerBridge closure;

			// Token: 0x0401C8BC RID: 116924
			[Token(Token = "0x401C8BC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetTab;

			// Token: 0x0401C8BD RID: 116925
			[Token(Token = "0x401C8BD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTabCount;

			// Token: 0x0401C8BE RID: 116926
			[Token(Token = "0x401C8BE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
