using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004022 RID: 16418
	[Token(Token = "0x2004022")]
	public class SandboxV2CharSelectLogisticsBuffItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060196A1 RID: 104097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196A1")]
		[Address(RVA = "0x121DB20", Offset = "0x121C720", VA = "0x18121DB20")]
		public void Render(SandboxV2LogisticsCharSelectBuffViewModel buffViewModel)
		{
		}

		// Token: 0x060196A2 RID: 104098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196A2")]
		[Address(RVA = "0x121E240", Offset = "0x121CE40", VA = "0x18121E240")]
		private void _InitIfNot(int curBuffCount)
		{
		}

		// Token: 0x060196A3 RID: 104099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196A3")]
		[Address(RVA = "0x121E390", Offset = "0x121CF90", VA = "0x18121E390")]
		private void _RenderBuffBeanRelated(int maxValidCount, int curCount)
		{
		}

		// Token: 0x060196A4 RID: 104100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196A4")]
		[Address(RVA = "0x121E480", Offset = "0x121D080", VA = "0x18121E480")]
		public SandboxV2CharSelectLogisticsBuffItem()
		{
		}

		// Token: 0x0401F9F1 RID: 129521
		[Token(Token = "0x401F9F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Profession Icon")]
		private Image _imgProfession;

		// Token: 0x0401F9F2 RID: 129522
		[Token(Token = "0x401F9F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Profession Icon")]
		private Graphic _graphicIconBg;

		// Token: 0x0401F9F3 RID: 129523
		[Token(Token = "0x401F9F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Profession Icon")]
		private Color _colorBgNormal;

		// Token: 0x0401F9F4 RID: 129524
		[Token(Token = "0x401F9F4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Profession Icon")]
		private Color _colorBgFull;

		// Token: 0x0401F9F5 RID: 129525
		[Token(Token = "0x401F9F5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Profession Icon")]
		private Color _colorIconNormal;

		// Token: 0x0401F9F6 RID: 129526
		[Token(Token = "0x401F9F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Profession Icon")]
		private Color _colorIconFull;

		// Token: 0x0401F9F7 RID: 129527
		[Token(Token = "0x401F9F7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtBuffDesc;

		// Token: 0x0401F9F8 RID: 129528
		[Token(Token = "0x401F9F8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2LogisticsCharBeanView _charBeanView;

		// Token: 0x0401F9F9 RID: 129529
		[Token(Token = "0x401F9F9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _txtBuffCount;

		// Token: 0x0401F9FA RID: 129530
		[Token(Token = "0x401F9FA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _colorCountDefault;

		// Token: 0x0401F9FB RID: 129531
		[Token(Token = "0x401F9FB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _colorCountNormal;

		// Token: 0x0401F9FC RID: 129532
		[Token(Token = "0x401F9FC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _colorCountOverflow;

		// Token: 0x0401F9FD RID: 129533
		[Token(Token = "0x401F9FD")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401F9FE RID: 129534
		[Token(Token = "0x401F9FE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0401F9FF RID: 129535
		[Token(Token = "0x401F9FF")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _panelOverflow;

		// Token: 0x0401FA00 RID: 129536
		[Token(Token = "0x401FA00")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401FA01 RID: 129537
		[Token(Token = "0x401FA01")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isInited;

		// Token: 0x0401FA02 RID: 129538
		[Token(Token = "0x401FA02")]
		[FieldOffset(Offset = "0xE0")]
		private SandboxV2CharSelectLogisticsBuffItem.CanvasNoBuffSwitchTween m_canvasSwitchTween;

		// Token: 0x0401FA03 RID: 129539
		[Token(Token = "0x401FA03")]
		[FieldOffset(Offset = "0xE8")]
		private int m_cachedBuffBeanCnt;

		// Token: 0x0401FA04 RID: 129540
		[Token(Token = "0x401FA04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FA05 RID: 129541
		[Token(Token = "0x401FA05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FA06 RID: 129542
		[Token(Token = "0x401FA06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderBuffBeanRelated;

		// Token: 0x0401FA07 RID: 129543
		[Token(Token = "0x401FA07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004023 RID: 16419
		[Token(Token = "0x2004023")]
		public class CanvasNoBuffSwitchTween : UISwitchTween
		{
			// Token: 0x060196A5 RID: 104101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60196A5")]
			[Address(RVA = "0x1213390", Offset = "0x1211F90", VA = "0x181213390")]
			public CanvasNoBuffSwitchTween(SandboxV2CharSelectLogisticsBuffItem closure)
			{
			}

			// Token: 0x060196A6 RID: 104102 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60196A6")]
			[Address(RVA = "0x1213200", Offset = "0x1211E00", VA = "0x181213200", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060196A7 RID: 104103 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60196A7")]
			[Address(RVA = "0x1213120", Offset = "0x1211D20", VA = "0x181213120", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060196A8 RID: 104104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60196A8")]
			[Address(RVA = "0x12132E0", Offset = "0x1211EE0", VA = "0x1812132E0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060196A9 RID: 104105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60196A9")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0401FA08 RID: 129544
			[Token(Token = "0x401FA08")]
			private const float ALPHA_SHOW = 0.35f;

			// Token: 0x0401FA09 RID: 129545
			[Token(Token = "0x401FA09")]
			private const float ALPHA_HIDE = 1f;

			// Token: 0x0401FA0A RID: 129546
			[Token(Token = "0x401FA0A")]
			[FieldOffset(Offset = "0x48")]
			private SandboxV2CharSelectLogisticsBuffItem m_closure;

			// Token: 0x0401FA0B RID: 129547
			[Token(Token = "0x401FA0B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FA0C RID: 129548
			[Token(Token = "0x401FA0C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0401FA0D RID: 129549
			[Token(Token = "0x401FA0D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0401FA0E RID: 129550
			[Token(Token = "0x401FA0E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
