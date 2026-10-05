using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E3A RID: 24122
	[Token(Token = "0x2005E3A")]
	public class CharacterRepoGridGroup : DataBinder<CharacterRepoCardGroupViewProperty>
	{
		// Token: 0x06022F3F RID: 143167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F3F")]
		[Address(RVA = "0x1D79D60", Offset = "0x1D78960", VA = "0x181D79D60")]
		public void Init(CharacterRepoGridGroup.Options options)
		{
		}

		// Token: 0x06022F40 RID: 143168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F40")]
		[Address(RVA = "0x1D79E30", Offset = "0x1D78A30", VA = "0x181D79E30", Slot = "7")]
		public override void OnValueChanged(CharacterRepoCardGroupViewProperty property)
		{
		}

		// Token: 0x06022F41 RID: 143169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F41")]
		[Address(RVA = "0x1D7A220", Offset = "0x1D78E20", VA = "0x181D7A220")]
		private IEnumerator _TrySetScrollPosition(float scrollPos)
		{
			return null;
		}

		// Token: 0x06022F42 RID: 143170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F42")]
		[Address(RVA = "0x1D7A2E0", Offset = "0x1D78EE0", VA = "0x181D7A2E0")]
		public CharacterRepoGridGroup()
		{
		}

		// Token: 0x0403027C RID: 197244
		[Token(Token = "0x403027C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterRepoGridAdapter _dataTarget;

		// Token: 0x0403027D RID: 197245
		[Token(Token = "0x403027D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopHorizontalScrollRect _scrollRect;

		// Token: 0x0403027E RID: 197246
		[Token(Token = "0x403027E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyStatePanel;

		// Token: 0x0403027F RID: 197247
		[Token(Token = "0x403027F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICharacterCardSelectEvent cardStarMarkEvent;

		// Token: 0x04030280 RID: 197248
		[Token(Token = "0x4030280")]
		[FieldOffset(Offset = "0x40")]
		private CharacterRepoCardView.Params m_charCardParams;

		// Token: 0x04030281 RID: 197249
		[Token(Token = "0x4030281")]
		[FieldOffset(Offset = "0x50")]
		private float m_scrollPosCache;

		// Token: 0x04030282 RID: 197250
		[Token(Token = "0x4030282")]
		[FieldOffset(Offset = "0x54")]
		private bool m_scrollPosLock;

		// Token: 0x04030283 RID: 197251
		[Token(Token = "0x4030283")]
		[FieldOffset(Offset = "0x58")]
		private int m_scrollPosRetryCount;

		// Token: 0x04030284 RID: 197252
		[Token(Token = "0x4030284")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04030285 RID: 197253
		[Token(Token = "0x4030285")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030286 RID: 197254
		[Token(Token = "0x4030286")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TrySetScrollPosition;

		// Token: 0x04030287 RID: 197255
		[Token(Token = "0x4030287")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E3B RID: 24123
		[Token(Token = "0x2005E3B")]
		public struct Options
		{
			// Token: 0x04030288 RID: 197256
			[Token(Token = "0x4030288")]
			[FieldOffset(Offset = "0x0")]
			public CharacterRepoCardView.Params charCardParams;

			// Token: 0x04030289 RID: 197257
			[Token(Token = "0x4030289")]
			[FieldOffset(Offset = "0x10")]
			public CharacterRepoCardGroupViewProperty property;
		}
	}
}
