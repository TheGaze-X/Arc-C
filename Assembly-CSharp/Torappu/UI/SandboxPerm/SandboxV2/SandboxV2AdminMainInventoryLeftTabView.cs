using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040AB RID: 16555
	[Token(Token = "0x20040AB")]
	public class SandboxV2AdminMainInventoryLeftTabView : SandboxV2AdminMainTypeSelectViewBase<SandboxV2AdminMainInventoryItemShowType, SandboxV2AdminMainInventoryPanelModelProperty>
	{
		// Token: 0x060199C5 RID: 104901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199C5")]
		[Address(RVA = "0x124B8C0", Offset = "0x124A4C0", VA = "0x18124B8C0", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainInventoryPanelModelProperty property)
		{
		}

		// Token: 0x060199C6 RID: 104902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60199C6")]
		[Address(RVA = "0x124B790", Offset = "0x124A390", VA = "0x18124B790", Slot = "8")]
		protected override IList<SandboxV2AdminMainTypeDefine<SandboxV2AdminMainInventoryItemShowType>> GetDefinedTypeList()
		{
			return null;
		}

		// Token: 0x060199C7 RID: 104903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199C7")]
		[Address(RVA = "0x124B7F0", Offset = "0x124A3F0", VA = "0x18124B7F0", Slot = "10")]
		protected override void OnTypeSelectChanged(SandboxV2AdminMainInventoryItemShowType selectType)
		{
		}

		// Token: 0x060199C8 RID: 104904 RVA: 0x0009EC88 File Offset: 0x0009CE88
		[Token(Token = "0x60199C8")]
		[Address(RVA = "0x124B6D0", Offset = "0x124A2D0", VA = "0x18124B6D0", Slot = "11")]
		protected override bool CheckIfShowRacingInfoBtn()
		{
			return default(bool);
		}

		// Token: 0x060199C9 RID: 104905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199C9")]
		[Address(RVA = "0x124BA00", Offset = "0x124A600", VA = "0x18124BA00")]
		public SandboxV2AdminMainInventoryLeftTabView()
		{
		}

		// Token: 0x0401FFE7 RID: 131047
		[Token(Token = "0x401FFE7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2AdminMainInventoryLeftTabDefine[] _typeDefine;

		// Token: 0x0401FFE8 RID: 131048
		[Token(Token = "0x401FFE8")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2AdminMainInventoryPanelModelProperty m_cachedProp;

		// Token: 0x0401FFE9 RID: 131049
		[Token(Token = "0x401FFE9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401FFEA RID: 131050
		[Token(Token = "0x401FFEA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDefinedTypeList;

		// Token: 0x0401FFEB RID: 131051
		[Token(Token = "0x401FFEB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTypeSelectChanged;

		// Token: 0x0401FFEC RID: 131052
		[Token(Token = "0x401FFEC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfShowRacingInfoBtn;

		// Token: 0x0401FFED RID: 131053
		[Token(Token = "0x401FFED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
