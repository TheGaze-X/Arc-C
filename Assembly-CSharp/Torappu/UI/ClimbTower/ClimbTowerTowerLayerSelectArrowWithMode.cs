using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CB9 RID: 23737
	[Token(Token = "0x2005CB9")]
	public class ClimbTowerTowerLayerSelectArrowWithMode : ClimbTowerTowerLayerBaseSelectArrow
	{
		// Token: 0x060225A3 RID: 140707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225A3")]
		[Address(RVA = "0x1CD82D0", Offset = "0x1CD6ED0", VA = "0x181CD82D0", Slot = "4")]
		public override void Render(ClimbTowerTowerLayerStackAdapter adapter)
		{
		}

		// Token: 0x060225A4 RID: 140708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225A4")]
		[Address(RVA = "0x1CD83E0", Offset = "0x1CD6FE0", VA = "0x181CD83E0")]
		private void _SetModePic(bool isHardMode)
		{
		}

		// Token: 0x060225A5 RID: 140709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225A5")]
		[Address(RVA = "0x1CD8470", Offset = "0x1CD7070", VA = "0x181CD8470")]
		public ClimbTowerTowerLayerSelectArrowWithMode()
		{
		}

		// Token: 0x0402F351 RID: 193361
		[Token(Token = "0x402F351")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objHardMode;

		// Token: 0x0402F352 RID: 193362
		[Token(Token = "0x402F352")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objNormalMode;

		// Token: 0x0402F353 RID: 193363
		[Token(Token = "0x402F353")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F354 RID: 193364
		[Token(Token = "0x402F354")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetModePic;

		// Token: 0x0402F355 RID: 193365
		[Token(Token = "0x402F355")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
