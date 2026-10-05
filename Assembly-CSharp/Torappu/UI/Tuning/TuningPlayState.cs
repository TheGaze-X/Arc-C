using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CCB RID: 15563
	[Token(Token = "0x2003CCB")]
	public class TuningPlayState : PopupFadeState, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x0601842E RID: 99374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601842E")]
		[Address(RVA = "0x10C4670", Offset = "0x10C3270", VA = "0x1810C4670", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601842F RID: 99375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601842F")]
		[Address(RVA = "0x10C46D0", Offset = "0x10C32D0", VA = "0x1810C46D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018430 RID: 99376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018430")]
		[Address(RVA = "0x10C4DE0", Offset = "0x10C39E0", VA = "0x1810C4DE0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06018431 RID: 99377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018431")]
		[Address(RVA = "0x10C5040", Offset = "0x10C3C40", VA = "0x1810C5040", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06018432 RID: 99378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018432")]
		[Address(RVA = "0x10C4A20", Offset = "0x10C3620", VA = "0x1810C4A20", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06018433 RID: 99379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018433")]
		[Address(RVA = "0x10C53C0", Offset = "0x10C3FC0", VA = "0x1810C53C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018434 RID: 99380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018434")]
		[Address(RVA = "0x10C5B80", Offset = "0x10C4780", VA = "0x1810C5B80")]
		private void _PlayCurMusic(bool isMainMusicFromStart)
		{
		}

		// Token: 0x06018435 RID: 99381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018435")]
		[Address(RVA = "0x10C6130", Offset = "0x10C4D30", VA = "0x1810C6130")]
		private void _TransToMusicHandBook()
		{
		}

		// Token: 0x06018436 RID: 99382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018436")]
		[Address(RVA = "0x10C5920", Offset = "0x10C4520", VA = "0x1810C5920")]
		private void _OpenOrche()
		{
		}

		// Token: 0x06018437 RID: 99383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018437")]
		[Address(RVA = "0x10C5210", Offset = "0x10C3E10", VA = "0x1810C5210")]
		private void _CloseOrche()
		{
		}

		// Token: 0x06018438 RID: 99384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018438")]
		[Address(RVA = "0x10C5F40", Offset = "0x10C4B40", VA = "0x1810C5F40")]
		private void _SelectOrche(string orcheId)
		{
		}

		// Token: 0x06018439 RID: 99385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018439")]
		[Address(RVA = "0x10C55F0", Offset = "0x10C41F0", VA = "0x1810C55F0")]
		private void _OnBackBtnPressed()
		{
		}

		// Token: 0x0601843A RID: 99386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601843A")]
		[Address(RVA = "0x10C5690", Offset = "0x10C4290", VA = "0x1810C5690")]
		private void _OnTransToHandBookState(IStateBean stateBean)
		{
		}

		// Token: 0x0601843B RID: 99387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601843B")]
		[Address(RVA = "0x10C5850", Offset = "0x10C4450", VA = "0x1810C5850")]
		private void _OnTransToProductState(IStateBean stateBean)
		{
		}

		// Token: 0x0601843C RID: 99388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601843C")]
		[Address(RVA = "0x10C61E0", Offset = "0x10C4DE0", VA = "0x1810C61E0")]
		public TuningPlayState()
		{
		}

		// Token: 0x0601843D RID: 99389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601843D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601843E RID: 99390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601843E")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601843F RID: 99391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601843F")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401D98F RID: 121231
		[Token(Token = "0x401D98F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0401D990 RID: 121232
		[Token(Token = "0x401D990")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TuningPlayView _playView;

		// Token: 0x0401D991 RID: 121233
		[Token(Token = "0x401D991")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TuningPlayMenuView _menuView;

		// Token: 0x0401D992 RID: 121234
		[Token(Token = "0x401D992")]
		[FieldOffset(Offset = "0x88")]
		private TuningPlayStateBean m_stateBean;

		// Token: 0x0401D993 RID: 121235
		[Token(Token = "0x401D993")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0401D994 RID: 121236
		[Token(Token = "0x401D994")]
		[FieldOffset(Offset = "0x98")]
		private string m_actId;

		// Token: 0x0401D995 RID: 121237
		[Token(Token = "0x401D995")]
		[NonSerialized]
		public const int TRANS_TO_MUSIC_HAND_BOOK = 0;

		// Token: 0x0401D996 RID: 121238
		[Token(Token = "0x401D996")]
		[NonSerialized]
		public const int OPEN_ORCHE = 1;

		// Token: 0x0401D997 RID: 121239
		[Token(Token = "0x401D997")]
		[NonSerialized]
		public const int CLOSE_ORCHE = 2;

		// Token: 0x0401D998 RID: 121240
		[Token(Token = "0x401D998")]
		[NonSerialized]
		public const int BACK_TO_PRODUCT = 3;

		// Token: 0x0401D999 RID: 121241
		[Token(Token = "0x401D999")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D99A RID: 121242
		[Token(Token = "0x401D99A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D99B RID: 121243
		[Token(Token = "0x401D99B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401D99C RID: 121244
		[Token(Token = "0x401D99C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401D99D RID: 121245
		[Token(Token = "0x401D99D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401D99E RID: 121246
		[Token(Token = "0x401D99E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D99F RID: 121247
		[Token(Token = "0x401D99F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayCurMusic;

		// Token: 0x0401D9A0 RID: 121248
		[Token(Token = "0x401D9A0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TransToMusicHandBook;

		// Token: 0x0401D9A1 RID: 121249
		[Token(Token = "0x401D9A1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OpenOrche;

		// Token: 0x0401D9A2 RID: 121250
		[Token(Token = "0x401D9A2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CloseOrche;

		// Token: 0x0401D9A3 RID: 121251
		[Token(Token = "0x401D9A3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SelectOrche;

		// Token: 0x0401D9A4 RID: 121252
		[Token(Token = "0x401D9A4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnBackBtnPressed;

		// Token: 0x0401D9A5 RID: 121253
		[Token(Token = "0x401D9A5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnTransToHandBookState;

		// Token: 0x0401D9A6 RID: 121254
		[Token(Token = "0x401D9A6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnTransToProductState;

		// Token: 0x0401D9A7 RID: 121255
		[Token(Token = "0x401D9A7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
