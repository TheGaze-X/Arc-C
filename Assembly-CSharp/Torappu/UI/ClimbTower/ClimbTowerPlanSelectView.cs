using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CF0 RID: 23792
	[Token(Token = "0x2005CF0")]
	public class ClimbTowerPlanSelectView : DataBinder<BoolProperty>
	{
		// Token: 0x17005102 RID: 20738
		// (get) Token: 0x06022725 RID: 141093 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022726 RID: 141094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005102")]
		public Action<bool> onPlanClick
		{
			[Token(Token = "0x6022725")]
			[Address(RVA = "0x1CD5D00", Offset = "0x1CD4900", VA = "0x181CD5D00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022726")]
			[Address(RVA = "0x1CD5D60", Offset = "0x1CD4960", VA = "0x181CD5D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022727 RID: 141095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022727")]
		[Address(RVA = "0x1CD5B10", Offset = "0x1CD4710", VA = "0x181CD5B10", Slot = "7")]
		public override void OnValueChanged(BoolProperty property)
		{
		}

		// Token: 0x06022728 RID: 141096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022728")]
		[Address(RVA = "0x1CD5C90", Offset = "0x1CD4890", VA = "0x181CD5C90")]
		public ClimbTowerPlanSelectView()
		{
		}

		// Token: 0x0402F58D RID: 193933
		[Token(Token = "0x402F58D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClimbTowerPlanItemView[] planItemViewList;

		// Token: 0x0402F58F RID: 193935
		[Token(Token = "0x402F58F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onPlanClick;

		// Token: 0x0402F590 RID: 193936
		[Token(Token = "0x402F590")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onPlanClick;

		// Token: 0x0402F591 RID: 193937
		[Token(Token = "0x402F591")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F592 RID: 193938
		[Token(Token = "0x402F592")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
