using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A09 RID: 18953
	[Token(Token = "0x2004A09")]
	public class InformantInnerState : PopupFadeState, ICompDialogCallBack, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x0601C85C RID: 116828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C85C")]
		[Address(RVA = "0x15F9F20", Offset = "0x15F8B20", VA = "0x1815F9F20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C85D RID: 116829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C85D")]
		[Address(RVA = "0x15FA2F0", Offset = "0x15F8EF0", VA = "0x1815FA2F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C85E RID: 116830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C85E")]
		[Address(RVA = "0x15FA830", Offset = "0x15F9430", VA = "0x1815FA830", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0601C85F RID: 116831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C85F")]
		[Address(RVA = "0x15FA440", Offset = "0x15F9040", VA = "0x1815FA440", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601C860 RID: 116832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C860")]
		[Address(RVA = "0x15FA260", Offset = "0x15F8E60", VA = "0x1815FA260", Slot = "31")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601C861 RID: 116833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C861")]
		[Address(RVA = "0x15F9F80", Offset = "0x15F8B80", VA = "0x1815F9F80", Slot = "32")]
		public CustomYieldInstruction HandleCallBackAsync(int instId, ValueBundle output)
		{
			return null;
		}

		// Token: 0x0601C862 RID: 116834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C862")]
		[Address(RVA = "0x15FA4C0", Offset = "0x15F90C0", VA = "0x1815FA4C0", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601C863 RID: 116835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C863")]
		[Address(RVA = "0x15FA920", Offset = "0x15F9520", VA = "0x1815FA920")]
		private void _HandleOpenCustomerInfoDialog()
		{
		}

		// Token: 0x0601C864 RID: 116836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C864")]
		[Address(RVA = "0x15FAAC0", Offset = "0x15F96C0", VA = "0x1815FAAC0")]
		private void _HandleOpenNewsDialog()
		{
		}

		// Token: 0x0601C865 RID: 116837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C865")]
		[Address(RVA = "0x15FB5A0", Offset = "0x15FA1A0", VA = "0x1815FB5A0")]
		private void _InitIfNot(string actId)
		{
		}

		// Token: 0x0601C866 RID: 116838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C866")]
		[Address(RVA = "0x15FBC00", Offset = "0x15FA800", VA = "0x1815FBC00")]
		private void _UpdateSelectedDialog()
		{
		}

		// Token: 0x0601C867 RID: 116839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C867")]
		[Address(RVA = "0x15FADC0", Offset = "0x15F99C0", VA = "0x1815FADC0")]
		private CustomYieldInstruction _HandleTabEntry(ValueBundle output)
		{
			return null;
		}

		// Token: 0x0601C868 RID: 116840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C868")]
		[Address(RVA = "0x15FA8B0", Offset = "0x15F94B0", VA = "0x1815FA8B0")]
		private void _HandleNextStateResponse(InformantNextStateResponse response)
		{
		}

		// Token: 0x0601C869 RID: 116841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C869")]
		[Address(RVA = "0x15FAC60", Offset = "0x15F9860", VA = "0x1815FAC60")]
		private void _HandleResultResponse(InformantNextStateResponse _)
		{
		}

		// Token: 0x0601C86A RID: 116842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C86A")]
		[Address(RVA = "0x15FB300", Offset = "0x15F9F00", VA = "0x1815FB300")]
		private CustomYieldInstruction _HandleTabSingleResult(ValueBundle output)
		{
			return null;
		}

		// Token: 0x0601C86B RID: 116843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C86B")]
		[Address(RVA = "0x15FB060", Offset = "0x15F9C60", VA = "0x1815FB060")]
		private CustomYieldInstruction _HandleTabResult(ValueBundle output)
		{
			return null;
		}

		// Token: 0x0601C86C RID: 116844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C86C")]
		[Address(RVA = "0x15FAD30", Offset = "0x15F9930", VA = "0x1815FAD30")]
		private CustomYieldInstruction _HandleTabChoiceHost(ValueBundle output)
		{
			return null;
		}

		// Token: 0x0601C86D RID: 116845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C86D")]
		[Address(RVA = "0x15FBFA0", Offset = "0x15FABA0", VA = "0x1815FBFA0")]
		public InformantInnerState()
		{
		}

		// Token: 0x0601C86E RID: 116846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C86E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C86F RID: 116847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C86F")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0601C870 RID: 116848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C870")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04025649 RID: 153161
		[Token(Token = "0x4025649")]
		[NonSerialized]
		public const int EVENT_OPEN_CUSTOMER_INFO_DIALOG = 0;

		// Token: 0x0402564A RID: 153162
		[Token(Token = "0x402564A")]
		[NonSerialized]
		public const int EVENT_OPEN_NEWS_DIALOG = 1;

		// Token: 0x0402564B RID: 153163
		[Token(Token = "0x402564B")]
		private const string TAB_ENTRY = "tab_entry";

		// Token: 0x0402564C RID: 153164
		[Token(Token = "0x402564C")]
		private const string TAB_SINGLE_RESULT = "tab_single_result";

		// Token: 0x0402564D RID: 153165
		[Token(Token = "0x402564D")]
		private const string TAB_RESULT = "tab_result";

		// Token: 0x0402564E RID: 153166
		[Token(Token = "0x402564E")]
		private const string TAB_CHOICE_HOST = "tab_choice_host";

		// Token: 0x0402564F RID: 153167
		[Token(Token = "0x402564F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UITabPager _tabPager;

		// Token: 0x04025650 RID: 153168
		[Token(Token = "0x4025650")]
		[FieldOffset(Offset = "0x78")]
		private InformantInnerStateBean m_stateBean;

		// Token: 0x04025651 RID: 153169
		[Token(Token = "0x4025651")]
		[FieldOffset(Offset = "0x80")]
		private UITabPager.Core m_tabPagerCore;

		// Token: 0x04025652 RID: 153170
		[Token(Token = "0x4025652")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04025653 RID: 153171
		[Token(Token = "0x4025653")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04025654 RID: 153172
		[Token(Token = "0x4025654")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025655 RID: 153173
		[Token(Token = "0x4025655")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025656 RID: 153174
		[Token(Token = "0x4025656")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04025657 RID: 153175
		[Token(Token = "0x4025657")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04025658 RID: 153176
		[Token(Token = "0x4025658")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04025659 RID: 153177
		[Token(Token = "0x4025659")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandleCallBackAsync;

		// Token: 0x0402565A RID: 153178
		[Token(Token = "0x402565A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402565B RID: 153179
		[Token(Token = "0x402565B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleOpenCustomerInfoDialog;

		// Token: 0x0402565C RID: 153180
		[Token(Token = "0x402565C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleOpenNewsDialog;

		// Token: 0x0402565D RID: 153181
		[Token(Token = "0x402565D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402565E RID: 153182
		[Token(Token = "0x402565E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateSelectedDialog;

		// Token: 0x0402565F RID: 153183
		[Token(Token = "0x402565F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandleTabEntry;

		// Token: 0x04025660 RID: 153184
		[Token(Token = "0x4025660")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HandleNextStateResponse;

		// Token: 0x04025661 RID: 153185
		[Token(Token = "0x4025661")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HandleResultResponse;

		// Token: 0x04025662 RID: 153186
		[Token(Token = "0x4025662")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandleTabSingleResult;

		// Token: 0x04025663 RID: 153187
		[Token(Token = "0x4025663")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandleTabResult;

		// Token: 0x04025664 RID: 153188
		[Token(Token = "0x4025664")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandleTabChoiceHost;

		// Token: 0x04025665 RID: 153189
		[Token(Token = "0x4025665")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A0A RID: 18954
		[Token(Token = "0x2004A0A")]
		private class TabModelEntry : UITabPager.TabPageViewModel
		{
			// Token: 0x0601C871 RID: 116849 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C871")]
			[Address(RVA = "0x1607360", Offset = "0x1605F60", VA = "0x181607360", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0601C872 RID: 116850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C872")]
			[Address(RVA = "0x1607410", Offset = "0x1606010", VA = "0x181607410")]
			public TabModelEntry()
			{
			}

			// Token: 0x0601C873 RID: 116851 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C873")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x04025666 RID: 153190
			[Token(Token = "0x4025666")]
			[FieldOffset(Offset = "0x30")]
			public string actId;

			// Token: 0x04025667 RID: 153191
			[Token(Token = "0x4025667")]
			[FieldOffset(Offset = "0x38")]
			public bool showStart;

			// Token: 0x04025668 RID: 153192
			[Token(Token = "0x4025668")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x04025669 RID: 153193
			[Token(Token = "0x4025669")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A0B RID: 18955
		[Token(Token = "0x2004A0B")]
		private class TabModelSelectChoice : UITabPager.TabPageViewModel
		{
			// Token: 0x0601C874 RID: 116852 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C874")]
			[Address(RVA = "0x1607570", Offset = "0x1606170", VA = "0x181607570", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0601C875 RID: 116853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C875")]
			[Address(RVA = "0x1607620", Offset = "0x1606220", VA = "0x181607620")]
			public TabModelSelectChoice()
			{
			}

			// Token: 0x0601C876 RID: 116854 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C876")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x0402566A RID: 153194
			[Token(Token = "0x402566A")]
			[FieldOffset(Offset = "0x30")]
			public string actId;

			// Token: 0x0402566B RID: 153195
			[Token(Token = "0x402566B")]
			[FieldOffset(Offset = "0x38")]
			public bool useSimpleEnterAnim;

			// Token: 0x0402566C RID: 153196
			[Token(Token = "0x402566C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x0402566D RID: 153197
			[Token(Token = "0x402566D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A0C RID: 18956
		[Token(Token = "0x2004A0C")]
		private class TabModelChoiceEnd : UITabPager.TabPageViewModel
		{
			// Token: 0x0601C877 RID: 116855 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C877")]
			[Address(RVA = "0x1607100", Offset = "0x1605D00", VA = "0x181607100", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0601C878 RID: 116856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C878")]
			[Address(RVA = "0x1607200", Offset = "0x1605E00", VA = "0x181607200")]
			public TabModelChoiceEnd()
			{
			}

			// Token: 0x0601C879 RID: 116857 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C879")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x0402566E RID: 153198
			[Token(Token = "0x402566E")]
			[FieldOffset(Offset = "0x30")]
			public string actId;

			// Token: 0x0402566F RID: 153199
			[Token(Token = "0x402566F")]
			[FieldOffset(Offset = "0x38")]
			public bool useSimpleEnterAnim;

			// Token: 0x04025670 RID: 153200
			[Token(Token = "0x4025670")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x04025671 RID: 153201
			[Token(Token = "0x4025671")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A0D RID: 18957
		[Token(Token = "0x2004A0D")]
		private class TabModelSingleResult : UITabPager.TabPageViewModel
		{
			// Token: 0x0601C87A RID: 116858 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C87A")]
			[Address(RVA = "0x1607680", Offset = "0x1606280", VA = "0x181607680", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0601C87B RID: 116859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C87B")]
			[Address(RVA = "0x1607720", Offset = "0x1606320", VA = "0x181607720")]
			public TabModelSingleResult()
			{
			}

			// Token: 0x0601C87C RID: 116860 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C87C")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x04025672 RID: 153202
			[Token(Token = "0x4025672")]
			[FieldOffset(Offset = "0x30")]
			public string actId;

			// Token: 0x04025673 RID: 153203
			[Token(Token = "0x4025673")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x04025674 RID: 153204
			[Token(Token = "0x4025674")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A0E RID: 18958
		[Token(Token = "0x2004A0E")]
		private class TabModelResult : UITabPager.TabPageViewModel
		{
			// Token: 0x0601C87D RID: 116861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C87D")]
			[Address(RVA = "0x1607470", Offset = "0x1606070", VA = "0x181607470", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0601C87E RID: 116862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C87E")]
			[Address(RVA = "0x1607510", Offset = "0x1606110", VA = "0x181607510")]
			public TabModelResult()
			{
			}

			// Token: 0x0601C87F RID: 116863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C87F")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x04025675 RID: 153205
			[Token(Token = "0x4025675")]
			[FieldOffset(Offset = "0x30")]
			public string actId;

			// Token: 0x04025676 RID: 153206
			[Token(Token = "0x4025676")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x04025677 RID: 153207
			[Token(Token = "0x4025677")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A0F RID: 18959
		[Token(Token = "0x2004A0F")]
		private class TabModelChoiceHost : UITabPager.TabPageViewModel
		{
			// Token: 0x0601C880 RID: 116864 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C880")]
			[Address(RVA = "0x1607260", Offset = "0x1605E60", VA = "0x181607260", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x0601C881 RID: 116865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C881")]
			[Address(RVA = "0x1607300", Offset = "0x1605F00", VA = "0x181607300")]
			public TabModelChoiceHost()
			{
			}

			// Token: 0x0601C882 RID: 116866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C882")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x04025678 RID: 153208
			[Token(Token = "0x4025678")]
			[FieldOffset(Offset = "0x30")]
			public string actId;

			// Token: 0x04025679 RID: 153209
			[Token(Token = "0x4025679")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x0402567A RID: 153210
			[Token(Token = "0x402567A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A10 RID: 18960
		[Token(Token = "0x2004A10")]
		private class TabDataSource : UITabPager.TabDataSource, IHotfixable
		{
			// Token: 0x0601C883 RID: 116867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C883")]
			[Address(RVA = "0x1607080", Offset = "0x1605C80", VA = "0x181607080")]
			public TabDataSource(InformantInnerState closure)
			{
			}

			// Token: 0x0601C884 RID: 116868 RVA: 0x000A8960 File Offset: 0x000A6B60
			[Token(Token = "0x601C884")]
			[Address(RVA = "0x1606EF0", Offset = "0x1605AF0", VA = "0x181606EF0", Slot = "4")]
			public override int GetTabCount()
			{
				return 0;
			}

			// Token: 0x0601C885 RID: 116869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C885")]
			[Address(RVA = "0x1606FC0", Offset = "0x1605BC0", VA = "0x181606FC0", Slot = "5")]
			public override UITabPager.TabPageViewModel GetTab(int index)
			{
				return null;
			}

			// Token: 0x0402567B RID: 153211
			[Token(Token = "0x402567B")]
			[FieldOffset(Offset = "0x10")]
			private InformantInnerState m_closure;

			// Token: 0x0402567C RID: 153212
			[Token(Token = "0x402567C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402567D RID: 153213
			[Token(Token = "0x402567D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTabCount;

			// Token: 0x0402567E RID: 153214
			[Token(Token = "0x402567E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTab;
		}
	}
}
