using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005587 RID: 21895
	[Token(Token = "0x2005587")]
	public class RL05DrawCopperGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060202AC RID: 131756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202AC")]
		[Address(RVA = "0x1A4F700", Offset = "0x1A4E300", VA = "0x181A4F700")]
		public void Render(List<RoguelikePlayerCopperItemViewModel> copperItemModels, string topicId, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x060202AD RID: 131757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202AD")]
		[Address(RVA = "0x1A4F5C0", Offset = "0x1A4E1C0", VA = "0x181A4F5C0")]
		public void PlayShowTween()
		{
		}

		// Token: 0x060202AE RID: 131758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202AE")]
		[Address(RVA = "0x1A4F950", Offset = "0x1A4E550", VA = "0x181A4F950")]
		public RL05DrawCopperGroupView()
		{
		}

		// Token: 0x0402B75C RID: 178012
		[Token(Token = "0x402B75C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RL05DrawCopperGroupView.CopperIconGroup> _copperItemIconGroupList;

		// Token: 0x0402B75D RID: 178013
		[Token(Token = "0x402B75D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _showAnimLocation;

		// Token: 0x0402B75E RID: 178014
		[Token(Token = "0x402B75E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _rootObj;

		// Token: 0x0402B75F RID: 178015
		[Token(Token = "0x402B75F")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_showTween;

		// Token: 0x0402B760 RID: 178016
		[Token(Token = "0x402B760")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B761 RID: 178017
		[Token(Token = "0x402B761")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayShowTween;

		// Token: 0x0402B762 RID: 178018
		[Token(Token = "0x402B762")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005588 RID: 21896
		[Token(Token = "0x2005588")]
		[Serializable]
		public class CopperIconGroup
		{
			// Token: 0x060202AF RID: 131759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60202AF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CopperIconGroup()
			{
			}

			// Token: 0x0402B763 RID: 178019
			[Token(Token = "0x402B763")]
			[FieldOffset(Offset = "0x10")]
			public Image copperIcon;

			// Token: 0x0402B764 RID: 178020
			[Token(Token = "0x402B764")]
			[FieldOffset(Offset = "0x18")]
			public Image copperLuckyIcon;
		}
	}
}
