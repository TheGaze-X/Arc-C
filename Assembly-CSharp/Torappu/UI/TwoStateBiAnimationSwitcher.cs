using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039C8 RID: 14792
	[Token(Token = "0x20039C8")]
	public class TwoStateBiAnimationSwitcher : TwoStateSwitcher, IHotfixable
	{
		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x060175DE RID: 95710 RVA: 0x00096300 File Offset: 0x00094500
		[Token(Token = "0x170037F5")]
		public override bool setWithAwake
		{
			[Token(Token = "0x60175DE")]
			[Address(RVA = "0xFB9AF0", Offset = "0xFB86F0", VA = "0x180FB9AF0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060175DF RID: 95711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175DF")]
		[Address(RVA = "0xFB9870", Offset = "0xFB8470", VA = "0x180FB9870", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060175E0 RID: 95712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175E0")]
		[Address(RVA = "0xFB99B0", Offset = "0xFB85B0", VA = "0x180FB99B0", Slot = "10")]
		protected override void OnResetState(TwoStateSwitcher.State newState)
		{
		}

		// Token: 0x060175E1 RID: 95713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175E1")]
		[Address(RVA = "0xFB97E0", Offset = "0xFB83E0", VA = "0x180FB97E0", Slot = "11")]
		protected override void OnChangeState(TwoStateSwitcher.State newState)
		{
		}

		// Token: 0x060175E2 RID: 95714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175E2")]
		[Address(RVA = "0xFB9A40", Offset = "0xFB8640", VA = "0x180FB9A40")]
		public TwoStateBiAnimationSwitcher()
		{
		}

		// Token: 0x060175E3 RID: 95715 RVA: 0x00096318 File Offset: 0x00094518
		[Token(Token = "0x60175E3")]
		[Address(RVA = "0xFB9670", Offset = "0xFB8270", VA = "0x180FB9670")]
		private bool <>xLuaBaseProxy_get_setWithAwake()
		{
			return default(bool);
		}

		// Token: 0x0401C380 RID: 115584
		[Token(Token = "0x401C380")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animSelect;

		// Token: 0x0401C381 RID: 115585
		[Token(Token = "0x401C381")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animUnselect;

		// Token: 0x0401C382 RID: 115586
		[Token(Token = "0x401C382")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _appearTime;

		// Token: 0x0401C383 RID: 115587
		[Token(Token = "0x401C383")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool _inactivateTargetIfHide;

		// Token: 0x0401C384 RID: 115588
		[Token(Token = "0x401C384")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _target;

		// Token: 0x0401C385 RID: 115589
		[Token(Token = "0x401C385")]
		[FieldOffset(Offset = "0x60")]
		private UIBiAnimClipSwitchTween m_switchTween;

		// Token: 0x0401C386 RID: 115590
		[Token(Token = "0x401C386")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_setWithAwake;

		// Token: 0x0401C387 RID: 115591
		[Token(Token = "0x401C387")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401C388 RID: 115592
		[Token(Token = "0x401C388")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResetState;

		// Token: 0x0401C389 RID: 115593
		[Token(Token = "0x401C389")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnChangeState;

		// Token: 0x0401C38A RID: 115594
		[Token(Token = "0x401C38A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
