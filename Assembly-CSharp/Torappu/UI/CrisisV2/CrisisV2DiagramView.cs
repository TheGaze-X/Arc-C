using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005927 RID: 22823
	[Token(Token = "0x2005927")]
	public class CrisisV2DiagramView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060213F7 RID: 136183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213F7")]
		[Address(RVA = "0x1B8EC70", Offset = "0x1B8D870", VA = "0x181B8EC70")]
		public void Render(CrisisV2DiagramInput input)
		{
		}

		// Token: 0x060213F8 RID: 136184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213F8")]
		[Address(RVA = "0x1B8EF80", Offset = "0x1B8DB80", VA = "0x181B8EF80")]
		public void ResetDiagram()
		{
		}

		// Token: 0x060213F9 RID: 136185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213F9")]
		[Address(RVA = "0x1B8EB90", Offset = "0x1B8D790", VA = "0x181B8EB90")]
		public void PlayBattleSettleEnterAnim()
		{
		}

		// Token: 0x060213FA RID: 136186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213FA")]
		[Address(RVA = "0x1B8EC00", Offset = "0x1B8D800", VA = "0x181B8EC00")]
		public void PlayBattleSettleNewRecordAnim()
		{
		}

		// Token: 0x060213FB RID: 136187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213FB")]
		[Address(RVA = "0x1B8EB30", Offset = "0x1B8D730", VA = "0x181B8EB30")]
		public void OnDestroy()
		{
		}

		// Token: 0x060213FC RID: 136188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213FC")]
		[Address(RVA = "0x1B8F610", Offset = "0x1B8E210", VA = "0x181B8F610")]
		private void _InitIfNot(CrisisV2DiagramInput.StyleConfig styleConfig)
		{
		}

		// Token: 0x060213FD RID: 136189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213FD")]
		[Address(RVA = "0x1B8F4E0", Offset = "0x1B8E0E0", VA = "0x181B8F4E0")]
		private string _GetDescIconId(CrisisV2DiagramInput.DescAndScoreStyle style, int index)
		{
			return null;
		}

		// Token: 0x060213FE RID: 136190 RVA: 0x000B9208 File Offset: 0x000B7408
		[Token(Token = "0x60213FE")]
		[Address(RVA = "0x1B8F210", Offset = "0x1B8DE10", VA = "0x181B8F210")]
		private CrisisV2DiagramDimensionItem.DimensionInput _GenerateDimensionInput(CrisisV2DiagramInput diagramInput, int index)
		{
			return default(CrisisV2DiagramDimensionItem.DimensionInput);
		}

		// Token: 0x060213FF RID: 136191 RVA: 0x000B9220 File Offset: 0x000B7420
		[Token(Token = "0x60213FF")]
		[Address(RVA = "0x1B8F080", Offset = "0x1B8DC80", VA = "0x181B8F080")]
		private CrisisV2DiagramDescAndScoreItem.DescAndScoreInput _GenerateDescAndScoreInput(CrisisV2DiagramInput diagramInput, int index)
		{
			return default(CrisisV2DiagramDescAndScoreItem.DescAndScoreInput);
		}

		// Token: 0x06021400 RID: 136192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021400")]
		[Address(RVA = "0x1B8FCF0", Offset = "0x1B8E8F0", VA = "0x181B8FCF0")]
		private void _StopAnim()
		{
		}

		// Token: 0x06021401 RID: 136193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021401")]
		[Address(RVA = "0x1B8FBF0", Offset = "0x1B8E7F0", VA = "0x181B8FBF0")]
		private void _PlayDiagramAnim(UIAnimationLocation anim)
		{
		}

		// Token: 0x06021402 RID: 136194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021402")]
		[Address(RVA = "0x1B8FD90", Offset = "0x1B8E990", VA = "0x181B8FD90")]
		public CrisisV2DiagramView()
		{
		}

		// Token: 0x0402D4B2 RID: 185522
		[Token(Token = "0x402D4B2")]
		private const string DIAGRAM_ICON_ACHIEVE_FORMAT = "diagram_icon_achieve_{0}";

		// Token: 0x0402D4B3 RID: 185523
		[Token(Token = "0x402D4B3")]
		private const string DIAGRAM_ICON_BATTLE_SETTLE_FORMAT = "diagram_icon_battle_settle_{0}";

		// Token: 0x0402D4B4 RID: 185524
		[Token(Token = "0x402D4B4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CrisisV2DiagramBgScoreHolder> _bgScoreHolders;

		// Token: 0x0402D4B5 RID: 185525
		[Token(Token = "0x402D4B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CrisisV2DiagramDimensionItem> _dimensions;

		// Token: 0x0402D4B6 RID: 185526
		[Token(Token = "0x402D4B6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIScaler _dimensionPartScaler;

		// Token: 0x0402D4B7 RID: 185527
		[Token(Token = "0x402D4B7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _battleSettleEnterAnim;

		// Token: 0x0402D4B8 RID: 185528
		[Token(Token = "0x402D4B8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _battleSettleNewRecordAnim;

		// Token: 0x0402D4B9 RID: 185529
		[Token(Token = "0x402D4B9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<RectTransform> _splitLines;

		// Token: 0x0402D4BA RID: 185530
		[Token(Token = "0x402D4BA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _splitLineMinWidth;

		// Token: 0x0402D4BB RID: 185531
		[Token(Token = "0x402D4BB")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _currentHeightDelta;

		// Token: 0x0402D4BC RID: 185532
		[Token(Token = "0x402D4BC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _baseHeightDelta;

		// Token: 0x0402D4BD RID: 185533
		[Token(Token = "0x402D4BD")]
		[FieldOffset(Offset = "0x64")]
		private bool m_hasInited;

		// Token: 0x0402D4BE RID: 185534
		[Token(Token = "0x402D4BE")]
		[FieldOffset(Offset = "0x68")]
		private List<CrisisV2DiagramDescAndScoreItem> m_descAndScoreItems;

		// Token: 0x0402D4BF RID: 185535
		[Token(Token = "0x402D4BF")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_animTween;

		// Token: 0x0402D4C0 RID: 185536
		[Token(Token = "0x402D4C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D4C1 RID: 185537
		[Token(Token = "0x402D4C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetDiagram;

		// Token: 0x0402D4C2 RID: 185538
		[Token(Token = "0x402D4C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayBattleSettleEnterAnim;

		// Token: 0x0402D4C3 RID: 185539
		[Token(Token = "0x402D4C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayBattleSettleNewRecordAnim;

		// Token: 0x0402D4C4 RID: 185540
		[Token(Token = "0x402D4C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402D4C5 RID: 185541
		[Token(Token = "0x402D4C5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D4C6 RID: 185542
		[Token(Token = "0x402D4C6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetDescIconId;

		// Token: 0x0402D4C7 RID: 185543
		[Token(Token = "0x402D4C7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateDimensionInput;

		// Token: 0x0402D4C8 RID: 185544
		[Token(Token = "0x402D4C8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateDescAndScoreInput;

		// Token: 0x0402D4C9 RID: 185545
		[Token(Token = "0x402D4C9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__StopAnim;

		// Token: 0x0402D4CA RID: 185546
		[Token(Token = "0x402D4CA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayDiagramAnim;

		// Token: 0x0402D4CB RID: 185547
		[Token(Token = "0x402D4CB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
