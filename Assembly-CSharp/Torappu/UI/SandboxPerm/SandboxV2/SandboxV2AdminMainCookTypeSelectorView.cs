using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200409A RID: 16538
	[Token(Token = "0x200409A")]
	public class SandboxV2AdminMainCookTypeSelectorView : SandboxV2AdminMainTypeSelectViewBase<SandboxV2AdminMainCookType, SandboxV2AdminMainCookPanelModelProperty>
	{
		// Token: 0x06019962 RID: 104802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019962")]
		[Address(RVA = "0x1248C50", Offset = "0x1247850", VA = "0x181248C50", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainCookPanelModelProperty property)
		{
		}

		// Token: 0x06019963 RID: 104803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019963")]
		[Address(RVA = "0x1248B20", Offset = "0x1247720", VA = "0x181248B20", Slot = "8")]
		protected override IList<SandboxV2AdminMainTypeDefine<SandboxV2AdminMainCookType>> GetDefinedTypeList()
		{
			return null;
		}

		// Token: 0x06019964 RID: 104804 RVA: 0x0009EBC8 File Offset: 0x0009CDC8
		[Token(Token = "0x6019964")]
		[Address(RVA = "0x1248A00", Offset = "0x1247600", VA = "0x181248A00", Slot = "9")]
		protected override bool CheckTypeActive(SandboxV2AdminMainCookType type)
		{
			return default(bool);
		}

		// Token: 0x06019965 RID: 104805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019965")]
		[Address(RVA = "0x1248B80", Offset = "0x1247780", VA = "0x181248B80", Slot = "10")]
		protected override void OnTypeSelectChanged(SandboxV2AdminMainCookType selectType)
		{
		}

		// Token: 0x06019966 RID: 104806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019966")]
		[Address(RVA = "0x1248D80", Offset = "0x1247980", VA = "0x181248D80")]
		private void _TutorialOnly_TryRegisterTypeButtonGO()
		{
		}

		// Token: 0x06019967 RID: 104807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019967")]
		[Address(RVA = "0x1248FA0", Offset = "0x1247BA0", VA = "0x181248FA0")]
		public SandboxV2AdminMainCookTypeSelectorView()
		{
		}

		// Token: 0x0401FF1E RID: 130846
		[Token(Token = "0x401FF1E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2CookTypeDefine[] _typeDefine;

		// Token: 0x0401FF1F RID: 130847
		[Token(Token = "0x401FF1F")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2AdminMainCookPanelModelProperty m_cachedProp;

		// Token: 0x0401FF20 RID: 130848
		[Token(Token = "0x401FF20")]
		[FieldOffset(Offset = "0x60")]
		private bool m_tutorialIsTypeButtonRegistered;

		// Token: 0x0401FF21 RID: 130849
		[Token(Token = "0x401FF21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401FF22 RID: 130850
		[Token(Token = "0x401FF22")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDefinedTypeList;

		// Token: 0x0401FF23 RID: 130851
		[Token(Token = "0x401FF23")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTypeActive;

		// Token: 0x0401FF24 RID: 130852
		[Token(Token = "0x401FF24")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTypeSelectChanged;

		// Token: 0x0401FF25 RID: 130853
		[Token(Token = "0x401FF25")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRegisterTypeButtonGO;

		// Token: 0x0401FF26 RID: 130854
		[Token(Token = "0x401FF26")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
