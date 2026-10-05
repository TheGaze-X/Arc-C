using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004185 RID: 16773
	[Token(Token = "0x2004185")]
	public class SandboxV2DungeonCrossDayApItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019E14 RID: 106004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E14")]
		[Address(RVA = "0x12BE980", Offset = "0x12BD580", VA = "0x1812BE980")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019E15 RID: 106005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E15")]
		[Address(RVA = "0x12BE810", Offset = "0x12BD410", VA = "0x1812BE810")]
		public void Render(bool isFill)
		{
		}

		// Token: 0x06019E16 RID: 106006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E16")]
		[Address(RVA = "0x12BEA60", Offset = "0x12BD660", VA = "0x1812BEA60")]
		public SandboxV2DungeonCrossDayApItemView()
		{
		}

		// Token: 0x04020882 RID: 133250
		[Token(Token = "0x4020882")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04020883 RID: 133251
		[Token(Token = "0x4020883")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objFillDot;

		// Token: 0x04020884 RID: 133252
		[Token(Token = "0x4020884")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objUnFillDot;

		// Token: 0x04020885 RID: 133253
		[Token(Token = "0x4020885")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_tween;

		// Token: 0x04020886 RID: 133254
		[Token(Token = "0x4020886")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04020887 RID: 133255
		[Token(Token = "0x4020887")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020888 RID: 133256
		[Token(Token = "0x4020888")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020889 RID: 133257
		[Token(Token = "0x4020889")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
