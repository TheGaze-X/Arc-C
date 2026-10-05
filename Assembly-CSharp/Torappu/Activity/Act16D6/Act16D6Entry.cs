using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act16D6
{
	// Token: 0x020079BD RID: 31165
	[Token(Token = "0x20079BD")]
	public class Act16D6Entry : ActivityCommonCheckinEntry, IHotfixable
	{
		// Token: 0x0602BB5F RID: 179039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB5F")]
		[Address(RVA = "0x279D2A0", Offset = "0x279BEA0", VA = "0x18279D2A0", Slot = "4")]
		public override void OnEnter(string activityId)
		{
		}

		// Token: 0x0602BB60 RID: 179040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB60")]
		[Address(RVA = "0x279DB50", Offset = "0x279C750", VA = "0x18279DB50")]
		private IEnumerator _RefreshHorizontal(DefaultCheckInData data)
		{
			return null;
		}

		// Token: 0x0602BB61 RID: 179041 RVA: 0x000DCF68 File Offset: 0x000DB168
		[Token(Token = "0x602BB61")]
		[Address(RVA = "0x279D860", Offset = "0x279C460", VA = "0x18279D860")]
		private int _CountNormalizedPosition(int focusItem, int totalCount, int gap)
		{
			return 0;
		}

		// Token: 0x0602BB62 RID: 179042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB62")]
		[Address(RVA = "0x279D4A0", Offset = "0x279C0A0", VA = "0x18279D4A0")]
		private void _ApplyTimeInfo(long startTime, long endTime)
		{
		}

		// Token: 0x0602BB63 RID: 179043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB63")]
		[Address(RVA = "0x279D400", Offset = "0x279C000", VA = "0x18279D400", Slot = "9")]
		protected override void RefreshInfo()
		{
		}

		// Token: 0x0602BB64 RID: 179044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB64")]
		[Address(RVA = "0x279E0B0", Offset = "0x279CCB0", VA = "0x18279E0B0")]
		private void _UpdateEntryInfo(bool isInit)
		{
		}

		// Token: 0x0602BB65 RID: 179045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB65")]
		[Address(RVA = "0x279D900", Offset = "0x279C500", VA = "0x18279D900")]
		private void _EventForDotClick(int focusItem, int checkinCount)
		{
		}

		// Token: 0x0602BB66 RID: 179046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB66")]
		[Address(RVA = "0x279DA70", Offset = "0x279C670", VA = "0x18279DA70")]
		private IEnumerator _MoveToFocusItem(int focusItem, int checkinCount)
		{
			return null;
		}

		// Token: 0x0602BB67 RID: 179047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB67")]
		[Address(RVA = "0x279DFC0", Offset = "0x279CBC0", VA = "0x18279DFC0")]
		private void _TryInjectPlugin()
		{
		}

		// Token: 0x0602BB68 RID: 179048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB68")]
		[Address(RVA = "0x279DC20", Offset = "0x279C820", VA = "0x18279DC20")]
		private void _RefreshPlugin(bool isInit)
		{
		}

		// Token: 0x0602BB69 RID: 179049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB69")]
		[Address(RVA = "0x279F0D0", Offset = "0x279DCD0", VA = "0x18279F0D0")]
		public Act16D6Entry()
		{
		}

		// Token: 0x0602BB6A RID: 179050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB6A")]
		[Address(RVA = "0x25BA740", Offset = "0x25B9340", VA = "0x1825BA740")]
		private void <>xLuaBaseProxy_OnEnter(string P0)
		{
		}

		// Token: 0x0403F3CE RID: 259022
		[Token(Token = "0x403F3CE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActivityCommonCheckinV2Item _checkinItem;

		// Token: 0x0403F3CF RID: 259023
		[Token(Token = "0x403F3CF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403F3D0 RID: 259024
		[Token(Token = "0x403F3D0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _dotViewContainer;

		// Token: 0x0403F3D1 RID: 259025
		[Token(Token = "0x403F3D1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _openTime;

		// Token: 0x0403F3D2 RID: 259026
		[Token(Token = "0x403F3D2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0403F3D3 RID: 259027
		[Token(Token = "0x403F3D3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _apItemTime;

		// Token: 0x0403F3D4 RID: 259028
		[Token(Token = "0x403F3D4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text[] _mainRewardCountdown;

		// Token: 0x0403F3D5 RID: 259029
		[Token(Token = "0x403F3D5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ActivityCommonCheckinDotView _dotView;

		// Token: 0x0403F3D6 RID: 259030
		[Token(Token = "0x403F3D6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Item Config")]
		private Color _mainColor;

		// Token: 0x0403F3D7 RID: 259031
		[Token(Token = "0x403F3D7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Item Config")]
		private Color _logoColor;

		// Token: 0x0403F3D8 RID: 259032
		[Token(Token = "0x403F3D8")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Item Config")]
		private Color _acceptableLogoColor;

		// Token: 0x0403F3D9 RID: 259033
		[Token(Token = "0x403F3D9")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Item Config")]
		private Color _maskColor;

		// Token: 0x0403F3DA RID: 259034
		[Token(Token = "0x403F3DA")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Item Config")]
		private Color _rewardBgColor;

		// Token: 0x0403F3DB RID: 259035
		[Token(Token = "0x403F3DB")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Item Config")]
		private Color _rewardMaskColor;

		// Token: 0x0403F3DC RID: 259036
		[Token(Token = "0x403F3DC")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Item Config")]
		private Color _rewardDotColor;

		// Token: 0x0403F3DD RID: 259037
		[Token(Token = "0x403F3DD")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Item Config")]
		private Color _acceptableLightColor;

		// Token: 0x0403F3DE RID: 259038
		[Token(Token = "0x403F3DE")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Item Config")]
		private Sprite _decSprite;

		// Token: 0x0403F3DF RID: 259039
		[Token(Token = "0x403F3DF")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Dot View Config")]
		private Sprite _normalDot;

		// Token: 0x0403F3E0 RID: 259040
		[Token(Token = "0x403F3E0")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Dot View Config")]
		private Sprite _bigDot;

		// Token: 0x0403F3E1 RID: 259041
		[Token(Token = "0x403F3E1")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Dot View Config")]
		private Sprite _acceptableDot;

		// Token: 0x0403F3E2 RID: 259042
		[Token(Token = "0x403F3E2")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("Dot View Config")]
		private Color _outlineColor;

		// Token: 0x0403F3E3 RID: 259043
		[Token(Token = "0x403F3E3")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("Dot View Config")]
		private Color _notGetColor;

		// Token: 0x0403F3E4 RID: 259044
		[Token(Token = "0x403F3E4")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Plugin")]
		private Transform _pluginContainer;

		// Token: 0x0403F3E5 RID: 259045
		[Token(Token = "0x403F3E5")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Plugin")]
		private GameObject _pluginPrefab;

		// Token: 0x0403F3E6 RID: 259046
		[Token(Token = "0x403F3E6")]
		[FieldOffset(Offset = "0x180")]
		private ActivityCommonCheckinDotView m_dotView;

		// Token: 0x0403F3E7 RID: 259047
		[Token(Token = "0x403F3E7")]
		[FieldOffset(Offset = "0x188")]
		private List<ActivityCommonCheckinV2Item> m_itemList;

		// Token: 0x0403F3E8 RID: 259048
		[Token(Token = "0x403F3E8")]
		[FieldOffset(Offset = "0x190")]
		private DefaultCheckInData.CheckInDailyInfo[] m_ShowItemArray;

		// Token: 0x0403F3E9 RID: 259049
		[Token(Token = "0x403F3E9")]
		[FieldOffset(Offset = "0x198")]
		private ITemplateActivityExtraSignPlugin m_plugin;

		// Token: 0x0403F3EA RID: 259050
		[Token(Token = "0x403F3EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F3EB RID: 259051
		[Token(Token = "0x403F3EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshHorizontal;

		// Token: 0x0403F3EC RID: 259052
		[Token(Token = "0x403F3EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CountNormalizedPosition;

		// Token: 0x0403F3ED RID: 259053
		[Token(Token = "0x403F3ED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyTimeInfo;

		// Token: 0x0403F3EE RID: 259054
		[Token(Token = "0x403F3EE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshInfo;

		// Token: 0x0403F3EF RID: 259055
		[Token(Token = "0x403F3EF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateEntryInfo;

		// Token: 0x0403F3F0 RID: 259056
		[Token(Token = "0x403F3F0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventForDotClick;

		// Token: 0x0403F3F1 RID: 259057
		[Token(Token = "0x403F3F1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__MoveToFocusItem;

		// Token: 0x0403F3F2 RID: 259058
		[Token(Token = "0x403F3F2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryInjectPlugin;

		// Token: 0x0403F3F3 RID: 259059
		[Token(Token = "0x403F3F3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshPlugin;

		// Token: 0x0403F3F4 RID: 259060
		[Token(Token = "0x403F3F4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
