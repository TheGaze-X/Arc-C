using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004204 RID: 16900
	[Token(Token = "0x2004204")]
	public class SandboxV2DungeonLogisticsEffectFloatPanel : SandboxV2FloatPanel
	{
		// Token: 0x0601A13D RID: 106813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A13D")]
		[Address(RVA = "0x12EB3A0", Offset = "0x12E9FA0", VA = "0x1812EB3A0", Slot = "4")]
		protected override void SetShowStatus(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x0601A13E RID: 106814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A13E")]
		[Address(RVA = "0x12EB2F0", Offset = "0x12E9EF0", VA = "0x1812EB2F0")]
		public void Render(SandboxV2DungeonMiscLogisticsEffectViewModel logisticsViewModel)
		{
		}

		// Token: 0x0601A13F RID: 106815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A13F")]
		[Address(RVA = "0x12EB470", Offset = "0x12EA070", VA = "0x1812EB470")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A140 RID: 106816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A140")]
		[Address(RVA = "0x12EB630", Offset = "0x12EA230", VA = "0x1812EB630")]
		public SandboxV2DungeonLogisticsEffectFloatPanel()
		{
		}

		// Token: 0x04020DAD RID: 134573
		[Token(Token = "0x4020DAD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x04020DAE RID: 134574
		[Token(Token = "0x4020DAE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rootRectTrans;

		// Token: 0x04020DAF RID: 134575
		[Token(Token = "0x4020DAF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _detailShowPos;

		// Token: 0x04020DB0 RID: 134576
		[Token(Token = "0x4020DB0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _detailHidePos;

		// Token: 0x04020DB1 RID: 134577
		[Token(Token = "0x4020DB1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2DungeonLogisticsEffectView _viewPrefab;

		// Token: 0x04020DB2 RID: 134578
		[Token(Token = "0x4020DB2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x04020DB3 RID: 134579
		[Token(Token = "0x4020DB3")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x04020DB4 RID: 134580
		[Token(Token = "0x4020DB4")]
		[FieldOffset(Offset = "0x68")]
		private FadeTranslationSwitchTween m_showTween;

		// Token: 0x04020DB5 RID: 134581
		[Token(Token = "0x4020DB5")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2DungeonLogisticsEffectView m_view;

		// Token: 0x04020DB6 RID: 134582
		[Token(Token = "0x4020DB6")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DungeonMiscLogisticsEffectViewModel m_cachedViewModel;

		// Token: 0x04020DB7 RID: 134583
		[Token(Token = "0x4020DB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x04020DB8 RID: 134584
		[Token(Token = "0x4020DB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020DB9 RID: 134585
		[Token(Token = "0x4020DB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020DBA RID: 134586
		[Token(Token = "0x4020DBA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
