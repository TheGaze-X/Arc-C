using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026AC RID: 9900
	[Token(Token = "0x20026AC")]
	[OperaInfo(Category = "Effect")]
	public class PlayMapEffect : OperaNode, IOperaEffectSource
	{
		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x06010297 RID: 66199 RVA: 0x00062910 File Offset: 0x00060B10
		[Token(Token = "0x17002334")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x6010297")]
			[Address(RVA = "0x7EE730", Offset = "0x7ED330", VA = "0x1807EE730", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x06010298 RID: 66200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010298")]
		[Address(RVA = "0x7EE2E0", Offset = "0x7ECEE0", VA = "0x1807EE2E0", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x06010299 RID: 66201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010299")]
		[Address(RVA = "0x7EE600", Offset = "0x7ED200", VA = "0x1807EE600", Slot = "7")]
		public void GatherEffects(List<string> results)
		{
		}

		// Token: 0x0601029A RID: 66202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601029A")]
		[Address(RVA = "0x7EE690", Offset = "0x7ED290", VA = "0x1807EE690")]
		public PlayMapEffect()
		{
		}

		// Token: 0x0401202B RID: 73771
		[Token(Token = "0x401202B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _effectKey;

		// Token: 0x0401202C RID: 73772
		[Token(Token = "0x401202C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _holdByTile;

		// Token: 0x0401202D RID: 73773
		[Token(Token = "0x401202D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x0401202E RID: 73774
		[Token(Token = "0x401202E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x0401202F RID: 73775
		[Token(Token = "0x401202F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04012030 RID: 73776
		[Token(Token = "0x4012030")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
