using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	public class ScreenEffectHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06004DA5 RID: 19877 RVA: 0x0002DAE0 File Offset: 0x0002BCE0
		[Token(Token = "0x1700020B")]
		public bool isEnabled
		{
			[Token(Token = "0x6004DA5")]
			[Address(RVA = "0x188F9D0", Offset = "0x188E5D0", VA = "0x18188F9D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA6")]
		[Address(RVA = "0x188F470", Offset = "0x188E070", VA = "0x18188F470")]
		private void Awake()
		{
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA7")]
		[Address(RVA = "0x188F540", Offset = "0x188E140", VA = "0x18188F540")]
		public void SetEffectEnable(bool enable)
		{
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA8")]
		[Address(RVA = "0x188F860", Offset = "0x188E460", VA = "0x18188F860")]
		private void _EnableEffect()
		{
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA9")]
		[Address(RVA = "0x188F7B0", Offset = "0x188E3B0", VA = "0x18188F7B0")]
		private void _DisableEffect()
		{
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DAA")]
		[Address(RVA = "0x188F970", Offset = "0x188E570", VA = "0x18188F970")]
		public ScreenEffectHolder()
		{
		}

		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _enabled;

		// Token: 0x040011C5 RID: 4549
		[Token(Token = "0x40011C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _effectToLoad;

		// Token: 0x040011C6 RID: 4550
		[Token(Token = "0x40011C6")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_effectInst;

		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEnabled;

		// Token: 0x040011C8 RID: 4552
		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040011C9 RID: 4553
		[Token(Token = "0x40011C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetEffectEnable;

		// Token: 0x040011CA RID: 4554
		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnableEffect;

		// Token: 0x040011CB RID: 4555
		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DisableEffect;

		// Token: 0x040011CC RID: 4556
		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
