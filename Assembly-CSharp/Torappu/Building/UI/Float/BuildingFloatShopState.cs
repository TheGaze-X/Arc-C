using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DD9 RID: 7641
	[Token(Token = "0x2001DD9")]
	public class BuildingFloatShopState : BuildingFloatVaultInfoState
	{
		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x0600BC75 RID: 48245 RVA: 0x00046290 File Offset: 0x00044490
		[Token(Token = "0x170016CB")]
		protected override FloatState state
		{
			[Token(Token = "0x600BC75")]
			[Address(RVA = "0x33A2770", Offset = "0x33A1370", VA = "0x1833A2770", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BC76 RID: 48246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC76")]
		[Address(RVA = "0x33A23F0", Offset = "0x33A0FF0", VA = "0x1833A23F0", Slot = "14")]
		protected override void Start()
		{
		}

		// Token: 0x0600BC77 RID: 48247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC77")]
		[Address(RVA = "0x33A22E0", Offset = "0x33A0EE0", VA = "0x1833A22E0", Slot = "15")]
		protected override void OnPlayerDataChanged(object args)
		{
		}

		// Token: 0x0600BC78 RID: 48248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC78")]
		[Address(RVA = "0x33A2360", Offset = "0x33A0F60", VA = "0x1833A2360", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BC79 RID: 48249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC79")]
		[Address(RVA = "0x33A2160", Offset = "0x33A0D60", VA = "0x1833A2160")]
		public void EventOnShopClick()
		{
		}

		// Token: 0x0600BC7A RID: 48250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC7A")]
		[Address(RVA = "0x33A24C0", Offset = "0x33A10C0", VA = "0x1833A24C0")]
		private void _LoadData()
		{
		}

		// Token: 0x0600BC7B RID: 48251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC7B")]
		[Address(RVA = "0x33A26A0", Offset = "0x33A12A0", VA = "0x1833A26A0")]
		public BuildingFloatShopState()
		{
		}

		// Token: 0x0600BC7C RID: 48252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC7C")]
		[Address(RVA = "0x3388C40", Offset = "0x3387840", VA = "0x183388C40")]
		private void <>xLuaBaseProxy_Start()
		{
		}

		// Token: 0x0600BC7D RID: 48253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC7D")]
		[Address(RVA = "0x3387820", Offset = "0x3386420", VA = "0x183387820")]
		private void <>xLuaBaseProxy_OnPlayerDataChanged(object P0)
		{
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC7E")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0400BC8B RID: 48267
		[Token(Token = "0x400BC8B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private BuildingFloatShopInfoView _shopInfoView;

		// Token: 0x0400BC8C RID: 48268
		[Token(Token = "0x400BC8C")]
		[FieldOffset(Offset = "0xA8")]
		private FloatShopInfoViewProperty m_shopInfoProp;

		// Token: 0x0400BC8D RID: 48269
		[Token(Token = "0x400BC8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BC8E RID: 48270
		[Token(Token = "0x400BC8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400BC8F RID: 48271
		[Token(Token = "0x400BC8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400BC90 RID: 48272
		[Token(Token = "0x400BC90")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BC91 RID: 48273
		[Token(Token = "0x400BC91")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnShopClick;

		// Token: 0x0400BC92 RID: 48274
		[Token(Token = "0x400BC92")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0400BC93 RID: 48275
		[Token(Token = "0x400BC93")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
