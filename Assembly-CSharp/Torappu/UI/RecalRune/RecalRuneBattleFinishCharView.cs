using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047A0 RID: 18336
	[Token(Token = "0x20047A0")]
	public class RecalRuneBattleFinishCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BC5F RID: 113759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC5F")]
		[Address(RVA = "0x152AC60", Offset = "0x1529860", VA = "0x18152AC60")]
		public void Render(SquadItemStruct item, bool isAssist)
		{
		}

		// Token: 0x0601BC60 RID: 113760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC60")]
		[Address(RVA = "0x152B230", Offset = "0x1529E30", VA = "0x18152B230")]
		private void _RenderPotential(int potentialRank)
		{
		}

		// Token: 0x0601BC61 RID: 113761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC61")]
		[Address(RVA = "0x152B190", Offset = "0x1529D90", VA = "0x18152B190")]
		private void _RenderEvolve(EvolvePhase evolvePhase)
		{
		}

		// Token: 0x0601BC62 RID: 113762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC62")]
		[Address(RVA = "0x152B2E0", Offset = "0x1529EE0", VA = "0x18152B2E0")]
		private void _RenderSkill(CharacterCardViewModel model)
		{
		}

		// Token: 0x0601BC63 RID: 113763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC63")]
		[Address(RVA = "0x152AF60", Offset = "0x1529B60", VA = "0x18152AF60")]
		private void _RenderEquip(CharacterCardViewModel model)
		{
		}

		// Token: 0x0601BC64 RID: 113764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC64")]
		[Address(RVA = "0x152B530", Offset = "0x152A130", VA = "0x18152B530")]
		public RecalRuneBattleFinishCharView()
		{
		}

		// Token: 0x0402418A RID: 147850
		[Token(Token = "0x402418A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _portraitImage;

		// Token: 0x0402418B RID: 147851
		[Token(Token = "0x402418B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _assistPanel;

		// Token: 0x0402418C RID: 147852
		[Token(Token = "0x402418C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _potentialImage;

		// Token: 0x0402418D RID: 147853
		[Token(Token = "0x402418D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _evolveImage;

		// Token: 0x0402418E RID: 147854
		[Token(Token = "0x402418E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x0402418F RID: 147855
		[Token(Token = "0x402418F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _skillValidVariant;

		// Token: 0x04024190 RID: 147856
		[Token(Token = "0x4024190")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _skillInvalidVariant;

		// Token: 0x04024191 RID: 147857
		[Token(Token = "0x4024191")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _skillImage;

		// Token: 0x04024192 RID: 147858
		[Token(Token = "0x4024192")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _skillLevelText;

		// Token: 0x04024193 RID: 147859
		[Token(Token = "0x4024193")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _skillSpecializationLevelImage;

		// Token: 0x04024194 RID: 147860
		[Token(Token = "0x4024194")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _equipValidVariant;

		// Token: 0x04024195 RID: 147861
		[Token(Token = "0x4024195")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _equipInvalidVariant;

		// Token: 0x04024196 RID: 147862
		[Token(Token = "0x4024196")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _equipImage;

		// Token: 0x04024197 RID: 147863
		[Token(Token = "0x4024197")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _equipLevelPart;

		// Token: 0x04024198 RID: 147864
		[Token(Token = "0x4024198")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _equipLevelText;

		// Token: 0x04024199 RID: 147865
		[Token(Token = "0x4024199")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402419A RID: 147866
		[Token(Token = "0x402419A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderPotential;

		// Token: 0x0402419B RID: 147867
		[Token(Token = "0x402419B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderEvolve;

		// Token: 0x0402419C RID: 147868
		[Token(Token = "0x402419C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderSkill;

		// Token: 0x0402419D RID: 147869
		[Token(Token = "0x402419D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderEquip;

		// Token: 0x0402419E RID: 147870
		[Token(Token = "0x402419E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
