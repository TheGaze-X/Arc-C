using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006705 RID: 26373
	[Token(Token = "0x2006705")]
	public class HandBookV2MapGroupLogoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025D9B RID: 155035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D9B")]
		[Address(RVA = "0x20DFE80", Offset = "0x20DEA80", VA = "0x1820DFE80")]
		public void RenderForce(HandBookV2GroupForceViewModel forceViewModel)
		{
		}

		// Token: 0x06025D9C RID: 155036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D9C")]
		[Address(RVA = "0x20E0460", Offset = "0x20DF060", VA = "0x1820E0460")]
		public HandBookV2MapGroupLogoView()
		{
		}

		// Token: 0x04035371 RID: 217969
		[Token(Token = "0x4035371")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _logoImg;

		// Token: 0x04035372 RID: 217970
		[Token(Token = "0x4035372")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _forceName;

		// Token: 0x04035373 RID: 217971
		[Token(Token = "0x4035373")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _forceTotalCount;

		// Token: 0x04035374 RID: 217972
		[Token(Token = "0x4035374")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _colorBar;

		// Token: 0x04035375 RID: 217973
		[Token(Token = "0x4035375")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _logoImg2;

		// Token: 0x04035376 RID: 217974
		[Token(Token = "0x4035376")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _forceName2;

		// Token: 0x04035377 RID: 217975
		[Token(Token = "0x4035377")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _forceTotalCount2;

		// Token: 0x04035378 RID: 217976
		[Token(Token = "0x4035378")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _colorBar2;

		// Token: 0x04035379 RID: 217977
		[Token(Token = "0x4035379")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _upPart;

		// Token: 0x0403537A RID: 217978
		[Token(Token = "0x403537A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _downPart;

		// Token: 0x0403537B RID: 217979
		[Token(Token = "0x403537B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _downRightLine;

		// Token: 0x0403537C RID: 217980
		[Token(Token = "0x403537C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _upLeftLine;

		// Token: 0x0403537D RID: 217981
		[Token(Token = "0x403537D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _upRightLine;

		// Token: 0x0403537E RID: 217982
		[Token(Token = "0x403537E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _downLeftLine;

		// Token: 0x0403537F RID: 217983
		[Token(Token = "0x403537F")]
		[FieldOffset(Offset = "0x88")]
		private HandBookV2GroupForceViewModel m_forceViewModel;

		// Token: 0x04035380 RID: 217984
		[Token(Token = "0x4035380")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderForce;

		// Token: 0x04035381 RID: 217985
		[Token(Token = "0x4035381")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
