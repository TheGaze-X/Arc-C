using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E86 RID: 16006
	[Token(Token = "0x2003E86")]
	public class SpecialOperatorBoardEvolveFeatureView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018DE4 RID: 101860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DE4")]
		[Address(RVA = "0x1185E00", Offset = "0x1184A00", VA = "0x181185E00")]
		public void Render(SpecialOperatorBoardEvolveNodeViewModel.Feature feature)
		{
		}

		// Token: 0x06018DE5 RID: 101861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DE5")]
		[Address(RVA = "0x1185ED0", Offset = "0x1184AD0", VA = "0x181185ED0")]
		public SpecialOperatorBoardEvolveFeatureView()
		{
		}

		// Token: 0x0401EA07 RID: 125447
		[Token(Token = "0x401EA07")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textFeature;

		// Token: 0x0401EA08 RID: 125448
		[Token(Token = "0x401EA08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EA09 RID: 125449
		[Token(Token = "0x401EA09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
