using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E84 RID: 16004
	[Token(Token = "0x2003E84")]
	public class SpecialOperatorBoardEvolveCursorView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018DDF RID: 101855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DDF")]
		[Address(RVA = "0x1185C30", Offset = "0x1184830", VA = "0x181185C30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018DE0 RID: 101856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DE0")]
		[Address(RVA = "0x1185880", Offset = "0x1184480", VA = "0x181185880")]
		public void Render(int level, int maxLevel, int exp, int expMax, bool showPanel, bool isEvolveLevelMax)
		{
		}

		// Token: 0x06018DE1 RID: 101857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DE1")]
		[Address(RVA = "0x11857E0", Offset = "0x11843E0", VA = "0x1811857E0")]
		public void OnCursorClick()
		{
		}

		// Token: 0x06018DE2 RID: 101858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DE2")]
		[Address(RVA = "0x1185D40", Offset = "0x1184940", VA = "0x181185D40")]
		public SpecialOperatorBoardEvolveCursorView()
		{
		}

		// Token: 0x0401E9F8 RID: 125432
		[Token(Token = "0x401E9F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _circle;

		// Token: 0x0401E9F9 RID: 125433
		[Token(Token = "0x401E9F9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _level;

		// Token: 0x0401E9FA RID: 125434
		[Token(Token = "0x401E9FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _expProgress;

		// Token: 0x0401E9FB RID: 125435
		[Token(Token = "0x401E9FB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _levelMax;

		// Token: 0x0401E9FC RID: 125436
		[Token(Token = "0x401E9FC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _panelAnim;

		// Token: 0x0401E9FD RID: 125437
		[Token(Token = "0x401E9FD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelHotspot;

		// Token: 0x0401E9FE RID: 125438
		[Token(Token = "0x401E9FE")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401E9FF RID: 125439
		[Token(Token = "0x401E9FF")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isMax;

		// Token: 0x0401EA00 RID: 125440
		[Token(Token = "0x401EA00")]
		[FieldOffset(Offset = "0x58")]
		private AnimationSwitchTween m_panelTween;

		// Token: 0x0401EA01 RID: 125441
		[Token(Token = "0x401EA01")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EA02 RID: 125442
		[Token(Token = "0x401EA02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EA03 RID: 125443
		[Token(Token = "0x401EA03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EA04 RID: 125444
		[Token(Token = "0x401EA04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCursorClick;

		// Token: 0x0401EA05 RID: 125445
		[Token(Token = "0x401EA05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
