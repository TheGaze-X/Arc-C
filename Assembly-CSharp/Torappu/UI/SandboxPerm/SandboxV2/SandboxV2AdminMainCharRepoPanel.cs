using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200406E RID: 16494
	[Token(Token = "0x200406E")]
	public class SandboxV2AdminMainCharRepoPanel : SandboxV2AdminMainTabPanel, ISandboxV2SquadPanelContext
	{
		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0601982F RID: 104495 RVA: 0x0009E5F8 File Offset: 0x0009C7F8
		[Token(Token = "0x17003CC6")]
		public override SandboxV2AdminMainPanelType panelType
		{
			[Token(Token = "0x601982F")]
			[Address(RVA = "0x122F860", Offset = "0x122E460", VA = "0x18122F860", Slot = "9")]
			get
			{
				return SandboxV2AdminMainPanelType.NONE;
			}
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x06019830 RID: 104496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CC7")]
		public override string topTitle
		{
			[Token(Token = "0x6019830")]
			[Address(RVA = "0x122F8C0", Offset = "0x122E4C0", VA = "0x18122F8C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019831 RID: 104497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019831")]
		[Address(RVA = "0x122EA60", Offset = "0x122D660", VA = "0x18122EA60", Slot = "16")]
		public void OpenDineState(int charInstId)
		{
		}

		// Token: 0x06019832 RID: 104498 RVA: 0x0009E610 File Offset: 0x0009C810
		[Token(Token = "0x6019832")]
		[Address(RVA = "0x122E4F0", Offset = "0x122D0F0", VA = "0x18122E4F0", Slot = "21")]
		public bool IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x06019833 RID: 104499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019833")]
		[Address(RVA = "0x122EC70", Offset = "0x122D870", VA = "0x18122EC70", Slot = "19")]
		public void OpenWorkbenchDialog(SandboxV2WorkbenchMakeDialog.Options options)
		{
		}

		// Token: 0x06019834 RID: 104500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019834")]
		[Address(RVA = "0x122E8E0", Offset = "0x122D4E0", VA = "0x18122E8E0", Slot = "17")]
		public void OpenCharSelectState(SandboxV2AdminCharSelectStateBean.OpenOption option)
		{
		}

		// Token: 0x06019835 RID: 104501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019835")]
		[Address(RVA = "0x122EB50", Offset = "0x122D750", VA = "0x18122EB50", Slot = "18")]
		public void OpenToolSelectState(SandboxV2ToolSelectStateBean.Input toolSelectInput)
		{
		}

		// Token: 0x06019836 RID: 104502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019836")]
		[Address(RVA = "0x122E730", Offset = "0x122D330", VA = "0x18122E730", Slot = "8")]
		protected override void OnUpdate(SandboxV2AdminMainTabPanelUpdateCase updateCase)
		{
		}

		// Token: 0x06019837 RID: 104503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019837")]
		[Address(RVA = "0x122E660", Offset = "0x122D260", VA = "0x18122E660", Slot = "15")]
		protected override void OnHideProcess(Action done)
		{
		}

		// Token: 0x06019838 RID: 104504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019838")]
		[Address(RVA = "0x122E380", Offset = "0x122CF80", VA = "0x18122E380", Slot = "12")]
		public override IEnumerable<KeyValuePair<Type, Action<IStateBean>>> GetToDataListener()
		{
			return null;
		}

		// Token: 0x06019839 RID: 104505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019839")]
		[Address(RVA = "0x122E270", Offset = "0x122CE70", VA = "0x18122E270", Slot = "13")]
		public override IEnumerable<KeyValuePair<Type, Action<IStateBean>>> GetFromDataListener()
		{
			return null;
		}

		// Token: 0x0601983A RID: 104506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601983A")]
		[Address(RVA = "0x122E210", Offset = "0x122CE10", VA = "0x18122E210", Slot = "20")]
		public DataBinder<SandboxV2SquadGroupProp> GetBinderView()
		{
			return null;
		}

		// Token: 0x0601983B RID: 104507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601983B")]
		[Address(RVA = "0x122F280", Offset = "0x122DE80", VA = "0x18122F280")]
		private void _OnJumpFromToolSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601983C RID: 104508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601983C")]
		[Address(RVA = "0x122F670", Offset = "0x122E270", VA = "0x18122F670")]
		private void _OnJumpToToolSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601983D RID: 104509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601983D")]
		[Address(RVA = "0x122F030", Offset = "0x122DC30", VA = "0x18122F030")]
		private void _OnJumpFromCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601983E RID: 104510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601983E")]
		[Address(RVA = "0x122F3F0", Offset = "0x122DFF0", VA = "0x18122F3F0")]
		private void _OnJumpToCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601983F RID: 104511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601983F")]
		[Address(RVA = "0x122F200", Offset = "0x122DE00", VA = "0x18122F200")]
		private void _OnJumpFromDineState(IStateBean obj)
		{
		}

		// Token: 0x06019840 RID: 104512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019840")]
		[Address(RVA = "0x122F530", Offset = "0x122E130", VA = "0x18122F530")]
		private void _OnJumpToDineState(IStateBean stateBean)
		{
		}

		// Token: 0x06019841 RID: 104513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019841")]
		[Address(RVA = "0x122EEF0", Offset = "0x122DAF0", VA = "0x18122EEF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019842 RID: 104514 RVA: 0x0009E628 File Offset: 0x0009C828
		[Token(Token = "0x6019842")]
		[Address(RVA = "0x122E490", Offset = "0x122D090", VA = "0x18122E490", Slot = "22")]
		public bool IsRepoShow()
		{
			return default(bool);
		}

		// Token: 0x06019843 RID: 104515 RVA: 0x0009E640 File Offset: 0x0009C840
		[Token(Token = "0x6019843")]
		[Address(RVA = "0x122E430", Offset = "0x122D030", VA = "0x18122E430", Slot = "23")]
		public bool IsNaviPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06019844 RID: 104516 RVA: 0x0009E658 File Offset: 0x0009C858
		[Token(Token = "0x6019844")]
		[Address(RVA = "0x122E320", Offset = "0x122CF20", VA = "0x18122E320", Slot = "24")]
		public SandboxV2SquadPanelShowMode GetPanelShowMode()
		{
			return SandboxV2SquadPanelShowMode.NORMAL;
		}

		// Token: 0x06019845 RID: 104517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019845")]
		[Address(RVA = "0x122F770", Offset = "0x122E370", VA = "0x18122F770")]
		public SandboxV2AdminMainCharRepoPanel()
		{
		}

		// Token: 0x06019846 RID: 104518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019846")]
		[Address(RVA = "0x122EE70", Offset = "0x122DA70", VA = "0x18122EE70")]
		private void <>xLuaBaseProxy_OnHideProcess(Action P0)
		{
		}

		// Token: 0x06019847 RID: 104519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019847")]
		[Address(RVA = "0x122EDD0", Offset = "0x122D9D0", VA = "0x18122EDD0")]
		private IEnumerable<KeyValuePair<Type, Action<IStateBean>>> <>xLuaBaseProxy_GetToDataListener()
		{
			return null;
		}

		// Token: 0x06019848 RID: 104520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019848")]
		[Address(RVA = "0x122ED30", Offset = "0x122D930", VA = "0x18122ED30")]
		private IEnumerable<KeyValuePair<Type, Action<IStateBean>>> <>xLuaBaseProxy_GetFromDataListener()
		{
			return null;
		}

		// Token: 0x0401FCC7 RID: 130247
		[Token(Token = "0x401FCC7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxV2SquadGroupPanel _squadGroupPanelPrefab;

		// Token: 0x0401FCC8 RID: 130248
		[Token(Token = "0x401FCC8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _squadPanelRt;

		// Token: 0x0401FCC9 RID: 130249
		[Token(Token = "0x401FCC9")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0401FCCA RID: 130250
		[Token(Token = "0x401FCCA")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2SquadGroupPanel m_squadGroupPanel;

		// Token: 0x0401FCCB RID: 130251
		[Token(Token = "0x401FCCB")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedDineCharInstId;

		// Token: 0x0401FCCC RID: 130252
		[Token(Token = "0x401FCCC")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2AdminCharSelectStateBean.OpenOption m_cachedOpenOption;

		// Token: 0x0401FCCD RID: 130253
		[Token(Token = "0x401FCCD")]
		[FieldOffset(Offset = "0xE0")]
		private SandboxV2ToolSelectStateBean.Input m_cachedToolSelectInput;

		// Token: 0x0401FCCE RID: 130254
		[Token(Token = "0x401FCCE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0401FCCF RID: 130255
		[Token(Token = "0x401FCCF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topTitle;

		// Token: 0x0401FCD0 RID: 130256
		[Token(Token = "0x401FCD0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenDineState;

		// Token: 0x0401FCD1 RID: 130257
		[Token(Token = "0x401FCD1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsStateStable;

		// Token: 0x0401FCD2 RID: 130258
		[Token(Token = "0x401FCD2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OpenWorkbenchDialog;

		// Token: 0x0401FCD3 RID: 130259
		[Token(Token = "0x401FCD3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OpenCharSelectState;

		// Token: 0x0401FCD4 RID: 130260
		[Token(Token = "0x401FCD4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OpenToolSelectState;

		// Token: 0x0401FCD5 RID: 130261
		[Token(Token = "0x401FCD5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0401FCD6 RID: 130262
		[Token(Token = "0x401FCD6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnHideProcess;

		// Token: 0x0401FCD7 RID: 130263
		[Token(Token = "0x401FCD7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetToDataListener;

		// Token: 0x0401FCD8 RID: 130264
		[Token(Token = "0x401FCD8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetFromDataListener;

		// Token: 0x0401FCD9 RID: 130265
		[Token(Token = "0x401FCD9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetBinderView;

		// Token: 0x0401FCDA RID: 130266
		[Token(Token = "0x401FCDA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnJumpFromToolSelectState;

		// Token: 0x0401FCDB RID: 130267
		[Token(Token = "0x401FCDB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnJumpToToolSelectState;

		// Token: 0x0401FCDC RID: 130268
		[Token(Token = "0x401FCDC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnJumpFromCharSelectState;

		// Token: 0x0401FCDD RID: 130269
		[Token(Token = "0x401FCDD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnJumpToCharSelectState;

		// Token: 0x0401FCDE RID: 130270
		[Token(Token = "0x401FCDE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnJumpFromDineState;

		// Token: 0x0401FCDF RID: 130271
		[Token(Token = "0x401FCDF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnJumpToDineState;

		// Token: 0x0401FCE0 RID: 130272
		[Token(Token = "0x401FCE0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FCE1 RID: 130273
		[Token(Token = "0x401FCE1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_IsRepoShow;

		// Token: 0x0401FCE2 RID: 130274
		[Token(Token = "0x401FCE2")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_IsNaviPanelShow;

		// Token: 0x0401FCE3 RID: 130275
		[Token(Token = "0x401FCE3")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetPanelShowMode;

		// Token: 0x0401FCE4 RID: 130276
		[Token(Token = "0x401FCE4")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
