using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200694F RID: 26959
	[Token(Token = "0x200694F")]
	public class StageButtonOnMap : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B1C RID: 23324
		// (get) Token: 0x0602697C RID: 158076 RVA: 0x000CBC58 File Offset: 0x000C9E58
		// (set) Token: 0x0602697D RID: 158077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B1C")]
		public bool isBlockClick
		{
			[Token(Token = "0x602697C")]
			[Address(RVA = "0x21AA2F0", Offset = "0x21A8EF0", VA = "0x1821AA2F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602697D")]
			[Address(RVA = "0x21AA670", Offset = "0x21A9270", VA = "0x1821AA670")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005B1D RID: 23325
		// (get) Token: 0x0602697E RID: 158078 RVA: 0x000CBC70 File Offset: 0x000C9E70
		[Token(Token = "0x17005B1D")]
		public bool isActive
		{
			[Token(Token = "0x602697E")]
			[Address(RVA = "0x21AA280", Offset = "0x21A8E80", VA = "0x1821AA280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B1E RID: 23326
		// (get) Token: 0x0602697F RID: 158079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B1E")]
		public virtual RectTransform positionRect
		{
			[Token(Token = "0x602697F")]
			[Address(RVA = "0x21AA410", Offset = "0x21A9010", VA = "0x1821AA410", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B1F RID: 23327
		// (get) Token: 0x06026980 RID: 158080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B1F")]
		protected StageRankViewViaSwitch stageRankView
		{
			[Token(Token = "0x6026980")]
			[Address(RVA = "0x21AA600", Offset = "0x21A9200", VA = "0x1821AA600")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B20 RID: 23328
		// (get) Token: 0x06026981 RID: 158081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B20")]
		protected Text stageNameText
		{
			[Token(Token = "0x6026981")]
			[Address(RVA = "0x21AA5A0", Offset = "0x21A91A0", VA = "0x1821AA5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B21 RID: 23329
		// (get) Token: 0x06026982 RID: 158082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B21")]
		protected Text stageCodeText
		{
			[Token(Token = "0x6026982")]
			[Address(RVA = "0x21AA4E0", Offset = "0x21A90E0", VA = "0x1821AA4E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B22 RID: 23330
		// (get) Token: 0x06026983 RID: 158083 RVA: 0x000CBC88 File Offset: 0x000C9E88
		[Token(Token = "0x17005B22")]
		protected bool isStageLocked
		{
			[Token(Token = "0x6026983")]
			[Address(RVA = "0x21AA350", Offset = "0x21A8F50", VA = "0x1821AA350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026984 RID: 158084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026984")]
		[Address(RVA = "0x21A99F0", Offset = "0x21A85F0", VA = "0x1821A99F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026985 RID: 158085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026985")]
		[Address(RVA = "0x21A91B0", Offset = "0x21A7DB0", VA = "0x1821A91B0")]
		public void OnStageClick()
		{
		}

		// Token: 0x06026986 RID: 158086 RVA: 0x000CBCA0 File Offset: 0x000C9EA0
		[Token(Token = "0x6026986")]
		[Address(RVA = "0x21A9940", Offset = "0x21A8540", VA = "0x1821A9940", Slot = "5")]
		protected virtual bool TryLockStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
			return default(bool);
		}

		// Token: 0x06026987 RID: 158087 RVA: 0x000CBCB8 File Offset: 0x000C9EB8
		[Token(Token = "0x6026987")]
		[Address(RVA = "0x21A8FE0", Offset = "0x21A7BE0", VA = "0x1821A8FE0", Slot = "6")]
		protected virtual bool CheckIsStageButtonBlockClick(StageViewModel stageViewModel, ZoneViewModel zoneViewModel)
		{
			return default(bool);
		}

		// Token: 0x06026988 RID: 158088 RVA: 0x000CBCD0 File Offset: 0x000C9ED0
		[Token(Token = "0x6026988")]
		[Address(RVA = "0x21A9070", Offset = "0x21A7C70", VA = "0x1821A9070", Slot = "7")]
		protected virtual bool CheckStageLocked(StageViewModel stageViewModel, ZoneViewModel zoneViewModel)
		{
			return default(bool);
		}

		// Token: 0x06026989 RID: 158089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026989")]
		[Address(RVA = "0x21A9120", Offset = "0x21A7D20", VA = "0x1821A9120")]
		public void InjectButtonEvents(StageButtonOnMap.Events events)
		{
		}

		// Token: 0x17005B23 RID: 23331
		// (get) Token: 0x0602698B RID: 158091 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602698A RID: 158090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B23")]
		public Action<string> onPluginClick
		{
			[Token(Token = "0x602698B")]
			[Address(RVA = "0x21AA3B0", Offset = "0x21A8FB0", VA = "0x1821AA3B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x602698A")]
			[Address(RVA = "0x21AA6E0", Offset = "0x21A92E0", VA = "0x1821AA6E0")]
			set
			{
			}
		}

		// Token: 0x17005B24 RID: 23332
		// (get) Token: 0x0602698C RID: 158092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B24")]
		public string stageId
		{
			[Token(Token = "0x602698C")]
			[Address(RVA = "0x21AA540", Offset = "0x21A9140", VA = "0x1821AA540")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602698D RID: 158093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602698D")]
		[Address(RVA = "0x21A9270", Offset = "0x21A7E70", VA = "0x1821A9270")]
		public StageButtonOnMap.PluginBridge PluginOnlyGetBridge()
		{
			return null;
		}

		// Token: 0x0602698E RID: 158094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602698E")]
		[Address(RVA = "0x21A9340", Offset = "0x21A7F40", VA = "0x1821A9340", Slot = "8")]
		public virtual void RenderStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
		}

		// Token: 0x0602698F RID: 158095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602698F")]
		[Address(RVA = "0x21A9DC0", Offset = "0x21A89C0", VA = "0x1821A9DC0")]
		private void _TryShowRankView(StageButtonOnMap.RankViewType rankViewType)
		{
		}

		// Token: 0x06026990 RID: 158096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026990")]
		[Address(RVA = "0x21A9AB0", Offset = "0x21A86B0", VA = "0x1821A9AB0")]
		private void _RenderTimelyDropAndApProtect(bool showApProtect, string timelyDropId)
		{
		}

		// Token: 0x06026991 RID: 158097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026991")]
		[Address(RVA = "0x21AA190", Offset = "0x21A8D90", VA = "0x1821AA190")]
		public StageButtonOnMap()
		{
		}

		// Token: 0x0403672A RID: 223018
		[Token(Token = "0x403672A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Text _stageNameText;

		// Token: 0x0403672B RID: 223019
		[Token(Token = "0x403672B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageCodeText;

		// Token: 0x0403672C RID: 223020
		[Token(Token = "0x403672C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Nullable")]
		private StageRankViewViaSwitch _stageRank;

		// Token: 0x0403672D RID: 223021
		[Token(Token = "0x403672D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Special Stage Rank")]
		[Tooltip("Nullable")]
		private RectTransform _stageRankHolder;

		// Token: 0x0403672E RID: 223022
		[Token(Token = "0x403672E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Special Stage Rank")]
		[Tooltip("Nullable")]
		private UIColorGraphic _stageRankColorGraphic;

		// Token: 0x0403672F RID: 223023
		[Token(Token = "0x403672F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _apProtectPrefab;

		// Token: 0x04036730 RID: 223024
		[Token(Token = "0x4036730")]
		[FieldOffset(Offset = "0x48")]
		private TwoStateToggle m_selectionToggle;

		// Token: 0x04036731 RID: 223025
		[Token(Token = "0x4036731")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_transform;

		// Token: 0x04036732 RID: 223026
		[Token(Token = "0x4036732")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04036733 RID: 223027
		[Token(Token = "0x4036733")]
		[FieldOffset(Offset = "0x59")]
		private bool m_isStageLocked;

		// Token: 0x04036734 RID: 223028
		[Token(Token = "0x4036734")]
		[FieldOffset(Offset = "0x60")]
		private GameObject m_extraItem;

		// Token: 0x04036735 RID: 223029
		[Token(Token = "0x4036735")]
		[FieldOffset(Offset = "0x68")]
		private string m_cacheDropId;

		// Token: 0x04036736 RID: 223030
		[Token(Token = "0x4036736")]
		[FieldOffset(Offset = "0x70")]
		private bool m_cacheShowApProtect;

		// Token: 0x04036737 RID: 223031
		[Token(Token = "0x4036737")]
		[FieldOffset(Offset = "0x78")]
		private StageButtonOnMap.ViewModelCache m_viewModelCache;

		// Token: 0x04036738 RID: 223032
		[Token(Token = "0x4036738")]
		[FieldOffset(Offset = "0xA0")]
		private Action<string> m_onPluginClickCallback;

		// Token: 0x04036739 RID: 223033
		[Token(Token = "0x4036739")]
		[FieldOffset(Offset = "0xA8")]
		private Action<string> m_onClickCallback;

		// Token: 0x0403673A RID: 223034
		[Token(Token = "0x403673A")]
		[FieldOffset(Offset = "0xB0")]
		private StageButtonOnMap.Events m_buttonEvents;

		// Token: 0x0403673B RID: 223035
		[Token(Token = "0x403673B")]
		[FieldOffset(Offset = "0xC0")]
		private StageButtonOnMap.PluginBridge m_pluginBridge;

		// Token: 0x0403673C RID: 223036
		[Token(Token = "0x403673C")]
		[FieldOffset(Offset = "0xC8")]
		private StageRankViewViaSwitch m_specialStageRank;

		// Token: 0x0403673D RID: 223037
		[Token(Token = "0x403673D")]
		[FieldOffset(Offset = "0xD0")]
		private StageButtonOnMap.RankViewType m_rankViewType;

		// Token: 0x0403673F RID: 223039
		[Token(Token = "0x403673F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isBlockClick;

		// Token: 0x04036740 RID: 223040
		[Token(Token = "0x4036740")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isBlockClick;

		// Token: 0x04036741 RID: 223041
		[Token(Token = "0x4036741")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isActive;

		// Token: 0x04036742 RID: 223042
		[Token(Token = "0x4036742")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_positionRect;

		// Token: 0x04036743 RID: 223043
		[Token(Token = "0x4036743")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageRankView;

		// Token: 0x04036744 RID: 223044
		[Token(Token = "0x4036744")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_stageNameText;

		// Token: 0x04036745 RID: 223045
		[Token(Token = "0x4036745")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_stageCodeText;

		// Token: 0x04036746 RID: 223046
		[Token(Token = "0x4036746")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isStageLocked;

		// Token: 0x04036747 RID: 223047
		[Token(Token = "0x4036747")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036748 RID: 223048
		[Token(Token = "0x4036748")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnStageClick;

		// Token: 0x04036749 RID: 223049
		[Token(Token = "0x4036749")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryLockStage;

		// Token: 0x0403674A RID: 223050
		[Token(Token = "0x403674A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIsStageButtonBlockClick;

		// Token: 0x0403674B RID: 223051
		[Token(Token = "0x403674B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckStageLocked;

		// Token: 0x0403674C RID: 223052
		[Token(Token = "0x403674C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_InjectButtonEvents;

		// Token: 0x0403674D RID: 223053
		[Token(Token = "0x403674D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_onPluginClick;

		// Token: 0x0403674E RID: 223054
		[Token(Token = "0x403674E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_onPluginClick;

		// Token: 0x0403674F RID: 223055
		[Token(Token = "0x403674F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x04036750 RID: 223056
		[Token(Token = "0x4036750")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_PluginOnlyGetBridge;

		// Token: 0x04036751 RID: 223057
		[Token(Token = "0x4036751")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x04036752 RID: 223058
		[Token(Token = "0x4036752")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryShowRankView;

		// Token: 0x04036753 RID: 223059
		[Token(Token = "0x4036753")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RenderTimelyDropAndApProtect;

		// Token: 0x04036754 RID: 223060
		[Token(Token = "0x4036754")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006950 RID: 26960
		[Token(Token = "0x2006950")]
		public struct Events
		{
			// Token: 0x04036755 RID: 223061
			[Token(Token = "0x4036755")]
			[FieldOffset(Offset = "0x0")]
			public Action<string> onButtonClicked;

			// Token: 0x04036756 RID: 223062
			[Token(Token = "0x4036756")]
			[FieldOffset(Offset = "0x8")]
			public Action<string> onSpeicalRewardClicked;
		}

		// Token: 0x02006951 RID: 26961
		[Token(Token = "0x2006951")]
		public enum RankViewType
		{
			// Token: 0x04036758 RID: 223064
			[Token(Token = "0x4036758")]
			COMMON,
			// Token: 0x04036759 RID: 223065
			[Token(Token = "0x4036759")]
			SIX_STAR
		}

		// Token: 0x02006952 RID: 26962
		[Token(Token = "0x2006952")]
		public class PluginBridge
		{
			// Token: 0x06026992 RID: 158098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026992")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public PluginBridge(StageButtonOnMap closure)
			{
			}

			// Token: 0x06026993 RID: 158099 RVA: 0x000CBCE8 File Offset: 0x000C9EE8
			[Token(Token = "0x6026993")]
			[Address(RVA = "0x21A71D0", Offset = "0x21A5DD0", VA = "0x1821A71D0")]
			public StageButtonOnMap.Events GetButtonEvents()
			{
				return default(StageButtonOnMap.Events);
			}

			// Token: 0x0403675A RID: 223066
			[Token(Token = "0x403675A")]
			[FieldOffset(Offset = "0x10")]
			private StageButtonOnMap m_closure;
		}

		// Token: 0x02006953 RID: 26963
		[Token(Token = "0x2006953")]
		private struct ViewModelCache
		{
			// Token: 0x06026994 RID: 158100 RVA: 0x000CBD00 File Offset: 0x000C9F00
			[Token(Token = "0x6026994")]
			[Address(RVA = "0x21BA4D0", Offset = "0x21B90D0", VA = "0x1821BA4D0")]
			public static StageButtonOnMap.ViewModelCache Create(StageButtonOnMapHolder holder, StageViewModel viewModel, bool isSelected)
			{
				return default(StageButtonOnMap.ViewModelCache);
			}

			// Token: 0x0403675B RID: 223067
			[Token(Token = "0x403675B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly StageButtonOnMap.ViewModelCache EMPTY;

			// Token: 0x0403675C RID: 223068
			[Token(Token = "0x403675C")]
			[FieldOffset(Offset = "0x0")]
			public bool isUnlocked;

			// Token: 0x0403675D RID: 223069
			[Token(Token = "0x403675D")]
			[FieldOffset(Offset = "0x8")]
			public string stageId;

			// Token: 0x0403675E RID: 223070
			[Token(Token = "0x403675E")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0403675F RID: 223071
			[Token(Token = "0x403675F")]
			[FieldOffset(Offset = "0x18")]
			public string code;

			// Token: 0x04036760 RID: 223072
			[Token(Token = "0x4036760")]
			[FieldOffset(Offset = "0x20")]
			public bool isSelected;
		}
	}
}
