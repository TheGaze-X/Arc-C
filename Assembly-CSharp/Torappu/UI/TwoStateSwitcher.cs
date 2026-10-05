using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039CA RID: 14794
	[Token(Token = "0x20039CA")]
	public abstract class TwoStateSwitcher : MonoBehaviour, ITwoStateSwitcher, IHotfixable
	{
		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x060175E8 RID: 95720 RVA: 0x00096330 File Offset: 0x00094530
		// (set) Token: 0x060175E9 RID: 95721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037F6")]
		[Inspect]
		public TwoStateSwitcher.State state
		{
			[Token(Token = "0x60175E8")]
			[Address(RVA = "0xFBA3B0", Offset = "0xFB8FB0", VA = "0x180FBA3B0")]
			get
			{
				return TwoStateSwitcher.State.UNSELECT;
			}
			[Token(Token = "0x60175E9")]
			[Address(RVA = "0xFBA660", Offset = "0xFB9260", VA = "0x180FBA660")]
			set
			{
			}
		}

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x060175EA RID: 95722 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060175EB RID: 95723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037F7")]
		public Action<TwoStateSwitcher.State> onToggle
		{
			[Token(Token = "0x60175EA")]
			[Address(RVA = "0xFBA2F0", Offset = "0xFB8EF0", VA = "0x180FBA2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60175EB")]
			[Address(RVA = "0xFBA510", Offset = "0xFB9110", VA = "0x180FBA510")]
			set
			{
			}
		}

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x060175EC RID: 95724 RVA: 0x00096348 File Offset: 0x00094548
		// (set) Token: 0x060175ED RID: 95725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037F8")]
		public bool selected
		{
			[Token(Token = "0x60175EC")]
			[Address(RVA = "0xFBA350", Offset = "0xFB8F50", VA = "0x180FBA350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60175ED")]
			[Address(RVA = "0xFBA590", Offset = "0xFB9190", VA = "0x180FBA590")]
			set
			{
			}
		}

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x060175EE RID: 95726 RVA: 0x00096360 File Offset: 0x00094560
		// (set) Token: 0x060175EF RID: 95727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037F9")]
		public bool isClickable
		{
			[Token(Token = "0x60175EE")]
			[Address(RVA = "0xFBA260", Offset = "0xFB8E60", VA = "0x180FBA260", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60175EF")]
			[Address(RVA = "0xFBA410", Offset = "0xFB9010", VA = "0x180FBA410", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x060175F0 RID: 95728 RVA: 0x00096378 File Offset: 0x00094578
		[Token(Token = "0x170037FA")]
		public virtual bool setWithAwake
		{
			[Token(Token = "0x60175F0")]
			[Address(RVA = "0xFB9670", Offset = "0xFB8270", VA = "0x180FB9670", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060175F1 RID: 95729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175F1")]
		[Address(RVA = "0xFB9F10", Offset = "0xFB8B10", VA = "0x180FB9F10", Slot = "7")]
		public void ResetButton(bool isClickable)
		{
		}

		// Token: 0x060175F2 RID: 95730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175F2")]
		[Address(RVA = "0xFB9F90", Offset = "0xFB8B90", VA = "0x180FB9F90")]
		public void ResetState(TwoStateSwitcher.State newState)
		{
		}

		// Token: 0x060175F3 RID: 95731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175F3")]
		[Address(RVA = "0xFBA030", Offset = "0xFB8C30", VA = "0x180FBA030")]
		public void Toggle()
		{
		}

		// Token: 0x060175F4 RID: 95732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175F4")]
		[Address(RVA = "0xFB9E70", Offset = "0xFB8A70", VA = "0x180FB9E70")]
		private void Awake()
		{
		}

		// Token: 0x060175F5 RID: 95733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175F5")]
		[Address(RVA = "0xFBA0C0", Offset = "0xFB8CC0", VA = "0x180FBA0C0")]
		private void _ChangeState(TwoStateSwitcher.State newState)
		{
		}

		// Token: 0x060175F6 RID: 95734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175F6")]
		[Address(RVA = "0xFBA160", Offset = "0xFB8D60", VA = "0x180FBA160")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060175F7 RID: 95735
		[Token(Token = "0x60175F7")]
		protected abstract void OnInit();

		// Token: 0x060175F8 RID: 95736
		[Token(Token = "0x60175F8")]
		protected abstract void OnResetState(TwoStateSwitcher.State newState);

		// Token: 0x060175F9 RID: 95737
		[Token(Token = "0x60175F9")]
		protected abstract void OnChangeState(TwoStateSwitcher.State newState);

		// Token: 0x060175FA RID: 95738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175FA")]
		[Address(RVA = "0xFBA1F0", Offset = "0xFB8DF0", VA = "0x180FBA1F0")]
		protected TwoStateSwitcher()
		{
		}

		// Token: 0x0401C393 RID: 115603
		[Token(Token = "0x401C393")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _setWithAwake;

		// Token: 0x0401C394 RID: 115604
		[Token(Token = "0x401C394")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		protected bool _ignoreTimeScale;

		// Token: 0x0401C395 RID: 115605
		[Token(Token = "0x401C395")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected float _fadeTime;

		// Token: 0x0401C396 RID: 115606
		[Token(Token = "0x401C396")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasInited;

		// Token: 0x0401C397 RID: 115607
		[Token(Token = "0x401C397")]
		[FieldOffset(Offset = "0x24")]
		private TwoStateSwitcher.State m_state;

		// Token: 0x0401C398 RID: 115608
		[Token(Token = "0x401C398")]
		[FieldOffset(Offset = "0x28")]
		private Action<TwoStateSwitcher.State> m_stateToggleListener;

		// Token: 0x0401C399 RID: 115609
		[Token(Token = "0x401C399")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0401C39A RID: 115610
		[Token(Token = "0x401C39A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x0401C39B RID: 115611
		[Token(Token = "0x401C39B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onToggle;

		// Token: 0x0401C39C RID: 115612
		[Token(Token = "0x401C39C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onToggle;

		// Token: 0x0401C39D RID: 115613
		[Token(Token = "0x401C39D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selected;

		// Token: 0x0401C39E RID: 115614
		[Token(Token = "0x401C39E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selected;

		// Token: 0x0401C39F RID: 115615
		[Token(Token = "0x401C39F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isClickable;

		// Token: 0x0401C3A0 RID: 115616
		[Token(Token = "0x401C3A0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isClickable;

		// Token: 0x0401C3A1 RID: 115617
		[Token(Token = "0x401C3A1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_setWithAwake;

		// Token: 0x0401C3A2 RID: 115618
		[Token(Token = "0x401C3A2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ResetButton;

		// Token: 0x0401C3A3 RID: 115619
		[Token(Token = "0x401C3A3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ResetState;

		// Token: 0x0401C3A4 RID: 115620
		[Token(Token = "0x401C3A4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Toggle;

		// Token: 0x0401C3A5 RID: 115621
		[Token(Token = "0x401C3A5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C3A6 RID: 115622
		[Token(Token = "0x401C3A6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ChangeState;

		// Token: 0x0401C3A7 RID: 115623
		[Token(Token = "0x401C3A7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C3A8 RID: 115624
		[Token(Token = "0x401C3A8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039CB RID: 14795
		[Token(Token = "0x20039CB")]
		public enum State
		{
			// Token: 0x0401C3AA RID: 115626
			[Token(Token = "0x401C3AA")]
			UNSELECT,
			// Token: 0x0401C3AB RID: 115627
			[Token(Token = "0x401C3AB")]
			SELECT
		}
	}
}
