using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040B3 RID: 16563
	[Token(Token = "0x20040B3")]
	public class SandboxV2AdminMainBottomView : SandboxV2AdminMainViewBase
	{
		// Token: 0x060199FE RID: 104958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60199FE")]
		[Address(RVA = "0x12738C0", Offset = "0x12724C0", VA = "0x1812738C0", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainModelProperty property)
		{
		}

		// Token: 0x060199FF RID: 104959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60199FF")]
		[Address(RVA = "0x1274370", Offset = "0x1272F70", VA = "0x181274370")]
		private IEnumerator _TweenSelectedMarkTo(SandboxV2AdminMainPanelType panelType, bool immediately)
		{
			return null;
		}

		// Token: 0x06019A00 RID: 104960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A00")]
		[Address(RVA = "0x1274450", Offset = "0x1273050", VA = "0x181274450")]
		private void _UpdateTab(SandboxV2AdminMainPanelType panelType, bool immediately)
		{
		}

		// Token: 0x06019A01 RID: 104961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A01")]
		[Address(RVA = "0x1274000", Offset = "0x1272C00", VA = "0x181274000")]
		private void _EventTabClick(SandboxV2AdminMainPanelType panelType)
		{
		}

		// Token: 0x06019A02 RID: 104962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A02")]
		[Address(RVA = "0x1274200", Offset = "0x1272E00", VA = "0x181274200")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019A03 RID: 104963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A03")]
		[Address(RVA = "0x1274560", Offset = "0x1273160", VA = "0x181274560")]
		public SandboxV2AdminMainBottomView()
		{
		}

		// Token: 0x04020035 RID: 131125
		[Token(Token = "0x4020035")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2AdminMainBottomTab[] _tabs;

		// Token: 0x04020036 RID: 131126
		[Token(Token = "0x4020036")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _selectedMark;

		// Token: 0x04020037 RID: 131127
		[Token(Token = "0x4020037")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _gradient;

		// Token: 0x04020038 RID: 131128
		[Token(Token = "0x4020038")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x04020039 RID: 131129
		[Token(Token = "0x4020039")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2AdminMainModelProperty m_cachedProp;

		// Token: 0x0402003A RID: 131130
		[Token(Token = "0x402003A")]
		[FieldOffset(Offset = "0x50")]
		private Tweener m_tween;

		// Token: 0x0402003B RID: 131131
		[Token(Token = "0x402003B")]
		private const float TWEEN_DUR = 0.6f;

		// Token: 0x0402003C RID: 131132
		[Token(Token = "0x402003C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402003D RID: 131133
		[Token(Token = "0x402003D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TweenSelectedMarkTo;

		// Token: 0x0402003E RID: 131134
		[Token(Token = "0x402003E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateTab;

		// Token: 0x0402003F RID: 131135
		[Token(Token = "0x402003F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventTabClick;

		// Token: 0x04020040 RID: 131136
		[Token(Token = "0x4020040")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020041 RID: 131137
		[Token(Token = "0x4020041")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
