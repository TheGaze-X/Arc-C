using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059C2 RID: 22978
	[Token(Token = "0x20059C2")]
	public class CrisisV2MapRoadView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060217DE RID: 137182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217DE")]
		[Address(RVA = "0x1BD6880", Offset = "0x1BD5480", VA = "0x181BD6880")]
		public void Init(CrisisV2RoadPosData roadPosData)
		{
		}

		// Token: 0x060217DF RID: 137183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217DF")]
		[Address(RVA = "0x1BD6A10", Offset = "0x1BD5610", VA = "0x181BD6A10")]
		public void Render(CrisisV2MapRoadModel roadModel, CrisisV2MapRoadStatus roadStatus)
		{
		}

		// Token: 0x060217E0 RID: 137184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217E0")]
		[Address(RVA = "0x1BD7160", Offset = "0x1BD5D60", VA = "0x181BD7160")]
		private void _SetPosAndSize(CrisisV2RoadPosData roadPosData)
		{
		}

		// Token: 0x060217E1 RID: 137185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217E1")]
		[Address(RVA = "0x1BD6DD0", Offset = "0x1BD59D0", VA = "0x181BD6DD0")]
		private void _PlayColorTweenIfNeed(CrisisV2MapRoadStatus roadStatus, bool skipTween)
		{
		}

		// Token: 0x060217E2 RID: 137186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60217E2")]
		[Address(RVA = "0x1BD6C00", Offset = "0x1BD5800", VA = "0x181BD6C00")]
		private Tween _GetColorTween(MaskableGraphic targetImg, Color targetColor)
		{
			return null;
		}

		// Token: 0x060217E3 RID: 137187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217E3")]
		[Address(RVA = "0x1BD72A0", Offset = "0x1BD5EA0", VA = "0x181BD72A0")]
		public CrisisV2MapRoadView()
		{
		}

		// Token: 0x0402DC00 RID: 187392
		[Token(Token = "0x402DC00")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CrisisV2MapRoad _road;

		// Token: 0x0402DC01 RID: 187393
		[Token(Token = "0x402DC01")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0402DC02 RID: 187394
		[Token(Token = "0x402DC02")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorSelect;

		// Token: 0x0402DC03 RID: 187395
		[Token(Token = "0x402DC03")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _colorTweenDuration;

		// Token: 0x0402DC04 RID: 187396
		[Token(Token = "0x402DC04")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Material _matDisableRoad;

		// Token: 0x0402DC05 RID: 187397
		[Token(Token = "0x402DC05")]
		private const int MAP_LINE_WIDTH = 9;

		// Token: 0x0402DC06 RID: 187398
		[Token(Token = "0x402DC06")]
		[FieldOffset(Offset = "0x50")]
		private bool m_firstRender;

		// Token: 0x0402DC07 RID: 187399
		[Token(Token = "0x402DC07")]
		[FieldOffset(Offset = "0x58")]
		private Sequence m_sequence;

		// Token: 0x0402DC08 RID: 187400
		[Token(Token = "0x402DC08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402DC09 RID: 187401
		[Token(Token = "0x402DC09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DC0A RID: 187402
		[Token(Token = "0x402DC0A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetPosAndSize;

		// Token: 0x0402DC0B RID: 187403
		[Token(Token = "0x402DC0B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayColorTweenIfNeed;

		// Token: 0x0402DC0C RID: 187404
		[Token(Token = "0x402DC0C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetColorTween;

		// Token: 0x0402DC0D RID: 187405
		[Token(Token = "0x402DC0D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
