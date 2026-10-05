using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C18 RID: 11288
	[Token(Token = "0x2002C18")]
	public class ExCludeCastTargetsWhenSucceeded : AbilityStandard.Behaviour
	{
		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x060130FD RID: 78077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170029F5")]
		private AdvancedSelectorWithExCludeWhenSucceeded bindSelector
		{
			[Token(Token = "0x60130FD")]
			[Address(RVA = "0xB1ADC0", Offset = "0xB199C0", VA = "0x180B1ADC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060130FE RID: 78078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130FE")]
		[Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
		private void OnEnable()
		{
		}

		// Token: 0x060130FF RID: 78079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130FF")]
		[Address(RVA = "0xB1ABD0", Offset = "0xB197D0", VA = "0x180B1ABD0", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x06013100 RID: 78080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013100")]
		[Address(RVA = "0xB1AAF0", Offset = "0xB196F0", VA = "0x180B1AAF0", Slot = "11")]
		public override void OnCastOnTarget(Entity target)
		{
		}

		// Token: 0x06013101 RID: 78081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013101")]
		[Address(RVA = "0xB1AD60", Offset = "0xB19960", VA = "0x180B1AD60")]
		public ExCludeCastTargetsWhenSucceeded()
		{
		}

		// Token: 0x06013102 RID: 78082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013102")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06013103 RID: 78083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013103")]
		[Address(RVA = "0xAC48F0", Offset = "0xAC34F0", VA = "0x180AC48F0")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0)
		{
		}

		// Token: 0x04015866 RID: 88166
		[Token(Token = "0x4015866")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _clearSelectorCacheWhenCastOnTarget;

		// Token: 0x04015867 RID: 88167
		[Token(Token = "0x4015867")]
		[FieldOffset(Offset = "0x28")]
		private AdvancedSelectorWithExCludeWhenSucceeded m_selector;

		// Token: 0x04015868 RID: 88168
		[Token(Token = "0x4015868")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindSelector;

		// Token: 0x04015869 RID: 88169
		[Token(Token = "0x4015869")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401586A RID: 88170
		[Token(Token = "0x401586A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0401586B RID: 88171
		[Token(Token = "0x401586B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x0401586C RID: 88172
		[Token(Token = "0x401586C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
