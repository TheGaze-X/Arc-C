using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066EC RID: 26348
	[Token(Token = "0x20066EC")]
	public class HandBookV2FavorMissionState : PopupFloatState
	{
		// Token: 0x06025D0C RID: 154892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D0C")]
		[Address(RVA = "0x20BF4C0", Offset = "0x20BE0C0", VA = "0x1820BF4C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06025D0D RID: 154893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D0D")]
		[Address(RVA = "0x20BF730", Offset = "0x20BE330", VA = "0x1820BF730", Slot = "29")]
		protected override void OnPopup()
		{
		}

		// Token: 0x06025D0E RID: 154894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D0E")]
		[Address(RVA = "0x20BF7B0", Offset = "0x20BE3B0", VA = "0x1820BF7B0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06025D0F RID: 154895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D0F")]
		[Address(RVA = "0x20BF520", Offset = "0x20BE120", VA = "0x1820BF520")]
		public void OnCollectionRequest(string id)
		{
		}

		// Token: 0x06025D10 RID: 154896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D10")]
		[Address(RVA = "0x20BF8C0", Offset = "0x20BE4C0", VA = "0x1820BF8C0")]
		public HandBookV2FavorMissionState()
		{
		}

		// Token: 0x06025D12 RID: 154898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D12")]
		[Address(RVA = "0x209C350", Offset = "0x209AF50", VA = "0x18209C350")]
		private void <>xLuaBaseProxy_OnPopup()
		{
		}

		// Token: 0x06025D13 RID: 154899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D13")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403528B RID: 217739
		[Token(Token = "0x403528B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HandBookV2FavorMissionStateBean _stateBean;

		// Token: 0x0403528C RID: 217740
		[Token(Token = "0x403528C")]
		[FieldOffset(Offset = "0x78")]
		private bool m_needRefresh;

		// Token: 0x0403528D RID: 217741
		[Token(Token = "0x403528D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403528E RID: 217742
		[Token(Token = "0x403528E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPopup;

		// Token: 0x0403528F RID: 217743
		[Token(Token = "0x403528F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04035290 RID: 217744
		[Token(Token = "0x4035290")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCollectionRequest;

		// Token: 0x04035291 RID: 217745
		[Token(Token = "0x4035291")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
