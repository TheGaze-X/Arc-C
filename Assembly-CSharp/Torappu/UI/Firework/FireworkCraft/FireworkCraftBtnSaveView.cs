using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E82 RID: 20098
	[Token(Token = "0x2004E82")]
	public class FireworkCraftBtnSaveView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DFE0 RID: 122848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFE0")]
		[Address(RVA = "0x179CE90", Offset = "0x179BA90", VA = "0x18179CE90")]
		public void Render(FireworkPlateGroupModel groupModel, FireworkPlateGroupViewStyle style, string currAnimalId)
		{
		}

		// Token: 0x0601DFE1 RID: 122849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFE1")]
		[Address(RVA = "0x179D360", Offset = "0x179BF60", VA = "0x18179D360")]
		public FireworkCraftBtnSaveView()
		{
		}

		// Token: 0x04027D6C RID: 163180
		[Token(Token = "0x4027D6C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _btnSaveShowAnim;

		// Token: 0x04027D6D RID: 163181
		[Token(Token = "0x4027D6D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _btnSaveLoopAnim;

		// Token: 0x04027D6E RID: 163182
		[Token(Token = "0x4027D6E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgBtnSave;

		// Token: 0x04027D6F RID: 163183
		[Token(Token = "0x4027D6F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgCircleBack;

		// Token: 0x04027D70 RID: 163184
		[Token(Token = "0x4027D70")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgCircleFront;

		// Token: 0x04027D71 RID: 163185
		[Token(Token = "0x4027D71")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgCircleDec;

		// Token: 0x04027D72 RID: 163186
		[Token(Token = "0x4027D72")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_showTween;

		// Token: 0x04027D73 RID: 163187
		[Token(Token = "0x4027D73")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_loopTween;

		// Token: 0x04027D74 RID: 163188
		[Token(Token = "0x4027D74")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027D75 RID: 163189
		[Token(Token = "0x4027D75")]
		[FieldOffset(Offset = "0x78")]
		private int m_cachedLoadSeqNum;

		// Token: 0x04027D76 RID: 163190
		[Token(Token = "0x4027D76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027D77 RID: 163191
		[Token(Token = "0x4027D77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
