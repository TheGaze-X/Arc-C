using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E37 RID: 24119
	[Token(Token = "0x2005E37")]
	public class CharacterRepoGridAdapter : UICharacterCardScrollAdapter<CharacterRepoGridAdapter.ViewHolder>
	{
		// Token: 0x06022F38 RID: 143160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F38")]
		[Address(RVA = "0x1D79430", Offset = "0x1D78030", VA = "0x181D79430", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x06022F39 RID: 143161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F39")]
		[Address(RVA = "0x1D794B0", Offset = "0x1D780B0", VA = "0x181D794B0")]
		public void SetArguments(CharacterRepoGridAdapter.RepoGridParam param)
		{
		}

		// Token: 0x06022F3A RID: 143162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F3A")]
		[Address(RVA = "0x1D79630", Offset = "0x1D78230", VA = "0x181D79630", Slot = "13")]
		public override void UpdateView(int position, GameObject view, CharacterRepoGridAdapter.ViewHolder holder, CharacterCardViewModel data)
		{
		}

		// Token: 0x06022F3B RID: 143163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F3B")]
		[Address(RVA = "0x1D79380", Offset = "0x1D77F80", VA = "0x181D79380", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06022F3C RID: 143164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F3C")]
		[Address(RVA = "0x1D79AD0", Offset = "0x1D786D0", VA = "0x181D79AD0")]
		private void _OnCardClick(int chrInstId)
		{
		}

		// Token: 0x06022F3D RID: 143165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F3D")]
		[Address(RVA = "0x1D79B60", Offset = "0x1D78760", VA = "0x181D79B60")]
		private void _OnStarMarkSelected(int chrInstId)
		{
		}

		// Token: 0x06022F3E RID: 143166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F3E")]
		[Address(RVA = "0x1D79BF0", Offset = "0x1D787F0", VA = "0x181D79BF0")]
		public CharacterRepoGridAdapter()
		{
		}

		// Token: 0x04030263 RID: 197219
		[Token(Token = "0x4030263")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _characterPanelPrefab;

		// Token: 0x04030264 RID: 197220
		[Token(Token = "0x4030264")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public UICharacterCardSelectEvent cardStarMarkSelectEvent;

		// Token: 0x04030265 RID: 197221
		[Token(Token = "0x4030265")]
		[FieldOffset(Offset = "0x70")]
		private bool m_disableLockAndInSquad;

		// Token: 0x04030266 RID: 197222
		[Token(Token = "0x4030266")]
		[FieldOffset(Offset = "0x78")]
		private List<int> m_selectedInstIds;

		// Token: 0x04030267 RID: 197223
		[Token(Token = "0x4030267")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<string, CharacterTrackPointData> m_charId2TrackPointDataMap;

		// Token: 0x04030268 RID: 197224
		[Token(Token = "0x4030268")]
		[FieldOffset(Offset = "0x88")]
		private HashSet<int> m_starMarkSelectedInstIds;

		// Token: 0x04030269 RID: 197225
		[Token(Token = "0x4030269")]
		[FieldOffset(Offset = "0x90")]
		private bool m_enableStarMarkSelectMode;

		// Token: 0x0403026A RID: 197226
		[Token(Token = "0x403026A")]
		[FieldOffset(Offset = "0x94")]
		private CharacterSortType m_currentSortType;

		// Token: 0x0403026B RID: 197227
		[Token(Token = "0x403026B")]
		[FieldOffset(Offset = "0x98")]
		private bool m_AVGIsFirstItemRegistered;

		// Token: 0x0403026C RID: 197228
		[Token(Token = "0x403026C")]
		[FieldOffset(Offset = "0xA0")]
		private CharacterRepoCardView.Params m_charCardParams;

		// Token: 0x0403026D RID: 197229
		[Token(Token = "0x403026D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x0403026E RID: 197230
		[Token(Token = "0x403026E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetArguments;

		// Token: 0x0403026F RID: 197231
		[Token(Token = "0x403026F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04030270 RID: 197232
		[Token(Token = "0x4030270")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04030271 RID: 197233
		[Token(Token = "0x4030271")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCardClick;

		// Token: 0x04030272 RID: 197234
		[Token(Token = "0x4030272")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnStarMarkSelected;

		// Token: 0x04030273 RID: 197235
		[Token(Token = "0x4030273")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E38 RID: 24120
		[Token(Token = "0x2005E38")]
		public struct ViewHolder
		{
			// Token: 0x04030274 RID: 197236
			[Token(Token = "0x4030274")]
			[FieldOffset(Offset = "0x0")]
			public CharacterRepoCardView panel;
		}

		// Token: 0x02005E39 RID: 24121
		[Token(Token = "0x2005E39")]
		public struct RepoGridParam
		{
			// Token: 0x04030275 RID: 197237
			[Token(Token = "0x4030275")]
			[FieldOffset(Offset = "0x0")]
			public List<int> selectedInstIds;

			// Token: 0x04030276 RID: 197238
			[Token(Token = "0x4030276")]
			[FieldOffset(Offset = "0x8")]
			public bool disableLockAndInSquad;

			// Token: 0x04030277 RID: 197239
			[Token(Token = "0x4030277")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, CharacterTrackPointData> charId2TrackPointDataMap;

			// Token: 0x04030278 RID: 197240
			[Token(Token = "0x4030278")]
			[FieldOffset(Offset = "0x18")]
			public HashSet<int> starMarkSelectedInstIds;

			// Token: 0x04030279 RID: 197241
			[Token(Token = "0x4030279")]
			[FieldOffset(Offset = "0x20")]
			public bool enableStarMarkSelectMode;

			// Token: 0x0403027A RID: 197242
			[Token(Token = "0x403027A")]
			[FieldOffset(Offset = "0x24")]
			public CharacterSortType sortType;

			// Token: 0x0403027B RID: 197243
			[Token(Token = "0x403027B")]
			[FieldOffset(Offset = "0x28")]
			public CharacterRepoCardView.Params charCardParams;
		}
	}
}
