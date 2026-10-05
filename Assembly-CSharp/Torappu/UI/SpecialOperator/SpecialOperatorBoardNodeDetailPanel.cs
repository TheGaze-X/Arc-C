using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E9F RID: 16031
	[Token(Token = "0x2003E9F")]
	public class SpecialOperatorBoardNodeDetailPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018E3D RID: 101949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E3D")]
		[Address(RVA = "0x118F920", Offset = "0x118E520", VA = "0x18118F920")]
		public void Render(SpecialOperatorBoardNodeBase model, bool isEnter)
		{
		}

		// Token: 0x06018E3E RID: 101950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018E3E")]
		[Address(RVA = "0x118FED0", Offset = "0x118EAD0", VA = "0x18118FED0")]
		private SpecialOperatorBoardLvlupDetailViewBase _LoadTypeView(SpecialOperatorDetailNodeType type)
		{
			return null;
		}

		// Token: 0x06018E3F RID: 101951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018E3F")]
		[Address(RVA = "0x11901A0", Offset = "0x118EDA0", VA = "0x1811901A0")]
		private SpecialOperatorBoardLvlupDetailViewBase _TryLoadDetailPrefab(SpecialOperatorDetailNodeType type)
		{
			return null;
		}

		// Token: 0x06018E40 RID: 101952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E40")]
		[Address(RVA = "0x118FCE0", Offset = "0x118E8E0", VA = "0x18118FCE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018E41 RID: 101953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E41")]
		[Address(RVA = "0x11902D0", Offset = "0x118EED0", VA = "0x1811902D0")]
		public SpecialOperatorBoardNodeDetailPanel()
		{
		}

		// Token: 0x0401EB05 RID: 125701
		[Token(Token = "0x401EB05")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpecialOperatorBoardLvlupDetailViewBase[] _detailPrefabs;

		// Token: 0x0401EB06 RID: 125702
		[Token(Token = "0x401EB06")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0401EB07 RID: 125703
		[Token(Token = "0x401EB07")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _posHandler;

		// Token: 0x0401EB08 RID: 125704
		[Token(Token = "0x401EB08")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _horiPosRange;

		// Token: 0x0401EB09 RID: 125705
		[Token(Token = "0x401EB09")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _duration;

		// Token: 0x0401EB0A RID: 125706
		[Token(Token = "0x401EB0A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0401EB0B RID: 125707
		[Token(Token = "0x401EB0B")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0401EB0C RID: 125708
		[Token(Token = "0x401EB0C")]
		[FieldOffset(Offset = "0x50")]
		private FadeTranslationSwitchTween m_switchTween;

		// Token: 0x0401EB0D RID: 125709
		[Token(Token = "0x401EB0D")]
		[FieldOffset(Offset = "0x58")]
		private List<SpecialOperatorBoardLvlupDetailViewBase> m_detailViews;

		// Token: 0x0401EB0E RID: 125710
		[Token(Token = "0x401EB0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EB0F RID: 125711
		[Token(Token = "0x401EB0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadTypeView;

		// Token: 0x0401EB10 RID: 125712
		[Token(Token = "0x401EB10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryLoadDetailPrefab;

		// Token: 0x0401EB11 RID: 125713
		[Token(Token = "0x401EB11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EB12 RID: 125714
		[Token(Token = "0x401EB12")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
