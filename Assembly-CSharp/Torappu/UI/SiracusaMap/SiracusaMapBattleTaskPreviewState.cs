using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F4E RID: 16206
	[Token(Token = "0x2003F4E")]
	public class SiracusaMapBattleTaskPreviewState : PopupFloatState
	{
		// Token: 0x0601927C RID: 103036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601927C")]
		[Address(RVA = "0x11D0EF0", Offset = "0x11CFAF0", VA = "0x1811D0EF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601927D RID: 103037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601927D")]
		[Address(RVA = "0x11D12E0", Offset = "0x11CFEE0", VA = "0x1811D12E0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601927E RID: 103038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601927E")]
		[Address(RVA = "0x11D0F50", Offset = "0x11CFB50", VA = "0x1811D0F50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601927F RID: 103039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601927F")]
		[Address(RVA = "0x11D19E0", Offset = "0x11D05E0", VA = "0x1811D19E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019280 RID: 103040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019280")]
		[Address(RVA = "0x11D1880", Offset = "0x11D0480", VA = "0x1811D1880", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06019281 RID: 103041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019281")]
		[Address(RVA = "0x11D1B00", Offset = "0x11D0700", VA = "0x1811D1B00")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x06019282 RID: 103042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019282")]
		[Address(RVA = "0x11D1410", Offset = "0x11D0010", VA = "0x1811D1410")]
		public void OpenEnemyHandbook()
		{
		}

		// Token: 0x06019283 RID: 103043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019283")]
		[Address(RVA = "0x11D14A0", Offset = "0x11D00A0", VA = "0x1811D14A0")]
		public void OpenSquad()
		{
		}

		// Token: 0x06019284 RID: 103044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019284")]
		[Address(RVA = "0x11D1D30", Offset = "0x11D0930", VA = "0x1811D1D30")]
		public SiracusaMapBattleTaskPreviewState()
		{
		}

		// Token: 0x06019285 RID: 103045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019285")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06019286 RID: 103046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019286")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019287 RID: 103047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019287")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401F2EC RID: 127724
		[Token(Token = "0x401F2EC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SiracusaMapBattleTaskPreviewView _view;

		// Token: 0x0401F2ED RID: 127725
		[Token(Token = "0x401F2ED")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _btnBackRt;

		// Token: 0x0401F2EE RID: 127726
		[Token(Token = "0x401F2EE")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0401F2EF RID: 127727
		[Token(Token = "0x401F2EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F2F0 RID: 127728
		[Token(Token = "0x401F2F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401F2F1 RID: 127729
		[Token(Token = "0x401F2F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401F2F2 RID: 127730
		[Token(Token = "0x401F2F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F2F3 RID: 127731
		[Token(Token = "0x401F2F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401F2F4 RID: 127732
		[Token(Token = "0x401F2F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x0401F2F5 RID: 127733
		[Token(Token = "0x401F2F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OpenEnemyHandbook;

		// Token: 0x0401F2F6 RID: 127734
		[Token(Token = "0x401F2F6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OpenSquad;

		// Token: 0x0401F2F7 RID: 127735
		[Token(Token = "0x401F2F7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
