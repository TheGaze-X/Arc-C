using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200328C RID: 12940
	[Token(Token = "0x200328C")]
	public class BounceEnemyHudPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x06014899 RID: 84121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014899")]
		[Address(RVA = "0xCCB510", Offset = "0xCCA110", VA = "0x180CCB510", Slot = "11")]
		public virtual void Reset()
		{
		}

		// Token: 0x0601489A RID: 84122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601489A")]
		[Address(RVA = "0xCCB0D0", Offset = "0xCC9CD0", VA = "0x180CCB0D0", Slot = "12")]
		public virtual void OnForceVectorChanged(InteractableBounceEnemy.IUIForceInfo forceInfo)
		{
		}

		// Token: 0x0601489B RID: 84123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601489B")]
		[Address(RVA = "0xCCAF20", Offset = "0xCC9B20", VA = "0x180CCAF20")]
		public void OnAppliedFinalForce()
		{
		}

		// Token: 0x0601489C RID: 84124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601489C")]
		[Address(RVA = "0xCCB5D0", Offset = "0xCCA1D0", VA = "0x180CCB5D0")]
		private void _OnShootEnd(string args)
		{
		}

		// Token: 0x0601489D RID: 84125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601489D")]
		[Address(RVA = "0xCCB670", Offset = "0xCCA270", VA = "0x180CCB670")]
		public BounceEnemyHudPlugin()
		{
		}

		// Token: 0x04018487 RID: 99463
		[Token(Token = "0x4018487")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected RectTransform[] _performsRoots;

		// Token: 0x04018488 RID: 99464
		[Token(Token = "0x4018488")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected AnimationWrapper _animWrapper;

		// Token: 0x04018489 RID: 99465
		[Token(Token = "0x4018489")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Image _fillImage;

		// Token: 0x0401848A RID: 99466
		[Token(Token = "0x401848A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Image _shootImage;

		// Token: 0x0401848B RID: 99467
		[Token(Token = "0x401848B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected string SHOOT_ANIM;

		// Token: 0x0401848C RID: 99468
		[Token(Token = "0x401848C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected string HIT_ANIM;

		// Token: 0x0401848D RID: 99469
		[Token(Token = "0x401848D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401848E RID: 99470
		[Token(Token = "0x401848E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnForceVectorChanged;

		// Token: 0x0401848F RID: 99471
		[Token(Token = "0x401848F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAppliedFinalForce;

		// Token: 0x04018490 RID: 99472
		[Token(Token = "0x4018490")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnShootEnd;

		// Token: 0x04018491 RID: 99473
		[Token(Token = "0x4018491")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
