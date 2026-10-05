using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003743 RID: 14147
	[Token(Token = "0x2003743")]
	[RequireComponent(typeof(Text))]
	public class MultilineBestFit : UIBehaviour, IHotfixable
	{
		// Token: 0x0601679E RID: 92062 RVA: 0x000915A8 File Offset: 0x0008F7A8
		[Token(Token = "0x601679E")]
		[Address(RVA = "0xEDBDF0", Offset = "0xEDA9F0", VA = "0x180EDBDF0")]
		private bool _GetAutoAlignmentWhenOnlyOneLine()
		{
			return default(bool);
		}

		// Token: 0x0601679F RID: 92063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601679F")]
		[Address(RVA = "0xEDB1A0", Offset = "0xED9DA0", VA = "0x180EDB1A0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060167A0 RID: 92064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167A0")]
		[Address(RVA = "0xEDB350", Offset = "0xED9F50", VA = "0x180EDB350", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060167A1 RID: 92065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167A1")]
		[Address(RVA = "0xEDB2D0", Offset = "0xED9ED0", VA = "0x180EDB2D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060167A2 RID: 92066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167A2")]
		[Address(RVA = "0xEDB270", Offset = "0xED9E70", VA = "0x180EDB270")]
		private void LateUpdate()
		{
		}

		// Token: 0x060167A3 RID: 92067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167A3")]
		[Address(RVA = "0xEDB3C0", Offset = "0xED9FC0", VA = "0x180EDB3C0")]
		private void TryFit()
		{
		}

		// Token: 0x060167A4 RID: 92068 RVA: 0x000915C0 File Offset: 0x0008F7C0
		[Token(Token = "0x60167A4")]
		[Address(RVA = "0xEDB8D0", Offset = "0xEDA4D0", VA = "0x180EDB8D0")]
		private int _BinaryFind()
		{
			return 0;
		}

		// Token: 0x060167A5 RID: 92069 RVA: 0x000915D8 File Offset: 0x0008F7D8
		[Token(Token = "0x60167A5")]
		[Address(RVA = "0xEDBD20", Offset = "0xEDA920", VA = "0x180EDBD20")]
		private int _DecreaseFind()
		{
			return 0;
		}

		// Token: 0x060167A6 RID: 92070 RVA: 0x000915F0 File Offset: 0x0008F7F0
		[Token(Token = "0x60167A6")]
		[Address(RVA = "0xEDBA00", Offset = "0xEDA600", VA = "0x180EDBA00")]
		private bool _CheckSuitable(int fontSize, Vector2 extents)
		{
			return default(bool);
		}

		// Token: 0x060167A7 RID: 92071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167A7")]
		[Address(RVA = "0xEDBE50", Offset = "0xEDAA50", VA = "0x180EDBE50")]
		public MultilineBestFit()
		{
		}

		// Token: 0x060167A8 RID: 92072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167A8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x060167A9 RID: 92073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167A9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x060167AA RID: 92074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167AA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnDisable()
		{
		}

		// Token: 0x0401B123 RID: 110883
		[Token(Token = "0x401B123")]
		[FieldOffset(Offset = "0x18")]
		private Text m_text;

		// Token: 0x0401B124 RID: 110884
		[Token(Token = "0x401B124")]
		[FieldOffset(Offset = "0x20")]
		private int m_defaultSize;

		// Token: 0x0401B125 RID: 110885
		[Token(Token = "0x401B125")]
		[FieldOffset(Offset = "0x28")]
		private string m_processedContent;

		// Token: 0x0401B126 RID: 110886
		[Token(Token = "0x401B126")]
		[FieldOffset(Offset = "0x30")]
		private Font m_processedFont;

		// Token: 0x0401B127 RID: 110887
		[Token(Token = "0x401B127")]
		[FieldOffset(Offset = "0x38")]
		private string m_textForFit;

		// Token: 0x0401B128 RID: 110888
		[Token(Token = "0x401B128")]
		[FieldOffset(Offset = "0x40")]
		private HorizontalWrapMode m_preHorzMode;

		// Token: 0x0401B129 RID: 110889
		[Token(Token = "0x401B129")]
		[FieldOffset(Offset = "0x44")]
		private VerticalWrapMode m_preVertMode;

		// Token: 0x0401B12A RID: 110890
		[Token(Token = "0x401B12A")]
		[FieldOffset(Offset = "0x48")]
		private TextAnchor m_cacheTextAnchor;

		// Token: 0x0401B12B RID: 110891
		[Token(Token = "0x401B12B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Tooltip("是否使用二分法查找合适的字号，当合适的字号会在一个较大范围内出现时使用，否则谨慎选择。")]
		private bool _binary;

		// Token: 0x0401B12C RID: 110892
		[Token(Token = "0x401B12C")]
		[FieldOffset(Offset = "0x4D")]
		[SerializeField]
		[Tooltip("是否忽略文本末尾的空白字符")]
		private bool _ignoreBlankEnd;

		// Token: 0x0401B12D RID: 110893
		[Token(Token = "0x401B12D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int _minSize;

		// Token: 0x0401B12E RID: 110894
		[Token(Token = "0x401B12E")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool _autoAlignmentWhenOnlyOneLine;

		// Token: 0x0401B12F RID: 110895
		[Token(Token = "0x401B12F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Inspect("_GetAutoAlignmentWhenOnlyOneLine")]
		private TextAnchor _textAnchorWhenOnlyOneLine;

		// Token: 0x0401B130 RID: 110896
		[Token(Token = "0x401B130")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetAutoAlignmentWhenOnlyOneLine;

		// Token: 0x0401B131 RID: 110897
		[Token(Token = "0x401B131")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401B132 RID: 110898
		[Token(Token = "0x401B132")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401B133 RID: 110899
		[Token(Token = "0x401B133")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401B134 RID: 110900
		[Token(Token = "0x401B134")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x0401B135 RID: 110901
		[Token(Token = "0x401B135")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryFit;

		// Token: 0x0401B136 RID: 110902
		[Token(Token = "0x401B136")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BinaryFind;

		// Token: 0x0401B137 RID: 110903
		[Token(Token = "0x401B137")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DecreaseFind;

		// Token: 0x0401B138 RID: 110904
		[Token(Token = "0x401B138")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckSuitable;

		// Token: 0x0401B139 RID: 110905
		[Token(Token = "0x401B139")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
