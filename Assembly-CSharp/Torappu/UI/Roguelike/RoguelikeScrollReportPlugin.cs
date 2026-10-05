using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053BF RID: 21439
	[Token(Token = "0x20053BF")]
	public abstract class RoguelikeScrollReportPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x170049E3 RID: 18915
		// (get) Token: 0x0601F8CF RID: 129231 RVA: 0x000B2320 File Offset: 0x000B0520
		[Token(Token = "0x170049E3")]
		public float endFadeHeight
		{
			[Token(Token = "0x601F8CF")]
			[Address(RVA = "0x194AFE0", Offset = "0x1949BE0", VA = "0x18194AFE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170049E4 RID: 18916
		// (get) Token: 0x0601F8D0 RID: 129232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049E4")]
		public virtual RoguelikeScrollReportTitleView titlePrefab
		{
			[Token(Token = "0x601F8D0")]
			[Address(RVA = "0x194B340", Offset = "0x1949F40", VA = "0x18194B340", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170049E5 RID: 18917
		// (get) Token: 0x0601F8D1 RID: 129233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049E5")]
		public virtual RoguelikeScrollReportEndingFrameViewModelPlugin endingFrameViewModelPlugin
		{
			[Token(Token = "0x601F8D1")]
			[Address(RVA = "0x194B160", Offset = "0x1949D60", VA = "0x18194B160", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F8D2 RID: 129234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8D2")]
		[Address(RVA = "0x1949980", Offset = "0x1948580", VA = "0x181949980", Slot = "6")]
		public virtual UIRecycleLayoutAdapter.IVirtualView GetCastVirtualView(List<string> nameList)
		{
			return null;
		}

		// Token: 0x0601F8D3 RID: 129235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8D3")]
		[Address(RVA = "0x194A0E0", Offset = "0x1948CE0", VA = "0x18194A0E0", Slot = "7")]
		public virtual UIRecycleLayoutAdapter.IVirtualView GetZoneOverViewVirtualView(List<string> zoneIdList)
		{
			return null;
		}

		// Token: 0x170049E6 RID: 18918
		// (get) Token: 0x0601F8D4 RID: 129236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049E6")]
		public virtual RoguelikeScrollReportItemView initPrefab
		{
			[Token(Token = "0x601F8D4")]
			[Address(RVA = "0x194B1C0", Offset = "0x1949DC0", VA = "0x18194B1C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170049E7 RID: 18919
		// (get) Token: 0x0601F8D5 RID: 129237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049E7")]
		public virtual RoguelikeScrollReportItemView summaryPrefab
		{
			[Token(Token = "0x601F8D5")]
			[Address(RVA = "0x194B280", Offset = "0x1949E80", VA = "0x18194B280", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170049E8 RID: 18920
		// (get) Token: 0x0601F8D6 RID: 129238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049E8")]
		public virtual RoguelikeScrollReportItemView summaryWithDifficultyPrefab
		{
			[Token(Token = "0x601F8D6")]
			[Address(RVA = "0x194B2E0", Offset = "0x1949EE0", VA = "0x18194B2E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170049E9 RID: 18921
		// (get) Token: 0x0601F8D7 RID: 129239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049E9")]
		public virtual RoguelikeScrollReportItemView endFailPrefab
		{
			[Token(Token = "0x601F8D7")]
			[Address(RVA = "0x194B040", Offset = "0x1949C40", VA = "0x18194B040", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170049EA RID: 18922
		// (get) Token: 0x0601F8D8 RID: 129240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049EA")]
		public virtual RoguelikeScrollReportItemView zonePrefab
		{
			[Token(Token = "0x601F8D8")]
			[Address(RVA = "0x194B3A0", Offset = "0x1949FA0", VA = "0x18194B3A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170049EB RID: 18923
		// (get) Token: 0x0601F8D9 RID: 129241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049EB")]
		public virtual RoguelikeScrollReportItemView nodePrefab
		{
			[Token(Token = "0x601F8D9")]
			[Address(RVA = "0x194B220", Offset = "0x1949E20", VA = "0x18194B220", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170049EC RID: 18924
		// (get) Token: 0x0601F8DA RID: 129242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049EC")]
		public virtual RoguelikeScrollReportItemView endPrefab
		{
			[Token(Token = "0x601F8DA")]
			[Address(RVA = "0x194B100", Offset = "0x1949D00", VA = "0x18194B100", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170049ED RID: 18925
		// (get) Token: 0x0601F8DB RID: 129243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049ED")]
		public virtual RoguelikeScrollReportItemView endPaddingPrefab
		{
			[Token(Token = "0x601F8DB")]
			[Address(RVA = "0x194B0A0", Offset = "0x1949CA0", VA = "0x18194B0A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F8DC RID: 129244 RVA: 0x000B2338 File Offset: 0x000B0538
		[Token(Token = "0x601F8DC")]
		[Address(RVA = "0x1949E80", Offset = "0x1948A80", VA = "0x181949E80")]
		public SpriteRenderData GetZoneIcon(string zoneId, RoguelikeEventType eventType)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601F8DD RID: 129245 RVA: 0x000B2350 File Offset: 0x000B0550
		[Token(Token = "0x601F8DD")]
		[Address(RVA = "0x19499F0", Offset = "0x19485F0", VA = "0x1819499F0")]
		public SpriteRenderData GetEndingIcon(string ending)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601F8DE RID: 129246 RVA: 0x000B2368 File Offset: 0x000B0568
		[Token(Token = "0x601F8DE")]
		[Address(RVA = "0x1949BA0", Offset = "0x19487A0", VA = "0x181949BA0")]
		public SpriteRenderData GetNodeIcon(EndingReportDisplayItem item)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601F8DF RID: 129247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8DF")]
		[Address(RVA = "0x194A7E0", Offset = "0x19493E0", VA = "0x18194A7E0")]
		private static string _FormatNodeSubTypeIconName(string directType, int subType)
		{
			return null;
		}

		// Token: 0x0601F8E0 RID: 129248 RVA: 0x000B2380 File Offset: 0x000B0580
		[Token(Token = "0x601F8E0")]
		[Address(RVA = "0x194A8B0", Offset = "0x19494B0", VA = "0x18194A8B0")]
		private SpriteRenderData _GetNormalZoneNodeIcon(EndingReportDisplayItem item)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601F8E1 RID: 129249 RVA: 0x000B2398 File Offset: 0x000B0598
		[Token(Token = "0x601F8E1")]
		[Address(RVA = "0x194AD90", Offset = "0x1949990", VA = "0x18194AD90")]
		private SpriteRenderData _GetSpZoneNodeIcon(EndingReportDisplayItem item)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601F8E2 RID: 129250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8E2")]
		[Address(RVA = "0x194A360", Offset = "0x1948F60", VA = "0x18194A360")]
		protected List<SpriteRenderData> GetZoneOverviewIcons(List<string> zoneIdList)
		{
			return null;
		}

		// Token: 0x0601F8E3 RID: 129251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8E3")]
		[Address(RVA = "0x194A5A0", Offset = "0x19491A0", VA = "0x18194A5A0")]
		protected List<SpriteRenderData> GetZoneOverviewNameIcons(List<string> zoneIdList)
		{
			return null;
		}

		// Token: 0x0601F8E4 RID: 129252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8E4")]
		[Address(RVA = "0x194A150", Offset = "0x1948D50", VA = "0x18194A150")]
		protected List<SpriteRenderData> GetZoneOverviewAllNameIcons()
		{
			return null;
		}

		// Token: 0x0601F8E5 RID: 129253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8E5")]
		[Address(RVA = "0x194AF80", Offset = "0x1949B80", VA = "0x18194AF80")]
		protected RoguelikeScrollReportPlugin()
		{
		}

		// Token: 0x0402A798 RID: 173976
		[Token(Token = "0x402A798")]
		private const string SPZONE_NODE_TYPE_FORMAT = "SPZONE_{0}";

		// Token: 0x0402A799 RID: 173977
		[Token(Token = "0x402A799")]
		private const string NODE_SUB_TYPE_ICON_FORMAT = "{0}_{1}";

		// Token: 0x0402A79A RID: 173978
		[Token(Token = "0x402A79A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Icons")]
		private List<RoguelikeScrollReportPlugin.Icon> _endingIcons;

		// Token: 0x0402A79B RID: 173979
		[Token(Token = "0x402A79B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Icons")]
		private List<RoguelikeScrollReportPlugin.Icon> _nodeIcons;

		// Token: 0x0402A79C RID: 173980
		[Token(Token = "0x402A79C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Icons")]
		private List<RoguelikeScrollReportPlugin.Icon> _spZoneNodeIcons;

		// Token: 0x0402A79D RID: 173981
		[Token(Token = "0x402A79D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Icons")]
		private List<RoguelikeScrollReportPlugin.Icon> _zoneIcons;

		// Token: 0x0402A79E RID: 173982
		[Token(Token = "0x402A79E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Icons")]
		private List<RoguelikeScrollReportPlugin.Icon> _zoneOverviewIcons;

		// Token: 0x0402A79F RID: 173983
		[Token(Token = "0x402A79F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Icons")]
		private List<RoguelikeScrollReportPlugin.Icon> _zoneOverviewNameIcons;

		// Token: 0x0402A7A0 RID: 173984
		[Token(Token = "0x402A7A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Icons")]
		private UIAtlasObject _iconObj;

		// Token: 0x0402A7A1 RID: 173985
		[Token(Token = "0x402A7A1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("ActPlay")]
		private float _endFadeHeight;

		// Token: 0x0402A7A2 RID: 173986
		[Token(Token = "0x402A7A2")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, RoguelikeScrollReportPlugin.Icon> m_nodeTypeToIcons;

		// Token: 0x0402A7A3 RID: 173987
		[Token(Token = "0x402A7A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_endFadeHeight;

		// Token: 0x0402A7A4 RID: 173988
		[Token(Token = "0x402A7A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_titlePrefab;

		// Token: 0x0402A7A5 RID: 173989
		[Token(Token = "0x402A7A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_endingFrameViewModelPlugin;

		// Token: 0x0402A7A6 RID: 173990
		[Token(Token = "0x402A7A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCastVirtualView;

		// Token: 0x0402A7A7 RID: 173991
		[Token(Token = "0x402A7A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetZoneOverViewVirtualView;

		// Token: 0x0402A7A8 RID: 173992
		[Token(Token = "0x402A7A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_initPrefab;

		// Token: 0x0402A7A9 RID: 173993
		[Token(Token = "0x402A7A9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_summaryPrefab;

		// Token: 0x0402A7AA RID: 173994
		[Token(Token = "0x402A7AA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_summaryWithDifficultyPrefab;

		// Token: 0x0402A7AB RID: 173995
		[Token(Token = "0x402A7AB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_endFailPrefab;

		// Token: 0x0402A7AC RID: 173996
		[Token(Token = "0x402A7AC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_zonePrefab;

		// Token: 0x0402A7AD RID: 173997
		[Token(Token = "0x402A7AD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_nodePrefab;

		// Token: 0x0402A7AE RID: 173998
		[Token(Token = "0x402A7AE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_endPrefab;

		// Token: 0x0402A7AF RID: 173999
		[Token(Token = "0x402A7AF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_endPaddingPrefab;

		// Token: 0x0402A7B0 RID: 174000
		[Token(Token = "0x402A7B0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetZoneIcon;

		// Token: 0x0402A7B1 RID: 174001
		[Token(Token = "0x402A7B1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetEndingIcon;

		// Token: 0x0402A7B2 RID: 174002
		[Token(Token = "0x402A7B2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetNodeIcon;

		// Token: 0x0402A7B3 RID: 174003
		[Token(Token = "0x402A7B3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__FormatNodeSubTypeIconName;

		// Token: 0x0402A7B4 RID: 174004
		[Token(Token = "0x402A7B4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetNormalZoneNodeIcon;

		// Token: 0x0402A7B5 RID: 174005
		[Token(Token = "0x402A7B5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetSpZoneNodeIcon;

		// Token: 0x0402A7B6 RID: 174006
		[Token(Token = "0x402A7B6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetZoneOverviewIcons;

		// Token: 0x0402A7B7 RID: 174007
		[Token(Token = "0x402A7B7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetZoneOverviewNameIcons;

		// Token: 0x0402A7B8 RID: 174008
		[Token(Token = "0x402A7B8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetZoneOverviewAllNameIcons;

		// Token: 0x0402A7B9 RID: 174009
		[Token(Token = "0x402A7B9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053C0 RID: 21440
		[Token(Token = "0x20053C0")]
		[Serializable]
		protected struct Icon
		{
			// Token: 0x0402A7BA RID: 174010
			[Token(Token = "0x402A7BA")]
			[FieldOffset(Offset = "0x0")]
			public string strKey;

			// Token: 0x0402A7BB RID: 174011
			[Token(Token = "0x402A7BB")]
			[FieldOffset(Offset = "0x8")]
			public int intKey;

			// Token: 0x0402A7BC RID: 174012
			[Token(Token = "0x402A7BC")]
			[FieldOffset(Offset = "0x10")]
			public string iconName;
		}
	}
}
