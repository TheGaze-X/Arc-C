using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E7C RID: 15996
	[Token(Token = "0x2003E7C")]
	public class SpecialOperatorDiagramSelectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018DB3 RID: 101811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DB3")]
		[Address(RVA = "0x1193DA0", Offset = "0x11929A0", VA = "0x181193DA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018DB4 RID: 101812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DB4")]
		[Address(RVA = "0x11938A0", Offset = "0x11924A0", VA = "0x1811938A0")]
		public void Render(SpecialOperatorPointViewBase selectNode, string selectId)
		{
		}

		// Token: 0x06018DB5 RID: 101813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DB5")]
		[Address(RVA = "0x1193B80", Offset = "0x1192780", VA = "0x181193B80")]
		public void Render(SpecialOperatorDiagramPointModel anchorPoint, string selectedId, bool fastMode)
		{
		}

		// Token: 0x06018DB6 RID: 101814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DB6")]
		[Address(RVA = "0x1193F40", Offset = "0x1192B40", VA = "0x181193F40")]
		private void _UpdateSelect(Vector2 anchorPos, string selectedId, bool fastMode)
		{
		}

		// Token: 0x06018DB7 RID: 101815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DB7")]
		[Address(RVA = "0x1193EB0", Offset = "0x1192AB0", VA = "0x181193EB0")]
		private void _UpdatePos(Vector2 anchorPos)
		{
		}

		// Token: 0x06018DB8 RID: 101816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DB8")]
		[Address(RVA = "0x11940C0", Offset = "0x1192CC0", VA = "0x1811940C0")]
		public SpecialOperatorDiagramSelectView()
		{
		}

		// Token: 0x0401E9B0 RID: 125360
		[Token(Token = "0x401E9B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _selectRect;

		// Token: 0x0401E9B1 RID: 125361
		[Token(Token = "0x401E9B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _selectContainer;

		// Token: 0x0401E9B2 RID: 125362
		[Token(Token = "0x401E9B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0401E9B3 RID: 125363
		[Token(Token = "0x401E9B3")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401E9B4 RID: 125364
		[Token(Token = "0x401E9B4")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedSelectId;

		// Token: 0x0401E9B5 RID: 125365
		[Token(Token = "0x401E9B5")]
		[FieldOffset(Offset = "0x48")]
		private AnimationSwitchTween m_selectAnim;

		// Token: 0x0401E9B6 RID: 125366
		[Token(Token = "0x401E9B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E9B7 RID: 125367
		[Token(Token = "0x401E9B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E9B8 RID: 125368
		[Token(Token = "0x401E9B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0401E9B9 RID: 125369
		[Token(Token = "0x401E9B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateSelect;

		// Token: 0x0401E9BA RID: 125370
		[Token(Token = "0x401E9BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdatePos;

		// Token: 0x0401E9BB RID: 125371
		[Token(Token = "0x401E9BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
