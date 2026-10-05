using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026B0 RID: 9904
	[Token(Token = "0x20026B0")]
	[OperaInfo(Category = "Buff")]
	public class CreateBuffInArea : OperaNode, IBuffSource
	{
		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x060102A5 RID: 66213 RVA: 0x00062988 File Offset: 0x00060B88
		[Token(Token = "0x17002338")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x60102A5")]
			[Address(RVA = "0x7E6930", Offset = "0x7E5530", VA = "0x1807E6930", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x060102A6 RID: 66214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102A6")]
		[Address(RVA = "0x7E6330", Offset = "0x7E4F30", VA = "0x1807E6330", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x060102A7 RID: 66215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102A7")]
		[Address(RVA = "0x7E6640", Offset = "0x7E5240", VA = "0x1807E6640", Slot = "7")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x060102A8 RID: 66216 RVA: 0x000629A0 File Offset: 0x00060BA0
		[Token(Token = "0x60102A8")]
		[Address(RVA = "0x7E66D0", Offset = "0x7E52D0", VA = "0x1807E66D0")]
		private bool _CheckInArea(GridPosition grid)
		{
			return default(bool);
		}

		// Token: 0x060102A9 RID: 66217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102A9")]
		[Address(RVA = "0x7E6840", Offset = "0x7E5440", VA = "0x1807E6840")]
		public CreateBuffInArea()
		{
		}

		// Token: 0x04012040 RID: 73792
		[Token(Token = "0x4012040")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GridPosition _min;

		// Token: 0x04012041 RID: 73793
		[Token(Token = "0x4012041")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridPosition _max;

		// Token: 0x04012042 RID: 73794
		[Token(Token = "0x4012042")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuffData _buff;

		// Token: 0x04012043 RID: 73795
		[Token(Token = "0x4012043")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012044 RID: 73796
		[Token(Token = "0x4012044")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012045 RID: 73797
		[Token(Token = "0x4012045")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04012046 RID: 73798
		[Token(Token = "0x4012046")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckInArea;

		// Token: 0x04012047 RID: 73799
		[Token(Token = "0x4012047")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
