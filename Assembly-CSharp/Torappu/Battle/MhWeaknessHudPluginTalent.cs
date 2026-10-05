using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024B5 RID: 9397
	[Token(Token = "0x20024B5")]
	public class MhWeaknessHudPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x0600F1CA RID: 61898 RVA: 0x00059190 File Offset: 0x00057390
		// (set) Token: 0x0600F1CB RID: 61899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F7A")]
		public bool takenDamage
		{
			[Token(Token = "0x600F1CA")]
			[Address(RVA = "0x693110", Offset = "0x691D10", VA = "0x180693110")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F1CB")]
			[Address(RVA = "0x693290", Offset = "0x691E90", VA = "0x180693290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x0600F1CC RID: 61900 RVA: 0x000591A8 File Offset: 0x000573A8
		[Token(Token = "0x17001F7B")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F1CC")]
			[Address(RVA = "0x693170", Offset = "0x691D70", VA = "0x180693170", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x0600F1CD RID: 61901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F7C")]
		public int[] validModeIndices
		{
			[Token(Token = "0x600F1CD")]
			[Address(RVA = "0x6931D0", Offset = "0x691DD0", VA = "0x1806931D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x0600F1CE RID: 61902 RVA: 0x000591C0 File Offset: 0x000573C0
		[Token(Token = "0x17001F7D")]
		public int weaknessSign
		{
			[Token(Token = "0x600F1CE")]
			[Address(RVA = "0x693230", Offset = "0x691E30", VA = "0x180693230")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600F1CF RID: 61903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F1CF")]
		[Address(RVA = "0x692610", Offset = "0x691210", VA = "0x180692610", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F1D0 RID: 61904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1D0")]
		[Address(RVA = "0x692290", Offset = "0x690E90", VA = "0x180692290", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F1D1 RID: 61905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1D1")]
		[Address(RVA = "0x692470", Offset = "0x691070", VA = "0x180692470", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F1D2 RID: 61906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1D2")]
		[Address(RVA = "0x692FB0", Offset = "0x691BB0", VA = "0x180692FB0")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F1D3 RID: 61907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1D3")]
		[Address(RVA = "0x6929A0", Offset = "0x6915A0", VA = "0x1806929A0")]
		private void _OnApplyedModifier(object arg)
		{
		}

		// Token: 0x0600F1D4 RID: 61908 RVA: 0x000591D8 File Offset: 0x000573D8
		[Token(Token = "0x600F1D4")]
		[Address(RVA = "0x692710", Offset = "0x691310", VA = "0x180692710")]
		private bool _CheckDirection(Vector2 mapDir)
		{
			return default(bool);
		}

		// Token: 0x0600F1D5 RID: 61909 RVA: 0x000591F0 File Offset: 0x000573F0
		[Token(Token = "0x600F1D5")]
		[Address(RVA = "0x692850", Offset = "0x691450", VA = "0x180692850")]
		private bool _CheckOwnerValidMode()
		{
			return default(bool);
		}

		// Token: 0x0600F1D6 RID: 61910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1D6")]
		[Address(RVA = "0x693060", Offset = "0x691C60", VA = "0x180693060")]
		public MhWeaknessHudPluginTalent()
		{
		}

		// Token: 0x0600F1D7 RID: 61911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1D7")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F1D8 RID: 61912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1D8")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010B93 RID: 68499
		[Token(Token = "0x4010B93")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("UI Plugin")]
		private int[] _validModeIndices;

		// Token: 0x04010B94 RID: 68500
		[Token(Token = "0x4010B94")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("UI Plugin")]
		private MhWeaknessHudPluginTalent.FacePosition _weakness;

		// Token: 0x04010B96 RID: 68502
		[Token(Token = "0x4010B96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_takenDamage;

		// Token: 0x04010B97 RID: 68503
		[Token(Token = "0x4010B97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_takenDamage;

		// Token: 0x04010B98 RID: 68504
		[Token(Token = "0x4010B98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010B99 RID: 68505
		[Token(Token = "0x4010B99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_validModeIndices;

		// Token: 0x04010B9A RID: 68506
		[Token(Token = "0x4010B9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_weaknessSign;

		// Token: 0x04010B9B RID: 68507
		[Token(Token = "0x4010B9B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B9C RID: 68508
		[Token(Token = "0x4010B9C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010B9D RID: 68509
		[Token(Token = "0x4010B9D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010B9E RID: 68510
		[Token(Token = "0x4010B9E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010B9F RID: 68511
		[Token(Token = "0x4010B9F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnApplyedModifier;

		// Token: 0x04010BA0 RID: 68512
		[Token(Token = "0x4010BA0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckDirection;

		// Token: 0x04010BA1 RID: 68513
		[Token(Token = "0x4010BA1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckOwnerValidMode;

		// Token: 0x04010BA2 RID: 68514
		[Token(Token = "0x4010BA2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020024B6 RID: 9398
		[Token(Token = "0x20024B6")]
		private enum FacePosition
		{
			// Token: 0x04010BA4 RID: 68516
			[Token(Token = "0x4010BA4")]
			BACK = -1,
			// Token: 0x04010BA5 RID: 68517
			[Token(Token = "0x4010BA5")]
			FRONT = 1
		}
	}
}
