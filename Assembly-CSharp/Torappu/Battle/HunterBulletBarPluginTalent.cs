using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024B0 RID: 9392
	[Token(Token = "0x20024B0")]
	public class HunterBulletBarPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x0600F188 RID: 61832 RVA: 0x00058F98 File Offset: 0x00057198
		[Token(Token = "0x17001F67")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F188")]
			[Address(RVA = "0x68EA80", Offset = "0x68D680", VA = "0x18068EA80", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x0600F189 RID: 61833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F68")]
		private Character characterOwner
		{
			[Token(Token = "0x600F189")]
			[Address(RVA = "0x68E280", Offset = "0x68CE80", VA = "0x18068E280")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x0600F18A RID: 61834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F69")]
		private Ability traitAbiliy
		{
			[Token(Token = "0x600F18A")]
			[Address(RVA = "0x68E940", Offset = "0x68D540", VA = "0x18068E940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x0600F18B RID: 61835 RVA: 0x00058FB0 File Offset: 0x000571B0
		[Token(Token = "0x17001F6A")]
		public bool needDisplay
		{
			[Token(Token = "0x600F18B")]
			[Address(RVA = "0x68E6E0", Offset = "0x68D2E0", VA = "0x18068E6E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x0600F18C RID: 61836 RVA: 0x00058FC8 File Offset: 0x000571C8
		[Token(Token = "0x17001F6B")]
		public int currentCnt
		{
			[Token(Token = "0x600F18C")]
			[Address(RVA = "0x68E400", Offset = "0x68D000", VA = "0x18068E400")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x0600F18D RID: 61837 RVA: 0x00058FE0 File Offset: 0x000571E0
		[Token(Token = "0x17001F6C")]
		public int maxCnt
		{
			[Token(Token = "0x600F18D")]
			[Address(RVA = "0x68E570", Offset = "0x68D170", VA = "0x18068E570")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600F18E RID: 61838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F18E")]
		[Address(RVA = "0x68E030", Offset = "0x68CC30", VA = "0x18068E030", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F18F RID: 61839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F18F")]
		[Address(RVA = "0x68DE30", Offset = "0x68CA30", VA = "0x18068DE30", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F190 RID: 61840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F190")]
		[Address(RVA = "0x68DF30", Offset = "0x68CB30", VA = "0x18068DF30", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F191 RID: 61841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F191")]
		[Address(RVA = "0x68E130", Offset = "0x68CD30", VA = "0x18068E130")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F192 RID: 61842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F192")]
		[Address(RVA = "0x68E1E0", Offset = "0x68CDE0", VA = "0x18068E1E0")]
		public HunterBulletBarPluginTalent()
		{
		}

		// Token: 0x0600F193 RID: 61843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F193")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F194 RID: 61844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F194")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010B42 RID: 68418
		[Token(Token = "0x4010B42")]
		[FieldOffset(Offset = "0x68")]
		private Character m_characterOwner;

		// Token: 0x04010B43 RID: 68419
		[Token(Token = "0x4010B43")]
		[FieldOffset(Offset = "0x70")]
		private Ability m_traitAbility;

		// Token: 0x04010B44 RID: 68420
		[Token(Token = "0x4010B44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010B45 RID: 68421
		[Token(Token = "0x4010B45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_characterOwner;

		// Token: 0x04010B46 RID: 68422
		[Token(Token = "0x4010B46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_traitAbiliy;

		// Token: 0x04010B47 RID: 68423
		[Token(Token = "0x4010B47")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_needDisplay;

		// Token: 0x04010B48 RID: 68424
		[Token(Token = "0x4010B48")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_currentCnt;

		// Token: 0x04010B49 RID: 68425
		[Token(Token = "0x4010B49")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_maxCnt;

		// Token: 0x04010B4A RID: 68426
		[Token(Token = "0x4010B4A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B4B RID: 68427
		[Token(Token = "0x4010B4B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010B4C RID: 68428
		[Token(Token = "0x4010B4C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010B4D RID: 68429
		[Token(Token = "0x4010B4D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010B4E RID: 68430
		[Token(Token = "0x4010B4E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
