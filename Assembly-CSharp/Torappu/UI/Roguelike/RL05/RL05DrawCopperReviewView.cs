using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200558A RID: 21898
	[Token(Token = "0x200558A")]
	public class RL05DrawCopperReviewView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060202B2 RID: 131762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202B2")]
		[Address(RVA = "0x1A4FE70", Offset = "0x1A4EA70", VA = "0x181A4FE70")]
		public void Render(RoguelikeDrawCopperViewModel model, ILoadAsset assetLoader)
		{
		}

		// Token: 0x060202B3 RID: 131763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202B3")]
		[Address(RVA = "0x1A50400", Offset = "0x1A4F000", VA = "0x181A50400")]
		private void _PlayShowTween()
		{
		}

		// Token: 0x060202B4 RID: 131764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202B4")]
		[Address(RVA = "0x1A50250", Offset = "0x1A4EE50", VA = "0x181A50250")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060202B5 RID: 131765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202B5")]
		[Address(RVA = "0x1A50510", Offset = "0x1A4F110", VA = "0x181A50510")]
		public RL05DrawCopperReviewView()
		{
		}

		// Token: 0x0402B76A RID: 178026
		[Token(Token = "0x402B76A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _grpContent;

		// Token: 0x0402B76B RID: 178027
		[Token(Token = "0x402B76B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _ptnContent;

		// Token: 0x0402B76C RID: 178028
		[Token(Token = "0x402B76C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _showAnimLocation;

		// Token: 0x0402B76D RID: 178029
		[Token(Token = "0x402B76D")]
		[FieldOffset(Offset = "0x38")]
		private RL05DrawCopperReviewView.CopperGrpAdapter m_adapter;

		// Token: 0x0402B76E RID: 178030
		[Token(Token = "0x402B76E")]
		[FieldOffset(Offset = "0x40")]
		private RL05DrawCopperReviewView.CopperGrpPtnAdapter m_ptnAdapter;

		// Token: 0x0402B76F RID: 178031
		[Token(Token = "0x402B76F")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0402B770 RID: 178032
		[Token(Token = "0x402B770")]
		[FieldOffset(Offset = "0x50")]
		private List<RoguelikePlayerCopperItemViewModel> copperList;

		// Token: 0x0402B771 RID: 178033
		[Token(Token = "0x402B771")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tween;

		// Token: 0x0402B772 RID: 178034
		[Token(Token = "0x402B772")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B773 RID: 178035
		[Token(Token = "0x402B773")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayShowTween;

		// Token: 0x0402B774 RID: 178036
		[Token(Token = "0x402B774")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B775 RID: 178037
		[Token(Token = "0x402B775")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200558B RID: 21899
		[Token(Token = "0x200558B")]
		public class CopperGrpAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004B78 RID: 19320
			// (get) Token: 0x060202B6 RID: 131766 RVA: 0x000B4DC8 File Offset: 0x000B2FC8
			[Token(Token = "0x17004B78")]
			public override int count
			{
				[Token(Token = "0x60202B6")]
				[Address(RVA = "0x1A48390", Offset = "0x1A46F90", VA = "0x181A48390", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060202B7 RID: 131767 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60202B7")]
			[Address(RVA = "0x1A48190", Offset = "0x1A46D90", VA = "0x181A48190", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060202B8 RID: 131768 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60202B8")]
			[Address(RVA = "0x1A48330", Offset = "0x1A46F30", VA = "0x181A48330")]
			public CopperGrpAdapter()
			{
			}

			// Token: 0x0402B776 RID: 178038
			[Token(Token = "0x402B776")]
			[FieldOffset(Offset = "0x20")]
			public List<RoguelikePlayerCopperItemViewModel> dataSource;

			// Token: 0x0402B777 RID: 178039
			[Token(Token = "0x402B777")]
			[FieldOffset(Offset = "0x28")]
			public ILoadAsset assetLoader;

			// Token: 0x0402B778 RID: 178040
			[Token(Token = "0x402B778")]
			[FieldOffset(Offset = "0x30")]
			public string topicId;

			// Token: 0x0402B779 RID: 178041
			[Token(Token = "0x402B779")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402B77A RID: 178042
			[Token(Token = "0x402B77A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402B77B RID: 178043
			[Token(Token = "0x402B77B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200558C RID: 21900
		[Token(Token = "0x200558C")]
		public class CopperGrpPtnAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004B79 RID: 19321
			// (get) Token: 0x060202B9 RID: 131769 RVA: 0x000B4DE0 File Offset: 0x000B2FE0
			[Token(Token = "0x17004B79")]
			public override int count
			{
				[Token(Token = "0x60202B9")]
				[Address(RVA = "0x1A48650", Offset = "0x1A47250", VA = "0x181A48650", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060202BA RID: 131770 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60202BA")]
			[Address(RVA = "0x1A48420", Offset = "0x1A47020", VA = "0x181A48420", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060202BB RID: 131771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60202BB")]
			[Address(RVA = "0x1A485F0", Offset = "0x1A471F0", VA = "0x181A485F0")]
			public CopperGrpPtnAdapter()
			{
			}

			// Token: 0x0402B77C RID: 178044
			[Token(Token = "0x402B77C")]
			[FieldOffset(Offset = "0x20")]
			public List<RoguelikePlayerCopperItemViewModel> dataSource;

			// Token: 0x0402B77D RID: 178045
			[Token(Token = "0x402B77D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402B77E RID: 178046
			[Token(Token = "0x402B77E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402B77F RID: 178047
			[Token(Token = "0x402B77F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
