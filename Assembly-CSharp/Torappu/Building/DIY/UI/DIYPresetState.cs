using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019D5 RID: 6613
	[Token(Token = "0x20019D5")]
	public class DIYPresetState : DIYPopupState
	{
		// Token: 0x0600A61A RID: 42522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A61A")]
		[Address(RVA = "0x321CE90", Offset = "0x321BA90", VA = "0x18321CE90")]
		private void _ShowJudgeDialog(string content, [Optional] Action positiveAction)
		{
		}

		// Token: 0x0600A61B RID: 42523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A61B")]
		[Address(RVA = "0x321CB90", Offset = "0x321B790", VA = "0x18321CB90")]
		private void _LoadPreset(int index, IDIYPreset preset)
		{
		}

		// Token: 0x0600A61C RID: 42524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A61C")]
		[Address(RVA = "0x321CD90", Offset = "0x321B990", VA = "0x18321CD90")]
		private void _SavePreset(int index, IDIYPreset preset)
		{
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A61D")]
		[Address(RVA = "0x321CCC0", Offset = "0x321B8C0", VA = "0x18321CCC0")]
		private void _RenamePreset(int index, string presetName)
		{
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A61E")]
		[Address(RVA = "0x321CC30", Offset = "0x321B830", VA = "0x18321CC30")]
		private void _OnSavePreset()
		{
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A61F")]
		[Address(RVA = "0x321C210", Offset = "0x321AE10", VA = "0x18321C210", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A620")]
		[Address(RVA = "0x321C580", Offset = "0x321B180", VA = "0x18321C580", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A621")]
		[Address(RVA = "0x321C410", Offset = "0x321B010", VA = "0x18321C410", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A622")]
		[Address(RVA = "0x321C700", Offset = "0x321B300", VA = "0x18321C700", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600A623 RID: 42531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A623")]
		[Address(RVA = "0x321CA20", Offset = "0x321B620", VA = "0x18321CA20")]
		private void _DataToSaveState(IStateBean stateBean)
		{
		}

		// Token: 0x0600A624 RID: 42532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A624")]
		[Address(RVA = "0x321C940", Offset = "0x321B540", VA = "0x18321C940")]
		private void _DataToRenameState(IStateBean stateBean)
		{
		}

		// Token: 0x0600A625 RID: 42533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A625")]
		[Address(RVA = "0x321C120", Offset = "0x321AD20", VA = "0x18321C120", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A626")]
		[Address(RVA = "0x321C180", Offset = "0x321AD80", VA = "0x18321C180")]
		public void OnBackButtonPressed()
		{
		}

		// Token: 0x0600A627 RID: 42535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A627")]
		[Address(RVA = "0x321C640", Offset = "0x321B240", VA = "0x18321C640")]
		public void OnSaveButtonPressed()
		{
		}

		// Token: 0x0600A628 RID: 42536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A628")]
		[Address(RVA = "0x321C470", Offset = "0x321B070", VA = "0x18321C470")]
		public void OnLoadButtonPressed()
		{
		}

		// Token: 0x0600A629 RID: 42537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A629")]
		[Address(RVA = "0x321D020", Offset = "0x321BC20", VA = "0x18321D020")]
		public DIYPresetState()
		{
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A62B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600A62C RID: 42540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A62C")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0600A62D RID: 42541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A62D")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A62E")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04009DFE RID: 40446
		[Token(Token = "0x4009DFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private DIYListViewStateBean _stateBean;

		// Token: 0x04009DFF RID: 40447
		[Token(Token = "0x4009DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DIYPresetPanel _panelPreset;

		// Token: 0x04009E00 RID: 40448
		[Token(Token = "0x4009E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_cachedRenameIndex;

		// Token: 0x04009E01 RID: 40449
		[Token(Token = "0x4009E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string m_cachedPresetName;

		// Token: 0x04009E02 RID: 40450
		[Token(Token = "0x4009E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ShowJudgeDialog;

		// Token: 0x04009E03 RID: 40451
		[Token(Token = "0x4009E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadPreset;

		// Token: 0x04009E04 RID: 40452
		[Token(Token = "0x4009E04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SavePreset;

		// Token: 0x04009E05 RID: 40453
		[Token(Token = "0x4009E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenamePreset;

		// Token: 0x04009E06 RID: 40454
		[Token(Token = "0x4009E06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSavePreset;

		// Token: 0x04009E07 RID: 40455
		[Token(Token = "0x4009E07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04009E08 RID: 40456
		[Token(Token = "0x4009E08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04009E09 RID: 40457
		[Token(Token = "0x4009E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04009E0A RID: 40458
		[Token(Token = "0x4009E0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04009E0B RID: 40459
		[Token(Token = "0x4009E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DataToSaveState;

		// Token: 0x04009E0C RID: 40460
		[Token(Token = "0x4009E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DataToRenameState;

		// Token: 0x04009E0D RID: 40461
		[Token(Token = "0x4009E0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04009E0E RID: 40462
		[Token(Token = "0x4009E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBackButtonPressed;

		// Token: 0x04009E0F RID: 40463
		[Token(Token = "0x4009E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnSaveButtonPressed;

		// Token: 0x04009E10 RID: 40464
		[Token(Token = "0x4009E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnLoadButtonPressed;

		// Token: 0x04009E11 RID: 40465
		[Token(Token = "0x4009E11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
