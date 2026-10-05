using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039CC RID: 14796
	[Token(Token = "0x20039CC")]
	public class TwoStateToggle : MonoBehaviour, IHotfixable
	{
		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x060175FB RID: 95739 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060175FC RID: 95740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037FB")]
		public Action<TwoStateToggle.State> onToggle
		{
			[Token(Token = "0x60175FB")]
			[Address(RVA = "0xFBAA90", Offset = "0xFB9690", VA = "0x180FBAA90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60175FC")]
			[Address(RVA = "0xFBAC00", Offset = "0xFB9800", VA = "0x180FBAC00")]
			set
			{
			}
		}

		// Token: 0x060175FD RID: 95741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175FD")]
		[Address(RVA = "0xFBA870", Offset = "0xFB9470", VA = "0x180FBA870")]
		private void Awake()
		{
		}

		// Token: 0x060175FE RID: 95742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175FE")]
		[Address(RVA = "0xFBA900", Offset = "0xFB9500", VA = "0x180FBA900")]
		public void Toggle()
		{
		}

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x060175FF RID: 95743 RVA: 0x00096390 File Offset: 0x00094590
		// (set) Token: 0x06017600 RID: 95744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037FC")]
		[Inspect]
		public TwoStateToggle.State state
		{
			[Token(Token = "0x60175FF")]
			[Address(RVA = "0xFBABA0", Offset = "0xFB97A0", VA = "0x180FBABA0")]
			get
			{
				return TwoStateToggle.State.UNSELECT;
			}
			[Token(Token = "0x6017600")]
			[Address(RVA = "0xFBAD00", Offset = "0xFB9900", VA = "0x180FBAD00")]
			set
			{
			}
		}

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x06017601 RID: 95745 RVA: 0x000963A8 File Offset: 0x000945A8
		// (set) Token: 0x06017602 RID: 95746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037FD")]
		public bool selected
		{
			[Token(Token = "0x6017601")]
			[Address(RVA = "0xFBAAF0", Offset = "0xFB96F0", VA = "0x180FBAAF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017602")]
			[Address(RVA = "0xFBAC80", Offset = "0xFB9880", VA = "0x180FBAC80")]
			set
			{
			}
		}

		// Token: 0x06017603 RID: 95747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017603")]
		[Address(RVA = "0xFBA990", Offset = "0xFB9590", VA = "0x180FBA990")]
		private void _ChangeState(TwoStateToggle.State newState)
		{
		}

		// Token: 0x06017604 RID: 95748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017604")]
		[Address(RVA = "0xFBAA30", Offset = "0xFB9630", VA = "0x180FBAA30")]
		public TwoStateToggle()
		{
		}

		// Token: 0x0401C3AC RID: 115628
		[Token(Token = "0x401C3AC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _unselect;

		// Token: 0x0401C3AD RID: 115629
		[Token(Token = "0x401C3AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _select;

		// Token: 0x0401C3AE RID: 115630
		[Token(Token = "0x401C3AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _setWithAwake;

		// Token: 0x0401C3AF RID: 115631
		[Token(Token = "0x401C3AF")]
		[FieldOffset(Offset = "0x2C")]
		private TwoStateToggle.State m_state;

		// Token: 0x0401C3B0 RID: 115632
		[Token(Token = "0x401C3B0")]
		[FieldOffset(Offset = "0x30")]
		private Action<TwoStateToggle.State> m_stateToggleListener;

		// Token: 0x0401C3B1 RID: 115633
		[Token(Token = "0x401C3B1")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401C3B2 RID: 115634
		[Token(Token = "0x401C3B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onToggle;

		// Token: 0x0401C3B3 RID: 115635
		[Token(Token = "0x401C3B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onToggle;

		// Token: 0x0401C3B4 RID: 115636
		[Token(Token = "0x401C3B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C3B5 RID: 115637
		[Token(Token = "0x401C3B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Toggle;

		// Token: 0x0401C3B6 RID: 115638
		[Token(Token = "0x401C3B6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0401C3B7 RID: 115639
		[Token(Token = "0x401C3B7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x0401C3B8 RID: 115640
		[Token(Token = "0x401C3B8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selected;

		// Token: 0x0401C3B9 RID: 115641
		[Token(Token = "0x401C3B9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_selected;

		// Token: 0x0401C3BA RID: 115642
		[Token(Token = "0x401C3BA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ChangeState;

		// Token: 0x0401C3BB RID: 115643
		[Token(Token = "0x401C3BB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039CD RID: 14797
		[Token(Token = "0x20039CD")]
		public enum State
		{
			// Token: 0x0401C3BD RID: 115645
			[Token(Token = "0x401C3BD")]
			UNSELECT,
			// Token: 0x0401C3BE RID: 115646
			[Token(Token = "0x401C3BE")]
			SELECT
		}
	}
}
