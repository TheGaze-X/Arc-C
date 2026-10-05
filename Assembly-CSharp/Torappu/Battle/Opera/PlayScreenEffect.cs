using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026A9 RID: 9897
	[Token(Token = "0x20026A9")]
	[OperaInfo(Category = "Effect")]
	public class PlayScreenEffect : OperaNode, IOperaEffectSource
	{
		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x0601028E RID: 66190 RVA: 0x000628E0 File Offset: 0x00060AE0
		[Token(Token = "0x17002332")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x601028E")]
			[Address(RVA = "0x7EEBB0", Offset = "0x7ED7B0", VA = "0x1807EEBB0", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x0601028F RID: 66191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601028F")]
		[Address(RVA = "0x7EE790", Offset = "0x7ED390", VA = "0x1807EE790", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x06010290 RID: 66192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010290")]
		[Address(RVA = "0x7EEA50", Offset = "0x7ED650", VA = "0x1807EEA50", Slot = "7")]
		public void GatherEffects(List<string> results)
		{
		}

		// Token: 0x06010291 RID: 66193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010291")]
		[Address(RVA = "0x7EEAE0", Offset = "0x7ED6E0", VA = "0x1807EEAE0")]
		public PlayScreenEffect()
		{
		}

		// Token: 0x0401201B RID: 73755
		[Token(Token = "0x401201B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _effectKey;

		// Token: 0x0401201C RID: 73756
		[Token(Token = "0x401201C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _holdEffect;

		// Token: 0x0401201D RID: 73757
		[Token(Token = "0x401201D")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _needDelaySetBoolForEffect;

		// Token: 0x0401201E RID: 73758
		[Token(Token = "0x401201E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _time;

		// Token: 0x0401201F RID: 73759
		[Token(Token = "0x401201F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _key;

		// Token: 0x04012020 RID: 73760
		[Token(Token = "0x4012020")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _flag;

		// Token: 0x04012021 RID: 73761
		[Token(Token = "0x4012021")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012022 RID: 73762
		[Token(Token = "0x4012022")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012023 RID: 73763
		[Token(Token = "0x4012023")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04012024 RID: 73764
		[Token(Token = "0x4012024")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
