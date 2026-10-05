using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EFA RID: 28410
	[Token(Token = "0x2006EFA")]
	public class ActMultiV3InverseToggleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005F4A RID: 24394
		// (get) Token: 0x060285D3 RID: 165331 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060285D4 RID: 165332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F4A")]
		public Action onToggleClick
		{
			[Token(Token = "0x60285D3")]
			[Address(RVA = "0x23B9200", Offset = "0x23B7E00", VA = "0x1823B9200")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60285D4")]
			[Address(RVA = "0x23B9260", Offset = "0x23B7E60", VA = "0x1823B9260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060285D5 RID: 165333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285D5")]
		[Address(RVA = "0x23B9000", Offset = "0x23B7C00", VA = "0x1823B9000")]
		public void Render(bool isInverseSelect, bool isInverseUnlock, bool showNewTrack)
		{
		}

		// Token: 0x060285D6 RID: 165334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285D6")]
		[Address(RVA = "0x23B8EF0", Offset = "0x23B7AF0", VA = "0x1823B8EF0")]
		public void EventOnToggleClick()
		{
		}

		// Token: 0x060285D7 RID: 165335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285D7")]
		[Address(RVA = "0x23B91A0", Offset = "0x23B7DA0", VA = "0x1823B91A0")]
		public ActMultiV3InverseToggleView()
		{
		}

		// Token: 0x0403962A RID: 235050
		[Token(Token = "0x403962A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x0403962B RID: 235051
		[Token(Token = "0x403962B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _inverseUnlockState;

		// Token: 0x0403962C RID: 235052
		[Token(Token = "0x403962C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newTrackGO;

		// Token: 0x0403962E RID: 235054
		[Token(Token = "0x403962E")]
		[FieldOffset(Offset = "0x40")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0403962F RID: 235055
		[Token(Token = "0x403962F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onToggleClick;

		// Token: 0x04039630 RID: 235056
		[Token(Token = "0x4039630")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onToggleClick;

		// Token: 0x04039631 RID: 235057
		[Token(Token = "0x4039631")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039632 RID: 235058
		[Token(Token = "0x4039632")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnToggleClick;

		// Token: 0x04039633 RID: 235059
		[Token(Token = "0x4039633")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
