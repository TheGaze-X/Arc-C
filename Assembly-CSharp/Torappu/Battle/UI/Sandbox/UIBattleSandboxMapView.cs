using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033B1 RID: 13233
	[Token(Token = "0x20033B1")]
	public class UIBattleSandboxMapView : MonoBehaviour
	{
		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x060151E0 RID: 86496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700321E")]
		public GridLayoutGroup mapTileRoot
		{
			[Token(Token = "0x60151E0")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x060151E1 RID: 86497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151E1")]
		[Address(RVA = "0xD91BC0", Offset = "0xD907C0", VA = "0x180D91BC0")]
		private void _GenerataOffset(LevelData data, List<Rect> hiddens)
		{
		}

		// Token: 0x060151E2 RID: 86498 RVA: 0x0008A6C0 File Offset: 0x000888C0
		[Token(Token = "0x60151E2")]
		[Address(RVA = "0xD912F0", Offset = "0xD8FEF0", VA = "0x180D912F0")]
		public int GetLeftOffset()
		{
			return 0;
		}

		// Token: 0x060151E3 RID: 86499 RVA: 0x0008A6D8 File Offset: 0x000888D8
		[Token(Token = "0x60151E3")]
		[Address(RVA = "0xD91340", Offset = "0xD8FF40", VA = "0x180D91340")]
		public int GetRightOffset()
		{
			return 0;
		}

		// Token: 0x060151E4 RID: 86500 RVA: 0x0008A6F0 File Offset: 0x000888F0
		[Token(Token = "0x60151E4")]
		[Address(RVA = "0xD91390", Offset = "0xD8FF90", VA = "0x180D91390")]
		public int GetUpOffset()
		{
			return 0;
		}

		// Token: 0x060151E5 RID: 86501 RVA: 0x0008A708 File Offset: 0x00088908
		[Token(Token = "0x60151E5")]
		[Address(RVA = "0xD912A0", Offset = "0xD8FEA0", VA = "0x180D912A0")]
		public int GetBottomOffset()
		{
			return 0;
		}

		// Token: 0x060151E6 RID: 86502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151E6")]
		[Address(RVA = "0xD926B0", Offset = "0xD912B0", VA = "0x180D926B0")]
		private void _PrepareList(int width, int height)
		{
		}

		// Token: 0x060151E7 RID: 86503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151E7")]
		[Address(RVA = "0xD91FE0", Offset = "0xD90BE0", VA = "0x180D91FE0")]
		private void _GenerateOutLine(List<List<bool>> lists, bool isVertical, float offset)
		{
		}

		// Token: 0x060151E8 RID: 86504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151E8")]
		[Address(RVA = "0xD913E0", Offset = "0xD8FFE0", VA = "0x180D913E0")]
		public void Render(LevelData data, Color lowLandColor, Color highlandColor, bool needGenerateOutLine = false)
		{
		}

		// Token: 0x060151E9 RID: 86505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151E9")]
		[Address(RVA = "0xD92C50", Offset = "0xD91850", VA = "0x180D92C50")]
		public UIBattleSandboxMapView()
		{
		}

		// Token: 0x0401929F RID: 103071
		[Token(Token = "0x401929F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("GameObject refs")]
		private UIAtlasImage _tile;

		// Token: 0x040192A0 RID: 103072
		[Token(Token = "0x40192A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("GameObject refs")]
		private GameObject _emptyTile;

		// Token: 0x040192A1 RID: 103073
		[Token(Token = "0x40192A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("GameObject refs")]
		private GameObject _warning;

		// Token: 0x040192A2 RID: 103074
		[Token(Token = "0x40192A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("GameObject refs")]
		private GameObject _OutLine;

		// Token: 0x040192A3 RID: 103075
		[Token(Token = "0x40192A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("GameObject refs")]
		private GridLayoutGroup _mapTileRoot;

		// Token: 0x040192A4 RID: 103076
		[Token(Token = "0x40192A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("GameObject refs")]
		private Transform _outLineRoot;

		// Token: 0x040192A5 RID: 103077
		[Token(Token = "0x40192A5")]
		[FieldOffset(Offset = "0x48")]
		private List<List<bool>> m_haveUpperOutLine;

		// Token: 0x040192A6 RID: 103078
		[Token(Token = "0x40192A6")]
		[FieldOffset(Offset = "0x50")]
		private List<List<bool>> m_haveBottomOutLine;

		// Token: 0x040192A7 RID: 103079
		[Token(Token = "0x40192A7")]
		[FieldOffset(Offset = "0x58")]
		private List<List<bool>> m_haveLeftOutLine;

		// Token: 0x040192A8 RID: 103080
		[Token(Token = "0x40192A8")]
		[FieldOffset(Offset = "0x60")]
		private List<List<bool>> m_haveRightOutLine;

		// Token: 0x040192A9 RID: 103081
		[Token(Token = "0x40192A9")]
		[FieldOffset(Offset = "0x68")]
		private int m_horizonNum;

		// Token: 0x040192AA RID: 103082
		[Token(Token = "0x40192AA")]
		[FieldOffset(Offset = "0x6C")]
		private int m_verticalNum;

		// Token: 0x040192AB RID: 103083
		[Token(Token = "0x40192AB")]
		[FieldOffset(Offset = "0x70")]
		private List<int> m_verticalOffset;

		// Token: 0x040192AC RID: 103084
		[Token(Token = "0x40192AC")]
		[FieldOffset(Offset = "0x78")]
		private List<int> m_horizontalOffset;
	}
}
