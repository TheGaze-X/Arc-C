using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038ED RID: 14573
	[Token(Token = "0x20038ED")]
	public class UILimitedLayoutFitter : LayoutGroup, IHotfixable
	{
		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x06017088 RID: 94344 RVA: 0x00094710 File Offset: 0x00092910
		[Token(Token = "0x170036F2")]
		private float limitedWidth
		{
			[Token(Token = "0x6017088")]
			[Address(RVA = "0xF78730", Offset = "0xF77330", VA = "0x180F78730")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x06017089 RID: 94345 RVA: 0x00094728 File Offset: 0x00092928
		[Token(Token = "0x170036F3")]
		private float limitedHeight
		{
			[Token(Token = "0x6017089")]
			[Address(RVA = "0xF786C0", Offset = "0xF772C0", VA = "0x180F786C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0601708A RID: 94346 RVA: 0x00094740 File Offset: 0x00092940
		[Token(Token = "0x170036F4")]
		public override float minWidth
		{
			[Token(Token = "0x601708A")]
			[Address(RVA = "0xF78840", Offset = "0xF77440", VA = "0x180F78840", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x0601708B RID: 94347 RVA: 0x00094758 File Offset: 0x00092958
		[Token(Token = "0x170036F5")]
		public override float preferredWidth
		{
			[Token(Token = "0x601708B")]
			[Address(RVA = "0xF78980", Offset = "0xF77580", VA = "0x180F78980", Slot = "31")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x0601708C RID: 94348 RVA: 0x00094770 File Offset: 0x00092970
		[Token(Token = "0x170036F6")]
		public override float flexibleWidth
		{
			[Token(Token = "0x601708C")]
			[Address(RVA = "0xF78650", Offset = "0xF77250", VA = "0x180F78650", Slot = "32")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x0601708D RID: 94349 RVA: 0x00094788 File Offset: 0x00092988
		[Token(Token = "0x170036F7")]
		public override float minHeight
		{
			[Token(Token = "0x601708D")]
			[Address(RVA = "0xF787A0", Offset = "0xF773A0", VA = "0x180F787A0", Slot = "33")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x0601708E RID: 94350 RVA: 0x000947A0 File Offset: 0x000929A0
		[Token(Token = "0x170036F8")]
		public override float preferredHeight
		{
			[Token(Token = "0x601708E")]
			[Address(RVA = "0xF788E0", Offset = "0xF774E0", VA = "0x180F788E0", Slot = "34")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0601708F RID: 94351 RVA: 0x000947B8 File Offset: 0x000929B8
		[Token(Token = "0x170036F9")]
		public override float flexibleHeight
		{
			[Token(Token = "0x601708F")]
			[Address(RVA = "0xF785E0", Offset = "0xF771E0", VA = "0x180F785E0", Slot = "35")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06017090 RID: 94352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017090")]
		[Address(RVA = "0xF778F0", Offset = "0xF764F0", VA = "0x180F778F0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06017091 RID: 94353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017091")]
		[Address(RVA = "0xF77BC0", Offset = "0xF767C0", VA = "0x180F77BC0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06017092 RID: 94354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017092")]
		[Address(RVA = "0xF781A0", Offset = "0xF76DA0", VA = "0x180F781A0")]
		private void _OnTargetDimensionChanged()
		{
		}

		// Token: 0x06017093 RID: 94355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017093")]
		[Address(RVA = "0xF77AF0", Offset = "0xF766F0", VA = "0x180F77AF0", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06017094 RID: 94356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017094")]
		[Address(RVA = "0xF77B60", Offset = "0xF76760", VA = "0x180F77B60", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x06017095 RID: 94357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017095")]
		[Address(RVA = "0xF77CF0", Offset = "0xF768F0", VA = "0x180F77CF0", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		// Token: 0x06017096 RID: 94358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017096")]
		[Address(RVA = "0xF77D50", Offset = "0xF76950", VA = "0x180F77D50", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		// Token: 0x06017097 RID: 94359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017097")]
		[Address(RVA = "0xF77FE0", Offset = "0xF76BE0", VA = "0x180F77FE0")]
		private void _GetChildSizeAlongAxis(RectTransform child, int axis, bool controlSize, out float min, out float preferred, out float flexible)
		{
		}

		// Token: 0x06017098 RID: 94360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017098")]
		[Address(RVA = "0xF78250", Offset = "0xF76E50", VA = "0x180F78250")]
		private void _SetChildSizeAlongAxis(RectTransform rect, int axis, float size)
		{
		}

		// Token: 0x06017099 RID: 94361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017099")]
		[Address(RVA = "0xF77E10", Offset = "0xF76A10", VA = "0x180F77E10")]
		private void _CalcAlongAxis(int axis)
		{
		}

		// Token: 0x0601709A RID: 94362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601709A")]
		[Address(RVA = "0xF78350", Offset = "0xF76F50", VA = "0x180F78350")]
		private void _SetChildrenSizeAlongAxis(int axis)
		{
		}

		// Token: 0x0601709B RID: 94363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601709B")]
		[Address(RVA = "0xF78580", Offset = "0xF77180", VA = "0x180F78580")]
		public UILimitedLayoutFitter()
		{
		}

		// Token: 0x0601709C RID: 94364 RVA: 0x000947D0 File Offset: 0x000929D0
		[Token(Token = "0x601709C")]
		[Address(RVA = "0xF77DE0", Offset = "0xF769E0", VA = "0x180F77DE0")]
		private float <>xLuaBaseProxy_get_minWidth()
		{
			return 0f;
		}

		// Token: 0x0601709D RID: 94365 RVA: 0x000947E8 File Offset: 0x000929E8
		[Token(Token = "0x601709D")]
		[Address(RVA = "0xF77E00", Offset = "0xF76A00", VA = "0x180F77E00")]
		private float <>xLuaBaseProxy_get_preferredWidth()
		{
			return 0f;
		}

		// Token: 0x0601709E RID: 94366 RVA: 0x00094800 File Offset: 0x00092A00
		[Token(Token = "0x601709E")]
		[Address(RVA = "0xF77DC0", Offset = "0xF769C0", VA = "0x180F77DC0")]
		private float <>xLuaBaseProxy_get_flexibleWidth()
		{
			return 0f;
		}

		// Token: 0x0601709F RID: 94367 RVA: 0x00094818 File Offset: 0x00092A18
		[Token(Token = "0x601709F")]
		[Address(RVA = "0xF77DD0", Offset = "0xF769D0", VA = "0x180F77DD0")]
		private float <>xLuaBaseProxy_get_minHeight()
		{
			return 0f;
		}

		// Token: 0x060170A0 RID: 94368 RVA: 0x00094830 File Offset: 0x00092A30
		[Token(Token = "0x60170A0")]
		[Address(RVA = "0xF77DF0", Offset = "0xF769F0", VA = "0x180F77DF0")]
		private float <>xLuaBaseProxy_get_preferredHeight()
		{
			return 0f;
		}

		// Token: 0x060170A1 RID: 94369 RVA: 0x00094848 File Offset: 0x00092A48
		[Token(Token = "0x60170A1")]
		[Address(RVA = "0xF77DB0", Offset = "0xF769B0", VA = "0x180F77DB0")]
		private float <>xLuaBaseProxy_get_flexibleHeight()
		{
			return 0f;
		}

		// Token: 0x060170A2 RID: 94370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170A2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x060170A3 RID: 94371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170A3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x060170A4 RID: 94372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170A4")]
		[Address(RVA = "0xF73570", Offset = "0xF72170", VA = "0x180F73570")]
		private void <>xLuaBaseProxy_CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0401BCE5 RID: 113893
		[Token(Token = "0x401BCE5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _horizontal;

		// Token: 0x0401BCE6 RID: 113894
		[Token(Token = "0x401BCE6")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool _vertical;

		// Token: 0x0401BCE7 RID: 113895
		[Token(Token = "0x401BCE7")]
		[FieldOffset(Offset = "0x5A")]
		[SerializeField]
		private bool _useSizeReferenceTarget;

		// Token: 0x0401BCE8 RID: 113896
		[Token(Token = "0x401BCE8")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _limitedWidth;

		// Token: 0x0401BCE9 RID: 113897
		[Token(Token = "0x401BCE9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _limitedHeight;

		// Token: 0x0401BCEA RID: 113898
		[Token(Token = "0x401BCEA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _sizeReferenceTarget;

		// Token: 0x0401BCEB RID: 113899
		[Token(Token = "0x401BCEB")]
		[FieldOffset(Offset = "0x70")]
		private UILayoutDimensionListener m_targetDimensionListener;

		// Token: 0x0401BCEC RID: 113900
		[Token(Token = "0x401BCEC")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_targetDimensionLimitedSize;

		// Token: 0x0401BCED RID: 113901
		[Token(Token = "0x401BCED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_limitedWidth;

		// Token: 0x0401BCEE RID: 113902
		[Token(Token = "0x401BCEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_limitedHeight;

		// Token: 0x0401BCEF RID: 113903
		[Token(Token = "0x401BCEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_minWidth;

		// Token: 0x0401BCF0 RID: 113904
		[Token(Token = "0x401BCF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0401BCF1 RID: 113905
		[Token(Token = "0x401BCF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_flexibleWidth;

		// Token: 0x0401BCF2 RID: 113906
		[Token(Token = "0x401BCF2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_minHeight;

		// Token: 0x0401BCF3 RID: 113907
		[Token(Token = "0x401BCF3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0401BCF4 RID: 113908
		[Token(Token = "0x401BCF4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_flexibleHeight;

		// Token: 0x0401BCF5 RID: 113909
		[Token(Token = "0x401BCF5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401BCF6 RID: 113910
		[Token(Token = "0x401BCF6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401BCF7 RID: 113911
		[Token(Token = "0x401BCF7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnTargetDimensionChanged;

		// Token: 0x0401BCF8 RID: 113912
		[Token(Token = "0x401BCF8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputHorizontal;

		// Token: 0x0401BCF9 RID: 113913
		[Token(Token = "0x401BCF9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputVertical;

		// Token: 0x0401BCFA RID: 113914
		[Token(Token = "0x401BCFA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetLayoutHorizontal;

		// Token: 0x0401BCFB RID: 113915
		[Token(Token = "0x401BCFB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetLayoutVertical;

		// Token: 0x0401BCFC RID: 113916
		[Token(Token = "0x401BCFC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetChildSizeAlongAxis;

		// Token: 0x0401BCFD RID: 113917
		[Token(Token = "0x401BCFD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SetChildSizeAlongAxis;

		// Token: 0x0401BCFE RID: 113918
		[Token(Token = "0x401BCFE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CalcAlongAxis;

		// Token: 0x0401BCFF RID: 113919
		[Token(Token = "0x401BCFF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SetChildrenSizeAlongAxis;

		// Token: 0x0401BD00 RID: 113920
		[Token(Token = "0x401BD00")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
