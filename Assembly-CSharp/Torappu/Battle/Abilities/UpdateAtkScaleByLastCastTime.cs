using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C2E RID: 11310
	[Token(Token = "0x2002C2E")]
	public class UpdateAtkScaleByLastCastTime : AbilityStandard.Behaviour
	{
		// Token: 0x06013198 RID: 78232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013198")]
		[Address(RVA = "0xB28900", Offset = "0xB27500", VA = "0x180B28900", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013199 RID: 78233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013199")]
		[Address(RVA = "0xB28570", Offset = "0xB27170", VA = "0x180B28570", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x0601319A RID: 78234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601319A")]
		[Address(RVA = "0xB28840", Offset = "0xB27440", VA = "0x180B28840", Slot = "13")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601319B RID: 78235 RVA: 0x00074958 File Offset: 0x00072B58
		[Token(Token = "0x601319B")]
		[Address(RVA = "0xB28AF0", Offset = "0xB276F0", VA = "0x180B28AF0")]
		private FP _GetAtkScale(FP deltaTime)
		{
			return default(FP);
		}

		// Token: 0x0601319C RID: 78236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601319C")]
		[Address(RVA = "0xB28BF0", Offset = "0xB277F0", VA = "0x180B28BF0")]
		public UpdateAtkScaleByLastCastTime()
		{
		}

		// Token: 0x0601319D RID: 78237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601319D")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0601319E RID: 78238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601319E")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601319F RID: 78239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601319F")]
		[Address(RVA = "0xADA600", Offset = "0xAD9200", VA = "0x180ADA600")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015915 RID: 88341
		[Token(Token = "0x4015915")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _createNewNodeEachTime;

		// Token: 0x04015916 RID: 88342
		[Token(Token = "0x4015916")]
		[FieldOffset(Offset = "0x28")]
		private FP m_minDeltaTime;

		// Token: 0x04015917 RID: 88343
		[Token(Token = "0x4015917")]
		[FieldOffset(Offset = "0x30")]
		private FP m_maxDeltaTime;

		// Token: 0x04015918 RID: 88344
		[Token(Token = "0x4015918")]
		[FieldOffset(Offset = "0x38")]
		private FP m_minAtkScale;

		// Token: 0x04015919 RID: 88345
		[Token(Token = "0x4015919")]
		[FieldOffset(Offset = "0x40")]
		private FP m_maxAtkScale;

		// Token: 0x0401591A RID: 88346
		[Token(Token = "0x401591A")]
		[FieldOffset(Offset = "0x48")]
		private FP m_accumCastTime;

		// Token: 0x0401591B RID: 88347
		[Token(Token = "0x401591B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401591C RID: 88348
		[Token(Token = "0x401591C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0401591D RID: 88349
		[Token(Token = "0x401591D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401591E RID: 88350
		[Token(Token = "0x401591E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetAtkScale;

		// Token: 0x0401591F RID: 88351
		[Token(Token = "0x401591F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
