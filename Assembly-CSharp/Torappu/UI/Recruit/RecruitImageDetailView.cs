using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004743 RID: 18243
	[Token(Token = "0x2004743")]
	public class RecruitImageDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA32 RID: 113202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA32")]
		[Address(RVA = "0x1504090", Offset = "0x1502C90", VA = "0x181504090")]
		public void Render(RecruitImageDetailView.RecruitImageObjectInput input)
		{
		}

		// Token: 0x0601BA33 RID: 113203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA33")]
		[Address(RVA = "0x1504160", Offset = "0x1502D60", VA = "0x181504160")]
		public RecruitImageDetailView()
		{
		}

		// Token: 0x04023DA0 RID: 146848
		[Token(Token = "0x4023DA0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIDynImage _image;

		// Token: 0x04023DA1 RID: 146849
		[Token(Token = "0x4023DA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023DA2 RID: 146850
		[Token(Token = "0x4023DA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004744 RID: 18244
		[Token(Token = "0x2004744")]
		public struct RecruitImageObjectInput
		{
			// Token: 0x04023DA3 RID: 146851
			[Token(Token = "0x4023DA3")]
			[FieldOffset(Offset = "0x0")]
			public GachaDetailData.GachaImageType imageType;
		}
	}
}
