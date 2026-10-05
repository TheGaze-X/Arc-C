using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026B6 RID: 9910
	[Token(Token = "0x20026B6")]
	[OperaInfo(Category = "Act46Side")]
	public class Act46SideCreateOrCleanMapEffect : OperaNode
	{
		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x060102B9 RID: 66233 RVA: 0x00062A30 File Offset: 0x00060C30
		[Token(Token = "0x1700233E")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x60102B9")]
			[Address(RVA = "0x7D55C0", Offset = "0x7D41C0", VA = "0x1807D55C0", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x060102BA RID: 66234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102BA")]
		[Address(RVA = "0x7D53B0", Offset = "0x7D3FB0", VA = "0x1807D53B0", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x060102BB RID: 66235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102BB")]
		[Address(RVA = "0x7D5520", Offset = "0x7D4120", VA = "0x1807D5520")]
		public Act46SideCreateOrCleanMapEffect()
		{
		}

		// Token: 0x04012063 RID: 73827
		[Token(Token = "0x4012063")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _effectKey;

		// Token: 0x04012064 RID: 73828
		[Token(Token = "0x4012064")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _pos;

		// Token: 0x04012065 RID: 73829
		[Token(Token = "0x4012065")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _isClean;

		// Token: 0x04012066 RID: 73830
		[Token(Token = "0x4012066")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012067 RID: 73831
		[Token(Token = "0x4012067")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012068 RID: 73832
		[Token(Token = "0x4012068")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
