using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x0200484A RID: 18506
	[Token(Token = "0x200484A")]
	public class MissionArchiveNodeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x0601BF48 RID: 114504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004266")]
		public string nodeId
		{
			[Token(Token = "0x601BF48")]
			[Address(RVA = "0x1551910", Offset = "0x1550510", VA = "0x181551910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x0601BF49 RID: 114505 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF4A RID: 114506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004267")]
		public Action<string> selectEvent
		{
			[Token(Token = "0x601BF49")]
			[Address(RVA = "0x1551970", Offset = "0x1550570", VA = "0x181551970")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF4A")]
			[Address(RVA = "0x15519D0", Offset = "0x15505D0", VA = "0x1815519D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BF4B RID: 114507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF4B")]
		[Address(RVA = "0x1551290", Offset = "0x154FE90", VA = "0x181551290")]
		public void OnSelectEvent()
		{
		}

		// Token: 0x0601BF4C RID: 114508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF4C")]
		[Address(RVA = "0x1551490", Offset = "0x1550090", VA = "0x181551490")]
		public void Render(MissionArchiveNodeViewModel model)
		{
		}

		// Token: 0x0601BF4D RID: 114509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF4D")]
		[Address(RVA = "0x15513A0", Offset = "0x154FFA0", VA = "0x1815513A0")]
		public Tween PlaySelect()
		{
			return null;
		}

		// Token: 0x0601BF4E RID: 114510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF4E")]
		[Address(RVA = "0x1551710", Offset = "0x1550310", VA = "0x181551710")]
		public void ResetSelect()
		{
		}

		// Token: 0x0601BF4F RID: 114511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF4F")]
		[Address(RVA = "0x1551790", Offset = "0x1550390", VA = "0x181551790")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BF50 RID: 114512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF50")]
		[Address(RVA = "0x15518B0", Offset = "0x15504B0", VA = "0x1815518B0")]
		public MissionArchiveNodeView()
		{
		}

		// Token: 0x04024745 RID: 149317
		[Token(Token = "0x4024745")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _nodeId;

		// Token: 0x04024746 RID: 149318
		[Token(Token = "0x4024746")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _selectAnimation;

		// Token: 0x04024747 RID: 149319
		[Token(Token = "0x4024747")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _lockedPanels;

		// Token: 0x04024748 RID: 149320
		[Token(Token = "0x4024748")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _notLockedPanels;

		// Token: 0x04024749 RID: 149321
		[Token(Token = "0x4024749")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _unlockedPanels;

		// Token: 0x0402474A RID: 149322
		[Token(Token = "0x402474A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject[] _notUnlockedPanels;

		// Token: 0x0402474B RID: 149323
		[Token(Token = "0x402474B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject[] _claimedPanels;

		// Token: 0x0402474C RID: 149324
		[Token(Token = "0x402474C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _nodeTitleText;

		// Token: 0x0402474D RID: 149325
		[Token(Token = "0x402474D")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0402474E RID: 149326
		[Token(Token = "0x402474E")]
		[FieldOffset(Offset = "0x68")]
		private AnimationWrapper m_animationWrapper;

		// Token: 0x0402474F RID: 149327
		[Token(Token = "0x402474F")]
		[FieldOffset(Offset = "0x70")]
		private UIAnimationTween.Builder m_selectTweenBuilder;

		// Token: 0x04024750 RID: 149328
		[Token(Token = "0x4024750")]
		[FieldOffset(Offset = "0x98")]
		private UIAnimationTween m_selectTween;

		// Token: 0x04024752 RID: 149330
		[Token(Token = "0x4024752")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeId;

		// Token: 0x04024753 RID: 149331
		[Token(Token = "0x4024753")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectEvent;

		// Token: 0x04024754 RID: 149332
		[Token(Token = "0x4024754")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_selectEvent;

		// Token: 0x04024755 RID: 149333
		[Token(Token = "0x4024755")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSelectEvent;

		// Token: 0x04024756 RID: 149334
		[Token(Token = "0x4024756")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024757 RID: 149335
		[Token(Token = "0x4024757")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlaySelect;

		// Token: 0x04024758 RID: 149336
		[Token(Token = "0x4024758")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ResetSelect;

		// Token: 0x04024759 RID: 149337
		[Token(Token = "0x4024759")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402475A RID: 149338
		[Token(Token = "0x402475A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
