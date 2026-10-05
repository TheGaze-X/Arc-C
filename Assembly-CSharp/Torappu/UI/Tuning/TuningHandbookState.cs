using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C90 RID: 15504
	[Token(Token = "0x2003C90")]
	public class TuningHandbookState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601835D RID: 99165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601835D")]
		[Address(RVA = "0x10B56A0", Offset = "0x10B42A0", VA = "0x1810B56A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601835E RID: 99166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601835E")]
		[Address(RVA = "0x10B5050", Offset = "0x10B3C50", VA = "0x1810B5050", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601835F RID: 99167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601835F")]
		[Address(RVA = "0x10B57B0", Offset = "0x10B43B0", VA = "0x1810B57B0")]
		private void _OnBackClick()
		{
		}

		// Token: 0x06018360 RID: 99168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018360")]
		[Address(RVA = "0x10B5AF0", Offset = "0x10B46F0", VA = "0x1810B5AF0")]
		private void _SelectEmotion(string eID)
		{
		}

		// Token: 0x06018361 RID: 99169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018361")]
		[Address(RVA = "0x10B5F50", Offset = "0x10B4B50", VA = "0x1810B5F50")]
		private void _SelectLockEmotion(string eID)
		{
		}

		// Token: 0x06018362 RID: 99170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018362")]
		[Address(RVA = "0x10B5960", Offset = "0x10B4560", VA = "0x1810B5960")]
		private void _PlayBgm(string bgmID, string orcheId, bool isPlayFromStart)
		{
		}

		// Token: 0x06018363 RID: 99171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018363")]
		[Address(RVA = "0x10B5540", Offset = "0x10B4140", VA = "0x1810B5540", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06018364 RID: 99172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018364")]
		[Address(RVA = "0x10B5850", Offset = "0x10B4450", VA = "0x1810B5850")]
		private void _OnTransToPlayState(IStateBean stateBean)
		{
		}

		// Token: 0x06018365 RID: 99173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018365")]
		[Address(RVA = "0x10B53B0", Offset = "0x10B3FB0", VA = "0x1810B53B0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06018366 RID: 99174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018366")]
		[Address(RVA = "0x10B4FF0", Offset = "0x10B3BF0", VA = "0x1810B4FF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018367 RID: 99175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018367")]
		[Address(RVA = "0x10B5FF0", Offset = "0x10B4BF0", VA = "0x1810B5FF0")]
		public TuningHandbookState()
		{
		}

		// Token: 0x06018368 RID: 99176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018368")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018369 RID: 99177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018369")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401D7CD RID: 120781
		[Token(Token = "0x401D7CD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TuningHandbookView _view;

		// Token: 0x0401D7CE RID: 120782
		[Token(Token = "0x401D7CE")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x0401D7CF RID: 120783
		[Token(Token = "0x401D7CF")]
		[FieldOffset(Offset = "0x80")]
		private TuningHandbookStateBean m_stateBean;

		// Token: 0x0401D7D0 RID: 120784
		[Token(Token = "0x401D7D0")]
		[NonSerialized]
		public const int SELECT_EMOTION = 0;

		// Token: 0x0401D7D1 RID: 120785
		[Token(Token = "0x401D7D1")]
		[NonSerialized]
		public const int SELECT_LOCK_EMOTION = 1;

		// Token: 0x0401D7D2 RID: 120786
		[Token(Token = "0x401D7D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D7D3 RID: 120787
		[Token(Token = "0x401D7D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D7D4 RID: 120788
		[Token(Token = "0x401D7D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBackClick;

		// Token: 0x0401D7D5 RID: 120789
		[Token(Token = "0x401D7D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SelectEmotion;

		// Token: 0x0401D7D6 RID: 120790
		[Token(Token = "0x401D7D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SelectLockEmotion;

		// Token: 0x0401D7D7 RID: 120791
		[Token(Token = "0x401D7D7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayBgm;

		// Token: 0x0401D7D8 RID: 120792
		[Token(Token = "0x401D7D8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401D7D9 RID: 120793
		[Token(Token = "0x401D7D9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnTransToPlayState;

		// Token: 0x0401D7DA RID: 120794
		[Token(Token = "0x401D7DA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401D7DB RID: 120795
		[Token(Token = "0x401D7DB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D7DC RID: 120796
		[Token(Token = "0x401D7DC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
