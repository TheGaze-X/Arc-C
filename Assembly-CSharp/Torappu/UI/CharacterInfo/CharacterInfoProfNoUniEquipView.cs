using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FA2 RID: 24482
	[Token(Token = "0x2005FA2")]
	public class CharacterInfoProfNoUniEquipView : CharacterInfoRightProfObj
	{
		// Token: 0x060236B6 RID: 145078 RVA: 0x000C0CF0 File Offset: 0x000BEEF0
		[Token(Token = "0x60236B6")]
		[Address(RVA = "0x1E02F10", Offset = "0x1E01B10", VA = "0x181E02F10", Slot = "4")]
		public override float GetAndApplyHeight()
		{
			return 0f;
		}

		// Token: 0x060236B7 RID: 145079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236B7")]
		[Address(RVA = "0x1E02FA0", Offset = "0x1E01BA0", VA = "0x181E02FA0", Slot = "6")]
		public override void Render(CharacterInfoHolderBean.CharViewModel viewModel)
		{
		}

		// Token: 0x060236B8 RID: 145080 RVA: 0x000C0D08 File Offset: 0x000BEF08
		[Token(Token = "0x60236B8")]
		[Address(RVA = "0x1E02E50", Offset = "0x1E01A50", VA = "0x181E02E50", Slot = "5")]
		public override bool CheckAvailInfo(CharacterInfoHolderBean.CharViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x060236B9 RID: 145081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236B9")]
		[Address(RVA = "0x1E03190", Offset = "0x1E01D90", VA = "0x181E03190")]
		public CharacterInfoProfNoUniEquipView()
		{
		}

		// Token: 0x060236BA RID: 145082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236BA")]
		[Address(RVA = "0x1E03130", Offset = "0x1E01D30", VA = "0x181E03130")]
		private void <>xLuaBaseProxy_Render(CharacterInfoHolderBean.CharViewModel P0)
		{
		}

		// Token: 0x060236BB RID: 145083 RVA: 0x000C0D20 File Offset: 0x000BEF20
		[Token(Token = "0x60236BB")]
		[Address(RVA = "0x1E030C0", Offset = "0x1E01CC0", VA = "0x181E030C0")]
		private bool <>xLuaBaseProxy_CheckAvailInfo(CharacterInfoHolderBean.CharViewModel P0)
		{
			return default(bool);
		}

		// Token: 0x04030F07 RID: 200455
		[Token(Token = "0x4030F07")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _currentStateText;

		// Token: 0x04030F08 RID: 200456
		[Token(Token = "0x4030F08")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _noEquipText;

		// Token: 0x04030F09 RID: 200457
		[Token(Token = "0x4030F09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAndApplyHeight;

		// Token: 0x04030F0A RID: 200458
		[Token(Token = "0x4030F0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030F0B RID: 200459
		[Token(Token = "0x4030F0B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckAvailInfo;

		// Token: 0x04030F0C RID: 200460
		[Token(Token = "0x4030F0C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
