using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DBD RID: 28093
	[Token(Token = "0x2006DBD")]
	public class ActVecBreakV2AchvCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027FFB RID: 163835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FFB")]
		[Address(RVA = "0x2344470", Offset = "0x2343070", VA = "0x182344470")]
		public void Render(ActVecBreakV2AchvSquadItemModel squadItem)
		{
		}

		// Token: 0x06027FFC RID: 163836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FFC")]
		[Address(RVA = "0x23446C0", Offset = "0x23432C0", VA = "0x1823446C0")]
		public ActVecBreakV2AchvCharItemView()
		{
		}

		// Token: 0x04038B5B RID: 232283
		[Token(Token = "0x4038B5B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _viewRootGO;

		// Token: 0x04038B5C RID: 232284
		[Token(Token = "0x4038B5C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyPartGO;

		// Token: 0x04038B5D RID: 232285
		[Token(Token = "0x4038B5D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPartGO;

		// Token: 0x04038B5E RID: 232286
		[Token(Token = "0x4038B5E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalCharBgGO;

		// Token: 0x04038B5F RID: 232287
		[Token(Token = "0x4038B5F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _assistCharBgGO;

		// Token: 0x04038B60 RID: 232288
		[Token(Token = "0x4038B60")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _assistIconGO;

		// Token: 0x04038B61 RID: 232289
		[Token(Token = "0x4038B61")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CommonCharCardView _charCardView;

		// Token: 0x04038B62 RID: 232290
		[Token(Token = "0x4038B62")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _potentialGo;

		// Token: 0x04038B63 RID: 232291
		[Token(Token = "0x4038B63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038B64 RID: 232292
		[Token(Token = "0x4038B64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
