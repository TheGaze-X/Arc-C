using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DD3 RID: 7635
	[Token(Token = "0x2001DD3")]
	public class BuildingFloatManufactState : BuildingFloatVaultInfoState
	{
		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x0600BC4A RID: 48202 RVA: 0x00046200 File Offset: 0x00044400
		[Token(Token = "0x170016C6")]
		protected override FloatState state
		{
			[Token(Token = "0x600BC4A")]
			[Address(RVA = "0x3388F60", Offset = "0x3387B60", VA = "0x183388F60", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BC4B RID: 48203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC4B")]
		[Address(RVA = "0x3388B70", Offset = "0x3387770", VA = "0x183388B70", Slot = "14")]
		protected override void Start()
		{
		}

		// Token: 0x0600BC4C RID: 48204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC4C")]
		[Address(RVA = "0x3388A60", Offset = "0x3387660", VA = "0x183388A60", Slot = "15")]
		protected override void OnPlayerDataChanged(object args)
		{
		}

		// Token: 0x0600BC4D RID: 48205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC4D")]
		[Address(RVA = "0x3388AE0", Offset = "0x33876E0", VA = "0x183388AE0", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BC4E RID: 48206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC4E")]
		[Address(RVA = "0x3388930", Offset = "0x3387530", VA = "0x183388930")]
		public void EventOnManufactClick()
		{
		}

		// Token: 0x0600BC4F RID: 48207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC4F")]
		[Address(RVA = "0x3388C50", Offset = "0x3387850", VA = "0x183388C50")]
		private void _LoadData()
		{
		}

		// Token: 0x0600BC50 RID: 48208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC50")]
		[Address(RVA = "0x3388E50", Offset = "0x3387A50", VA = "0x183388E50")]
		public BuildingFloatManufactState()
		{
		}

		// Token: 0x0600BC51 RID: 48209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC51")]
		[Address(RVA = "0x3388C40", Offset = "0x3387840", VA = "0x183388C40")]
		private void <>xLuaBaseProxy_Start()
		{
		}

		// Token: 0x0600BC52 RID: 48210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC52")]
		[Address(RVA = "0x3387820", Offset = "0x3386420", VA = "0x183387820")]
		private void <>xLuaBaseProxy_OnPlayerDataChanged(object P0)
		{
		}

		// Token: 0x0600BC53 RID: 48211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC53")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0400BC52 RID: 48210
		[Token(Token = "0x400BC52")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private BuildingFloatManufactInfoView _manufactInfo;

		// Token: 0x0400BC53 RID: 48211
		[Token(Token = "0x400BC53")]
		[FieldOffset(Offset = "0xA8")]
		private FloatManufactViewProperty m_manufactProperty;

		// Token: 0x0400BC54 RID: 48212
		[Token(Token = "0x400BC54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BC55 RID: 48213
		[Token(Token = "0x400BC55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400BC56 RID: 48214
		[Token(Token = "0x400BC56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400BC57 RID: 48215
		[Token(Token = "0x400BC57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BC58 RID: 48216
		[Token(Token = "0x400BC58")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnManufactClick;

		// Token: 0x0400BC59 RID: 48217
		[Token(Token = "0x400BC59")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0400BC5A RID: 48218
		[Token(Token = "0x400BC5A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
