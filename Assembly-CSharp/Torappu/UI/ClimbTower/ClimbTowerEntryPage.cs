using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C63 RID: 23651
	[Token(Token = "0x2005C63")]
	public class ClimbTowerEntryPage : StateEnginePage
	{
		// Token: 0x17005074 RID: 20596
		// (get) Token: 0x0602244A RID: 140362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005074")]
		private string towerIdOnOpen
		{
			[Token(Token = "0x602244A")]
			[Address(RVA = "0x1CBB440", Offset = "0x1CBA040", VA = "0x181CBB440")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602244B RID: 140363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602244B")]
		[Address(RVA = "0x1CBAB90", Offset = "0x1CB9790", VA = "0x181CBAB90")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0602244C RID: 140364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602244C")]
		[Address(RVA = "0x1CBAE70", Offset = "0x1CB9A70", VA = "0x181CBAE70", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602244D RID: 140365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602244D")]
		[Address(RVA = "0x1CBADC0", Offset = "0x1CB99C0", VA = "0x181CBADC0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0602244E RID: 140366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602244E")]
		[Address(RVA = "0x1CBAD10", Offset = "0x1CB9910", VA = "0x181CBAD10", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0602244F RID: 140367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602244F")]
		[Address(RVA = "0x1CBB200", Offset = "0x1CB9E00", VA = "0x181CBB200", Slot = "14")]
		protected override void OnStop()
		{
		}

		// Token: 0x06022450 RID: 140368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022450")]
		[Address(RVA = "0x1CBB270", Offset = "0x1CB9E70", VA = "0x181CBB270")]
		private IEnumerator _RouteToClimbTowerList(bool fastMode)
		{
			return null;
		}

		// Token: 0x06022451 RID: 140369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022451")]
		[Address(RVA = "0x1CBB330", Offset = "0x1CB9F30", VA = "0x181CBB330")]
		private IEnumerator _RouteToClimbTowerPage()
		{
			return null;
		}

		// Token: 0x06022452 RID: 140370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022452")]
		[Address(RVA = "0x1CBB3E0", Offset = "0x1CB9FE0", VA = "0x181CBB3E0")]
		public ClimbTowerEntryPage()
		{
		}

		// Token: 0x06022454 RID: 140372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022454")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06022455 RID: 140373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022455")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x06022456 RID: 140374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022456")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x06022457 RID: 140375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022457")]
		[Address(RVA = "0x12C3F80", Offset = "0x12C2B80", VA = "0x1812C3F80")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x0402F0E8 RID: 192744
		[Token(Token = "0x402F0E8")]
		private const float ANIM_TIME = 0.3f;

		// Token: 0x0402F0E9 RID: 192745
		[Token(Token = "0x402F0E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CanvasGroup _fadeFloatPanel;

		// Token: 0x0402F0EA RID: 192746
		[Token(Token = "0x402F0EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UICommonPageEffectHolder[] _effectHolders;

		// Token: 0x0402F0EB RID: 192747
		[Token(Token = "0x402F0EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool m_isToClimbTowerPage;

		// Token: 0x0402F0EC RID: 192748
		[Token(Token = "0x402F0EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool m_isToTrainState;

		// Token: 0x0402F0ED RID: 192749
		[Token(Token = "0x402F0ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private UISwitchTween m_fadePanelTween;

		// Token: 0x0402F0EE RID: 192750
		[Token(Token = "0x402F0EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string m_towerIdFromSavedInst;

		// Token: 0x0402F0EF RID: 192751
		[Token(Token = "0x402F0EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool m_backFromBattle;

		// Token: 0x0402F0F0 RID: 192752
		[Token(Token = "0x402F0F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_towerIdOnOpen;

		// Token: 0x0402F0F1 RID: 192753
		[Token(Token = "0x402F0F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0402F0F2 RID: 192754
		[Token(Token = "0x402F0F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402F0F3 RID: 192755
		[Token(Token = "0x402F0F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0402F0F4 RID: 192756
		[Token(Token = "0x402F0F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0402F0F5 RID: 192757
		[Token(Token = "0x402F0F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0402F0F6 RID: 192758
		[Token(Token = "0x402F0F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RouteToClimbTowerList;

		// Token: 0x0402F0F7 RID: 192759
		[Token(Token = "0x402F0F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RouteToClimbTowerPage;

		// Token: 0x0402F0F8 RID: 192760
		[Token(Token = "0x402F0F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C64 RID: 23652
		[Token(Token = "0x2005C64")]
		public class Params
		{
			// Token: 0x06022458 RID: 140376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022458")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0402F0F9 RID: 192761
			[Token(Token = "0x402F0F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string towerId;
		}
	}
}
