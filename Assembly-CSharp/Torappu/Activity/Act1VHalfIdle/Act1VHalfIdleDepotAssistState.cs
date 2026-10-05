using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007787 RID: 30599
	[Token(Token = "0x2007787")]
	public class Act1VHalfIdleDepotAssistState : PopupFadeState, IPlayerDataListener, IHotfixable, ICompDialogCallBack
	{
		// Token: 0x0602AF8C RID: 176012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF8C")]
		[Address(RVA = "0x26C43E0", Offset = "0x26C2FE0", VA = "0x1826C43E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AF8D RID: 176013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF8D")]
		[Address(RVA = "0x26C4BA0", Offset = "0x26C37A0", VA = "0x1826C4BA0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602AF8E RID: 176014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF8E")]
		[Address(RVA = "0x26C4A40", Offset = "0x26C3640", VA = "0x1826C4A40", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602AF8F RID: 176015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF8F")]
		[Address(RVA = "0x26C5820", Offset = "0x26C4420", VA = "0x1826C5820")]
		private void _RegisterToCommonFriendAssistState(IStateBean stateBean)
		{
		}

		// Token: 0x0602AF90 RID: 176016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF90")]
		[Address(RVA = "0x26C56C0", Offset = "0x26C42C0", VA = "0x1826C56C0")]
		private void _RegisterFromCommonFriendAssistState(IStateBean stateBean)
		{
		}

		// Token: 0x0602AF91 RID: 176017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF91")]
		[Address(RVA = "0x26C46C0", Offset = "0x26C32C0", VA = "0x1826C46C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AF92 RID: 176018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF92")]
		[Address(RVA = "0x26C4330", Offset = "0x26C2F30", VA = "0x1826C4330")]
		public void EventOnClickBg()
		{
		}

		// Token: 0x0602AF93 RID: 176019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF93")]
		[Address(RVA = "0x26C5020", Offset = "0x26C3C20", VA = "0x1826C5020")]
		private void _EventOnClickSupport(int selectSlotId)
		{
		}

		// Token: 0x0602AF94 RID: 176020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF94")]
		[Address(RVA = "0x26C5900", Offset = "0x26C4500", VA = "0x1826C5900")]
		private void _TryOpenAssistState(string actId, int selectSlotId, bool allowExtraAssist)
		{
		}

		// Token: 0x0602AF95 RID: 176021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF95")]
		[Address(RVA = "0x26C4D00", Offset = "0x26C3900", VA = "0x1826C4D00")]
		private void _EventOnClickClear(int selectSlotId)
		{
		}

		// Token: 0x0602AF96 RID: 176022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF96")]
		[Address(RVA = "0x26C4440", Offset = "0x26C3040", VA = "0x1826C4440", Slot = "33")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602AF97 RID: 176023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF97")]
		[Address(RVA = "0x26C5270", Offset = "0x26C3E70", VA = "0x1826C5270")]
		private void _HandleClearCharDlgCallback(ValueBundle output)
		{
		}

		// Token: 0x0602AF98 RID: 176024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF98")]
		[Address(RVA = "0x26C4660", Offset = "0x26C3260", VA = "0x1826C4660")]
		private void OnEnable()
		{
		}

		// Token: 0x0602AF99 RID: 176025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF99")]
		[Address(RVA = "0x26C4600", Offset = "0x26C3200", VA = "0x1826C4600")]
		private void OnDisable()
		{
		}

		// Token: 0x0602AF9A RID: 176026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF9A")]
		[Address(RVA = "0x26C4500", Offset = "0x26C3100", VA = "0x1826C4500")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602AF9B RID: 176027 RVA: 0x000DA8B0 File Offset: 0x000D8AB0
		[Token(Token = "0x602AF9B")]
		[Address(RVA = "0x26C40B0", Offset = "0x26C2CB0", VA = "0x1826C40B0", Slot = "31")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0602AF9C RID: 176028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF9C")]
		[Address(RVA = "0x26C4930", Offset = "0x26C3530", VA = "0x1826C4930", Slot = "32")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0602AF9D RID: 176029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF9D")]
		[Address(RVA = "0x26C5CF0", Offset = "0x26C48F0", VA = "0x1826C5CF0")]
		public Act1VHalfIdleDepotAssistState()
		{
		}

		// Token: 0x0602AF9E RID: 176030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF9E")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602AF9F RID: 176031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF9F")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602AFA0 RID: 176032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFA0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403E024 RID: 253988
		[Token(Token = "0x403E024")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1VHalfIdleDepotAssistView _assistView;

		// Token: 0x0403E025 RID: 253989
		[Token(Token = "0x403E025")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _blurBackground;

		// Token: 0x0403E026 RID: 253990
		[Token(Token = "0x403E026")]
		[FieldOffset(Offset = "0x80")]
		private Act1VHalfIdleDepotPage m_page;

		// Token: 0x0403E027 RID: 253991
		[Token(Token = "0x403E027")]
		[FieldOffset(Offset = "0x88")]
		private int m_clearCharDlgInst;

		// Token: 0x0403E028 RID: 253992
		[Token(Token = "0x403E028")]
		[FieldOffset(Offset = "0x8C")]
		private int m_cachedClearCharIndex;

		// Token: 0x0403E029 RID: 253993
		[Token(Token = "0x403E029")]
		[FieldOffset(Offset = "0x90")]
		private Act1VHalfIdleDepotAssistStateBean m_stateBean;

		// Token: 0x0403E02A RID: 253994
		[Token(Token = "0x403E02A")]
		[FieldOffset(Offset = "0x98")]
		private Act1VHalfIdleFriendAssistPlugin m_friendAssistPlugin;

		// Token: 0x0403E02B RID: 253995
		[Token(Token = "0x403E02B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E02C RID: 253996
		[Token(Token = "0x403E02C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403E02D RID: 253997
		[Token(Token = "0x403E02D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403E02E RID: 253998
		[Token(Token = "0x403E02E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterToCommonFriendAssistState;

		// Token: 0x0403E02F RID: 253999
		[Token(Token = "0x403E02F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterFromCommonFriendAssistState;

		// Token: 0x0403E030 RID: 254000
		[Token(Token = "0x403E030")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E031 RID: 254001
		[Token(Token = "0x403E031")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClickBg;

		// Token: 0x0403E032 RID: 254002
		[Token(Token = "0x403E032")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnClickSupport;

		// Token: 0x0403E033 RID: 254003
		[Token(Token = "0x403E033")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryOpenAssistState;

		// Token: 0x0403E034 RID: 254004
		[Token(Token = "0x403E034")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnClickClear;

		// Token: 0x0403E035 RID: 254005
		[Token(Token = "0x403E035")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403E036 RID: 254006
		[Token(Token = "0x403E036")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandleClearCharDlgCallback;

		// Token: 0x0403E037 RID: 254007
		[Token(Token = "0x403E037")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403E038 RID: 254008
		[Token(Token = "0x403E038")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0403E039 RID: 254009
		[Token(Token = "0x403E039")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403E03A RID: 254010
		[Token(Token = "0x403E03A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0403E03B RID: 254011
		[Token(Token = "0x403E03B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0403E03C RID: 254012
		[Token(Token = "0x403E03C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
