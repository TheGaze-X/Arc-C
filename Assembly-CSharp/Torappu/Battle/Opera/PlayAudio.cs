using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026A7 RID: 9895
	[Token(Token = "0x20026A7")]
	[OperaInfo(Category = "Audio")]
	public class PlayAudio : OperaNode, IAudioSource
	{
		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x06010286 RID: 66182 RVA: 0x000628B0 File Offset: 0x00060AB0
		[Token(Token = "0x17002330")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x6010286")]
			[Address(RVA = "0x7EDB70", Offset = "0x7EC770", VA = "0x1807EDB70", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x06010287 RID: 66183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010287")]
		[Address(RVA = "0x7ED810", Offset = "0x7EC410", VA = "0x1807ED810", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x06010288 RID: 66184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010288")]
		[Address(RVA = "0x7EDA40", Offset = "0x7EC640", VA = "0x1807EDA40", Slot = "7")]
		public void GatherAudio(List<string> results)
		{
		}

		// Token: 0x06010289 RID: 66185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010289")]
		[Address(RVA = "0x7EDAD0", Offset = "0x7EC6D0", VA = "0x1807EDAD0")]
		public PlayAudio()
		{
		}

		// Token: 0x0401200F RID: 73743
		[Token(Token = "0x401200F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _signal;

		// Token: 0x04012010 RID: 73744
		[Token(Token = "0x4012010")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012011 RID: 73745
		[Token(Token = "0x4012011")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012012 RID: 73746
		[Token(Token = "0x4012012")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherAudio;

		// Token: 0x04012013 RID: 73747
		[Token(Token = "0x4012013")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
