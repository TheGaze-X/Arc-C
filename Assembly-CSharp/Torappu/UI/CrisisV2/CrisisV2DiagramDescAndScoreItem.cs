using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200591A RID: 22810
	[Token(Token = "0x200591A")]
	public class CrisisV2DiagramDescAndScoreItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060213E2 RID: 136162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213E2")]
		[Address(RVA = "0x1B8E100", Offset = "0x1B8CD00", VA = "0x181B8E100")]
		public void SetDescAndIcon(string desc, string iconName)
		{
		}

		// Token: 0x060213E3 RID: 136163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213E3")]
		[Address(RVA = "0x1B8DE80", Offset = "0x1B8CA80", VA = "0x181B8DE80")]
		public void RenderScore(CrisisV2DiagramDescAndScoreItem.DescAndScoreInput input)
		{
		}

		// Token: 0x060213E4 RID: 136164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213E4")]
		[Address(RVA = "0x1B8E2A0", Offset = "0x1B8CEA0", VA = "0x181B8E2A0")]
		public CrisisV2DiagramDescAndScoreItem()
		{
		}

		// Token: 0x0402D458 RID: 185432
		[Token(Token = "0x402D458")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _score;

		// Token: 0x0402D459 RID: 185433
		[Token(Token = "0x402D459")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402D45A RID: 185434
		[Token(Token = "0x402D45A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _icon;

		// Token: 0x0402D45B RID: 185435
		[Token(Token = "0x402D45B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402D45C RID: 185436
		[Token(Token = "0x402D45C")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_scoreTween;

		// Token: 0x0402D45D RID: 185437
		[Token(Token = "0x402D45D")]
		[FieldOffset(Offset = "0x40")]
		private int m_score;

		// Token: 0x0402D45E RID: 185438
		[Token(Token = "0x402D45E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetDescAndIcon;

		// Token: 0x0402D45F RID: 185439
		[Token(Token = "0x402D45F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderScore;

		// Token: 0x0402D460 RID: 185440
		[Token(Token = "0x402D460")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200591B RID: 22811
		[Token(Token = "0x200591B")]
		public struct DescAndScoreInput
		{
			// Token: 0x0402D461 RID: 185441
			[Token(Token = "0x402D461")]
			[FieldOffset(Offset = "0x0")]
			public int score;

			// Token: 0x0402D462 RID: 185442
			[Token(Token = "0x402D462")]
			[FieldOffset(Offset = "0x4")]
			public bool needTween;

			// Token: 0x0402D463 RID: 185443
			[Token(Token = "0x402D463")]
			[FieldOffset(Offset = "0x8")]
			public CrisisV2DiagramInput.TweenInput tweenInput;
		}
	}
}
