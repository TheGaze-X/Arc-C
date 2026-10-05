using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F31 RID: 7985
	[Token(Token = "0x2001F31")]
	public class AVGReaderModeShowItemView : MonoBehaviour, IAVGDataSubscriber<AVGReaderModePerformanceViewModel>, IHotfixable
	{
		// Token: 0x0600C689 RID: 50825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C689")]
		[Address(RVA = "0x3480490", Offset = "0x347F090", VA = "0x183480490", Slot = "4")]
		public void OnValueChanged(AVGReaderModePerformanceViewModel viewModel)
		{
		}

		// Token: 0x0600C68A RID: 50826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C68A")]
		[Address(RVA = "0x3480730", Offset = "0x347F330", VA = "0x183480730")]
		public void RenderView(Command command)
		{
		}

		// Token: 0x0600C68B RID: 50827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C68B")]
		[Address(RVA = "0x3480BC0", Offset = "0x347F7C0", VA = "0x183480BC0")]
		private void _ExecuteShowItem(Command command)
		{
		}

		// Token: 0x0600C68C RID: 50828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C68C")]
		[Address(RVA = "0x3480A90", Offset = "0x347F690", VA = "0x183480A90")]
		private void _ExecuteHideItem(Command command)
		{
		}

		// Token: 0x0600C68D RID: 50829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C68D")]
		[Address(RVA = "0x3481440", Offset = "0x3480040", VA = "0x183481440")]
		private void _ShowItem(Command command)
		{
		}

		// Token: 0x0600C68E RID: 50830 RVA: 0x00048888 File Offset: 0x00046A88
		[Token(Token = "0x600C68E")]
		[Address(RVA = "0x3480ED0", Offset = "0x347FAD0", VA = "0x183480ED0")]
		private AVGReaderModeShowItemView.ShowItemParam _GenParamWithCommand(Command command)
		{
			return default(AVGReaderModeShowItemView.ShowItemParam);
		}

		// Token: 0x0600C68F RID: 50831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C68F")]
		[Address(RVA = "0x3480D60", Offset = "0x347F960", VA = "0x183480D60")]
		private AVGReaderModeShowItemView.SlotStyle _FindSlotStyle(string style)
		{
			return null;
		}

		// Token: 0x0600C690 RID: 50832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C690")]
		[Address(RVA = "0x3481090", Offset = "0x347FC90", VA = "0x183481090")]
		private Sprite _LoadSprite(string key)
		{
			return null;
		}

		// Token: 0x0600C691 RID: 50833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C691")]
		[Address(RVA = "0x3481340", Offset = "0x347FF40", VA = "0x183481340")]
		private void _Reset()
		{
		}

		// Token: 0x0600C692 RID: 50834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C692")]
		[Address(RVA = "0x3480410", Offset = "0x347F010", VA = "0x183480410")]
		private void OnDisable()
		{
		}

		// Token: 0x0600C693 RID: 50835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C693")]
		[Address(RVA = "0x3480390", Offset = "0x347EF90", VA = "0x183480390")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C694 RID: 50836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C694")]
		[Address(RVA = "0x3481280", Offset = "0x347FE80", VA = "0x183481280")]
		private void _ResetCommandCache()
		{
		}

		// Token: 0x0600C695 RID: 50837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C695")]
		[Address(RVA = "0x3481190", Offset = "0x347FD90", VA = "0x183481190")]
		private Command _PickLatestShowHideCommand(Command showCommand, Command hideCommand)
		{
			return null;
		}

		// Token: 0x0600C696 RID: 50838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C696")]
		[Address(RVA = "0x3481AB0", Offset = "0x34806B0", VA = "0x183481AB0")]
		public AVGReaderModeShowItemView()
		{
		}

		// Token: 0x0400CBDB RID: 52187
		[Token(Token = "0x400CBDB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> SUPPORTED_COMMANDS;

		// Token: 0x0400CBDC RID: 52188
		[Token(Token = "0x400CBDC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AVGReaderModeShowItemView.SlotStyle[] _slotStyles;

		// Token: 0x0400CBDD RID: 52189
		[Token(Token = "0x400CBDD")]
		[FieldOffset(Offset = "0x20")]
		private AVGShowItemSlot m_slotInUse;

		// Token: 0x0400CBDE RID: 52190
		[Token(Token = "0x400CBDE")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<int> m_processedLineNumbers;

		// Token: 0x0400CBDF RID: 52191
		[Token(Token = "0x400CBDF")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, Command> m_lastCommandDict;

		// Token: 0x0400CBE0 RID: 52192
		[Token(Token = "0x400CBE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400CBE1 RID: 52193
		[Token(Token = "0x400CBE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0400CBE2 RID: 52194
		[Token(Token = "0x400CBE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteShowItem;

		// Token: 0x0400CBE3 RID: 52195
		[Token(Token = "0x400CBE3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteHideItem;

		// Token: 0x0400CBE4 RID: 52196
		[Token(Token = "0x400CBE4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowItem;

		// Token: 0x0400CBE5 RID: 52197
		[Token(Token = "0x400CBE5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenParamWithCommand;

		// Token: 0x0400CBE6 RID: 52198
		[Token(Token = "0x400CBE6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FindSlotStyle;

		// Token: 0x0400CBE7 RID: 52199
		[Token(Token = "0x400CBE7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x0400CBE8 RID: 52200
		[Token(Token = "0x400CBE8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x0400CBE9 RID: 52201
		[Token(Token = "0x400CBE9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400CBEA RID: 52202
		[Token(Token = "0x400CBEA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400CBEB RID: 52203
		[Token(Token = "0x400CBEB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ResetCommandCache;

		// Token: 0x0400CBEC RID: 52204
		[Token(Token = "0x400CBEC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PickLatestShowHideCommand;

		// Token: 0x0400CBED RID: 52205
		[Token(Token = "0x400CBED")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F32 RID: 7986
		[Token(Token = "0x2001F32")]
		public struct ShowItemParam
		{
			// Token: 0x0400CBEE RID: 52206
			[Token(Token = "0x400CBEE")]
			[FieldOffset(Offset = "0x0")]
			public string style;

			// Token: 0x0400CBEF RID: 52207
			[Token(Token = "0x400CBEF")]
			[FieldOffset(Offset = "0x8")]
			public string image;
		}

		// Token: 0x02001F33 RID: 7987
		[Token(Token = "0x2001F33")]
		[Serializable]
		private class SlotStyle
		{
			// Token: 0x0600C699 RID: 50841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C699")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SlotStyle()
			{
			}

			// Token: 0x0400CBF0 RID: 52208
			[Token(Token = "0x400CBF0")]
			[FieldOffset(Offset = "0x10")]
			public string styleKey;

			// Token: 0x0400CBF1 RID: 52209
			[Token(Token = "0x400CBF1")]
			[FieldOffset(Offset = "0x18")]
			public UnityEngine.Object slotPrefab;
		}
	}
}
