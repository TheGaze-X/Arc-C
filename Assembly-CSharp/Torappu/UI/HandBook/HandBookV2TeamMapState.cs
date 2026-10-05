using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066EF RID: 26351
	[Token(Token = "0x20066EF")]
	public class HandBookV2TeamMapState : State
	{
		// Token: 0x06025D2B RID: 154923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D2B")]
		[Address(RVA = "0x20C8A70", Offset = "0x20C7670", VA = "0x1820C8A70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06025D2C RID: 154924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D2C")]
		[Address(RVA = "0x20C8B00", Offset = "0x20C7700", VA = "0x1820C8B00", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06025D2D RID: 154925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D2D")]
		[Address(RVA = "0x20C88D0", Offset = "0x20C74D0", VA = "0x1820C88D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025D2E RID: 154926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D2E")]
		[Address(RVA = "0x20C8B80", Offset = "0x20C7780", VA = "0x1820C8B80", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06025D2F RID: 154927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D2F")]
		[Address(RVA = "0x20C89C0", Offset = "0x20C75C0", VA = "0x1820C89C0")]
		public void OnClickForce(string id)
		{
		}

		// Token: 0x06025D30 RID: 154928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D30")]
		[Address(RVA = "0x20C8930", Offset = "0x20C7530", VA = "0x1820C8930")]
		public void OnClickFavorMissionList()
		{
		}

		// Token: 0x06025D31 RID: 154929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D31")]
		[Address(RVA = "0x20C8DC0", Offset = "0x20C79C0", VA = "0x1820C8DC0")]
		public HandBookV2TeamMapState()
		{
		}

		// Token: 0x06025D33 RID: 154931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D33")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06025D34 RID: 154932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D34")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06025D35 RID: 154933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D35")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x040352A7 RID: 217767
		[Token(Token = "0x40352A7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HandBookV2TeamMapStateBean _stateBean;

		// Token: 0x040352A8 RID: 217768
		[Token(Token = "0x40352A8")]
		[FieldOffset(Offset = "0x58")]
		private string m_cacheForce;

		// Token: 0x040352A9 RID: 217769
		[Token(Token = "0x40352A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040352AA RID: 217770
		[Token(Token = "0x40352AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040352AB RID: 217771
		[Token(Token = "0x40352AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040352AC RID: 217772
		[Token(Token = "0x40352AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040352AD RID: 217773
		[Token(Token = "0x40352AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickForce;

		// Token: 0x040352AE RID: 217774
		[Token(Token = "0x40352AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickFavorMissionList;

		// Token: 0x040352AF RID: 217775
		[Token(Token = "0x40352AF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
