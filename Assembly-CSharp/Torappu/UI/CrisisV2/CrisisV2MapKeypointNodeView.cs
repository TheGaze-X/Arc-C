using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059AD RID: 22957
	[Token(Token = "0x20059AD")]
	public class CrisisV2MapKeypointNodeView : CrisisV2MapNodeViewBase
	{
		// Token: 0x06021772 RID: 137074 RVA: 0x000BA5D0 File Offset: 0x000B87D0
		[Token(Token = "0x6021772")]
		[Address(RVA = "0x1BC7F30", Offset = "0x1BC6B30", VA = "0x181BC7F30", Slot = "4")]
		public override CrisisV2NodeSlotType GetSlotType()
		{
			return CrisisV2NodeSlotType.NONE;
		}

		// Token: 0x06021773 RID: 137075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021773")]
		[Address(RVA = "0x1BC7F90", Offset = "0x1BC6B90", VA = "0x181BC7F90", Slot = "6")]
		protected override void PlayHighlightAnimIfNeed(bool isNodeHighlight)
		{
		}

		// Token: 0x06021774 RID: 137076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021774")]
		[Address(RVA = "0x1BC8010", Offset = "0x1BC6C10", VA = "0x181BC8010", Slot = "5")]
		protected override void Render()
		{
		}

		// Token: 0x06021775 RID: 137077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021775")]
		[Address(RVA = "0x1BC81F0", Offset = "0x1BC6DF0", VA = "0x181BC81F0")]
		public CrisisV2MapKeypointNodeView()
		{
		}

		// Token: 0x06021776 RID: 137078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021776")]
		[Address(RVA = "0x1BC81E0", Offset = "0x1BC6DE0", VA = "0x181BC81E0")]
		private void <>xLuaBaseProxy_PlayHighlightAnimIfNeed(bool P0)
		{
		}

		// Token: 0x0402DB2B RID: 187179
		[Token(Token = "0x402DB2B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _unreachGo;

		// Token: 0x0402DB2C RID: 187180
		[Token(Token = "0x402DB2C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _reachableGo;

		// Token: 0x0402DB2D RID: 187181
		[Token(Token = "0x402DB2D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _availGo;

		// Token: 0x0402DB2E RID: 187182
		[Token(Token = "0x402DB2E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _completedGo;

		// Token: 0x0402DB2F RID: 187183
		[Token(Token = "0x402DB2F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _animHighlightGo;

		// Token: 0x0402DB30 RID: 187184
		[Token(Token = "0x402DB30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSlotType;

		// Token: 0x0402DB31 RID: 187185
		[Token(Token = "0x402DB31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayHighlightAnimIfNeed;

		// Token: 0x0402DB32 RID: 187186
		[Token(Token = "0x402DB32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DB33 RID: 187187
		[Token(Token = "0x402DB33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
