using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200688B RID: 26763
	[Token(Token = "0x200688B")]
	public class StagePreviewRewardState : PopupFloatState
	{
		// Token: 0x0602657E RID: 157054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602657E")]
		[Address(RVA = "0x21690C0", Offset = "0x2167CC0", VA = "0x1821690C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602657F RID: 157055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602657F")]
		[Address(RVA = "0x2168990", Offset = "0x2167590", VA = "0x182168990", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06026580 RID: 157056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026580")]
		[Address(RVA = "0x2168E50", Offset = "0x2167A50", VA = "0x182168E50", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06026581 RID: 157057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026581")]
		[Address(RVA = "0x2168F10", Offset = "0x2167B10", VA = "0x182168F10", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06026582 RID: 157058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026582")]
		[Address(RVA = "0x21689F0", Offset = "0x21675F0", VA = "0x1821689F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026583 RID: 157059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026583")]
		[Address(RVA = "0x21691A0", Offset = "0x2167DA0", VA = "0x1821691A0")]
		public StagePreviewRewardState()
		{
		}

		// Token: 0x06026586 RID: 157062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026586")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x06026587 RID: 157063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026587")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06026588 RID: 157064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026588")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403600C RID: 221196
		[Token(Token = "0x403600C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private StageRewardStateBean _stateBean;

		// Token: 0x0403600D RID: 221197
		[Token(Token = "0x403600D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private StagePreviewRewardView _view;

		// Token: 0x0403600E RID: 221198
		[Token(Token = "0x403600E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuContainer;

		// Token: 0x0403600F RID: 221199
		[Token(Token = "0x403600F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private StageRewardDetailPluginHandler _pluginHandler;

		// Token: 0x04036010 RID: 221200
		[Token(Token = "0x4036010")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _pluginContainer;

		// Token: 0x04036011 RID: 221201
		[Token(Token = "0x4036011")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imgBgTint;

		// Token: 0x04036012 RID: 221202
		[Token(Token = "0x4036012")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _defaultBgTint;

		// Token: 0x04036013 RID: 221203
		[Token(Token = "0x4036013")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x04036014 RID: 221204
		[Token(Token = "0x4036014")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Tooltip("Block the events when state changes")]
		protected GameObject _globalEventMask;

		// Token: 0x04036015 RID: 221205
		[Token(Token = "0x4036015")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036016 RID: 221206
		[Token(Token = "0x4036016")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04036017 RID: 221207
		[Token(Token = "0x4036017")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04036018 RID: 221208
		[Token(Token = "0x4036018")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04036019 RID: 221209
		[Token(Token = "0x4036019")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403601A RID: 221210
		[Token(Token = "0x403601A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
