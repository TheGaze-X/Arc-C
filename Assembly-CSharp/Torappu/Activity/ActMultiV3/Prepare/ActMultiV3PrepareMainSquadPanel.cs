using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007061 RID: 28769
	[Token(Token = "0x2007061")]
	public class ActMultiV3PrepareMainSquadPanel : ActMultiV3PrepareMainStepPanelBase, IActMultiV3PrepareMainSquadPanelProcEvent
	{
		// Token: 0x06028DA8 RID: 167336 RVA: 0x000D3458 File Offset: 0x000D1658
		[Token(Token = "0x6028DA8")]
		[Address(RVA = "0x2443CF0", Offset = "0x24428F0", VA = "0x182443CF0", Slot = "10")]
		public override ActMultiV3PrepareMainViewConfig GetMainViewConfig()
		{
			return default(ActMultiV3PrepareMainViewConfig);
		}

		// Token: 0x17006098 RID: 24728
		// (get) Token: 0x06028DA9 RID: 167337 RVA: 0x000D3470 File Offset: 0x000D1670
		[Token(Token = "0x17006098")]
		public override ActMultiV3PrepareStepType step
		{
			[Token(Token = "0x6028DA9")]
			[Address(RVA = "0x24456B0", Offset = "0x24442B0", VA = "0x1824456B0", Slot = "4")]
			get
			{
				return ActMultiV3PrepareStepType.NONE;
			}
		}

		// Token: 0x06028DAA RID: 167338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DAA")]
		[Address(RVA = "0x24441A0", Offset = "0x2442DA0", VA = "0x1824441A0", Slot = "7")]
		protected override void OnUpdate(ActMultiV3StepUpdateCase updateCase)
		{
		}

		// Token: 0x06028DAB RID: 167339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DAB")]
		[Address(RVA = "0x2444270", Offset = "0x2442E70", VA = "0x182444270", Slot = "8")]
		protected override void OnVisible(bool v)
		{
		}

		// Token: 0x06028DAC RID: 167340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DAC")]
		[Address(RVA = "0x2443F60", Offset = "0x2442B60", VA = "0x182443F60", Slot = "9")]
		protected override void OnEmergency()
		{
		}

		// Token: 0x06028DAD RID: 167341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028DAD")]
		[Address(RVA = "0x2444440", Offset = "0x2443040", VA = "0x182444440", Slot = "12")]
		protected override IEnumerator PlayEntryAnimation()
		{
			return null;
		}

		// Token: 0x06028DAE RID: 167342 RVA: 0x000D3488 File Offset: 0x000D1688
		[Token(Token = "0x6028DAE")]
		[Address(RVA = "0x2443AA0", Offset = "0x24426A0", VA = "0x182443AA0", Slot = "11")]
		public override bool DoBackAction()
		{
			return default(bool);
		}

		// Token: 0x06028DAF RID: 167343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DAF")]
		[Address(RVA = "0x24450D0", Offset = "0x2443CD0", VA = "0x1824450D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028DB0 RID: 167344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DB0")]
		[Address(RVA = "0x2444020", Offset = "0x2442C20", VA = "0x182444020", Slot = "6")]
		protected override void OnStop()
		{
		}

		// Token: 0x06028DB1 RID: 167345 RVA: 0x000D34A0 File Offset: 0x000D16A0
		[Token(Token = "0x6028DB1")]
		[Address(RVA = "0x2444D20", Offset = "0x2443920", VA = "0x182444D20")]
		private ActMultiV3PrepareMainViewConfig _GetMainViewConfigByProc(ActMultiV3PrepareMainSquadProc proc)
		{
			return default(ActMultiV3PrepareMainViewConfig);
		}

		// Token: 0x06028DB2 RID: 167346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DB2")]
		[Address(RVA = "0x2444F20", Offset = "0x2443B20", VA = "0x182444F20")]
		private void _HandleSetCharSuc(object arg)
		{
		}

		// Token: 0x06028DB3 RID: 167347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DB3")]
		[Address(RVA = "0x2444DF0", Offset = "0x24439F0", VA = "0x182444DF0")]
		private void _HandleSaveSquadSuc(object arg)
		{
		}

		// Token: 0x06028DB4 RID: 167348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DB4")]
		[Address(RVA = "0x24446E0", Offset = "0x24432E0", VA = "0x1824446E0", Slot = "15")]
		public void SetCharInSquad(int instId, bool inSquad)
		{
		}

		// Token: 0x06028DB5 RID: 167349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DB5")]
		[Address(RVA = "0x2443960", Offset = "0x2442560", VA = "0x182443960", Slot = "19")]
		public void CheckReserveVisible()
		{
		}

		// Token: 0x06028DB6 RID: 167350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DB6")]
		[Address(RVA = "0x2444A60", Offset = "0x2443660", VA = "0x182444A60", Slot = "20")]
		public void SetReady(bool isReady)
		{
		}

		// Token: 0x06028DB7 RID: 167351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DB7")]
		[Address(RVA = "0x2444C40", Offset = "0x2443840", VA = "0x182444C40", Slot = "16")]
		public void ToNextProc()
		{
		}

		// Token: 0x06028DB8 RID: 167352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DB8")]
		[Address(RVA = "0x2443E30", Offset = "0x2442A30", VA = "0x182443E30", Slot = "17")]
		public void JumpToEndProc()
		{
		}

		// Token: 0x06028DB9 RID: 167353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DB9")]
		[Address(RVA = "0x24444F0", Offset = "0x24430F0", VA = "0x1824444F0", Slot = "18")]
		public void SaveSquad()
		{
		}

		// Token: 0x06028DBA RID: 167354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DBA")]
		[Address(RVA = "0x24454E0", Offset = "0x24440E0", VA = "0x1824454E0")]
		private void _SaveSquadImpl(bool isEmergency)
		{
		}

		// Token: 0x06028DBB RID: 167355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DBB")]
		[Address(RVA = "0x24448F0", Offset = "0x24434F0", VA = "0x1824448F0", Slot = "21")]
		public void SetCharSkill(int instId, string skillId)
		{
		}

		// Token: 0x06028DBC RID: 167356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DBC")]
		[Address(RVA = "0x2444570", Offset = "0x2443170", VA = "0x182444570", Slot = "22")]
		public void SetCharEquip(int instId, string equipId)
		{
		}

		// Token: 0x06028DBD RID: 167357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DBD")]
		[Address(RVA = "0x2444B30", Offset = "0x2443730", VA = "0x182444B30", Slot = "23")]
		public void SwitchShowSkill()
		{
		}

		// Token: 0x06028DBE RID: 167358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DBE")]
		[Address(RVA = "0x2445650", Offset = "0x2444250", VA = "0x182445650")]
		public ActMultiV3PrepareMainSquadPanel()
		{
		}

		// Token: 0x06028DBF RID: 167359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DBF")]
		[Address(RVA = "0x2436ED0", Offset = "0x2435AD0", VA = "0x182436ED0")]
		private void <>xLuaBaseProxy_OnUpdate(ActMultiV3StepUpdateCase P0)
		{
		}

		// Token: 0x06028DC0 RID: 167360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DC0")]
		[Address(RVA = "0x2436EE0", Offset = "0x2435AE0", VA = "0x182436EE0")]
		private void <>xLuaBaseProxy_OnVisible(bool P0)
		{
		}

		// Token: 0x06028DC1 RID: 167361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DC1")]
		[Address(RVA = "0x2444D10", Offset = "0x2443910", VA = "0x182444D10")]
		private void <>xLuaBaseProxy_OnEmergency()
		{
		}

		// Token: 0x06028DC2 RID: 167362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028DC2")]
		[Address(RVA = "0x2436EF0", Offset = "0x2435AF0", VA = "0x182436EF0")]
		private IEnumerator <>xLuaBaseProxy_PlayEntryAnimation()
		{
			return null;
		}

		// Token: 0x06028DC3 RID: 167363 RVA: 0x000D34B8 File Offset: 0x000D16B8
		[Token(Token = "0x6028DC3")]
		[Address(RVA = "0x2436EB0", Offset = "0x2435AB0", VA = "0x182436EB0")]
		private bool <>xLuaBaseProxy_DoBackAction()
		{
			return default(bool);
		}

		// Token: 0x06028DC4 RID: 167364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028DC4")]
		[Address(RVA = "0x2436EC0", Offset = "0x2435AC0", VA = "0x182436EC0")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x0403A46A RID: 238698
		[Token(Token = "0x403A46A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403A46B RID: 238699
		[Token(Token = "0x403A46B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ActMultiV3PrepareMainSquadPanelMainView _mainView;

		// Token: 0x0403A46C RID: 238700
		[Token(Token = "0x403A46C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActMultiV3PrepareMainSquadPanelSysAllocView _sysAllocView;

		// Token: 0x0403A46D RID: 238701
		[Token(Token = "0x403A46D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActMultiV3PrepareMainSquadPanelProcViewBase[] _procViewPrefab;

		// Token: 0x0403A46E RID: 238702
		[Token(Token = "0x403A46E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _procViewContainer;

		// Token: 0x0403A46F RID: 238703
		[Token(Token = "0x403A46F")]
		[FieldOffset(Offset = "0x68")]
		private ActMultiV3PrepareMainSquadPanelViewModelProperty m_prop;

		// Token: 0x0403A470 RID: 238704
		[Token(Token = "0x403A470")]
		[FieldOffset(Offset = "0x70")]
		private List<ActMultiV3PrepareMainSquadPanelProcViewBase> m_procViews;

		// Token: 0x0403A471 RID: 238705
		[Token(Token = "0x403A471")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMainViewConfig;

		// Token: 0x0403A472 RID: 238706
		[Token(Token = "0x403A472")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_step;

		// Token: 0x0403A473 RID: 238707
		[Token(Token = "0x403A473")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403A474 RID: 238708
		[Token(Token = "0x403A474")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnVisible;

		// Token: 0x0403A475 RID: 238709
		[Token(Token = "0x403A475")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEmergency;

		// Token: 0x0403A476 RID: 238710
		[Token(Token = "0x403A476")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayEntryAnimation;

		// Token: 0x0403A477 RID: 238711
		[Token(Token = "0x403A477")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoBackAction;

		// Token: 0x0403A478 RID: 238712
		[Token(Token = "0x403A478")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A479 RID: 238713
		[Token(Token = "0x403A479")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0403A47A RID: 238714
		[Token(Token = "0x403A47A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetMainViewConfigByProc;

		// Token: 0x0403A47B RID: 238715
		[Token(Token = "0x403A47B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__HandleSetCharSuc;

		// Token: 0x0403A47C RID: 238716
		[Token(Token = "0x403A47C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandleSaveSquadSuc;

		// Token: 0x0403A47D RID: 238717
		[Token(Token = "0x403A47D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetCharInSquad;

		// Token: 0x0403A47E RID: 238718
		[Token(Token = "0x403A47E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckReserveVisible;

		// Token: 0x0403A47F RID: 238719
		[Token(Token = "0x403A47F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetReady;

		// Token: 0x0403A480 RID: 238720
		[Token(Token = "0x403A480")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ToNextProc;

		// Token: 0x0403A481 RID: 238721
		[Token(Token = "0x403A481")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_JumpToEndProc;

		// Token: 0x0403A482 RID: 238722
		[Token(Token = "0x403A482")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SaveSquad;

		// Token: 0x0403A483 RID: 238723
		[Token(Token = "0x403A483")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SaveSquadImpl;

		// Token: 0x0403A484 RID: 238724
		[Token(Token = "0x403A484")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetCharSkill;

		// Token: 0x0403A485 RID: 238725
		[Token(Token = "0x403A485")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetCharEquip;

		// Token: 0x0403A486 RID: 238726
		[Token(Token = "0x403A486")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SwitchShowSkill;

		// Token: 0x0403A487 RID: 238727
		[Token(Token = "0x403A487")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
