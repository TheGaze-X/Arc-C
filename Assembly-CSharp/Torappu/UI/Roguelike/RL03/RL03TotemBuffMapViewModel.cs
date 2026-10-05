using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005865 RID: 22629
	[Token(Token = "0x2005865")]
	public class RL03TotemBuffMapViewModel : IHotfixable
	{
		// Token: 0x17004D8A RID: 19850
		// (get) Token: 0x060210CE RID: 135374 RVA: 0x000B8578 File Offset: 0x000B6778
		[Token(Token = "0x17004D8A")]
		public bool hasNodeSelected
		{
			[Token(Token = "0x60210CE")]
			[Address(RVA = "0x1B65850", Offset = "0x1B64450", VA = "0x181B65850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060210CF RID: 135375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210CF")]
		[Address(RVA = "0x1B64840", Offset = "0x1B63440", VA = "0x181B64840")]
		public void LoadData(string topicId, Dictionary<string, RL03TotemListItemViewModel> locationTotemItemDict)
		{
		}

		// Token: 0x060210D0 RID: 135376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60210D0")]
		[Address(RVA = "0x1B643C0", Offset = "0x1B62FC0", VA = "0x181B643C0")]
		public List<string> GetMapNoneSelectableNodeLocationTotemList()
		{
			return null;
		}

		// Token: 0x060210D1 RID: 135377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60210D1")]
		[Address(RVA = "0x1B64600", Offset = "0x1B63200", VA = "0x181B64600")]
		public RL03TotemBuffMapNodeViewModel GetNodeViewModel(string nodeCode)
		{
			return null;
		}

		// Token: 0x060210D2 RID: 135378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210D2")]
		[Address(RVA = "0x1B64CA0", Offset = "0x1B638A0", VA = "0x181B64CA0")]
		public void UpdateSelectableNodes(RL03TotemViewModel locationTotemViewModel)
		{
		}

		// Token: 0x060210D3 RID: 135379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210D3")]
		[Address(RVA = "0x1B64B40", Offset = "0x1B63740", VA = "0x181B64B40")]
		public void SelectNode(int depth, int index)
		{
		}

		// Token: 0x060210D4 RID: 135380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60210D4")]
		[Address(RVA = "0x1B646C0", Offset = "0x1B632C0", VA = "0x181B646C0")]
		public List<string> GetSelectNodes()
		{
			return null;
		}

		// Token: 0x060210D5 RID: 135381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210D5")]
		[Address(RVA = "0x1B651A0", Offset = "0x1B63DA0", VA = "0x181B651A0")]
		private void _CalcAllLocationTotemSelectResult(Dictionary<string, RL03TotemListItemViewModel> locationTotemItemDict)
		{
		}

		// Token: 0x060210D6 RID: 135382 RVA: 0x000B8590 File Offset: 0x000B6790
		[Token(Token = "0x60210D6")]
		[Address(RVA = "0x1B653E0", Offset = "0x1B63FE0", VA = "0x181B653E0")]
		private bool _CheckIfLocationTotemChanged(RL03TotemViewModel locationTotemViewModel)
		{
			return default(bool);
		}

		// Token: 0x060210D7 RID: 135383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210D7")]
		[Address(RVA = "0x1B65500", Offset = "0x1B64100", VA = "0x181B65500")]
		private void _ClearAllSelectInMap()
		{
		}

		// Token: 0x060210D8 RID: 135384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210D8")]
		[Address(RVA = "0x1B65700", Offset = "0x1B64300", VA = "0x181B65700")]
		public RL03TotemBuffMapViewModel()
		{
		}

		// Token: 0x0402CF94 RID: 184212
		[Token(Token = "0x402CF94")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeDungeonZone curZone;

		// Token: 0x0402CF95 RID: 184213
		[Token(Token = "0x402CF95")]
		[FieldOffset(Offset = "0x18")]
		public int curDepth;

		// Token: 0x0402CF96 RID: 184214
		[Token(Token = "0x402CF96")]
		[FieldOffset(Offset = "0x1C")]
		public int curIndex;

		// Token: 0x0402CF97 RID: 184215
		[Token(Token = "0x402CF97")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, RL03TotemBuffMapNodeViewModel> nodeViewModelDict;

		// Token: 0x0402CF98 RID: 184216
		[Token(Token = "0x402CF98")]
		[FieldOffset(Offset = "0x28")]
		public string topicId;

		// Token: 0x0402CF99 RID: 184217
		[Token(Token = "0x402CF99")]
		[FieldOffset(Offset = "0x30")]
		private List<RL03TotemBuffMapNodeViewModel> m_manualSelectableNodeViewModels;

		// Token: 0x0402CF9A RID: 184218
		[Token(Token = "0x402CF9A")]
		[FieldOffset(Offset = "0x38")]
		private RL03TotemViewModel m_cachedLocationTotemViewModel;

		// Token: 0x0402CF9B RID: 184219
		[Token(Token = "0x402CF9B")]
		[FieldOffset(Offset = "0x40")]
		private TotemMapNodeSelectType m_mapSelectType;

		// Token: 0x0402CF9C RID: 184220
		[Token(Token = "0x402CF9C")]
		[FieldOffset(Offset = "0x44")]
		private bool m_hasNodeSelected;

		// Token: 0x0402CF9D RID: 184221
		[Token(Token = "0x402CF9D")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, LocationTotemMapSelectResult> m_locationTotemSelectResultDict;

		// Token: 0x0402CF9E RID: 184222
		[Token(Token = "0x402CF9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasNodeSelected;

		// Token: 0x0402CF9F RID: 184223
		[Token(Token = "0x402CF9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402CFA0 RID: 184224
		[Token(Token = "0x402CFA0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMapNoneSelectableNodeLocationTotemList;

		// Token: 0x0402CFA1 RID: 184225
		[Token(Token = "0x402CFA1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetNodeViewModel;

		// Token: 0x0402CFA2 RID: 184226
		[Token(Token = "0x402CFA2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateSelectableNodes;

		// Token: 0x0402CFA3 RID: 184227
		[Token(Token = "0x402CFA3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SelectNode;

		// Token: 0x0402CFA4 RID: 184228
		[Token(Token = "0x402CFA4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetSelectNodes;

		// Token: 0x0402CFA5 RID: 184229
		[Token(Token = "0x402CFA5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CalcAllLocationTotemSelectResult;

		// Token: 0x0402CFA6 RID: 184230
		[Token(Token = "0x402CFA6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckIfLocationTotemChanged;

		// Token: 0x0402CFA7 RID: 184231
		[Token(Token = "0x402CFA7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearAllSelectInMap;

		// Token: 0x0402CFA8 RID: 184232
		[Token(Token = "0x402CFA8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
