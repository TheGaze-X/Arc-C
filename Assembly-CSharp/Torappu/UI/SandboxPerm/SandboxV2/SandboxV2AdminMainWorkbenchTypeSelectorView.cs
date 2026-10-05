using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040EF RID: 16623
	[Token(Token = "0x20040EF")]
	public class SandboxV2AdminMainWorkbenchTypeSelectorView : SandboxV2AdminMainTypeSelectViewBase<SandboxV2AdminMainWorkbenchType, SandboxV2AdminMainWorkbenchPanelModelProperty>
	{
		// Token: 0x06019B60 RID: 105312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B60")]
		[Address(RVA = "0x1291010", Offset = "0x128FC10", VA = "0x181291010", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainWorkbenchPanelModelProperty property)
		{
		}

		// Token: 0x06019B61 RID: 105313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019B61")]
		[Address(RVA = "0x1290EE0", Offset = "0x128FAE0", VA = "0x181290EE0", Slot = "8")]
		protected override IList<SandboxV2AdminMainTypeDefine<SandboxV2AdminMainWorkbenchType>> GetDefinedTypeList()
		{
			return null;
		}

		// Token: 0x06019B62 RID: 105314 RVA: 0x0009F2E8 File Offset: 0x0009D4E8
		[Token(Token = "0x6019B62")]
		[Address(RVA = "0x1290DF0", Offset = "0x128F9F0", VA = "0x181290DF0", Slot = "9")]
		protected override bool CheckTypeActive(SandboxV2AdminMainWorkbenchType type)
		{
			return default(bool);
		}

		// Token: 0x06019B63 RID: 105315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B63")]
		[Address(RVA = "0x1290F40", Offset = "0x128FB40", VA = "0x181290F40", Slot = "10")]
		protected override void OnTypeSelectChanged(SandboxV2AdminMainWorkbenchType selectType)
		{
		}

		// Token: 0x06019B64 RID: 105316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B64")]
		[Address(RVA = "0x1291200", Offset = "0x128FE00", VA = "0x181291200")]
		private void _TutorialOnly_TryRegisterTypeButtonGO()
		{
		}

		// Token: 0x06019B65 RID: 105317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B65")]
		[Address(RVA = "0x1291320", Offset = "0x128FF20", VA = "0x181291320")]
		public SandboxV2AdminMainWorkbenchTypeSelectorView()
		{
		}

		// Token: 0x040202A2 RID: 131746
		[Token(Token = "0x40202A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2WorkbenchTypeDefine[] _typeDefine;

		// Token: 0x040202A3 RID: 131747
		[Token(Token = "0x40202A3")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2AdminMainWorkbenchPanelModelProperty m_cachedProp;

		// Token: 0x040202A4 RID: 131748
		[Token(Token = "0x40202A4")]
		[FieldOffset(Offset = "0x60")]
		private bool m_tutorialIsTypeButtonRegistered;

		// Token: 0x040202A5 RID: 131749
		[Token(Token = "0x40202A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040202A6 RID: 131750
		[Token(Token = "0x40202A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDefinedTypeList;

		// Token: 0x040202A7 RID: 131751
		[Token(Token = "0x40202A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTypeActive;

		// Token: 0x040202A8 RID: 131752
		[Token(Token = "0x40202A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTypeSelectChanged;

		// Token: 0x040202A9 RID: 131753
		[Token(Token = "0x40202A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRegisterTypeButtonGO;

		// Token: 0x040202AA RID: 131754
		[Token(Token = "0x40202AA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
