using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200321C RID: 12828
	[Token(Token = "0x200321C")]
	public class SetEffectAnimatorParameter : Effect.Behaviour
	{
		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x060145A8 RID: 83368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003036")]
		private Animator animator
		{
			[Token(Token = "0x60145A8")]
			[Address(RVA = "0xCAE1A0", Offset = "0xCACDA0", VA = "0x180CAE1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060145A9 RID: 83369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145A9")]
		[Address(RVA = "0xCADD70", Offset = "0xCAC970", VA = "0x180CADD70", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145AA RID: 83370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145AA")]
		[Address(RVA = "0xCADC50", Offset = "0xCAC850", VA = "0x180CADC50", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060145AB RID: 83371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145AB")]
		[Address(RVA = "0xCADEA0", Offset = "0xCACAA0", VA = "0x180CADEA0")]
		private void _SetBool(SetEffectAnimatorParameter.ParamInfo paramInfo)
		{
		}

		// Token: 0x060145AC RID: 83372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145AC")]
		[Address(RVA = "0xCADF40", Offset = "0xCACB40", VA = "0x180CADF40")]
		private void _SetFloat(SetEffectAnimatorParameter.ParamInfo paramInfo)
		{
		}

		// Token: 0x060145AD RID: 83373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145AD")]
		[Address(RVA = "0xCADFE0", Offset = "0xCACBE0", VA = "0x180CADFE0")]
		private void _SetInt(SetEffectAnimatorParameter.ParamInfo paramInfo)
		{
		}

		// Token: 0x060145AE RID: 83374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145AE")]
		[Address(RVA = "0xCAE080", Offset = "0xCACC80", VA = "0x180CAE080")]
		private void _SetTrigger(SetEffectAnimatorParameter.ParamInfo paramInfo)
		{
		}

		// Token: 0x060145AF RID: 83375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145AF")]
		[Address(RVA = "0xCAE110", Offset = "0xCACD10", VA = "0x180CAE110")]
		public SetEffectAnimatorParameter()
		{
		}

		// Token: 0x060145B0 RID: 83376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145B0")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060145B1 RID: 83377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145B1")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018016 RID: 98326
		[Token(Token = "0x4018016")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SetEffectAnimatorParameter.ParamInfo[] _paramInfos;

		// Token: 0x04018017 RID: 98327
		[Token(Token = "0x4018017")]
		[FieldOffset(Offset = "0x28")]
		private Animator m_animator;

		// Token: 0x04018018 RID: 98328
		[Token(Token = "0x4018018")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animator;

		// Token: 0x04018019 RID: 98329
		[Token(Token = "0x4018019")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x0401801A RID: 98330
		[Token(Token = "0x401801A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0401801B RID: 98331
		[Token(Token = "0x401801B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetBool;

		// Token: 0x0401801C RID: 98332
		[Token(Token = "0x401801C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetFloat;

		// Token: 0x0401801D RID: 98333
		[Token(Token = "0x401801D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetInt;

		// Token: 0x0401801E RID: 98334
		[Token(Token = "0x401801E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetTrigger;

		// Token: 0x0401801F RID: 98335
		[Token(Token = "0x401801F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200321D RID: 12829
		[Token(Token = "0x200321D")]
		public enum ParamType
		{
			// Token: 0x04018021 RID: 98337
			[Token(Token = "0x4018021")]
			Trigger,
			// Token: 0x04018022 RID: 98338
			[Token(Token = "0x4018022")]
			Bool,
			// Token: 0x04018023 RID: 98339
			[Token(Token = "0x4018023")]
			Float,
			// Token: 0x04018024 RID: 98340
			[Token(Token = "0x4018024")]
			Int,
			// Token: 0x04018025 RID: 98341
			[Token(Token = "0x4018025")]
			Enum
		}

		// Token: 0x0200321E RID: 12830
		[Token(Token = "0x200321E")]
		public enum TriggerTime
		{
			// Token: 0x04018027 RID: 98343
			[Token(Token = "0x4018027")]
			ON_PLAY,
			// Token: 0x04018028 RID: 98344
			[Token(Token = "0x4018028")]
			ON_FINISH,
			// Token: 0x04018029 RID: 98345
			[Token(Token = "0x4018029")]
			Enum
		}

		// Token: 0x0200321F RID: 12831
		[Token(Token = "0x200321F")]
		[Serializable]
		public class ParamInfo
		{
			// Token: 0x060145B2 RID: 83378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60145B2")]
			[Address(RVA = "0xCA7120", Offset = "0xCA5D20", VA = "0x180CA7120")]
			public ParamInfo()
			{
			}

			// Token: 0x0401802A RID: 98346
			[Token(Token = "0x401802A")]
			[FieldOffset(Offset = "0x10")]
			public SetEffectAnimatorParameter.ParamType paramType;

			// Token: 0x0401802B RID: 98347
			[Token(Token = "0x401802B")]
			[FieldOffset(Offset = "0x14")]
			public SetEffectAnimatorParameter.TriggerTime triggerTime;

			// Token: 0x0401802C RID: 98348
			[Token(Token = "0x401802C")]
			[FieldOffset(Offset = "0x18")]
			public int valueToSetBool;

			// Token: 0x0401802D RID: 98349
			[Token(Token = "0x401802D")]
			[FieldOffset(Offset = "0x1C")]
			public float valueToSetFloat;

			// Token: 0x0401802E RID: 98350
			[Token(Token = "0x401802E")]
			[FieldOffset(Offset = "0x20")]
			public int valueToSetInt;

			// Token: 0x0401802F RID: 98351
			[Token(Token = "0x401802F")]
			[FieldOffset(Offset = "0x28")]
			public string paramKey;
		}
	}
}
