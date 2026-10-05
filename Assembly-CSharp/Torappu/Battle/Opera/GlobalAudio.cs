using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026A6 RID: 9894
	[Token(Token = "0x20026A6")]
	[OperaInfo(Category = "Audio")]
	public class GlobalAudio : OperaNode, IAudioSource
	{
		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x06010282 RID: 66178 RVA: 0x00062898 File Offset: 0x00060A98
		[Token(Token = "0x1700232F")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x6010282")]
			[Address(RVA = "0x7EC1C0", Offset = "0x7EADC0", VA = "0x1807EC1C0", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x06010283 RID: 66179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010283")]
		[Address(RVA = "0x7EBFC0", Offset = "0x7EABC0", VA = "0x1807EBFC0", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x06010284 RID: 66180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010284")]
		[Address(RVA = "0x7EC090", Offset = "0x7EAC90", VA = "0x1807EC090", Slot = "7")]
		public void GatherAudio(List<string> results)
		{
		}

		// Token: 0x06010285 RID: 66181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010285")]
		[Address(RVA = "0x7EC120", Offset = "0x7EAD20", VA = "0x1807EC120")]
		public GlobalAudio()
		{
		}

		// Token: 0x04012009 RID: 73737
		[Token(Token = "0x4012009")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _signal;

		// Token: 0x0401200A RID: 73738
		[Token(Token = "0x401200A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _position;

		// Token: 0x0401200B RID: 73739
		[Token(Token = "0x401200B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x0401200C RID: 73740
		[Token(Token = "0x401200C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x0401200D RID: 73741
		[Token(Token = "0x401200D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherAudio;

		// Token: 0x0401200E RID: 73742
		[Token(Token = "0x401200E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
