using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069C5 RID: 27077
	[Token(Token = "0x20069C5")]
	public class StageZoneWeeklyGroupPanel : StageZoneGroupPanel, IHotfixable
	{
		// Token: 0x06026BE5 RID: 158693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BE5")]
		[Address(RVA = "0x21DA000", Offset = "0x21D8C00", VA = "0x1821DA000", Slot = "8")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026BE6 RID: 158694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BE6")]
		[Address(RVA = "0x21DA6C0", Offset = "0x21D92C0", VA = "0x1821DA6C0")]
		private void _UpdateIconWidget()
		{
		}

		// Token: 0x06026BE7 RID: 158695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BE7")]
		[Address(RVA = "0x21DA4D0", Offset = "0x21D90D0", VA = "0x1821DA4D0", Slot = "7")]
		public override void OnValueChanged(ZoneGroupViewProperty property)
		{
		}

		// Token: 0x06026BE8 RID: 158696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BE8")]
		[Address(RVA = "0x21DA590", Offset = "0x21D9190", VA = "0x1821DA590")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026BE9 RID: 158697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BE9")]
		[Address(RVA = "0x21DA1E0", Offset = "0x21D8DE0", VA = "0x1821DA1E0")]
		private void OnItemClick(string zoneId)
		{
		}

		// Token: 0x06026BEA RID: 158698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BEA")]
		[Address(RVA = "0x21DAB60", Offset = "0x21D9760", VA = "0x1821DAB60")]
		public StageZoneWeeklyGroupPanel()
		{
		}

		// Token: 0x06026BEB RID: 158699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BEB")]
		[Address(RVA = "0x21DA570", Offset = "0x21D9170", VA = "0x1821DA570")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026BEC RID: 158700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BEC")]
		[Address(RVA = "0x21DA580", Offset = "0x21D9180", VA = "0x1821DA580")]
		private void <>xLuaBaseProxy_OnValueChanged(ZoneGroupViewProperty P0)
		{
		}

		// Token: 0x04036B66 RID: 224102
		[Token(Token = "0x4036B66")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04036B67 RID: 224103
		[Token(Token = "0x4036B67")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _zoneList;

		// Token: 0x04036B68 RID: 224104
		[Token(Token = "0x4036B68")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private WeeklyGroupZoneIconWidget _iconWidget;

		// Token: 0x04036B69 RID: 224105
		[Token(Token = "0x4036B69")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _rtIconToday;

		// Token: 0x04036B6A RID: 224106
		[Token(Token = "0x4036B6A")]
		private const int WEEK_COUNT = 7;

		// Token: 0x04036B6B RID: 224107
		[Token(Token = "0x4036B6B")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04036B6C RID: 224108
		[Token(Token = "0x4036B6C")]
		[FieldOffset(Offset = "0x88")]
		private ZoneGroupViewModel m_zoneGroupModel;

		// Token: 0x04036B6D RID: 224109
		[Token(Token = "0x4036B6D")]
		[FieldOffset(Offset = "0x90")]
		private StageZoneWeeklyGroupPanel.Adapter m_adapter;

		// Token: 0x04036B6E RID: 224110
		[Token(Token = "0x4036B6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036B6F RID: 224111
		[Token(Token = "0x4036B6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateIconWidget;

		// Token: 0x04036B70 RID: 224112
		[Token(Token = "0x4036B70")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036B71 RID: 224113
		[Token(Token = "0x4036B71")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036B72 RID: 224114
		[Token(Token = "0x4036B72")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04036B73 RID: 224115
		[Token(Token = "0x4036B73")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069C6 RID: 27078
		[Token(Token = "0x20069C6")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06026BED RID: 158701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026BED")]
			[Address(RVA = "0x21D1DE0", Offset = "0x21D09E0", VA = "0x1821D1DE0")]
			public Adapter(StageZoneWeeklyGroupPanel stageZoneWeeklyGroupPanel)
			{
			}

			// Token: 0x17005B72 RID: 23410
			// (get) Token: 0x06026BEE RID: 158702 RVA: 0x000CC2A0 File Offset: 0x000CA4A0
			[Token(Token = "0x17005B72")]
			public override int count
			{
				[Token(Token = "0x6026BEE")]
				[Address(RVA = "0x21D1EC0", Offset = "0x21D0AC0", VA = "0x1821D1EC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026BEF RID: 158703 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026BEF")]
			[Address(RVA = "0x21D1BC0", Offset = "0x21D07C0", VA = "0x1821D1BC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04036B74 RID: 224116
			[Token(Token = "0x4036B74")]
			[FieldOffset(Offset = "0x20")]
			private StageZoneWeeklyGroupPanel m_closure;

			// Token: 0x04036B75 RID: 224117
			[Token(Token = "0x4036B75")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04036B76 RID: 224118
			[Token(Token = "0x4036B76")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036B77 RID: 224119
			[Token(Token = "0x4036B77")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
