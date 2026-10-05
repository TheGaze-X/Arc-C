using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026AF RID: 9903
	[Token(Token = "0x20026AF")]
	[OperaInfo(Category = "Tile")]
	public class RewriteTileOptionsInArea : OperaNode
	{
		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x060102A1 RID: 66209 RVA: 0x00062958 File Offset: 0x00060B58
		[Token(Token = "0x17002337")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x60102A1")]
			[Address(RVA = "0x7EF180", Offset = "0x7EDD80", VA = "0x1807EF180", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x060102A2 RID: 66210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102A2")]
		[Address(RVA = "0x7EED80", Offset = "0x7ED980", VA = "0x1807EED80", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x060102A3 RID: 66211 RVA: 0x00062970 File Offset: 0x00060B70
		[Token(Token = "0x60102A3")]
		[Address(RVA = "0x7EEF70", Offset = "0x7EDB70", VA = "0x1807EEF70")]
		private bool _CheckInArea(GridPosition grid)
		{
			return default(bool);
		}

		// Token: 0x060102A4 RID: 66212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102A4")]
		[Address(RVA = "0x7EF0E0", Offset = "0x7EDCE0", VA = "0x1807EF0E0")]
		public RewriteTileOptionsInArea()
		{
		}

		// Token: 0x04012038 RID: 73784
		[Token(Token = "0x4012038")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GridPosition _min;

		// Token: 0x04012039 RID: 73785
		[Token(Token = "0x4012039")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridPosition _max;

		// Token: 0x0401203A RID: 73786
		[Token(Token = "0x401203A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildableType _buildableType;

		// Token: 0x0401203B RID: 73787
		[Token(Token = "0x401203B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _restoreOptions;

		// Token: 0x0401203C RID: 73788
		[Token(Token = "0x401203C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x0401203D RID: 73789
		[Token(Token = "0x401203D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x0401203E RID: 73790
		[Token(Token = "0x401203E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckInArea;

		// Token: 0x0401203F RID: 73791
		[Token(Token = "0x401203F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
