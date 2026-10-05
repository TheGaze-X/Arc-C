using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	public class TwoPhaseButtonWidget : MonoBehaviour, ExclusiveSelectionGroup.ITarget, IHotfixable
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AB")]
		public UnityEvent onPreClick
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x5538280", Offset = "0x5536E80", VA = "0x185538280")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AC")]
		public UnityEvent onClick
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x5538220", Offset = "0x5536E20", VA = "0x185538220")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AD")]
		public UnityEvent onResetToPreClick
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x55382E0", Offset = "0x5536EE0", VA = "0x1855382E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x5537B20", Offset = "0x5536720", VA = "0x185537B20")]
		private void Start()
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x5537930", Offset = "0x5536530", VA = "0x185537930")]
		private void OnDestroy()
		{
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x5537AA0", Offset = "0x55366A0", VA = "0x185537AA0", Slot = "4")]
		public void SetGroup(ExclusiveSelectionGroup group)
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x5537720", Offset = "0x5536320", VA = "0x185537720", Slot = "5")]
		public void OnConfirmState(bool isSelected)
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00006B6C File Offset: 0x00004D6C
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x5537530", Offset = "0x5536130", VA = "0x185537530")]
		public bool ConfirmPreClick()
		{
			return default(bool);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00006B84 File Offset: 0x00004D84
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x5537470", Offset = "0x5536070", VA = "0x185537470")]
		public bool ConfirmPreClick(float transition, TwoPhaseButtonWidget.RevertCountdown revertCountdown)
		{
			return default(bool);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x55379C0", Offset = "0x55365C0", VA = "0x1855379C0")]
		public void Reset()
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x5537650", Offset = "0x5536250", VA = "0x185537650")]
		public void OnButtonClick()
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x5537E60", Offset = "0x5536A60", VA = "0x185537E60")]
		private void _OnRevertPreClickTimeout()
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00006B9C File Offset: 0x00004D9C
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x5537ED0", Offset = "0x5536AD0", VA = "0x185537ED0")]
		private bool _RequestSetState(bool isSelected)
		{
			return default(bool);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x5537C20", Offset = "0x5536820", VA = "0x185537C20")]
		private void _ConfirmPreClickImpl()
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x5537F80", Offset = "0x5536B80", VA = "0x185537F80")]
		private void _ResetPreClickImpl()
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x5538110", Offset = "0x5536D10", VA = "0x185538110")]
		public TwoPhaseButtonWidget()
		{
		}

		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent _onPreClick;

		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent _onClick;

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _onResetToPreClick;

		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("GameObject which contains ITwoStateSwitcher.")]
		private GameObject _panelSwitcher;

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _transitionPreClickToClickable;

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TwoPhaseButtonWidget.RevertCountdown _revertCountdown;

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x44")]
		private int m_timer;

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x48")]
		private TwoPhaseButtonWidget.State m_state;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x50")]
		private TimeTransiting m_transiting;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x68")]
		private float m_cachedTransition;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x6C")]
		private TwoPhaseButtonWidget.RevertCountdown m_cachedRevertCountdown;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x78")]
		private ExclusiveSelectionGroup m_group;

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x80")]
		private ITwoStateSwitcher m_switcher;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate148 __Hotfix0_get_onPreClick;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate148 __Hotfix0_get_onClick;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate148 __Hotfix0_get_onResetToPreClick;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Start;

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnDestroy;

		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate0 __Hotfix0_SetGroup;

		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate6 __Hotfix0_OnConfirmState;

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate21 __Hotfix0_ConfirmPreClick;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate149 __Hotfix1_ConfirmPreClick;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Reset;

		// Token: 0x0400070C RID: 1804
		[Token(Token = "0x400070C")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnButtonClick;

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate1 __Hotfix0__OnRevertPreClickTimeout;

		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate34 __Hotfix0__RequestSetState;

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ConfirmPreClickImpl;

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ResetPreClickImpl;

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x0200014C RID: 332
		[Token(Token = "0x200014C")]
		[Serializable]
		public struct RevertCountdown : IHotfixable
		{
			// Token: 0x060007E3 RID: 2019 RVA: 0x00006BB4 File Offset: 0x00004DB4
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x5531EB0", Offset = "0x5530AB0", VA = "0x185531EB0")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x04000712 RID: 1810
			[Token(Token = "0x4000712")]
			[FieldOffset(Offset = "0x0")]
			public float countdown;

			// Token: 0x04000713 RID: 1811
			[Token(Token = "0x4000713")]
			[FieldOffset(Offset = "0x4")]
			public float transition;

			// Token: 0x04000714 RID: 1812
			[Token(Token = "0x4000714")]
			[FieldOffset(Offset = "0x0")]
			[NonSerialized]
			public static readonly TwoPhaseButtonWidget.RevertCountdown EMPTY;

			// Token: 0x04000715 RID: 1813
			[Token(Token = "0x4000715")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate147 __Hotfix0_IsValid;
		}

		// Token: 0x0200014D RID: 333
		[Token(Token = "0x200014D")]
		private enum State
		{
			// Token: 0x04000717 RID: 1815
			[Token(Token = "0x4000717")]
			PRE_CLICK,
			// Token: 0x04000718 RID: 1816
			[Token(Token = "0x4000718")]
			CLICKABLE
		}
	}
}
