using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DF0 RID: 7664
	[Token(Token = "0x2001DF0")]
	public class BuildingFloatArchSwitchView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BD4C RID: 48460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD4C")]
		[Address(RVA = "0x339EC40", Offset = "0x339D840", VA = "0x18339EC40")]
		public void UpdateSwitch(bool isActive)
		{
		}

		// Token: 0x0600BD4D RID: 48461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD4D")]
		[Address(RVA = "0x339EBC0", Offset = "0x339D7C0", VA = "0x18339EBC0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600BD4E RID: 48462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD4E")]
		[Address(RVA = "0x339ECF0", Offset = "0x339D8F0", VA = "0x18339ECF0")]
		public BuildingFloatArchSwitchView()
		{
		}

		// Token: 0x0400BD88 RID: 48520
		[Token(Token = "0x400BD88")]
		private const string BUTTON_SWITCH_ON = "SWITCH_ON";

		// Token: 0x0400BD89 RID: 48521
		[Token(Token = "0x400BD89")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator _switchAnimator;

		// Token: 0x0400BD8A RID: 48522
		[Token(Token = "0x400BD8A")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isSwitchOn;

		// Token: 0x0400BD8B RID: 48523
		[Token(Token = "0x400BD8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateSwitch;

		// Token: 0x0400BD8C RID: 48524
		[Token(Token = "0x400BD8C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400BD8D RID: 48525
		[Token(Token = "0x400BD8D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
