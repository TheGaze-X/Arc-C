using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EF8 RID: 28408
	[Token(Token = "0x2006EF8")]
	public class ActMultiV3DifficultyIconView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060285CA RID: 165322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285CA")]
		[Address(RVA = "0x23AAC30", Offset = "0x23A9830", VA = "0x1823AAC30")]
		public void Render(ActMultiV3DifficultyIconViewModel model)
		{
		}

		// Token: 0x060285CB RID: 165323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285CB")]
		[Address(RVA = "0x23AAE20", Offset = "0x23A9A20", VA = "0x1823AAE20")]
		public void SetScale(float scale)
		{
		}

		// Token: 0x060285CC RID: 165324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285CC")]
		[Address(RVA = "0x23AAF40", Offset = "0x23A9B40", VA = "0x1823AAF40")]
		public ActMultiV3DifficultyIconView()
		{
		}

		// Token: 0x04039617 RID: 235031
		[Token(Token = "0x4039617")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _trainingNode;

		// Token: 0x04039618 RID: 235032
		[Token(Token = "0x4039618")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _ordinaryNode;

		// Token: 0x04039619 RID: 235033
		[Token(Token = "0x4039619")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _ordinaryText;

		// Token: 0x0403961A RID: 235034
		[Token(Token = "0x403961A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _difficultyNode;

		// Token: 0x0403961B RID: 235035
		[Token(Token = "0x403961B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _difficultyText;

		// Token: 0x0403961C RID: 235036
		[Token(Token = "0x403961C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _extremelyNode;

		// Token: 0x0403961D RID: 235037
		[Token(Token = "0x403961D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _extremelyText;

		// Token: 0x0403961E RID: 235038
		[Token(Token = "0x403961E")]
		[FieldOffset(Offset = "0x50")]
		private UIScaler m_scaler;

		// Token: 0x0403961F RID: 235039
		[Token(Token = "0x403961F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039620 RID: 235040
		[Token(Token = "0x4039620")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetScale;

		// Token: 0x04039621 RID: 235041
		[Token(Token = "0x4039621")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
