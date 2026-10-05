using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039C7 RID: 14791
	[Token(Token = "0x20039C7")]
	public class TwoStateAnimationSwitcher : TwoStateSwitcher, IHotfixable
	{
		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x060175D8 RID: 95704 RVA: 0x000962D0 File Offset: 0x000944D0
		[Token(Token = "0x170037F4")]
		public override bool setWithAwake
		{
			[Token(Token = "0x60175D8")]
			[Address(RVA = "0xFB9780", Offset = "0xFB8380", VA = "0x180FB9780", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060175D9 RID: 95705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175D9")]
		[Address(RVA = "0xFB94C0", Offset = "0xFB80C0", VA = "0x180FB94C0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060175DA RID: 95706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175DA")]
		[Address(RVA = "0xFB95E0", Offset = "0xFB81E0", VA = "0x180FB95E0", Slot = "10")]
		protected override void OnResetState(TwoStateSwitcher.State newState)
		{
		}

		// Token: 0x060175DB RID: 95707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175DB")]
		[Address(RVA = "0xFB9430", Offset = "0xFB8030", VA = "0x180FB9430", Slot = "11")]
		protected override void OnChangeState(TwoStateSwitcher.State newState)
		{
		}

		// Token: 0x060175DC RID: 95708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175DC")]
		[Address(RVA = "0xFB96D0", Offset = "0xFB82D0", VA = "0x180FB96D0")]
		public TwoStateAnimationSwitcher()
		{
		}

		// Token: 0x060175DD RID: 95709 RVA: 0x000962E8 File Offset: 0x000944E8
		[Token(Token = "0x60175DD")]
		[Address(RVA = "0xFB9670", Offset = "0xFB8270", VA = "0x180FB9670")]
		private bool <>xLuaBaseProxy_get_setWithAwake()
		{
			return default(bool);
		}

		// Token: 0x0401C378 RID: 115576
		[Token(Token = "0x401C378")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animSelect;

		// Token: 0x0401C379 RID: 115577
		[Token(Token = "0x401C379")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _inactivateTargetIfHide;

		// Token: 0x0401C37A RID: 115578
		[Token(Token = "0x401C37A")]
		[FieldOffset(Offset = "0x48")]
		private UISwitchTween m_selectTween;

		// Token: 0x0401C37B RID: 115579
		[Token(Token = "0x401C37B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_setWithAwake;

		// Token: 0x0401C37C RID: 115580
		[Token(Token = "0x401C37C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401C37D RID: 115581
		[Token(Token = "0x401C37D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResetState;

		// Token: 0x0401C37E RID: 115582
		[Token(Token = "0x401C37E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnChangeState;

		// Token: 0x0401C37F RID: 115583
		[Token(Token = "0x401C37F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
