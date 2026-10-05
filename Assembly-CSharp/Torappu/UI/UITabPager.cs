using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A78 RID: 14968
	[Token(Token = "0x2003A78")]
	public class UITabPager : DataBinder<UITabPager.TabPageGroupProperty>
	{
		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x06017A9F RID: 96927 RVA: 0x00097998 File Offset: 0x00095B98
		[Token(Token = "0x170038CA")]
		public int dialogInstId
		{
			[Token(Token = "0x6017A9F")]
			[Address(RVA = "0xFF9260", Offset = "0xFF7E60", VA = "0x180FF9260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x06017AA0 RID: 96928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038CB")]
		public Type dialogType
		{
			[Token(Token = "0x6017AA0")]
			[Address(RVA = "0xFF92E0", Offset = "0xFF7EE0", VA = "0x180FF92E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x06017AA1 RID: 96929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038CC")]
		public string tabId
		{
			[Token(Token = "0x6017AA1")]
			[Address(RVA = "0xFF93F0", Offset = "0xFF7FF0", VA = "0x180FF93F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017AA2 RID: 96930 RVA: 0x000979B0 File Offset: 0x00095BB0
		[Token(Token = "0x6017AA2")]
		[Address(RVA = "0xFF9040", Offset = "0xFF7C40", VA = "0x180FF9040")]
		private bool _CheckSameDialogHandler(UITabPager.ITabPageDialogHandler currDialogHandler)
		{
			return default(bool);
		}

		// Token: 0x06017AA3 RID: 96931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AA3")]
		[Address(RVA = "0xFF8BA0", Offset = "0xFF77A0", VA = "0x180FF8BA0", Slot = "7")]
		public override void OnValueChanged(UITabPager.TabPageGroupProperty property)
		{
		}

		// Token: 0x06017AA4 RID: 96932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AA4")]
		[Address(RVA = "0xFF9190", Offset = "0xFF7D90", VA = "0x180FF9190")]
		public UITabPager()
		{
		}

		// Token: 0x0401C8DB RID: 116955
		[Token(Token = "0x401C8DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0401C8DC RID: 116956
		[Token(Token = "0x401C8DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ListDict<string, UITabPager.ITabPageDialogHandler> m_dialogHandlers;

		// Token: 0x0401C8DD RID: 116957
		[Token(Token = "0x401C8DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UITabPager.ITabPageDialogHandler m_dialogHandler;

		// Token: 0x0401C8DE RID: 116958
		[Token(Token = "0x401C8DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_cachedInitSeq;

		// Token: 0x0401C8DF RID: 116959
		[Token(Token = "0x401C8DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dialogInstId;

		// Token: 0x0401C8E0 RID: 116960
		[Token(Token = "0x401C8E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogType;

		// Token: 0x0401C8E1 RID: 116961
		[Token(Token = "0x401C8E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_tabId;

		// Token: 0x0401C8E2 RID: 116962
		[Token(Token = "0x401C8E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckSameDialogHandler;

		// Token: 0x0401C8E3 RID: 116963
		[Token(Token = "0x401C8E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401C8E4 RID: 116964
		[Token(Token = "0x401C8E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A79 RID: 14969
		[Token(Token = "0x2003A79")]
		public class TabPageViewModel : IHotfixable
		{
			// Token: 0x06017AA5 RID: 96933 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017AA5")]
			[Address(RVA = "0xFEF1F0", Offset = "0xFEDDF0", VA = "0x180FEF1F0", Slot = "4")]
			public virtual object GetDialogInput()
			{
				return null;
			}

			// Token: 0x06017AA6 RID: 96934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AA6")]
			[Address(RVA = "0xFEF7C0", Offset = "0xFEE3C0", VA = "0x180FEF7C0")]
			public TabPageViewModel()
			{
			}

			// Token: 0x0401C8E5 RID: 116965
			[Token(Token = "0x401C8E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string tabId;

			// Token: 0x0401C8E6 RID: 116966
			[Token(Token = "0x401C8E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string dialogResPath;

			// Token: 0x0401C8E7 RID: 116967
			[Token(Token = "0x401C8E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Type dialogType;

			// Token: 0x0401C8E8 RID: 116968
			[Token(Token = "0x401C8E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Type dialogHandlerType;

			// Token: 0x0401C8E9 RID: 116969
			[Token(Token = "0x401C8E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x0401C8EA RID: 116970
			[Token(Token = "0x401C8EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A7A RID: 14970
		[Token(Token = "0x2003A7A")]
		public class TabPageGroupViewModel : IHotfixable
		{
			// Token: 0x06017AA7 RID: 96935 RVA: 0x000979C8 File Offset: 0x00095BC8
			[Token(Token = "0x6017AA7")]
			[Address(RVA = "0xFEF610", Offset = "0xFEE210", VA = "0x180FEF610")]
			public bool SelectTab(string tabId)
			{
				return default(bool);
			}

			// Token: 0x06017AA8 RID: 96936 RVA: 0x000979E0 File Offset: 0x00095BE0
			[Token(Token = "0x6017AA8")]
			[Address(RVA = "0xFEF460", Offset = "0xFEE060", VA = "0x180FEF460")]
			public bool DeselectTab(string tabId)
			{
				return default(bool);
			}

			// Token: 0x06017AA9 RID: 96937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AA9")]
			[Address(RVA = "0xFEF3F0", Offset = "0xFEDFF0", VA = "0x180FEF3F0")]
			public void ClearSelection()
			{
			}

			// Token: 0x06017AAA RID: 96938 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017AAA")]
			[Address(RVA = "0xFEF560", Offset = "0xFEE160", VA = "0x180FEF560")]
			public UITabPager.TabPageViewModel GetSelectedViewModel()
			{
				return null;
			}

			// Token: 0x06017AAB RID: 96939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AAB")]
			[Address(RVA = "0xFEF710", Offset = "0xFEE310", VA = "0x180FEF710")]
			public TabPageGroupViewModel()
			{
			}

			// Token: 0x0401C8EB RID: 116971
			[Token(Token = "0x401C8EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ListDict<string, UITabPager.TabPageViewModel> tabListViewModel;

			// Token: 0x0401C8EC RID: 116972
			[Token(Token = "0x401C8EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string selectedTabId;

			// Token: 0x0401C8ED RID: 116973
			[Token(Token = "0x401C8ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int initSeqNum;

			// Token: 0x0401C8EE RID: 116974
			[Token(Token = "0x401C8EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SelectTab;

			// Token: 0x0401C8EF RID: 116975
			[Token(Token = "0x401C8EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DeselectTab;

			// Token: 0x0401C8F0 RID: 116976
			[Token(Token = "0x401C8F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ClearSelection;

			// Token: 0x0401C8F1 RID: 116977
			[Token(Token = "0x401C8F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetSelectedViewModel;

			// Token: 0x0401C8F2 RID: 116978
			[Token(Token = "0x401C8F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A7B RID: 14971
		[Token(Token = "0x2003A7B")]
		public class TabPageGroupProperty : DynamicBindProperty<UITabPager.TabPageGroupProperty, UITabPager.TabPageGroupViewModel>
		{
			// Token: 0x06017AAC RID: 96940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AAC")]
			[Address(RVA = "0xFEF390", Offset = "0xFEDF90", VA = "0x180FEF390")]
			public TabPageGroupProperty()
			{
			}
		}

		// Token: 0x02003A7C RID: 14972
		[Token(Token = "0x2003A7C")]
		public interface ITabPageDialogHandler : IHotfixable
		{
			// Token: 0x170038CD RID: 14541
			// (get) Token: 0x06017AAD RID: 96941
			// (set) Token: 0x06017AAE RID: 96942
			[Token(Token = "0x170038CD")]
			string tabId { [Token(Token = "0x6017AAD")] get; [Token(Token = "0x6017AAE")] set; }

			// Token: 0x170038CE RID: 14542
			// (get) Token: 0x06017AAF RID: 96943
			// (set) Token: 0x06017AB0 RID: 96944
			[Token(Token = "0x170038CE")]
			string dialogResPath { [Token(Token = "0x6017AAF")] get; [Token(Token = "0x6017AB0")] set; }

			// Token: 0x170038CF RID: 14543
			// (get) Token: 0x06017AB1 RID: 96945
			[Token(Token = "0x170038CF")]
			Type dialogType { [Token(Token = "0x6017AB1")] get; }

			// Token: 0x170038D0 RID: 14544
			// (get) Token: 0x06017AB2 RID: 96946
			[Token(Token = "0x170038D0")]
			int dialogInstId { [Token(Token = "0x6017AB2")] get; }

			// Token: 0x06017AB3 RID: 96947
			[Token(Token = "0x6017AB3")]
			bool OpenDialog(UICompDialogMgr dialogMgr, object input, out int instId, bool isInit);
		}

		// Token: 0x02003A7D RID: 14973
		[Token(Token = "0x2003A7D")]
		private class InnerCompBuilder : UICompDialogMgr.CompBaseBuilder
		{
			// Token: 0x06017AB4 RID: 96948 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017AB4")]
			[Address(RVA = "0xFEA4E0", Offset = "0xFE90E0", VA = "0x180FEA4E0", Slot = "4")]
			public override object GetInput()
			{
				return null;
			}

			// Token: 0x06017AB5 RID: 96949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AB5")]
			[Address(RVA = "0xFEA540", Offset = "0xFE9140", VA = "0x180FEA540")]
			public InnerCompBuilder()
			{
			}

			// Token: 0x0401C8F3 RID: 116979
			[Token(Token = "0x401C8F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object input;

			// Token: 0x0401C8F4 RID: 116980
			[Token(Token = "0x401C8F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetInput;

			// Token: 0x0401C8F5 RID: 116981
			[Token(Token = "0x401C8F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A7E RID: 14974
		[Token(Token = "0x2003A7E")]
		public class DefaultTabPageDialogHandler : UITabPager.ITabPageDialogHandler, IHotfixable
		{
			// Token: 0x170038D1 RID: 14545
			// (get) Token: 0x06017AB6 RID: 96950 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017AB7 RID: 96951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038D1")]
			public string tabId
			{
				[Token(Token = "0x6017AB6")]
				[Address(RVA = "0xFE6CA0", Offset = "0xFE58A0", VA = "0x180FE6CA0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6017AB7")]
				[Address(RVA = "0xFE6E70", Offset = "0xFE5A70", VA = "0x180FE6E70", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170038D2 RID: 14546
			// (get) Token: 0x06017AB8 RID: 96952 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017AB9 RID: 96953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038D2")]
			public string dialogResPath
			{
				[Token(Token = "0x6017AB8")]
				[Address(RVA = "0xFE6BE0", Offset = "0xFE57E0", VA = "0x180FE6BE0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6017AB9")]
				[Address(RVA = "0xFE6D70", Offset = "0xFE5970", VA = "0x180FE6D70", Slot = "7")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170038D3 RID: 14547
			// (get) Token: 0x06017ABA RID: 96954 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017ABB RID: 96955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038D3")]
			public Type dialogType
			{
				[Token(Token = "0x6017ABA")]
				[Address(RVA = "0xFE6C40", Offset = "0xFE5840", VA = "0x180FE6C40", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6017ABB")]
				[Address(RVA = "0xFE6DF0", Offset = "0xFE59F0", VA = "0x180FE6DF0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			// Token: 0x170038D4 RID: 14548
			// (get) Token: 0x06017ABC RID: 96956 RVA: 0x000979F8 File Offset: 0x00095BF8
			// (set) Token: 0x06017ABD RID: 96957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038D4")]
			public int dialogInstId
			{
				[Token(Token = "0x6017ABC")]
				[Address(RVA = "0xFE6B80", Offset = "0xFE5780", VA = "0x180FE6B80", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6017ABD")]
				[Address(RVA = "0xFE6D00", Offset = "0xFE5900", VA = "0x180FE6D00")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			// Token: 0x06017ABE RID: 96958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017ABE")]
			[Address(RVA = "0xFE6AC0", Offset = "0xFE56C0", VA = "0x180FE6AC0")]
			public DefaultTabPageDialogHandler(Type pDialogType)
			{
			}

			// Token: 0x06017ABF RID: 96959 RVA: 0x00097A10 File Offset: 0x00095C10
			[Token(Token = "0x6017ABF")]
			[Address(RVA = "0xFE6840", Offset = "0xFE5440", VA = "0x180FE6840", Slot = "11")]
			public virtual bool OpenDialog(UICompDialogMgr dialogMgr, object input, out int instId, bool isInit)
			{
				return default(bool);
			}

			// Token: 0x0401C8FA RID: 116986
			[Token(Token = "0x401C8FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_tabId;

			// Token: 0x0401C8FB RID: 116987
			[Token(Token = "0x401C8FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_tabId;

			// Token: 0x0401C8FC RID: 116988
			[Token(Token = "0x401C8FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_dialogResPath;

			// Token: 0x0401C8FD RID: 116989
			[Token(Token = "0x401C8FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_dialogResPath;

			// Token: 0x0401C8FE RID: 116990
			[Token(Token = "0x401C8FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_dialogType;

			// Token: 0x0401C8FF RID: 116991
			[Token(Token = "0x401C8FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_dialogType;

			// Token: 0x0401C900 RID: 116992
			[Token(Token = "0x401C900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_dialogInstId;

			// Token: 0x0401C901 RID: 116993
			[Token(Token = "0x401C901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_dialogInstId;

			// Token: 0x0401C902 RID: 116994
			[Token(Token = "0x401C902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C903 RID: 116995
			[Token(Token = "0x401C903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OpenDialog;
		}

		// Token: 0x02003A7F RID: 14975
		[Token(Token = "0x2003A7F")]
		public class TabPageDialogHandler<TDialog, TInput> : UITabPager.DefaultTabPageDialogHandler where TDialog : UICompDialog<TInput> where TInput : class
		{
			// Token: 0x06017AC0 RID: 96960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AC0")]
			public TabPageDialogHandler()
			{
			}

			// Token: 0x06017AC1 RID: 96961 RVA: 0x00097A28 File Offset: 0x00095C28
			[Token(Token = "0x6017AC1")]
			public override bool OpenDialog(UICompDialogMgr dialogMgr, object input, out int instId, bool isInit)
			{
				return default(bool);
			}

			// Token: 0x0401C904 RID: 116996
			[Token(Token = "0x401C904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C905 RID: 116997
			[Token(Token = "0x401C905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OpenDialog;
		}

		// Token: 0x02003A80 RID: 14976
		[Token(Token = "0x2003A80")]
		public abstract class TabDataSource : IHotfixable
		{
			// Token: 0x06017AC2 RID: 96962
			[Token(Token = "0x6017AC2")]
			public abstract int GetTabCount();

			// Token: 0x06017AC3 RID: 96963
			[Token(Token = "0x6017AC3")]
			public abstract UITabPager.TabPageViewModel GetTab(int index);

			// Token: 0x06017AC4 RID: 96964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AC4")]
			[Address(RVA = "0xFEF070", Offset = "0xFEDC70", VA = "0x180FEF070")]
			protected TabDataSource()
			{
			}

			// Token: 0x0401C906 RID: 116998
			[Token(Token = "0x401C906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A81 RID: 14977
		[Token(Token = "0x2003A81")]
		public struct BuildOptions
		{
			// Token: 0x0401C907 RID: 116999
			[Token(Token = "0x401C907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UITabPager tabPager;

			// Token: 0x0401C908 RID: 117000
			[Token(Token = "0x401C908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public UnityEngine.Object hostObj;

			// Token: 0x0401C909 RID: 117001
			[Token(Token = "0x401C909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Camera> viewableCameras;

			// Token: 0x0401C90A RID: 117002
			[Token(Token = "0x401C90A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ICompDialogCallBack callbackHandler;

			// Token: 0x0401C90B RID: 117003
			[Token(Token = "0x401C90B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UITabPager.TabDataSource tabDataSource;

			// Token: 0x0401C90C RID: 117004
			[Token(Token = "0x401C90C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DataBinder<UITabPager.TabPageGroupProperty> tabView;
		}

		// Token: 0x02003A82 RID: 14978
		[Token(Token = "0x2003A82")]
		public struct LoadOptions
		{
			// Token: 0x170038D5 RID: 14549
			// (get) Token: 0x06017AC5 RID: 96965 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06017AC6 RID: 96966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170038D5")]
			public string selectedTabId
			{
				[Token(Token = "0x6017AC5")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				get
				{
					return null;
				}
				[Token(Token = "0x6017AC6")]
				[Address(RVA = "0xFEA730", Offset = "0xFE9330", VA = "0x180FEA730")]
				set
				{
				}
			}

			// Token: 0x170038D6 RID: 14550
			// (get) Token: 0x06017AC7 RID: 96967 RVA: 0x00097A40 File Offset: 0x00095C40
			[Token(Token = "0x170038D6")]
			public bool indicateSelection
			{
				[Token(Token = "0x6017AC7")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0401C90D RID: 117005
			[Token(Token = "0x401C90D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool m_indicateSelection;

			// Token: 0x0401C90E RID: 117006
			[Token(Token = "0x401C90E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private string m_selectedTabId;

			// Token: 0x0401C90F RID: 117007
			[Token(Token = "0x401C90F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isInit;
		}

		// Token: 0x02003A83 RID: 14979
		[Token(Token = "0x2003A83")]
		public class Core : ICompDialogDestroyedCallback, IHotfixable
		{
			// Token: 0x06017AC8 RID: 96968 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017AC8")]
			[Address(RVA = "0xFE2BD0", Offset = "0xFE17D0", VA = "0x180FE2BD0")]
			public static UITabPager.Core Build(UITabPager.BuildOptions options)
			{
				return null;
			}

			// Token: 0x06017AC9 RID: 96969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AC9")]
			[Address(RVA = "0xFE3380", Offset = "0xFE1F80", VA = "0x180FE3380")]
			public void LoadData([Optional] UITabPager.LoadOptions options)
			{
			}

			// Token: 0x06017ACA RID: 96970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017ACA")]
			[Address(RVA = "0xFE3110", Offset = "0xFE1D10", VA = "0x180FE3110", Slot = "4")]
			public void HandleDialogDestroyedCallback(int instId)
			{
			}

			// Token: 0x06017ACB RID: 96971 RVA: 0x00097A58 File Offset: 0x00095C58
			[Token(Token = "0x6017ACB")]
			[Address(RVA = "0xFE3310", Offset = "0xFE1F10", VA = "0x180FE3310")]
			public bool IsStable()
			{
				return default(bool);
			}

			// Token: 0x06017ACC RID: 96972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017ACC")]
			[Address(RVA = "0xFE37A0", Offset = "0xFE23A0", VA = "0x180FE37A0")]
			public void SelectTab(string tabId)
			{
			}

			// Token: 0x06017ACD RID: 96973 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017ACD")]
			[Address(RVA = "0xFE3090", Offset = "0xFE1C90", VA = "0x180FE3090")]
			public string GetSelectTabId()
			{
				return null;
			}

			// Token: 0x06017ACE RID: 96974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017ACE")]
			[Address(RVA = "0xFE2F80", Offset = "0xFE1B80", VA = "0x180FE2F80")]
			public void ClearSelection()
			{
			}

			// Token: 0x06017ACF RID: 96975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017ACF")]
			[Address(RVA = "0xFE3870", Offset = "0xFE2470", VA = "0x180FE3870")]
			private UITabPager.ITabPageDialogHandler _CreateTabPageDialogHandler(UITabPager.TabPageViewModel tabPageViewModel)
			{
				return null;
			}

			// Token: 0x06017AD0 RID: 96976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017AD0")]
			[Address(RVA = "0xFE3AE0", Offset = "0xFE26E0", VA = "0x180FE3AE0")]
			public Core()
			{
			}

			// Token: 0x0401C910 RID: 117008
			[Token(Token = "0x401C910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UICompDialogMgr m_dialogMgr;

			// Token: 0x0401C911 RID: 117009
			[Token(Token = "0x401C911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UITabPager m_tabPager;

			// Token: 0x0401C912 RID: 117010
			[Token(Token = "0x401C912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UITabPager.TabPageGroupProperty m_property;

			// Token: 0x0401C913 RID: 117011
			[Token(Token = "0x401C913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UITabPager.TabDataSource m_tabDataSource;

			// Token: 0x0401C914 RID: 117012
			[Token(Token = "0x401C914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Build;

			// Token: 0x0401C915 RID: 117013
			[Token(Token = "0x401C915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0401C916 RID: 117014
			[Token(Token = "0x401C916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_HandleDialogDestroyedCallback;

			// Token: 0x0401C917 RID: 117015
			[Token(Token = "0x401C917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsStable;

			// Token: 0x0401C918 RID: 117016
			[Token(Token = "0x401C918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_SelectTab;

			// Token: 0x0401C919 RID: 117017
			[Token(Token = "0x401C919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetSelectTabId;

			// Token: 0x0401C91A RID: 117018
			[Token(Token = "0x401C91A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ClearSelection;

			// Token: 0x0401C91B RID: 117019
			[Token(Token = "0x401C91B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__CreateTabPageDialogHandler;

			// Token: 0x0401C91C RID: 117020
			[Token(Token = "0x401C91C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
