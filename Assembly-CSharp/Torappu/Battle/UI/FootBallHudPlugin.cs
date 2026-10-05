using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003292 RID: 12946
	[Token(Token = "0x2003292")]
	public class FootBallHudPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x060148D7 RID: 84183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148D7")]
		[Address(RVA = "0xCCEA20", Offset = "0xCCD620", VA = "0x180CCEA20")]
		public void Reset()
		{
		}

		// Token: 0x060148D8 RID: 84184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148D8")]
		[Address(RVA = "0xCCE4C0", Offset = "0xCCD0C0", VA = "0x180CCE4C0")]
		public void OnForceVectorChanged(FP vectorX, FP vectorY, FP ratio)
		{
		}

		// Token: 0x060148D9 RID: 84185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148D9")]
		[Address(RVA = "0xCCE890", Offset = "0xCCD490", VA = "0x180CCE890")]
		public void OnKnockBackByDamage()
		{
		}

		// Token: 0x060148DA RID: 84186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148DA")]
		[Address(RVA = "0xCCEAE0", Offset = "0xCCD6E0", VA = "0x180CCEAE0")]
		private void _OnShootEnd(string args)
		{
		}

		// Token: 0x060148DB RID: 84187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148DB")]
		[Address(RVA = "0xCCEC00", Offset = "0xCCD800", VA = "0x180CCEC00")]
		public FootBallHudPlugin()
		{
		}

		// Token: 0x040184E9 RID: 99561
		[Token(Token = "0x40184E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform[] _performsRoots;

		// Token: 0x040184EA RID: 99562
		[Token(Token = "0x40184EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x040184EB RID: 99563
		[Token(Token = "0x40184EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _fillImage;

		// Token: 0x040184EC RID: 99564
		[Token(Token = "0x40184EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _shootImage;

		// Token: 0x040184ED RID: 99565
		[Token(Token = "0x40184ED")]
		private const string SHOOT_ANIM = "act2vmulti_battle_football_charge_shoot";

		// Token: 0x040184EE RID: 99566
		[Token(Token = "0x40184EE")]
		private const string HIT_ANIM = "act2vmulti_battle_football_charge_hit";

		// Token: 0x040184EF RID: 99567
		[Token(Token = "0x40184EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040184F0 RID: 99568
		[Token(Token = "0x40184F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnForceVectorChanged;

		// Token: 0x040184F1 RID: 99569
		[Token(Token = "0x40184F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnKnockBackByDamage;

		// Token: 0x040184F2 RID: 99570
		[Token(Token = "0x40184F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnShootEnd;

		// Token: 0x040184F3 RID: 99571
		[Token(Token = "0x40184F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
