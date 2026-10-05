using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007417 RID: 29719
	[Token(Token = "0x2007417")]
	public class Act3D0CampSelectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F60 RID: 171872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F60")]
		[Address(RVA = "0x2585990", Offset = "0x2584590", VA = "0x182585990")]
		public void Render(string actId)
		{
		}

		// Token: 0x06029F61 RID: 171873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F61")]
		[Address(RVA = "0x2585C60", Offset = "0x2584860", VA = "0x182585C60")]
		public void ShowSelectResult()
		{
		}

		// Token: 0x06029F62 RID: 171874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029F62")]
		[Address(RVA = "0x2585DA0", Offset = "0x25849A0", VA = "0x182585DA0")]
		private IEnumerator _SelectResultEffectCoroutine()
		{
			return null;
		}

		// Token: 0x06029F63 RID: 171875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F63")]
		[Address(RVA = "0x2585E50", Offset = "0x2584A50", VA = "0x182585E50")]
		private void _TriggerCampBGMPreview(string campId)
		{
		}

		// Token: 0x06029F64 RID: 171876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F64")]
		[Address(RVA = "0x2585710", Offset = "0x2584310", VA = "0x182585710")]
		public void EventOnCampButtonClicked(string campId)
		{
		}

		// Token: 0x06029F65 RID: 171877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F65")]
		[Address(RVA = "0x2585FB0", Offset = "0x2584BB0", VA = "0x182585FB0")]
		public Act3D0CampSelectView()
		{
		}

		// Token: 0x0403C26A RID: 246378
		[Token(Token = "0x403C26A")]
		private const string CAMP_BGM_PREVIEW_SUFFIX = "_climax";

		// Token: 0x0403C26B RID: 246379
		[Token(Token = "0x403C26B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act3D0CampDetailView _detailView;

		// Token: 0x0403C26C RID: 246380
		[Token(Token = "0x403C26C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectView;

		// Token: 0x0403C26D RID: 246381
		[Token(Token = "0x403C26D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act3D0CampSelectResultView _resultView;

		// Token: 0x0403C26E RID: 246382
		[Token(Token = "0x403C26E")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_selectViewTween;

		// Token: 0x0403C26F RID: 246383
		[Token(Token = "0x403C26F")]
		[FieldOffset(Offset = "0x38")]
		private Act3D0CampGroupViewModel m_campGroupModel;

		// Token: 0x0403C270 RID: 246384
		[Token(Token = "0x403C270")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string> onCampSelected;

		// Token: 0x0403C271 RID: 246385
		[Token(Token = "0x403C271")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action onCampResultConfirmed;

		// Token: 0x0403C272 RID: 246386
		[Token(Token = "0x403C272")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C273 RID: 246387
		[Token(Token = "0x403C273")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowSelectResult;

		// Token: 0x0403C274 RID: 246388
		[Token(Token = "0x403C274")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SelectResultEffectCoroutine;

		// Token: 0x0403C275 RID: 246389
		[Token(Token = "0x403C275")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TriggerCampBGMPreview;

		// Token: 0x0403C276 RID: 246390
		[Token(Token = "0x403C276")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCampButtonClicked;

		// Token: 0x0403C277 RID: 246391
		[Token(Token = "0x403C277")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
