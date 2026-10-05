using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059C0 RID: 22976
	[Token(Token = "0x20059C0")]
	public class CrisisV2MapRoadPointView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060217D7 RID: 137175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217D7")]
		[Address(RVA = "0x1BD6210", Offset = "0x1BD4E10", VA = "0x181BD6210")]
		public void Init(CrisisV2RoadPosData roadPosData)
		{
		}

		// Token: 0x060217D8 RID: 137176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217D8")]
		[Address(RVA = "0x1BD6390", Offset = "0x1BD4F90", VA = "0x181BD6390")]
		public void Render(CrisisV2MapRoadModel roadModel, CrisisV2MapRoadStatus roadStatus, CrisisV2RoadPointStyle startPointStyle, CrisisV2RoadPointStyle endPointStyle)
		{
		}

		// Token: 0x060217D9 RID: 137177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217D9")]
		[Address(RVA = "0x1BD66A0", Offset = "0x1BD52A0", VA = "0x181BD66A0")]
		private void _UpdatePointStyle(CrisisV2MapRoadPointView.PointStyle pointStyle, CrisisV2RoadPointStyle style, CrisisV2MapRoadStatus roadStatus)
		{
		}

		// Token: 0x060217DA RID: 137178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217DA")]
		[Address(RVA = "0x1BD6460", Offset = "0x1BD5060", VA = "0x181BD6460")]
		private void _SetImgStatus(Image imgPoint, bool isSelect, bool isDisable)
		{
		}

		// Token: 0x060217DB RID: 137179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217DB")]
		[Address(RVA = "0x1BD6550", Offset = "0x1BD5150", VA = "0x181BD6550")]
		private void _SetPosAndSize(CrisisV2RoadPosData roadPosData)
		{
		}

		// Token: 0x060217DC RID: 137180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217DC")]
		[Address(RVA = "0x1BD6820", Offset = "0x1BD5420", VA = "0x181BD6820")]
		public CrisisV2MapRoadPointView()
		{
		}

		// Token: 0x0402DBF2 RID: 187378
		[Token(Token = "0x402DBF2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CrisisV2MapRoadPointView.PointStyle _startPointStyle;

		// Token: 0x0402DBF3 RID: 187379
		[Token(Token = "0x402DBF3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrisisV2MapRoadPointView.PointStyle _endPointStyle;

		// Token: 0x0402DBF4 RID: 187380
		[Token(Token = "0x402DBF4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material _matDisableRoad;

		// Token: 0x0402DBF5 RID: 187381
		[Token(Token = "0x402DBF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402DBF6 RID: 187382
		[Token(Token = "0x402DBF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DBF7 RID: 187383
		[Token(Token = "0x402DBF7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdatePointStyle;

		// Token: 0x0402DBF8 RID: 187384
		[Token(Token = "0x402DBF8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetImgStatus;

		// Token: 0x0402DBF9 RID: 187385
		[Token(Token = "0x402DBF9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetPosAndSize;

		// Token: 0x0402DBFA RID: 187386
		[Token(Token = "0x402DBFA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020059C1 RID: 22977
		[Token(Token = "0x20059C1")]
		[Serializable]
		public class PointStyle
		{
			// Token: 0x060217DD RID: 137181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60217DD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PointStyle()
			{
			}

			// Token: 0x0402DBFB RID: 187387
			[Token(Token = "0x402DBFB")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform pointRt;

			// Token: 0x0402DBFC RID: 187388
			[Token(Token = "0x402DBFC")]
			[FieldOffset(Offset = "0x18")]
			public Image imgSquareUnselect;

			// Token: 0x0402DBFD RID: 187389
			[Token(Token = "0x402DBFD")]
			[FieldOffset(Offset = "0x20")]
			public Image imgSquareSelect;

			// Token: 0x0402DBFE RID: 187390
			[Token(Token = "0x402DBFE")]
			[FieldOffset(Offset = "0x28")]
			public Image imgCircleUnselect;

			// Token: 0x0402DBFF RID: 187391
			[Token(Token = "0x402DBFF")]
			[FieldOffset(Offset = "0x30")]
			public Image imgCircleSelect;
		}
	}
}
