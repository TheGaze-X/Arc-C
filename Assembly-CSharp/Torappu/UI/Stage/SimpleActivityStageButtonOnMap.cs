using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006781 RID: 26497
	[Token(Token = "0x2006781")]
	public class SimpleActivityStageButtonOnMap : StageButtonOnMap, IHotfixable
	{
		// Token: 0x06026030 RID: 155696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026030")]
		[Address(RVA = "0x20FCE40", Offset = "0x20FBA40", VA = "0x1820FCE40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026031 RID: 155697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026031")]
		[Address(RVA = "0x20FCA30", Offset = "0x20FB630", VA = "0x1820FCA30", Slot = "8")]
		public override void RenderStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
		}

		// Token: 0x06026032 RID: 155698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026032")]
		[Address(RVA = "0x20FCEE0", Offset = "0x20FBAE0", VA = "0x1820FCEE0")]
		public SimpleActivityStageButtonOnMap()
		{
		}

		// Token: 0x06026033 RID: 155699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026033")]
		[Address(RVA = "0x20FCE20", Offset = "0x20FBA20", VA = "0x1820FCE20")]
		private void <>xLuaBaseProxy_RenderStage(StageButtonOnMapHolder P0, StageViewModel P1, ZoneViewModel P2, bool P3)
		{
		}

		// Token: 0x0403578F RID: 219023
		[Token(Token = "0x403578F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Selection")]
		private UIColorGraphic _selectionGraphic;

		// Token: 0x04035790 RID: 219024
		[Token(Token = "0x4035790")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Selection")]
		private Color _selectedColor;

		// Token: 0x04035791 RID: 219025
		[Token(Token = "0x4035791")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Color _codeTextColor;

		// Token: 0x04035792 RID: 219026
		[Token(Token = "0x4035792")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private StageRankView _stageRankView;

		// Token: 0x04035793 RID: 219027
		[Token(Token = "0x4035793")]
		[FieldOffset(Offset = "0x108")]
		private SimpleActivityStageButtonOnMapPlugin m_plugin;

		// Token: 0x04035794 RID: 219028
		[Token(Token = "0x4035794")]
		[FieldOffset(Offset = "0x110")]
		private bool m_inited;

		// Token: 0x04035795 RID: 219029
		[Token(Token = "0x4035795")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035796 RID: 219030
		[Token(Token = "0x4035796")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x04035797 RID: 219031
		[Token(Token = "0x4035797")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
