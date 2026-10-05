using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DD8 RID: 7640
	[Token(Token = "0x2001DD8")]
	public class BuildingFloatPowerState : BuildingFloatVaultInfoState
	{
		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x0600BC70 RID: 48240 RVA: 0x00046278 File Offset: 0x00044478
		[Token(Token = "0x170016CA")]
		protected override FloatState state
		{
			[Token(Token = "0x600BC70")]
			[Address(RVA = "0x338F330", Offset = "0x338DF30", VA = "0x18338F330", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BC71 RID: 48241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC71")]
		[Address(RVA = "0x338EBD0", Offset = "0x338D7D0", VA = "0x18338EBD0", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BC72 RID: 48242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC72")]
		[Address(RVA = "0x338EF60", Offset = "0x338DB60", VA = "0x18338EF60")]
		private void _UpdateBuffedValues(float baseVal, float buffVal, SimpleLayoutContent layout, ref BuildingBuffedValueView.ListAdapter refAdapter)
		{
		}

		// Token: 0x0600BC73 RID: 48243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC73")]
		[Address(RVA = "0x338F220", Offset = "0x338DE20", VA = "0x18338F220")]
		public BuildingFloatPowerState()
		{
		}

		// Token: 0x0600BC74 RID: 48244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC74")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0400BC80 RID: 48256
		[Token(Token = "0x400BC80")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _powerText;

		// Token: 0x0400BC81 RID: 48257
		[Token(Token = "0x400BC81")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _accelLaborText;

		// Token: 0x0400BC82 RID: 48258
		[Token(Token = "0x400BC82")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private SimpleLayoutContent _laborAccelLayout;

		// Token: 0x0400BC83 RID: 48259
		[Token(Token = "0x400BC83")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Style Buff")]
		private Color _bkgColorLaborAccel;

		// Token: 0x0400BC84 RID: 48260
		[Token(Token = "0x400BC84")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Style Buff")]
		private Color _textColorLaborAccel;

		// Token: 0x0400BC85 RID: 48261
		[Token(Token = "0x400BC85")]
		[FieldOffset(Offset = "0xD8")]
		private PowerRoomViewModel m_viewModel;

		// Token: 0x0400BC86 RID: 48262
		[Token(Token = "0x400BC86")]
		[FieldOffset(Offset = "0xE0")]
		private BuildingBuffedValueView.ListAdapter m_laborAccelAdapter;

		// Token: 0x0400BC87 RID: 48263
		[Token(Token = "0x400BC87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BC88 RID: 48264
		[Token(Token = "0x400BC88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BC89 RID: 48265
		[Token(Token = "0x400BC89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateBuffedValues;

		// Token: 0x0400BC8A RID: 48266
		[Token(Token = "0x400BC8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
