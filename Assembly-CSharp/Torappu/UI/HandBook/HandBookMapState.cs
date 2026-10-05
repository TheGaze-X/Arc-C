using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006686 RID: 26246
	[Token(Token = "0x2006686")]
	public class HandBookMapState : State
	{
		// Token: 0x06025B0A RID: 154378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B0A")]
		[Address(RVA = "0x2099130", Offset = "0x2097D30", VA = "0x182099130")]
		public void OnEnemyHandBookClick()
		{
		}

		// Token: 0x06025B0B RID: 154379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B0B")]
		[Address(RVA = "0x20991B0", Offset = "0x2097DB0", VA = "0x1820991B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025B0C RID: 154380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B0C")]
		[Address(RVA = "0x20992C0", Offset = "0x2097EC0", VA = "0x1820992C0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06025B0D RID: 154381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025B0D")]
		[Address(RVA = "0x209A030", Offset = "0x2098C30", VA = "0x18209A030")]
		private IEnumerator _OnFadeBack()
		{
			return null;
		}

		// Token: 0x06025B0E RID: 154382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B0E")]
		[Address(RVA = "0x2098E50", Offset = "0x2097A50", VA = "0x182098E50")]
		public void CleanEffect()
		{
		}

		// Token: 0x06025B0F RID: 154383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B0F")]
		[Address(RVA = "0x2099210", Offset = "0x2097E10", VA = "0x182099210", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06025B10 RID: 154384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025B10")]
		[Address(RVA = "0x20990D0", Offset = "0x2097CD0", VA = "0x1820990D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025B11 RID: 154385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B11")]
		[Address(RVA = "0x209A0E0", Offset = "0x2098CE0", VA = "0x18209A0E0")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x06025B12 RID: 154386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025B12")]
		[Address(RVA = "0x20999D0", Offset = "0x20985D0", VA = "0x1820999D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06025B13 RID: 154387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B13")]
		[Address(RVA = "0x2099F70", Offset = "0x2098B70", VA = "0x182099F70")]
		private void _JumpFromOtherState(IStateBean stateBean)
		{
		}

		// Token: 0x06025B14 RID: 154388 RVA: 0x000C8C10 File Offset: 0x000C6E10
		[Token(Token = "0x6025B14")]
		[Address(RVA = "0x2099F00", Offset = "0x2098B00", VA = "0x182099F00", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x06025B15 RID: 154389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025B15")]
		[Address(RVA = "0x20997A0", Offset = "0x20983A0", VA = "0x1820997A0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06025B16 RID: 154390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B16")]
		[Address(RVA = "0x2099040", Offset = "0x2097C40", VA = "0x182099040")]
		public void EventOpenMission()
		{
		}

		// Token: 0x06025B17 RID: 154391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B17")]
		[Address(RVA = "0x2098EC0", Offset = "0x2097AC0", VA = "0x182098EC0")]
		public void EventOnBtnCheckClick()
		{
		}

		// Token: 0x06025B18 RID: 154392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B18")]
		[Address(RVA = "0x209A550", Offset = "0x2099150", VA = "0x18209A550")]
		public HandBookMapState()
		{
		}

		// Token: 0x06025B1F RID: 154399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B1F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06025B20 RID: 154400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B20")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06025B21 RID: 154401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B21")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06025B22 RID: 154402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025B22")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06025B23 RID: 154403 RVA: 0x000C8C40 File Offset: 0x000C6E40
		[Token(Token = "0x6025B23")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06025B24 RID: 154404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025B24")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04034F32 RID: 216882
		[Token(Token = "0x4034F32")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HandBookCommonStateBean _stateBean;

		// Token: 0x04034F33 RID: 216883
		[Token(Token = "0x4034F33")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x04034F34 RID: 216884
		[Token(Token = "0x4034F34")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private HandBookScrollView _scrollView;

		// Token: 0x04034F35 RID: 216885
		[Token(Token = "0x4034F35")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04034F36 RID: 216886
		[Token(Token = "0x4034F36")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04034F37 RID: 216887
		[Token(Token = "0x4034F37")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UICommonTrackPoint _missionTrackPoint;

		// Token: 0x04034F38 RID: 216888
		[Token(Token = "0x4034F38")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public TrackPointViewProperty missionTrackPointProperty;

		// Token: 0x04034F39 RID: 216889
		[Token(Token = "0x4034F39")]
		private const string FASTPLAY_FLAG = "scroll";

		// Token: 0x04034F3A RID: 216890
		[Token(Token = "0x4034F3A")]
		private const string TRIGGER_FLAG = "trigger";

		// Token: 0x04034F3B RID: 216891
		[Token(Token = "0x4034F3B")]
		[FieldOffset(Offset = "0x88")]
		private string m_cacheTargetCharId;

		// Token: 0x04034F3C RID: 216892
		[Token(Token = "0x4034F3C")]
		[FieldOffset(Offset = "0x90")]
		private bool m_initFlag;

		// Token: 0x04034F3D RID: 216893
		[Token(Token = "0x4034F3D")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_cacheTween;

		// Token: 0x04034F3E RID: 216894
		[Token(Token = "0x4034F3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnemyHandBookClick;

		// Token: 0x04034F3F RID: 216895
		[Token(Token = "0x4034F3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04034F40 RID: 216896
		[Token(Token = "0x4034F40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04034F41 RID: 216897
		[Token(Token = "0x4034F41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnFadeBack;

		// Token: 0x04034F42 RID: 216898
		[Token(Token = "0x4034F42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CleanEffect;

		// Token: 0x04034F43 RID: 216899
		[Token(Token = "0x4034F43")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04034F44 RID: 216900
		[Token(Token = "0x4034F44")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034F45 RID: 216901
		[Token(Token = "0x4034F45")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x04034F46 RID: 216902
		[Token(Token = "0x4034F46")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04034F47 RID: 216903
		[Token(Token = "0x4034F47")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__JumpFromOtherState;

		// Token: 0x04034F48 RID: 216904
		[Token(Token = "0x4034F48")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04034F49 RID: 216905
		[Token(Token = "0x4034F49")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04034F4A RID: 216906
		[Token(Token = "0x4034F4A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOpenMission;

		// Token: 0x04034F4B RID: 216907
		[Token(Token = "0x4034F4B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnBtnCheckClick;

		// Token: 0x04034F4C RID: 216908
		[Token(Token = "0x4034F4C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
