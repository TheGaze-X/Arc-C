using System;
using Il2CppDummyDll;
using Torappu.Building.UI.Hire;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DD2 RID: 7634
	[Token(Token = "0x2001DD2")]
	public class BuildingFloatHireState : BuildingFloatVaultInfoState
	{
		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x0600BC3D RID: 48189 RVA: 0x000461D0 File Offset: 0x000443D0
		[Token(Token = "0x170016C5")]
		protected override FloatState state
		{
			[Token(Token = "0x600BC3D")]
			[Address(RVA = "0x33888D0", Offset = "0x33874D0", VA = "0x1833888D0", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BC3E RID: 48190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC3E")]
		[Address(RVA = "0x3387630", Offset = "0x3386230", VA = "0x183387630")]
		public void EventOnHireSelect()
		{
		}

		// Token: 0x0600BC3F RID: 48191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC3F")]
		[Address(RVA = "0x3387850", Offset = "0x3386450", VA = "0x183387850")]
		private void Update()
		{
		}

		// Token: 0x0600BC40 RID: 48192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC40")]
		[Address(RVA = "0x3388530", Offset = "0x3387130", VA = "0x183388530")]
		private void _RenderCountDownValue()
		{
		}

		// Token: 0x0600BC41 RID: 48193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC41")]
		[Address(RVA = "0x3387780", Offset = "0x3386380", VA = "0x183387780", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BC42 RID: 48194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC42")]
		[Address(RVA = "0x33879C0", Offset = "0x33865C0", VA = "0x1833879C0")]
		private void _RefreshView()
		{
		}

		// Token: 0x0600BC43 RID: 48195 RVA: 0x000461E8 File Offset: 0x000443E8
		[Token(Token = "0x600BC43")]
		[Address(RVA = "0x33878C0", Offset = "0x33864C0", VA = "0x1833878C0")]
		private bool _IsTotalEmpty(PlayerBuildingHire playerHire)
		{
			return default(bool);
		}

		// Token: 0x0600BC44 RID: 48196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC44")]
		[Address(RVA = "0x3387700", Offset = "0x3386300", VA = "0x183387700", Slot = "15")]
		protected override void OnPlayerDataChanged(object args)
		{
		}

		// Token: 0x0600BC45 RID: 48197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC45")]
		[Address(RVA = "0x3388800", Offset = "0x3387400", VA = "0x183388800")]
		public BuildingFloatHireState()
		{
		}

		// Token: 0x0600BC48 RID: 48200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC48")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0600BC49 RID: 48201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC49")]
		[Address(RVA = "0x3387820", Offset = "0x3386420", VA = "0x183387820")]
		private void <>xLuaBaseProxy_OnPlayerDataChanged(object P0)
		{
		}

		// Token: 0x0400BC3A RID: 48186
		[Token(Token = "0x400BC3A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _avatarIcon;

		// Token: 0x0400BC3B RID: 48187
		[Token(Token = "0x400BC3B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _downCountTime;

		// Token: 0x0400BC3C RID: 48188
		[Token(Token = "0x400BC3C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _statePercent;

		// Token: 0x0400BC3D RID: 48189
		[Token(Token = "0x400BC3D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _stateBar;

		// Token: 0x0400BC3E RID: 48190
		[Token(Token = "0x400BC3E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _emptyPart;

		// Token: 0x0400BC3F RID: 48191
		[Token(Token = "0x400BC3F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _avatarPart;

		// Token: 0x0400BC40 RID: 48192
		[Token(Token = "0x400BC40")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _noAvatarPart;

		// Token: 0x0400BC41 RID: 48193
		[Token(Token = "0x400BC41")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _hiringPart;

		// Token: 0x0400BC42 RID: 48194
		[Token(Token = "0x400BC42")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _hiredPart;

		// Token: 0x0400BC43 RID: 48195
		[Token(Token = "0x400BC43")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _pausePart;

		// Token: 0x0400BC44 RID: 48196
		[Token(Token = "0x400BC44")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Text _hiredText;

		// Token: 0x0400BC45 RID: 48197
		[Token(Token = "0x400BC45")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _iconTimeArrow;

		// Token: 0x0400BC46 RID: 48198
		[Token(Token = "0x400BC46")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private BuildingHireRefreshCountView _refreshCount;

		// Token: 0x0400BC47 RID: 48199
		[Token(Token = "0x400BC47")]
		[FieldOffset(Offset = "0x108")]
		private HiringSnapshot m_hireSnapshot;

		// Token: 0x0400BC48 RID: 48200
		[Token(Token = "0x400BC48")]
		[FieldOffset(Offset = "0x138")]
		private CountDownTask m_hiringCountDown;

		// Token: 0x0400BC49 RID: 48201
		[Token(Token = "0x400BC49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BC4A RID: 48202
		[Token(Token = "0x400BC4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnHireSelect;

		// Token: 0x0400BC4B RID: 48203
		[Token(Token = "0x400BC4B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400BC4C RID: 48204
		[Token(Token = "0x400BC4C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCountDownValue;

		// Token: 0x0400BC4D RID: 48205
		[Token(Token = "0x400BC4D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BC4E RID: 48206
		[Token(Token = "0x400BC4E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x0400BC4F RID: 48207
		[Token(Token = "0x400BC4F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsTotalEmpty;

		// Token: 0x0400BC50 RID: 48208
		[Token(Token = "0x400BC50")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400BC51 RID: 48209
		[Token(Token = "0x400BC51")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
