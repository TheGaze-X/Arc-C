using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity.Act12D6;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D38 RID: 27960
	[Token(Token = "0x2006D38")]
	public class Act12D6OuterBuffState : PopupFloatState, IHotfixable
	{
		// Token: 0x06027DAA RID: 163242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DAA")]
		[Address(RVA = "0x22EBE60", Offset = "0x22EAA60", VA = "0x1822EBE60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027DAB RID: 163243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DAB")]
		[Address(RVA = "0x22EBEC0", Offset = "0x22EAAC0", VA = "0x1822EBEC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027DAC RID: 163244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DAC")]
		[Address(RVA = "0x22EC1C0", Offset = "0x22EADC0", VA = "0x1822EC1C0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06027DAD RID: 163245 RVA: 0x000CFAB0 File Offset: 0x000CDCB0
		[Token(Token = "0x6027DAD")]
		[Address(RVA = "0x22EC480", Offset = "0x22EB080", VA = "0x1822EC480", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x06027DAE RID: 163246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DAE")]
		[Address(RVA = "0x22EC060", Offset = "0x22EAC60", VA = "0x1822EC060", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06027DAF RID: 163247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DAF")]
		[Address(RVA = "0x22EBCA0", Offset = "0x22EA8A0", VA = "0x1822EBCA0")]
		public void EventOnOuterBuffDetail(string buffId)
		{
		}

		// Token: 0x06027DB0 RID: 163248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DB0")]
		[Address(RVA = "0x22EBC00", Offset = "0x22EA800", VA = "0x1822EBC00")]
		public void EventOnMaxLevel(string buffId)
		{
		}

		// Token: 0x06027DB1 RID: 163249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DB1")]
		[Address(RVA = "0x22EC4F0", Offset = "0x22EB0F0", VA = "0x1822EC4F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027DB2 RID: 163250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DB2")]
		[Address(RVA = "0x22EC610", Offset = "0x22EB210", VA = "0x1822EC610")]
		public Act12D6OuterBuffState()
		{
		}

		// Token: 0x06027DB6 RID: 163254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DB6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06027DB7 RID: 163255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DB7")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06027DB8 RID: 163256 RVA: 0x000CFAC8 File Offset: 0x000CDCC8
		[Token(Token = "0x6027DB8")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06027DB9 RID: 163257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DB9")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x040387DF RID: 231391
		[Token(Token = "0x40387DF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act12D6OuterBuffView _view;

		// Token: 0x040387E0 RID: 231392
		[Token(Token = "0x40387E0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act12D6CoinView _coinView;

		// Token: 0x040387E1 RID: 231393
		[Token(Token = "0x40387E1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040387E2 RID: 231394
		[Token(Token = "0x40387E2")]
		[FieldOffset(Offset = "0x88")]
		private Act12D6OuterBuffStateBean m_stateBean;

		// Token: 0x040387E3 RID: 231395
		[Token(Token = "0x40387E3")]
		[FieldOffset(Offset = "0x90")]
		private CommonTopMenu m_topMenu;

		// Token: 0x040387E4 RID: 231396
		[Token(Token = "0x40387E4")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x040387E5 RID: 231397
		[Token(Token = "0x40387E5")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedBuffId;

		// Token: 0x040387E6 RID: 231398
		[Token(Token = "0x40387E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040387E7 RID: 231399
		[Token(Token = "0x40387E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040387E8 RID: 231400
		[Token(Token = "0x40387E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040387E9 RID: 231401
		[Token(Token = "0x40387E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x040387EA RID: 231402
		[Token(Token = "0x40387EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x040387EB RID: 231403
		[Token(Token = "0x40387EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnOuterBuffDetail;

		// Token: 0x040387EC RID: 231404
		[Token(Token = "0x40387EC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnMaxLevel;

		// Token: 0x040387ED RID: 231405
		[Token(Token = "0x40387ED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040387EE RID: 231406
		[Token(Token = "0x40387EE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
