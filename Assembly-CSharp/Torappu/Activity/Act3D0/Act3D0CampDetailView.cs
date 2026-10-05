using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007410 RID: 29712
	[Token(Token = "0x2007410")]
	public class Act3D0CampDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F48 RID: 171848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F48")]
		[Address(RVA = "0x2583890", Offset = "0x2582490", VA = "0x182583890")]
		public void Open(Act3D0CampViewModel campModel)
		{
		}

		// Token: 0x06029F49 RID: 171849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029F49")]
		[Address(RVA = "0x25836C0", Offset = "0x25822C0", VA = "0x1825836C0")]
		public IEnumerator CloseCoroutine()
		{
			return null;
		}

		// Token: 0x06029F4A RID: 171850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F4A")]
		[Address(RVA = "0x2583940", Offset = "0x2582540", VA = "0x182583940")]
		private void _Render()
		{
		}

		// Token: 0x06029F4B RID: 171851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F4B")]
		[Address(RVA = "0x2583810", Offset = "0x2582410", VA = "0x182583810")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x06029F4C RID: 171852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F4C")]
		[Address(RVA = "0x2583770", Offset = "0x2582370", VA = "0x182583770")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x06029F4D RID: 171853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F4D")]
		[Address(RVA = "0x2583B80", Offset = "0x2582780", VA = "0x182583B80")]
		public Act3D0CampDetailView()
		{
		}

		// Token: 0x0403C23D RID: 246333
		[Token(Token = "0x403C23D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _floatPanel;

		// Token: 0x0403C23E RID: 246334
		[Token(Token = "0x403C23E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act3D0CampDetailView.CampImage[] _campImages;

		// Token: 0x0403C23F RID: 246335
		[Token(Token = "0x403C23F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403C240 RID: 246336
		[Token(Token = "0x403C240")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCampDesc;

		// Token: 0x0403C241 RID: 246337
		[Token(Token = "0x403C241")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textRewardDesc;

		// Token: 0x0403C242 RID: 246338
		[Token(Token = "0x403C242")]
		[FieldOffset(Offset = "0x40")]
		private Act3D0CampViewModel m_campModel;

		// Token: 0x0403C243 RID: 246339
		[Token(Token = "0x403C243")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onCampConfirmed;

		// Token: 0x0403C244 RID: 246340
		[Token(Token = "0x403C244")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action onCampCancelled;

		// Token: 0x0403C245 RID: 246341
		[Token(Token = "0x403C245")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Open;

		// Token: 0x0403C246 RID: 246342
		[Token(Token = "0x403C246")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CloseCoroutine;

		// Token: 0x0403C247 RID: 246343
		[Token(Token = "0x403C247")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403C248 RID: 246344
		[Token(Token = "0x403C248")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0403C249 RID: 246345
		[Token(Token = "0x403C249")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x0403C24A RID: 246346
		[Token(Token = "0x403C24A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007411 RID: 29713
		[Token(Token = "0x2007411")]
		[Serializable]
		private struct CampImage
		{
			// Token: 0x0403C24B RID: 246347
			[Token(Token = "0x403C24B")]
			[FieldOffset(Offset = "0x0")]
			public string campId;

			// Token: 0x0403C24C RID: 246348
			[Token(Token = "0x403C24C")]
			[FieldOffset(Offset = "0x8")]
			public Image image;
		}
	}
}
