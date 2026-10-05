using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005160 RID: 20832
	[Token(Token = "0x2005160")]
	public class DeepSeaRPEndingState : PopupFadeState
	{
		// Token: 0x0601EC82 RID: 126082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EC82")]
		[Address(RVA = "0x1867C50", Offset = "0x1866850", VA = "0x181867C50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601EC83 RID: 126083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC83")]
		[Address(RVA = "0x1867CB0", Offset = "0x18668B0", VA = "0x181867CB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601EC84 RID: 126084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC84")]
		[Address(RVA = "0x1868290", Offset = "0x1866E90", VA = "0x181868290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EC85 RID: 126085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC85")]
		[Address(RVA = "0x18683A0", Offset = "0x1866FA0", VA = "0x1818683A0")]
		private void _InitView()
		{
		}

		// Token: 0x0601EC86 RID: 126086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC86")]
		[Address(RVA = "0x1868090", Offset = "0x1866C90", VA = "0x181868090")]
		private void _EventOnZoneClick(string zoneId)
		{
		}

		// Token: 0x0601EC87 RID: 126087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC87")]
		[Address(RVA = "0x1867E20", Offset = "0x1866A20", VA = "0x181867E20")]
		private void _CloseState([Optional] Action callbackBeforeDismiss)
		{
		}

		// Token: 0x0601EC88 RID: 126088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC88")]
		[Address(RVA = "0x1867BF0", Offset = "0x18667F0", VA = "0x181867BF0")]
		public void CloseState()
		{
		}

		// Token: 0x0601EC89 RID: 126089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC89")]
		[Address(RVA = "0x18685A0", Offset = "0x18671A0", VA = "0x1818685A0")]
		public DeepSeaRPEndingState()
		{
		}

		// Token: 0x0601EC8A RID: 126090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC8A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402944B RID: 169035
		[Token(Token = "0x402944B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x0402944C RID: 169036
		[Token(Token = "0x402944C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DeepSeaRPEndingZoneGroupView _view;

		// Token: 0x0402944D RID: 169037
		[Token(Token = "0x402944D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0402944E RID: 169038
		[Token(Token = "0x402944E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402944F RID: 169039
		[Token(Token = "0x402944F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04029450 RID: 169040
		[Token(Token = "0x4029450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029451 RID: 169041
		[Token(Token = "0x4029451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitView;

		// Token: 0x04029452 RID: 169042
		[Token(Token = "0x4029452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnZoneClick;

		// Token: 0x04029453 RID: 169043
		[Token(Token = "0x4029453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CloseState;

		// Token: 0x04029454 RID: 169044
		[Token(Token = "0x4029454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CloseState;

		// Token: 0x04029455 RID: 169045
		[Token(Token = "0x4029455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
