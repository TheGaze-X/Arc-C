using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B91 RID: 11153
	[Token(Token = "0x2002B91")]
	public class CammouTrait : PassiveBuffAbility
	{
		// Token: 0x06012C5C RID: 76892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C5C")]
		[Address(RVA = "0xAB47A0", Offset = "0xAB33A0", VA = "0x180AB47A0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012C5D RID: 76893 RVA: 0x00072F78 File Offset: 0x00071178
		[Token(Token = "0x6012C5D")]
		[Address(RVA = "0xAB4A60", Offset = "0xAB3660", VA = "0x180AB4A60")]
		public float SetFunnelAtkScale(Entity target)
		{
			return 0f;
		}

		// Token: 0x06012C5E RID: 76894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C5E")]
		[Address(RVA = "0xAB49C0", Offset = "0xAB35C0", VA = "0x180AB49C0", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012C5F RID: 76895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C5F")]
		[Address(RVA = "0xAB4C40", Offset = "0xAB3840", VA = "0x180AB4C40")]
		public CammouTrait()
		{
		}

		// Token: 0x06012C60 RID: 76896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C60")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012C61 RID: 76897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C61")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x04015345 RID: 86853
		[Token(Token = "0x4015345")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float _initAtkScale;

		// Token: 0x04015346 RID: 86854
		[Token(Token = "0x4015346")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private float _deltaAtkScale;

		// Token: 0x04015347 RID: 86855
		[Token(Token = "0x4015347")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _maxAtkScale;

		// Token: 0x04015348 RID: 86856
		[Token(Token = "0x4015348")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private int _maxStack;

		// Token: 0x04015349 RID: 86857
		[Token(Token = "0x4015349")]
		[FieldOffset(Offset = "0x128")]
		private float m_curAtkScale;

		// Token: 0x0401534A RID: 86858
		[Token(Token = "0x401534A")]
		[FieldOffset(Offset = "0x12C")]
		private float m_initAtkScale;

		// Token: 0x0401534B RID: 86859
		[Token(Token = "0x401534B")]
		[FieldOffset(Offset = "0x130")]
		private float m_deltaAtkScale;

		// Token: 0x0401534C RID: 86860
		[Token(Token = "0x401534C")]
		[FieldOffset(Offset = "0x134")]
		private float m_maxAtkScale;

		// Token: 0x0401534D RID: 86861
		[Token(Token = "0x401534D")]
		[FieldOffset(Offset = "0x138")]
		private float m_maxStack;

		// Token: 0x0401534E RID: 86862
		[Token(Token = "0x401534E")]
		[FieldOffset(Offset = "0x13C")]
		private int m_curStack;

		// Token: 0x0401534F RID: 86863
		[Token(Token = "0x401534F")]
		[FieldOffset(Offset = "0x140")]
		private ObjectPtr<Entity> m_lastTarget;

		// Token: 0x04015350 RID: 86864
		[Token(Token = "0x4015350")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015351 RID: 86865
		[Token(Token = "0x4015351")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetFunnelAtkScale;

		// Token: 0x04015352 RID: 86866
		[Token(Token = "0x4015352")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04015353 RID: 86867
		[Token(Token = "0x4015353")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
