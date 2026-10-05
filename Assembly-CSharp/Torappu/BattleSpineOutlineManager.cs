using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000542 RID: 1346
	[Token(Token = "0x2000542")]
	public class BattleSpineOutlineManager : IHotfixable
	{
		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06005A3A RID: 23098 RVA: 0x0002E8A8 File Offset: 0x0002CAA8
		[Token(Token = "0x17000C8C")]
		public bool isEnable
		{
			[Token(Token = "0x6005A3A")]
			[Address(RVA = "0x1AEA5A0", Offset = "0x1AE91A0", VA = "0x181AEA5A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005A3B RID: 23099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3B")]
		[Address(RVA = "0x1AE9C80", Offset = "0x1AE8880", VA = "0x181AE9C80")]
		public void Init()
		{
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3C")]
		[Address(RVA = "0x1AE9DD0", Offset = "0x1AE89D0", VA = "0x181AE9DD0")]
		public void ResetMeshByAnimator(UnitAnimator animator, bool isEnabled = true)
		{
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3D")]
		[Address(RVA = "0x1AE9B90", Offset = "0x1AE8790", VA = "0x181AE9B90")]
		public void DrawOutline(UnitAnimator animator)
		{
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0x1AE9A70", Offset = "0x1AE8670", VA = "0x181AE9A70")]
		public void DisableOutlineByAnimator(UnitAnimator animator)
		{
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x0002E8C0 File Offset: 0x0002CAC0
		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0x1AEA260", Offset = "0x1AE8E60", VA = "0x181AEA260")]
		private BattleOutlineConfig _GetOutlineConfig()
		{
			return default(BattleOutlineConfig);
		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A40")]
		[Address(RVA = "0x1AEA4D0", Offset = "0x1AE90D0", VA = "0x181AEA4D0")]
		public BattleSpineOutlineManager()
		{
		}

		// Token: 0x0400200D RID: 8205
		[Token(Token = "0x400200D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string OUTLINE_SHADER_NAME;

		// Token: 0x0400200E RID: 8206
		[Token(Token = "0x400200E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly float OFFSET_Z;

		// Token: 0x0400200F RID: 8207
		[Token(Token = "0x400200F")]
		[FieldOffset(Offset = "0xC")]
		public static readonly BattleOutlineConfig DEFAULT_CONFIG;

		// Token: 0x04002010 RID: 8208
		[Token(Token = "0x4002010")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<UnitAnimator, SpineOutlineOption> m_options;

		// Token: 0x04002011 RID: 8209
		[Token(Token = "0x4002011")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isEnabled;

		// Token: 0x04002012 RID: 8210
		[Token(Token = "0x4002012")]
		[FieldOffset(Offset = "0x20")]
		private Shader m_outlineShader;

		// Token: 0x04002013 RID: 8211
		[Token(Token = "0x4002013")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isEnable;

		// Token: 0x04002014 RID: 8212
		[Token(Token = "0x4002014")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04002015 RID: 8213
		[Token(Token = "0x4002015")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetMeshByAnimator;

		// Token: 0x04002016 RID: 8214
		[Token(Token = "0x4002016")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DrawOutline;

		// Token: 0x04002017 RID: 8215
		[Token(Token = "0x4002017")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DisableOutlineByAnimator;

		// Token: 0x04002018 RID: 8216
		[Token(Token = "0x4002018")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetOutlineConfig;

		// Token: 0x04002019 RID: 8217
		[Token(Token = "0x4002019")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
