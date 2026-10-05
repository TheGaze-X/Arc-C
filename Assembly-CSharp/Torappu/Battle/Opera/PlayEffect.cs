using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026A8 RID: 9896
	[Token(Token = "0x20026A8")]
	[OperaInfo(Category = "Effect")]
	public class PlayEffect : OperaNode, IOperaEffectSource
	{
		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x0601028A RID: 66186 RVA: 0x000628C8 File Offset: 0x00060AC8
		[Token(Token = "0x17002331")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x601028A")]
			[Address(RVA = "0x7EE280", Offset = "0x7ECE80", VA = "0x1807EE280", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x0601028B RID: 66187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601028B")]
		[Address(RVA = "0x7EDD60", Offset = "0x7EC960", VA = "0x1807EDD60", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x0601028C RID: 66188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601028C")]
		[Address(RVA = "0x7EE150", Offset = "0x7ECD50", VA = "0x1807EE150", Slot = "7")]
		public void GatherEffects(List<string> results)
		{
		}

		// Token: 0x0601028D RID: 66189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601028D")]
		[Address(RVA = "0x7EE1E0", Offset = "0x7ECDE0", VA = "0x1807EE1E0")]
		public PlayEffect()
		{
		}

		// Token: 0x04012014 RID: 73748
		[Token(Token = "0x4012014")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _effectKey;

		// Token: 0x04012015 RID: 73749
		[Token(Token = "0x4012015")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _holdByTile;

		// Token: 0x04012016 RID: 73750
		[Token(Token = "0x4012016")]
		[FieldOffset(Offset = "0x21")]
		private CameraController.PostprocessMask _postProcessType;

		// Token: 0x04012017 RID: 73751
		[Token(Token = "0x4012017")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012018 RID: 73752
		[Token(Token = "0x4012018")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012019 RID: 73753
		[Token(Token = "0x4012019")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401201A RID: 73754
		[Token(Token = "0x401201A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
