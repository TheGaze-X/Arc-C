using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007612 RID: 30226
	[Token(Token = "0x2007612")]
	public class Act24sideStageMapPreviewItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A8DD RID: 174301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8DD")]
		[Address(RVA = "0x2661080", Offset = "0x265FC80", VA = "0x182661080")]
		public void Render(string previewId)
		{
		}

		// Token: 0x0602A8DE RID: 174302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8DE")]
		[Address(RVA = "0x2661130", Offset = "0x265FD30", VA = "0x182661130")]
		public Act24sideStageMapPreviewItemView()
		{
		}

		// Token: 0x0403D436 RID: 250934
		[Token(Token = "0x403D436")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIDynImage _imgPreview;

		// Token: 0x0403D437 RID: 250935
		[Token(Token = "0x403D437")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D438 RID: 250936
		[Token(Token = "0x403D438")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
