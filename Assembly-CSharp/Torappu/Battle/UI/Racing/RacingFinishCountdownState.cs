using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Racing
{
	// Token: 0x02003426 RID: 13350
	[Token(Token = "0x2003426")]
	public class RacingFinishCountdownState : UIStateNode
	{
		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x060155C2 RID: 87490 RVA: 0x0008B728 File Offset: 0x00089928
		[Token(Token = "0x17003289")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60155C2")]
			[Address(RVA = "0xDD1FC0", Offset = "0xDD0BC0", VA = "0x180DD1FC0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x060155C3 RID: 87491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155C3")]
		[Address(RVA = "0xDD1BA0", Offset = "0xDD07A0", VA = "0x180DD1BA0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060155C4 RID: 87492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155C4")]
		[Address(RVA = "0xDD1EC0", Offset = "0xDD0AC0", VA = "0x180DD1EC0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060155C5 RID: 87493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155C5")]
		[Address(RVA = "0xDD18B0", Offset = "0xDD04B0", VA = "0x180DD18B0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060155C6 RID: 87494 RVA: 0x0008B740 File Offset: 0x00089940
		[Token(Token = "0x60155C6")]
		[Address(RVA = "0xDD1800", Offset = "0xDD0400", VA = "0x180DD1800", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x060155C7 RID: 87495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155C7")]
		[Address(RVA = "0xDD1F20", Offset = "0xDD0B20", VA = "0x180DD1F20")]
		public RacingFinishCountdownState()
		{
		}

		// Token: 0x060155C8 RID: 87496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155C8")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060155C9 RID: 87497 RVA: 0x0008B758 File Offset: 0x00089958
		[Token(Token = "0x60155C9")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x040198D0 RID: 104656
		[Token(Token = "0x40198D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCountdownNum;

		// Token: 0x040198D1 RID: 104657
		[Token(Token = "0x40198D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _coutdownCircle;

		// Token: 0x040198D2 RID: 104658
		[Token(Token = "0x40198D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _finishCountdownInfoHolder;

		// Token: 0x040198D3 RID: 104659
		[Token(Token = "0x40198D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _finishAnim;

		// Token: 0x040198D4 RID: 104660
		[Token(Token = "0x40198D4")]
		[FieldOffset(Offset = "0x48")]
		private RacingUIPlugin m_plugin;

		// Token: 0x040198D5 RID: 104661
		[Token(Token = "0x40198D5")]
		[FieldOffset(Offset = "0x50")]
		private int m_remainingTimeNum;

		// Token: 0x040198D6 RID: 104662
		[Token(Token = "0x40198D6")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tween;

		// Token: 0x040198D7 RID: 104663
		[Token(Token = "0x40198D7")]
		[FieldOffset(Offset = "0x60")]
		private PeriodicTimer periodicTimer;

		// Token: 0x040198D8 RID: 104664
		[Token(Token = "0x40198D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040198D9 RID: 104665
		[Token(Token = "0x40198D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040198DA RID: 104666
		[Token(Token = "0x40198DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040198DB RID: 104667
		[Token(Token = "0x40198DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x040198DC RID: 104668
		[Token(Token = "0x40198DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x040198DD RID: 104669
		[Token(Token = "0x40198DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
