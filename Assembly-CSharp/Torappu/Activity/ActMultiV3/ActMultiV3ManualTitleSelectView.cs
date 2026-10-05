using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F6C RID: 28524
	[Token(Token = "0x2006F6C")]
	public class ActMultiV3ManualTitleSelectView : DataBinder<ActMultiV3TitleSelectProperty>, IHotfixable
	{
		// Token: 0x060287F2 RID: 165874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287F2")]
		[Address(RVA = "0x23C9940", Offset = "0x23C8540", VA = "0x1823C9940", Slot = "7")]
		public override void OnValueChanged(ActMultiV3TitleSelectProperty property)
		{
		}

		// Token: 0x060287F3 RID: 165875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287F3")]
		[Address(RVA = "0x23C98B0", Offset = "0x23C84B0", VA = "0x1823C98B0")]
		public void OnConfirmTitle()
		{
		}

		// Token: 0x060287F4 RID: 165876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287F4")]
		[Address(RVA = "0x23C9B70", Offset = "0x23C8770", VA = "0x1823C9B70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287F5 RID: 165877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287F5")]
		[Address(RVA = "0x23C9CA0", Offset = "0x23C88A0", VA = "0x1823C9CA0")]
		public ActMultiV3ManualTitleSelectView()
		{
		}

		// Token: 0x04039A37 RID: 236087
		[Token(Token = "0x4039A37")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _commitToggle;

		// Token: 0x04039A38 RID: 236088
		[Token(Token = "0x4039A38")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActMultiV3TitlePagerView _prefixPagerView;

		// Token: 0x04039A39 RID: 236089
		[Token(Token = "0x4039A39")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActMultiV3TitlePagerView _suffixPagerView;

		// Token: 0x04039A3A RID: 236090
		[Token(Token = "0x4039A3A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _scrollAnimLocation;

		// Token: 0x04039A3B RID: 236091
		[Token(Token = "0x4039A3B")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x04039A3C RID: 236092
		[Token(Token = "0x4039A3C")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039A3D RID: 236093
		[Token(Token = "0x4039A3D")]
		[FieldOffset(Offset = "0x60")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x04039A3E RID: 236094
		[Token(Token = "0x4039A3E")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedInitSeqNum;

		// Token: 0x04039A3F RID: 236095
		[Token(Token = "0x4039A3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04039A40 RID: 236096
		[Token(Token = "0x4039A40")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnConfirmTitle;

		// Token: 0x04039A41 RID: 236097
		[Token(Token = "0x4039A41")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039A42 RID: 236098
		[Token(Token = "0x4039A42")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
