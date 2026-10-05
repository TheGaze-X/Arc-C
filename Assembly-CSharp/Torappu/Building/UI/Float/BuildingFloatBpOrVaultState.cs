using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DD1 RID: 7633
	[Token(Token = "0x2001DD1")]
	public class BuildingFloatBpOrVaultState : BuildingFloatState
	{
		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x0600BC37 RID: 48183 RVA: 0x000461A0 File Offset: 0x000443A0
		[Token(Token = "0x170016C4")]
		protected override FloatState state
		{
			[Token(Token = "0x600BC37")]
			[Address(RVA = "0x33875D0", Offset = "0x33861D0", VA = "0x1833875D0", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC38")]
		[Address(RVA = "0x3387170", Offset = "0x3385D70", VA = "0x183387170", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BC39 RID: 48185 RVA: 0x000461B8 File Offset: 0x000443B8
		[Token(Token = "0x600BC39")]
		[Address(RVA = "0x33874B0", Offset = "0x33860B0", VA = "0x1833874B0")]
		private bool _CheckPlayerHasBuiltDorm()
		{
			return default(bool);
		}

		// Token: 0x0600BC3A RID: 48186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC3A")]
		[Address(RVA = "0x33873D0", Offset = "0x3385FD0", VA = "0x1833873D0")]
		public void OnStationManagerClick()
		{
		}

		// Token: 0x0600BC3B RID: 48187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC3B")]
		[Address(RVA = "0x3387570", Offset = "0x3386170", VA = "0x183387570")]
		public BuildingFloatBpOrVaultState()
		{
		}

		// Token: 0x0600BC3C RID: 48188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC3C")]
		[Address(RVA = "0x3383AF0", Offset = "0x33826F0", VA = "0x183383AF0")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0400BC32 RID: 48178
		[Token(Token = "0x400BC32")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _btnSM;

		// Token: 0x0400BC33 RID: 48179
		[Token(Token = "0x400BC33")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _iconDisableSM;

		// Token: 0x0400BC34 RID: 48180
		[Token(Token = "0x400BC34")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _stationManageTrackPoint;

		// Token: 0x0400BC35 RID: 48181
		[Token(Token = "0x400BC35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BC36 RID: 48182
		[Token(Token = "0x400BC36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BC37 RID: 48183
		[Token(Token = "0x400BC37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckPlayerHasBuiltDorm;

		// Token: 0x0400BC38 RID: 48184
		[Token(Token = "0x400BC38")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStationManagerClick;

		// Token: 0x0400BC39 RID: 48185
		[Token(Token = "0x400BC39")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
