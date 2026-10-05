using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007413 RID: 29715
	[Token(Token = "0x2007413")]
	public class Act3D0CampSelectResultView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F54 RID: 171860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F54")]
		[Address(RVA = "0x2583FE0", Offset = "0x2582BE0", VA = "0x182583FE0")]
		private void Start()
		{
		}

		// Token: 0x06029F55 RID: 171861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029F55")]
		[Address(RVA = "0x2583F30", Offset = "0x2582B30", VA = "0x182583F30")]
		public IEnumerator StartEffectCoroutine()
		{
			return null;
		}

		// Token: 0x06029F56 RID: 171862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F56")]
		[Address(RVA = "0x2584340", Offset = "0x2582F40", VA = "0x182584340")]
		private void _RenderContent(string campId)
		{
		}

		// Token: 0x06029F57 RID: 171863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F57")]
		[Address(RVA = "0x2584060", Offset = "0x2582C60", VA = "0x182584060")]
		private void _LoadCampRes(string campId)
		{
		}

		// Token: 0x06029F58 RID: 171864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F58")]
		[Address(RVA = "0x2583EB0", Offset = "0x2582AB0", VA = "0x182583EB0")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x06029F59 RID: 171865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F59")]
		[Address(RVA = "0x2584540", Offset = "0x2583140", VA = "0x182584540")]
		public Act3D0CampSelectResultView()
		{
		}

		// Token: 0x0403C250 RID: 246352
		[Token(Token = "0x403C250")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIColorGraphic _colorTheme;

		// Token: 0x0403C251 RID: 246353
		[Token(Token = "0x403C251")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act3D0CampSelectResultView.CampColor[] _campColors;

		// Token: 0x0403C252 RID: 246354
		[Token(Token = "0x403C252")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act3D0CampSelectResultView.CampGameObject[] _campNameImgs;

		// Token: 0x0403C253 RID: 246355
		[Token(Token = "0x403C253")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCampLeft;

		// Token: 0x0403C254 RID: 246356
		[Token(Token = "0x403C254")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgBox;

		// Token: 0x0403C255 RID: 246357
		[Token(Token = "0x403C255")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgBoxShadow;

		// Token: 0x0403C256 RID: 246358
		[Token(Token = "0x403C256")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textCampName;

		// Token: 0x0403C257 RID: 246359
		[Token(Token = "0x403C257")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _effectAnim;

		// Token: 0x0403C258 RID: 246360
		[Token(Token = "0x403C258")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isEffectStart;

		// Token: 0x0403C259 RID: 246361
		[Token(Token = "0x403C259")]
		[FieldOffset(Offset = "0x61")]
		private bool m_isEffectFinish;

		// Token: 0x0403C25A RID: 246362
		[Token(Token = "0x403C25A")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action onResultConfirmed;

		// Token: 0x0403C25B RID: 246363
		[Token(Token = "0x403C25B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0403C25C RID: 246364
		[Token(Token = "0x403C25C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StartEffectCoroutine;

		// Token: 0x0403C25D RID: 246365
		[Token(Token = "0x403C25D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderContent;

		// Token: 0x0403C25E RID: 246366
		[Token(Token = "0x403C25E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadCampRes;

		// Token: 0x0403C25F RID: 246367
		[Token(Token = "0x403C25F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0403C260 RID: 246368
		[Token(Token = "0x403C260")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007414 RID: 29716
		[Token(Token = "0x2007414")]
		[Serializable]
		private struct CampColor
		{
			// Token: 0x0403C261 RID: 246369
			[Token(Token = "0x403C261")]
			[FieldOffset(Offset = "0x0")]
			public string campId;

			// Token: 0x0403C262 RID: 246370
			[Token(Token = "0x403C262")]
			[FieldOffset(Offset = "0x8")]
			public Color color;
		}

		// Token: 0x02007415 RID: 29717
		[Token(Token = "0x2007415")]
		[Serializable]
		private struct CampGameObject
		{
			// Token: 0x0403C263 RID: 246371
			[Token(Token = "0x403C263")]
			[FieldOffset(Offset = "0x0")]
			public string campId;

			// Token: 0x0403C264 RID: 246372
			[Token(Token = "0x403C264")]
			[FieldOffset(Offset = "0x8")]
			public GameObject gameObject;
		}
	}
}
