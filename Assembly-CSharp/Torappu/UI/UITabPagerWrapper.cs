using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A84 RID: 14980
	[Token(Token = "0x2003A84")]
	public class UITabPagerWrapper : IHotfixable, ICompDialogCallBack
	{
		// Token: 0x06017AD1 RID: 96977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AD1")]
		[Address(RVA = "0xFF8250", Offset = "0xFF6E50", VA = "0x180FF8250")]
		public void Init(UITabPagerWrapper.ITabPagerWrapperHost wrapperHost, UITabPager pager, UnityEngine.Object dlgHost, List<Camera> cameras)
		{
		}

		// Token: 0x06017AD2 RID: 96978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AD2")]
		[Address(RVA = "0xFF8AC0", Offset = "0xFF76C0", VA = "0x180FF8AC0")]
		public void SelectTab(string tabId)
		{
		}

		// Token: 0x06017AD3 RID: 96979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017AD3")]
		[Address(RVA = "0xFF7FB0", Offset = "0xFF6BB0", VA = "0x180FF7FB0")]
		public string GetSelectedTabId()
		{
			return null;
		}

		// Token: 0x06017AD4 RID: 96980 RVA: 0x00097A70 File Offset: 0x00095C70
		[Token(Token = "0x6017AD4")]
		[Address(RVA = "0xFF89A0", Offset = "0xFF75A0", VA = "0x180FF89A0")]
		public bool IsStable()
		{
			return default(bool);
		}

		// Token: 0x06017AD5 RID: 96981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AD5")]
		[Address(RVA = "0xFF7E90", Offset = "0xFF6A90", VA = "0x180FF7E90")]
		public void ClearSelection()
		{
		}

		// Token: 0x06017AD6 RID: 96982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AD6")]
		[Address(RVA = "0xFF8A10", Offset = "0xFF7610", VA = "0x180FF8A10")]
		public void ReloadData(UITabPager.LoadOptions loadOptions)
		{
		}

		// Token: 0x06017AD7 RID: 96983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AD7")]
		[Address(RVA = "0xFF7F00", Offset = "0xFF6B00", VA = "0x180FF7F00")]
		public void Dispose()
		{
		}

		// Token: 0x06017AD8 RID: 96984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AD8")]
		[Address(RVA = "0xFF81C0", Offset = "0xFF6DC0", VA = "0x180FF81C0", Slot = "4")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06017AD9 RID: 96985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017AD9")]
		[Address(RVA = "0xFF8020", Offset = "0xFF6C20", VA = "0x180FF8020", Slot = "5")]
		public CustomYieldInstruction HandleCallBackAsync(int instId, ValueBundle output)
		{
			return null;
		}

		// Token: 0x06017ADA RID: 96986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017ADA")]
		[Address(RVA = "0xFF8B40", Offset = "0xFF7740", VA = "0x180FF8B40")]
		public UITabPagerWrapper()
		{
		}

		// Token: 0x0401C91D RID: 117021
		[Token(Token = "0x401C91D")]
		[FieldOffset(Offset = "0x10")]
		private UITabPager m_tabPager;

		// Token: 0x0401C91E RID: 117022
		[Token(Token = "0x401C91E")]
		[FieldOffset(Offset = "0x18")]
		private UITabPager.Core m_tabCore;

		// Token: 0x0401C91F RID: 117023
		[Token(Token = "0x401C91F")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, UITabPagerWrapper.TabModel> m_tabModels;

		// Token: 0x0401C920 RID: 117024
		[Token(Token = "0x401C920")]
		[FieldOffset(Offset = "0x28")]
		private UITabPagerWrapper.ITabPagerWrapperHost m_wrapperHost;

		// Token: 0x0401C921 RID: 117025
		[Token(Token = "0x401C921")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401C922 RID: 117026
		[Token(Token = "0x401C922")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectTab;

		// Token: 0x0401C923 RID: 117027
		[Token(Token = "0x401C923")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSelectedTabId;

		// Token: 0x0401C924 RID: 117028
		[Token(Token = "0x401C924")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsStable;

		// Token: 0x0401C925 RID: 117029
		[Token(Token = "0x401C925")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearSelection;

		// Token: 0x0401C926 RID: 117030
		[Token(Token = "0x401C926")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReloadData;

		// Token: 0x0401C927 RID: 117031
		[Token(Token = "0x401C927")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401C928 RID: 117032
		[Token(Token = "0x401C928")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0401C929 RID: 117033
		[Token(Token = "0x401C929")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HandleCallBackAsync;

		// Token: 0x0401C92A RID: 117034
		[Token(Token = "0x401C92A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A85 RID: 14981
		[Token(Token = "0x2003A85")]
		public interface ITabPagerWrapperHost
		{
			// Token: 0x170038D7 RID: 14551
			// (get) Token: 0x06017ADB RID: 96987
			[Token(Token = "0x170038D7")]
			int tabCount { [Token(Token = "0x6017ADB")] get; }

			// Token: 0x170038D8 RID: 14552
			// (get) Token: 0x06017ADC RID: 96988
			[Token(Token = "0x170038D8")]
			string defaultTab { [Token(Token = "0x6017ADC")] get; }

			// Token: 0x06017ADD RID: 96989
			[Token(Token = "0x6017ADD")]
			string GetTabId(int index);

			// Token: 0x06017ADE RID: 96990
			[Token(Token = "0x6017ADE")]
			string GetTabResPath(int index);

			// Token: 0x06017ADF RID: 96991
			[Token(Token = "0x6017ADF")]
			Type GetTabDialogType(int index);

			// Token: 0x06017AE0 RID: 96992
			[Token(Token = "0x6017AE0")]
			object GetTabInput(int index);

			// Token: 0x06017AE1 RID: 96993
			[Token(Token = "0x6017AE1")]
			CustomYieldInstruction TabPagerCallback(int index, ValueBundle output);
		}

		// Token: 0x02003A86 RID: 14982
		[Token(Token = "0x2003A86")]
		private class TabModel : UITabPager.TabPageViewModel
		{
			// Token: 0x06017AE2 RID: 96994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017AE2")]
			[Address(RVA = "0xFEF160", Offset = "0xFEDD60", VA = "0x180FEF160", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x06017AE3 RID: 96995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AE3")]
			[Address(RVA = "0xFEF2F0", Offset = "0xFEDEF0", VA = "0x180FEF2F0")]
			public TabModel()
			{
			}

			// Token: 0x06017AE4 RID: 96996 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017AE4")]
			[Address(RVA = "0xFEF1F0", Offset = "0xFEDDF0", VA = "0x180FEF1F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x0401C92B RID: 117035
			[Token(Token = "0x401C92B")]
			[FieldOffset(Offset = "0x30")]
			public int index;

			// Token: 0x0401C92C RID: 117036
			[Token(Token = "0x401C92C")]
			[FieldOffset(Offset = "0x38")]
			public UITabPagerWrapper closure;

			// Token: 0x0401C92D RID: 117037
			[Token(Token = "0x401C92D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x0401C92E RID: 117038
			[Token(Token = "0x401C92E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A87 RID: 14983
		[Token(Token = "0x2003A87")]
		private class TabSource : UITabPager.TabDataSource
		{
			// Token: 0x06017AE5 RID: 96997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017AE5")]
			[Address(RVA = "0xFEFA60", Offset = "0xFEE660", VA = "0x180FEFA60", Slot = "5")]
			public override UITabPager.TabPageViewModel GetTab(int index)
			{
				return null;
			}

			// Token: 0x06017AE6 RID: 96998 RVA: 0x00097A88 File Offset: 0x00095C88
			[Token(Token = "0x6017AE6")]
			[Address(RVA = "0xFEF8E0", Offset = "0xFEE4E0", VA = "0x180FEF8E0", Slot = "4")]
			public override int GetTabCount()
			{
				return 0;
			}

			// Token: 0x06017AE7 RID: 96999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AE7")]
			[Address(RVA = "0xFEFB20", Offset = "0xFEE720", VA = "0x180FEFB20")]
			public TabSource()
			{
			}

			// Token: 0x0401C92F RID: 117039
			[Token(Token = "0x401C92F")]
			[FieldOffset(Offset = "0x10")]
			public UITabPagerWrapper closure;

			// Token: 0x0401C930 RID: 117040
			[Token(Token = "0x401C930")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetTab;

			// Token: 0x0401C931 RID: 117041
			[Token(Token = "0x401C931")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTabCount;

			// Token: 0x0401C932 RID: 117042
			[Token(Token = "0x401C932")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
