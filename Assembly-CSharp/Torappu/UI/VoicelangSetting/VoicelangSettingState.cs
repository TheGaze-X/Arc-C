using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003B9E RID: 15262
	[Token(Token = "0x2003B9E")]
	public class VoicelangSettingState : State
	{
		// Token: 0x06017E7B RID: 97915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E7B")]
		[Address(RVA = "0x1073410", Offset = "0x1072010", VA = "0x181073410", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06017E7C RID: 97916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E7C")]
		[Address(RVA = "0x10736C0", Offset = "0x10722C0", VA = "0x1810736C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06017E7D RID: 97917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E7D")]
		[Address(RVA = "0x1074590", Offset = "0x1073190", VA = "0x181074590")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017E7E RID: 97918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E7E")]
		[Address(RVA = "0x1074740", Offset = "0x1073340", VA = "0x181074740")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x06017E7F RID: 97919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E7F")]
		[Address(RVA = "0x10738E0", Offset = "0x10724E0", VA = "0x1810738E0")]
		public void OnPowerSelect(bool isAll, string powerId)
		{
		}

		// Token: 0x06017E80 RID: 97920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E80")]
		[Address(RVA = "0x10744C0", Offset = "0x10730C0", VA = "0x1810744C0")]
		public void OnTypeTabSelect(bool isAll, VoiceLangGroupType type)
		{
		}

		// Token: 0x06017E81 RID: 97921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E81")]
		[Address(RVA = "0x1073640", Offset = "0x1072240", VA = "0x181073640")]
		public void OnCardSelect(string wordKey)
		{
		}

		// Token: 0x06017E82 RID: 97922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E82")]
		[Address(RVA = "0x1073470", Offset = "0x1072070", VA = "0x181073470")]
		public void OnBatchSelect()
		{
		}

		// Token: 0x06017E83 RID: 97923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E83")]
		[Address(RVA = "0x1073DF0", Offset = "0x10729F0", VA = "0x181073DF0")]
		public void OnSwitchLangTypeConfirm()
		{
		}

		// Token: 0x06017E84 RID: 97924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E84")]
		[Address(RVA = "0x1073D80", Offset = "0x1072980", VA = "0x181073D80")]
		public void OnSwitchLangTypeCancel()
		{
		}

		// Token: 0x06017E85 RID: 97925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E85")]
		[Address(RVA = "0x10742A0", Offset = "0x1072EA0", VA = "0x1810742A0")]
		public void OnSwitchLangType(VoiceLangType type)
		{
		}

		// Token: 0x06017E86 RID: 97926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E86")]
		[Address(RVA = "0x1073980", Offset = "0x1072580", VA = "0x181073980")]
		public void OnReturn()
		{
		}

		// Token: 0x06017E87 RID: 97927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E87")]
		[Address(RVA = "0x1073CC0", Offset = "0x10728C0", VA = "0x181073CC0")]
		public void OnRoute(UIRouteTarget t, bool b)
		{
		}

		// Token: 0x06017E88 RID: 97928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E88")]
		[Address(RVA = "0x10748C0", Offset = "0x10734C0", VA = "0x1810748C0")]
		public VoicelangSettingState()
		{
		}

		// Token: 0x06017E8B RID: 97931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E8B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401CE9E RID: 118430
		[Token(Token = "0x401CE9E")]
		[FieldOffset(Offset = "0x50")]
		private VoicelangSettingStateBean _stateBean;

		// Token: 0x0401CE9F RID: 118431
		[Token(Token = "0x401CE9F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VoicelangCardGridGroupBinder _cardGroupBinder;

		// Token: 0x0401CEA0 RID: 118432
		[Token(Token = "0x401CEA0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private VoicelangPowerGridGroup _powerGroupBinder;

		// Token: 0x0401CEA1 RID: 118433
		[Token(Token = "0x401CEA1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private VoicelangSettingConfirmBinder _settingConfirmBinder;

		// Token: 0x0401CEA2 RID: 118434
		[Token(Token = "0x401CEA2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private VoicelangTypeSelectGroupBinder _typeSelectGroupBinder;

		// Token: 0x0401CEA3 RID: 118435
		[Token(Token = "0x401CEA3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UnityEvent onReturnPageEvent;

		// Token: 0x0401CEA4 RID: 118436
		[Token(Token = "0x401CEA4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401CEA5 RID: 118437
		[Token(Token = "0x401CEA5")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0401CEA6 RID: 118438
		[Token(Token = "0x401CEA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401CEA7 RID: 118439
		[Token(Token = "0x401CEA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401CEA8 RID: 118440
		[Token(Token = "0x401CEA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401CEA9 RID: 118441
		[Token(Token = "0x401CEA9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x0401CEAA RID: 118442
		[Token(Token = "0x401CEAA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPowerSelect;

		// Token: 0x0401CEAB RID: 118443
		[Token(Token = "0x401CEAB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTypeTabSelect;

		// Token: 0x0401CEAC RID: 118444
		[Token(Token = "0x401CEAC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCardSelect;

		// Token: 0x0401CEAD RID: 118445
		[Token(Token = "0x401CEAD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBatchSelect;

		// Token: 0x0401CEAE RID: 118446
		[Token(Token = "0x401CEAE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnSwitchLangTypeConfirm;

		// Token: 0x0401CEAF RID: 118447
		[Token(Token = "0x401CEAF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnSwitchLangTypeCancel;

		// Token: 0x0401CEB0 RID: 118448
		[Token(Token = "0x401CEB0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnSwitchLangType;

		// Token: 0x0401CEB1 RID: 118449
		[Token(Token = "0x401CEB1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnReturn;

		// Token: 0x0401CEB2 RID: 118450
		[Token(Token = "0x401CEB2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnRoute;

		// Token: 0x0401CEB3 RID: 118451
		[Token(Token = "0x401CEB3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
