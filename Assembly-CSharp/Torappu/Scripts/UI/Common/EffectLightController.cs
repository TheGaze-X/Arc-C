using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Scripts.UI.Common
{
	// Token: 0x020017B5 RID: 6069
	[Token(Token = "0x20017B5")]
	public class EffectLightController : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600996C RID: 39276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600996C")]
		[Address(RVA = "0x3142C40", Offset = "0x3141840", VA = "0x183142C40")]
		public void SetCenterAnchorActive(bool isActive)
		{
		}

		// Token: 0x0600996D RID: 39277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600996D")]
		[Address(RVA = "0x3142BC0", Offset = "0x31417C0", VA = "0x183142BC0")]
		public void SetBottomAnchorActive(bool isActive)
		{
		}

		// Token: 0x0600996E RID: 39278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600996E")]
		[Address(RVA = "0x3142CC0", Offset = "0x31418C0", VA = "0x183142CC0")]
		public EffectLightController()
		{
		}

		// Token: 0x04008F9B RID: 36763
		[Token(Token = "0x4008F9B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _anchorCenter;

		// Token: 0x04008F9C RID: 36764
		[Token(Token = "0x4008F9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _anchorBottom;

		// Token: 0x04008F9D RID: 36765
		[Token(Token = "0x4008F9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetCenterAnchorActive;

		// Token: 0x04008F9E RID: 36766
		[Token(Token = "0x4008F9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetBottomAnchorActive;

		// Token: 0x04008F9F RID: 36767
		[Token(Token = "0x4008F9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
